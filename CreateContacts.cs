using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    /// <summary>
    /// Variable to create variable.
    /// </summary>
    class CreateContacts
    {
		public String firstNameVar;
		public String lastNameVar;
		public String addressVar;
		public String cityVar;
		public String stateVar;
		public int zipVar;
		public long phoneNumberVar;
		public string eMailVar;
		List<String> firstName = new List<String>();

		List<String> lastName = new List<String>();

		List<String> address = new List<String>();

		List<String> city = new List<String>();

		List<String> state = new List<String>();

		List<int> zip = new List<int>();

		List<long> phoneNumber = new List<long>();
		List<String> eMail = new List<String>();

        /// <summary>
        /// Creates this instance.
		/// method to create contacts, taking all the inputs.
        /// </summary>
        public void Create() 
		{
			while (true)
			{
				try
				{
					Console.WriteLine("Enter your First Name : ");
					firstNameVar = Console.ReadLine();
					firstName.Add(firstNameVar);
					Console.WriteLine("Enter your Last Name : ");
					lastNameVar = Console.ReadLine();
					lastName.Add(lastNameVar);
					Console.WriteLine("Enter your Address : ");
					addressVar = Console.ReadLine();
					address.Add(addressVar);
					Console.WriteLine("Enter your City : ");
					cityVar = Console.ReadLine();
					city.Add(cityVar);
					Console.WriteLine("Enter your State : ");
					stateVar = Console.ReadLine();
					state.Add(stateVar);
					Console.WriteLine("Enter your Zip : ");
					zipVar =Convert.ToInt32(Console.ReadLine());
					zip.Add(zipVar);
					Console.WriteLine("Enter your 10 digit Phone Number : ");
					phoneNumberVar = Convert.ToInt64( Console.ReadLine());
					phoneNumber.Add(phoneNumberVar);
					Console.WriteLine("Enter your email Address : ");
					eMailVar = Console.ReadLine();
					eMail.Add(eMailVar);
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
					continue;
				}
			}
		}
	}
}
