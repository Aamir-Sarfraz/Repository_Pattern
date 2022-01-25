using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Pattern.Repository.Wrapper
{
    public class Wrapper:IWrapper
    {
        public Database.DataBaseContext _dbcontext;

        Repository.LoginRepository.ILogin _ilogin;
        public Wrapper(Database.DataBaseContext dataBaseContext)
        {
            this._dbcontext = dataBaseContext;

        }

        public LoginRepository.ILogin login
        {

            get
            {

                if (_ilogin == null) {
                    _ilogin = new LoginRepository.Login(_dbcontext);
                }
                return _ilogin;

            }

        }

    }
}
