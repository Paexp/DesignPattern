using System;

namespace EventandHandler
{
    class Mouse
    {
        private string name;

        public Mouse(string name)
        {
            this.name = name;
        }

        public void Run(object sender, CatShoutEventArgs args)
        {
            Console.WriteLine("老猫{0}来了，{1}快跑！", args.Name, name);
        }
    }
}
