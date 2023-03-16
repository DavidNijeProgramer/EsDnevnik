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
    public partial class Form2 : Form
    {
        DataTable osoba, pomocna;

        private void button1_Click(object sender, EventArgs e)
        {//<<
            BrVrsta = 0;
            Ucitaj();
            label9.Visible = false;
            button9.Visible = false;
            button3.Visible = false;


        }

        private void button2_Click(object sender, EventArgs e)
        { //<
            //<
            if (BrVrsta > 0)
            {
                BrVrsta--;
                Ucitaj();
                label9.Visible = false;
                button9.Visible = false;
                button3.Visible = false;
            }
       

        }

        private void button6_Click(object sender, EventArgs e)
        {//>
            if (BrVrsta < osoba.Rows.Count + 1)
            {
                BrVrsta++;
                Ucitaj();
                label9.Visible = false;
                button9.Visible = false;
                button3.Visible = false;

            }


        }

        private void button7_Click(object sender, EventArgs e)
        {//>>
            BrVrsta = osoba.Rows.Count - 1;
            Ucitaj();
            label9.Visible = false;
            button9.Visible = false;
            button3.Visible = false;



        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                menjanja = new SqlCommand();
                menjanja.CommandText = ("INSERT INTO Osoba VALUES ('" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text
                    + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "', " + Convert.ToInt32(textBox8.Text) + ")");
                
                SqlConnection con = new SqlConnection(Konekcija.Veza());
                menjanja.Connection = con;
                con.Open();
                menjanja.ExecuteNonQuery();
                con.Close();
                osoba = new DataTable();
                osoba = Konekcija.Unos("SELECT * FROM Osoba");
                
                Ucitaj();
                button3.Visible = false;
            button9.Visible = false;
                button8.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;

            }
            catch
            {
                label9.Text = "Pokusajte ponovo";
                label9.Visible = true;
            }
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int max_id;
                menjanja = new SqlCommand();
                menjanja.CommandText = ("DELETE FROM Osoba WHERE id = " + Convert.ToInt32(textBox1.Text));
                pomocna = new DataTable();
                pomocna = Konekcija.Unos("SELECT * FROM Osoba");
                max_id = pomocna.Rows.Count - 2;
                resetovanje_id = new SqlCommand();
                resetovanje_id.CommandText = ("DBCC CHECKIDENT ('Osoba', RESEED, " + max_id + ")");
                SqlConnection con = new SqlConnection(Konekcija.Veza());
                menjanja.Connection = con;
                resetovanje_id.Connection = con;
                con.Open();
                menjanja.ExecuteNonQuery();
                resetovanje_id.ExecuteNonQuery();
                con.Close();
              
                osoba = new DataTable();
                
                osoba = Konekcija.Unos("SELECT * FROM Osoba");
                Ucitaj();
            }
            catch
            {

            }
            if (textBox1.Text == "1") { button6.PerformClick(); }
            else { button2.PerformClick(); }
        

    }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                menjanja = new SqlCommand();
                menjanja.CommandText = ("UPDATE Osoba SET ime ='" + textBox2.Text  +
                    "', prezime ='" + textBox3.Text + "',adresa = '" +textBox4.Text + "',jmbg = '" + textBox5.Text +
                    "' ,email = '" + textBox6.Text+ "',pass = '" + textBox7.Text + "',uloga = " + textBox8.Text + " WHERE id = " + textBox1.Text);
                SqlConnection con = new SqlConnection(Konekcija.Veza());
                menjanja.Connection = con;
                con.Open();
                menjanja.ExecuteNonQuery();
                con.Close();
                osoba = new DataTable();
                
                osoba = Konekcija.Unos("SELECT * FROM Osoba");
                
                Ucitaj();
            }
            catch
            {
                label9.Text = "Pokusajte ponovo";
                label9.Visible = true;
            }
           
        }

        SqlCommand menjanja, resetovanje_id;
        int BrVrsta;
        private void Ucitaj()
        {
            if (osoba.Rows.Count == 1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                textBox1.Text = osoba.Rows[BrVrsta][0].ToString();
                textBox2.Text = osoba.Rows[BrVrsta][1].ToString();
                textBox3.Text = osoba.Rows[BrVrsta][2].ToString();
                textBox4.Text = osoba.Rows[BrVrsta][3].ToString();
                textBox5.Text = osoba.Rows[BrVrsta][4].ToString();
                textBox6.Text = osoba.Rows[BrVrsta][5].ToString();
                textBox7.Text = osoba.Rows[BrVrsta][6].ToString();
                textBox8.Text = osoba.Rows[BrVrsta][7].ToString();
                if (BrVrsta == 0)
                {
                    button2.Enabled = false;
                    button1.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                    button1.Enabled = true;
                }
                if (BrVrsta == osoba.Rows.Count - 1)
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

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button9.Visible = true;
            button3.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button8.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button9.Visible = false;
            button3.Visible = false;
            Ucitaj();



        }

        public Form2()
        {
            InitializeComponent();
            osoba = new DataTable();
            osoba = Konekcija.Unos("SELECT * FROM OSOBA");
            Ucitaj();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
