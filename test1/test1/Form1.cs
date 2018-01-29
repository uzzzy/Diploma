﻿using System;
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
    public partial class buyForm : Form
    {
        public static buyForm wm;

        public buyForm()
        {
            InitializeComponent();
        }

        class sql_data
        {
            public string name { get; set; }
            public string name_genre { get; set; }
            public string dur { get; set; }
            public string premiere_s { get; set; }
            public string premiere_f { get; set; }
            public string film_cost { get; set; }
            
        }

        class cash_list
        {
            public string name { get; set; }
            public string costs { get; set; }
        }
        class report_list
        {
            public string name { get; set; }
            public string costs { get; set; }
            public string counts { get; set; }
            public string date { get; set; }
        }

        List<sql_data> sql_data_List = new List<sql_data> { };
        List<cash_list> sql_data_List_cash = new List<cash_list> { };
        List<report_list> sql_data_List_report = new List<report_list> { };

        class work_Controls //класс work_Controls
        {
            //ниже идут методы внутри класса
            public void create_DataGrid_columns() //метод для работы с гридом(сеткой)
            {
                wm.dg_SqlData.ColumnCount = 6; //устанавливаем кол-во колонок

                wm.dg_SqlData.Columns[0].Name = "name";          //имя колонки для доступа из кода(данная строка не обязательна)
                wm.dg_SqlData.Columns[0].HeaderText = "Название фильма";               //Название заголовка
                wm.dg_SqlData.Columns[0].DataPropertyName = "name";  //название поля из БД к которому будем привязывать данные при чтнеии из БД
                wm.dg_SqlData.Columns[1].Name = "name_genre";          
                wm.dg_SqlData.Columns[1].HeaderText = "Жанр";              
                wm.dg_SqlData.Columns[1].DataPropertyName = "name_genre";
                wm.dg_SqlData.Columns[2].Name = "dur";
                wm.dg_SqlData.Columns[2].HeaderText = "Длительность";
                wm.dg_SqlData.Columns[2].DataPropertyName = "dur";
                wm.dg_SqlData.Columns[3].Name = "premiere_s";
                wm.dg_SqlData.Columns[3].HeaderText = "Начало премьеры";
                wm.dg_SqlData.Columns[3].DataPropertyName = "premiere_s";
                wm.dg_SqlData.Columns[4].Name = "premiere_f";
                wm.dg_SqlData.Columns[4].HeaderText = "Окончание примьеры";
                wm.dg_SqlData.Columns[4].DataPropertyName = "premiere_f";
                wm.dg_SqlData.Columns[5].Name = "film_cost";
                wm.dg_SqlData.Columns[5].HeaderText = "Стоймость фильма";
                wm.dg_SqlData.Columns[5].DataPropertyName = "film_cost";
            }
        
            public void create_dg_cash_columns()
            {
                wm.dg_cash.ColumnCount = 2;

                wm.dg_cash.Columns[0].Name = "name";          //имя колонки для доступа из кода(данная строка не обязательна)
                wm.dg_cash.Columns[0].HeaderText = "Название фильма";               //Название заголовка
                wm.dg_cash.Columns[0].DataPropertyName = "name";  //название поля из БД к которому будем привязывать данные при чтнеии из БД
                wm.dg_cash.Columns[1].Name = "costs";
                wm.dg_cash.Columns[1].HeaderText = "Сумма";
                wm.dg_cash.Columns[1].DataPropertyName = "costs";
            }

            public void create_dg_report_columns()
            {
                wm.dg_report.ColumnCount = 4;

                wm.dg_report.Columns[0].Name = "name";          //имя колонки для доступа из кода(данная строка не обязательна)
                wm.dg_report.Columns[0].HeaderText = "Название фильма";               //Название заголовка
                wm.dg_report.Columns[0].DataPropertyName = "name";  //название поля из БД к которому будем привязывать данные при чтнеии из БД
                wm.dg_report.Columns[1].Name = "costs";
                wm.dg_report.Columns[1].HeaderText = "Сумма";
                wm.dg_report.Columns[1].DataPropertyName = "costs";
                wm.dg_report.Columns[2].Name = "counts";
                wm.dg_report.Columns[2].HeaderText = "Количество";
                wm.dg_report.Columns[2].DataPropertyName = "counts";
                wm.dg_report.Columns[3].Name = "date";
                wm.dg_report.Columns[3].HeaderText = "Дата";
                wm.dg_report.Columns[3].DataPropertyName = "date";
            }
        }

        class work_SQL : buyForm //класс work_SQL
        {
                //ниже идут(могут идти) объекты и переменные для работы класса
                private static SqlConnection conn = new SqlConnection("Data Source=UZZZY-ПК\\SQLEXPRESS;Initial Catalog=cinema;User ID=sa;Password=123"); //строка подключения
                private static SqlCommand command = new SqlCommand("", conn);  //создаем объект для выполнения комманд БД и присваиваем ему объект подключения(conn)
                //ниже идут методы внутри класса

                private string id_gen()
            {
                string id_g = " ";

                conn.Open();

                command.CommandText = "SELECT [id_genre] FROM [cinema].[dbo].[genres] WHERE [name_genre]='"
                    + cb_search.Text + "'";

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) //если получена хоть одна строка в результате выполнения запроса
                {
                    while (reader.Read()) //начинаем цикл построчного чтения пока не будут считаны все строки
                    {
                        id_g = reader["id_genre"].ToString();
                    }
                }

                conn.Close();

                return id_g;
            }

            //Модуль вывода информации
                
            public void sql_select() // метод для реализации запроса на выборку данных из БД
            {
                conn.Open(); //открываем подключение к БД
                command.CommandText = "SELECT [name],[name_genre],[dur],[premiere_s],[premiere_f],[film_cost] " +
                    "FROM [cinema].[dbo].[films],[cinema].[dbo].[genres]"
                    +"WHERE [cinema].[dbo].[genres].[id_genre]=[cinema].[dbo].[films].[id_genre]"+ search(comboBox1.SelectedIndex); //присваиваем текст SQL команды объекту выполнения команд
                    
                SqlDataReader reader = command.ExecuteReader(); //создаем объект чтения данных и сразу считываем в него все данные полученные в результате выполнения объекта command
                if (reader.HasRows) //если получена хоть одна строка в результате выполнения запроса
                {
                    while (reader.Read()) //начинаем цикл построчного чтения пока не будут считаны все строки
                    {
                        sql_data_List.Add(new sql_data
                        {
                            name = reader["name"].ToString(),
                            name_genre = reader["name_genre"].ToString(),
                            dur = reader["dur"].ToString(),
                            premiere_s = reader["premiere_s"].ToString().Substring(0, 10),
                            premiere_f = reader["premiere_f"].ToString().Substring(0, 10),
                            film_cost = reader["film_cost"].ToString(),//заполняем наш список объектов для хранения данных из таблицы
                        });
                       
                    }
                }               

                conn.Close(); //закрываем подключение

                wm.dg_SqlData.DataSource = sql_data_List;//присваиваем список гриду(сетке)
            }

            public void sql_cash() 
            {
                conn.Open(); //открываем подключение к БД
                command.CommandText = "SELECT [name], SUM(cost) as [costs]"+
                " FROM[cinema].[dbo].[costs],  [cinema].[dbo].[tickets],   [cinema].[dbo].[films],  [cinema].[dbo].[seats_in_halls] "+
                 "WHERE films.id_film=tickets.id_film and seats_in_halls.id_seat= tickets.id_seat and tickets.id_cost= costs.id_cost"+
                " group by name"; //присваиваем текст SQL команды объекту выполнения команд

                SqlDataReader reader = command.ExecuteReader(); //создаем объект чтения данных и сразу считываем в него все данные полученные в результате выполнения объекта command
                if (reader.HasRows) //если получена хоть одна строка в результате выполнения запроса
                {
                    while (reader.Read()) //начинаем цикл построчного чтения пока не будут считаны все строки
                    {

                        sql_data_List_cash.Add(new cash_list
                        {
                            name = reader["name"].ToString(),
                            costs = reader["costs"].ToString()
                            });
                    }
                }

                conn.Close(); //закрываем подключение

                wm.dg_cash.DataSource = sql_data_List_cash;//присваиваем список гриду(сетке)
            }

            public void sql_report() // метод для реализации запроса на выборку данных из БД
            {
                conn.Open(); //открываем подключение к БД
                command.CommandText = "SELECT [name], SUM(cost) as [costs], count(n_ticket) as [count], [tickets].[date] "+
                    "FROM[cinema].[dbo].[costs], [cinema].[dbo].[tickets],  [cinema].[dbo].[films], [cinema].[dbo].[seats_in_halls] "+
                    "WHERE films.id_film=tickets.id_film and seats_in_halls.id_seat= tickets.id_seat and tickets.id_cost= costs.id_cost "+
                    "group by name, [date]"; //присваиваем текст SQL команды объекту выполнения команд

                SqlDataReader reader = command.ExecuteReader(); //создаем объект чтения данных и сразу считываем в него все данные полученные в результате выполнения объекта command
                if (reader.HasRows) //если получена хоть одна строка в результате выполнения запроса
                {
                    while (reader.Read()) //начинаем цикл построчного чтения пока не будут считаны все строки
                    {

                        sql_data_List_report.Add(new report_list
                        {
                            name = reader["name"].ToString(),
                            costs = reader["costs"].ToString(),
                            counts = reader["count"].ToString(),
                            date = reader["date"].ToString().Substring(0, 10)
                        });
                    }
                }

                conn.Close(); //закрываем подключение

                wm.dg_report.DataSource = sql_data_List_report;//присваиваем список гриду(сетке)
            }

            public void sql_update() // изменение данных В БД
            {
                conn.Open();

                command.CommandText = "UPDATE [dbo].[cinema] " +
                                      "SET [field_name]='новая строка' " +
                                      "WHERE [field_name]='искомая строка(ки)' ";

                command.ExecuteNonQuery(); //выполняем команду без запроса (для команды отличной от SELECT, SqlDataReader не нужен)
                conn.Close();
            }

            public List<string> genress()
            {
                List<string> res = new List<string> { };

                conn.Open(); //открываем подключение к БД
                command.CommandText = "SELECT [name_genre] " +
                                      "FROM [cinema].[dbo].[genres]";

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) //если получена хоть одна строка в результате выполнения запроса
                {
                    while (reader.Read()) //начинаем цикл построчного чтения пока не будут считаны все строки
                    {
                        res.Add(reader["name_genre"].ToString());
                    }
                }

                conn.Close();

                return res;
            }

            public string search(int a)
            {

                string back = " ";

                if (a == 0)
                {
                    back = "and [name] like '%"+ tb_search.Text+ "%'";
                }
                else if (a== 1)
                {
                    back = "and [id_genre] = '" + id_gen() + "'";
                    
                }
                else if (a == 2)
                {
                    back = "and [dur] like '%" + tb_search.Text + "%'";
                }
                else if (a == 3)
                {
                    back = "and [premiere_s] = '" + dt_search.Value.ToString("yyyy-MM-dd") + "'";
                }
                else if (a == 4)
                {
                    back = "and [premiere_f] like '" + dt_search.Value.ToString("yyyy-MM-dd") + "'";
                }
                else if (a == 5)
                {
                    back = "and [film_cost] >= '" + tb_search.Text + "'";
                }
                return back;
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            wm = this; //присваиваем ссылке на объект главного окна сам объект главного окна

            work_Controls w_Controls = new work_Controls(); //создаем объект класса для работы с контролами(компонентами) гридом(сеткой)
            work_SQL w_SQL = new work_SQL();                //создаем объект класса для работы с SQL

            w_Controls.create_DataGrid_columns();           //вызываем метод create_DataGrid_columns(который создает столбцы в гриде) из класса для работы с контролами(компонентами) 

            w_SQL.sql_select();              //вызываем метод sql_select(который выполняет SQL команду на выборку данных и присваивает полученные данные в грид(сетку)) 

            wm.cb_search.DataSource = w_SQL.genress();

            w_Controls.create_dg_cash_columns();

            w_SQL.sql_cash();


            w_Controls.create_dg_report_columns();       

            w_SQL.sql_report();


            wm.dg_SqlData.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;
            
            wm.dg_cash.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            wm.dg_report.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill;

            uint place = 1;

            for (int i = 0; i < 6; i++)
            {
                listView1.Groups.Add(new ListViewGroup("Ряд " + i + ""));

                for (uint j = 0; j < 3; j++)
                {
                    ListViewItem item = new ListViewItem("Место " + place + "");

                    item.Group = listView1.Groups[i];

                    listView1.Items.Add(item);

                    place++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//Кнопка добавить
        {
            work_SQL w_SQL = new work_SQL();
            AddFilms Add = new AddFilms();

            Add.cb_genre.DataSource = w_SQL.genress();
            //Add.cb_genre.DisplayMember = "имя поля если их много";

            Add.ShowDialog();
            w_SQL.sql_select();

        }

        private void button2_Click(object sender, EventArgs e)//Кнопка изменить
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_search.Visible = false;
            cb_search.Visible = false;
            dt_search.Visible = false;

            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 5)
            {
                tb_search.Visible=true;
            }
            else if (comboBox1.SelectedIndex == 1){

                cb_search.Visible = true;
            }
            else if (comboBox1.SelectedIndex == 3 || comboBox1.SelectedIndex == 4)
            {

                dt_search.Visible = true;
            }
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            work_SQL w_SQL = new work_SQL();
            
            w_SQL.sql_select();

            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            MessageBox.Show(w_SQL.search(comboBox1.SelectedIndex).ToString());
        }



    }
}
