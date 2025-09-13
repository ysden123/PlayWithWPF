using System.Windows;
using System.Windows.Input;

namespace WpfAppAsync
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

        private async void ButtonMakeJob_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "Waiting...";
            var currentCursor = ResultText.Cursor;
            ResultText.Cursor = Cursors.Wait;
            ButtonMakeJob.IsEnabled = false;
            ButtonMakeJob2.IsEnabled = false;
            ButtonMakeJob3.IsEnabled = false;
            try
            {
                var result = await LongProcess.MakeJob();
                ResultText.Text = result;
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
            ResultText.Cursor = currentCursor;
            ButtonMakeJob.IsEnabled = true;
            ButtonMakeJob2.IsEnabled = true;
            ButtonMakeJob3.IsEnabled = true;
        }

        private async void ButtonMakeJob2_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "Waiting...";
            var currentCursor = ResultText.Cursor;
            ResultText.Cursor = Cursors.Wait;
            ButtonMakeJob.IsEnabled = false;
            ButtonMakeJob2.IsEnabled = false;
            ButtonMakeJob3.IsEnabled = false;
            try
            {
                var result = await LongProcess.MakeJob2();
                ResultText.Text = result;
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }
            ResultText.Cursor = currentCursor;
            ButtonMakeJob.IsEnabled = true;
            ButtonMakeJob2.IsEnabled = true;
            ButtonMakeJob3.IsEnabled = true;
        }

        private async void ButtonMakeJob3_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "Waiting...";
            var currentCursor = ResultText.Cursor;
            ResultText.Cursor = Cursors.Wait;
            ButtonMakeJob.IsEnabled = false;
            ButtonMakeJob2.IsEnabled = false;
            ButtonMakeJob3.IsEnabled = false;

            try
            {
                var result = await LongProcess.MakeJob3();
                ResultText.Text = result;
            }
            catch (Exception ex)
            {
                ResultText.Text = ex.Message;
            }

            ResultText.Cursor = currentCursor;
            ButtonMakeJob.IsEnabled = true;
            ButtonMakeJob2.IsEnabled = true;
            ButtonMakeJob3.IsEnabled = true;
        }
    }
}