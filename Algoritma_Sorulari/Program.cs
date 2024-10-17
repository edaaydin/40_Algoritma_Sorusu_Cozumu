#region Soru1 - İki sayının toplamını veren programın algoritma ve akış diyagramını çiziniz

//bool sonuc1, sonuc2;
//int ilkSayim, ikinciSayim;
//do
//{
//    Console.Write("Lutfen ilk sayinizi alınız : ");
//    sonuc1 = int.TryParse(Console.ReadLine(), out ilkSayim);

//    Console.Write("Lutfen ikinci sayinizi aliniz : ");
//    sonuc2 = int.TryParse(Console.ReadLine(), out ikinciSayim);

//} while (!(sonuc1 && sonuc2));

//int toplam = ilkSayim + ikinciSayim;

//Console.WriteLine($"Sayilar Toplami = {toplam}");
#endregion

#region Soru2 - Kullanıcının girdiği iki sayının karelerinin toplamını görüntüleyen programın algoritma ve akış diyagramını çiziniz.

//bool sonuc1, sonuc2;
//int ilkSayim, ikinciSayim;
//double toplam = 0;
//do
//{
//    Console.Write("Lutfen ilk sayinizi alınız : ");
//    sonuc1 = int.TryParse(Console.ReadLine(), out ilkSayim);

//    Console.Write("Lutfen ikinci sayinizi aliniz : ");
//    sonuc2 = int.TryParse(Console.ReadLine(), out ikinciSayim);

//} while (!(sonuc1 && sonuc2));

//toplam = Math.Pow(ilkSayim, 2) + Math.Pow(ikinciSayim, 2);
//Console.WriteLine($"Sayilarin Toplaminin Kareleri = {toplam}");
#endregion

#region Soru3 - 1'den 100'e kadar olan sayılarının küplerinin toplamını bulan programın algoritma ve akış diyagramını çiziniz
//double toplam = 0;
//for (int i = 1; i <= 100; i++)
//{
//    toplam = toplam + Math.Pow(i, 3);
//}
//Console.WriteLine(toplam);
#endregion

#region Soru4 - Doğum tarihi girilen kişinin yaşını hesaplayan programın algoritma ve akış diyagramını çiziniz

//bool sonuc;
//DateTime dt;
//int yas;
//do
//{
//    Console.Write("Lutfen Dogum Tarihinizi GG/AA/YY Seklinde Giriniz : ");
//    sonuc = DateTime.TryParse(Console.ReadLine(), out dt);

//} while (!(sonuc));

//yas = (DateTime.Now.Year) - (dt.Year);
//Console.WriteLine($"Yasiniz : {yas}'dir.");
#endregion

#region Soru5 - Girilen sayının faktöriyelini bulan programın algoritma ve akış diyagramını çiziniz.

//bool result;
//uint sayi;
//do
//{
//    Console.WriteLine("Faktoriyeli alinacak sayiyi giriniz: ");
//    result = UInt32.TryParse(Console.ReadLine(), out sayi);
//} while (!result);
//long faktoriyel = 1;


//for (uint i = sayi; i > 1; i--)
//{
//    if (sayi == 0 || sayi == 1)
//        faktoriyel = 1;
//    else
//        faktoriyel *= i;
//}
//Console.WriteLine($"{sayi}! = {faktoriyel}");
//#endregion

//#region Soru6 - Çarpma işlemini toplama kullanarak bulan programın algoritma ve akış diyagramını çiziniz.

//bool sonuc1, sonuc2;
//int sayi1, sayi2, carpim = 0;

//do
//{
//    Console.Write("Lutfen birinci sayinizi giriniz :");
//    sonuc1 = int.TryParse(Console.ReadLine(), out sayi1);

//    Console.Write("Lutfen ikinci sayinizi giriniz :");
//    sonuc2 = int.TryParse(Console.ReadLine(), out sayi2);

//} while (!(sonuc1 && sonuc2));

//for (int i = 1; i <= sayi2; i++)
//{
//    carpim = carpim + sayi1;

//}
//Console.WriteLine(carpim);
#endregion

#region Soru7 - Bölme işlemini çıkarma kullanarak yapan programın algoritma ve akış diyagramını çiziniz.

//Console.Write("Bolunen sayiyi giriniz : ");
//int bolunen = Convert.ToInt32(Console.ReadLine());

//Console.Write("Bolen sayiyi giriniz : ");
//int bolen = Convert.ToInt32(Console.ReadLine());

//if (bolen == 0)
//{
//    Console.WriteLine("Bolen sifir olamaz !");
//    return;
//}

