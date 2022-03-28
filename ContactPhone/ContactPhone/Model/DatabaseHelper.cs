
using SQLite.Net;
using SQLite.Net.Platform.WinRT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactPhone.Model
{
    class DatabaseHelper
    {
        public ObservableCollection<Contact> ReadAllContact()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), App.DB_PATH))
                {
                    List<Contact> listContact = conn.Table<Contact>().ToList<Contact>();
                    ObservableCollection<Contact> conllectionContact = new ObservableCollection<Contact>(listContact);
                    return conllectionContact;
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                throw;
            }

        }

        public Contact ReadContactById(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), App.DB_PATH))
            {
                // Call method of DLL Dynamic linking library, -> API
                var contact = conn.Query<Contact>("SELECT Id, Name, PhoneNumber FROM Contact WHERE Id = " + id).FirstOrDefault();
                return contact;
            }
        }

        public void Insert(Contact newContact)
        {
            using (SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), App.DB_PATH))
            {
                conn.RunInTransaction(() =>
                {
                    conn.Insert(newContact);
                });
            }
        }

        public void Update(Contact updateContact)
        {
            using (SQLiteConnection conn = new SQLiteConnection(new SQLitePlatformWinRT(), App.DB_PATH))
            {
                //Get existing Contact
                Contact existingContact = ReadContactById(updateContact.Id);
                if (existingContact != null)
                {
                    conn.RunInTransaction(() =>
                    {
                        conn.Update(updateContact);
                    });
                }

            }
        }
    }
}
