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
using Microsoft.Win32;
using CarShowRoom.ViewModel;
using CarShowRoom.Model;


namespace CarShowRoom.View
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            FileAction file = new FileAction();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Текстовый файл (*.txt)|*.txt";
            saveFile.CheckFileExists = true;
            saveFile.CreatePrompt = true;

            if (saveFile.ShowDialog() == true)
                file.SaveFileCar(saveFile.FileName, ((SearchViewModel)this.Resources["searchVM"]).GetListCar);
        }

        /* Reset search engine */
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            SearchViewModel search = (SearchViewModel)this.Resources["searchVM"];
            search.UpdateSearch();
        }
    }
}
