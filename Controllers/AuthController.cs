using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Pattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
       public static Database.DataBaseContext _context;
      public static  Repository.Wrapper.IWrapper _iwrapper;
        

        public AuthController(Database.DataBaseContext context, Repository.Wrapper.IWrapper iwrapper) {
            _context = context;
            _iwrapper = iwrapper;
        }
        
        [HttpPost]


        public bool login() {
            BusinessLayer.AuthLogin blauth = new BusinessLayer.AuthLogin(_context, _iwrapper);
            return blauth.Alogin();
        }

    }
}
