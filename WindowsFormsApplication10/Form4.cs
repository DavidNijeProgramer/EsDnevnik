using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace WindowsFormsApplication10
{
    public partial class Form4 : Form
    {
        int br;
        SqlConnection veza;
        DataTable tabela1, tabela2, tabela3, tabela4;
        string[] s;
        SqlCommand promena;
        public Form4()
        {
            InitializeComponent();

        }



        private void Form4_Load(object sender, EventArgs e)
        {
            tabela4 = new DataTable();
            tabela4 = Konekcija.Unos("SELECT ime + ' ' + prezime AS Ucenik FROM Osoba WHERE ULOGA = 1");
            s = new string[tabela4.Rows.Count];

            for (int i = 0; i < tabela4.Rows.Count; i++)
            {
                s[i] = Convert.ToString(tabela4.Rows[i]["Ucenik"]);
                Ime_i_prezime.Items.Add(s[i]);
            }

            tabela4 = new DataTable();
            tabela4 = Konekcija.Unos("SELECT DISTINCT naziv FROM Predmet");
            s = new string[tabela4.Rows.Count];

            for (int i = 0; i < tabela4.Rows.Count; i++)
            {
                s[i] = Convert.ToString(tabela4.Rows[i]["naziv"]);
                Predmet.Items.Add(s[i]);
            }

            Osvezi();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            panel1.Visible = false;
            button1.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Obrisi")
            {
                try
                {

                    int indeks = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                    promena = new SqlCommand();
                    promena.CommandText = ("DELETE FROM Ocena WHERE id = " + indeks);

                    SqlConnection con = new SqlConnection(Konekcija.Veza());
                    con.Open();
                    promena.Connection = con;
                    promena.ExecuteNonQuery();
                    con.Close();
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    Osvezi();

                }
                catch (Exception)
                {
                    MessageBox.Show("GRESKA");
                }
            }

            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Menjaj")
            {
                try
                {

                    promena = new SqlCommand();

                    int indeks = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    string[] ime_prezime = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Ime_i_prezime"].Value).Split(' ');
                    string datum = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Datum"].Value);
                    string raspodela = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Predmet"].Value);
                    string ocena = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Ocena"].Value);
                    string predmet = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Predmet"].Value);

                    tabela3 = new DataTable();
                    tabela3 = Konekcija.Unos("SELECT id FROM Osoba WHERE ime = " + "'" + ime_prezime[0] + "' AND prezime = " + "'" + ime_prezime[1] + "'");
                    int osoba_id = (int)tabela3.Rows[0][0];

                    tabela3 = new DataTable();
                    tabela3 = Konekcija.Unos("SELECT id FROM Predmet WHERE naziv = " + "'" + predmet + "'");
                    int predmet_id = (int)tabela3.Rows[0][0];

                    tabela3 = new DataTable();
                    tabela3 = Konekcija.Unos("SELECT id FROM Raspodela WHERE predmet_id = " + predmet_id);
                    int raspodela_id = (int)tabela3.Rows[0][0];

                    tabela3 = new DataTable();
                    tabela3 = Konekcija.Unos("SELECT * FROM Ocena WHERE datum = '" + datum + "' AND raspodela_id = " + raspodela_id + " AND ocena = '" + ocena + "' AND ucenik_id = " + osoba_id);
                    if (tabela3.Rows.Count >= 1) throw new Exception();

                    promena.CommandText = ("UPDATE Ocena SET datum = '" + datum + "' WHERE id = " + indeks +
                        " UPDATE Ocena SET raspodela_id = " + raspodela_id + " WHERE id = " + indeks +
                        " UPDATE Ocena SET ocena = '" + ocena + "' WHERE id = " + indeks +
                        " UPDATE Ocena SET ucenik_id = " + osoba_id + " WHERE id = " + indeks);

                    SqlConnection con = new SqlConnection(Konekcija.Veza());
                    con.Open();
                    promena.Connection = con;
                    promena.ExecuteNonQuery();
                    con.Close();

                    Osvezi();


                }
                catch (Exception)
                {
                    MessageBox.Show("GRESKA");
                    Osvezi();
                }
            }

            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Dodaj")
            {
                try
                {

                    promena = new SqlCommand();

                    int indeks = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    string[] ime_prezime = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Ime_i_prezime"].Value).Split(' ');
                    string datum = "";
                    if (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Datum"].Value) != "")
                    {
                        datum = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Datum"].Value);
                    }
                    string ocena = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Ocena"].Value);
                    string predmet = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Predmet"].Value);

                    if (ime_prezime[0] == "" || ime_prezime[1] == "" || predmet == "" || ocena == "") throw new Exception();

                    tabela3 = new DataTable();
                    tabela3 = Konekcija.Unos("SELECT id FROM Osoba WHERE ime = " + "'" + ime_prezime[0] + "' AND prezime = " + "'" + ime_prezime[1] + "'");
                    int osoba_id = (int)tabela3.Rows[0][0];

                    tabela3 = new DataTable();
                    tabela3 = Konekcija.Unos("SELECT id FROM Predmet WHERE naziv = " + "'" + predmet + "'");
                    int predmet_id = (int)tabela3.Rows[0][0];

                    tabela3 = new DataTable();
                    tabela3 = Konekcija.Unos("SELECT id FROM Raspodela WHERE predmet_id = " + predmet_id);
                    int raspodela_id = (int)tabela3.Rows[0][0];

                    tabela3 = new DataTable();
                    tabela3 = Konekcija.Unos("SELECT * FROM Ocena WHERE datum = '" + datum + "' AND raspodela_id = " + raspodela_id + " AND ocena = '" + ocena + "' AND ucenik_id = " + osoba_id);
                    if (tabela3.Rows.Count >= 1) throw new Exception();

                    if (datum != "")
                    {
                        promena.CommandText = ("INSERT INTO Ocena VALUES ('" + datum + "', " + raspodela_id + ", " + ocena + ", " + osoba_id + ")");
                    }
                    else
                    {
                        promena.CommandText = ("INSERT INTO Ocena (raspodela_id,ocena,ucenik_id) VALUES (" + raspodela_id + ", " + ocena + ", " + osoba_id + ")");
                    }


                    SqlConnection con = new SqlConnection(Konekcija.Veza());
                    con.Open();
                    promena.Connection = con;
                    promena.ExecuteNonQuery();
                    con.Close();

                    Osvezi();



                }
                catch (Exception)
                {
                    MessageBox.Show("GRESKA");
                    Osvezi();
                }
            }


        }



        private void Osvezi()
        {
            tabela3 = new DataTable();
            tabela3 = Konekcija.Unos("SELECT Ocena.id AS Id, datum AS Datum, Osoba.ime + ' ' + Osoba.prezime AS Ucenik, ocena AS Ocena, Predmet.naziv AS Predmet FROM Ocena\r\n JOIN Osoba ON Ocena.ucenik_id = Osoba.id\r\n JOIN Raspodela ON Raspodela.id = Ocena.raspodela_id\r\n JOIN Predmet ON Predmet.id = Raspodela.predmet_id");

            if (dataGridView1.Rows.Count != 1)
            {
                while (dataGridView1.Rows.Count != 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }

            for (int i = 0; i < tabela3.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["Id"].Value = Convert.ToString(tabela3.Rows[i]["Id"]);
                dataGridView1.Rows[i].Cells["Datum"].Value = Convert.ToString(tabela3.Rows[i]["Datum"]);
                dataGridView1.Rows[i].Cells["Ime_i_prezime"].Value = Convert.ToString(tabela3.Rows[i]["Ucenik"]);
                dataGridView1.Rows[i].Cells["Ocena"].Value = Convert.ToString(tabela3.Rows[i]["Ocena"]);
                dataGridView1.Rows[i].Cells["Predmet"].Value = Convert.ToString(tabela3.Rows[i]["Predmet"]);
            }
        
   

    }



    }

}
