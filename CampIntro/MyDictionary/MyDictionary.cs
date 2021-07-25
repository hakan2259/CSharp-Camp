using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key,Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];

        }
        public void Add(Key key, Value value)
        {
            Key[] tempKeys = keys;
            Value[] tempValues = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }
            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;


        }

        public int Count
        {
            get { return keys.Length;  }
        }
        public Key[] key
        {
            get { return keys; }
        }
        public Value[] value
        {
            get { return values; }
        }
    }
}
