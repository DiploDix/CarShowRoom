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
using CarShowRoom.View;
using System.Collections.ObjectModel;

namespace CarShowRoom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CarsList car = new CarsList();
        UsersList user = new UsersList();
        FileAction file = new FileAction();
        Cars carView;
        Search searchView;
        Users usersView;
        About aboutView;
        Help helpView;
        public MainWindow()
        {
            InitializeComponent();
        }

        /* Переход во фрейме к странице /View/Search.xaml */
        private void BorderSearch_Click(object sender, MouseButtonEventArgs e)
        {
            if (searchView == null)
                searchView = new Search();
            
            frameWindow.Content = searchView;
        }

        /* Переход во фрейме к странице /View/Cars.xaml */
        private void BorderCars_Click(object sender, MouseButtonEventArgs e)
        {
            if (carView == null)
                carView = new Cars();

            frameWindow.Content = carView;
        }

        /* Переход во фрейме к странице /View/Users.xaml */
        private void BorderUsers_Click(object sender, MouseButtonEventArgs e)
        {
            if (usersView == null)
                usersView = new Users();
            
            frameWindow.Content = usersView;
        }

        private void BorderAbout_Click(object sender, MouseButtonEventArgs e)
        {
            if (aboutView == null)
                aboutView = new About();

            frameWindow.Content = aboutView;
        }


        /* Загрузить колекции с файла */
        private void ImageUpload_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Текстовый файл (*.txt)|*.txt";
            openFile.CheckFileExists = true;
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == true)
                file.UploadFile(openFile.FileName);
        }

        /* Сохранить как */
        private void ImageDownload_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Текстовый файл (*.txt)|*.txt";
            saveFile.CheckFileExists = true;
            saveFile.CreatePrompt = true;

            if (saveFile.ShowDialog() == true)
                file.SaveFileAll(saveFile.FileName, car.CarList, user.UserList);
        }

        /* Сохранить */
        private void ImageDownloadNow_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            file.SaveFileAll("current", car.CarList, user.UserList);
        }

        private void ImageHelpView_PreviewMouseDown(object sender, MouseButtonEventArgs e )
        {
            if (helpView == null)
                helpView = new Help();

            frameWindow.Content = helpView;
        }
    }
}
