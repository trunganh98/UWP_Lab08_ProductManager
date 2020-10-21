using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Lab08_ProductsCategory.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Lab08_ProductsCategory
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<CategoryItem> CategoryItems;

        public MainPage()
        {
            this.InitializeComponent();
            CategoryItems = new ObservableCollection<CategoryItem>();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Laptop.IsSelected)
            {
                NewsManager.GetCategorys("Laptop", CategoryItems);
                TitleTextBlock.Text = "Laptop";
            }

            else if (Product.IsSelected)
            {
                NewsManager.GetCategorys("Product", CategoryItems);
                TitleTextBlock.Text = "Product";
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Laptop.IsSelected = true;
        }
    }
}
