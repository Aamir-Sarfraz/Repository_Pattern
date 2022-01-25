using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Pattern.Repository.LoginRepository
{
    public interface ILogin:Generics.IGenericRepository<Models.Login>
    {
        public bool Alogin();
    }
}
