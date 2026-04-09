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
            export = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(77, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(603, 345);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // csv
            // 
            csv.Location = new Point(77, 472);
            csv.Name = "csv";
            csv.Size = new Size(206, 47);
            csv.TabIndex = 1;
            csv.Text = "Zapis do CSV";
            csv.UseVisualStyleBackColor = true;
            csv.Click += csv_Click;
            // 
            // odczyt
            // 
            odczyt.Location = new Point(479, 472);
            odczyt.Name = "odczyt";
            odczyt.Size = new Size(201, 47);
            odczyt.TabIndex = 2;
            odczyt.Text = "Odczyt z CSV";
            odczyt.UseVisualStyleBackColor = true;
            odczyt.Click += odczyt_Click;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(761, 135);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(111, 48);
            dodaj.TabIndex = 3;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // usun
            // 
            usun.Location = new Point(761, 303);
            usun.Name = "usun";
            usun.Size = new Size(111, 45);
            usun.TabIndex = 4;
            usun.Text = "Usun";
            usun.UseVisualStyleBackColor = true;
            usun.Click += usun_Click;
            // 
            // export
            // 
            export.Location = new Point(760, 472);
            export.Name = "export";
            export.Size = new Size(112, 47);
            export.TabIndex = 5;
            export.Text = "XML";
            export.UseVisualStyleBackColor = true;
            export.Click += export_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 572);
            Controls.Add(export);
            Controls.Add(usun);
            Controls.Add(dodaj);
            Controls.Add(odczyt);
            Controls.Add(csv);
            Controls.Add(dataGridView1);
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
        private Button export;
    }
}
