using System;
using Server.Wcf;

namespace Server.Impl
{
    public class SimpleService : IService
    {
        public bool Login(string username, string password)
        {
            return username == "John" && password == "Gnabber";
        }
    }
}