//int kalan = bolunen;
//int sonuc = 0;

//while (kalan >= bolen)
//{
//    kalan -= bolen;
//    sonuc++;
//}

//Console.WriteLine("Sonuç: " + sonuc);
//Console.WriteLine("Kalan: " + kalan);
#endregion

#region Soru8 - Girilen sayının istenilen sayıya göre mod işlemini yaptıran programın algoritma ve akış diyagramını çiziniz.(carpma islemi)

//int taban, us;
//bool sonuc1, sonuc2;
//double modİslemi = 0;
//do
//{
//    Console.WriteLine("Lutfen taban sayisini giriniz");
//    sonuc1 = int.TryParse(Console.ReadLine(), out taban);

//    Console.WriteLine("Lutfen us sayisini giriniz");
//    sonuc2 = int.TryParse(Console.ReadLine(), out us);

//} while (!(sonuc1 && sonuc2));

//for (int i = 0; i <= us; i++)
//{
//    modİslemi = Math.Pow(taban, us);
//}
//Console.WriteLine($"{taban}^{us} = {modİslemi}");
#endregion

#region Soru9 - Girilen sayının kaç basamaklı olduğunu söyleyen programın algoritma ve akış diyagramını çiziniz

//Console.Write("Lutfen basamak sayisi hesaplanacak olan sayinizi giriniz : ");
//int sayi = int.Parse(Console.ReadLine());
//int basamakSayisi = 0;
//int İlkGirilenHali = sayi;

//if (sayi < 0)
//    sayi = Math.Abs(sayi);

//if (sayi == 0 || sayi == 1)
//    basamakSayisi = 1;

//else
//    while (sayi > 0)
//    {
//        sayi /= 10;
//        basamakSayisi++;
//    }
//Console.WriteLine($"{İlkGirilenHali} sayisi {basamakSayisi} basamakli sayidir !");
#endregion

#region Soru10 - Girilen 3 basamaklı bir sayının basamaklarının küpleri toplamı sayının kendine eşit olup olmadığını bulan program (armstrong)

// Armstrong Sayi = sayinin, basamaklarinin küpleri toplami kendisine esit ise bu sayi armstrong sayidir. orn = 153 sayisi.

//Console.Write("Lutfen uc basamakli bir sayi giriniz :");
//int sayi = Convert.ToInt32(Console.ReadLine());

//if (sayi < 100 || sayi > 999)   // sayı 100 ile 999 arasında mı diye kontrol et
//    Console.WriteLine("Gecersiz sayi, Lutfen tekrar deneyiniz !");

//sayının basamaklarını ayır 
//int birler = sayi % 10;

//int onlar = (sayi / 10) % 10;

//int yuzler = (sayi / 100) % 10;

//int kuplerToplami = (int)Math.Pow(birler, 3) + (int)Math.Pow(onlar, 3) + (int)Math.Pow(yuzler, 3);

//if (kuplerToplami == sayi)
//    Console.WriteLine($"{sayi} sayisi Armstrong bir sayidir :)");

//else
//    Console.WriteLine($"{sayi} sayisi Armstrong bir sayi degildir :(");
#endregion

#region Soru11 - Klavyeden girilen 20 adet sayıdan çift sayıların toplamının tek sayıların toplamına oranını bulan program

//bool sonuc;
//int tekToplam = 0, CiftToplam = 0, sayi;

//for (int i = 1; i <= 20; i++)
//{
//    do
//    {
//        Console.Write($"Lutfen {i}. sayi giriniz : ");
//        sonuc = int.TryParse(Console.ReadLine(), out sayi);

//    } while (!sonuc);

//    if (sayi % 2 == 0)
//        CiftToplam += sayi;

//    else
//        tekToplam += sayi;
//}
//Console.WriteLine(tekToplam);
//Console.WriteLine(CiftToplam);
//Console.Writeline(ciftToplam / tekToplam);
#endregion

#region Soru12 - 10 ile 1000 arasındaki tam kare sayıları ekrana yazdıran program

//for (int i = 4; i < 1000; i++)

//    if (i * i <= 1000)
//        Console.WriteLine(Math.Pow(i, 2));
#endregion

#region Soru13 - Klavyeden girilen 25 adet sayı içerisinden negatif olanların toplamını, çift sayıların çarpımını, 7'ye eşit olanların adetini bulup ekrana yazdıran program

//Bu soru hem else if ile hem de if'ler ile oluyor.

//bool sonuc;
//int negatifToplami = 0, ciftlerCarpimi = 1, yediEsitAdet = 0, sayi;

