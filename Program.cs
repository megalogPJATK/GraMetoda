string heroName = "Natalia";
int health = 70;
int maxHealth = 100;
int gold = 15;
int strength = 6;
int weaponDamage = 3;
bool isRunning = true;

int CalculateDamage(int strength, int weaponDamage)
{
    return strength + weaponDamage;
}
int Heal(int health, int amount, int maxHealth)
{
    if (amount <= 0)
    {
        return health;
    }

    int newHealth = health + amount;
    return Math.Min(newHealth, maxHealth);
}
bool IsGameOver(int health)
{
    return health < 0;
}

void ShowPanelTitle(string title, ConsoleColor backgroundColor)
{
    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($"  {title.ToUpper()}  ");
    Console.ResetColor();
}

void ShowStatus(string name, int health, int maxHealth, int gold)
{
    ShowPanelTitle("Status bohatera", ConsoleColor.DarkBlue);

    Console.Write("Bohater:  ");
    Console.ResetColor();
    Console.WriteLine(name);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Zdrowie: ");
    Console.ResetColor();
    Console.WriteLine($"{health}/{maxHealth} HP");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Złoto:    ");
    Console.ResetColor();
    Console.WriteLine(gold);
}
void ShowMenu()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[1] Atak treningowy");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[2] Odpoczynek");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("[3] Koniec gry");
        Console.ResetColor();
    }


string ReadCommand()
        {
            while (true)
            {
                Console.Write("Wybór: ");
                string? command = Console.ReadLine();

                if(command == "1" || command == "2" || command == "3")
                {
                    return command;
                }

                Console.WriteLine("Nieznana komenda.");
            }
        }

while (isRunning)
{
        ShowStatus(heroName, health, maxHealth, gold);
        ShowMenu();

        string command = ReadCommand();

        if (command == "1")
        {
            int damage = CalculateDamage(strength, weaponDamage);
            Console.WriteLine($"Zadajesz {damage} obrażeń manekinowi.");
        }
        else if (command == "2")
        {
            health = Heal(health, 10, maxHealth);
            Console.WriteLine($"Odpoczywasz. Masz teraz {health} HP.");
        }
        else if (command == "3")
        {
            isRunning = false;
        }

        if (IsGameOver(health))
        {
            Console.WriteLine("Koniec gry.");
        }
}


// zadanie 7

/*
A
health = Heal(health, 10, maxHealth);

B
if (health < 20)
{
    string warning = "Mało zdrowia!";
    Console.WriteLine(warning);
}

C
Console.Write("Czy chcesz zaatakować?(tak/nie) ");
string? answer = Console.ReadLine();

if (anwser == "tak")
int CalculateDamage(int strength, int weaponDamage)
{
    Console.WriteLine("Rozpoczynam animację ataku...");
    return strength + weaponDamage;
}
else if (anwser == "nie")
{
    Console.WriteLine("Nie atakujesz.");
}
else
{
    Console.WriteLine("Nie poprawne wejście");
}
D
bool CanHeal(int health, int maxHealth, int potions) => health < maxHealth && potions > 0 && health > 0;

technicznie D to nie błąd ale może być zapisane jako

bool CanHeal(int health, int maxHealth, int potions)
{
    if(health < maxHealth && potions > 0 && health > 0)
    {
        return CanHeal;
    }
}
*/