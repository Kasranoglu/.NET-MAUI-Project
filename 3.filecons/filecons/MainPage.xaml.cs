using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
namespace filecons;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();




        List<File> Files = new List<File>()
        {
             new File { Name = "ilahimorluk_ErkinKoray_TurkishGodOfRock.mp3"},
             new File { Name = "MyPlaylist_Spotify.exe"},
             new File { Name = "VisualStudioForMacInstaller__4650352e77004cbf8e3794fcf4628999.dmg"},
             new File { Name = "Faceebookaras"},
             new File { Name = "Kanye West LA Concert Video.mp4"},
             new File { Name = "Istanbul Hatırası"},
             new File { Name = "Flutter"},
             new File { Name = "filecon.exe"},
             new File { Name = "funny.pic"},
             new File { Name = "Forest"},
             new File { Name = "Horoscoso.net"},
             new File { Name = "TurretDash.exe"},
             new File { Name = "Fifa 23.exe"},
             new File { Name = "Trabzonspor"},
        };

        FileList.ItemsSource = Files;

        List<File> Files_modified = new List<File>()
        {
            new File { Modified = "23/05/2023" },
            new File { Modified = "19/03/2024" },
            new File { Modified = "04/01/2023" },
            new File { Modified = "28/10/2019" },
            new File { Modified = "07/01/2020" },
            new File { Modified = "20/02/2011" },
            new File { Modified = "24/11/2023" },
            new File { Modified = "21/02/2023" },
            new File { Modified = "27/12/2023" },
            new File { Modified = "24/02/2023" },
            new File { Modified = "26/07/2018" },
            new File { Modified = "15/09/2019" },
            new File { Modified = "04/02/2020" },
            new File { Modified = "15/05/2012" },

        };

        FileModified.ItemsSource = Files_modified;
        List<File> Files_size = new List<File>()
        {
             new File { Name = "999 MB"},
             new File { Name = "750 MB"},
             new File { Name = "980 MB"},
             new File { Name = "190 MB"},
             new File { Name = "2.4 GB"},
             new File { Name = "420 KB"},
             new File { Name = "190 KB"},
             new File { Name = "499 MB"},
             new File { Name = "120 MB"},
             new File { Name = "120 KB"},
             new File { Name = "256 MB"},
             new File { Name = "233 KB"},
             new File { Name = "345 KB"},
             new File { Name = "222 MB"},
        };
        FileSize.ItemsSource = Files_size;

    }

    public class File
    {
        public string Name { get; set; }
        public string Modified { get; set; }
        public string Size { get; set; }
    }


}