using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoPlayer.View
{
    /// <summary>
    /// Interaction logic for MusicPage.xaml
    /// </summary>
    public partial class MusicPage : Page
    {
        private object dummyNode = null;

        public MusicPage()
        {
            InitializeComponent();

            LoadAllDirectoryAndFilesToTreView();
           
            MainPlayer.Play();
        }

        private void LoadAllDirectoryAndFilesToTreView()
        {
            foreach (string s in Directory.GetLogicalDrives())
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = s;
                item.Tag = s;
                item.FontWeight = FontWeights.Normal;
                item.Items.Add(dummyNode);
                item.Expanded += new RoutedEventHandler(folder_Expanded);
                ReviewPCItemTreeView.Items.Add(item);
            }
        }

        void folder_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)sender;
            if (item.Items.Count == 1 && item.Items[0] == dummyNode)
            {
                item.Items.Clear();
                try
                {
                    foreach (string s in Directory.GetDirectories(item.Tag.ToString()))
                    {
                        TreeViewItem subitem = new TreeViewItem();
                        subitem.Header = s.Substring(s.LastIndexOf("\\") + 1);
                        subitem.Tag = s;
                        subitem.FontWeight = FontWeights.Normal;
                        subitem.Items.Add(dummyNode);
                        subitem.Expanded += new RoutedEventHandler(folder_Expanded);
                        item.Items.Add(subitem);
                    }
                    foreach (string s in Directory.GetFiles(item.Tag.ToString()))
                    {
                        if (s.Contains(".mp3"))
                        {
                            TreeViewItem subitem = new TreeViewItem();
                            subitem.Header = s.Substring(s.LastIndexOf("\\") + 1);
                            subitem.Tag = s;
                            subitem.FontWeight = FontWeights.Normal;
                            subitem.Items.Add(dummyNode);
                            subitem.Expanded += new RoutedEventHandler(folder_Expanded);
                            item.Items.Add(subitem);
                        }
                    }
                }
                catch (Exception) { }
            }
        }
    }
}
