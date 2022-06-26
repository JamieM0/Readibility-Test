using System.IO;

Console.WriteLine("Welcome to Readibility Test! \r\n");
string name;

//Check if the settings.conf file exists
if (!File.Exists("settings.conf"))
{
    Console.WriteLine("This is the first time setup! \r\n");
    Console.Write("What is your name? \r\nName: ");
    name = Console.ReadLine();
    File.WriteAllText("settings.conf", name);
    //Write name string to settings.conf file
}
else
{
    //Open settings.conf and save the contents to name variable
    name = File.ReadAllText("settings.conf");
}

Console.WriteLine($"\r\nHello, {name}!\r\n");
Console.WriteLine("Choose an option:\r\n1: Start Readibility Test\r\n2: Exit\r\n\r\nOption: ");
string option = Console.ReadLine();

bool IsDigitsOnly(string str)
{
    foreach (char c in str)
    {
        if (c < '0' || c > '9')
            return false;
    }
    return true;
}

if (IsDigitsOnly(option))
{
    //Console.WriteLine("Yes!");
    Console.WriteLine("Ok!");
    Thread.Sleep(500);
    Console.Clear();
    Console.WriteLine("Place your thumb on the '+' button on your keyboard's numpad.");
    Thread.Sleep(2500);
    Console.WriteLine("Done!");
    Console.WriteLine("You are not ready! (I know this because a person who is ready would never launch / start this program)!");
    Console.WriteLine("\r\nThank you for using the Readibility Test! (Github/Jamium/Readibility-Test)");
}
else
{
    //Console.WriteLine("No!");
    Console.WriteLine("You didn't enter a valid option!\r\nError Code: 1");
}