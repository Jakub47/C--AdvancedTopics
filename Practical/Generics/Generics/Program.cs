using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = new Result<int> { Succes = true, Data = 5,Data2 = 10 };
            var result2 = new Result<string> { Succes = false, Data = "John" };

            var helper = new ResultPrinter();

            helper.Print(result);
        }
    }



    public class Result<T>
    {
        public bool Succes { get; set; }
        public T Data { get; set; }
        public T Data2 { get; set; }
    }

    public class ResultPrinter
    {
        public void Print<T>(Result<T> result)
        {
            Console.WriteLine(result.Succes);
            Console.WriteLine(result.Data);
        }
    }

    //public class Result<T,U>
    //{
    //    public bool Succes { get; set; }
    //    public T Data { get; set; }
    //    public U Data2 { get; set; }
    //}

    //public class Result<T>
    //{
    //    public bool Succes { get; set; }
    //    public T Data { get; set; }
    //}

    //public class ResultInt
    //{
    //    public bool Succes { get; set; }
    //    public int Data { get; set; }
    //}

    //public class ResultString
    //{
    //    public bool Succes { get; set; }
    //    public string Data { get; set; }
    //}

    //public class ResultBool
    //{
    //    public bool Succes { get; set; }
    //    public bool Data { get; set; }
    //}
}
