// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBookDataTable.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AddressBookSystem_LINQ
{
    public class AddressBookDataTable
    {
        /// <summary>
        /// UC 1 : Created new address book table
        /// </summary>
        public static DataTable addressBookTable = new DataTable();

        /// <summary>
        /// UC 2 : Adds the data into table.
        /// </summary>
        public static void AddDataIntoTable()
        {
            //Adding columns into datatable
            addressBookTable.Columns.Add("FirstName", typeof(string));
            addressBookTable.Columns.Add("LastName", typeof(string));
            addressBookTable.Columns.Add("Address", typeof(string));
            addressBookTable.Columns.Add("City", typeof(string));
            addressBookTable.Columns.Add("State", typeof(string));
            addressBookTable.Columns.Add("Zip", typeof(int));
            addressBookTable.Columns.Add("PhoneNumber", typeof(double));
            addressBookTable.Columns.Add("Email", typeof(string));

            //Adding First Name and Last name as primary key
            DataColumn[] primaryKeys = new DataColumn[2];
            primaryKeys[0] = addressBookTable.Columns["FirstName"];
            primaryKeys[1] = addressBookTable.Columns["LastName"];
            addressBookTable.PrimaryKey = primaryKeys;
           
            //Creating rows and adding data into rows
            addressBookTable.Rows.Add("Lebron", "James", "Street 1", "Lakers", "Los Angeles", 444556, 6785674567, "lb@gmail.com");
            addressBookTable.Rows.Add("Kyrie", "Irving", "Street 3", "Celtics", "Boston", 345267, 2345678987, "ki@gmail.com");
            addressBookTable.Rows.Add("Steph", "Curry", "Block 4", "Warriors", "Golden State", 987654, 3456787654, "sg@gmail.com");
            addressBookTable.Rows.Add("James", "Harden", "Street 5", "Rockets", "Houston", 234566, 6543456789, "vs@gmail.com");
            addressBookTable.Rows.Add("Michel", "Jordan", "Block 2", "Hornets ", "Charlotte ", 444556, 3456787654, "mj@gmail.com");
        }
        /// <summary>
        /// Displays the table contents.
        /// </summary>
        public static void DisplayTableContents()
        {
            foreach (var v in addressBookTable.AsEnumerable())
            {
                Console.WriteLine($"FirstName:{v.Field<string>("FirstName")}\nLastName:{v.Field<string>("LastName")}\nAddress:{v.Field<string>("Address")}\nCity:{v.Field<string>("City")}\nState:{v.Field<string>("State")}\nZip:{v.Field<int>("Zip")}\nPhoneNumber:{v.Field<double>("PhoneNumber")}\nEmail:{v.Field<string>("Email")}\n");
            }
        }

        /// <summary>
        /// UC 4 : Edits the existing contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="zip">The zip.</param>
        public static void EditExistingContact(string firstName, string lastName, int zip)
        {
            (from p in addressBookTable.AsEnumerable()
             where p.Field<string>("FirstName") == firstName && p.Field<string>("LastName") == lastName
             select p).ToList().ForEach(x => x[5] = zip);
        }
        /// <summary>
        /// UC 5 : Deletes the contact.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public static void DeleteContact(string firstName, string lastName)
        {
            //Retrieve the datarow containing given name
            var x = (from p in addressBookTable.AsEnumerable()
                     where p.Field<string>("FirstName") == firstName && p.Field<string>("LastName") == lastName
                     select p).FirstOrDefault();
            //Delete the row
            x.Delete();
        }
    }
}
