using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SfDataGridSample
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private bool _checkBox1;
        private bool _checkBox2;
        private bool _checkBox3;
        private bool _checkBox2Enabled;
        private bool _checkBox3Enabled;

        public bool CheckBox1
        {
            get => _checkBox1;
            set
            {
                if (_checkBox1 != value)
                {
                    _checkBox1 = value;
                    OnPropertyChanged();
                    UpdateCheckBoxStates();
                }
            }
        }

        public bool CheckBox2
        {
            get => _checkBox2;
            set
            {
                if (_checkBox2 != value)
                {
                    _checkBox2 = value;
                    OnPropertyChanged();
                    UpdateCheckBoxStates();
                }
            }
        }

        public bool CheckBox3
        {
            get => _checkBox3;
            set
            {
                if (_checkBox3 != value)
                {
                    _checkBox3 = value;
                    OnPropertyChanged();
                    UpdateCheckBoxStates();
                }
            }
        }

        public bool CheckBox2Enabled
        {
            get => _checkBox2Enabled;
            set
            {
                if (_checkBox2Enabled != value)
                {
                    _checkBox2Enabled = value;
                    OnPropertyChanged();
                }
            }
        }

        public bool CheckBox3Enabled
        {
            get => _checkBox3Enabled;
            set
            {
                if (_checkBox3Enabled != value)
                {
                    _checkBox3Enabled = value;
                    OnPropertyChanged();
                }
            }
        }

        private void UpdateCheckBoxStates()
        {
            if (!CheckBox1)
            {
                CheckBox2 = false;
                CheckBox3 = false;
                CheckBox3Enabled = false;
            }
            else
            {
                CheckBox3Enabled = CheckBox2;
                if (CheckBox3)
                {
                    CheckBox2Enabled = false;
                }
                else if (!CheckBox3 && !CheckBox2Enabled)
                {
                    CheckBox2Enabled = true;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
