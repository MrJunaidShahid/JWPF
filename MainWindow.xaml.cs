using System;
using System.Windows;
using System.Windows.Input;

namespace JWPF
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

        private void Process_Click(object sender, RoutedEventArgs e)
        {
            Output.Content = "Output:" + (int.Parse(IsNull(Value1.Text)) + int.Parse(IsNull(Value2.Text)));         
        }

        private string IsNull(string text)
        {
            if (text == null || text == "")
            {
                return "0";
            }
            else
            if (text.Length == 0)
            {
                return "0";
            }
            else
            {
                return text;
            }
        }
    }
}
