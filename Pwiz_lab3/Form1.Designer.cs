namespace Pwiz_lab3
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
            dataGridView1 = new DataGridView();
            csv = new Button();
            odczyt = new Button();
            dodaj = new Button();
            usun = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(54, 35);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(422, 207);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // csv
            // 
            csv.Location = new Point(54, 283);
            csv.Margin = new Padding(2, 2, 2, 2);
            csv.Name = "csv";
            csv.Size = new Size(144, 28);
            csv.TabIndex = 1;
            csv.Text = "Zapis do CSV";
            csv.UseVisualStyleBackColor = true;
            csv.Click += csv_Click;
            // 
            // odczyt
            // 
            odczyt.Location = new Point(335, 283);
            odczyt.Margin = new Padding(2, 2, 2, 2);
            odczyt.Name = "odczyt";
            odczyt.Size = new Size(141, 28);
            odczyt.TabIndex = 2;
            odczyt.Text = "Odczyt z CSV";
            odczyt.UseVisualStyleBackColor = true;
            odczyt.Click += odczyt_Click;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(533, 81);
            dodaj.Margin = new Padding(2, 2, 2, 2);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(78, 29);
            dodaj.TabIndex = 3;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // usun
            // 
            usun.Location = new Point(533, 182);
            usun.Margin = new Padding(2, 2, 2, 2);
            usun.Name = "usun";
            usun.Size = new Size(78, 27);
            usun.TabIndex = 4;
            usun.Text = "Usun";
            usun.UseVisualStyleBackColor = true;
            usun.Click += usun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 343);
            Controls.Add(usun);
            Controls.Add(dodaj);
            Controls.Add(odczyt);
            Controls.Add(csv);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button csv;
        private Button odczyt;
        private Button dodaj;
        private Button usun;
    }
}
