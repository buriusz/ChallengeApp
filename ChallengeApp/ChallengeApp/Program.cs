var name = "Ewa";
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
}
