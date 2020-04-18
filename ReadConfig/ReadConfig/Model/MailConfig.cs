using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadConfig.Model
{
    public class MailConfig
    {
        public Servers Servers { get; set; }
        public Sender Sender { get; set; }
    }

    public class Servers
    {
        public MailGun MailGun { get; set; }
    }
    
    public class MailGun
    {
        public string Pass { get; set; }
        public int Port { get; set; }
        public string Host { get; set; }
    }
    
    public class Sender
    {
        public string Email { get; set; }
        public string Pass { get; set; }
    }
}
