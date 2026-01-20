using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_14_GrupC_Uygulamasi
{
    internal class Program
    {
        /*
         Oluşturulan dizide, yan yana aynı değerin en fazla kaç kez tekrar ettiğini bulan bir C# programı yazınız.

Program, 10 elemanlı bir tamsayı dizisini otomatik olarak oluşturacaktır.

Dizinin her elemanı 1 ile 5 arasında rastgele (Random) bir değer alacaktır.

Çalışma Mantığı:

Random sınıfını kullanarak:

10 elemanlı bir tamsayı dizisini 1–5 aralığında değerlerle doldurunuz.
Oluşturulan diziyi ekrana yazdırınız.
Dizideki;

En uzun tekrar sayısını,
Bu tekrarın hangi sayıya ait olduğunu,
Ve başlangıç indeksini ekrana yazdırınız.
         */

        // ALGORİTMANIN İŞLEYİŞİNİ ANLAYABİLMEK İÇİN YORUM SATIRLARINI OKUMALISIN DOST. ANLATAMADIYSAM KODU YAPAY ZEKAYA ATIP SANA ANLATMASINI İSTEMEN EFSO OLUR...
        static void Main(string[] args)
        {
            Random random = new Random();

            int sayi; // rastgele sayıları bu değişkende tutucaz.
            int sayiAdedi = 10; // sayi adedi
            int encok_tekrarEdenSayi=0; // en cok
            int tekrarEdenAdet = 1;
            int encok_tekrarEdenIndeks = 0;
            int tekrarEdenIndeks_gecici=0; // her ardışık sayı buldugumuzda indeksini burada tutucaz ve encok_tekrarEdenIndeks değişkenine aktarıcaz.
            int tekrarEdenAdet_buyuk = 0; // en cok tekrar eden ardışık sayının kaç defa tekrar ettiğini tutucaz.
            int[] sayilar = new int[sayiAdedi];

            for (int i = 0; i < sayiAdedi; i++)
            {
                sayi = random.Next(5) + 1; // 1-5 arası rastgele sayı ürettik ve diziye ekledik.
                sayilar[i]=(sayi);
            }
            listele(sayilar); // Yazdığımız listele() metodunu kullanarak diziyi yazdırdık.

            for (int i = 0; i < sayiAdedi - 1; i++)
            {

                while(sayilar[i] == sayilar[i + 1])  // yan yana aynı sayı var mı kontrolü yaptık.
                {
                    if (tekrarEdenAdet == 1) // varsa ilk indeksine ulaşabilmek için bu sorguyla indeksini tuttuk
                        tekrarEdenIndeks_gecici = i;

                    tekrarEdenAdet++; // adet sayısını hesaplıyoruz.
                    i++;

                    if (i == 9) // eğer i = 9 ken  while döngüsüne tekrardan başa dönüp koşulu kontrol ettiğind sayilar[i+1] 10. indekste veri arıcak.
                                // dizimizin 10. indeksi olmadığı için sonulandırmazsak algoritma hata verecek. bu yüzden sonlandırıyoruz.
                        break;
                }
                if (tekrarEdenAdet_buyuk < tekrarEdenAdet) // Daha önce tekrar eden sayıdan daha fazla tekrarlayan bir sayı varsa bu if bloğuna girecek
                                                           // yoksa önceden bulduğumuz sayı hala en çok tekrar eden olarak kalacak.
                {
                    tekrarEdenAdet_buyuk = tekrarEdenAdet; //fazla olan tekrar sayısını tekrarEdenAdet_enbuyuk değişkeninde saklıyoruz.

                    encok_tekrarEdenSayi = (int)sayilar[tekrarEdenIndeks_gecici]; // en cok tekrar eden sayıyı da encok_tekrarEdenSayi değişkeniyle saklıyoruz.
                    encok_tekrarEdenIndeks = tekrarEdenIndeks_gecici; // en cok tekrar eden sayının hangi indekste ilk defa görüldüğünü encok_tekrarEdenIndeks değişkeniyle saklıyoruz.
                }
                tekrarEdenAdet = 1; // her bir ardışık eşit sayının adet sayısını doğru hesaplayabilmek için her sayıda adet sayısını 1 e eşitliyoruz.



            }

            Console.WriteLine("----------------------------------\nTekrar eden ilk en uzun sayı:" + encok_tekrarEdenSayi + "\nBaşlangıç indeksi:"+ encok_tekrarEdenIndeks + "\n"+"Tekrar sayısı:"+tekrarEdenAdet_buyuk);
        }
    
    public static void listele(int[] list)
        {
            for (int i = 0; i < list.Length; i++) {
                Console.WriteLine(i + 1 + ". sayı: " + list[i]);
            }
        }
    }
}
