/* var name = "Ewa";
var sex = 'f'; // lub teź bool np. true ze jest kobieta a false mezczyzna lub na odwrót, albo string "kobieta" lub "mężczyzna"
var age = 33;

if (sex == 'f' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex != 'f' && age < 18)
{
    Console.WriteLine($"Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Nie jest to kobieta w wieku poniżej 30, nie jest to Ewa w wieku 30 lat a tym bardziej mężczyzna w wieku poniżej 18 lat");
} */

//// tablica
//int[] grades = new int[5];
//string[] dayOfWeeks = new string[7];
//dayOfWeeks[0] = "poniedziałek";
//dayOfWeeks[1] = "wtorek";
//dayOfWeeks[2] = "środa";
//dayOfWeeks[3] = "czwartek";
//dayOfWeeks[4] = "piątek";
//dayOfWeeks[5] = "sobota";
//dayOfWeeks[6] = "niedziela";

////Console.WriteLine(dayOfWeeks[6]);

//for (var i = 0; i < dayOfWeeks.Length; i++)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

//List<string> dayOfWeeks = new List<string>();
//dayOfWeeks.Add("poniedziałek");
//dayOfWeeks.Add("wtorek");
//dayOfWeeks.Add("środa");
//dayOfWeeks.Add("czwartek");
//dayOfWeeks.Add("piątek");
//dayOfWeeks.Add("sobota");
//dayOfWeeks.Add("niedziela");

//for (var i = 0;i < dayOfWeeks.Count; i++)
//{
//    Console.WriteLine(dayOfWeeks[i]);
//}

//foreach (var day in dayOfWeeks)
//{
//    Console.WriteLine(day);
//}

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] numbersCounter = new int[10];

foreach (char letter in letters)
{
    int tmpLetter = letter - 48;
    for (int i = 0; i < numbersCounter.Length; i++)
    {
        if (tmpLetter == i)
        {
            numbersCounter[i]++;
        }
    }
}

for (var i = 0; i < 10; i++)
{
    Console.WriteLine(i + " => " + numbersCounter[i]);
}