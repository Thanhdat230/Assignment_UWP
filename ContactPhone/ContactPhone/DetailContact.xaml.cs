using ContactPhone.Model;
using System;
using System.Collections.Generic;
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
    public sealed partial class DetailContact : Page
    {
        DatabaseHelper db = new DatabaseHelper();
        Contact contact = new Contact();
        public DetailContact()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            contact = e.Parameter as Contact;

            txtName.Text = contact.Name;
            txtPhoneNumber.Text = contact.PhoneNumber;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            contact.Name = txtName.Text;
            contact.PhoneNumber = txtPhoneNumber.Text;

            db.Update(contact);

            Frame.Navigate(typeof(ContactList));
        }

        private void btnDelte_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
