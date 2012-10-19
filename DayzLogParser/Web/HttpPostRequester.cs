using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace DayzLogParser.Web {
    public class HttpPostRequester {
        protected String url { get; set; }
        protected String data { get; set; }

        public HttpPostRequester(String url, String data) {
            this.url = url;
            this.data = data;
        }

        /// <summary>
        /// Performs a POST request.
        /// </summary>
        /// <returns>The result as a string.</returns>
        public String DoPost() {
            HttpWebRequest httpWReq =
                (HttpWebRequest)WebRequest.Create(url);

            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] data = encoding.GetBytes(this.data);

            httpWReq.Method = "POST";
            httpWReq.ContentType = "application/x-www-form-urlencoded";
            httpWReq.ContentLength = data.Length;

            Stream newStream = httpWReq.GetRequestStream();
            newStream.Write(data, 0, data.Length);// Get the response.
            WebResponse response = httpWReq.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            newStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(newStream);
            // Read the content.
            String responseText = "";
            responseText = reader.ReadToEnd();
            newStream.Close();

            return responseText;
        }
    }
}
