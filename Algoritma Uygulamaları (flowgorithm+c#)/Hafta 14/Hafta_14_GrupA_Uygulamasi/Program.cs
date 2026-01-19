using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_14_GrupA_Uygulamasi
{
    internal class Program
    {

        /*Kullanıcıdan alınan 5 elemanlı bir tamsayı dizisinin Testere (Zigzag) Dizisi olup olmadığını kontrol eden bir C# programı yazınız.

Dizi elemanları sırasıyla:

Bir artan, bir azalan, veya bir azalan, bir artan şekilde ilerlemelidir.

Warning

Yan yana eşit iki eleman olması kuralı bozar.

Üst üste iki artış veya iki azalış olması kuralı bozar.

Dizinin ilk iki elemanı, dizinin başlangıç yönünü belirler. Örnek:

[1, 5, 2, 8, 3] -> (Arttı, azaldı, arttı, azaldı) -> 
DO
Ğ
RU

[1, 2, 3, 5, 2] -> (Üst üste arttı) -> 
YANLI
Ş*/
        static void Main(string[] args)
        {
            int girilenSayi; // kullanıcıdan alınacak sayıları tutar.
            int sayiAdedi =5; // dizideki sayı adedini belirler.
            int hata_payi = 0; // dizide hatalı ARTIŞ veya AZALIŞ var mı onu tespit eder.

            int[] testereDizi = new int[sayiAdedi];

            for (int i = 0; i < sayiAdedi; i++)
            {
                Console.Write(i + 1 + ". sayıyı gir: ");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                testereDizi[i] = girilenSayi;

            }

            // ---------- MANTIĞINI KODLARA BAKTIĞINDA ANLAMADIYSAN YORUM SATIRLARINI OKUMALISIN --------
            // ----------     OKUDUĞUNDA DA BEN ANLATAMADIYSAM GPT DAYI SANA YARDIMCI OLUR :D    --------
            

            // hata_payi değişkeni TESTERE DİZİSİ olup olmadığının tespitini nasıl yapıyor:
            /*
             TESTERE DİZİSİ  dediğin  ARTMALI ve AZALMALI, veya  AZALMALI ve ARTMALI örüntüsü ile gitmeli
             Biz de hata_payi değişkenini ilk başta 0 a atıyoruz.
            Her  bir ARTIŞTA değişkeni(hata_payi) +1 artırıyor, her bir AZALIŞTA -1 azaltıyoruz.
            5 elemanlı bir dizi olduğundan verileri kendi arasında ancak 4 defa karşılaştırabiliriz.
            4 defa karşılaştırdığımızda dizinin TESTERE DİZİSİ olabilmesi için hata_payi değişkeninin algoritma sonunda yine 0 olarak değerini koruması gerekiyor.
            Örnek = [1,0,2,0,1] dizisi olsun >> 1.indeks > 1 (hata_payi+1), 2.indeks > 0(hata_payi-1), 3.indeks > 2(hata_payi+1), 4.indeks > 1(hata_payi-1)
            böyle bir örüntü olduğunda haliyle hata_payi değişkeni ilk baştaki değerini koruyor. EĞER DEĞERİNİ KORUYORSA "TESTERE DİZİDİR." KORUMUYORSA "TESTERE DİZİ DEĞİLDİR."
            DİYEBİLİYORUZ.

            
             */
            for (int i = 0; i < (sayiAdedi - 1); i++)  // 1 2 1 2 1
            {
                if (testereDizi[i] == testereDizi[i + 1]) // BİRBİRİNE ARDIŞIK OLAN SAYILARI KARŞILAŞTIRIYORUZ.
                                                          // EŞİTSE DİREKT TESTERE DİZİ OLMAYACAĞINDAN DÖNGÜYÜ SONLANDIRIYORUZ.           
                {
                    hata_payi++; 
                    break;
                }
                else if (testereDizi[i] > testereDizi[i + 1])
                {
                    hata_payi++;


                }
                else
                    hata_payi--;


            }

            if (hata_payi == 0)
            {
                Console.WriteLine("Bu dizi TESTERE DİZİDİR.");
            }
            else
                Console.WriteLine("Bu dizi TESTERE DİZİ DEĞİLDİR.");
        }
    }
}
