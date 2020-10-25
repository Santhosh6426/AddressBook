/*
 *  C# CODING STANDARDS - LINE SPACE
 * NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
 */

/******************************************************************************
 *  Compilation:  C:\Users\Santhu\source\repos\AddressBook\bin\Debug\netcoreapp3.1\AddressBook.exe
 *  Execution:    AddressBook.exe
 *  
 *  Purpose: Address Book.
 *
 *  @author  Santhosh
 *  @version 2019
 *  @since   2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;

namespace AddressBook
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book!");
            while(true)
            {
                ///Call create method from create contacts class to create contacts.
                CreateContacts createContacts = new CreateContacts();
                Console.WriteLine("Enter 1 to Create Contact.\nEnter 2 to exit! ");
                int readOption = Convert.ToInt32(Console.ReadLine());
                ///to read the input to create contact or exit the application.
                if (readOption == 1)
                {
                    createContacts.Create();
                }
                else 
                {
                    break;
                }
            }
        }
    }
}
