using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Lab08_Product.Models;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab08_Product
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<Icon> Icons;

        private ObservableCollection<Contact> Contacts;

        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<Icon>();
            Icons.Add(new Icon { IconPath = "Assets/icon1.png" });
            Icons.Add(new Icon { IconPath = "Assets/icon2.png" });
            Icons.Add(new Icon { IconPath = "Assets/icon3.jfif" });
            Icons.Add(new Icon { IconPath = "Assets/icon4.png" });
            Icons.Add(new Icon { IconPath = "Assets/icon5.jfif" });
            Icons.Add(new Icon { IconPath = "Assets/icon6.png" });

            Contacts = new ObservableCollection<Contact>();
            Contacts.Add(new Contact { ProductName = "Hallo", ImagePath = "Assets/icon1.png" });
            Contacts.Add(new Contact { ProductName = "FireFox", ImagePath = "Assets/icon5.jfif" });

        }

        private void NewContactButton_Click(object sender, RoutedEventArgs e)
        {
            string image = ((Icon)ImageCombobox.SelectedValue).IconPath;
            Contacts.Add(new Contact
            {
                ProductName = ProductNameTextBox.Text,
                ImagePath = image
            });
        }
    }
}
