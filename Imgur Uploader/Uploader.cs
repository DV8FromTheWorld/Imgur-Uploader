using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net;

namespace Imgur_Uploader
{
    class Uploader
    {
        //CHANGE TO @CLIENT_ID@ and replace with buildscript.
        private const String CLIENT_ID = "efce6070269a7f1";

        //CHANGE TO @CLIENT_SECRET@ and replace with buildscript.
        private const String CLIENT_SECRET = "bc038b940212ad28e0de3eddea1a18375434b143";

        public static String Upload(Image image)
        {
            MemoryStream ms = new MemoryStream();
            ImageFormat format = image.RawFormat;
            image.Save(ms, format.Equals(ImageFormat.MemoryBmp) ? ImageFormat.Png : format);

            WebClientEx w = new WebClientEx();
            w.timeout = 100000;
            w.Headers.Add("Authorization", "Client-ID " + CLIENT_ID);

            NameValueCollection values = new NameValueCollection
            {
                { "image", Convert.ToBase64String(ms.ToArray()) }
            };

            try
            {
                byte[] response = w.UploadValues("https://api.imgur.com/3/image", values);
                return Encoding.ASCII.GetString(response);
            }
            catch (WebException e)
            {
                return getWebError(e.Response);
            }
        }

        public static String CreateAlbum(List<String> imageIds)
        {
            WebClientEx w = new WebClientEx();
            w.timeout = 100000;
            w.Headers.Add("Authorization", "Client-ID " + CLIENT_ID);

            String ids = "";
            foreach (String id in imageIds)
            {
                if (!ids.Equals(""))
                {
                    ids += ",";
                }
                ids += id;
            }

            NameValueCollection values = new NameValueCollection
            {
                { "ids", ids }
            };

            try
            {
                byte[] response = w.UploadValues("https://api.imgur.com/3/album", values);
                return Encoding.ASCII.GetString(response);
            }
            catch (WebException e)
            {
                return getWebError(e.Response);
            }
        }

        private static String getWebError(WebResponse wr)
        {
            switch (((HttpWebResponse) wr).StatusCode)
            {
                case HttpStatusCode.ServiceUnavailable:
                    return "ERROR: Service Unavailable.  Check Imgur.com";
                case HttpStatusCode.RequestTimeout:
                case HttpStatusCode.GatewayTimeout:
                    return "ERROR: Upload Timed out. Need Moar Internez";
                case HttpStatusCode.BadGateway:
                    return "ERROR: Bad Gateway. Imgur is Overloaded.";
                default:
                    return "ERROR:  Unknown error occured.";
            }
        }
    }    
}