//for (int i = 1; i <= 25; i++)
//{
//    do
//    {
//        Console.Write($"{i}. Sayinizi Giriniz : ");
//        sonuc = int.TryParse(Console.ReadLine(), out sayi);
//    } while (!sonuc);

//    if (sayi < 0)
//        negatifToplami += sayi;

//    else if (sayi % 2 == 0)
//        ciftlerCarpimi *= sayi;

//    else if (sayi == 7)
//        yediEsitAdet++;
//}
//Console.WriteLine($"Negatif Sayilar Toplami = {negatifToplami}");
//Console.WriteLine($"Cİft Sayilar Carpimi = {ciftlerCarpimi}");
//Console.WriteLine($"Yediye esit olan Sayi Adedi = {yediEsitAdet}");
#endregion
#region Soru14 - Çarpım Tablosu yapan program.

// i ve j sayısını al iki sayıyı çarp

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//    {
//        Console.WriteLine($"{i} * {j} = {i * j}\n");
//    }
//}
#endregion

#region Soru15 - Girilen sayının 5'in kuvveti olup olmadığını bulan program
//int sayi;
//bool sonuc;
//do
//{
//    Console.Write("Lutfen Bir Sayi Giriniz : ");
//    sonuc = int.TryParse(Console.ReadLine(), out sayi);
//} while (!sonuc);

//if (sayi % 5 == 0)
//    Console.WriteLine($"{sayi} sayisi 5'in kuvvetidir !");

//else
//    Console.WriteLine($"{sayi} sayisi 5'in kuvveti degildir !");
#endregion

#region Soru16 - X,Y pozitif olmak üzere, eğer x sayısının çarpanları toplamı y sayısına ve aynı zamanda y sayısının çarpanları toplamı x sayısına eşit ise bu sayılar dost sayılardır. Buna göre girilen iki sayının dost olup olmadığını bulan program

//Console.Write("X sayisini girin: ");
//int x = int.Parse(Console.ReadLine());

//Console.Write("Y sayisini girin: ");
//int y = int.Parse(Console.ReadLine());

//// x ve y pozitif sayılar mı kontrol edelim
//if (x <= 0 || y <= 0)
//    Console.WriteLine("Lütfen pozitif tam sayılar girin.");

//int xCarpanlarininToplami = 0, yCarpanlarininToplami = 0;

//for (int i = 1; i < x; i++)
//{

//    if (x % i == 0)
//        xCarpanlarininToplami += i;
//}

//for (int i = 1; i < y; i++)
//{

//    if (y % i == 0)
//        yCarpanlarininToplami += i;
//}

//if (x == yCarpanlarininToplami && y == xCarpanlarininToplami)
//    Console.WriteLine($"{x} sayisi ile {y} sayisi DOST sayilardir :)");

//else
//    Console.WriteLine($"{x} sayisi ile {y} sayisi dost sayi degildir :(");
#endregion
#region Soru17 - Fibonacci serisinin ilk 10 terimini ekrana basan program

//int ilkDeger = 0;
//int sonDeger = 1;
//int toplam;
////string fibonacci "";

//bool result;
//int sayi;
//do
//{
//    Console.Write("Lutfen bir sayi giriniz : ");
//    result = int.TryParse(Console.ReadLine(), out sayi);
//} while (!result);

//for (int i = 0; i <= sayi; i++)
//{
//    //fİbonacci += ($"{ilkDeger} ");
//    toplam = ilkDeger + sonDeger;
//    ilkDeger = sonDeger;
//    sonDeger = toplam;
//    Console.WriteLine(toplam);
//}
#endregion

#region Soru18 - Klavyeden girilen bir sayının negatif, pozitif veya 0 olup olmadığını bulan program.

//bool sonuc;
//int sayi;
//do
//{
//    Console.Write("Lutfen bir sayi giriniz :");
//    sonuc = int.TryParse(Console.ReadLine(), out sayi);

//} while (!sonuc);

//if (sayi == 0)
//    Console.WriteLine($"{sayi} = 0");

//else if (sayi > 0)
//    Console.WriteLine($"{sayi} = Pozitiftir.");

//else
//    Console.WriteLine($"{sayi} = Negatiftir.");
#endregion

#region Soru19 - Girilen sayının mükemmel sayı olup olmadığını bulan program

// Mukemmel sayı = kendisi haric pozitif carpanlarının toplamına esit olan sayılardır.
// Çarpanı toplama ekliyoruz     
// Eğer çarpanlar toplamı sayının kendisine eşitse mükemmel sayı

