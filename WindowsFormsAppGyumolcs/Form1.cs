using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppGyumolcs
{
    public partial class Form1 : Form
    {
        MySqlConnection conn= null;
        MySqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message+Environment.NewLine+"a program leáll!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }
            gyumolcs_lista_update();
        }

        private void gyumolcs_lista_update()
        {
            listBox1.Items.Clear();
            cmd.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcsok` WHERE 1;";
            conn.Open();
            using(MySqlDataReader dr=cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    gyumolcs uj = new gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetInt32("egysegar"), dr.GetInt32("mennyiseg"));
                    listBox1.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void buttonUjGyumolcs_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNev.Text))
            {
                MessageBox.Show("Adja meg a nevet!");
                textBoxNev.Focus();
                return;
            }
            if (numericUpDownEgysegar.Value==0)
            {
                MessageBox.Show("Adja meg az egységárat!");
                numericUpDownEgysegar.Focus();
                return;
            }
            if (numericUpDownMennyiseg.Value==0)
            {
                MessageBox.Show("Adja meg a mennyiséget!");
                numericUpDownMennyiseg.Focus();
                return;
            }
            cmd.CommandText = "INSERT INTO `gyumolcsok` (`id`, `nev`, `egysegar`, `mennyiseg`) VALUES (NULL, @nev, @egysegar, @mennyiseg);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", textBoxNev.Text);
            cmd.Parameters.AddWithValue("@egysegar", numericUpDownEgysegar.Value.ToString());
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDownMennyiseg.Value.ToString());
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Sikeresen rögzítve");
                    textBoxId.Text = "";
                    textBoxNev.Text = "";
                    numericUpDownEgysegar.Value = numericUpDownEgysegar.Minimum;
                    numericUpDownMennyiseg.Value = numericUpDownMennyiseg.Minimum;
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            gyumolcs_lista_update();
        }

        private void buttonModosítas_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve gyümölcs!");
                return;
            }
            cmd.CommandText = "UPDATE `gyumolcsok` SET `nev` = @nev, `egysegar` = @egysegar, `mennyiseg` = @mennyiseg WHERE `gyumolcsok`.`id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            cmd.Parameters.AddWithValue("@nev", textBoxNev.Text);
            cmd.Parameters.AddWithValue("@egysegar", numericUpDownEgysegar.Value);
            cmd.Parameters.AddWithValue("@mennyiseg", numericUpDownMennyiseg.Value);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres!");
                conn.Close();
                textBoxId.Text = "";
                textBoxNev.Text = "";
                numericUpDownEgysegar.Value = numericUpDownEgysegar.Minimum;
                numericUpDownMennyiseg.Value = numericUpDownMennyiseg.Minimum;
                gyumolcs_lista_update();
            }
            else
            {
                MessageBox.Show("Az adatok modosítása sikerleten!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `gyumolcsok` WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Törlés sikeres!");
                conn.Close();
                textBoxId.Text = "";
                textBoxNev.Text = "";
                numericUpDownEgysegar.Value = numericUpDownEgysegar.Minimum;
                numericUpDownMennyiseg.Value = numericUpDownMennyiseg.Minimum;
                gyumolcs_lista_update();
            }
            else
            {
                MessageBox.Show("Törlés sikertelen!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            //--A felhasználó kijelöl egy elemet a listában -------
            gyumolcs kivalaszott_gumolcs = (gyumolcs)listBox1.SelectedItem;
            textBoxId.Text = kivalaszott_gumolcs.Id.ToString();
            textBoxNev.Text = kivalaszott_gumolcs.Nev;
            numericUpDownEgysegar.Value = kivalaszott_gumolcs.Egysegar;
            numericUpDownMennyiseg.Value = kivalaszott_gumolcs.Mennyiseg;
        }
    }
}
