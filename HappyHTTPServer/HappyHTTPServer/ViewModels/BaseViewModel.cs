﻿namespace HappyHTTPServer.ViewModels
{
    using System;
    using System.ComponentModel;
    using System.Linq.Expressions;
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged == null)
            {
                return;
            }
            var propertyEventArgs = new PropertyChangedEventArgs(propertyName);
            this.PropertyChanged.Invoke(this, propertyEventArgs);
        }
    }
}
