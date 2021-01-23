using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] keyArray = keys;
            V[] valueArray = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];
            for (int i = 0; i < keyArray.Length; i++)
            {
                for (int j = 0; j < valueArray.Length; j++)
                {
                    keys[i] = keyArray[i];
                    values[j] = valueArray[j];
                }
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

            public int Count
        {
            get { return keys.Length; }
        }



    }

    }

