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

namespace _184863RG_or_B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show(findAll(50) + "");
        }
        public ulong findRed (int tiles)
        {
            ulong count1 = 1;
            ulong count2 = 0;
            ulong temp;
            for (int i = 2; i < tiles; i++)
            {
                temp = count1 + count2 + 1;
                count2 = count1;
                count1 = temp;
            }
            return count1;
        }
        public ulong findGreen (int tiles)
        {
            ulong count1 = 1;
            ulong count2 = 0;
            ulong count3 = 0;
            ulong count4 = 0;
            ulong temp;
            for (int i = 3; i < tiles; i++)
            {
                temp = count2 + count3 + count4 + 2;
                count4 = count3;
                count3 = count2;
                count2 = count1;
                count1 = temp;
            }
            return count1;
        }
        public ulong findBlue (int tiles)
        {
            ulong count1 = 2;
            ulong count2 = 1;
            ulong count3 = 0;
            ulong count4 = 0;
            ulong count5 = 0;
            ulong count6 = 0;
            ulong temp;
            for (int i = 5; i < tiles; i++)
            {
                temp = count3 + count4 + count5 + count6 + 3;
                count6 = count5;
                count5 = count4;
                count4 = count3;
                count3 = count2;
                count2 = count1;
                count1 = temp;
            }
            return count1;
        }
        public ulong findAll (int tiles)
        {
            return findRed(tiles) + findGreen(tiles) + findBlue(tiles);
        }
    }
}
