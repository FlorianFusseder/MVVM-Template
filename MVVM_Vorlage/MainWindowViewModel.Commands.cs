using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Vorlage
{
    partial class MainWindowViewModel
    {
        private ICommand start;


        public ICommand Start
        {
            get
            {
                if (start == null)
                    start = new RelayCommand(calc, (obj) => IsAllowed && ButtonAn);

                return start;
            }
        }

        private void calc(object obj)
        {
            var t = new Task(
            delegate
            {
                var watch = new Stopwatch();
                watch.Start();
                for (var i = 0; i < 1000000; i++)
                {
                    Zahl += i + 1;
                }

                watch.Stop();
                Zeit = watch.Elapsed.ToString();
            }
            );

            t.Start();

        }
    }
}
