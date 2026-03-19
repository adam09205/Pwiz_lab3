namespace Pwiz_lab3
{
    partial class Form2
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
            imie = new TextBox();
            nazw = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            zatwierdz = new Button();
            anuluj = new Button();
            wiek = new NumericUpDown();
            stanowisko = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)wiek).BeginInit();
            SuspendLayout();
            // 
            // imie
            // 
            imie.Location = new Point(95, 53);
            imie.Name = "imie";
            imie.Size = new Size(180, 31);
            imie.TabIndex = 0;
            // 
            // nazw
            // 
            nazw.Location = new Point(95, 131);
            nazw.Name = "nazw";
            nazw.Size = new Size(180, 31);
            nazw.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(429, 59);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 4;
            label1.Text = "Imie";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 131);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 5;
            label2.Text = "Nazwisko";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 214);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 6;
            label3.Text = "Wiek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 302);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "Stanowisko";
            // 
            // zatwierdz
            // 
            zatwierdz.Location = new Point(114, 388);
            zatwierdz.Name = "zatwierdz";
            zatwierdz.Size = new Size(112, 34);
            zatwierdz.TabIndex = 8;
            zatwierdz.Text = "Zatwierdz";
            zatwierdz.UseVisualStyleBackColor = true;
            zatwierdz.Click += zatwierdz_Click;
            // 
            // anuluj
            // 
            anuluj.Location = new Point(397, 388);
            anuluj.Name = "anuluj";
            anuluj.Size = new Size(112, 34);
            anuluj.TabIndex = 9;
            anuluj.Text = "Anuluj";
            anuluj.UseVisualStyleBackColor = true;
            // 
            // wiek
            // 
            wiek.Location = new Point(93, 208);
            wiek.Name = "wiek";
            wiek.Size = new Size(182, 31);
            wiek.TabIndex = 10;
            // 
            // stanowisko
            // 
            stanowisko.FormattingEnabled = true;
            stanowisko.Items.AddRange(new object[] { "Stanowisko1", "Stanowisko2", "Stanowisko3" });
            stanowisko.Location = new Point(93, 294);
            stanowisko.Name = "stanowisko";
            stanowisko.Size = new Size(182, 33);
            stanowisko.TabIndex = 11;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 450);
            Controls.Add(stanowisko);
            Controls.Add(wiek);
            Controls.Add(anuluj);
            Controls.Add(zatwierdz);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nazw);
            Controls.Add(imie);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)wiek).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox imie;
        private TextBox nazw;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button zatwierdz;
        private Button anuluj;
        private NumericUpDown wiek;
        private ComboBox stanowisko;
    }
}