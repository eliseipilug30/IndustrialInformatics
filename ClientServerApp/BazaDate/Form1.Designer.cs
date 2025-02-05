namespace BazaDate
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
            btnadauga = new Button();
            label1 = new Label();
            btnsterge = new Button();
            btnafiseaza = new Button();
            btncauta = new Button();
            listBox = new ListBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnadauga
            // 
            btnadauga.Location = new Point(22, 228);
            btnadauga.Name = "btnadauga";
            btnadauga.Size = new Size(164, 29);
            btnadauga.TabIndex = 0;
            btnadauga.Text = "Adauga carte";
            btnadauga.UseVisualStyleBackColor = true;
            btnadauga.Click += btnadauga_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(471, 46);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Vizualizare";
            // 
            // btnsterge
            // 
            btnsterge.Location = new Point(22, 301);
            btnsterge.Name = "btnsterge";
            btnsterge.Size = new Size(164, 29);
            btnsterge.TabIndex = 2;
            btnsterge.Text = "Sterge carte";
            btnsterge.UseVisualStyleBackColor = true;
            btnsterge.Click += button2_Click;
            // 
            // btnafiseaza
            // 
            btnafiseaza.Location = new Point(22, 164);
            btnafiseaza.Name = "btnafiseaza";
            btnafiseaza.Size = new Size(222, 29);
            btnafiseaza.TabIndex = 3;
            btnafiseaza.Text = "Afiseaza cartile din biblioteca";
            btnafiseaza.UseVisualStyleBackColor = true;
            btnafiseaza.Click += button3_Click;
            // 
            // btncauta
            // 
            btncauta.Location = new Point(22, 373);
            btncauta.Name = "btncauta";
            btncauta.Size = new Size(164, 29);
            btncauta.TabIndex = 4;
            btncauta.Text = "Cauta dupa autor";
            btncauta.UseVisualStyleBackColor = true;
            btncauta.Click += btncauta_Click;
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.InactiveCaption;
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(471, 84);
            listBox.Name = "listBox";
            listBox.Size = new Size(256, 304);
            listBox.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.AppWorkspace;
            textBox1.Font = new Font("Segoe UI", 40F);
            textBox1.ForeColor = SystemColors.HotTrack;
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 96);
            textBox1.TabIndex = 6;
            textBox1.Text = "Welcome!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(listBox);
            Controls.Add(btncauta);
            Controls.Add(btnafiseaza);
            Controls.Add(btnsterge);
            Controls.Add(label1);
            Controls.Add(btnadauga);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnadauga;
        private Label label1;
        private Button btnsterge;
        private Button btnafiseaza;
        private Button btncauta;
        private ListBox listBox;
        private TextBox textBox1;
    }
}
