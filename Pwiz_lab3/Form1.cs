using System.Data;
using System.Net.Sockets;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Serialization;

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

        private void LoadCSVToDataGridView(string filePath)
        {
            // SprawdŸ, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            // Tworzenie tabeli danych
            DataTable dataTable = new DataTable();
            // Dodawanie wierszy do tabeli danych
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                dataGridView1.Rows.Add(values);

            }
            MessageBox.Show(
                "Dodano Wiersze z pliku CSV.",
                "Odczyt z CSV", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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
            if (dataGridView1.SelectedRows.Count >= 1)
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
            MessageBox.Show(
                "Zapisano zawartoœæ tabeli w pliku dane.csv",
                "Zapis do CSV", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void odczyt_Click(object sender, EventArgs e)
        {
            LoadCSVToDataGridView("dane.csv");
        }

        private void export_Click(object sender, EventArgs e)

        {
            List<Person> listaOsob = new List<Person>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var imie = dataGridView1.Rows[i].Cells[0].Value;
                var nazw = dataGridView1.Rows[i].Cells[1].Value;
                var wiek = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                var stanowisko = dataGridView1.Rows[i].Cells[3].Value;
                if (imie is not null && nazw is not null && stanowisko is not null){
                    Person osoba = new Person(imie.ToString(), nazw.ToString(), wiek, stanowisko.ToString());
                    listaOsob.Add(osoba);
                }
             
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            using (TextWriter writer = new StreamWriter("dane.xml"))
            {
                serializer.Serialize(writer, listaOsob);
            }
            MessageBox.Show(
               "Zapisano zawartoœæ tabeli w pliku dane.xml",
               "Zapis do XML", MessageBoxButtons.OK,
               MessageBoxIcon.Information);

        }
    }
    }

