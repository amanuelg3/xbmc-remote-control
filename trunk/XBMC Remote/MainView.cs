using System;
using System.Collections.Generic;
using System.Windows.Forms;
using XbmcJson;

namespace XBMC_Remote
{
    public partial class MainView : Form
    {
        XbmcConnection Xbmc;

        public MainView()
        {
            InitializeComponent();
        }

        public void RefreshNowPlaying()
        {
            if (Xbmc.AudioPlaylist.GetCurrentItem() != null)
            {
                Song NowPlaying = Xbmc.AudioPlaylist.GetCurrentItemAllFields();
                TBNowPlayingSong.Text = NowPlaying.Title;
                TBNowPlayingArtist.Text = NowPlaying.Artist;
                TBNowPlayingAlbum.Text = NowPlaying.Album;
                PBNowPlaying.Image = Xbmc.Files.GetImageFromThumbnail(NowPlaying.Thumbnail);
                TBNowPlayingRuntime.Text = Xbmc.AudioPlayer.GetTimeFormatted();
             }

            if (Xbmc.VideoPlaylist.GetCurrentItem() != null)
            {
                PlaylistItem NowPlaying = Xbmc.VideoPlaylist.GetCurrentItemAllFields();
                TBNowPlayingAlbum.Text = NowPlaying.Label;
            }
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

        private void MainView_Load(object sender, EventArgs e)
        {
            Xbmc = new XbmcConnection("192.168.1.200", 80, "xbmc", "test");

            if (Xbmc.Status.IsConnected)
            {
                RefreshMovies();
                RefreshTvShows();
                RefreshMusic();
                RefreshNowPlaying();
             }
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
    }
}
