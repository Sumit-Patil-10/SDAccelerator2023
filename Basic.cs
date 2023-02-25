
// +++++ This is simple practice program for basic syntax +++++++



Console.WriteLine("Welcome to pie shop");

Console.WriteLine("Hey, Please write first your name");

string firstName = Console.ReadLine(); // this line accepts firstname

Console.WriteLine("Hey, Please write surname ");

string secondName = Console.ReadLine(); // this line will surname

Console.WriteLine("Hey, Please enter your age");

int ageOfPerson = Convert.ToInt32(Console.ReadLine()); // Cannot read int directly we have convert it

Console.WriteLine("Welcome to shop " + firstName + " " + secondName );

Console.WriteLine("Your age is " + ageOfPerson);



//++++This section covers practice with integer and string & char


int hoursWorked; // declaretion

hoursWorked = 21;

hoursWorked = 10; // value reassigned perfectly fine 

Console.WriteLine( "The hoursWorked are" + hoursWorked);

int intMaxValue = int.MaxValue; // stores max int value

int intMinValue = int.MinValue; // stores min int value 

double doubleMaxValue = double.MaxValue; // stores double valye

char myChar = 's'; // needs single quote for string we double quote

bool isDigit = char.IsDigit(myChar);
bool isWhitespace = char.IsWhiteSpace(myChar);


