using IO.Swagger.Api.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {

        static void Main(string[] args)
        {
            var authenticationClient = new AuthorizationApi("https://ixapidemo.arxivar.it/OAuth");
            var token = authenticationClient.Token(new IO.Swagger.Model.Account.TokenRequest(
                "MioClientID",
                "MioClientSecret",
                 IO.Swagger.Model.Account.TokenRequest.GrantTypeEnum.Password,
                "",
                "",
                new List<string>(),
                null,
                "v2.0.3.1"));
        }

        
    }
}
