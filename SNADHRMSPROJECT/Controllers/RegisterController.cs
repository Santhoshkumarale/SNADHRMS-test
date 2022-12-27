using Microsoft.AspNetCore.Mvc;
using SNADHRMS.Business.Interface;
using SNADHRMS.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SNADHRMSPROJECT.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IRegisterBusiness _regBusiness;
        public RegisterController(IRegisterBusiness regBusiness)
        {
            _regBusiness = regBusiness;
        }
        public IActionResult Index()
        {
           

            return View();
        }
    }
}
