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
    public class DrawSequence
    {

        public static void Draw(WrapPanel Panel, byte[] Sequence)
        {
            for (int i = 0; i < Sequence.Length; i++)
            {
                Grid NewGrid = new Grid() { Height = Sequence[i], Width = 15, VerticalAlignment = System.Windows.VerticalAlignment.Bottom, Background = Brushes.White };
                Border Border = new Border() {BorderBrush = Brushes.Black, BorderThickness = new Thickness(1) };
                NewGrid.Children.Add(Border);
                Panel.Children.Add(NewGrid);
            }
        }
    }
}
