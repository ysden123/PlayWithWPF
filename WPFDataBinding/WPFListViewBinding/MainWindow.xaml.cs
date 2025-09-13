using System.Collections.ObjectModel;
using System.Windows;

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


            Task.Run(() =>
            {
                Thread.Sleep(2000);
                Dispatcher.Invoke(new Action(() =>
                {
                    Persons[1] = new Person()
                    {
                        Age = 321,
                        FirstName = "Second",
                        LastName = "The last"
                    };
                }));
            });
        }
        private void PressMeButtonClick(object sender, RoutedEventArgs e)
        {
            Persons[0] = new Person()
            {
                Age = 12,
                FirstName = "YYY",
                LastName = "LLLL"
            };
        }
    }
}