//bool sonuc;
//int sayi, bolenToplami = 0;
//do
//{
//    Console.Write("Lutfen sayinizi giriniz :");
//    sonuc = int.TryParse(Console.ReadLine(), out sayi);
//} while (!sonuc);

//for (int i = 1; i < sayi; i++)
//{
//    if (sayi % i == 0)
//        bolenToplami += i;
//}

//if (bolenToplami == sayi)
//    Console.WriteLine($"{sayi} Sayisi Mukemmel Sayidir !");

//else
//    Console.WriteLine($"{sayi} Sayisi Mukemmel Sayi Degildir !");
#endregion

#region Soru20 - 1-100 arasındaki çift sayıların toplamının mükemmel sayı olup olmadığını bulan program

//bool sonuc;
//int sayi, ciftToplam = 0;
//do
//{
//    Console.Write("Lutfen sayinizi giriniz :");
//    sonuc = int.TryParse(Console.ReadLine(), out sayi);
//} while (!sonuc);


//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0)
//        ciftToplam += i;
//}

//if (ciftToplam == sayi)
//    Console.WriteLine($"{ciftToplam} Sayisi Mukemmel Sayidir !");

//else
//    Console.WriteLine($"{ciftToplam} Sayisi Mukemmel Sayi Degildir !");
#endregion

#region Soru21 - Herhangi bir sayının herhangi bir dereceden kuvvetini bulan program (uslu sayi)

//bool sonuc;
//int taban, us;

//do
//{
//    Console.Write("Taban Sayinizi Giriniz : ");
//    sonuc = int.TryParse(Console.ReadLine(), out taban);

//    Console.Write("Taban Sayinizi Giriniz : ");
//    sonuc = int.TryParse(Console.ReadLine(), out us);

//} while (!sonuc);

//Console.WriteLine($"{taban}^{us} = {Math.Pow(taban, us)}");
#endregion

#region Soru22 - Girilen sayının abundant (güçlü) sayı mı ya da Deficient (güçsüz) sayı mı olduğunu bulan program

// Guclu (Abundant) sayi = Pozitif bolenlerinin toplamı kendisinden buyukse guclu sayidir.
// Gucsuz (Deficent) sayi = Pozitif bolenlerinin toplamı kendinden kucukse gucsuz sayıdır.
// Mukemmel Sayi = Pozitif bolenlerin toplamı kendisine esit ise bu sayı mükemmel sayidir.

//bool sonuc;
//int sayi, bolenlerToplami = 0;

//do
//{
//    Console.Write("Lutfen sayinizi giriniz :");
//    sonuc = int.TryParse(Console.ReadLine(), out sayi);

//} while (!sonuc);

//for (int i = 1; i < sayi; i++)
//{
//    if (sayi % i == 0)
//        bolenlerToplami += i;
//}
//if (bolenlerToplami == sayi)
//    Console.WriteLine($"{sayi} Sayisi Mukemmel Sayidir !");

//else if (bolenlerToplami > sayi)
//    Console.WriteLine($"{sayi} Sayisi Guclu(Abundant) Sayidir !");

//else
//    Console.WriteLine($"{sayi} Sayisi Gucsuz(Deficent) Sayidir !");
#endregion

#region Soru23 - 1'den 500'e kadar olan tamsayıların toplamını bulan program

//int toplam = 0;

//for (int i = 1; i <= 500; i++)
//{
//    toplam += i;
//}
//Console.WriteLine($"1-500 arasindaki sayilar toplami = {toplam}");
#endregion

#region Soru24 - Girilen a ve b sayısı 50'den büyük olduğunda c=a+b işlemini yapan değilse bu sayılar uygun değil yazdıran program

//bool result1, result2;
//int a, b, c = 0;

//do
//{
//    Console.Write("A sayisiniz giriniz : ");
//    result1 = int.TryParse(Console.ReadLine(), out a);

//    Console.Write("B sayisiniz giriniz : ");
//    result2 = int.TryParse(Console.ReadLine(), out b);

//} while (!(result1 && result2));

//if (a > 50 && b > 50)
//{
//    c = a + b;
//    Console.WriteLine(c);
//}

//else
//    Console.WriteLine("Girdiginiz Degerler Toplama Islemi Icin Uygun Degildir !");
#endregion

#region Soru25 - 1'den 63'e kadar olan sayılar arasında istenilen sayıyı maksimum 6 seferde bulan program

//Random random = new Random();
//int gizliSayi = random.Next(1, 64);// 1 ile 63 arasında rastgele bir sayı seçilir

