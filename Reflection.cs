using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Reflection <T> where T : class
    {
        private readonly Type _type;
        private readonly IEnumerable<T> _data;

        public Reflection(IEnumerable<T> data)
        {
            _type = typeof(T); // fetch the type of the class being used
            _data = data;
        }

        public void PrintData()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(CreateHeader());
            foreach(var item in _data)
            {
                stringBuilder.Append(GetRow(item));
            }
            Console.WriteLine(stringBuilder.ToString());
        }

        private string GetRow(T item)
        {
            StringBuilder stringBuilder = new StringBuilder();
            var properties = _type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance); // provide the flags to get respective data, "Instance" is used to get instance level data non static properties in this case

            foreach (var property in properties)
            {
                stringBuilder.Append(property.GetValue(item)).Append(","); // to get the actual value of the property in instance we need to put GetValue(item)
            }
            stringBuilder.Append("\n");
            return stringBuilder.ToString();
        }

        private string CreateHeader()
        {
            StringBuilder stringBuilder = new StringBuilder();

            var properties = _type.GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);

            foreach (var property in properties)
            {
                stringBuilder.Append(property.Name).Append(",");
            }
            stringBuilder.Append("\n");
            return stringBuilder.ToString();
        }
    }
}
