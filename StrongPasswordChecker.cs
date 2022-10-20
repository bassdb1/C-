using System;


// source = https://www.youtube.com/watch?v=JIIeuhtTdpY

class Program {
  const int MIN_LENGTH = 10;  //Screaming Snake Case
  const string SYMBOLS = "!@#$%^&*()";

  // Function to test if the password is good or not

  static bool goodPassord(string password)
  {
    bool hasLength = password.Length >= MIN_LENGTH;
    if (!hasLength) Console.WriteLine("Password is less than 10 characters");

    // Check if our password has a Symbol !@#$%^&*()

    // going to set hasSymbol as false, then change to true if the requirement is met
    bool hasSymbol = false;

    // going to loop through each chararcter in SYMBOLS
    foreach (char c in SYMBOLS)
    {
      if (password.Contains(c))
      {
        hasSymbol = true;
        break;
      }
    }
    if (!hasSymbol) Console.WriteLine($"Needs at least one symbol: {SYMBOLS}");
    // both criteria has to be met in order to get a good password
    return hasLength && hasSymbol;
  }
  
  public static void Main (string[] args) {
    Console.WriteLine ("The Password must:");
    Console.WriteLine ("> Have at least " + MIN_LENGTH + " letters");
    Console.WriteLine ($"> Have at least 1 of these symbols: {SYMBOLS}");

    // Variable to store what the user types in
    string password = "";

    // Create a While Loop to loop until the conditon is met
       // was while(password =="")
    // -- also calling the function, and passing the argument of what somewone typed in
    // -- so while the passord is < 10 this loop will continue 

    do {
      password = Console.ReadLine();
      }
    while (!goodPassord(password));
      // mutetated the variable - changed what was stored in the variable
      Console.WriteLine("Good password!");
       

    
 }
}