//int tahmin;
//int hak = 6;  // Kullanıcıya verilen tahmin hak sayısı

//Console.WriteLine("1 ile 100 arasında bir sayı tutun. 6 tahmin hakkınız var !");
//for (int i = 1; i <= hak; i++)
//{
//    Console.Write("Tahmininizi girin: ");
//    bool result = int.TryParse(Console.ReadLine(), out tahmin);

//    if (!result)
//    {
//        Console.WriteLine("Lütfen geçerli bir sayı girin!");
//        i--;    // Geçersiz girişte hak kaybı yaşanmaz
//    }

//    if (tahmin < gizliSayi)
//    {
//        Console.WriteLine("Daha büyük bir sayı girin.");
//        Console.WriteLine($"Kalan tahmin hakkınız: {hak - i}"); // Kalan tahmin haklarını göster
//    }
//    else if (tahmin > gizliSayi)
//    {
//        Console.WriteLine("Daha küçük bir sayı girin.");
//        Console.WriteLine($"Kalan tahmin hakkınız: {hak - i}"); // Kalan tahmin haklarını göster
//    }
//    else
//    {
//        Console.WriteLine($"Tebrikler! Doğru sayıyı {i}. denemede buldunuz: {gizliSayi}");
//        Console.WriteLine($"Kalan tahmin hakkınız: {hak - i}"); // Kalan tahmin haklarını göster                                                       
//    }
//}
//Console.WriteLine($"Tahmin hakkınız bitti. Doğru sayı: {gizliSayi}");   // Tahmin hakları bittiğinde doğru sayıyı bildir
#endregion

#region Soru26 - Girilen decimal (onluk) bir sayının binary (ikilik) bir sayıya dönüştüren program

//Console.Write("Bir decimal say giriniz : ");
//int decimalSayi = int.Parse(Console.ReadLine());

// Decimal sayıyı binary sayıya dönüştürüyoruz

//string binarySayi = "";
//int sayi = decimalSayi;

//if (sayi == 0)
//{
//    binarySayi = "0";
//}
//else
//{
//    while (sayi > 0)
//    {
//        // Kalanı alıp binary stringine ekliyoruz

//        binarySayi = (sayi % 2) + binarySayi;
//        sayi /= 2;
//    }
//}

//Console.WriteLine($"{decimalSayi} sayisinin ikilik (binary) karsiligi : {binarySayi}");
#endregion

#region Soru27 - Binary olarak girilen sayıyı decimal sayıya çeviren program
// Kullanıcıdan binary (ikilik) bir sayı alıyoruz
//Console.Write("Bir binary sayi giriniz : ");
//string binarySayi = Console.ReadLine();

// Binary sayıyı decimal (onluk) sayıya dönüştürüyoruz
//int decimalSayi = 0;
//int uzunluk = binarySayi.Length;

// En soldan sağa doğru binary sayıdaki her bit'i kontrol ediyoruz
//for (int i = 0; i < uzunluk; i++)
//{
//    if (binarySayi[i] == '1')
//    {
//        // Eğer bit 1 ise, o basamağın değerini hesaplıyoruz
//        decimalSayi += (int)Math.Pow(2, uzunluk - 1 - i);
//    }
//}
//Console.WriteLine($"{binarySayi} binary sayısının ondalık (decimal) karşılığı: {decimalSayi}");
#endregion

#region Soru28 - Verilen yılın artık yıl olup olmadığını bulan program

//bool sonuc;
//int yil;

//do
//{
//    Console.WriteLine("Lutfen yili giriniz : ");
//    sonuc = int.TryParse(Console.ReadLine(), out yil);
//} while (!sonuc);

//if (yil % 4 == 0)
//{
//    if (yil % 100 == 0)
//    {
//        if (yil % 400 == 0)
//        {
//            Console.WriteLine($"{yil} yılı artık yıldır!");
//        }
//        else
//        {
//            Console.WriteLine($"{yil} yılı artık yıl değildir.");
//        }
//    }
//    else
//    {
//        Console.WriteLine($"{yil} yılı artık yıldır!");
//    }
//}
//else
//{
//    Console.WriteLine($"{yil} yılı artık yıl değildir.");
//}
#endregion

#region Soru29 - Boyu ile kilosu girilen kişinin şişman mı, zayıf mı yoksa ideal kiloda mı olduğunu gösteren program

//bool result1, result2;
//double boy, kilo, vucutkitleIndeksi;

