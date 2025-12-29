Console.WriteLine("Selam yeni kölem! Seninle bir oyun oynacağız... BİR ZAR OYUNU!");
Console.ReadKey();
Console.WriteLine("Eğer ki, 10 veya daha yüksek bir sayı atarsan, kurtulursun.");
Console.ReadKey();
Console.WriteLine("Aksi halde, kölem OLACAKSIN! HA HA HA");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Zar atmak için, bir tuşa bas.");
Console.ReadKey();

Random roll = new Random();
int twentyDice = roll.Next(1,20);
Console.Clear();

if (twentyDice < 10)
{
    Console.WriteLine("Korkusuzca bir atış yaptın!");
    Console.WriteLine("Zar masada sekiyor ve sekiyor...");
    Console.ReadKey();
    Console.WriteLine($"Fakat zar {twentyDice} geldi...");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Ork kahkalar savurmaya başladı!");
    Console.ReadKey();
    Console.WriteLine("-HA HA HA SONSUZA KADAR BENİMSİN!");
    Console.ReadKey();
    Console.WriteLine("*ork gardiyanları yanına geliyor ve kollarına giriyorlar...");
    Console.ReadKey();
    Console.WriteLine("KÖTÜ SON");
}
else
{
    Console.WriteLine("Korkusuzca bir atış yaptın!");
    Console.WriteLine("Zar masada sekiyor ve sekiyor...");
    Console.ReadKey();
    Console.WriteLine($"VE zar {twentyDice} geldi!");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Eline çok güveniyordun ve EVET OLDU BAŞARDIN");
    Console.ReadKey();
    Console.WriteLine("Ork sinirden küplere bindi sen ise bir rahatlamanın eşliğinde yüzünde bir gülümsemeyle:");
    Console.ReadKey();
    Console.WriteLine("-Sanırım çıkabilirim, değil mi?");
    Console.ReadKey();
    Console.WriteLine("*ork homurdanır ve:");
    Console.WriteLine("-Açın kapıyı çıksın...");
    Console.ReadKey();
    Console.WriteLine("Sakin ve soğukkanlı adımlarla kapıdan dışarı çıkıyorsun...");
    Console.WriteLine("GÜZEL SON");
}
