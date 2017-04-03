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

namespace WpfTreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var logicalDrive in Directory.GetLogicalDrives())
            {
                var item = new TreeViewItem {Header = logicalDrive, Tag = logicalDrive};
                item.Items.Add(null);
                item.Expanded += TreeViewITem_Expanded;

                FolderView.Items.Add(item);
            }
        }

        private void TreeViewITem_Expanded(object sender, RoutedEventArgs e)
        {
            var item = (TreeViewItem) sender;

            if (item.Items.Count != 1 || item.Items[0] != null) return;

            item.Items.Clear();

            var fullPath = item.Tag as string;

            GetFolders(fullPath, item);
            GetFiles(fullPath, item);
        }

        private void GetFolders(string fullPath, TreeViewItem item)
        {
            var directories = new List<string>();

            try
            {
                var dirs = Directory.GetDirectories(fullPath);

                if (dirs.Length > 0)
                    directories.AddRange(dirs);
            }
            catch
            {
            }

            directories.ForEach((d) =>
            {
                DirectoryInfo info = new DirectoryInfo(d);
                var subItem = new TreeViewItem
                {
                    Header = info.Name,
                    Tag = info.FullName
                };
                subItem.Items.Add(null);
                subItem.Expanded += TreeViewITem_Expanded;

                item.Items.Add(subItem);
            });
        }

        private void GetFiles(string fullPath, TreeViewItem item)
        {
            var filesList = new List<string>();

            try
            {
                var files = Directory.GetFiles(fullPath);

                if (files.Length > 0)
                    filesList.AddRange(files);
            }
            catch
            {
                // ignored
            }

            filesList.ForEach(f =>
            {
                FileInfo info = new FileInfo(f);
                var subItem = new TreeViewItem
                {
                    Header = info.Name,
                    Tag = info.FullName
                };

                item.Items.Add(subItem);
            });
        }
    }
}
