using System;
using System.Collections.Generic;
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
using CarShowRoom.ViewModel;
using Microsoft.Win32;
using System.Collections.ObjectModel;

namespace CarShowRoom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Uri uriToSearchPage = new Uri("/View/Search.xaml", UriKind.Relative);
        Uri uriToCarsPage = new Uri("/View/Cars.xaml", UriKind.Relative);
        Uri uriToUsersPage = new Uri("/View/Users.xaml", UriKind.Relative);

        FileAction file = new FileAction();

        public MainWindow()
        {
            InitializeComponent();
        }

        /* Переход во фрейме к странице /View/Search.xaml */
        private void BorderSearch_Click(object sender, MouseButtonEventArgs e)
        {
            frameWindow.Source = uriToSearchPage;
        }

        /* Переход во фрейме к странице /View/Cars.xaml */
        private void BorderCars_Click(object sender, MouseButtonEventArgs e)
        {
            frameWindow.Source = uriToCarsPage;
        }

        /* Переход во фрейме к странице /View/Users.xaml */
        private void BorderUsers_Click(object sender, MouseButtonEventArgs e)
        {
            frameWindow.Source = uriToUsersPage;
        }

        private void ImageUpload_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Текстовый файл (*.txt)|*.txt";
            openFile.CheckFileExists = true;
            openFile.Multiselect = false;
            if (openFile.ShowDialog() == true)
            {
                file.UploadFile(openFile.FileName);
            }
        }

        private void ImageDownload_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Текстовый файл (*.txt)|*.txt";
            saveFile.CheckFileExists = true;
            saveFile.CreatePrompt = true;
            if (saveFile.ShowDialog() == true)
            {
                file.SaveFile(saveFile.FileName);
            }
        }
    }
}
