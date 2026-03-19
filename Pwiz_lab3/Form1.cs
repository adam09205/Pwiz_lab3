using System.Net.Sockets;

namespace Pwiz_lab3
{
    public partial class Form1 : Form
    {
        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            // Tworzenie nag³ówka pliku CSV
            string csvContent = "Imie,Nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            // Dodawanie danych z DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Pomijaj wiersze niemieszcz¹ce siê w DataGridView (np. wiersz zaznaczania)
                if (!row.IsNewRow)
                {
                    // Dodaj kolejne wartoœci w wierszu, oddzielone przecinkami
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            // Zapisanie zawartoœci do pliku CSV
            File.WriteAllText(filePath, csvContent);
        }
        public void dodawanie(string imie, string nazwisko, decimal wiek, string stanowisko)
        {
            dataGridView1.Rows.Add(new object[] { imie, nazwisko, wiek, stanowisko });

        }

        public Form2 form2;
        public Form1()
        {
            InitializeComponent();
            // Utworzenie kolumn
            dataGridView1.Columns.Add("Imie", "imie");
            dataGridView1.Columns.Add("Nazwisko", "nazwisko");
            dataGridView1.Columns.Add("Wiek", "wiek");
            dataGridView1.Columns.Add("Stanowisko", "stanowisko");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            form2.Show();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Nie zaznaczono elementu");
            }

        }

        private void csv_Click(object sender, EventArgs e)
        {
            //SaveFileDialog openFileDialog = new SaveFileDialog();
            //openFileDialog.ShowDialog(this);
            ExportToCSV(dataGridView1, "dane.csv");
        }
    }
}
