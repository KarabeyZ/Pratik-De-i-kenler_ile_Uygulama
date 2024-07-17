// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz: ");

// Tc kimlik numarısı bir sayı olsa da herhangi bir matematiksel işlemde kullanılmayacağı için string veri tipinde bırakmayı tercih ettim.
Console.WriteLine("T.C. Kimlik Numaranizi Giriniz: ");
string TcKimlik = Console.ReadLine();

// İsim soyisim string veri tipinde alınıyor.
Console.WriteLine("Adınızı Giriniz: ");
string ad = Console.ReadLine();

Console.WriteLine("Soyadınızı Giriniz: ");
string soyAd = Console.ReadLine();


//Telefon numaralarının başında + gibi işaretler olabileceği ve int veri tipinin sayıların başındaki 0'ları silmesindenden dolayı telefon numarsını string olarak saklamak istedim.
Console.WriteLine("Telefon Numaranızı Giriniz: ");
string telNo = Console.ReadLine();


// Yaş sayısal bir değer olduğu için int değer tipine çevirdim.
Console.WriteLine("Yaşınızı Giriniz: ");
string yas = Console.ReadLine();
int yasInt = Convert.ToInt32(yas);


// Matematiksel bir işlem yapacağımız için veriyi int veri tipine dönüştürdüm.
Console.WriteLine("İlk aldığınız ürünün fiyatını giriniz: ");
string ilkUrun = Console.ReadLine();
int ilkUrunInt = Convert.ToInt32(ilkUrun);

Console.WriteLine("İkinci aldığınız ürünün fiyatını giriniz: ");
string ikinciUrun = Console.ReadLine();
int ikinciUrunInt = Convert.ToInt32(ikinciUrun);

//iki ürünün toplam fiyatını buluyoruz.
int toplamHarcama = ilkUrunInt + ikinciUrunInt;
//indirim miktarını buluyoruz.
int indirim = toplamHarcama / 10;

Console.WriteLine($"T.C. Kimlik Numarasi: {TcKimlik}");
Console.WriteLine("Adi: "+ad);
Console.WriteLine("Soyadi: "+soyAd);
Console.WriteLine("Telefon Numarasi: "+telNo);
Console.WriteLine("Yas: "+yas);
Console.WriteLine($"Ilk Aldigi Ürünün Fiyati: {ilkUrunInt}");
Console.WriteLine($"Ikinci Aldigi Ürünün Fiyati: {ikinciUrunInt}");
Console.WriteLine("-----------------------------");
Console.WriteLine($"{TcKimlik} Tc numarali {ad} {soyAd} isimli kisi için kayit olusturulmustur.");
Console.WriteLine($"{telNo} telefon numarasina bildirim mesaji gönderilmiştir.");
Console.WriteLine($"{toplamHarcama} toplam harcama karsiligi kazanilan 10% patika puan miktari -> {indirim} TL'dir.");









