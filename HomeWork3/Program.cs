using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                Console.WriteLine("Сколько чисел сгенерировать числотрону?");
                try
                {
                    count = Convert.ToInt32(Console.ReadLine());
                    if (count < 1) throw new Exception("Число должно быть больше 0");      
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (count < 1);

            Numbertron numbertron = new Numbertron();
            Jay jay = new Jay();
            SilentBob silentBob = new SilentBob();
            Random rnd = new Random();

            numbertron.NewNumber += new Numbertron.NewNumberDelegate(jay.FetchNewNumber);
            numbertron.NewNumber += new Numbertron.NewNumberDelegate(silentBob.FetchNewNumber);

            for (int i = 0; i < count; i++)
            {                
                numbertron.Generate(rnd);
            }
            
            if (jay.Score > silentBob.Score) Console.WriteLine("Победил Джей!");
            if (silentBob.Score > jay.Score) Console.WriteLine("Победил Молчаливый Боб!");
            if (jay.Score == silentBob.Score) Console.WriteLine("Ничья!");

            Console.Read();                
        }
        
    }
}
