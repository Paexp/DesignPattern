﻿using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小菜");

            Console.WriteLine("\n第一种装扮：");

            Sneakers pqx = new Sneakers();
            BigTrouser kk = new BigTrouser();
            TShirts dtx = new TShirts();

            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

            Console.WriteLine("\n第二种装扮：");

            LeatherShoes px = new LeatherShoes();
            Tie ld = new Tie();
            Suit xz = new Suit();

            px.Decorate(xc);
            ld.Decorate(px);
            xz.Decorate(ld);
            xz.Show();

            Console.Read();
        }
    }
}
