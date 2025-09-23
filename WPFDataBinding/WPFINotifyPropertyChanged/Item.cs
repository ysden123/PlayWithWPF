using System.ComponentModel;

namespace WPFINotifyPropertyChanged
{
    public class Item : INotifyPropertyChanged
    {
        private string? _column1;
        private string? _column2;

        public string? Column1
        {
            get { return _column1; }
            set
            {
                _column1 = value;
                OnPropertyChanged(nameof(Column1));
            }
        }

        public string? Column2
        {
            get { return _column2; }
            set
            {
                _column2 = value;
                OnPropertyChanged(nameof(Column2));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
