using CommunityToolkit.Mvvm.Input;
using LookLike.Desktop.ViewModels.Base;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace LookLike.Desktop.ViewModels.StatPanel
{
    public class StatPanelViewModel : BaseViewModel
    {
        private int _ertekeles;
        private int _munkanapok;
        private double _atlag;

        public int Ertekeles
        {
            get => _ertekeles;
            set
            {
                if (_ertekeles != value)
                {
                    _ertekeles = value;
                    OnPropertyChanged();
                    SzamoljAtlagot();
                }
            }
        }

        public int Munkanapok
        {
            get => _munkanapok;
            set
            {
                if (_munkanapok != value)
                {
                    _munkanapok = value;
                    OnPropertyChanged();
                    SzamoljAtlagot();
                }
            }
        }

        public double Atlag
        {
            get => _atlag;
            private set
            {
                if (_atlag != value)
                {
                    _atlag = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand SzamolasCommand { get; }

        public StatPanelViewModel()
        {
            SzamolasCommand = new RelayCommand(SzamoljAtlagot);
        }

        private void SzamoljAtlagot()
        {
            if (Munkanapok != 0)
                Atlag = (double)Ertekeles / Munkanapok;
            else
                Atlag = 0;
        }
        //kész
    }
}
