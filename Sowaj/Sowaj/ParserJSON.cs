using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;


namespace Sowaj
{
    class ParserJSON
    {
        

        public Token   ServerConnect(String email, String password, String username)
        {
            RequestServer newreq = new RequestServer();
            Token token = new Token();

            String responseJASON = newreq.ServerConnect(email, password, username);

            try
            { //(responseJASON.ElementAt<char>(0) == '{')
                token = JsonConvert.DeserializeObject<Token>(responseJASON);
                token.connectionAccepted = true;
            }
            catch
            {
                token.connectionAccepted = false;
                token.Tok = responseJASON;
            }
            MessageBox.Show(token.Tok);

            return (token);
        }
    }
}
