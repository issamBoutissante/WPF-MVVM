using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_MVVM_ICommand
{
    class ViewModal:INotifyPropertyChanged
    {
        private int n1;

        public int N1
        {
            get { return n1; }
            set { if (n1 != value)
                {
                    n1 = value;
                    onPropertyChanged("N1");
                    onPropertyChanged("Result");
                }
            }
        }
        private int n2;

        public int N2
        {
            get { return n2; }
            set { if (n2 != value)
                {
                    n2 = value; 
                    onPropertyChanged("N2");
                    onPropertyChanged("Result");
                }
            }
        }
        private int result;

        public int Result
        {
            get { return N1+N2; }
            set { if (result != value) {
                    result = value;
                    onPropertyChanged("result");
                };
            }
        }

        public ICommand SayHiCommand { get; set; }
        public ViewModal()
        {
            this.SayHiCommand = new Command(() => MessageBox.Show("Hello Issam"));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void onPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
