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
using System.Windows.Shapes;
using CarShowRoom.Model;
using CarShowRoom.ViewModel;
using Microsoft.Win32;

namespace CarShowRoom.View
{
    /// <summary>
    /// Логика взаимодействия для SelectionCarWindow.xaml
    /// </summary>
    public partial class SelectionCarWindow : Window
    {
        public SelectionCarWindow(User user)
        {
            InitializeComponent();
            ((SelectionCarViewModel)this.Resources["selectVM"]).SelectionCar(user);
        }

        /* Save list in file */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FileAction file = new FileAction();
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Текстовый файл (*.txt)|*.txt";
            saveFile.CheckFileExists = true;
            saveFile.CreatePrompt = true;

            if (saveFile.ShowDialog() == true)
                file.SaveFileCar(saveFile.FileName, ((SelectionCarViewModel)this.Resources["selectVM"]).GetListCar);
        }
    }
}
