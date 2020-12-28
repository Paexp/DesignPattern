using System;
using System.Reflection;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dept = new Department();

            IUser iu = DataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment idept = DataAccess.CreateDepartment();
            idept.Insert(dept);
            idept.GetDepartment(1);

            Console.Read();
        }
    }
}
