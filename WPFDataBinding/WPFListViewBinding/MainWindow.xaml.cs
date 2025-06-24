using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFListViewBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly ObservableCollection<Person> Persons = [
            new Person {FirstName = "Ivan", LastName = "Petrov", Age = 12},
            new Person {FirstName = "Semen", LastName = "Putov", Age = 21},
            new Person {FirstName = "Petr", LastName = "Tonkov", Age = 14},
            new Person {FirstName = "Uhbu", LastName = "Maliy", Age = 9}
            ];

        public MainWindow()
        {
            InitializeComponent();
            this.ListView_Persons.ItemsSource = Persons;
        }
    }
}