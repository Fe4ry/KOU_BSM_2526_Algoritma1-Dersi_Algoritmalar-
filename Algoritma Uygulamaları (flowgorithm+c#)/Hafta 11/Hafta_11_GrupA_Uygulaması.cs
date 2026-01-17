using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta10_GrupA_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 elemanlı bir tamsayı dizisi oluşturup bu dizinin her elemanına -100 ile 100 arasında
            //rastgele üretilmiş sayılar atanmasını sağlayan bir C# programı yazınız.

          //  Program, tüm elemanlar oluşturulduktan sonra dizinin içindeki sayıların tamamını ekrana listelemeli
          //  ve dizide kaç adet negatif, kaç adet pozitif ve kaç adet nötr sayı bulunduğunu hesaplayıp sonuçları
          //  kullanıcıya göstermelidir..
          int[] tamsayiDizi = new int[10];


            int sayacPoz = 0,sayacNeg = 0, sayacNotr = 0;
            Random random = new Random(); // Bu sınıf(class) sayesinde rastgele sayılar oluşturabilmemizi sağlayan metotlara erişim sağlıyoruz.
            for (int i = 0; i < 10; i++)
            {

                tamsayiDizi[i] = random.Next(201) -100;/* Random sınıfının içinde olan Next() metodu sayesinde de aralık belirleyerek sayının    
                 oluşturulmasını sağlıyoruz.
                  1-100 arasında bir sayı belirleyeceğimizden sınırı 99 +1 ekliyoruz.
                  +1 eklememizin sebebi örnek olarak sayımız 0 geldiğinde
                   1 eklediğimizde sayı bize 1 olarak gelecek ve bu sayede 1 ile 100 arasında bir sayı seçmiş olacağız.*/

                if (tamsayiDizi[i] > 0) // Tek çift sorgusu işlemini yapıyoruz.
                    sayacPoz++;
                else if (tamsayiDizi[i] == 0)
                    sayacNotr++;
                else
                    sayacNeg++;
            }

                // Tüm sayıları konsola yazdırma işlemi:
                for (int i = 0;i<tamsayiDizi.Length;i++)
                Console.WriteLine($"{i+1}. sayı = {tamsayiDizi[i]}");

            // $ işareti sayesinde tırnakları açıp kapamadan değişkenleri
            //süslü parantez içinde yazarak değerini yazdırıyoruz.

            Console.WriteLine($"Pozitif Sayı: {sayacPoz}, Negatif Sayı: {sayacNeg}, Nötr Sayı: {sayacNotr}");

        }
    }
}
