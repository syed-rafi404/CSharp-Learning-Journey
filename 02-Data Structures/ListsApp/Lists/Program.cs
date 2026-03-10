
// string[] firstname = new string[5];

// List<> ----- Means "Generic" like the type. For example List<string> here t = String so the list is string

using System.ComponentModel;

List<string> firstnames = new List<string>();

firstnames.Add("Rafi");
firstnames.Add("Ahsan");
firstnames.Add("Arafat");
firstnames.Add("Pranto");
firstnames.Add("Ashik");


// In list to see the total element we use .Count not .Legth like Array
int len = firstnames.Count;


List<double> cgpa = new List<double>();

cgpa.Add(3.38);
cgpa.Add(3.77);
cgpa.Add(3.00);
cgpa.Add(3.80);
cgpa.Add(3.20);

for (int i = 0; i < firstnames.Count; i++)
{
    Console.WriteLine($"Student's Name is {firstnames[i]}");
    Console.WriteLine($"Student's CGPA is {cgpa[i]}");

}


// Can't add elements in Array
string data = "Rafi,Ahsan,Sakib";
string[] names = data.Split(",");


//This is the modern approach of doing task. Here we convert the string to a List 
// So there are no limitation of adding elements here.
List<string> list = data.Split(",").ToList();
list.Add("Arafat");

