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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        DataTable student = new DataTable();
       
        int red = 0;
        string cs = "Data source=DESKTOP-CQJ6GR7; Initial catalog=Student; Integrated security=true";
        public Form1()
        {
            InitializeComponent();
        }
        private void osvezi(int x)
        {
                txt_id.Text = student.Rows[x]["ID"].ToString();
                txt_index.Text = student.Rows[x]["indexst"].ToString();
                txt_ime.Text = student.Rows[x]["ime"].ToString();
                txt_prezime.Text = student.Rows[x]["prezime"].ToString();
                txt_jmbg.Text = student.Rows[x]["jmbg"].ToString();
                txt_redovan.Text = student.Rows[x]["redovan"].ToString();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            SqlConnection veza = new SqlConnection(cs);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from studenti " ,veza);
            adapter.Fill(student);
            // MessageBox.Show(student.Rows.Count.ToString());

            osvezi(red);


        }

        private void txt_redovan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_redovan_Click(object sender, EventArgs e)
        {

        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            if (red < student.Rows.Count - 1)
            {
                red++;
                osvezi(red);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (red > 0)
            {
                red--;
                osvezi(red);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            red = student.Rows.Count - 1;
            osvezi(red);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            red = 0;
            osvezi(red);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(cs);
            SqlCommand naredba = new SqlCommand("DELETE FROM studenti WHERE ID=" + txt_id.Text , veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from studenti", veza);
            student.Clear();
            adapter.Fill(student);
            if (red == student.Rows.Count) red = red - 1;
            if (red == 0) red = 1;

            osvezi(red);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(cs);
            SqlCommand naredba = new SqlCommand("Update studenti Set indexst= '"+txt_index.Text + "' , ime= '" +txt_ime.Text +"', prezime= '"+ txt_prezime.Text +"' , jmbg= '" +txt_jmbg.Text +"' , redovan= '"+txt_redovan.Text+ "'  where ID= " + txt_id.Text, veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from studenti", veza);
            student.Clear();
            adapter.Fill(student);
            osvezi(red);
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(cs);
            MessageBox.Show("insert into studenti (id , indexst , ime, prezime, jmbg, redovan ) values (" + txt_id.Text + ", '" + txt_index.Text + "' ,'" + txt_ime.Text + "', '" + txt_prezime.Text + "' , '" + txt_jmbg.Text + "' ,'" + txt_redovan.Text + "' ) ");
           SqlCommand naredba = new SqlCommand("insert into studenti (id , indexst , ime, prezime, jmbg, redovan ) values ("+txt_id.Text +", '" + txt_index.Text+"' ,'" + txt_ime.Text+"', '"+ txt_prezime.Text+"' , '"+txt_jmbg.Text+"' ,'"+txt_redovan.Text+"' ) "  ,veza);
            veza.Open();
            naredba.ExecuteNonQuery();
            veza.Close();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from studenti", veza);
            student.Clear();
            adapter.Fill(student);
            osvezi(red);

        }
    }
}
