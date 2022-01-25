using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Pattern.Repository.Wrapper
{
    public interface IWrapper
    {
        public  LoginRepository.ILogin login { get; }


    }
}
