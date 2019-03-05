using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviveFinalizedObject
{
    public class BadClass
    {
        // グローバルオブジェクトの参照を保持
        private static readonly List<BadClass> finalizedList = new List<BadClass>();
        public static List<BadClass> FinalizedList
        {
            get { return finalizedList; }
        }
        private string msg;

        public BadClass(string msg)
        {
            // 参照をキャッシュ
            msg = (string)msg.Clone();
        }

        ~BadClass()
        {
            // オブジェクト自信をリストに追加
            //　このオブジェクトは到達可能になるため、ガベージではなくなる
            //　つまり復活します！
            finalizedList.Add(this);
        }
    }
}
