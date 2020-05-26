namespace Recipie_planner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewDatabase = new System.Windows.Forms.Button();
            this.LoadDatabase = new System.Windows.Forms.Button();
            this.IngredientsInput = new System.Windows.Forms.TextBox();
            this.RecipieData = new System.Windows.Forms.DataGridView();
            this.AddRecipieButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.FromCalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.StepInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ToCalendar = new System.Windows.Forms.MonthCalendar();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DebugCheck = new System.Windows.Forms.CheckBox();
            this.databaseStatus = new System.Windows.Forms.Label();
            this.DebugBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DaysInput = new System.Windows.Forms.NumericUpDown();
            this.CookingTimeInput = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RecipieNameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RecipieData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CookingTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewDatabase
            // 
            this.NewDatabase.Location = new System.Drawing.Point(12, 12);
            this.NewDatabase.Name = "NewDatabase";
            this.NewDatabase.Size = new System.Drawing.Size(177, 38);
            this.NewDatabase.TabIndex = 1;
            this.NewDatabase.Text = "New Database";
            this.NewDatabase.UseVisualStyleBackColor = true;
            this.NewDatabase.Click += new System.EventHandler(this.NewDatabase_Click);
            // 
            // LoadDatabase
            // 
            this.LoadDatabase.Location = new System.Drawing.Point(195, 12);
            this.LoadDatabase.Name = "LoadDatabase";
            this.LoadDatabase.Size = new System.Drawing.Size(177, 38);
            this.LoadDatabase.TabIndex = 2;
            this.LoadDatabase.Text = "Load Database";
            this.LoadDatabase.UseVisualStyleBackColor = true;
            this.LoadDatabase.Click += new System.EventHandler(this.button3_Click);
            // 
            // IngredientsInput
            // 
            this.IngredientsInput.AcceptsReturn = true;
            this.IngredientsInput.AcceptsTab = true;
            this.IngredientsInput.Location = new System.Drawing.Point(12, 103);
            this.IngredientsInput.Multiline = true;
            this.IngredientsInput.Name = "IngredientsInput";
            this.IngredientsInput.Size = new System.Drawing.Size(296, 147);
            this.IngredientsInput.TabIndex = 5;
            // 
            // RecipieData
            // 
            this.RecipieData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipieData.Location = new System.Drawing.Point(12, 277);
            this.RecipieData.Name = "RecipieData";
            this.RecipieData.Size = new System.Drawing.Size(790, 267);
            this.RecipieData.TabIndex = 6;
            // 
            // AddRecipieButton
            // 
            this.AddRecipieButton.Location = new System.Drawing.Point(625, 212);
            this.AddRecipieButton.Name = "AddRecipieButton";
            this.AddRecipieButton.Size = new System.Drawing.Size(177, 38);
            this.AddRecipieButton.TabIndex = 7;
            this.AddRecipieButton.Text = "Add recipie";
            this.AddRecipieButton.UseVisualStyleBackColor = true;
            this.AddRecipieButton.Click += new System.EventHandler(this.AddRecipieButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingredients";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Recipie database";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(307, 750);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(177, 38);
            this.GenerateButton.TabIndex = 10;
            this.GenerateButton.Text = "Generate ";
            this.GenerateButton.UseVisualStyleBackColor = true;
            // 
            // FromCalendar
            // 
            this.FromCalendar.Location = new System.Drawing.Point(12, 576);
            this.FromCalendar.Name = "FromCalendar";
            this.FromCalendar.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Steps";
            // 
            // StepInput
            // 
            this.StepInput.AcceptsReturn = true;
            this.StepInput.AcceptsTab = true;
            this.StepInput.Location = new System.Drawing.Point(323, 103);
            this.StepInput.Multiline = true;
            this.StepInput.Name = "StepInput";
            this.StepInput.Size = new System.Drawing.Size(285, 147);
            this.StepInput.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "From:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "To:";
            // 
            // ToCalendar
            // 
            this.ToCalendar.Location = new System.Drawing.Point(257, 576);
            this.ToCalendar.Name = "ToCalendar";
            this.ToCalendar.TabIndex = 15;
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(12, 768);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(289, 20);
            this.EmailBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 750);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Email (Optional):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // DebugCheck
            // 
            this.DebugCheck.AutoSize = true;
            this.DebugCheck.Checked = true;
            this.DebugCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DebugCheck.Location = new System.Drawing.Point(496, 554);
            this.DebugCheck.Name = "DebugCheck";
            this.DebugCheck.Size = new System.Drawing.Size(58, 17);
            this.DebugCheck.TabIndex = 19;
            this.DebugCheck.Text = "Debug";
            this.DebugCheck.UseVisualStyleBackColor = true;
            this.DebugCheck.CheckedChanged += new System.EventHandler(this.DebugCheck_CheckedChanged);
            // 
            // databaseStatus
            // 
            this.databaseStatus.AutoSize = true;
            this.databaseStatus.Location = new System.Drawing.Point(378, 25);
            this.databaseStatus.Name = "databaseStatus";
            this.databaseStatus.Size = new System.Drawing.Size(109, 13);
            this.databaseStatus.TabIndex = 20;
            this.databaseStatus.Text = "No database loaded!!";
            // 
            // DebugBox
            // 
            this.DebugBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.DebugBox.Font = new System.Drawing.Font("Lucida Console", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DebugBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.DebugBox.Location = new System.Drawing.Point(490, 577);
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.Size = new System.Drawing.Size(312, 211);
            this.DebugBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(631, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Days of food";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(724, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cooking time";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // DaysInput
            // 
            this.DaysInput.Location = new System.Drawing.Point(644, 186);
            this.DaysInput.Name = "DaysInput";
            this.DaysInput.Size = new System.Drawing.Size(43, 20);
            this.DaysInput.TabIndex = 26;
            // 
            // CookingTimeInput
            // 
            this.CookingTimeInput.Location = new System.Drawing.Point(737, 185);
            this.CookingTimeInput.Name = "CookingTimeInput";
            this.CookingTimeInput.Size = new System.Drawing.Size(43, 20);
            this.CookingTimeInput.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Recipie_planner.Properties.Resources.SRainbowPear;
            this.pictureBox1.InitialImage = global::Recipie_planner.Properties.Resources.SRainbowPear;
            this.pictureBox1.Location = new System.Drawing.Point(625, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Name of recipie:";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // RecipieNameInput
            // 
            this.RecipieNameInput.Location = new System.Drawing.Point(101, 61);
            this.RecipieNameInput.Name = "RecipieNameInput";
            this.RecipieNameInput.Size = new System.Drawing.Size(212, 20);
            this.RecipieNameInput.TabIndex = 30;
            this.RecipieNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 796);
            this.Controls.Add(this.RecipieNameInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CookingTimeInput);
            this.Controls.Add(this.DaysInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.databaseStatus);
            this.Controls.Add(this.DebugCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ToCalendar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StepInput);
            this.Controls.Add(this.FromCalendar);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRecipieButton);
            this.Controls.Add(this.RecipieData);
            this.Controls.Add(this.IngredientsInput);
            this.Controls.Add(this.LoadDatabase);
            this.Controls.Add(this.NewDatabase);
            this.Name = "Form1";
            this.Text = "Weekly Recipie generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecipieData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CookingTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewDatabase;
        private System.Windows.Forms.Button LoadDatabase;
        private System.Windows.Forms.TextBox IngredientsInput;
        private System.Windows.Forms.DataGridView RecipieData;
        private System.Windows.Forms.Button AddRecipieButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.MonthCalendar FromCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StepInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar ToCalendar;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox DebugCheck;
        private System.Windows.Forms.Label databaseStatus;
        private System.Windows.Forms.TextBox DebugBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown DaysInput;
        private System.Windows.Forms.NumericUpDown CookingTimeInput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RecipieNameInput;
    }
}

