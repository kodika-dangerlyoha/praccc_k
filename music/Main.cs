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
using conditerskaya;

namespace music
{
    public partial class Main : Form
    {
        database database = new database();
        public Main()
        {
            InitializeComponent();
        }

        int selected_row;

        public void Create_colums()
        {
            grid_authors.Columns.Add("id_author", "id");
            grid_authors.Columns.Add("nickname", "Ник");
            grid_authors.Columns.Add("proslushivane", "Прослушивания");

            grid_song.Columns.Add("id_song", "id");
            grid_song.Columns.Add("title", "Название");
            grid_song.Columns.Add("data_drop", "Дата релиза");
            grid_song.Columns.Add("id_style", "Стиль");

            grid_albums.Columns.Add("id_song", "id");
            grid_albums.Columns.Add("title", "Название");
            grid_albums.Columns.Add("id_style", "Стиль");
            grid_albums.Columns.Add("data_drop", "Дата релиза");
        }

        public void Read_single_row(DataGridView dgw, IDataRecord record, int n)
        {
            if (n == 0) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2));
            if (n == 1) dgw.Rows.Add(record.GetInt32(0), record.GetString(1));
            if (n == 2) dgw.Rows.Add(record.GetInt32(0), record.GetString(1));
        }

        public void Refresh_data_grid(DataGridView dgw, string table, int n)
        {
            dgw.Rows.Clear();

            string query_string = $"select * from {table}";

            SqlCommand command = new SqlCommand(query_string, database.getSqlConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Read_single_row(dgw, reader, n);
            }
            reader.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Create_colums();
            Refresh_data_grid(grid_authors, "author", 0);
            Refresh_data_grid(grid_song, "song", 1);
            Refresh_data_grid(grid_albums, "album", 2);

            grid_authors.Visible = false;
            grid_albums.Visible = false;
            grid_song.Visible = true;
        }

        private void button_authors_Click(object sender, EventArgs e)
        {
            lbl_title_main.Text = "Исполнители";
            grid_song.Visible = false;
            grid_albums.Visible = false;
            grid_authors.Visible = true;
        }

        private void button_songs_Click(object sender, EventArgs e)
        {
            lbl_title_main.Text = "Треки";
            grid_authors.Visible = false;
            grid_albums.Visible = false;
            grid_song.Visible = true;
        }

        private void button_albums_Click(object sender, EventArgs e)
        {
            lbl_title_main.Text = "Альбомы";
            grid_authors.Visible = false;
            grid_song.Visible = false;
            grid_albums.Visible = true;
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string search_string = $"select * from [album] where concat (id_album, title) like '%" + TB_search.Text + "%'";

            SqlCommand command = new SqlCommand(search_string, database.getSqlConnection());
            database.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) {
                Read_single_row(dgw, reader, 2); 
            }

            reader.Close(); 
        }

        private void TB_search_TextChanged(object sender, EventArgs e)
        {
            Search(grid_albums);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_smena_akka_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TB_search_Click(object sender, EventArgs e)
        {
            if (TB_search.Text == "Поиск")
            {
                TB_search.Text = "";
            }
        }

        private void TB_search_Leave(object sender, EventArgs e)
        {
            if (TB_search.Text == "")
            {
                TB_search.Text = "Поиск";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
