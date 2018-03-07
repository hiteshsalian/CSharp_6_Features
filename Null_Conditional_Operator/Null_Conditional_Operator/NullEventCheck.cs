using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Null_Conditional_Operator
{
    public class NullEventCheck : IUsage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void ShowUsage()
        {
            OnPropertyChanged();
        }

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            // using the null conditional operator with Event and invoking the delegate
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
