using System;
using System.Linq;
namespace Deliverable1
{
    class ValidPassword
    {
        static void Main(string[] args)
        {
			// Print out prompt
			Console.WriteLine("Please create a password with following criteria: ");
			Console.WriteLine("- At least one lowercase letter");
			Console.WriteLine("- At least one uppercase letter");
			Console.WriteLine("- At least 7 characters minimum");
			Console.WriteLine("- At most 12 characters max");
			Console.WriteLine("- An exclamation point: !");

			// read input and create flag for valid password
			string password = Console.ReadLine();
			bool isValid = true;
			if (!(password.Any(char.IsUpper) &&
			password.Any(char.IsLower) &&
			password.Contains('!')))
				isValid = false;
			if (password.Length < 7 || password.Length > 12)
				isValid = false;
			// Check flag for correct password
			if (isValid)
				Console.WriteLine("Password valid and accepted");
			else
				Console.WriteLine("Error");
		}
    }
}
