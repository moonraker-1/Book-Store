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

namespace BookStoreDesktop
{
    /// <summary>
    /// Interaction logic for CustomMessageBox.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {   
        public CustomMessageBoxButtonHandler SaveButtonHandler { get; set; }
        public CustomMessageBoxButtonHandler NoSaveButtonHandler { get; set; }
        public CustomMessageBoxButtonHandler CancelButtonHandler { get; set; }

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveButtonHandler.Invoke();
        }

        private void btnNoSave_Click(object sender, RoutedEventArgs e)
        {
            NoSaveButtonHandler.Invoke();

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
