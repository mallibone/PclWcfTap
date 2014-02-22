using System;
using Server.Wcf;

namespace Server.Impl
{
    public class SimpleService : IService
    {
        public string Login(string username, string password)
        {
            if (username == "John" && password == "Gnabber") return Guid.NewGuid().ToString();

            return string.Empty;
        }
    }
}
