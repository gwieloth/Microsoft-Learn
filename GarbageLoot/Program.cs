using System.Diagnostics;

Random dice = new Random();
Console.WriteLine("Çok açsın...");
Console.ReadKey();
Console.WriteLine("Günlerdir boğazından bir kuru ekmek bile geçmedi...");
Console.ReadKey();
Console.WriteLine("Yemek kokularından burnun sızlıyor...");
Console.WriteLine("Sanırım artık zamanı geldi...");
Console.ReadKey();
Console.Clear();



Console.WriteLine("Önünde 3 adet çöp var. (1,2 veya 3 yazmalısın.)\n");
Console.Write("Sen hangisini karıştırmak istersin: ");
string userResponse = Console.ReadLine();
Console.Clear();

if (userResponse == "1")
{
    Console.WriteLine("İlk çöpü seçtin.");
    Console.WriteLine("Çöpe içine doğru atıldın.");
    Console.ReadKey();
    Console.WriteLine("-LANET OLSUN O DA NEYİN NESİ");
    Console.ReadKey();
    Console.WriteLine("*çöp kapağı üstüne kapandı.");
    Console.WriteLine("-KİMSE YOK MU BU DA NE!");
    Console.ReadKey();
    Console.WriteLine("*çöpün içindeki yaratık ile boğuşmaya başlarsın.");
    Console.WriteLine("-ÇEK LANET ELİNİ ÜSTÜMDEN AGHHH");
    Console.ReadKey();
    Console.WriteLine("Dövüşü kazanmak istiyosan zar atmalısın, bir tuşa bas:");
    Console.ReadKey();
    Console.Clear();

    int fightWithMonster = dice.Next(1,20);

    if (fightWithMonster < 11)
    {
        Console.WriteLine("İyi denemeydi fakat yaratık seni YEDİ!");
        Console.ReadKey();
        Console.WriteLine("En azından artık aç değilsin...");
        Console.ReadKey();
        Console.WriteLine("KÖTÜ SON #1");
    }
    else
    {
        Console.WriteLine("HA HA, seni lanet yaratık!");
        Console.ReadKey();
        Console.WriteLine("BAŞARDIN!, yaratığı öldürdün altından bir sürü konserve yiyecek çıktı.");
        Console.WriteLine("Sonunda karnına bişeyler gireceği için çok mutlusun!");
        Console.ReadKey();
        Console.WriteLine("MUTLU SON #1");
        Console.ReadKey();
    }

}
if (userResponse == "2")
{
    Console.WriteLine("İkinci çöpü seçtin.");
    Console.WriteLine("Çöpe içine doğru atıldın.");
    Console.ReadKey();
    Console.WriteLine("Çöpün içi zerzavat dolu, bir sürü metalin arasına elini korkusuzca sokuyorsun.");
    Console.ReadKey();
    Console.Clear();

    int tetenoz = dice.Next(1,6);

    if (tetenoz < 2)
    {
        Console.WriteLine("-AHHHH");
        Console.WriteLine("-Lanet olsun elim!");
        Console.ReadKey();
        Console.WriteLine("*elin metal parçalardan dolayı kesildi...");
        Console.WriteLine("Metal paslıydı ve tetenoz oldun...");
        Console.ReadKey();
        Console.WriteLine("Acı içinde hastaneye koşuyosun!");
        Console.ReadKey();
        Console.WriteLine("KÖTÜ SON #2");
        Console.ReadKey();
    }
    else
    {
        int goodLoot = dice.Next(1,20);

        if (goodLoot >= 15)
        {
            Console.WriteLine("Gözlerine inanamıyosun.");
            Console.WriteLine("-HASSİKTİR!");
            Console.ReadKey();
            Console.WriteLine("Bi anda elini ağzına götürüp ağzını kapattın.");
            Console.WriteLine("Ya etrafında bir hırsız varsa? Çünkü bir ALTIN RENGİ KOLYE BULDUN!");
            Console.ReadKey();
            Console.WriteLine("Sakince etrafa bakıyorsun...");
            Console.ReadKey();
            Console.Clear();

            int theyHear = dice.Next(1,6);
            if (theyHear == 1)
            {
                Console.WriteLine("*kafana sert bir cisimle vurdular.");
                Console.WriteLine("Aradan birkaç saat geçiyor...");
                Console.ReadKey();
                Console.WriteLine("Çöplüğün başında uyanıyorsun...");
                Console.ReadKey();
                Console.WriteLine("-Ahhh, lanet olsun!");
                Console.WriteLine("Ceplerine baktığında herhangi bir şeyin olmadığını görüyosun...");
                Console.ReadKey();
                Console.WriteLine("Bağırmamalıydın...");
                Console.ReadKey();
                Console.WriteLine("KÖTÜ SON #3");
            }
            else
            {
                Console.WriteLine("Sanırım kimse duymadı!");
                Console.WriteLine("Hemen kolyeyi cebine attın.");
                Console.ReadKey();
                Console.WriteLine("En yakın kuyumcuya gidiyorsun.");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Kuyumcuya girdin.");
                Console.WriteLine("-Merhaba ben bu kolyeyi satmak istiyorum.");
                Console.ReadKey();
                Console.WriteLine("*adam sana iğrenmiş gibi bakış attı.");
                Console.WriteLine("Ama ne de olsa müşterisin değil mi?");
                Console.ReadKey();
                Console.WriteLine("-Tabi efendim, verin bana ben bi inceleyeyim.");
                Console.ReadKey();
                Console.Clear();

                int goldOrSilver = dice.Next (1,2);

                Console.ReadKey();
                if (goldOrSilver == 1)
                {
                    Console.WriteLine("-Efendim kolyeyi inceledim.");
                    Console.WriteLine("-Bu kolye gümüş biz bu kuyumcuda sadece altınla ilgileniyoruz.");
                    Console.ReadKey();
                    Console.WriteLine("Lanet olsun, tüm hayallerimiz suya düştü...");
                    Console.WriteLine("Çaresizce adama: \"Peki bunla kim ilgilenebilir?\" diye soruyorsun.");
                    Console.ReadKey();
                    Console.WriteLine("Adam sana yan taraftaki dükkandan bahsediyor...");
                    Console.ReadKey();
                    Console.WriteLine("Biraz için buruk oraya gidiyorsun, kolyenin fiyatı dudak uçuklatmasa da gene de iyi.");
                    Console.ReadKey();
                    Console.WriteLine("Parayı alıp gümüşçüden çıktın, hemen bi yemek yemelisin!");
                    Console.ReadKey();
                    Console.WriteLine("MUTLU SON #2");
                }
                else
                {
                    Console.WriteLine("-Efendim kolyeyi inceledim.");
                    Console.WriteLine("-Bu kolye çok nadide bir parça.");
                    Console.ReadKey();
                    Console.WriteLine("-Bu kolyeyi nereden buldunuz?");
                    Console.WriteLine("Adam bir anda neden böyle bir soru sordu ki? Tipimizden olsa gerek...");
                    Console.ReadKey();
                    Console.WriteLine("-\"Eşimden kalan bir hatıra...\" dedin.");
                    Console.ReadKey();
                    Console.WriteLine("Adamın içinin burkulması suratına yansıdı...");
                    Console.WriteLine("Kuyumcudan parayı aldın ve çıktın.");
                    Console.ReadKey();
                    Console.WriteLine("Yalanı sevmeyiz ama arada da işe yarıyor değil mi?");
                    Console.WriteLine("Kazandığın para seni birkaç ay götürür. ZENGİN OLDUK!");
                    Console.ReadKey();
                    Console.WriteLine("MUTLU SON #3");
                }
            }



        }
        if (goodLoot < 15 && goodLoot >= 10)
        {
            Console.WriteLine("Aaa, birkaç adet hırdavat parçası, bunları toplayıp para kazanabiliriz!");
            Console.ReadKey();
            Console.WriteLine("Yanında bulunan çöp poşetine bunları doldurmaya başladın.");
            Console.WriteLine("Bunları satıp yemek alabiliriz!");
            Console.ReadKey();
            Console.WriteLine("MUTLU SON #4");
        }
        if (goodLoot < 10)
        {
            Console.WriteLine("Uuu birileri bizim için birkaç yemek bırakmış!");
            Console.ReadKey();
            Console.WriteLine("Yemek artıklarını yanında bulunan plastik kaba atıyorsun.");
            Console.WriteLine("-N-neyse, idare edeceğiz..");
            Console.ReadKey();
            Console.WriteLine("En azından açlığın dinecek ve hayatta kalmak için birkaç günün daha olacak. Pozitif düşün.");
            Console.ReadKey();
            Console.WriteLine("MUTLU SON #5");
        }
    }
}
if (userResponse == "3")
{
    Console.WriteLine("Üçüncü çöpü seçtin.");
    Console.WriteLine("Çöpe içine doğru atıldın.");
    Console.ReadKey();
    Console.WriteLine("Kafanı çok sert bi şekilde çöpün dibine çarpıyorsun!");
    Console.ReadKey();
    Console.WriteLine("-Ahh..");
    Console.WriteLine("Maalesef, çöp arabaları senden önce davranmışlar...");
    Console.ReadKey();
    Console.WriteLine("KÖTÜ SON #4");
}
if (userResponse == "4")
{
    Console.WriteLine("Bir anda etrafındaki duvar yıkılıyor...");
    Console.WriteLine("Her şey bir yalanmış...");
    Console.ReadKey();
    Console.WriteLine("Neden Bay Anderson, neden...");
    Console.ReadKey();
    Console.WriteLine("Easter Egg Ending!");
}

//Gwieloth - 28.12.2025