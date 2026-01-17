using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_12_GrupB_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
1. sehirler isminde bir ArrayList oluşturun ve listeye “Kocaeli”, “Van”, “Antalya”, “Rize”, “Bursa” şehirlerini ekleyiniz.

2. Listeyi alfabetik (Sort) olarak sıralayınız.

3. Sıralanan listenin en başına “Ankara” şehrini Insert metodu ile ekleyiniz.

4. Güncellenmiş sıralama yapısında 3. indeksindeki şehri RemoveAt ile listeden siliniz.

5. Listenin içinde “Van” şehrinin bulunup bulunmadığını Contains ile kontrol ederek uygun bir mesaj ekrana yazdırınız.

6. Son olarak listenin eleman sayısını (Count) ekrana yazdırınız ve listedeki tüm şehirleri ekrana yazdırınız.

Her adımdan sonra listeyi ekrana yazdırmanız gerekmektedir.*/

            ArrayList sehirler = new ArrayList();
            sehirler.Add("Kocaeli"); // diziye veri ekler.
            sehirler.Add("Van");
            sehirler.Add("Antalya");
            sehirler.Add("Rize");
            sehirler.Add("Bursa");

            diziDondur(sehirler); // sadece for döngüsünü yazmak yerine bu metodu yazdım. Eğer diziyi nasıl yazdırdığımı öğrenmek istersen aşağıdaki metoda bakabilirsin.
            // metodu kullanmak istemiyorsan içindeki for döngüsünü metodu kullandığım yerlere yapıştırabilirsin.

            sehirler.Sort(); // Listeyi  alfabetik sıralar.
            Console.WriteLine("Küçükten büyüğe (Alfabetik sıralama):");
            diziDondur(sehirler);
            sehirler.Insert(0, "Ankara"); // Listenin en başına Ankara değerini ekler.
            Console.WriteLine("Ankara şehrinin eklenmiş haliyle:");
            diziDondur(sehirler);
            sehirler.RemoveAt(3); // 3.indeksteki değeri siler.
            Console.WriteLine("3. indeksteki şehirin silinmiş haliyle:");

            diziDondur(sehirler);

            bool kontrol = sehirler.Contains("Van"); // dizide Van değerinin olup olmadığını sorgular varsa true yoksa false döndürür.
            // hiçbir operatör yazmazsanız girilen verinin içinde (kontrol == true) olarak algılar ve ona göre sorgu işlemi yapar.
            // if bloğunun altına tek satırlık kod yazacaksanız süslü parantez ile blok olarak içine almaya gerek kalmaz.
            if (kontrol)
                Console.WriteLine("+ Van şehri dizide var.");
            else
                Console.WriteLine("- Van şehri dizide yok.");





        }

        public static void diziDondur(ArrayList liste) //  bu metot sayesinde dizinin içindeki her veriyi yazdırmak yerine sadece bu metodu kullanarak değerleri yazdırabilicez.
        { // isterseniz metot oluşturup yazın isterseniz pratik amaçlı for döngüsü yazın, onun dışında amele olursunuz. :D
            for (int i = 0; i < liste.Count; i++)
            {
                Console.WriteLine($"{i + 1}.değer = {liste[i]}");
            }
        }
    }
    }

