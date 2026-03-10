// Do While Loop

// It runs the codes inside the Do block at least one time. 
// We need to add variable globally to use it later outside do code snippet or in while statement



bool isValidAge;
int age;


do
{
    Console.Write("What is your age: ");
    string ageText = Console.ReadLine();


    // TryParse here checking if ageText is valid to convert into an integer. If yes the value of this integer will in in the age variable. 
    isValidAge = int.TryParse(ageText, out age);
    if (!isValidAge)
    {
        Console.WriteLine("That was an invalid age");
    }
}
while (isValidAge == false);
Console.WriteLine($"You are {age} years old");