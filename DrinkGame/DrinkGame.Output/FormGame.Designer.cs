namespace DrinkGame.Output
{
    partial class FormGame
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DrinkGames = new System.Windows.Forms.Label();
            this.fizzBuzz = new System.Windows.Forms.RadioButton();
            this.pilorium = new System.Windows.Forms.RadioButton();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 103);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DrinkGames
            // 
            this.DrinkGames.AutoSize = true;
            this.DrinkGames.Location = new System.Drawing.Point(13, 13);
            this.DrinkGames.Name = "DrinkGames";
            this.DrinkGames.Size = new System.Drawing.Size(65, 13);
            this.DrinkGames.TabIndex = 1;
            this.DrinkGames.Text = "DrinkGames";
            this.DrinkGames.Click += new System.EventHandler(this.label1_Click);
            // 
            // fizzBuzz
            // 
            this.fizzBuzz.AutoSize = true;
            this.fizzBuzz.Location = new System.Drawing.Point(16, 40);
            this.fizzBuzz.Name = "fizzBuzz";
            this.fizzBuzz.Size = new System.Drawing.Size(69, 17);
            this.fizzBuzz.TabIndex = 2;
            this.fizzBuzz.TabStop = true;
            this.fizzBuzz.Text = "Fizz Buzz";
            this.fizzBuzz.UseVisualStyleBackColor = true;
            this.fizzBuzz.CheckedChanged += new System.EventHandler(this.fizzBuzz_CheckedChanged);
            // 
            // pilorium
            // 
            this.pilorium.AutoSize = true;
            this.pilorium.Location = new System.Drawing.Point(16, 64);
            this.pilorium.Name = "pilorium";
            this.pilorium.Size = new System.Drawing.Size(61, 17);
            this.pilorium.TabIndex = 3;
            this.pilorium.TabStop = true;
            this.pilorium.Text = "Pilorivm";
            this.pilorium.UseVisualStyleBackColor = true;
            this.pilorium.CheckedChanged += new System.EventHandler(this.pilorium_CheckedChanged);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(197, 58);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 4;
            this.submit.Text = "Go!";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.pilorium);
            this.Controls.Add(this.fizzBuzz);
            this.Controls.Add(this.DrinkGames);
            this.Controls.Add(this.listBox1);
            this.Name = "FormGame";
            this.Text = "Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label DrinkGames;
        private System.Windows.Forms.RadioButton fizzBuzz;
        private System.Windows.Forms.RadioButton pilorium;
        private System.Windows.Forms.Button submit;
    }
}

