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
    /// Interaction logic for AddNewBrand.xaml
    /// </summary>
    public partial class AddNewBrand : Window
    {
        public AddNewBrand()
        {
            InitializeComponent();
            
            

            

        }

        private void addContactsBrandButton_Click(object sender, RoutedEventArgs e)
        {
            

            contactsinfo ci = new contactsinfo();
            
            ci.ManufacName = getManufacText.Text;
            ci.Name = getContactsNameText.Text;
            ci.BaseCurve = float.Parse(getBaseCurveText.Text);
            ci.Diameter = float.Parse(getDiameterText.Text);

            

            //must check if contacts exist first before adding.
            if(contactsList.cList.Exists(x=> x.ManufacName == ci.ManufacName)&&
                (contactsList.cList.Exists(y=>y.Name == ci.Name)) == false)
            {
                contactsList.cList.Add(ci);
            }
            

            if (brandList.bList.Exists(x=> x.ManufacName == ci.ManufacName) == false)
            {
                brandList.bList.Add((brand)ci);
            }

            this.Close();
        }

        private void getManufacText_GotFocus(object sender, RoutedEventArgs e)
        {
            getManufacText.Clear();
        }

        private void getContactsNameText_GotFocus(object sender, RoutedEventArgs e)
        {
            getContactsNameText.Clear();
        }

        private void getBaseCurveText_GotFocus(object sender, RoutedEventArgs e)
        {
            getBaseCurveText.Clear();
        }

        private void getDiameterText_GotFocus(object sender, RoutedEventArgs e)
        {
            getDiameterText.Clear();
        }
    }
}
