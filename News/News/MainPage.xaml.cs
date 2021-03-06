using News.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace News
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<NewsItems> NewsItems;
        public MainPage()
        {
            this.InitializeComponent();
            NewsItems = new ObservableCollection<NewsItems>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyMenu.IsPaneOpen = !MyMenu.IsPaneOpen; 
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Update data of NewsItems
            if (FinancialListBoxItem.IsSelected)
            {
                NewManager.GetNews("Financial", NewsItems);
                //data of NewsItems changed
            }
            else if (ShareListBoxItem.IsSelected)
            {
                NewManager.GetNews("Today", NewsItems);
            }
            else if (FavouriteListBoxItem.IsSelected)
            {
                NewManager.GetNews("Food", NewsItems);
            }
        }

            private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(NewsDetails));
        }
    }
}
