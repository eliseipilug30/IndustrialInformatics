namespace Quiz_Tema_II
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxNume = new TextBox();
            textBoxParola = new TextBox();
            labelNume = new Label();
            labelParola = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBoxNume
            // 
            textBoxNume.BackColor = SystemColors.InactiveCaption;
            textBoxNume.Location = new Point(286, 81);
            textBoxNume.Name = "textBoxNume";
            textBoxNume.Size = new Size(161, 27);
            textBoxNume.TabIndex = 0;
            // 
            // textBoxParola
            // 
            textBoxParola.BackColor = SystemColors.InactiveCaption;
            textBoxParola.Location = new Point(286, 114);
            textBoxParola.Name = "textBoxParola";
            textBoxParola.Size = new Size(161, 27);
            textBoxParola.TabIndex = 1;
            // 
            // labelNume
            // 
            labelNume.AutoSize = true;
            labelNume.Location = new Point(205, 84);
            labelNume.Name = "labelNume";
            labelNume.Size = new Size(75, 20);
            labelNume.TabIndex = 2;
            labelNume.Text = "Username";
            // 
            // labelParola
            // 
            labelParola.AutoSize = true;
            labelParola.Location = new Point(210, 114);
            labelParola.Name = "labelParola";
            labelParola.Size = new Size(70, 20);
            labelParola.TabIndex = 3;
            labelParola.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(309, 174);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ControlDark;
            checkBox1.Location = new Point(551, 342);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(165, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Tine-ma autentificat";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(labelParola);
            Controls.Add(labelNume);
            Controls.Add(textBoxParola);
            Controls.Add(textBoxNume);
            Cursor = Cursors.Hand;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNume;
        private TextBox textBoxParola;
        private Label labelNume;
        private Label labelParola;
        private Button button1;
        private CheckBox checkBox1;
    }
}
