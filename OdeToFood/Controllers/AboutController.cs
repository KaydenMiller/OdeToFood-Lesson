using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    // About

    [Route("[controller]/[action]")]
    public class AboutController
    {
        //[Route("")]
        public string Phone()
        {
            return "1+ 801-388-5765";
        }

        //[Route("[action]")]
        public string Address()
        {
            return "2520 W. 1675 S.";
        }
    }
}
