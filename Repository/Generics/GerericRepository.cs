using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Pattern.Repository.Generics
{
    public class GerericRepository<T>:IGenericRepository<T> where T:class
    {

        public Database.DataBaseContext _dbcontext;
        public GerericRepository(Database.DataBaseContext context)
        {
            _dbcontext = context;

        }
    }
}
