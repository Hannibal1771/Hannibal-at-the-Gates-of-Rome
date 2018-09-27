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

namespace VTF
{
    public partial class SpLic : Form
    {
        public SpLic()
        {
            InitializeComponent();
        }

        private void SpLic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vTFDataSet.Lic' table. You can move, or remove it, as needed.
            this.licTableAdapter.Fill(this.vTFDataSet.Lic);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SpLic spl = new SpLic();
            this.Hide();
            Menu men = new Menu();
            men.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text != "") && (textBox3.Text != ""))
            {
                SqlConnection con = new SqlConnection(@"Data Source=Владимир-ПК\SOON; Initial Catalog=VTF;Integrated Security=True");
                con.Open();
                SqlCommand StrPrc = new SqlCommand("Lic_Add", con);// Обращение к хранимой процедуре добавления
                StrPrc.CommandType = CommandType.StoredProcedure;
                StrPrc.Parameters.AddWithValue("@Naim_Lic", textBox3.Text);
                StrPrc.Parameters.AddWithValue("@Sd_Lic", textBox2.Text);
                StrPrc.ExecuteNonQuery();
                textBox2.Text = "";
                textBox3.Text = "";
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text != "") && (textBox3.Text != ""))
            {
                SqlConnection con = new SqlConnection(@"Data Source=Владимир-ПК\SOON; Initial Catalog=VTF;Integrated Security=True");
                con.Open();
                SqlCommand StrPrc1 = new SqlCommand("Lic_update", con); // Обращение к хранимой процедуре обновления
                StrPrc1.CommandType = CommandType.StoredProcedure;
                StrPrc1.Parameters.AddWithValue("@Sd_Lic", textBox2.Text);
                StrPrc1.Parameters.AddWithValue("@Naim_Lic", textBox3.Text);
                StrPrc1.Parameters.AddWithValue("@ID_Lic", textBox4.Text);
                StrPrc1.ExecuteNonQuery();
                MessageBox.Show("Информация изменена");
                textBox4.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                SqlDataAdapter da = new SqlDataAdapter("select * from Lic", con);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "Lic");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=Владимир-ПК\SOON; Initial Catalog=VTF;Integrated Security=True");
            con.Open();
            SqlCommand StrPrc = new SqlCommand("[dbo].Lic_delete", con); // Обращение к хранимой процедуре удаления
            StrPrc.CommandType = CommandType.StoredProcedure;
            StrPrc.Parameters.AddWithValue("@ID_Lic", Convert.ToInt32(textBox4.Text));
            StrPrc.ExecuteNonQuery();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
            con.Close();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=Владимир-ПК\SOON; Initial Catalog=VTF;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Lic", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Lic");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Text = "ДОБАВИТЬ";
            button2.Text = "ИЗМЕНИТЬ";
            button3.Text = "УДАЛИТЬ";
            button4.Text = "ОБНОВИТЬ";
        }
    }
}
