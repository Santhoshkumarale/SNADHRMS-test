using SNADHRMS.Business.Interface;
using SNADHRMS.Repository.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNADHRMS.Business
{
  
    public class RegisterBusiness : IRegisterBusiness
    {
        private readonly IRegisterRepository _regRepository;
        public RegisterBusiness()
        {

        }
    }

}
