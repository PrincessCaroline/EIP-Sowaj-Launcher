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
            { 
                token = JsonConvert.DeserializeObject<Token>(responseJASON);
                token.connectionAccepted = true;
            }
            catch
            {
                token.connectionAccepted = false;
                token.Tok = responseJASON;
            }
            return (token);
        }

        /*public ClientInfos ProfilCreation(String nickname)
        {
            RequestServer newreq = new RequestServer();
            ClientInfos clientInfos = new ClientInfos();

            String responseJASON = newreq.ProfilCreation(nickname);
            MessageBox.Show(responseJASON);

            try
            {
                clientInfos = JsonConvert.DeserializeObject<ClientInfos>(responseJASON);
            }
            catch
            {
                clientInfos.nickName = "Unknow";
            }
            return (clientInfos);
        }*/
    }
}
