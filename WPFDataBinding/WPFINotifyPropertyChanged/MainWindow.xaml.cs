using System.Collections.ObjectModel;
using System.Windows;

namespace WPFINotifyPropertyChanged
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Items = new ObservableCollection<Item>();
            // Добавьте тестовые данные
            Items.Add(new Item { Column1 = "Значение 1", Column2 = "Значение 2" });
            Items.Add(new Item { Column1 = "Значение 3", Column2 = "Значение 4" });

            // Привяжите коллекцию к DataContext
            this.DataContext = this;
        }

        private void ChangeButtonClick(object sender, RoutedEventArgs e)
        {
            if (Items.Count > 0)
            {
                // Изменение значения в первом элементе
                Items[0].Column2 = "Новое значение";
            }
        }
    }
}