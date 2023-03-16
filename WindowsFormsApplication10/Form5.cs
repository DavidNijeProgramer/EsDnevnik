using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form5 : Form
    {
        DataTable tabela1, tabela2, tabela3,tabela4;
        SqlCommand promena;
        SqlConnection veza;
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                promena = new SqlCommand();


                string[] ime_prezime = Convert.ToString(comboBox1.Text).Split(' ');
                string[] odeljenje = Convert.ToString(comboBox2.Text).Split('/');

                if (ime_prezime[0] == "" || ime_prezime[1] == "" || odeljenje[0] == "" || odeljenje[1] == "")
                    throw new Exception();

                tabela4 = new DataTable();
                tabela4 = Konekcija.Unos("SELECT id FROM Osoba WHERE ime = " + "'" + ime_prezime[0] + "' AND prezime = " + "'" + ime_prezime[1] + "'");
                int osoba_id = (int)tabela4.Rows[0][0];

                tabela4 = new DataTable();
                tabela4 = Konekcija.Unos("SELECT id FROM Odeljenje WHERE razred = " + "'" + odeljenje[0] + "' AND indeks = " + "'" + odeljenje[1] + "'");
                int odeljenje_id = (int)tabela4.Rows[0][0];

                
                promena.CommandText = ("INSERT INTO Upisnica (osoba_id,odeljenje_id) VALUES (" + osoba_id + ", " + odeljenje_id + ")");

                SqlConnection con = new SqlConnection(Konekcija.Veza());
                con.Open();
                promena.Connection = con;
                promena.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("GRESKA!");
                Osvezi();
            }

            Osvezi();
        }

        

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            tabela1 = Konekcija.Unos("SELECT COUNT(*) FROM Osoba WHERE uloga = 1");
            int brojac = int.Parse(tabela1.Rows[0][0].ToString());
            tabela1 = Konekcija.Unos("SELECT ime + ' ' + prezime  FROM Osoba WHERE uloga = 1");
            System.Object[] ItemObject = new System.Object[brojac];
            for (int i = 0; i < brojac; i++)
            {
                ItemObject[i] = tabela1.Rows[0 + i][0].ToString();
            }
            comboBox1.Items.AddRange(ItemObject);

            tabela1 = Konekcija.Unos("SELECT COUNT(*) FROM Odeljenje");
            brojac = int.Parse(tabela1.Rows[0][0].ToString());
            tabela1 = Konekcija.Unos("SELECT CAST(razred AS VARCHAR(10)) + '/'  + indeks as ime FROM Odeljenje");
            System.Object[] ItemObject1 = new System.Object[brojac];
            for (int i = 0; i < brojac; i++)
            {
                ItemObject1[i] = tabela1.Rows[0 + i][0].ToString();
            }
            comboBox2.Items.AddRange(ItemObject1);
            Osvezi();


        }


        private void Osvezi()
        {
            tabela4 = new DataTable();
            tabela4 = Konekcija.Unos("SELECT Upisnica.id AS id, Osoba.ime + ' ' + Osoba.prezime AS 'ime i prezime', STR(Odeljenje.razred,1,0) + '/' + Odeljenje.indeks AS Odeljenje FROM Upisnica JOIN Osoba ON Upisnica.osoba_id = Osoba.id JOIN Odeljenje ON Upisnica.odeljenje_id = Odeljenje.id JOIN Smer ON Odeljenje.smer_id = Smer.id");

            

            for (int i = 0; i < tabela4.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = (tabela4.Rows[i]["id"]).ToString();
                dataGridView1.Rows[i].Cells[1].Value = Convert.ToString(tabela4.Rows[i]["ime i prezime"]);
                dataGridView1.Rows[i].Cells[2].Value = Convert.ToString(tabela4.Rows[i]["Odeljenje"]);
            }

        }
    }
}
