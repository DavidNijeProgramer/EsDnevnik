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
using System.Configuration;

namespace WindowsFormsApplication10
{
    public partial class Form3 : Form
    {
        DataTable tabelaodeljenja, tabelaodeljenja2, tabelaodeljenja3, tabelaodeljenja4, tabelaodeljenja5, pomocna;
        SqlCommand menjanja, pomocnaid;
        int BrVrsta;

        public Form3()
        {
            InitializeComponent();
        }
        private void Ucitaj()
        {
            if (tabelaodeljenja.Rows.Count == 1)
            {
                button8.Enabled = false;
                button2.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                textBox1.Text = tabelaodeljenja.Rows[BrVrsta][0].ToString();
                textBox2.Text = tabelaodeljenja.Rows[BrVrsta][1].ToString();
                textBox3.Text = tabelaodeljenja.Rows[BrVrsta][2].ToString();
                comboBox1.Text = tabelaodeljenja2.Rows[BrVrsta][0].ToString();
                comboBox2.Text = tabelaodeljenja3.Rows[BrVrsta][0].ToString();
                comboBox3.Text = tabelaodeljenja4.Rows[BrVrsta][0].ToString();
                if (BrVrsta == 0)
                {
                    button2.Enabled = false;
                    button8.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    button8.Enabled = true;
                }
                if (BrVrsta == tabelaodeljenja.Rows.Count - 1)
                {
                    button6.Enabled = false;
                    button7.Enabled = false;
                }
                else
                {
                    button6.Enabled = true;
                    button7.Enabled = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void Form3_Load(object sender, EventArgs e)
        {

            tabelaodeljenja = new DataTable();
            tabelaodeljenja2 = new DataTable();
            tabelaodeljenja3 = new DataTable();
            tabelaodeljenja5 = new DataTable();
            tabelaodeljenja = Konekcija.Unos("SELECT * FROM Odeljenje");
            tabelaodeljenja2 = Konekcija.Unos("SELECT naziv AS smer_id FROM Smer JOIN Odeljenje ON Smer.id = Odeljenje.smer_id");
            tabelaodeljenja3 = Konekcija.Unos("SELECT ime + ' ' + prezime AS id_razredni FROM Osoba JOIN Odeljenje ON Osoba.id = Odeljenje.razredni_id");
            tabelaodeljenja4 = Konekcija.Unos("SELECT naziv AS godina_id FROM Skolska_godina JOIN Odeljenje ON Odeljenje.godina_id = Skolska_godina.id");
            Ucitaj();
            tabelaodeljenja5 = Konekcija.Unos("SELECT COUNT(*) FROM Osoba WHERE uloga = 2");
            int brojac =int.Parse(tabelaodeljenja5.Rows[0][0].ToString());
            tabelaodeljenja5 = Konekcija.Unos("SELECT ime + ' ' + prezime  FROM Osoba WHERE uloga = 2");
            System.Object[] ItemObject = new System.Object[brojac];
            for (int i = 0; i < brojac; i++)
            {
                ItemObject[i] = tabelaodeljenja5.Rows[0+i][0].ToString();
            }
            comboBox2.Items.AddRange(ItemObject);
            

            tabelaodeljenja5 = Konekcija.Unos("SELECT COUNT(*) FROM Skolska_godina");
            brojac = int.Parse(tabelaodeljenja5.Rows[0][0].ToString());
            tabelaodeljenja5 = Konekcija.Unos("SELECT naziv FROM Skolska_godina");
            System.Object[] ItemObject1 = new System.Object[brojac];
            for (int i = 0; i < brojac; i++)
            {
                ItemObject1[i] = tabelaodeljenja5.Rows[0 + i][0].ToString();
            }
            comboBox3.Items.AddRange(ItemObject1);
        }
        

        

        private void button8_Click(object sender, EventArgs e)
        {
            //<<
           BrVrsta = 0;
            Ucitaj();
            button10.Visible = false;
            button3.Visible = false;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //<
            if (BrVrsta > 0)
            {
                label7.Visible = false;
                BrVrsta--;
                Ucitaj();
            }
            button10.Visible = false;
            button3.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button2.Enabled = true;
            button9.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button10.Visible = false;
            button3.Visible = false;
            Ucitaj();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button2.Enabled = false;
            button9.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button3.Visible = true;
            button10.Visible = true;
            textBox1.Text = "";


        }

        private void button3_Click_1(object sender, EventArgs e)
        { //dodaj

            try
            {
                
                string[] ime_prezime = comboBox2.Text.Split(' ');
                int smer_id, razredni_id;
                string godina_id;
                pomocna = new DataTable();
                pomocna = Konekcija.Unos("SELECT id FROM Smer WHERE naziv = '" + comboBox1.Text + "'");
                smer_id = (int)pomocna.Rows[0][0];
                pomocna = new DataTable();
                pomocna = Konekcija.Unos("SELECT id FROM Osoba WHERE ime = '" + ime_prezime[0] + "'" + "AND prezime = '" + ime_prezime[1] + "'");
                razredni_id = (int)pomocna.Rows[0][0];
                pomocna = new DataTable();
                pomocna = Konekcija.Unos("SELECT id FROM Skolska_godina WHERE naziv = '" + comboBox3.Text + "'");
                godina_id = pomocna.Rows[0][0].ToString();
                menjanja = new SqlCommand();
                menjanja.CommandText = ("INSERT INTO Odeljenje VALUES (" + Convert.ToInt32(textBox2.Text) + ", " + Convert.ToInt32(textBox3.Text) + ", " + smer_id + ", " + razredni_id + ", " + godina_id + ")");
                SqlConnection con = new SqlConnection(Konekcija.Veza());
                menjanja.Connection = con;
                con.Open();
                menjanja.ExecuteNonQuery();
                con.Close();
                label7.Visible = false;
                tabelaodeljenja = new DataTable();
                tabelaodeljenja2 = new DataTable();
                tabelaodeljenja3 = new DataTable();
                tabelaodeljenja = Konekcija.Unos("SELECT * FROM Odeljenje");
                tabelaodeljenja2 = Konekcija.Unos("SELECT naziv AS smer_id FROM Smer JOIN Odeljenje ON Smer.id = Odeljenje.smer_id");
                tabelaodeljenja3 = Konekcija.Unos("SELECT ime + ' ' + prezime AS id_razredni FROM Osoba JOIN Odeljenje ON Osoba.id = Odeljenje.razredni_id");
                tabelaodeljenja4 = Konekcija.Unos("SELECT naziv AS godina_id FROM Skolska_godina JOIN Odeljenje ON Odeljenje.godina_id = Skolska_godina.id");
                Ucitaj();
                button8.Enabled = true;
                button2.Enabled = true;
                button9.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button10.Visible = false;
                button3.Visible = false;
            }
            catch
            {
                label7.Text = "Pokusajte ponovo";
                label7.Visible = true;
            }
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {   //izmeni
            try
            {
                string smer_id, razredni_id;
                string godina_id;
                string[] ime_prezime = comboBox2.Text.Split(' ');
                pomocna = new DataTable();
                pomocna = Konekcija.Unos("SELECT id FROM Smer WHERE naziv = '" + comboBox1.Text + "'");
                smer_id = pomocna.Rows[0][0].ToString();
                pomocna = new DataTable();
                pomocna = Konekcija.Unos("SELECT id FROM Osoba WHERE ime = '" + ime_prezime[0] + "'" + "AND prezime = '" + ime_prezime[1] + "'");
                razredni_id = pomocna.Rows[0][0].ToString();
                pomocna = new DataTable();
                pomocna = Konekcija.Unos("SELECT id FROM Skolska_godina WHERE naziv = '" + comboBox3.Text + "'");
                godina_id = pomocna.Rows[0][0].ToString();
                menjanja = new SqlCommand();
                menjanja.CommandText = ("UPDATE Odeljenje SET razred = " +textBox2.Text + ",indeks = '" + textBox3.Text +
                    "', smer_id = " + smer_id + ", razredni_id = " + razredni_id  + ", godina_id = " + godina_id + " WHERE id = " + textBox1.Text);
                SqlConnection con = new SqlConnection(Konekcija.Veza());
                menjanja.Connection = con;
                con.Open();
                menjanja.ExecuteNonQuery();
                con.Close();
             tabelaodeljenja = new DataTable();
            tabelaodeljenja2 = new DataTable();
            tabelaodeljenja3 = new DataTable();
            tabelaodeljenja4 = new DataTable();
            tabelaodeljenja = Konekcija.Unos("SELECT * FROM Odeljenje");
            tabelaodeljenja2 = Konekcija.Unos("SELECT naziv AS smer_id FROM Smer JOIN Odeljenje ON Smer.id = Odeljenje.smer_id");
            tabelaodeljenja3 = Konekcija.Unos("SELECT ime + ' ' + prezime AS id_razredni FROM Osoba JOIN Odeljenje ON Osoba.id = Odeljenje.razredni_id");
            tabelaodeljenja4 = Konekcija.Unos("SELECT naziv AS godina_id FROM Skolska_godina JOIN Odeljenje ON Odeljenje.godina_id = Skolska_godina.id");
            Ucitaj();
            }
            catch
            {
                label7.Text = "Pokusajte ponovo";
                label7.Visible = true;
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {   //obrisi
            try
            {
                int max_id;
                menjanja = new SqlCommand();
                menjanja.CommandText = ("DELETE FROM Odeljenje WHERE id = " + Convert.ToInt32(textBox1.Text));
                pomocna = new DataTable();
                pomocna = Konekcija.Unos("SELECT * FROM Odeljenje");
                max_id = pomocna.Rows.Count - 2;
                pomocnaid = new SqlCommand();
                pomocnaid.CommandText = ("DBCC CHECKIDENT ('Odeljenje', RESEED, " + max_id + ")");
                SqlConnection con = new SqlConnection(Konekcija.Veza());
                menjanja.Connection = con;
                pomocnaid.Connection = con;
                con.Open();
                menjanja.ExecuteNonQuery();
                pomocnaid.ExecuteNonQuery();
                con.Close();
                label7.Visible = false;
                tabelaodeljenja = new DataTable();
                tabelaodeljenja2 = new DataTable();
                tabelaodeljenja3 = new DataTable();
                tabelaodeljenja = Konekcija.Unos("SELECT * FROM Odeljenje");
                tabelaodeljenja2 = Konekcija.Unos("SELECT naziv AS smer_id FROM Smer JOIN Odeljenje ON Smer.id = Odeljenje.smer_id");
                tabelaodeljenja3 = Konekcija.Unos("SELECT ime + ' ' + prezime AS id_razredni FROM Osoba JOIN Odeljenje ON Osoba.id = Odeljenje.razredni_id");
                tabelaodeljenja4 = Konekcija.Unos("SELECT naziv AS godina_id FROM Skolska_godina JOIN Odeljenje ON Odeljenje.godina_id = Skolska_godina.id");
                Ucitaj();
            }
            catch
            {
               
            }
            if (textBox1.Text == "1") { button6.PerformClick(); }
            else { button2.PerformClick(); }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //>
            if (BrVrsta < tabelaodeljenja.Rows.Count+1)
            {
                label7.Visible = false;
                BrVrsta++;
                Ucitaj();
            }
            button10.Visible = false;
            button3.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //>>
            label7.Visible = false;
            BrVrsta = tabelaodeljenja.Rows.Count - 1;
            Ucitaj();
            button10.Visible = false;
            button3.Visible = false;
        }

       

    
        
    }
}
