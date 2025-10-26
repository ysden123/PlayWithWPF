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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfUIEx
{
    /// <summary>
    /// Interaction logic for EventHandlerEx2.xaml
    /// </summary>
    public partial class EventHandlerEx2 : UserControl
    {
        public EventHandlerEx2()
        {
            InitializeComponent();
            ResultText.Text = $"Initialization {Environment.CurrentManagedThreadId}";
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = $"Button 1 {Environment.CurrentManagedThreadId}";
        }

        private async void Button2_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => {
                var threadId = Environment.CurrentManagedThreadId;
                this.Dispatcher.Invoke(() =>
                {
                    ResultText.Text = $"Button 2 {threadId}";
                });
            });
        }
    }
}
