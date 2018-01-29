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

namespace test1
{
    public partial class AddFilms : Form 
    {
        
        public AddFilms()
        {
            InitializeComponent();


        }


        class sql_data
        {
            public string name_genre { get; set; }
        }
        
        List<sql_data> sql_data_List = new List<sql_data> { };
        
        private void AddFilms_Load(object sender, EventArgs e)
        {}


        class Insert : AddFilms
        {

        }
        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=UZZZY-ПК\\SQLEXPRESS;Initial Catalog=cinema;User ID=sa;Password=123"); //строка подключения
            SqlCommand command = new SqlCommand("", conn);

            string id_g=" ";

            conn.Open();

            command.CommandText = "SELECT [id_genre] FROM [cinema].[dbo].[genres] WHERE [name_genre]='"
                + cb_genre.Text + "'";

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows) //если получена хоть одна строка в результате выполнения запроса
            {
                while (reader.Read()) //начинаем цикл построчного чтения пока не будут считаны все строки
                {
                    id_g=reader["id_genre"].ToString();
                }
            }

            conn.Close();

            // MessageBox.Show(dt_start.Value.ToString("yyyy-MM-dd"));

            conn.Open();

            //Формирование запроса для добавления
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO [cinema].[dbo].[films] " +
                                  "VALUES ('" + tb_name.Text + "', " + id_g + ", " + tb_dur.Text +
                                  ", ' " + dt_start.Value.ToString("yyyy-MM-dd") + "', ' "
                                  + dt_finish.Value.ToString("yyyy-MM-dd") + "', " + tb_cost.Text + ")";
            command.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Запись добавлена", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
