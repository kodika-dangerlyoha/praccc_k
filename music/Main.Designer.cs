namespace music
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_authors = new System.Windows.Forms.DataGridView();
            this.grid_song = new System.Windows.Forms.DataGridView();
            this.button_authors = new System.Windows.Forms.Button();
            this.button_songs = new System.Windows.Forms.Button();
            this.grid_albums = new System.Windows.Forms.DataGridView();
            this.button_albums = new System.Windows.Forms.Button();
            this.TB_search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_smena_akka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_title_main = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_authors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_song)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_albums)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_authors
            // 
            this.grid_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_authors.Location = new System.Drawing.Point(305, 128);
            this.grid_authors.Margin = new System.Windows.Forms.Padding(4);
            this.grid_authors.Name = "grid_authors";
            this.grid_authors.RowHeadersWidth = 51;
            this.grid_authors.Size = new System.Drawing.Size(457, 401);
            this.grid_authors.TabIndex = 3;
            // 
            // grid_song
            // 
            this.grid_song.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_song.Location = new System.Drawing.Point(305, 128);
            this.grid_song.Margin = new System.Windows.Forms.Padding(4);
            this.grid_song.Name = "grid_song";
            this.grid_song.RowHeadersWidth = 51;
            this.grid_song.Size = new System.Drawing.Size(457, 401);
            this.grid_song.TabIndex = 4;
            // 
            // button_authors
            // 
            this.button_authors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.button_authors.FlatAppearance.BorderSize = 0;
            this.button_authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_authors.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_authors.Location = new System.Drawing.Point(8, 330);
            this.button_authors.Margin = new System.Windows.Forms.Padding(4);
            this.button_authors.Name = "button_authors";
            this.button_authors.Size = new System.Drawing.Size(231, 34);
            this.button_authors.TabIndex = 5;
            this.button_authors.Text = "              Исполнители";
            this.button_authors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_authors.UseVisualStyleBackColor = false;
            this.button_authors.Click += new System.EventHandler(this.button_authors_Click);
            // 
            // button_songs
            // 
            this.button_songs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.button_songs.FlatAppearance.BorderSize = 0;
            this.button_songs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_songs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_songs.Location = new System.Drawing.Point(8, 252);
            this.button_songs.Margin = new System.Windows.Forms.Padding(4);
            this.button_songs.Name = "button_songs";
            this.button_songs.Size = new System.Drawing.Size(231, 34);
            this.button_songs.TabIndex = 6;
            this.button_songs.Text = "              Треки";
            this.button_songs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_songs.UseVisualStyleBackColor = false;
            this.button_songs.Click += new System.EventHandler(this.button_songs_Click);
            // 
            // grid_albums
            // 
            this.grid_albums.BackgroundColor = System.Drawing.Color.Snow;
            this.grid_albums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_albums.Location = new System.Drawing.Point(305, 128);
            this.grid_albums.Margin = new System.Windows.Forms.Padding(4);
            this.grid_albums.Name = "grid_albums";
            this.grid_albums.RowHeadersWidth = 51;
            this.grid_albums.Size = new System.Drawing.Size(696, 401);
            this.grid_albums.TabIndex = 7;
            // 
            // button_albums
            // 
            this.button_albums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.button_albums.FlatAppearance.BorderSize = 0;
            this.button_albums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_albums.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_albums.Location = new System.Drawing.Point(8, 291);
            this.button_albums.Margin = new System.Windows.Forms.Padding(4);
            this.button_albums.Name = "button_albums";
            this.button_albums.Size = new System.Drawing.Size(231, 34);
            this.button_albums.TabIndex = 8;
            this.button_albums.Text = "              Альбомы";
            this.button_albums.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_albums.UseVisualStyleBackColor = false;
            this.button_albums.Click += new System.EventHandler(this.button_albums_Click);
            // 
            // TB_search
            // 
            this.TB_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_search.ForeColor = System.Drawing.SystemColors.MenuText;
            this.TB_search.Location = new System.Drawing.Point(336, 14);
            this.TB_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_search.MinimumSize = new System.Drawing.Size(675, 23);
            this.TB_search.Multiline = true;
            this.TB_search.Name = "TB_search";
            this.TB_search.Size = new System.Drawing.Size(675, 25);
            this.TB_search.TabIndex = 9;
            this.TB_search.Text = "Поиск";
            this.TB_search.Click += new System.EventHandler(this.TB_search_Click);
            this.TB_search.TextChanged += new System.EventHandler(this.TB_search_TextChanged);
            this.TB_search.Leave += new System.EventHandler(this.TB_search_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.groupBox1.Controls.Add(this.button_smena_akka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_songs);
            this.groupBox1.Controls.Add(this.button_albums);
            this.groupBox1.Controls.Add(this.button_authors);
            this.groupBox1.Location = new System.Drawing.Point(-13, -15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(219, 625);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "〠";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "◎";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F);
            this.label2.Location = new System.Drawing.Point(33, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "♬";
            // 
            // button_smena_akka
            // 
            this.button_smena_akka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.button_smena_akka.FlatAppearance.BorderSize = 0;
            this.button_smena_akka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_smena_akka.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_smena_akka.Location = new System.Drawing.Point(8, 572);
            this.button_smena_akka.Margin = new System.Windows.Forms.Padding(4);
            this.button_smena_akka.Name = "button_smena_akka";
            this.button_smena_akka.Size = new System.Drawing.Size(211, 34);
            this.button_smena_akka.TabIndex = 10;
            this.button_smena_akka.Text = "      Сменить аккаунт";
            this.button_smena_akka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_smena_akka.UseVisualStyleBackColor = false;
            this.button_smena_akka.Click += new System.EventHandler(this.button_smena_akka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "МОЯ МУЗЫКА";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_title_main
            // 
            this.lbl_title_main.AutoSize = true;
            this.lbl_title_main.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title_main.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title_main.Location = new System.Drawing.Point(291, 55);
            this.lbl_title_main.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_main.Name = "lbl_title_main";
            this.lbl_title_main.Size = new System.Drawing.Size(160, 55);
            this.lbl_title_main.TabIndex = 11;
            this.lbl_title_main.Text = "Треки";
            this.lbl_title_main.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(305, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(696, 1);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(303, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "🔍";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 599);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TB_search);
            this.Controls.Add(this.grid_albums);
            this.Controls.Add(this.grid_song);
            this.Controls.Add(this.grid_authors);
            this.Controls.Add(this.lbl_title_main);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Z.Музыка";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_authors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_song)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_albums)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_authors;
        private System.Windows.Forms.DataGridView grid_song;
        private System.Windows.Forms.Button button_authors;
        private System.Windows.Forms.Button button_songs;
        private System.Windows.Forms.DataGridView grid_albums;
        private System.Windows.Forms.Button button_albums;
        private System.Windows.Forms.TextBox TB_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_title_main;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_smena_akka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}