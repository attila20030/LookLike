using CommunityToolkit.Mvvm.Input;
using LookLike.Desktop.ViewModels.Base;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LookLike.Desktop.ViewModels.NotificationPanel
{
    public class NotePanelViewModel : BaseViewModel
    {
        private string _newNoteText;
        public string NewNoteText
        {
            get { return _newNoteText; }
            set { SetProperty(ref _newNoteText, value); }
        }

        private string _newNoteType;
        public string NewNoteType
        {
            get { return _newNoteType; }
            set { SetProperty(ref _newNoteType, value); }
        }

        private ObservableCollection<string> _notes;
        public ObservableCollection<string> Notes
        {
            get { return _notes; }
            set { SetProperty(ref _notes, value); }
        }

        public ICommand AddNoteCommand { get; }
        public ICommand ClearAllNotesCommand { get; }

        public NotePanelViewModel()
        {
            Notes = new ObservableCollection<string>();
            AddNoteCommand = new RelayCommand(AddNote);
            ClearAllNotesCommand = new RelayCommand(ClearAllNotes);
        }

        private void AddNote()
        {
            if (!string.IsNullOrEmpty(NewNoteText))
            {
                string newNote = $"{NewNoteText} ({NewNoteType})";
                Notes.Add(newNote);
                NewNoteText = string.Empty;
                NewNoteType = string.Empty;
            }
        }

        private void ClearAllNotes()
        {
            Notes.Clear();
        }
    }
}