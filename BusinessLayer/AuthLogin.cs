using Repository_Pattern.Repository.LoginRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Pattern.BusinessLayer
{
    public class AuthLogin
    {
        

        
        public  Repository.Wrapper.IWrapper repository;


        public Database.DataBaseContext _context;
       

        public AuthLogin(Database.DataBaseContext context,Repository.Wrapper.IWrapper iwrapper)
        {
           this._context = context;
            this.repository = iwrapper;

        }
      public  bool Alogin()
        {
            return repository.login.Alogin(); 
        }
    }
}
