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
            ///Creating the instance of the address book repository
            AddressBookDataTable.AddDataIntoTable();
        }
    }
}
