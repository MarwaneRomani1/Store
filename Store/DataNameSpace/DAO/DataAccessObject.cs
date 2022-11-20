using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Store.DataNameSpace.DAO
{
    internal abstract class DataAccessObject<T>
    {
        protected SqlConnection connection;

        protected DataAccessObject(SqlConnection connection)
        {
            this.connection = connection;
        }
        

        public abstract List<T> getAll();
        public abstract T getOne(int id);
        public abstract int save(T t);
        public abstract int update(T t, String[] arguments);
        public abstract int delete(T t);
    }
}
