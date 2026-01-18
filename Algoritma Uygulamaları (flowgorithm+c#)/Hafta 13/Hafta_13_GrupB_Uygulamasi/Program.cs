using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_13_GrupB_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bir marketteki ürünlerin fiyatlarını tutan ve aşağıdaki işlemleri sırasıyla gerçekleştiren bir C# programı yazınız:

Çalışma Mantığı:

1. İçinde rastgele 5 adet ürün fiyatının (örneğin: 10, 50, 25, 100, 5) bulunduğu sayısal bir ArrayList oluşturunuz.

2. Kullanıcıdan bir fiyat değeri alınız.

3. IndexOf kullanarak listede girilen fiyatta bir ürün olup olmadığını kontrol ediniz.

Eğer girilen fiyat listede varsa:

4. Fiyat listesini küçükten büyüğe sıralayınız.

5. *BinarySearch kullanarak girilen fiyatın sıralı listedeki indeksini bulunuz ve ekrana yazdırınız.

6. Girilen fiyatın orijinal listedeki değerini 2 katı ile güncelleyiniz.

7. Güncellenmiş fiyat listesini ekrana yazdırınız.

Eğer girilen fiyat listede yoksa:

8. "Bu fiyatta bir ürün bulunamadı." mesajını yazdırınız.

Her adımdan sonra listeyi ekrana yazdırmanız gerekmektedir.*/

            ArrayList ürünFiyatları = new ArrayList();
            ürünFiyatları.Add(10);
            ürünFiyatları.Add(50);
            ürünFiyatları.Add(25);
            ürünFiyatları.Add(100);
            ürünFiyatları.Add(5);

            Console.WriteLine("Bana bir fiyat değeri gir haacom:");
            int kullaniciFiyat = Convert.ToInt16(Console.ReadLine());
            int varMi = ürünFiyatları.IndexOf(kullaniciFiyat); // Böyle bir fiyatta ürün var mı sorgusu.
            if (varMi > -1)
            {
                Console.WriteLine(kullaniciFiyat+" fiyatında bir ürün listede bulunuyor.");

                ürünFiyatları.Sort(); // küçükten büyüğe sıralar
                Console.WriteLine("Küçükten büyüğe:");
                listele(ürünFiyatları);

                int girilen_fiyatin_indeksi = ürünFiyatları.BinarySearch(kullaniciFiyat); // BinarySearch ile girilen değeri listede arar
                                                                                          // (hızlı bir şekilde, BinarySearch metodunun farkı hızlı olmasıdır.)
                                           

                int girilen_fiyat = ((int)ürünFiyatları[girilen_fiyatin_indeksi]); //ArrayList her şeyi object/tüm değişken tiplerini barındırır) değişken tipi olarak işlediğinden burada casting işlemi(değişken tipini belirtiyoruz) yapıyoruz.
                ürünFiyatları[girilen_fiyatin_indeksi] = girilen_fiyat*2; // Girilen veriyi 2 katı ile güncelliyoruz.

                Console.WriteLine("Güncel hali:");
                listele(ürünFiyatları); // konsola fiyatları listeledik.

            }
            else
                Console.WriteLine(kullaniciFiyat + "  fiyatında bir ürün listede bulunmuyor.");



        }
        public static void listele(ArrayList liste)
        {
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine(i+1+".ürünün fiyatı: " + liste[i]);
            }
        }
    }
}
