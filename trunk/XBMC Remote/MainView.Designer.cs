﻿namespace XBMC_Remote
{
    partial class MainView
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
            this.GBNowPlaying = new System.Windows.Forms.GroupBox();
            this.TBNowPlayingRuntime = new System.Windows.Forms.TextBox();
            this.TBNowPlayingAlbum = new System.Windows.Forms.TextBox();
            this.TBNowPlayingArtist = new System.Windows.Forms.TextBox();
            this.LblNowPlayingAlbum = new System.Windows.Forms.Label();
            this.LblNowPlayingArtist = new System.Windows.Forms.Label();
            this.PBNowPlaying = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabMovies = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBMoviesArt = new System.Windows.Forms.PictureBox();
            this.TBMoviesPlot = new System.Windows.Forms.TextBox();
            this.LblMoviesPlot = new System.Windows.Forms.Label();
            this.TBMoviesRuntime = new System.Windows.Forms.TextBox();
            this.LblMoviesRuntime = new System.Windows.Forms.Label();
            this.TBMoviesYear = new System.Windows.Forms.TextBox();
            this.LblMoviesYear = new System.Windows.Forms.Label();
            this.TBMoviesWriter = new System.Windows.Forms.TextBox();
            this.TBMoviesStudio = new System.Windows.Forms.TextBox();
            this.TBMoviesGenre = new System.Windows.Forms.TextBox();
            this.TBMoviesDirector = new System.Windows.Forms.TextBox();
            this.LblMoviesGenre = new System.Windows.Forms.Label();
            this.LblMoviesStudio = new System.Windows.Forms.Label();
            this.LblMoviesWriter = new System.Windows.Forms.Label();
            this.LblMoviesDirector = new System.Windows.Forms.Label();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.ClmTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabTvShows = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PBTvShowsArt = new System.Windows.Forms.PictureBox();
            this.TBTvShowsPlot = new System.Windows.Forms.TextBox();
            this.LblTvShowsPlot = new System.Windows.Forms.Label();
            this.TBTvShowsYear = new System.Windows.Forms.TextBox();
            this.LblTvShowsYear = new System.Windows.Forms.Label();
            this.TBTvShowsGenre = new System.Windows.Forms.TextBox();
            this.LblTvShowsGenre = new System.Windows.Forms.Label();
            this.DGVTvShows = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabMusic = new System.Windows.Forms.TabPage();
            this.DGVMusicPlaylist = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVMusic = new System.Windows.Forms.TreeView();
            this.TabFiles = new System.Windows.Forms.TabPage();
            this.TBNowPlayingSong = new System.Windows.Forms.TextBox();
            this.LblNowPlayingSong = new System.Windows.Forms.Label();
            this.GBNowPlaying.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBNowPlaying)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabMovies.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMoviesArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.TabTvShows.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTvShowsArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTvShows)).BeginInit();
            this.TabMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusicPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // GBNowPlaying
            // 
            this.GBNowPlaying.Controls.Add(this.TBNowPlayingSong);
            this.GBNowPlaying.Controls.Add(this.LblNowPlayingSong);
            this.GBNowPlaying.Controls.Add(this.TBNowPlayingRuntime);
            this.GBNowPlaying.Controls.Add(this.TBNowPlayingAlbum);
            this.GBNowPlaying.Controls.Add(this.TBNowPlayingArtist);
            this.GBNowPlaying.Controls.Add(this.LblNowPlayingAlbum);
            this.GBNowPlaying.Controls.Add(this.LblNowPlayingArtist);
            this.GBNowPlaying.Controls.Add(this.PBNowPlaying);
            this.GBNowPlaying.Location = new System.Drawing.Point(13, 11);
            this.GBNowPlaying.Margin = new System.Windows.Forms.Padding(4);
            this.GBNowPlaying.Name = "GBNowPlaying";
            this.GBNowPlaying.Padding = new System.Windows.Forms.Padding(4);
            this.GBNowPlaying.Size = new System.Drawing.Size(508, 134);
            this.GBNowPlaying.TabIndex = 0;
            this.GBNowPlaying.TabStop = false;
            this.GBNowPlaying.Text = "Now Playing";
            // 
            // TBNowPlayingRuntime
            // 
            this.TBNowPlayingRuntime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBNowPlayingRuntime.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNowPlayingRuntime.Location = new System.Drawing.Point(140, 99);
            this.TBNowPlayingRuntime.Name = "TBNowPlayingRuntime";
            this.TBNowPlayingRuntime.ReadOnly = true;
            this.TBNowPlayingRuntime.Size = new System.Drawing.Size(361, 24);
            this.TBNowPlayingRuntime.TabIndex = 4;
            this.TBNowPlayingRuntime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBNowPlayingAlbum
            // 
            this.TBNowPlayingAlbum.Location = new System.Drawing.Point(194, 71);
            this.TBNowPlayingAlbum.Name = "TBNowPlayingAlbum";
            this.TBNowPlayingAlbum.ReadOnly = true;
            this.TBNowPlayingAlbum.Size = new System.Drawing.Size(307, 22);
            this.TBNowPlayingAlbum.TabIndex = 6;
            // 
            // TBNowPlayingArtist
            // 
            this.TBNowPlayingArtist.Location = new System.Drawing.Point(194, 46);
            this.TBNowPlayingArtist.Name = "TBNowPlayingArtist";
            this.TBNowPlayingArtist.ReadOnly = true;
            this.TBNowPlayingArtist.Size = new System.Drawing.Size(307, 22);
            this.TBNowPlayingArtist.TabIndex = 5;
            // 
            // LblNowPlayingAlbum
            // 
            this.LblNowPlayingAlbum.AutoSize = true;
            this.LblNowPlayingAlbum.Location = new System.Drawing.Point(136, 74);
            this.LblNowPlayingAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNowPlayingAlbum.Name = "LblNowPlayingAlbum";
            this.LblNowPlayingAlbum.Size = new System.Drawing.Size(50, 14);
            this.LblNowPlayingAlbum.TabIndex = 2;
            this.LblNowPlayingAlbum.Text = "Album:";
            // 
            // LblNowPlayingArtist
            // 
            this.LblNowPlayingArtist.AutoSize = true;
            this.LblNowPlayingArtist.Location = new System.Drawing.Point(137, 49);
            this.LblNowPlayingArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNowPlayingArtist.Name = "LblNowPlayingArtist";
            this.LblNowPlayingArtist.Size = new System.Drawing.Size(45, 14);
            this.LblNowPlayingArtist.TabIndex = 1;
            this.LblNowPlayingArtist.Text = "Artist:";
            // 
            // PBNowPlaying
            // 
            this.PBNowPlaying.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBNowPlaying.Location = new System.Drawing.Point(8, 19);
            this.PBNowPlaying.Margin = new System.Windows.Forms.Padding(4);
            this.PBNowPlaying.Name = "PBNowPlaying";
            this.PBNowPlaying.Size = new System.Drawing.Size(120, 104);
            this.PBNowPlaying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBNowPlaying.TabIndex = 0;
            this.PBNowPlaying.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabMovies);
            this.tabControl1.Controls.Add(this.TabTvShows);
            this.tabControl1.Controls.Add(this.TabMusic);
            this.tabControl1.Controls.Add(this.TabFiles);
            this.tabControl1.Location = new System.Drawing.Point(13, 163);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 428);
            this.tabControl1.TabIndex = 1;
            // 
            // TabMovies
            // 
            this.TabMovies.Controls.Add(this.panel1);
            this.TabMovies.Controls.Add(this.DGVMovies);
            this.TabMovies.Location = new System.Drawing.Point(4, 23);
            this.TabMovies.Name = "TabMovies";
            this.TabMovies.Padding = new System.Windows.Forms.Padding(3);
            this.TabMovies.Size = new System.Drawing.Size(895, 401);
            this.TabMovies.TabIndex = 0;
            this.TabMovies.Text = "Movies";
            this.TabMovies.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PBMoviesArt);
            this.panel1.Controls.Add(this.TBMoviesPlot);
            this.panel1.Controls.Add(this.LblMoviesPlot);
            this.panel1.Controls.Add(this.TBMoviesRuntime);
            this.panel1.Controls.Add(this.LblMoviesRuntime);
            this.panel1.Controls.Add(this.TBMoviesYear);
            this.panel1.Controls.Add(this.LblMoviesYear);
            this.panel1.Controls.Add(this.TBMoviesWriter);
            this.panel1.Controls.Add(this.TBMoviesStudio);
            this.panel1.Controls.Add(this.TBMoviesGenre);
            this.panel1.Controls.Add(this.TBMoviesDirector);
            this.panel1.Controls.Add(this.LblMoviesGenre);
            this.panel1.Controls.Add(this.LblMoviesStudio);
            this.panel1.Controls.Add(this.LblMoviesWriter);
            this.panel1.Controls.Add(this.LblMoviesDirector);
            this.panel1.Location = new System.Drawing.Point(471, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 401);
            this.panel1.TabIndex = 1;
            // 
            // PBMoviesArt
            // 
            this.PBMoviesArt.Location = new System.Drawing.Point(291, 0);
            this.PBMoviesArt.Name = "PBMoviesArt";
            this.PBMoviesArt.Size = new System.Drawing.Size(133, 162);
            this.PBMoviesArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBMoviesArt.TabIndex = 16;
            this.PBMoviesArt.TabStop = false;
            // 
            // TBMoviesPlot
            // 
            this.TBMoviesPlot.BackColor = System.Drawing.SystemColors.Window;
            this.TBMoviesPlot.Location = new System.Drawing.Point(64, 168);
            this.TBMoviesPlot.Multiline = true;
            this.TBMoviesPlot.Name = "TBMoviesPlot";
            this.TBMoviesPlot.ReadOnly = true;
            this.TBMoviesPlot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBMoviesPlot.Size = new System.Drawing.Size(360, 233);
            this.TBMoviesPlot.TabIndex = 15;
            // 
            // LblMoviesPlot
            // 
            this.LblMoviesPlot.AutoSize = true;
            this.LblMoviesPlot.Location = new System.Drawing.Point(-3, 171);
            this.LblMoviesPlot.Name = "LblMoviesPlot";
            this.LblMoviesPlot.Size = new System.Drawing.Size(36, 14);
            this.LblMoviesPlot.TabIndex = 14;
            this.LblMoviesPlot.Text = "Plot:";
            // 
            // TBMoviesRuntime
            // 
            this.TBMoviesRuntime.BackColor = System.Drawing.SystemColors.Window;
            this.TBMoviesRuntime.Location = new System.Drawing.Point(64, 140);
            this.TBMoviesRuntime.Name = "TBMoviesRuntime";
            this.TBMoviesRuntime.ReadOnly = true;
            this.TBMoviesRuntime.Size = new System.Drawing.Size(221, 22);
            this.TBMoviesRuntime.TabIndex = 11;
            // 
            // LblMoviesRuntime
            // 
            this.LblMoviesRuntime.AutoSize = true;
            this.LblMoviesRuntime.Location = new System.Drawing.Point(-3, 143);
            this.LblMoviesRuntime.Name = "LblMoviesRuntime";
            this.LblMoviesRuntime.Size = new System.Drawing.Size(63, 14);
            this.LblMoviesRuntime.TabIndex = 10;
            this.LblMoviesRuntime.Text = "Runtime:";
            // 
            // TBMoviesYear
            // 
            this.TBMoviesYear.BackColor = System.Drawing.SystemColors.Window;
            this.TBMoviesYear.Location = new System.Drawing.Point(64, 112);
            this.TBMoviesYear.Name = "TBMoviesYear";
            this.TBMoviesYear.ReadOnly = true;
            this.TBMoviesYear.Size = new System.Drawing.Size(221, 22);
            this.TBMoviesYear.TabIndex = 9;
            // 
            // LblMoviesYear
            // 
            this.LblMoviesYear.AutoSize = true;
            this.LblMoviesYear.Location = new System.Drawing.Point(-3, 115);
            this.LblMoviesYear.Name = "LblMoviesYear";
            this.LblMoviesYear.Size = new System.Drawing.Size(40, 14);
            this.LblMoviesYear.TabIndex = 8;
            this.LblMoviesYear.Text = "Year:";
            // 
            // TBMoviesWriter
            // 
            this.TBMoviesWriter.BackColor = System.Drawing.SystemColors.Window;
            this.TBMoviesWriter.Location = new System.Drawing.Point(64, 28);
            this.TBMoviesWriter.Name = "TBMoviesWriter";
            this.TBMoviesWriter.ReadOnly = true;
            this.TBMoviesWriter.Size = new System.Drawing.Size(221, 22);
            this.TBMoviesWriter.TabIndex = 7;
            // 
            // TBMoviesStudio
            // 
            this.TBMoviesStudio.BackColor = System.Drawing.SystemColors.Window;
            this.TBMoviesStudio.Location = new System.Drawing.Point(64, 56);
            this.TBMoviesStudio.Name = "TBMoviesStudio";
            this.TBMoviesStudio.ReadOnly = true;
            this.TBMoviesStudio.Size = new System.Drawing.Size(221, 22);
            this.TBMoviesStudio.TabIndex = 6;
            // 
            // TBMoviesGenre
            // 
            this.TBMoviesGenre.BackColor = System.Drawing.SystemColors.Window;
            this.TBMoviesGenre.Location = new System.Drawing.Point(64, 84);
            this.TBMoviesGenre.Name = "TBMoviesGenre";
            this.TBMoviesGenre.ReadOnly = true;
            this.TBMoviesGenre.Size = new System.Drawing.Size(221, 22);
            this.TBMoviesGenre.TabIndex = 5;
            // 
            // TBMoviesDirector
            // 
            this.TBMoviesDirector.BackColor = System.Drawing.SystemColors.Window;
            this.TBMoviesDirector.Location = new System.Drawing.Point(64, 0);
            this.TBMoviesDirector.Name = "TBMoviesDirector";
            this.TBMoviesDirector.ReadOnly = true;
            this.TBMoviesDirector.Size = new System.Drawing.Size(221, 22);
            this.TBMoviesDirector.TabIndex = 4;
            // 
            // LblMoviesGenre
            // 
            this.LblMoviesGenre.AutoSize = true;
            this.LblMoviesGenre.Location = new System.Drawing.Point(-3, 87);
            this.LblMoviesGenre.Name = "LblMoviesGenre";
            this.LblMoviesGenre.Size = new System.Drawing.Size(50, 14);
            this.LblMoviesGenre.TabIndex = 3;
            this.LblMoviesGenre.Text = "Genre:";
            // 
            // LblMoviesStudio
            // 
            this.LblMoviesStudio.AutoSize = true;
            this.LblMoviesStudio.Location = new System.Drawing.Point(-3, 59);
            this.LblMoviesStudio.Name = "LblMoviesStudio";
            this.LblMoviesStudio.Size = new System.Drawing.Size(52, 14);
            this.LblMoviesStudio.TabIndex = 2;
            this.LblMoviesStudio.Text = "Studio:";
            // 
            // LblMoviesWriter
            // 
            this.LblMoviesWriter.AutoSize = true;
            this.LblMoviesWriter.Location = new System.Drawing.Point(-3, 31);
            this.LblMoviesWriter.Name = "LblMoviesWriter";
            this.LblMoviesWriter.Size = new System.Drawing.Size(51, 14);
            this.LblMoviesWriter.TabIndex = 1;
            this.LblMoviesWriter.Text = "Writer:";
            // 
            // LblMoviesDirector
            // 
            this.LblMoviesDirector.AutoSize = true;
            this.LblMoviesDirector.Location = new System.Drawing.Point(-3, 3);
            this.LblMoviesDirector.Name = "LblMoviesDirector";
            this.LblMoviesDirector.Size = new System.Drawing.Size(61, 14);
            this.LblMoviesDirector.TabIndex = 0;
            this.LblMoviesDirector.Text = "Director:";
            // 
            // DGVMovies
            // 
            this.DGVMovies.AllowUserToAddRows = false;
            this.DGVMovies.AllowUserToDeleteRows = false;
            this.DGVMovies.AllowUserToResizeRows = false;
            this.DGVMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.ColumnHeadersVisible = false;
            this.DGVMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmTitle});
            this.DGVMovies.Location = new System.Drawing.Point(0, 0);
            this.DGVMovies.MultiSelect = false;
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.ReadOnly = true;
            this.DGVMovies.RowHeadersVisible = false;
            this.DGVMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMovies.ShowEditingIcon = false;
            this.DGVMovies.Size = new System.Drawing.Size(459, 401);
            this.DGVMovies.TabIndex = 0;
            this.DGVMovies.SelectionChanged += new System.EventHandler(this.DGVMovies_SelectionChanged);
            // 
            // ClmTitle
            // 
            this.ClmTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmTitle.HeaderText = "Title";
            this.ClmTitle.Name = "ClmTitle";
            this.ClmTitle.ReadOnly = true;
            // 
            // TabTvShows
            // 
            this.TabTvShows.Controls.Add(this.panel2);
            this.TabTvShows.Controls.Add(this.DGVTvShows);
            this.TabTvShows.Location = new System.Drawing.Point(4, 23);
            this.TabTvShows.Name = "TabTvShows";
            this.TabTvShows.Padding = new System.Windows.Forms.Padding(3);
            this.TabTvShows.Size = new System.Drawing.Size(895, 401);
            this.TabTvShows.TabIndex = 1;
            this.TabTvShows.Text = "Tv Shows";
            this.TabTvShows.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PBTvShowsArt);
            this.panel2.Controls.Add(this.TBTvShowsPlot);
            this.panel2.Controls.Add(this.LblTvShowsPlot);
            this.panel2.Controls.Add(this.TBTvShowsYear);
            this.panel2.Controls.Add(this.LblTvShowsYear);
            this.panel2.Controls.Add(this.TBTvShowsGenre);
            this.panel2.Controls.Add(this.LblTvShowsGenre);
            this.panel2.Location = new System.Drawing.Point(471, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 401);
            this.panel2.TabIndex = 2;
            // 
            // PBTvShowsArt
            // 
            this.PBTvShowsArt.Location = new System.Drawing.Point(291, 0);
            this.PBTvShowsArt.Name = "PBTvShowsArt";
            this.PBTvShowsArt.Size = new System.Drawing.Size(133, 162);
            this.PBTvShowsArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBTvShowsArt.TabIndex = 16;
            this.PBTvShowsArt.TabStop = false;
            // 
            // TBTvShowsPlot
            // 
            this.TBTvShowsPlot.BackColor = System.Drawing.SystemColors.Window;
            this.TBTvShowsPlot.Location = new System.Drawing.Point(64, 168);
            this.TBTvShowsPlot.Multiline = true;
            this.TBTvShowsPlot.Name = "TBTvShowsPlot";
            this.TBTvShowsPlot.ReadOnly = true;
            this.TBTvShowsPlot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBTvShowsPlot.Size = new System.Drawing.Size(360, 233);
            this.TBTvShowsPlot.TabIndex = 15;
            // 
            // LblTvShowsPlot
            // 
            this.LblTvShowsPlot.AutoSize = true;
            this.LblTvShowsPlot.Location = new System.Drawing.Point(-3, 171);
            this.LblTvShowsPlot.Name = "LblTvShowsPlot";
            this.LblTvShowsPlot.Size = new System.Drawing.Size(36, 14);
            this.LblTvShowsPlot.TabIndex = 14;
            this.LblTvShowsPlot.Text = "Plot:";
            // 
            // TBTvShowsYear
            // 
            this.TBTvShowsYear.BackColor = System.Drawing.SystemColors.Window;
            this.TBTvShowsYear.Location = new System.Drawing.Point(64, 28);
            this.TBTvShowsYear.Name = "TBTvShowsYear";
            this.TBTvShowsYear.ReadOnly = true;
            this.TBTvShowsYear.Size = new System.Drawing.Size(221, 22);
            this.TBTvShowsYear.TabIndex = 9;
            // 
            // LblTvShowsYear
            // 
            this.LblTvShowsYear.AutoSize = true;
            this.LblTvShowsYear.Location = new System.Drawing.Point(-3, 31);
            this.LblTvShowsYear.Name = "LblTvShowsYear";
            this.LblTvShowsYear.Size = new System.Drawing.Size(40, 14);
            this.LblTvShowsYear.TabIndex = 8;
            this.LblTvShowsYear.Text = "Year:";
            // 
            // TBTvShowsGenre
            // 
            this.TBTvShowsGenre.BackColor = System.Drawing.SystemColors.Window;
            this.TBTvShowsGenre.Location = new System.Drawing.Point(64, 0);
            this.TBTvShowsGenre.Name = "TBTvShowsGenre";
            this.TBTvShowsGenre.ReadOnly = true;
            this.TBTvShowsGenre.Size = new System.Drawing.Size(221, 22);
            this.TBTvShowsGenre.TabIndex = 5;
            // 
            // LblTvShowsGenre
            // 
            this.LblTvShowsGenre.AutoSize = true;
            this.LblTvShowsGenre.Location = new System.Drawing.Point(-3, 3);
            this.LblTvShowsGenre.Name = "LblTvShowsGenre";
            this.LblTvShowsGenre.Size = new System.Drawing.Size(50, 14);
            this.LblTvShowsGenre.TabIndex = 3;
            this.LblTvShowsGenre.Text = "Genre:";
            // 
            // DGVTvShows
            // 
            this.DGVTvShows.AllowUserToAddRows = false;
            this.DGVTvShows.AllowUserToDeleteRows = false;
            this.DGVTvShows.AllowUserToResizeRows = false;
            this.DGVTvShows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVTvShows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTvShows.ColumnHeadersVisible = false;
            this.DGVTvShows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.DGVTvShows.Location = new System.Drawing.Point(0, 0);
            this.DGVTvShows.MultiSelect = false;
            this.DGVTvShows.Name = "DGVTvShows";
            this.DGVTvShows.ReadOnly = true;
            this.DGVTvShows.RowHeadersVisible = false;
            this.DGVTvShows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTvShows.ShowEditingIcon = false;
            this.DGVTvShows.Size = new System.Drawing.Size(459, 401);
            this.DGVTvShows.TabIndex = 1;
            this.DGVTvShows.SelectionChanged += new System.EventHandler(this.DGVTvShows_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TabMusic
            // 
            this.TabMusic.Controls.Add(this.DGVMusicPlaylist);
            this.TabMusic.Controls.Add(this.TVMusic);
            this.TabMusic.Location = new System.Drawing.Point(4, 23);
            this.TabMusic.Name = "TabMusic";
            this.TabMusic.Size = new System.Drawing.Size(895, 401);
            this.TabMusic.TabIndex = 2;
            this.TabMusic.Text = "Music";
            this.TabMusic.UseVisualStyleBackColor = true;
            // 
            // DGVMusicPlaylist
            // 
            this.DGVMusicPlaylist.AllowUserToAddRows = false;
            this.DGVMusicPlaylist.AllowUserToDeleteRows = false;
            this.DGVMusicPlaylist.AllowUserToResizeRows = false;
            this.DGVMusicPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVMusicPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMusicPlaylist.ColumnHeadersVisible = false;
            this.DGVMusicPlaylist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.DGVMusicPlaylist.Location = new System.Drawing.Point(446, 0);
            this.DGVMusicPlaylist.MultiSelect = false;
            this.DGVMusicPlaylist.Name = "DGVMusicPlaylist";
            this.DGVMusicPlaylist.ReadOnly = true;
            this.DGVMusicPlaylist.RowHeadersVisible = false;
            this.DGVMusicPlaylist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMusicPlaylist.ShowEditingIcon = false;
            this.DGVMusicPlaylist.Size = new System.Drawing.Size(449, 401);
            this.DGVMusicPlaylist.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // TVMusic
            // 
            this.TVMusic.Location = new System.Drawing.Point(0, 0);
            this.TVMusic.Name = "TVMusic";
            this.TVMusic.Size = new System.Drawing.Size(440, 401);
            this.TVMusic.TabIndex = 0;
            // 
            // TabFiles
            // 
            this.TabFiles.Location = new System.Drawing.Point(4, 23);
            this.TabFiles.Name = "TabFiles";
            this.TabFiles.Size = new System.Drawing.Size(895, 401);
            this.TabFiles.TabIndex = 3;
            this.TabFiles.Text = "Files";
            this.TabFiles.UseVisualStyleBackColor = true;
            // 
            // TBNowPlayingSong
            // 
            this.TBNowPlayingSong.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNowPlayingSong.Location = new System.Drawing.Point(194, 19);
            this.TBNowPlayingSong.Name = "TBNowPlayingSong";
            this.TBNowPlayingSong.ReadOnly = true;
            this.TBNowPlayingSong.Size = new System.Drawing.Size(307, 23);
            this.TBNowPlayingSong.TabIndex = 9;
            // 
            // LblNowPlayingSong
            // 
            this.LblNowPlayingSong.AutoSize = true;
            this.LblNowPlayingSong.Location = new System.Drawing.Point(137, 23);
            this.LblNowPlayingSong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNowPlayingSong.Name = "LblNowPlayingSong";
            this.LblNowPlayingSong.Size = new System.Drawing.Size(44, 14);
            this.LblNowPlayingSong.TabIndex = 8;
            this.LblNowPlayingSong.Text = "Song:";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 603);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GBNowPlaying);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XBMC Remote";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.GBNowPlaying.ResumeLayout(false);
            this.GBNowPlaying.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBNowPlaying)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabMovies.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBMoviesArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.TabTvShows.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBTvShowsArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTvShows)).EndInit();
            this.TabMusic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMusicPlaylist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBNowPlaying;
        private System.Windows.Forms.PictureBox PBNowPlaying;
        private System.Windows.Forms.Label LblNowPlayingAlbum;
        private System.Windows.Forms.Label LblNowPlayingArtist;
        private System.Windows.Forms.TextBox TBNowPlayingAlbum;
        private System.Windows.Forms.TextBox TBNowPlayingArtist;
        private System.Windows.Forms.TextBox TBNowPlayingRuntime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabMovies;
        private System.Windows.Forms.TabPage TabTvShows;
        private System.Windows.Forms.TabPage TabMusic;
        private System.Windows.Forms.TabPage TabFiles;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTitle;
        private System.Windows.Forms.Label LblMoviesDirector;
        private System.Windows.Forms.TextBox TBMoviesWriter;
        private System.Windows.Forms.TextBox TBMoviesStudio;
        private System.Windows.Forms.TextBox TBMoviesGenre;
        private System.Windows.Forms.TextBox TBMoviesDirector;
        private System.Windows.Forms.Label LblMoviesGenre;
        private System.Windows.Forms.Label LblMoviesStudio;
        private System.Windows.Forms.Label LblMoviesWriter;
        private System.Windows.Forms.TextBox TBMoviesPlot;
        private System.Windows.Forms.Label LblMoviesPlot;
        private System.Windows.Forms.TextBox TBMoviesRuntime;
        private System.Windows.Forms.Label LblMoviesRuntime;
        private System.Windows.Forms.TextBox TBMoviesYear;
        private System.Windows.Forms.Label LblMoviesYear;
        private System.Windows.Forms.PictureBox PBMoviesArt;
        private System.Windows.Forms.DataGridView DGVTvShows;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PBTvShowsArt;
        private System.Windows.Forms.TextBox TBTvShowsPlot;
        private System.Windows.Forms.Label LblTvShowsPlot;
        private System.Windows.Forms.TextBox TBTvShowsYear;
        private System.Windows.Forms.Label LblTvShowsYear;
        private System.Windows.Forms.TextBox TBTvShowsGenre;
        private System.Windows.Forms.Label LblTvShowsGenre;
        private System.Windows.Forms.TreeView TVMusic;
        private System.Windows.Forms.DataGridView DGVMusicPlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox TBNowPlayingSong;
        private System.Windows.Forms.Label LblNowPlayingSong;
    }
}

