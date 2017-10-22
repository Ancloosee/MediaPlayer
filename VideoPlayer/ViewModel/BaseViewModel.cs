using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoPlayer.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged, IDisposable
    {
        
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler changedEventHandler = this.PropertyChanged;

            if (changedEventHandler != null)
                changedEventHandler.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        public void Dispose()
        {
            this.OnDispose();
        }

        public virtual void OnDispose()
        {

        }
    }
}