//do
//{
//    Console.Write("Lutfen Kilonuzu Giriniz : ");
//    result1 = double.TryParse(Console.ReadLine(), out kilo);

//    Console.Write("Lutfen Boyunuzu Metre Cinsinden Giriniz : ");
//    result2 = double.TryParse(Console.ReadLine(), out boy);

//} while (!(result1 && result2));

//vucutkitleIndeksi = kilo / (Math.Pow(boy, 2));

//if (vucutkitleIndeksi > 15 && vucutkitleIndeksi < 30)
//    Console.WriteLine("Zayif");

//else if (vucutkitleIndeksi > 30 && vucutkitleIndeksi < 50)
//    Console.WriteLine("Normal Kiloda");

//else
//    Console.WriteLine("kilolu");

//Console.WriteLine(vucutkitleIndeksi);
#endregion

#region Soru30 - Dairenin alanını ve çevresini bulan program

//bool sonuc;
//double alan, cevre, yariCap, pi = Math.PI;

//do
//{
//    Console.Write("Yaricap degeri giriniz : ");
//    sonuc = double.TryParse(Console.ReadLine(), out yariCap);
//} while (!sonuc);

//alan = pi * Math.Pow(yariCap, 2);
//cevre = 2 * pi * yariCap;

//Console.WriteLine($"Dairenin Alani : {alan}");
//Console.WriteLine($"Dairenin Cevresi : {cevre}");
#endregion

#region Soru31 - Kenarları A,B,C,D olan bir dörtgenin kare olup olmadığını bulan program

//bool result1, result2, result3, result4;
//int A, B, C, D;

//do
//{
//    Console.Write("A Kenarini Giriniz : ");
//    result1 = int.TryParse(Console.ReadLine(), out A);

//    Console.Write("B Kenarini Giriniz : ");
//    result2 = int.TryParse(Console.ReadLine(), out B);

//    Console.Write("C Kenarini Giriniz : ");
//    result3 = int.TryParse(Console.ReadLine(), out C);

//    Console.Write("D Kenarini Giriniz : ");
//    result4 = int.TryParse(Console.ReadLine(), out D);

//} while (!(result1 && result2 && result3 && result4));
//if (A == B && B == C && C == D)
//    Console.WriteLine("Girilen degere gore dortgeniniz karedir !");
//else
//    Console.WriteLine("Girilen degere gore dortgeniniz kare degildir !");
#endregion

#region Soru32 - Bir uçak 15 dk boyunca düzgün hızlanarak hızı 480 km/s oluyor. Sonra 20 dk sabit hızla gidiyor ve 15 dk boyunca düzgün yavaşlayarak hızı sıfır oluyor. Herhangi bir t anında hızı veren program

// Kullanıcıdan bir t zamanı (dakika olarak) alıyoruz
//Console.Write("Hangi t aninda hizi ogrenmek istiyorsunuz ? (dakika cinsinden 0 ile 50 arasinda) : ");
//double t = double.Parse(Console.ReadLine());

//double hiz = 0; // Başlangıçta hız 0 olarak tanımlanır

// Zaman 0-15 dakika arasında ise: Düzgün hızlanma
//if (t >= 0 && t <= 15)
//{
//    // Hız = 480 km/s * (t / 15) (çizgisel hızlanma)
//    hiz = 480 * (t / 15);
//}
// Zaman 15-35 dakika arasında ise: Sabit hız
//else if (t > 15 && t <= 35)
//{
//    // Hız sabit: 480 km/s
//    hiz = 480;
//}
// Zaman 35-50 dakika arasında ise: Düzgün yavaşlama
//else if (t > 35 && t <= 50)
//{
//    // Hız = 480 km/s * (1 - ((t - 35) / 15)) (çizgisel yavaşlama)
//    hiz = 480 * (1 - ((t - 35) / 15));
//}
//else
//{
//     Geçersiz t zamanı girildiğinde hata mesajı verilir
//    Console.Write("Lutfen 0 ile 50 dakika arasinda bir t degeri giriniz : ");
//    return;
//}
//Console.WriteLine($"t = {t} dakika iken ucagin hizi: {hiz} km/s");
#endregion
#region Soru33 - Girilen dört basamaklı sayılardan ilk iki basamağı ile son iki basamağının toplamının karesi, sayının kendine eşit olan sayılara orijinal sayı denir. Girilen sayının orijinal olup olmadığını bulan program

//Console.WriteLine("Lutfen 4 basamakli bir sayi giriniz : ");
//int sayi = Convert.ToInt32(Console.ReadLine());

