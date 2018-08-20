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
            DataContext = this;

            CBrandListViewBox.ItemsSource = brandList.bList;
            //ContactsNameBox.ItemsSource = contactsList.selectedCList;


        }

        

        private void CBrandListViewBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
            

            var selectedbrand = CBrandListViewBox.SelectedItem;
            foreach (contactsinfo c in contactsList.cList)
            {


                if (selectedbrand.ToString() == c.ManufacName.ToString())
                    contactsList.selectedCList.Add(c);
            }
            ContactsNameBox.ItemsSource = contactsList.selectedCList;
        }

        private void ContactsNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            
            

        }
    }

   
    
}
