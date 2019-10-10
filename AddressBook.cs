using System;
using System.Collections.Generic;

namespace TryCatch {
public class AddressBook
    {
      Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();
      public void AddContact(Contact contact)
      {
        Contacts.Add(contact.Email, contact);
      }

      public Contact GetByEmail(string email)
      {
        return Contacts[email];
      }
    }
}