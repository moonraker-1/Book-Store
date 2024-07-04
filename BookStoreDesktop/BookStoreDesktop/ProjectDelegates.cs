using System.Windows;

namespace BookStoreDesktop
{
    public delegate void CustomMessageBoxSaveHandler(object sender, RoutedEventArgs e);
    public delegate void CustomMessageBoxNoSaveHandler(object sender, System.ComponentModel.CancelEventArgs e);
    public delegate void CustomMessageBoxCancelHandler(System.ComponentModel.CancelEventArgs e);
}