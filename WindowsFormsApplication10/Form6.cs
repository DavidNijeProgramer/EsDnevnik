using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection.Emit;

namespace WindowsFormsApplication10
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        DataTable tabela1, tabela2;
        SqlCommand promena;
        string[] s;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Obrisi")
            {
                try
                {
                    
                        int indeks = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);

                        promena = new SqlCommand();
                        promena.CommandText = ("DELETE FROM Raspodela WHERE id = " + indeks);

                        SqlConnection con = new SqlConnection(Konekcija.Veza());
                        con.Open();
                        promena.Connection = con;
                        promena.ExecuteNonQuery();
                        con.Close();
                        dataGridView1.Rows.RemoveAt(e.RowIndex);

                        Osvezi();
                    }
                
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA!");
                }
            }

            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Menjaj")
            {
                try
                {
                    
                        promena = new SqlCommand();

                        int indeks = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                        string[] ime_prezime = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nastavnik"].Value).Split(' ');
                        string godina = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Godina"].Value);
                        string predmet = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Predmet"].Value);
                        string[] odeljenje = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Odeljenje"].Value).Split('/');

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT id FROM Osoba WHERE ime = " + "'" + ime_prezime[0] + "' AND prezime = " + "'" + ime_prezime[1] + "'");
                        int osoba_id = (int)tabela1.Rows[0][0];

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT id FROM Skolska_godina WHERE naziv = " + "'" + godina + "'");
                        int godina_id = (int)tabela1.Rows[0][0];

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT id FROM Predmet WHERE naziv = " + "'" + predmet + "'");
                        int predmet_id = (int)tabela1.Rows[0][0];

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT id FROM Odeljenje WHERE razred = " + "'" + odeljenje[0] + "' AND indeks = " + "'" + odeljenje[1] + "'");
                        int odeljenje_id = (int)tabela1.Rows[0][0];

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT * FROM Raspodela WHERE nastavnik_id = " + osoba_id + " AND godina_id = " + godina_id + " AND predmet_id = " + predmet_id + " AND odeljenje_id = " + odeljenje_id);
                        if (tabela1.Rows.Count >= 1) throw new Exception();

                        promena.CommandText = ("UPDATE Raspodela SET nastavnik_id = " + osoba_id + " WHERE id = " + indeks +
                            " UPDATE Raspodela SET godina_id = " + godina_id + " WHERE id = " + indeks +
                            " UPDATE Raspodela SET predmet_id = " + predmet_id + " WHERE id = " + indeks +
                            " UPDATE Raspodela SET odeljenje_id = " + odeljenje_id + " WHERE id = " + indeks);

                        SqlConnection con = new SqlConnection(Konekcija.Veza());
                        con.Open();
                        promena.Connection = con;
                        promena.ExecuteNonQuery();
                        con.Close();

                        Osvezi();

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA!");
                    Osvezi();
                }
            }

            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Dodaj")
            {
                try
                {
                    
                        promena = new SqlCommand();

                        int indeks = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                        string[] ime_prezime = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nastavnik"].Value).Split(' ');
                        string godina = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Godina"].Value);
                        string predmet = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Predmet"].Value);
                        string[] odeljenje = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Odeljenje"].Value).Split('/');

                        if (ime_prezime[0] == "" || ime_prezime[1] == "" || godina == "" || predmet == "" || odeljenje[0] == "" || odeljenje[1] == "")
                            throw new Exception();

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT id FROM Osoba WHERE ime = " + "'" + ime_prezime[0] + "' AND prezime = " + "'" + ime_prezime[1] + "'");
                        int osoba_id = (int)tabela1.Rows[0][0];

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT id FROM Skolska_godina WHERE naziv = " + "'" + godina + "'");
                        int godina_id = (int)tabela1.Rows[0][0];

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT id FROM Predmet WHERE naziv = " + "'" + predmet + "'");
                        int predmet_id = (int)tabela1.Rows[0][0];

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT id FROM Odeljenje WHERE razred = " + "'" + odeljenje[0] + "' AND indeks = " + "'" + odeljenje[1] + "'");
                        int odeljenje_id = (int)tabela1.Rows[0][0];

                        tabela1 = new DataTable();
                        tabela1 = Konekcija.Unos("SELECT * FROM Raspodela WHERE nastavnik_id = " + osoba_id + " AND godina_id = " + godina_id + " AND predmet_id = " + predmet_id + " AND odeljenje_id = " + odeljenje_id);
                        if (tabela1.Rows.Count >= 1) throw new Exception();

                        promena.CommandText = ("INSERT INTO Raspodela VALUES (" + osoba_id + ", " + godina_id + ", " + predmet_id + ", " + odeljenje_id + ")");

                        SqlConnection con = new SqlConnection(Konekcija.Veza());
                        con.Open();
                        promena.Connection = con;
                        promena.ExecuteNonQuery();
                        con.Close();

                        Osvezi();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("GRESKA!");
                    Osvezi();
                }
            }
        }
        private void Osvezi()
        {
            tabela1 = new DataTable();
            tabela1 = Konekcija.Unos("SELECT raspodela.id, Osoba.ime + ' ' + Osoba.prezime AS Nastavnik, Skolska_godina.naziv AS Godina, Predmet.naziv AS Predmet, STR(Odeljenje.razred,1,0) + '/' + Odeljenje.indeks AS Odeljenje FROM Raspodela left join Osoba ON Raspodela.nastavnik_id = Osoba.id left join Skolska_godina ON Raspodela.godina_id = Skolska_godina.id left join Predmet ON Raspodela.predmet_id = Predmet.id left join Odeljenje ON Raspodela.odeljenje_id = Odeljenje.id");

            if (dataGridView1.Rows.Count != 1)
            {
                while (dataGridView1.Rows.Count != 1)
                {
                    dataGridView1.Rows.RemoveAt(0);
                }
            }

            for (int i = 0; i < tabela1.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["id"].Value = Convert.ToString(tabela1.Rows[i]["id"]);
                dataGridView1.Rows[i].Cells["Nastavnik"].Value = Convert.ToString(tabela1.Rows[i]["Nastavnik"]);
                dataGridView1.Rows[i].Cells["Godina"].Value = Convert.ToString(tabela1.Rows[i]["Godina"]);
                dataGridView1.Rows[i].Cells["Predmet"].Value = Convert.ToString(tabela1.Rows[i]["Predmet"]);
                dataGridView1.Rows[i].Cells["Odeljenje"].Value = Convert.ToString(tabela1.Rows[i]["Odeljenje"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            panel1.Visible = false;
            button1.Visible = false;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            tabela2 = new DataTable();//Dodavanje skolskih godina
            tabela2 = Konekcija.Unos("SELECT naziv FROM Skolska_godina");
            s = new string[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                s[i] = Convert.ToString(tabela2.Rows[i]["naziv"]);
                Godina.Items.Add(s[i]);
            }

            tabela2 = new DataTable();//Dodavanje nastavnika
            tabela2 = Konekcija.Unos("SELECT ime + ' ' + prezime AS Nastavnik FROM Osoba WHERE uloga = 2");
            s = new string[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                s[i] = Convert.ToString(tabela2.Rows[i]["Nastavnik"]);
                Nastavnik.Items.Add(s[i]);
            }

            tabela2 = new DataTable();//Dodavanje predmeta
            tabela2 = Konekcija.Unos("SELECT DISTINCT naziv FROM Predmet");
            s = new string[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                s[i] = Convert.ToString(tabela2.Rows[i]["naziv"]);
                Predmet.Items.Add(s[i]);
            }

            tabela2 = new DataTable();//Dodavanje odeljenja
            tabela2 = Konekcija.Unos("SELECT STR(razred,1,0) + '/' + indeks AS Odlj FROM Odeljenje");
            s = new string[tabela2.Rows.Count];

            for (int i = 0; i < tabela2.Rows.Count; i++)
            {
                s[i] = Convert.ToString(tabela2.Rows[i]["Odlj"]);
                Odeljenje.Items.Add(s[i]);
            }
            Osvezi();
        
    }
    }
}
