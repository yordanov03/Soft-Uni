using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class Tuple<K, V>
    {
        private readonly K key;
        private readonly V value;

        public Tuple(K key, V value)
        {
            this.key = key;
            this.value = value;
        }

    public override string ToString()
    {
        return $"{this.key.ToString()} -> {this.value.ToString()}";
    }
}


