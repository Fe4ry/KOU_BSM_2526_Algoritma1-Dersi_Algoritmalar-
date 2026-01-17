using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hafta10_GrupA_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int[] tamsayiDizi = new int[10];
            int enKucuk, enBuyuk;
            int enKucuk_indis=0, enBuyuk_indis=1;
            Console.WriteLine("");
            for (int i = 0; i < tamsayiDizi.Length; i++)
            {
                Console.WriteLine("-",100);

                Console.Write(i + 1 + ". sayıyı gir hocam:");
                int sayi = Convert.ToInt16(Console.ReadLine());
                
                tamsayiDizi[i] = sayi;
            }
            enKucuk = tamsayiDizi[0];
            enBuyuk = tamsayiDizi[1];

            for (int i = 0; i < tamsayiDizi.Length; i++)
            {
                Console.WriteLine($"{i+1}.sayı = {tamsayiDizi[i]}, indis:{i}");
                if (tamsayiDizi[i] > enBuyuk)
                {
                    enBuyuk = tamsayiDizi[i];
                    enBuyuk_indis = i;
                }

                else if (tamsayiDizi[i] < enKucuk)
                {
                    enKucuk = tamsayiDizi[i];
                    enKucuk_indis = i;
                }

            }
            Console.WriteLine("-");
            Console.WriteLine($"En küçük sayı ve indisi: {enKucuk}, {enKucuk_indis}\nEn büyük sayı ve indisi: {enBuyuk}, {enBuyuk_indis}");
        }
    }
}
