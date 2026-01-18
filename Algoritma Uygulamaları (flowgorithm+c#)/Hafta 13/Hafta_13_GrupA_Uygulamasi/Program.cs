using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_13_GrupA_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Bir kütüphanedeki kitapların listesini tutarak aşağıdaki işlemleri sırasıyla gerçekleştiren bir C# programı yazınız:

Çalışma Mantığı:

1. İçinde "Nutuk", "Sefiller", "Suç ve Ceza", "Simyacı" kitaplarının olduğu bir ArrayList oluşturunuz.

2. Kullanıcıdan kiralamak istediği kitabın ismini alınız.

3. IndexOf kullanarak kitabın listede olup olmadığını kontrol ediniz.

Eğer kitap listede varsa:

4. Kitap listesini alfabetik olarak sıralayınız.

5. BinarySearch kullanarak kitabın sıralı listedeki konumunu bulunuz ve ekrana yazdırınız.

6. "Kitap bulundu, kiralandı." mesajını yazdırınız.

7. Kitabı listeden siliniz.

Eğer kitap listede yoksa:

8. "Kitap kütüphanemizde bulunmamaktadır." mesajını yazdırınız.

Her adımdan sonra listeyi ekrana yazdırmanız gerekmektedir.*/
            ArrayList kitaplik = new ArrayList();
            kitaplik.Add("Nutuk");
            kitaplik.Add("Sefiller");
            kitaplik.Add("Suç ve Ceza");
            kitaplik.Add("Simyacı");

            Console.WriteLine("Kiralamak istediğin kitabın adını gir:"); // Kitap adı girerken listedeki değerleri girerek deneyin.
                                                                         // Buradaki mevzu metotları kullanabilme pratiği olduğu için öğrendiğiniz yapılar üzerinden algoritma tasarlanmaya çalışılıyor.
                                                                         // Büyük küçük harfe dikkat ederek veri girmelisiniz yoksa algoritma çalışmayabilir...
                                                                         // İleride yeni yapılar öğrendiğinizde algoritmaları daha da geliştirerek kodlayabilirsiniz.
            String kitapAdi = Convert.ToString(Console.ReadLine());

            int varMi = kitaplik.IndexOf(kitapAdi); // IndexOf() metodu parametreye(parantezin içine girilmesi istenilen veri [IndexOf("Suç ve Ceza) gibi.] ) girdiğimiz değeri dizide arar ve bulduğunda indeksini döndürür.

            String bulunanKitap = ((string)kitaplik[varMi]); // Bulunan kitabı string bir değişkene atıyoruz ki daha anlaşılır bir kod yazalım.

            if (varMi>-1)
            {
                kitaplik.Sort(); // Kitapları alfabetik sıraladık.
                Console.WriteLine("Alfabetik sıralama:");
                listele(kitaplik); // Kitapları, oluşturduğumuz metotla konsola yazdırdım(listeledim)

                int bulunan_kitabin_indeksi = kitaplik.BinarySearch(kitapAdi); // BinarySearch() metoduyla dizide kiralamak istediğimi kitabın indeksini aldım.
                Console.WriteLine("Aranılan kitabın dizideki sırası: " + bulunan_kitabin_indeksi);
                Console.WriteLine(kitapAdi + " kitabı raflarda bulundu ve kiralandı.");

                kitaplik.Remove(kitapAdi); // Kiralanan kitabı raflardan sildim.


            }
            else
                Console.WriteLine(kitapAdi + "böyle bir kitap raflarda bulunmuyor.");
            



        }
        public static void listele(ArrayList liste)
        {
            for (int i = 0; i < liste.Count; i++)
                Console.WriteLine(i + 1 + ". kitap: " + liste[i]);
        }
    }
}
