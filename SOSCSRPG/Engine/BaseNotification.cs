using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class BaseNotification : INotifyPropertyChanged
    {
        // Important event handle that informs any classes that rely on the Player data to update.
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Event used to update the UI, given a specified property to update.
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
