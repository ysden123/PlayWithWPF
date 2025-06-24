using System.Collections.ObjectModel;
using System.Windows;

namespace WPFListBoxBinding
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
            this.ListBox_Persons.ItemsSource = Persons;
        }
    }
}