using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2019.02.23 add
using System.ComponentModel;

namespace PropertyChanged
{
    public class Person
    {
        public string Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                    PropertyChanged?.Invoke(this,
                        new PropertyChangedEventArgs(nameof(Name)));
                }
            }
        }
        private string name;

        public event PropertyChangedEventHandler PropertyChanged;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.PropertyChanged += NameChanged;
            p.Name = "sasaki";
        }

        private static void NameChanged(object sender, PropertyChangedEventArgs e)
        {
            // 文字列でプロパティ名を判別
            if (e.PropertyName != "Name") return;

            // そしてキャスト
            var p = (Person)sender;

            // 各々の処理
            Console.WriteLine("名前が変更されました: " + p.Name);
        }
    }
}
