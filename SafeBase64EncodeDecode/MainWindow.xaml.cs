using System;
using System.Text;
using System.Windows;

namespace SafeBase64EncodeDecode
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Encode_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(Result.Text));
                Status.Content = "";
            }
            catch
            {
                Status.Content = "This text cannot be encoded";
            }
        }

        private void Decode_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result.Text = Encoding.UTF8.GetString(Convert.FromBase64String(Result.Text));
                Status.Content = "";
            }
            catch
            {
                Status.Content = "This text cannot be decoded";
            }
        }
    }
}
