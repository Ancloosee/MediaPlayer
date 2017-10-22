using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlayer.Model
{
    public  class MediaData
    {
        string Name { set; get; }
        string Path { set; get; }
        int Year { set; get; }
        int Size { set; get; }




        
        public static List<MediaData> GetTestMediaDataList()
        {
            return new List<MediaData>()
            {
                new MediaData(){Name="New Film 1",Path="new Path 1",Year=2005,Size=30},
                new MediaData() { Name = "New Film 2", Path = "new Path 2", Year = 2005, Size = 30 },
                new MediaData() { Name = "New Film 3", Path = "new Path 3", Year = 2005, Size = 30 },
                new MediaData() { Name = "New Film 4", Path = "new Path 4", Year = 2005, Size = 30 }
            };
        }
    }







}
