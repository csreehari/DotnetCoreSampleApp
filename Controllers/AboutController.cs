using System;
using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "+1-215-281-2345";
        }

        public string Address()
        {
            return "Hello from Philadephia";
        }
    }
}
