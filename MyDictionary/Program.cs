using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();
            countries.Add("TR", "Turkey");
            countries.Add("TS", "Turkey");
            countries.Add("TK", "Turkey");
            countries.Add("TA", "Turkey");
            Console.WriteLine(countries.Count);
            Mydictionary<string, string> countries2 = new Mydictionary<string, string>();
            countries2.Add("TR", "Türkiye");
            countries2.Add("Ta", "Türkiye");
            countries2.Add("Td", "Türkiye");
            countries2.Add("Ts", "Türkiye");
            countries2.Add("Tk", "Türkiye");
            Console.WriteLine(countries2.Count);




        }
    }
    class Mydictionary<T,S>
    {
        T[] _keys;
        T[] _tempkeys;
        S[] _values;
        S[] _tempvalues;

        public Mydictionary()
        {
            _keys = new T[0];
            _values = new S[0];
        }
        public void Add(T Keys, S Values)
        {
            _tempkeys = _keys;
            _tempvalues = _values;
            _keys = new T[_keys.Length + 1];
            _values = new S[_values.Length + 1];
            for (int i = 0; i < _tempkeys.Length; i++)
            {
                _keys[i] = _tempkeys[i];
                _values[i] = _tempvalues[i];
            }
            _keys[_keys.Length - 1] = Keys;
            _values[_values.Length - 1] = Values;
           
        }
        

        public int Count
        {
            get { return _keys.Length; }
            
        }
        public T[] Keys
        {
            get { return _keys; }

        }
        public S[] Values
        {
            get { return _values; }

        }

    }
}
