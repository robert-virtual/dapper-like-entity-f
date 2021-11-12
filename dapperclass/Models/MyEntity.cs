using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Dapper.Contrib.Extensions;
using dapperclass.DataAccess;


namespace dapperclass.Models
{
    public class MyEntity<T>:Connection where T:class
    {
        public List<T> GetAll()  
        {
            using (var db = ConnectDB())
            {
                return db.GetAll<T>().ToList();
            }
        }
        public static long Save(T entity)
        {
            using (var db = ConnectDB())
            {
                return db.Insert(entity);
            }
        }
    }
}
