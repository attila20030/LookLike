using LookLike.Desktop.ViewModels.StatPanel;
using System.Windows.Controls;

namespace LookLike.Desktop.Views.StatPanel
{
    public partial class StatPanelView : UserControl
    {
        public StatPanelView()
        {
            InitializeComponent();
            DataContext = new StatPanelViewModel();
        }
    }
}
