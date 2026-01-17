using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_11_GrupA_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*20 elemanlı bir tamsayı dizisi oluşturup bu dizinin her elemanına 1 ile 100 arasında rastgele üretilmiş sayılar atanmasını sağlayan bir C# programı yazınız.

            Program, tüm elemanlar oluşturulduktan sonra dizinin içindeki sayıların tamamını ekrana listelemeli
            ve dizide kaç adet çift,
            kaç adet tek sayı bulunduğunu hesaplayıp sonuçları kullanıcıya göstermelidir.*/
            int[] tamsayiDizi = new int[20];


            int sayacTek = 0, sayacCift = 0;
            Random random = new Random(); // Bu sınıf(class) sayesinde rastgele sayılar oluşturabilmemizi sağlayan metotlara erişim sağlıyoruz.
            for (int i = 0; i < tamsayiDizi.Length; i++)
            {

                tamsayiDizi[i] = random.Next(100) +1;/* Random sınıfının içinde olan Next() metodu sayesinde de aralık belirleyerek sayının    
                 oluşturulmasını sağlıyoruz.
                  1-100 arasında bir sayı belirleyeceğimizden sınırı 99 +1 ekliyoruz.
                  +1 eklememizin sebebi örnek olarak sayımız 0 geldiğinde
                   1 eklediğimizde sayı bize 1 olarak gelecek ve bu sayede 1 ile 100 arasında bir sayı seçmiş olacağız.*/
                Console.WriteLine(i+1+". sayı: "+tamsayiDizi[i]);
                if (tamsayiDizi[i]%2== 0) // Tek çift sorgusu işlemini yapıyoruz.
                    sayacCift++;
                else
                    sayacTek++;
            }
            Console.WriteLine("Çift sayı adedi: " + sayacCift + "\nTek sayı adedi: " + sayacTek);

        }
    }
}
