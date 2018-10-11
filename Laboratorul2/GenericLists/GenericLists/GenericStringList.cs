using System;
using System.Collections.Generic;

namespace GenericLists
{
    public class GenericStringList
    {
        private List<string> _cities;
        public GenericStringList()
        {
            _cities = new List<string> { "Iasi", "Cluj", "Oradea" };
        }


        public void AddCity(string city)
        {
            CheckCityForNull(city);
            _cities.Add(city);
        }

        public void RemoveCity(string city)
        {
            CheckCityForNull(city);
            _cities.Remove(city);
        }

        public int Capacity()
        {
            return _cities.Count;
        }

        private void CheckCityForNull(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                throw new ArgumentNullException();
            }
        }

    }
}
