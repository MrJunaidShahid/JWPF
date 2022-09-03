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

            CommandBindings.Add(new CommandBinding(ApplicationCommands.New, NewCommandExecuted, AllowNew));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, OpenCommandExecuted, AllowOpen));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, SaveCommandExecuted, AllowSave));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Properties, PropertiesCommandExecuted, AllowProperties));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Print, PrintCommandExecuted, AllowPrint));

        }

        private void PrintCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to print.");
        }

        private void AllowPrint(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void PropertiesCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to open properties.");
        }

        private void AllowProperties(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to create new file.");
        }

        private void AllowNew(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void OpenCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to open existing file.");
        }

        private void AllowOpen(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void SaveCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("You want to save a file.");
        }
        private void AllowSave(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