//if (sayi < 1000 || sayi > 9999)
//    Console.WriteLine("Gecersiz sayi girisi, Lutfen tekrar deneyiniz !");

//int ilkIkıBasamak = sayi / 100; // iki virgul sola kaydırarak ilk iki basamak alınır.

//int sonIkıBasamak = sayi % 100; // modu alınarak 10 a bolumunden kalan yani son iki basamak almış oluruz.

//int karesi = (int)Math.Pow((ilkIkıBasamak + sonIkıBasamak), 2);

//if (karesi == sayi)
//    Console.WriteLine($"{karesi} = {sayi} esit oldugundan bu sayi ORIGINAL Sayidir :)");

//else
//    Console.WriteLine($"{karesi} != {sayi} esit olmadıgı icin bu sayi original sayi degildir :(");
#endregion
#region Soru34 - 1 ile 500 arasındaki tam sayılardan tek sayıların toplamı ile çift sayıların toplamının farkı negatif mi, pozitif mi olduğunu bulan program

//int tekToplam = 0;
//int ciftToplam = 0;

//for (int i = 1; i <= 500; i++)
//{
//    if (i % 2 == 0)
//        ciftToplam += i;

//    else
//        tekToplam += i;
//}

//int fark = ciftToplam - tekToplam;
//int fark = tekToplam - ciftToplam;

//if (fark > 0)
//    Console.WriteLine("Fark pozitiftir !");

//else if (fark == 0)
//    Console.WriteLine("Fark 0 a esittir !");

//else
//    Console.WriteLine("Fark negatiftir !");
#endregion
#region Soru35 - 4 haneli bir sayının birler, onlar, yüzler ve binler hanesini bulan program

//Console.Write("Dört basamaklı bir sayı girin: ");
//int sayi = int.Parse(Console.ReadLine());

//if (sayi < 1000 || sayi > 9999)
//    Console.WriteLine("Gecersiz sayi girisi, Lutfen tekrar deneyiniz !");

//int birlerBasamagi = sayi % 10;

//int onlarBasamagi = (sayi / 10) % 10;

//int yuzlerBasamagi = (sayi / 100) % 10;

//int binlerBasamagi = (sayi / 1000) % 10;

//Console.WriteLine($"Binler basamağı: {binlerBasamagi}");
//Console.WriteLine($"Yüzler basamağı: {yuzlerBasamagi}");
//Console.WriteLine($"Onlar basamağı : {onlarBasamagi}");
//Console.WriteLine($"Birler basamağı: {birlerBasamagi}");
#endregion

#region Soru36 - Rastgele girilen 50 sayıdan negatif olanların ve pozitif olanların sayısını bulan program

//int[] sayilar = new int[50];

//// Negatif ve pozitif sayıların sayısını tutmak için değişkenler
//int negatifSayilar = 0;
//int pozitifSayilar = 0;

//// Diziyi kullanıcı tarafından dolduruyoruz
//for (int i = 0; i < sayilar.Length; i++)
//{
//    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
//    sayilar[i] = Convert.ToInt32(Console.ReadLine());

//    if (sayilar[i] < 0)
//    {
//        negatifSayilar++;
//    }
//    else if (sayilar[i] > 0)
//    {
//        pozitifSayilar++;
//    }
//}

//Console.WriteLine($"Girilen negatif sayıların sayısı: {negatifSayilar}");
//Console.WriteLine($"Girilen pozitif sayıların sayısı: {pozitifSayilar}");
#endregion

#region Soru37- Sayı bulmaca oyunu programı

//Console.WriteLine("Sayi Tahmin Oyununa Hosgeldiniz......\n");

//int tahmin = 0;
//int hafiza;
//int sayac = 0;

//Random rastgele = new Random();
//hafiza = rastgele.Next(1, 101);

//while (tahmin != hafiza)
//{
//    sayac++;
//    Console.Write("Tahmin ettiginiz sayiyi giriniz : ");
//    tahmin = Convert.ToInt32(Console.ReadLine());

//    if (tahmin > hafiza)
//        Console.WriteLine("Daha kucuk sayi giriniz !\n");

//    else if (tahmin < hafiza)
//        Console.WriteLine("Daha buyuk sayi giriniz !\n");
//}
//Console.WriteLine("Tebrikleeerrrr, sayiyi dogru buldunuz :)\n");
//Console.WriteLine($"{sayac}. denemede buldunuz");
#endregion

#region Soru38 - Kural: 10 sefer hakkınız var Kullanıcının tahminine göre tahmini yükselt yada tahmini azalt diyerek yönlendirme yapacak. Bulduğu sefer sayısını ekrana basacak veya üzgünüz bir daha ki sefere diyecek.

