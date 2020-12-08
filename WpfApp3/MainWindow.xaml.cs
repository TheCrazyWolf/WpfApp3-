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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<YYY> yYYs = new List<YYY>()
            {
               new YYY{Name= "111" ,ZZZ="222" },
                new YYY{Name= "444" ,ZZZ="222" },
                 new YYY{Name= "555" ,ZZZ="222" },
                  new YYY{Name= "666" ,ZZZ="222" }
            };

            cb.ItemsSource = yYYs;

        }



    }

    public  class YYY
    {
        public string Name { get; set; }
        public string ZZZ { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
