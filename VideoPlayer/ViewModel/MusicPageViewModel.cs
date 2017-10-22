using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VideoPlayer.Infasrtucture;
using VideoPlayer.Model;

namespace VideoPlayer.ViewModel
{
    public class MusicPageViewModel:BaseViewModel
    {
        #region PrivateField

        private MediaData currentTrack;
        private ObservableCollection<MusicPlaylist> musicPlaylists;
        private MusicPlaylist newPlaylist;
        #endregion

        #region PublicProperty
        
        public MediaData CurrentTrack
        {
            get
            {
                return currentTrack ?? new MediaData();
            }
            set
            {
                currentTrack = value;
                OnPropertyChanged("currentTrack");
            }
            
        }
        public ObservableCollection<MusicPlaylist> MusicPlaylists
        {
            get
            {
                return musicPlaylists ??  MusicPlaylist.Desiriasisation();
            }
        }
        public MusicPlaylist NewPlaylist
        {
            get
            {
               return newPlaylist ?? new MusicPlaylist();
            }
            set
            {
                newPlaylist = value;
                OnPropertyChanged("currentPlaylist");
            }
        }

        #endregion


        #region Commands

             #region RelayComandField

                private RelayCommand addNewPlaylist;
                private RelayCommand addTrackToPlaylist;

             #endregion;


        public ICommand AddNewPlaylist
        {
            get
            {
                return addNewPlaylist ?? new RelayCommand(ExecuteAddNewPlaylistCommand);
            }
        }
        public ICommand AddTrackToPlaylist
        {
            get
            {
                throw new NotImplementedException();
            }
        }


        #endregion

        #region OtherMethod

        private void ExecuteAddNewPlaylistCommand(object obj)
        {
            newPlaylist.Header= newPlaylist.Header ?? string.Format("Плейлист {0}",musicPlaylists.Count+1);
            this.musicPlaylists.Add(newPlaylist);
            newPlaylist = null;
        }


        #endregion;
    }
}
