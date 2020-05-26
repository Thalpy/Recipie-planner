using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Recipie_planner
{

  
    public partial class Form1 : Form
    {
        public List<Recipie> RecipieList = new List<Recipie>();
        public List<string> ListyReci = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DebugCheck_CheckedChanged(object sender, EventArgs e)
        {
            DebugBox.Visible ^= true;
            DebugBox.AppendText("Debug toggled");
            DebugBox.AppendText(Environment.NewLine);
        }


        private void NewDatabase_Click(object sender, EventArgs e) //sets up a new database
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddRecipieButton_Click(object sender, EventArgs e)
        {
            //Check to see if input exists
            if (String.IsNullOrEmpty(RecipieNameInput.Text))
            {
                RecipieNameInput.Text = "Please input name!";
                return;
            }

            if (String.IsNullOrEmpty(IngredientsInput.Text))
            {
                IngredientsInput.Text = "Please input Ingredients!";
                return;
            }

            if (String.IsNullOrEmpty(StepInput.Text))
            {
                StepInput.Text = "Please input cooking steps!";
                return;
            }

            DebugBox.AppendText($"{RecipieNameInput.Text}, {IngredientsInput.Text}, {StepInput.Text}, {Convert.ToInt32(DaysInput.Value)}, {Convert.ToInt32(CookingTimeInput.Value)}");
            DebugBox.AppendText(Environment.NewLine);

            //If we've input, take that input and add it to the list!
            AddRecipie(RecipieNameInput.Text, IngredientsInput.Text, StepInput.Text, Convert.ToInt32(DaysInput.Value), Convert.ToInt32(CookingTimeInput.Value));
            RecipieNameInput.Text = null;
            IngredientsInput.Text = null;
            StepInput.Text = null;
            UpdateRecipies();
        }

    //}
    //public class dataStruc
    //{
        //public List<Recipie> RecipieList;


        public void UpdateRecipies()
        {
            DataTable dt = new DataTable();

            dt = ConvertListToDataTable();
            RecipieData.DataSource = dt;
            RecipieData.Columns[0].Width = 90;
            RecipieData.Columns[2].Width = 320;
            RecipieData.Columns[3].Width = 50;
            RecipieData.Columns[4].Width = 70;
            RecipieData.Columns[5].Width = 50;
            RecipieData.Update();
            RecipieData.Refresh();
            DebugPrint($"RecipieList: {RecipieList}");
        }

        public DataTable ConvertListToDataTable()
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            // Add columns.


            table.Columns.Add("Recipe", typeof(string));
            table.Columns.Add("Ingredients", typeof(string));
            table.Columns.Add("Steps", typeof(string));
            table.Columns.Add("Days", typeof(string));
            table.Columns.Add("Cooking Time", typeof(string));
            table.Columns.Add("Active", typeof(bool));


            // Add rows.
            foreach (var recipe in RecipieList)
            {
                DebugPrint("Adding recipie!");
                string ingString = null;
                foreach (Ingredient ingredient in recipe.RecipieIngredient) { ingString = ($"{ingredient.Amount}g {ingredient.IngredientName}"); }
                table.Rows.Add(recipe.RecipieName, ingString, recipe.Steps, recipe.Days, recipe.CookingTime, false);
            }

            return table;
        }

        public void AddRecipie(string rName, string rawIngre, string rawStep, int rDays, int rCTime)
        {
            List<String> iList = new List<string>();
            List<float> iAmount = new List<float>();

            string t_iL = null;
            float t_iA = 0;
            string units = null;

            //Split based on newlines
            String[] lines = rawIngre.Split(new String[] { Environment.NewLine }, StringSplitOptions.None);

            //each LINE
            foreach (string line in lines)
            {
                units = FindUnits(line);

                //each LETTER
                for (int j = 0; j < line.Length; j++)
                {
                    DebugBox.Text += $"{line[j]}";
                    if (Char.IsDigit(line[j])) //Is this selection a number?
                    {
                        //Add the numeric
                        t_iA += line[j];

                        //If there's a number next, then we need to multiply this value by 10
                        if (Char.IsDigit(line[j + 1]))
                        {
                            t_iA *= 10;
                        }
                    }
                    //Since people use cups, we need to watch out for fractions
                    else if (Char.ToString(line[j]) == "/")
                    {
                        t_iA = t_iA / line[j + 1];
                        j++;
                        continue;

                    }

                    //Otherwise add text to the text temp
                    else
                    {
                        t_iL += line[j];
                    }
                }


                //End of line clear
                //If there were no numbers found
                if (t_iA <= 0)
                {
                    iAmount.Add(1);
                }
                //If numbers are present, then add the number to the list.
                else
                    DebugPrint($"Attempting to print t_iA {t_iA}");
                    t_iA = ConvertUnits(t_iA, units);
                    iAmount.Add(t_iA);

                //Add letters to list and reset temp vars
                iList.Add(t_iL);
                t_iL = null;
                t_iA = 0;

            }
            //Finally we're done with data manlip

            //(string name, List<string> ingredients, List<float> iAmount, string steps, int days, int ctime)
            //rName, string rawIngre, string rawStep, int rDays, int rCTime
            RecipieList.Add(new Recipie(rName, iList, iAmount, rawStep, rDays, rCTime));

        }

        public string FindUnits(string phrase) //trys to find what units are used
        {
            string[] units = { "tbsp", "cup", "tsp", "oz", "kg" };
            foreach (string unit in units)
                if (phrase.Contains(unit)) { return (unit);}
            return ("g");
        }

        public float ConvertUnits(float amount, string type) //Converts numerics into grams
        {
            //I'll do moles later
            switch (type) {
                case "kg":
                    return (amount * 1000);

                case "tbsp":
                    return (amount * 15);

                case "cup":
                    return (amount * 128);

                case "tsp":
                    return (amount * 5);

                case "oz":
                    return (amount * 28);

                case "g":
                    return (amount);
            }

            return (amount);
        }
        //Convert formats to correct ones

        public void DebugPrint(string text)
        {
            DebugBox.AppendText($"{text}");
            DebugBox.AppendText(Environment.NewLine);
            Console.WriteLine($"{text}");
        }

    }
}


public class Recipie
{
    public string RecipieName;
    //var test = new List<Ingredient>();
    //public RecipieIngredient = new List<Ingredient>;
    public List<Ingredient> RecipieIngredient = new List<Ingredient>();
    public string Steps;
    public int Days;
    public int CookingTime;
    public bool UserSelected = false;

    public Recipie(string name, List<string> req_ingredients, List<float> _iAmount, string steps, int days, int ctime)
    {
        Console.WriteLine($"Attempting to setup Recipie object _i:{req_ingredients}, _iA:{_iAmount}");
        RecipieName = name;
        for (int i = 0; i < req_ingredients.Count; i++)
        {
            Console.WriteLine($"loop {i}");
            RecipieIngredient.Add(new Ingredient(req_ingredients[i], _iAmount[i]));
            /*RecipieIngredient.Add(new Ingredient());
            RecipieIngredient[i].Amount = _iAmount[i];
            RecipieIngredient[i].IngredientName = req_ingredients[i];*/
        }

        Steps = steps;
        Days = days;
        CookingTime = ctime;
    }

}

public class Ingredient
{
    public string IngredientName;
    public float Amount;
    int SpoilTime;

    public Ingredient()
    {
        IngredientName = "air";
        Amount = 0;
        SpoilTime = 0;
    }

    public Ingredient(string name, float amount)
    {
        IngredientName = name;
        Amount = amount;
        SpoilTime = 0;
    }

}
