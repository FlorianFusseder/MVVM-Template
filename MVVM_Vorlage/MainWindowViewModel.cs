using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Vorlage
{
    partial class MainWindowViewModel : BaseViewModel
    {
        private bool isAllowed;

        public bool IsAllowed
        {
            get { return isAllowed; }
            set
            {
                isAllowed = value;
                OnPropertyChanged();
            }
        }

        private bool buttonAn;

        public bool ButtonAn
        {
            get { return buttonAn; }
            set
            {
                buttonAn = value;
                OnPropertyChanged();
            }
        }
        private long zahl;

        public long Zahl
        {
            get { return zahl; }
            set
            {
                zahl = value;
                OnPropertyChanged();
            }
        }

        private string zeit;

        public string Zeit
        {
            get { return zeit; }
            set
            {
                zeit = value;
                OnPropertyChanged();
            }
        }


        public MainWindowViewModel()
        {
            isAllowed = true;
            ButtonAn = false;
            Zeit = "N/A";
        }
    }
}
