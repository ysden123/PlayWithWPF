using System.Windows;

namespace WPFImageFromResource
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

        private void ShowButtonClick(object sender, RoutedEventArgs e)
        {
            DataContext = new ViewModel() { ImagePath = "/Resources/clear.png" };
        }
    }
}