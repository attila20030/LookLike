using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LookLike.Desktop.Views.ControlPanel
{
    /// <summary>
    /// Interaction logic for ControlPanelView.xaml
    /// </summary>
    public partial class ControlPanelView : UserControl
    {
        public ControlPanelView()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private ImageBrush _imageBrush = new ImageBrush();
        public ImageBrush ImageBrush
        {
            get { return _imageBrush; }
            set { _imageBrush = value; }
        }

        private void ChangeImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                ImageBrush imageBrush = new ImageBrush
                {
                    ImageSource = new BitmapImage(new Uri(openFileDialog.FileName))
                };

                ImageBrush = imageBrush;
                ImageBorder.Background = ImageBrush;
            }
        }
    }
}
