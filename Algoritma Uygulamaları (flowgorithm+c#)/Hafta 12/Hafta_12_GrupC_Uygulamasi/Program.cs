using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_12_GrupC_Uygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
Bir online market uygulaması için ürün sepeti yönettiğinizi varsayarak aşağıdaki işlemleri gerçekleştiren bir C# programı yazınız:

1. sepet isminde bir ArrayList oluşturunuz ve listeye “Süt”, “Un”, “Yağ”, “Şeker”, “Tuz” ürünlerini ekleyiniz.

2. Listeyi alfabetik (Sort) olarak sıralayınız.

3. Sıralanan listeden “Tuz” ürününü Remove metodu ile siliniz.

4. Listenin 1. indeksine “Makarna” ürününü Insert metodu ile ekleyiniz.

5. Sepetin Capacity değerini ekrana yazdırıniz.

6. Listenin içinde “Şeker” ürününün bulunup bulunmadığını Contains ile kontrol ederek uygun bir mesaj yazdırınız.

7. Son olarak listeyi Reverse metodu ile ters çevirin ve oluşan son hâli ekrana yazdırınız.

Her adımdan sonra listeyi ekrana yazdırmanız gerekmektedir.
             */

            ArrayList sepet = new ArrayList();
            sepet.Add("Süt");
            sepet.Add("Un");
            sepet.Add("Yağ");
            sepet.Add("Şeker");
            sepet.Add("Tuz");

            sepet.Sort(); //Alfabetik sıralama
            Console.WriteLine("Listenin alfabetik sıralamaya göre sıralanmış hali:");
            listele(sepet);
            sepet.Insert(1,"Makarna"); // Makarna değerini 1.indekse ekledik.
            Console.WriteLine("Makarna değerinin eklenmiş listenin hali:");
            listele(sepet);
            int kapasite = sepet.Capacity; // Dizinin ne kadar veri alabileceğini gösterir.
            Console.WriteLine("> Listenin kapasitesi: "+kapasite);

            bool kontrol = sepet.Contains("Şeker");
            if(kontrol)
                Console.WriteLine("+ Sepetin içinde Şeker var.");
            else
                Console.WriteLine("- Sepetin içinde Şeker yok.");
            sepet.Reverse(); // dizideki verilerin sıralamasını ters çevirir.
            Console.WriteLine("Listenin ters çevirilmiş hali:");
            listele(sepet); // son olarak listeledik




        }
        public static void listele(ArrayList sepet)
        {
            for (int i = 0; i < sepet.Count; i++)
                Console.WriteLine(i+1+". değer = " + sepet[i]);
            
        }

    }
}
