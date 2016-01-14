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

        //private String url = "http://epitech-api.herokuapp.com/";
        private String url = "http://163.5.84.192:80/SowajServer/";



        public String SendHttpRequest(String requestName, byte[] param, String method)
        {
            url += requestName;
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AllowAutoRedirect = false;
            request.Method = method;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = param.Length;

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

        public String ProfilCreation(String nickname)
        {
            // Create POST data and convert it to a byte array.
            string postData = "nickname=" + nickname;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            string responseStr = SendHttpRequest("infosplayer", byteArray, "POST");
            return (responseStr);
        }

        public String ServerConnect(String username, String pwd, String mail)
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
            String responseStr = SendHttpRequest("connection", byteArray, "POST");
            //MessageBox.Show(responseStr);
            return (responseStr);
            
        } //OK

        public bool LoginAvaible(String login)
        {
            // Create POST data and convert it to a byte array.
            string postData = "login=" + login;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            string response = SendHttpRequest("login", byteArray, "POST");
            if (response == "200")
            {
                Console.WriteLine("yes it's avaible");
                return (true);
            }
            else
                return (false);
        } //OK

        public bool Register(String login, String password, String mail, String firstname, String lastname, String nat, String birthdate)
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

            String responseStr = SendHttpRequest("registration", byteArray, "POST");
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

        public void PlayerInfos(String token, int playerId)
        {
            // Create POST data and convert it to a byte array.
            string postData = "token=" + token;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            //SendRequest("infosplayer", byteArray, "POST");
            SendHttpRequest("infosplayer", byteArray, "POST");
        }

        public String SendRequest(String requestName, byte[] param, String method)
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
