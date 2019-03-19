using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadRelationOperators
{
    public class Name :
        IComparable<Name>,
        IEquatable<Name>,
        IComparable
    {
        public string First { get; set; }
        public string Last { get; set; }
        public string Middle { get; set; }

        // IComparable<Name>メンバ
        public int CompareTo(Name other)
        {
            if (Object.ReferenceEquals(this, other))
                return 0;
            if (Object.ReferenceEquals(other, null))
                return 1; // 非nullはnullより大
            int rVal = Comparer<string>.Default.Compare(Last, other.Last);
            if (rVal != 0)
                return rVal;
            rVal = Comparer<string>.Default.Compare(First, other.First);
            if (rVal != 0)
                return rVal;
            return Comparer<string>.Default.Compare(Middle, other.Middle);
        }

        // IEquatable<Name>メンバ
        public bool Equals(Name other)
        {
            if (Object.ReferenceEquals(this, other))
                return true;
            if (Object.ReferenceEquals(other, null))
                return false;
            // 意味的にはEqualityComparer<string>.Defaultと同じ
            return Last == other.Last &&
                First == other.First &&
                Middle == other.Middle;
        }

        public override bool Equals(object obj)
        {
            // 2019.03.17 add: check obj == null
            if (obj == null)
                return false;

            if (obj.GetType() == typeof(Name))
                return this.Equals(obj as Name);
            else return false;
        }

        public override int GetHashCode()
        {
            int hashCode = 0;
            if (Last != null)
                hashCode ^= Last.GetHashCode();
            if (First != null)
                hashCode ^= First.GetHashCode();
            if (Middle != null)
                hashCode ^= Middle.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Name left, Name right)
        {
            /* 2019.03.17 change: stack overflow
            if (left == null)
                return right == null;
            */
            if (Object.ReferenceEquals(left, null))
                return Object.ReferenceEquals(right, null);
            return left.Equals(right);
        }

        public static bool operator !=(Name left, Name right)
        {
            /* 2019.03.17 change
            if (left == null)
                return right != null;
            */
            if (Object.ReferenceEquals(left, null))
                return !Object.ReferenceEquals(right, null);
            return !left.Equals(right);
        }

        public int CompareTo(object obj)
        {
            // IComparableメンバ
            // 2019.03.18: change: check obj not null and is Name
            //if (obj.GetType() != typeof(Name))
            if (!(obj is Name))
                throw new ArgumentException(
                    "引数はNameオブジェクトではありません");
            return this.CompareTo(obj as Name);
        }

        public static bool operator <(Name left, Name right)
        {
            /* 2019.03.19: change
            if (left == null)
                return right != null;
            */
            if (Object.ReferenceEquals(left, null))
                return !Object.ReferenceEquals(right, null);
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(Name left, Name right)
        {
            /* 2019.02.19: change
            if (left == null)
                return false;
            */
            if (Object.ReferenceEquals(left, null))
                return false;
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(Name left, Name right)
        {
            /* 2019.03.19 change
            if (left == null)
                return true;
            */
            if (Object.ReferenceEquals(left, null))
                return true;
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(Name left, Name right)
        {
            /* 2019.03.19 change
            if (left == null)
                return right == null;
            */
            if (Object.ReferenceEquals(left, null))
                return Object.ReferenceEquals(right, null);
            return left.CompareTo(right) >= 0;
        }

        public override string ToString()
        {
            return $"(Last={Last}, First={First}, Middle={Middle})";
        }

        // その他の詳細は省略
    }
}
