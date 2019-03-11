using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonDelegate
{
    public struct Customer : IComparable<Customer>, IComparable
    {
        private readonly string name;
        private double revenue;

        public Customer(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
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
            return "{name=" + this.name + ", revenue=" + this.revenue + "}";
        }

        // Relation Operators.
        public static bool operator <(Customer left, Customer right) =>
            left.CompareTo(right) < 0;
        public static bool operator <=(Customer left, Customer right) =>
            left.CompareTo(right) <= 0;
        public static bool operator >=(Customer left, Customer right) =>
            left.CompareTo(right) >= 0;
        public static bool operator >(Customer left, Customer right) =>
            left.CompareTo(right) > 0;

        public static Comparison<Customer> CompareByRevenue =>
            (left, right) => left.revenue.CompareTo(right.revenue);
    }
}
