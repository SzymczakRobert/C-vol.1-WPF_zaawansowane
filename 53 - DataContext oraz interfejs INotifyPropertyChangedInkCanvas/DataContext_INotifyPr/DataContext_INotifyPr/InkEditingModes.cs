using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DataContext_INotifyPr
{
    class InkEditingModes : INotifyPropertyChanged
    {
        private InkCanvasEditingMode _EditingMode;
        public InkCanvasEditingMode EditingMode
        {
            get
            {
                // return this._EditingMode;    //chyba tak
                //albo po prostu tak
                return _EditingMode;
            }
            set
            {
                _EditingMode = value;
                reisEventTahtPropertyChanged("EditingMode");


            }
        }
        public void reisEventTahtPropertyChanged(string propertyName)
        {            
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        //tu ustawiamy jakiś domyślny parametr uruchomieniowy
        public InkEditingModes()
        {
            _EditingMode = InkCanvasEditingMode.Ink;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
