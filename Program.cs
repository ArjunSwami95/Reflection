using ConsoleApp1.DataSource;
using ConsoleApp1.Model;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Reflection<Book> reflection = new Reflection<Book>(BooksProvider.GetBooks());

            reflection.PrintData();

            Reflection<Weather> reflection2 = new Reflection<Weather>(WeatherProvider.GetWeather());

            reflection2.PrintData();
        }
    }
}
