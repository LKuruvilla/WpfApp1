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
using System.Windows.Shapes;
using Class;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ViewCurrentBrands.xaml
    /// </summary>
    public partial class ViewCurrentBrands : Window
    {
        
        public ViewCurrentBrands()
        { 
            InitializeComponent();

            CBrandListViewBox.ItemsSource = brandList.bList;
            foreach (brand b in brandList.bList)
            {
                CBrandListViewBox.DataContext = b.ManufacName;
            }
            
            Binding contactsnamebind = new Binding();
            contactsnamebind.Source = contactsList.cList;
            
           

        }

        
    }
}
