using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReadConfig.Bsl;
using ReadConfig.Model;

namespace ReadConfig.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var emailHost = AppSettings.Instance.Get<MailConfig>("MailConfig");

            string returnText = string.Format("1. Pass : {0} \n", emailHost.Servers.MailGun.Pass);
            returnText += string.Format("2. Port : {0} \n", emailHost.Servers.MailGun.Port);
            returnText += string.Format("3. Host : {0} \n", emailHost.Servers.MailGun.Host);
            returnText += string.Format("4. Email : {0} \n", emailHost.Sender.Email);
            returnText += string.Format("5. Pass : {0} \n", emailHost.Sender.Pass);

            return Content(returnText);
        }
    }
}