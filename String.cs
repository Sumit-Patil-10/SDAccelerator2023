// The string module


    string firstName = "Sumit";
    var lastName = "Patil"; // implict 

    int l = firstName.Length; // property (An property is also kind of member)

    string replaced = lastName.Replace("P", "b"); // method

    string fullName = String.Concat(firstName, lastName);// concatination

    // how to escape from the escape charater trap
    // for ex

    string filePath = "c:\sumitp\SDAccelerator.xlsx"; // error : escape character trap

    // to remove this 1st option is use '\' or @ in front of string

    string filePath2 = @"c:\sumitp\SDAccelerator.xlsx"; // No error best way


    // Parsing

    int value;
    string inputValue = Console.ReadLine();
    
    if (int.TryParse(inputValue, out value))
        Console.WriteLine("Parsing Success");
    else
        Console.WriteLine("Parsing failed");


