using System.ComponentModel;
using UnityEngine;
using System; 
using System.Runtime.CompilerServices;   

namespace EventSystem.SO
{
    public abstract class GenericEventSO<T> : EventSO, INotifyPropertyChanged
    {
        private T value;

        public T Value
        {
            get => value;
            set
            {
                this.value = value;
                NotifyPropertyChanged();
            } 
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")  
        {  
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }  
        
    }
}
