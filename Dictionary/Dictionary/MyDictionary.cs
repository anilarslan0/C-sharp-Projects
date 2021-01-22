using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<Key, Value>
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
            Key[] _tempKeys = keys;
            Value[] _tempValues = values;


            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                keys[i] = _tempKeys[i];
                values[i] = _tempValues[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }


        public Key[] Keys
        {
            get {return keys;}
        }

        public Value[] Values
        {
            get { return values; }
        }



    }
}
