// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akash Kumar Singh"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace AddressBookSystem_LINQ
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Address Book Data LINQ Operartion Program");
            //UC 1,2,3
            AddressBookDataTable.AddDataIntoTable();
            AddressBookDataTable.DisplayTableContents();
            //UC 4
            AddressBookDataTable.EditExistingContact("Lebron", "James", 136119);
            AddressBookDataTable.DisplayTableContents();
            // UC_5
            AddressBookDataTable.DeleteContact("Lebron", "James");
            AddressBookDataTable.DisplayTableContents();
            //UC 6
            AddressBookDataTable.RetrievePersonFromACityOrState("Lakers", "Boston");
        }
    }
}
