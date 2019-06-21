using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true){
                 Console.WriteLine("Soz daxil edin");
                 Tap(Console.ReadLine());
                 Console.WriteLine("");
            }
           
        }

        public static void Tap(string soz)
        {
            //Daxil olunan soz uzunlugu qeder bos bir Array yaradilmasi
            //Sonradan bu Arraya daxil edilmis sozun ferqli herflerini daxil edeceyik
            string[] herfler = new string[soz.Length];
            int count = 0;
            for(int i=0;i<soz.Length;i++)
            {
                bool Yoxlama=true;
                for(int x = 0; x < herfler.Length; x++)
                {
                    //Daxil edilmis sozun i-ci herfinin herfler arrayinda olub olmamasinin yoxlanilmasi
                    //eger tapsa Yoxlama neticesi false olacaq ve herfler arrayine hemin i -ci herfi elave etmeyecek
                   if(soz[i].ToString()==herfler[x]){
                        Yoxlama=false;
                        break;
                    }
                }
                if(Yoxlama){
                    herfler[count]=soz[i].ToString();
                    count++;
                 }
            }

            foreach (var herf in herfler)
            {
                 int herfSayi=0;
                 for(int i=0;i<soz.Length;i++){
                    if(herf==soz[i].ToString()){ herfSayi++;}
                 }
                 //Herfler arrayindeki NULL deyerleri ekrana cixarmamaq ucun:
                 if(herf!=null){
                    Console.WriteLine($"{herfSayi} -eded '{herf}' -herfi ");
                 }
                 
            }
        }
    }
}
