using System;

namespace Flyweight
{
    class ConcreteWebsite : WebSite
    {
        private string name = "";

        public ConcreteWebsite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("网站分类：" + name + " 用户：" + user.Name);
        }
    }
}
