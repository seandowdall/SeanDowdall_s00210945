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

namespace SeanDowdall_s00210945
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void lbxProperties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what was selected
            RentalProperty selected = lbxProperties.SelectedItem as RentalProperty;

            //check not null
            if (selected != null)
            {
                //update display
                tblkDescription.Text = selected.GetDescription(); //get details method in games class
                imgGameImage.Source = new BitmapImage(new Uri(selected.Game_Image, UriKind.Relative));

            }
        }
    }
}
