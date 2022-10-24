using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DATATAMPLATE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Brand>brand;
        public MainWindow()
        {
            InitializeComponent();
            brand = new ObservableCollection<Brand>();
            brand.Add(new Brand()
            {
                Name = "A319",
                Capacity = "100 чел.",
                Price = "50 000 0000 $",
                Image = "Data/Airbus_319-100.jpg",
                AeroPlane = AeroPlanes.Airbus
            });
            brand.Add(new Brand()
            {
                Name = "A321",
                Capacity = "200 чел.",
                Price = "110 000 0000 $",
                Image = "Data/Airbus_321-200.jpg",
                AeroPlane = AeroPlanes.Airbus
            }); brand.Add(new Brand()
            {
                Name = "A380",
                Capacity = "800 чел.",
                Price = "500 000 0000 $",
                Image = "Data/Airbus_380-800.jpg",
                AeroPlane = AeroPlanes.Airbus
            }); brand.Add(new Brand()
            {
                Name = "747",
                Capacity = "660 чел.",
                Price = "250 000 0000 $",
                Image = "Boing_747-400.jpg",
                AeroPlane = AeroPlanes.Boing
            }); brand.Add(new Brand()
            {
                Name = "777",
                Capacity = "300 чел.",
                Price = "100 000 0000 $",
                Image = "Data/Boing_777-300.jpg",
                AeroPlane = AeroPlanes.Boing
            }); brand.Add(new Brand()
            {
                Name = "787",
                Capacity = "300 чел.",
                Price = "250 000 0000 $",
                Image = "Data/Boing_787-9.jpg",
                AeroPlane = AeroPlanes.Boing
            });
            ListBox.ItemsSource = brand;
        }
    }
}
