using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace LookLike.Desktop.Views.NotificationPanel
{
    public class NotificationPanelModel
    {
        // Model: Értesítés osztály
        public class Ertesites
        {
            public string Uzenet { get; set; } = string.Empty;
            public string Tipus { get; set; } = string.Empty; // Pl. "Info", "Hiba", stb.
        }

        // ViewModel: Értesítéskezelő
        public class ErtesitesKezeloViewModel : INotifyPropertyChanged
        {
            private string _ujErtesitesUzenet;
            private string _ujErtesitesTipus;

            public ObservableCollection<Ertesites> Ertesitesek { get; set; } = new ObservableCollection<Ertesites>();

            public string UjErtesitesUzenet
            {
                get => _ujErtesitesUzenet;
                set
                {
                    _ujErtesitesUzenet = value;
                    OnPropertyChanged();
                }
            }

            public string UjErtesitesTipus
            {
                get => _ujErtesitesTipus;
                set
                {
                    _ujErtesitesTipus = value;
                    OnPropertyChanged();
                }
            }

            public ICommand HozzaadasParancs { get; }
            public ICommand TorlesParancs { get; }

            public ErtesitesKezeloViewModel()
            {
                HozzaadasParancs = new RelayCommand(Hozzaadas);
                TorlesParancs = new RelayCommand(Torles);
            }

            private void Hozzaadas()
            {
                if (!string.IsNullOrWhiteSpace(UjErtesitesUzenet) && !string.IsNullOrWhiteSpace(UjErtesitesTipus))
                {
                    Ertesitesek.Add(new Ertesites { Uzenet = UjErtesitesUzenet, Tipus = UjErtesitesTipus });
                    UjErtesitesUzenet = string.Empty;
                    UjErtesitesTipus = string.Empty;
                }
            }

            private void Torles()
            {
                if (Ertesitesek.Count > 0)
                {
                    Ertesitesek.Clear();
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // RelayCommand osztály (az MVVM parancskezeléshez)
        public class RelayCommand : ICommand
        {
            private readonly Action _execute;
            private readonly Func<bool> _canExecute;

            public RelayCommand(Action execute, Func<bool> canExecute = null)
            {
                _execute = execute;
                _canExecute = canExecute;
            }

            public bool CanExecute(object parameter) => _canExecute == null || _canExecute();

            public void Execute(object parameter) => _execute();

            public event EventHandler CanExecuteChanged
            {
                add => CommandManager.RequerySuggested += value;
                remove => CommandManager.RequerySuggested -= value;
            }
        }
    }
}
