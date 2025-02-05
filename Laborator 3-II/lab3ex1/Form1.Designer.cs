namespace lab3ex1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNumeUser = new System.Windows.Forms.TextBox();
            this.textBoxOras = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelNU = new System.Windows.Forms.Label();
            this.labelOras = new System.Windows.Forms.Label();
            this.labelCodUniv = new System.Windows.Forms.Label();
            this.textBoxCodUniv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "UNIVERSITATI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Facultati";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(49, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 196);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(211, 98);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 196);
            this.listBox2.TabIndex = 3;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(358, 129);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxNumeUser
            // 
            this.textBoxNumeUser.Location = new System.Drawing.Point(358, 190);
            this.textBoxNumeUser.Name = "textBoxNumeUser";
            this.textBoxNumeUser.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumeUser.TabIndex = 5;
            // 
            // textBoxOras
            // 
            this.textBoxOras.Location = new System.Drawing.Point(358, 251);
            this.textBoxOras.Name = "textBoxOras";
            this.textBoxOras.Size = new System.Drawing.Size(100, 22);
            this.textBoxOras.TabIndex = 6;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(355, 110);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 16);
            this.labelID.TabIndex = 7;
            this.labelID.Text = "ID";
            // 
            // labelNU
            // 
            this.labelNU.AutoSize = true;
            this.labelNU.Location = new System.Drawing.Point(355, 171);
            this.labelNU.Name = "labelNU";
            this.labelNU.Size = new System.Drawing.Size(75, 16);
            this.labelNU.TabIndex = 8;
            this.labelNU.Text = "Nume User";
            this.labelNU.UseMnemonic = false;
            // 
            // labelOras
            // 
            this.labelOras.AutoSize = true;
            this.labelOras.Location = new System.Drawing.Point(355, 232);
            this.labelOras.Name = "labelOras";
            this.labelOras.Size = new System.Drawing.Size(36, 16);
            this.labelOras.TabIndex = 9;
            this.labelOras.Text = "Oras";
            // 
            // labelCodUniv
            // 
            this.labelCodUniv.AutoSize = true;
            this.labelCodUniv.Location = new System.Drawing.Point(355, 301);
            this.labelCodUniv.Name = "labelCodUniv";
            this.labelCodUniv.Size = new System.Drawing.Size(62, 16);
            this.labelCodUniv.TabIndex = 10;
            this.labelCodUniv.Text = "Cod Univ";
            // 
            // textBoxCodUniv
            // 
            this.textBoxCodUniv.Location = new System.Drawing.Point(358, 334);
            this.textBoxCodUniv.Name = "textBoxCodUniv";
            this.textBoxCodUniv.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodUniv.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "stergere";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(367, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "introducere";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(464, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(428, 234);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Code";
            this.Column2.HeaderText = "NameUniv";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NameFac";
            this.Column3.HeaderText = "NameFac";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCodUniv);
            this.Controls.Add(this.labelCodUniv);
            this.Controls.Add(this.labelOras);
            this.Controls.Add(this.labelNU);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxOras);
            this.Controls.Add(this.textBoxNumeUser);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNumeUser;
        private System.Windows.Forms.TextBox textBoxOras;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelNU;
        private System.Windows.Forms.Label labelOras;
        private System.Windows.Forms.Label labelCodUniv;
        private System.Windows.Forms.TextBox textBoxCodUniv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

