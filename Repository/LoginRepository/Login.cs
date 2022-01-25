using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Pattern.Repository.LoginRepository
{
    public class Login:ILogin
    {

        Database.DataBaseContext _dbcontext;
        public Login(Database.DataBaseContext dbcontext)
        {
            this._dbcontext = dbcontext;

        }

        public bool Alogin() {
            //this is testing
                    return true;
        }
    }
}
