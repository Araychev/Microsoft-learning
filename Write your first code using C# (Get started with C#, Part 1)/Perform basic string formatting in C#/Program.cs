
// Format output using character escape sequences
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Format output using verbatim strings

Console.Write(@"c:\invoices");

//Unicode escape characters

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");

// Concatenate a literal string and a variable
//string firstName = "Bob";
//string message = "Hello " + firstName;
//Console.WriteLine(message);

// Concatenate multiple strings

//string firstName = "Bob";
//string lastName = "Smith";
//string message = "Hello " + firstName + " " + lastName;


//Use string interpolation to combine a literal string and a variable value
//string firstName = "Bob";
//string message = $"Hello {firstName}!";
//Console.WriteLine(message);



//Combine verbatim literals and string interpolation

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");


string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";


Console.WriteLine("View English output");
Console.WriteLine($@"  c:\Exercise\{projectName}\data.txt");
Console.WriteLine();
Console.WriteLine($@"{russianMessage}");
Console.WriteLine($@"  c:\Exercise\{projectName}\ru-RU\data.txt");