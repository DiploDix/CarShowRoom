using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using CarShowRoom.ViewModel;


namespace CarShowRoom.View
{
    public partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
        }

        /* Кнопка сохранения выборки в файл */
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

        /* Кнопка обновления списка */
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            SearchViewModel search = (SearchViewModel)this.Resources["searchVM"];
            search.UpdateSearch();
        }
    }
}
