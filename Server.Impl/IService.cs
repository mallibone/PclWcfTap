using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;

namespace Server.Wcf
{
    /// <summary>
    /// Example Service
    /// </summary>
    [ServiceContract]
    public interface IService
    {
	/// <summary>
	/// Given a valid username and password a token is returned, if not an empty string is returned
	/// </summary>
	/// <param name="username">username</param>
	/// <param name="password">password</param>
	/// <returns>token</returns>
        [OperationContract]
        string Login(string username, string password);
    }
}
