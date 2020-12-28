﻿using System;

namespace AbstractFactory
{
    class SqlserverUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SQL Server中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SQL Server中根据ID得到User表一条记录");
            return null;
        }
    }
}
