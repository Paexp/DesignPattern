﻿using System;

namespace AbstractFactory
{
    class SqlserverDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在SQL Server中给Department表增加一条记录");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SQL Server中根据ID得到Department表一条记录");
            return null;
        }
    }
}
