using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            try
            {
                int[] array = new int[3];
                array[2] = 10;
                int a = 10;
                int b = 2;
                int result = a / b;
                string str = "jhwusc";
                int l = str.Length + array.Length;
                throw new MyException("Мое исключение");
            }
            catch (MyException ex)
            { 
                Console.WriteLine("Поймали свое исключение:");
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Поймали исключение IndexOutOfRangeException:");
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Поймали исключение DivideByZeroException:");
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Поймали исключение NullReferenceException:");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Поймали другое исключение:");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        

        public class MyException : Exception
        {
            public MyException()
            { }

            public MyException(string message)
                : base(message)
            { }
        }
    }
}
