using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XbmcJson;
using System.Threading;
using System.Drawing;

namespace XBMC_Remote
{
    public partial class MainView : Form
    {
        XbmcConnection Xbmc;
        System.Windows.Forms.Timer UpdateTimerOne = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer UpdateTimerThree = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer UpdateTimerTen = new System.Windows.Forms.Timer();
        string CurrentSong = "";

        public MainView()
        {
            InitializeComponent();
        }

        public void RefreshNowPlaying()
        {
            if (Xbmc.AudioPlaylist.GetCurrentItem() != null)
            {
                Song NowPlaying = Xbmc.AudioPlaylist.GetCurrentItem(new string[] {"title", "artist", "album"} );
                if (NowPlaying.Title != CurrentSong)
                {
                    CurrentSong = NowPlaying.Title;
                    TBNowPlayingSong.Text = NowPlaying.Title;
                    TBNowPlayingArtist.Text = NowPlaying.Artist;
                    TBNowPlayingAlbum.Text = NowPlaying.Album;
                    PBNowPlaying.Image = Xbmc.Files.GetImageFromThumbnail(NowPlaying.Thumbnail);
                    System.Drawing.Size size = new System.Drawing.Size(32,32);

                    if (PBNowPlaying.Image.Size == size)
                    {
                        PBNowPlaying.Image = Image.FromFile(Environment.CurrentDirectory + @"\Data\" + "music-icon.jpg");
                    }
                }

                TBNowPlayingRuntime.Text = Xbmc.AudioPlayer.GetTimeFormatted();
             }

            if (Xbmc.VideoPlaylist.GetCurrentItem() != null)
            {
                PlaylistItem NowPlaying = Xbmc.VideoPlaylist.GetCurrentItemAllFields();
                TBNowPlayingAlbum.Text = NowPlaying.Label;
            }
        }

        public void RefreshSystemStatsThree()
        {
            TBFreeMemory.Text = Xbmc.System_.GetFreeMemory();
            TBFPS.Text = Xbmc.System_.GetFPS().ToString(); 
        }

        public void RefreshSystemStatsTen()
        {

            TBResolution.Text = Xbmc.System_.GetScreenResolution();
            TBBuild.Text = Xbmc.System_.GetBuildVersion();
            TBUPT.Text = Xbmc.System_.GetUptime();
        }

        public void RefreshMovies()
        {
            DGVMovies.Rows.Clear();

            foreach (Movie m in Xbmc.VideoLibrary.GetMovies())
            {
                DataGridViewRow NewRow = new DataGridViewRow();
                NewRow.CreateCells(DGVMovies, new object[] {m.Label});
                DGVMovies.Rows.Add(NewRow);
            }
        }

        public void RefreshTvShows()
        {
            DGVTvShows.Rows.Clear();

            foreach(TvShow tv in Xbmc.VideoLibrary.GetTvShows())
            {
                DataGridViewRow NewRow = new DataGridViewRow();
                NewRow.CreateCells(DGVMovies, new object[] {tv.Label });
                DGVTvShows.Rows.Add(NewRow);
            }
        }

        public void RefreshMusic()
        {
            foreach (Artist ar in Xbmc.AudioLibrary.GetArtists())
            {
                TreeNode ArtistNode = new TreeNode(ar.Label);
                TVMusic.Nodes.Add(ArtistNode);

                foreach (Album al in Xbmc.AudioLibrary.GetAlbumsByArtist(ar._id))
                {
                    TreeNode AlbumNode = new TreeNode(al.Label);
                    ArtistNode.Nodes.Add(AlbumNode);

                    foreach (Song s in Xbmc.AudioLibrary.GetSongsByAlbum(al._id))
                    {
                        TreeNode SongNode = new TreeNode(s.Label);
                        AlbumNode.Nodes.Add(SongNode);
                    }
                }
            }

            foreach (Song i in Xbmc.AudioPlaylist.GetItems())
            {
                DataGridViewRow NewRow = new DataGridViewRow();
                NewRow.CreateCells(DGVMovies, new object[] {i.Label});
                DGVMusicPlaylist.Rows.Add(NewRow); 
            }
        }

        void UpdateTimerTen_Tick(Object myObject, EventArgs myEventArgs)
        {
            UpdateTimerTen.Stop();
            if (Xbmc.Status.IsConnected)
            {
                RefreshSystemStatsTen();
            }
            UpdateTimerTen.Enabled = true;
        }

        void UpdateTimerThree_Tick(Object myObject, EventArgs myEventArgs)
        {
            UpdateTimerThree.Stop();
            if (Xbmc.Status.IsConnected)
            {
                RefreshSystemStatsThree();  
            }
            UpdateTimerThree.Enabled = true;
        }

        void UpdateTimerOne_Tick(Object myObject, EventArgs myEventArgs)
        {
            UpdateTimerOne.Stop();
            if (Xbmc.Status.IsConnected)
            {
                RefreshNowPlaying();  
            }
            UpdateTimerOne.Enabled = true;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Xbmc = new XbmcConnection("192.168.1.200", 80, "xbmc", "test");
            UpdateTimerOne.Interval = 1000;
            UpdateTimerThree.Interval = 3000;
            UpdateTimerTen.Interval = 10000;
            UpdateTimerOne.Tick += new EventHandler(UpdateTimerOne_Tick);
            UpdateTimerThree.Tick += new EventHandler(UpdateTimerThree_Tick);
            UpdateTimerTen.Tick += new EventHandler(UpdateTimerTen_Tick);
            UpdateTimerOne.Start();
            UpdateTimerThree.Start();
            UpdateTimerTen.Start();
            if (Xbmc.Status.IsConnected)
            {
                RefreshMovies();
                RefreshTvShows();
                RefreshMusic();
             //  ThreadPool.QueueUserWorkItem(new WaitCallback(RefreshMusic), XbmcConnection Xbmc);
            }

            UpdateTimerOne.Start();
        }
          
        private void DGVMovies_SelectionChanged(object sender, EventArgs e)
        {
            Movie m = Xbmc.VideoLibrary.GetMoviesAllFields(null, null, DGVMovies.CurrentRow.Index, DGVMovies.CurrentRow.Index + 1)[0];
            TBMoviesDirector.Text = m.Director;
            TBMoviesWriter.Text = m.Writer;
            TBMoviesStudio.Text = m.Studio;
            TBMoviesGenre.Text = m.Genre;
            TBMoviesYear.Text = m.Year.ToString();
            TBMoviesRuntime.Text = m.Runtime;
            TBMoviesPlot.Text = m.Plot;
            PBMoviesArt.Image = Xbmc.Files.GetImageFromThumbnail(m.Thumbnail);
        }

        private void DGVTvShows_SelectionChanged(object sender, EventArgs e)
        {
            TvShow tv = Xbmc.VideoLibrary.GetTvShowsAllFields(null, null, DGVTvShows.CurrentRow.Index, DGVTvShows.CurrentRow.Index + 1)[0];
            TBTvShowsGenre.Text = tv.Genre;
            TBTvShowsYear.Text = tv.Year.ToString();
            TBTvShowsPlot.Text = tv.Plot;
            PBTvShowsArt.Image = Xbmc.Files.GetImageFromThumbnail(tv.Thumbnail);
        }

        private void BTNPlayPause_Click(object sender, EventArgs e)
        {
            Xbmc.AudioPlayer.PlayPause();
        }

        private void BTNStop_Click(object sender, EventArgs e)
        {
            Xbmc.AudioPlayer.Stop();
        }

        private void BTNSkipPrevious_Click(object sender, EventArgs e)
        {
            Xbmc.AudioPlayer.SkipPrevious();
        }

        private void BTNSkipNext_Click(object sender, EventArgs e)
        {
            Xbmc.AudioPlayer.SkipNext();
        }

        private void BTNRewind_Click(object sender, EventArgs e)
        {
            Xbmc.AudioPlayer.Rewind();
        }

        private void BTNFastForward_Click(object sender, EventArgs e)
        {
            Xbmc.AudioPlayer.Forward();
        }

        private void BTNRecord_Click(object sender, EventArgs e)
        {
            Xbmc.AudioPlayer.Record();
        }
    }
}
