using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookLike.Desktop.Views.StatPanel
{
    public class Adatok : INotifyPropertyChanged
    {
        public double alap;
        public double afa;
        public double afasertek;

        public double Alap
        {
            get
            {
                return alap;
            }
            set
            {
                alap = value;
                OnPropertyChanged("Afasertek");
            }

        }
        public double Afa
        {
            get
            {
                return afa;
            }
            set
            {
                afa = value;
                OnPropertyChanged("Afasertek");
            }

        }
        public double Afasertek
        {
            get
            {
                double ertek = alap * (1 + (afa / 100));
                return ertek;
            }

        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }


        }


    }
}
