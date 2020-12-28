using System;

namespace TemplateMethod
{
    class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("杨过得到过，后来给了郭靖，练成倚天剑、屠龙刀的玄铁可能是[] a.球磨铸铁 b.马口铁 c.高速合金钢 d.碳素纤维");
            Console.WriteLine("答案是：" + Answer1());
        }

        public void TestQuestion2()
        {
            Console.WriteLine("杨过、程英、陆无双铲除了情花，造成[] a.使这种植物不再害人 b.使一种珍惜物种灭绝 c.破坏了那个生态圈的生态平衡 d.造成该地区沙漠化");
            Console.WriteLine("答案是：" + Answer2());
        }

        public void TestQuestion3()
        {
            Console.WriteLine("蓝凤凰致使华山师徒，桃谷六仙呕吐不止，如果你是大夫，会给他们开什么药[] a.阿司匹林 b.牛黄解毒片 c.氟哌酸 d.让他们喝大量牛奶 e.以上全不对");
            Console.WriteLine("答案是：" + Answer3());
        }

        protected virtual string Answer1()
        {
            return "";
        }
        protected virtual string Answer2()
        {
            return "";
        }
        protected virtual string Answer3()
        {
            return "";
        }
    }
}