//Random random = new Random();
//int gizliSayi = random.Next(1, 101);// 1 ile 100 arasında rastgele bir sayı seçilir

//int tahmin;
//int hak = 10;  // Kullanıcıya verilen tahmin hak sayısı

//Console.WriteLine("1 ile 100 arasında bir sayı tuttum. 10 tahmin hakkınız var, bakalım bulabilecek misiniz!");
//for (int i = 1; i < hak; i++)
//{
//    Console.Write("Tahmininizi girin: ");
//    bool result = int.TryParse(Console.ReadLine(), out tahmin);

//    if (!result)
//    {
//        Console.WriteLine("Lütfen geçerli bir sayı girin!");
//        i--;    // Geçersiz girişte hak kaybı yaşanmaz
//    }

//    if (tahmin < gizliSayi)
//    {
//        Console.WriteLine("Daha büyük bir sayı girin.");
//        Console.WriteLine($"Kalan tahmin hakkınız: {hak - i}"); // Kalan tahmin haklarını göster
//    }
//    else if (tahmin > gizliSayi)
//    {
//        Console.WriteLine("Daha küçük bir sayı girin.");
//        Console.WriteLine($"Kalan tahmin hakkınız: {hak - i}"); // Kalan tahmin haklarını göster
//    }
//    else
//    {
//        Console.WriteLine($"Tebrikler! Doğru sayıyı {i}. denemede buldunuz: {gizliSayi}");
//        Console.WriteLine($"Kalan tahmin hakkınız: {hak - i}"); // Kalan tahmin haklarını göster                                                       
//    }
//}
//Console.WriteLine($"Tahmin hakkınız bitti. Doğru sayı: {gizliSayi}");   // Tahmin hakları bittiğinde doğru sayıyı bildir
#endregion
#region Soru39 - 10 ile 200 arasındaki tam sayılardan 3 katının 2 fazlası 5 ile tam bölünebilen sayıları gösteren program

//int sonuc = 0;

//for (int i = 10; i <= 200; i++)
//{
//    sonuc = (3 * i) + 2;
//}

//if (sonuc % 5 == 0)
//    Console.WriteLine($"{sonuc} sayisi 5 e tam bolunmektedir :)");

//else
//    Console.WriteLine($"{sonuc} sayisi 5 e tam bolunmuyor :(");
#endregion

#region Soru40 - İç açıları verilen üçgenin karar ağacını bulan program

//int kenar1, kenar2, kenar3;
//bool result1, result2, result3;

//do
//{
//    Console.Write("Lutfen birinci kenari giriniz :");
//    result1 = int.TryParse(Console.ReadLine(), out kenar1);

//    Console.Write("Lutfen ikinci kenari giriniz :");
//    result2 = int.TryParse(Console.ReadLine(), out kenar2);

//    Console.Write("Lutfen ucuncu kenari giriniz :");
//    result3 = int.TryParse(Console.ReadLine(), out kenar3);

//} while (!(result1 && result2 && result3));

//while (kenar1 + kenar2 + kenar3 != 180) while ile yapılırsa nasıl olur ?
//{
//    if (kenar1 == 60 && kenar2 == 60 && kenar3 == 60)
//        Console.WriteLine("Eskenar Ucgen !");

//    else if (kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
//        Console.WriteLine("İkizkenar Üçgen!");


//    else if (kenar1 == 90 || kenar2 == 90 || kenar3 == 90)
//        Console.WriteLine("Dik Üçgen!");

//    else
//        Console.WriteLine("Çeşitkenar Üçgen!");
//}
//Console.WriteLine("Geçersiz üçgen, iç açıların toplamı 180 olmalı.");

//İç açıların toplamı 180 mi kontrolü
//if (kenar1 + kenar2 + kenar3 != 180)
//{
//    Console.WriteLine("Geçersiz üçgen, iç açıların toplamı 180 olmalı.");
//}
//else
//{
//    if (kenar1 == 60 && kenar2 == 60 && kenar3 == 60)
//        Console.WriteLine("Eşkenar Üçgen!");

//    else if (kenar1 == kenar2 || kenar1 == kenar3 || kenar2 == kenar3)
//        Console.WriteLine("İkizkenar Üçgen!");

//    else if (kenar1 == 90 || kenar2 == 90 || kenar3 == 90)
//        Console.WriteLine("Dik Üçgen!");

//    else
//        Console.WriteLine("Çeşitkenar Üçgen!");
//}
#endregion