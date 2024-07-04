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
        public CustomMessageBoxSaveHandler SaveButtonHandler { get; set; }
        public CustomMessageBoxNoSaveHandler NoSaveButtonHandler { get; set; }
        public CustomMessageBoxCancelHandler CancelButtonHandler { get; set; }

        public System.ComponentModel.CancelEventArgs CancelEventArgs { get; set; }

        public CustomMessageBox()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveButtonHandler.Invoke(null, null);
            this.Close();
        }

        private void btnNoSave_Click(object sender, RoutedEventArgs e)
        {
            //NoSaveButtonHandler.Invoke();
            this.Close();

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            CancelButtonHandler.Invoke(CancelEventArgs);
            this.Close();
        }
    }
}
