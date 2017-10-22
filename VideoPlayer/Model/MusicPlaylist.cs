using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlayer.Model
{
   public class MusicPlaylist
    {
       public string Header { set; get; }
       public ObservableCollection<MediaData> observableMusicCollection { get; set; }

        public MusicPlaylist()
        {

        }
       public MusicPlaylist(string Header)
        {
            this.Header = Header;
        }


        public static ObservableCollection<MusicPlaylist> Desiriasisation()
        {
            throw new Exception();
        }
    }
}
