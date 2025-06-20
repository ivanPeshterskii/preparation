// Дефолт данни
int health = 100;
int bitcoins = 0;
// Четем масива
string[] rooms = Console.ReadLine()
    .Split("|", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < rooms.Length; i++)
{
    // Разделяме го
    string[] parts = rooms[i].Split(" ");
    string keyWord = parts[0];
    // Проверки
    switch (keyWord)
    {
        case "potion":
            int number = int.Parse(parts[1]);
            Potion(ref health, number);
            break;

        case "chest":
            int numberOfBitcoins = int.Parse(parts[1]);
            Chest(ref bitcoins, numberOfBitcoins);
            break;

        default:
            string nameOfMonster = parts[0];
            int damage = int.Parse(parts[1]);
            bool isWin = Fight(nameOfMonster, ref health, damage, i + 1);
            if (!isWin)
                return;
            break;
    }
}

Console.WriteLine("You've made it!");
Console.WriteLine($"Bitcoins: {bitcoins}");
Console.WriteLine($"Health: {health}");


static void Potion(ref int health, int number)
{
    int healedAmount = Math.Min(100 - health, number);
    health += healedAmount;
    Console.WriteLine($"You healed for {healedAmount} hp.");
    Console.WriteLine($"Current health: {health} hp.");
}

static void Chest(ref int bitcoins, int numberOfBitcoins)
{
    bitcoins += numberOfBitcoins;
    Console.WriteLine($"You found {numberOfBitcoins} bitcoins.");
}

static bool Fight(string name, ref int health, int damage, int roomNumber)
{
    health -= damage;
    if (health > 0)
    {
        Console.WriteLine($"You slayed {name}.");
        return true;
    }
    else
    {
        Console.WriteLine($"You died! Killed by {name}.");
        Console.WriteLine($"Best room: {roomNumber}");
        return false;
    }
}
/*
 *  Използваме 'ref', за да внасяме промени у стоиностите на 'health' 'bitcoins';
 *  
 *  => в противен случай всичко е 0;
 */