using System;

namespace OdevConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Otobüste boş yer var mıdır ?");
            string var = "bos";
            string yok = "dolu";
            string tek = "tek";
            string cift = "cift";
            string nakit = "nakit";
            string kart = "kart";
            if (Console.ReadLine() == var)
            {
                Console.WriteLine("Kaç kişi gidecek ?");
                string kisi = Console.ReadLine();
                int.TryParse(kisi, out int no);
                if (no == 1)
                {
                    Console.WriteLine("Tekli koltuk mu çiftli koltuk mu ?");
                   
                    if (Console.ReadLine() == tek)
                    {
                        Console.WriteLine("Ödeme şekli nasıl?");
                        string odeme = Console.ReadLine();
                        
                        if (odeme == nakit)
                        {
                            Console.WriteLine("nakit Ödeme işlemi başarılı");
                        }
                        else if(odeme == kart)
                        {
                            Console.WriteLine("kart ödeme işlemi basarili");
                        }
                        else
                        {
                            Console.WriteLine(" ödeme işlemi basarisiz");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ödeme şekli nasıl?");
                        if (Console.ReadLine() == nakit)
                        {
                            Console.WriteLine("Ödeme işlemi başarılı");
                        }
                        else
                        {
                            Console.WriteLine("ödeme işlemi basarisiz");
                        }
                    }
                }
                else if(no>=2)
                {
                    Console.WriteLine("Tekli koltuk mu çiftli koltuk mu ?");
             
                    if (Console.ReadLine() == tek)
                    {
                        Console.WriteLine("Ödeme şekli nasıl?");

                        if (Console.ReadLine() == nakit)
                        {
                            Console.WriteLine("Ödeme işlemi başarılı");
                        }
                        else
                        {
                            Console.WriteLine("ödeme işlemi basarisiz");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ödeme şekli nasıl?");
                        if (Console.ReadLine() == nakit)
                        {
                            Console.WriteLine("Ödeme işlemi başarılı");
                        }
                        else
                        {
                            Console.WriteLine("ödeme işlemi basarisiz");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("hatali kisi sayisi");
                }

            }
            else
            {
                Console.WriteLine("Otobüste boş yer bulunmamaktadır başka seferlere bakabilirsiniz");
            }
            
        }
    }
}
