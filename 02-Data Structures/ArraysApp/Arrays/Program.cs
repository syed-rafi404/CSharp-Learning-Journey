// Creating New Array of a fixed size


string[] firstName = new string[5];

firstName[0] = "Superman";
firstName[1] = "Batman";
firstName[2] = "Flash";

Console.WriteLine($"The first second and third names are: {firstName[0]}, {firstName[1]}, {firstName[2]} ");


firstName[2] = "Shazam";
Console.WriteLine(firstName[2]);


//Creating an Array from a String(eg: CSV file)

string data = "SuperMan,Batman,Flash";
string[] heroes = data.Split(',');


Console.WriteLine(heroes[2]);

Console.WriteLine(heroes.Length);




// Direct initialization of different data types
string[] lastname = new string[] {"Syed", "Ar", "Rafi" };
float[] cgpa = new float[] {3.5f, 4.0f, 3.8f };
