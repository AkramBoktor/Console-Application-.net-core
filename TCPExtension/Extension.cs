using System;
using System.Collections.Generic;
using System.Linq;

namespace TCPExtension
{
    public static class Extension
    {
        
        public static List<T> filter<T>(this List<T> records , Func<T,bool> func)
        {
            List<T> filterList = new List<T>();
            foreach (T record in records)
            {
                if (func(record))
                {
                    filterList.Add(record);
                }
            }

            return filterList; 
        }
    }
}
