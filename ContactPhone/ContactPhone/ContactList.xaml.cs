using ContactPhone.Model;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ContactPhone
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContactList : Page
    {
        ObservableCollection<Contact> Contacts = new ObservableCollection<Contact>();
        DatabaseHelper db = new DatabaseHelper();
        public ContactList()
        {
            this.InitializeComponent();
        }
        private void btnAddContact_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AddContact));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            Contacts = db.ReadAllContact();
            if (Contacts.Count > 0)
            {
                listContacts.ItemsSource = Contacts.ToList();
            }
        }

        private void listContacts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact item = listContacts.SelectedItem as Contact;

            Frame.Navigate(typeof(DetailContact), item);
        }
    }
}
