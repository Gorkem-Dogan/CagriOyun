using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriOyun
{
    public class SoruManager : ISoruService
    {
        public void soru() 
        {
            Console.WriteLine("Hangi Pokemon çok fazla yemek yemesiyle, hareket etmemesi ve Tembelliği ile bilinir ? ");
            Console.WriteLine("A.) Eevee");
            Console.WriteLine("B.) Pikachu");
            Console.WriteLine("C.) Bulbasaur");
            Console.WriteLine("D.) Snorlax");
            string Cevap1 = Console.ReadLine();
            if (Cevap1 == "D" || Cevap1 == "d")
            {
                Console.WriteLine("Doğru Cevap 500 tl kazandınız");
                Console.WriteLine("Osmanlı İmparatorluğu Döneminde Girit kaç yılında ve kaç yıl içerisinde fethedilmiştir ? ");
                Console.WriteLine("A.) 1624 yılında, 12 yılda");
                Console.WriteLine("B.) 1669 yılında, 24 yılda");
                Console.WriteLine("C.) 1650 yılında, 14 yılda");
                Console.WriteLine("D.) 1670 yılında, 40 yılda");
                string Cevap2 = Console.ReadLine();
                if (Cevap2 == "B" || Cevap2 == "b")
                {
                    Console.WriteLine("Doğru Cevap 1000 tl kazandınız");
                    Console.WriteLine("Efsanevi Formula 1 yarışçısı Ayrton Senna hangi yılda, hangi pistte ve hangi takımdayken hayatını kaybetmiştir ?");
                    Console.WriteLine("A.) 1992 yılında, Dallas Grand Prixi ve McLaren takımında ");
                    Console.WriteLine("B.) 1994 yılında, Belgium Grand Prixi ve Lotus takımında ");
                    Console.WriteLine("C.) 1994 yılında, San Marino Grand Prixi ve Williams takımında ");
                    Console.WriteLine("D.) 1992 yılında, Silverstone Grand Prixi ve Williams takımında ");
                    string Cevap3 = Console.ReadLine();
                    if (Cevap3 == "C" || Cevap3 == "c")
                    {
                        Console.WriteLine("Doğru Cevap 2500 tl kazandınız");
                        Console.WriteLine("Kralın yetkilerini tarihte ilk kez kısıtlayan Magna Carta Yasaları hangi yıl yayınlanmıştır ?");
                        Console.WriteLine("A.) 1216 ");
                        Console.WriteLine("B.) 1215 ");
                        Console.WriteLine("C.) 1251 ");
                        Console.WriteLine("D.) 1254 ");

                        string Cevap4 = Console.ReadLine();
                        if (Cevap4 == "B" || Cevap4 == "b")
                        {
                            Console.WriteLine("Doğru Cevap 5000 tl kazandınız");
                            Console.WriteLine("C dilini icat eden ve Unixin ortaklarından olan isim aşağıdakilerden hangisidir ? ");
                            Console.WriteLine("A.) Dennis Ritchie");
                            Console.WriteLine("B.) Linus Torvalds");
                            Console.WriteLine("C.) Bjarne Stroustrup");
                            Console.WriteLine("D.) Rob Pike");
                            string Cevap5 = Console.ReadLine();
                            if (Cevap5 == "A" || Cevap5 == "a")
                            {
                                Console.WriteLine("Doğru Cevap 10000 tl kazandınız");
                                Console.WriteLine("Yarışmamız sona ermiştir katılımınız için teşekkür ederiz");
                            }
                            else
                            {
                                Console.WriteLine("Maalesef doğru bilemediniz ve elendiniz");
                                Console.WriteLine("Yarışmamız sona ermiştir katılımınız için teşekkür ederiz");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Maalesef doğru bilemediniz ve elendiniz, 2500 TL kazandınız");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Maalesef doğru bilemediniz ve elendiniz, 1000 TL kazandınız");
                    }
                }
                else
                {
                    Console.WriteLine("Maalesef doğru bilemediniz ve elendiniz, 500 TL kazandınız");
                }
            }
            else
            {
                Console.WriteLine("Maalesef doğru bilemediniz ve elendiniz");
            }

        }
    }
}
