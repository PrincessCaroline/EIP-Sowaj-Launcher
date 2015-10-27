using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Sowaj
{
    class RequestServer
    {

        private String url = "http://epitech-api.herokuapp.com/";

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

        public bool ServerConnect(String username, String pwd)
        {
            // Create POST data and convert it to a byte array.
            string postData = "login="+username+"&password="+pwd;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            SendRequest("login", byteArray, "POST");
            return (true);
        }

        public void PlayerInfos(String token)
        {
            // Create POST data and convert it to a byte array.
            string postData = "token=" + token;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            SendRequest("infosplayer", byteArray, "POST");
        }
    }
}
