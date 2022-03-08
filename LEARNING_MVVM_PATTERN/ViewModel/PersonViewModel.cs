using LEARNING_MVVM_PATTERN.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_MVVM_PATTERN.ViewModel
{

    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _Model =new Person();

        public string FirstName
        {
            get
            {
                return _Model.FirstName; 
            }
            set
            {
                _Model.FirstName = value;
                this.NotifyPropertyChanged("FirstName");
                this.NotifyPropertyChanged("FullName"); //Inform View about value changed

            }
        }

        public string LastName
        {
            get
            {
                return _Model.LastName; 
            }
            set
            {
                _Model.LastName = value;
                this.NotifyPropertyChanged("LastName");
                this.NotifyPropertyChanged("FullName");
            }
        }


        //ViewModel can contain property which serves view
        //For example: FullName not necessary in the Model  
        public String FullName
        {
            get 
            {
                string result = 
                    $"{_Model.FirstName} {_Model.LastName}";

                return result;
            }
        }

       

        //Implementing INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
    }
}
