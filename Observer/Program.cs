using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss huhansan = new Boss();

            StockObserver tongshi1 = new StockObserver("同事1", huhansan);
            NBAObserver tongshi2 = new NBAObserver("同事2", huhansan);

            huhansan.Update += new Boss.EventHandler(tongshi1.CloseStockMarket);
            huhansan.Update += new Boss.EventHandler(tongshi2.CloseNBADirectSeeding);

            huhansan.SubjectState = "我胡汉三回来了!";

            huhansan.Notify();

            Console.Read();
        }
    }
}
