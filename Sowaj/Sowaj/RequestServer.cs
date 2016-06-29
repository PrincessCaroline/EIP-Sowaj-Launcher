using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Sowaj
{
    class RequestServer
    {
        private String url = "http://163.5.84.192:80/SowajServer/";



        private String SendHttpRequest_POST(String requestName, byte[] param)
        {
            url += requestName;
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AllowAutoRedirect = false;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                   
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(param, 0, param.Length);
                dataStream.Close();
                
                //get response from the request
                response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                String responseStr = sr.ReadToEnd();

                if (responseStr == "")
                    return (((int)response.StatusCode).ToString());
                else
                    return (responseStr);
            }
            catch (WebException e)
            {

                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                response = (HttpWebResponse)e.Response;

                Console.Write("CATCH : Errorcode: {0}", response);
                return (((int)response.StatusCode).ToString());
                }
                else
                {
                Console.Write("CATCH : Error: {0}", e.Status);
                return (e.Status.ToString());
                }
            }
            finally
            {
                if (response != null)
                {
                response.Close();
                }
            }
            //           MessageBox.Show((int)httpRes.StatusCode);
        }
        private String SendHttpRequest_PUT(String requestName, byte[] param)
        {
            url += requestName;
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AllowAutoRedirect = false;
                request.Method = "PUT";
                request.ContentType = "application/x-www-form-urlencoded";

                Stream dataStream = request.GetRequestStream();
                dataStream.Write(param, 0, param.Length);
                dataStream.Close();

                //get response from the request
                response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                String responseStr = sr.ReadToEnd();

                if (responseStr == "")
                    return (((int)response.StatusCode).ToString());
                else
                    return (responseStr);
            }
            catch (WebException e)
            {

                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    response = (HttpWebResponse)e.Response;

                    Console.Write("CATCH : Errorcode: {0}", response);
                    return (((int)response.StatusCode).ToString());
                }
                else
                {
                    Console.Write("CATCH : Error: {0}", e.Status);
                    return (e.Status.ToString());
                }
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
            //           MessageBox.Show((int)httpRes.StatusCode);
        }
        private String SendHttpRequest_GET(String requestName, String param, String method)
        {
            url += requestName + "?" + param;
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AllowAutoRedirect = false;
                request.Method = method;
                request.ContentType = "application/x-www-form-urlencoded";

                //get response from the request
                response = (HttpWebResponse)request.GetResponse();
                StreamReader sr = new StreamReader(response.GetResponseStream());
                String responseStr = sr.ReadToEnd();

                if (responseStr == "")
                    return (((int)response.StatusCode).ToString());
                else
                    return (responseStr);
            }
            catch (WebException e)
            {

                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    response = (HttpWebResponse)e.Response;

                    Console.Write("CATCH : Errorcode: {0}", response);
                    return (((int)response.StatusCode).ToString());
                }
                else
                {
                    Console.Write("CATCH : Error: {0}", e.Status);
                    return (e.Status.ToString());
                }
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }
            //           MessageBox.Show((int)httpRes.StatusCode);
        }

        public String   ProfilCreation(String nickname, String token)
        {
            string postData = "login=" + nickname + "&token=" + token;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            string responseStr = SendHttpRequest_POST("infosplayer", byteArray);
            return (responseStr);
        }

        public String   CreateDeck(String profileid, String token, String name, String desc)
        {
            string postData = "profileid=" + profileid + "&token=" + token + "&name=" + name + "&desc=" + desc;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            string responseStr = SendHttpRequest_POST("deck", byteArray);
            return (responseStr);
        }

        public String   DeleteDeck(String profileid, String token, String deckid)
        {
            string param = "token=" + token + "&profileid=" + profileid + "&deckid=" + deckid;
            string responseStr = SendHttpRequest_GET("deck", param, "DELETE");
            MessageBox.Show("DELETE deck: " + responseStr);
            return (responseStr);
        }

        public String   ModifyDeck(String profileid, 
                                   String token, 
                                   String name, 
                                   String desc, 
                                   String action, 
                                   String deckid)
        {
            string param = "profileid=" + profileid +
                           "&token=" + token +
                           "&name=" + name +
                           "&desc=" + desc +
                           "&action" + action +
                           "&deckid" + deckid;
            byte[] byteArray = Encoding.UTF8.GetBytes(param);
            string responseStr = SendHttpRequest_PUT("deck", byteArray);
            MessageBox.Show("MODIFY deck: " + responseStr);
            return (responseStr);
        }
        public String   DeckAll(String profileid, String token)
        {
            string getData = "token=" + token + "&profileid=" + profileid;
            string responseStr = SendHttpRequest_GET("deckall", getData, "GET");
//            MessageBox.Show(">> deckall  : " + responseStr);
            return (responseStr);
        }
        public String   InfosPlayer(String profileid, String token)
        {
           string getData = "profileid = " + profileid + "&token=" + token;
           string responseStr = SendHttpRequest_GET("infosplayer", getData, "GET");           
           return (responseStr);
        }

    

        public String   ServerConnect(String username, String pwd, String mail)
        {
            // Create POST data and convert it to a byte array
            String postData;
            if (username != "")
            {
                 postData = "login=" + username + "&password=" + pwd;
            }
            else
            {
                 postData = "email=" + mail + "&password=" + pwd;
            }
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            //Send connection request with param    
            String responseStr = SendHttpRequest_POST("connection", byteArray);
            //MessageBox.Show(responseStr);
            return (responseStr);
            
        } //OK

        public String   RankOverall(int profil_id, String action, String token)
        {
            String getData;
            // Create POST data and convert it to a byte array
            if (action == "nat")
                getData = "profileid=" + profil_id + "&action=" + action + "&nationality=FR&token=" + token;
            else
                getData = "profileid=" + profil_id + "&action=" + action + "&token=" + token;

            //Send connection request with param    
            String responseStr = SendHttpRequest_GET("rankoverall", getData, "GET");
            //MessageBox.Show(responseStr);
            return (responseStr);

        } //OK

        public bool     LoginAvaible(String login)
        {
            // Create POST data and convert it to a byte array.
            string postData = "login=" + login;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            string responseStr = SendHttpRequest_POST("login", byteArray);
            if (responseStr == "200")
            {
                Console.WriteLine("yes it's avaible");
                return (true);
            }
            else
                return (false);
        } //OK

        public bool     Register(String login, 
                                 String password, 
                                 String mail, 
                                 String firstname, 
                                 String lastname, 
                                 String nat, 
                                 String birthdate)
        {
            // Create POST data and convert it to a byte array.
            string postData =
                "login=" + login +
                "&password=" + password +
                "&email=" + mail +
                "&firstname=" + firstname +
                "&lastname=" + lastname +
                "&nationality=" + nat +
                "&dateofbirth=" + birthdate;

            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            String responseStr = SendHttpRequest_POST("registration", byteArray);
            MessageBox.Show("inscription : " + responseStr);
            if (responseStr == "200")
                return (true);
            else if (responseStr == "500")
            {
                Console.WriteLine("INTERNAL ERROR");
                return (false);
            }
            else
            {
                Console.WriteLine("ERROR BUT I DON'T KNOW WHY !! HAHA ! I'M SO SILLY");
            return (false);
            }
        } //OK

        public String   SendRequest(String requestName, byte[] param, String method)
        {
            url += requestName;

            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create(url);

            // Set the Method property of the request to POST.
            request.Method = method;

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";

            // Set the ContentLength property of the WebRequest.
            request.ContentLength = param.Length;

            // Get the request stream.
            Stream dataStream = request.GetRequestStream();

            // Write the data to the request stream.
            dataStream.Write(param, 0, param.Length);

            // Close the Stream object.
            dataStream.Close();

            // Get the response.
            WebResponse response = request.GetResponse();

            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            //Debug
            Console.WriteLine(responseFromServer);

            //Clean up the Stream
            reader.Close();
            dataStream.Close();
            response.Close();
            return (responseFromServer);
        }
    }
}
