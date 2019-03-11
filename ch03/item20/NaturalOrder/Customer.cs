using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalOrder
{
    public struct Customer : IComparable<Customer>, IComparable
    {
        private readonly string name;

        public Customer(string name)
        {
            this.name = name;
        }

        // IComparable<Customer>メンバ
        public int CompareTo(Customer other) => name.CompareTo(other.name);

        // IComparableメンバ
        //　2019.03.11：　注意：publicとすることはできない
        int IComparable.CompareTo(object obj)
        {
            if (!(obj is Customer))
                throw new ArgumentException("引数はCustomer型ではありません", "obj");
            Customer otherCustomer = (Customer)obj;
            return this.CompareTo(otherCustomer);
        }

        // 2019.03.11 add
        public override string ToString()
        {
            return "{Name=" + this.name + "}";
        }
    }
}
