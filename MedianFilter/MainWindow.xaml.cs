using System;
using System.Collections.Generic;
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

namespace MedianFilter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int size = 1000;

        public MainWindow()
        {
            InitializeComponent();
            byte[] InicialSequence = GenerateNumbers.Generate(size);
            DrawSequence.Draw(InitialPanel, InicialSequence);
            byte[] FilteredSequence = MedianFilterSequence.Filter(InicialSequence, 30);
            DrawSequence.Draw(FilteredPanel, FilteredSequence);

        }

        private void Grid_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            InitialPanel.Children.Clear();
            FilteredPanel.Children.Clear();
            byte[] InicialSequence = GenerateNumbers.Generate(size);
            DrawSequence.Draw(InitialPanel, InicialSequence);
            byte[] FilteredSequence = MedianFilterSequence.Filter(InicialSequence, Convert.ToInt32(WindowSizeBox.Text));
            DrawSequence.Draw(FilteredPanel, FilteredSequence);
        }
    }
}
