using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, var>
    {
        T[] keys;
        var[] items;
        public MyDictionary()
        {
            keys = new T[0];
            items = new var[0];
        }

        public void Add(T key, var item)
        {
            T[] tempKeys = keys;
            var[] tempItems = items;

            keys = new T[keys.Length + 1];
            items = new var[items.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                items[i] = tempItems[i];
            }
        }
    }
}
