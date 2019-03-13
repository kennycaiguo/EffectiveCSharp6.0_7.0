using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateVariance
{
    public interface ICovariantDelegate<out T>
    {
        T GetAnItem();
        Func<T> GetAnItemLater();
        void GiveAnItemLater(Action<T> whatToDo);
    }

    public interface IContravariantDelegate<in T>
    {
        void ActOnAnItem(T item);
        void GetAnItemLater(Func<T> item);
        Action<T> ActOnAnItemLater();
    }

    public class IntSupplier : ICovariantDelegate<int>
    {
        private int value;
        public IntSupplier(int value)
        {
            this.value = value;
        }

        public int GetAnItem()
        {
            return this.value;
        }

        public Func<int> GetAnItemLater()
        {
            return () => this.value;
        }

        public void GiveAnItemLater(Action<int> whatToDo)
        {
            whatToDo(value);
        }
    }

    public class IntConsumer : IContravariantDelegate<int>
    {
        private int value;
        public int Value
        {
            get { return value; }
        }

        public void ActOnAnItem(int item)
        {
            this.value = item;
        }

        public Action<int> ActOnAnItemLater()
        {
            return (item) => this.value = item; 
        }

        public void GetAnItemLater(Func<int> item)
        {
            this.value = item();
        }
    }

}
