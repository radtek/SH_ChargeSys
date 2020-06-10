using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Live0xUtils.HttpUtils;
using Newtonsoft.Json;

namespace ChargeSys.Main.Api
{
    public class ApiHelper
    {
        /// <summary>
        /// 资源类型：JSON字符串
        /// </summary>
        public const string APPLICATION_JSON = "application/json";

        //private static string BaseUrl = "http://192.168.2.235:8088/api/"; 
        private static string BaseUrl = "http://localhost:5000/api/";

        public ResponseModel ReqGet(string url, Hashtable hashtable)
        {
            string reqUrl = (BaseUrl.EndsWith("/") ? BaseUrl : BaseUrl + "/") + url;
            ResponseModel responseModel = new ResponseModel();
            try
            {
                List<string> list = new List<string>();
                if (hashtable != null)
                {
                    foreach (DictionaryEntry de in hashtable)
                    {
                        list.Add($"{de.Key}={de.Value}");
                    }
                }
                var resp = HttpGet(reqUrl, string.Join("&", list.ToArray()));
                resp = HttpUtility.HtmlDecode(resp);
                if (!string.IsNullOrEmpty(resp))
                {
                    responseModel = JsonConvert.DeserializeObject<ResponseModel>(resp);
                }
            }
            catch (WebException ex)
            {
                responseModel.Message = ex.Message;
            }
            catch (Exception ex)
            {
                responseModel.Message = ex.Message;
            }
            return responseModel;
        }

        public ResponseModel ReqDelete(string url, Hashtable hashtable)
        {
            string reqUrl = (BaseUrl.EndsWith("/") ? BaseUrl : BaseUrl + "/") + url;
            ResponseModel responseModel = new ResponseModel();
            try
            {
                List<string> list = new List<string>();
                if (hashtable != null)
                {
                    foreach (DictionaryEntry de in hashtable)
                    {
                        list.Add($"{de.Key}={de.Value}");
                    }
                }
                var resp = HttpDelete(reqUrl, string.Join("&", list.ToArray()));
                resp = HttpUtility.HtmlDecode(resp);
                if (!string.IsNullOrEmpty(resp))
                {
                    responseModel = JsonConvert.DeserializeObject<ResponseModel>(resp);
                }
            }
            catch (WebException ex)
            {
                responseModel.Message = ex.Message;
            }
            catch (Exception ex)
            {
                responseModel.Message = ex.Message;
            }
            return responseModel;
        }

        public ResponseModel ReqPut(string url, object obj)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                string reqUrl = (BaseUrl.EndsWith("/") ? BaseUrl : BaseUrl + "/") + url;
                string respStr = "";
                respStr = HttpPut(reqUrl, JsonConvert.SerializeObject(obj));

                respStr = HttpUtility.HtmlDecode(respStr);
                if (!string.IsNullOrEmpty(respStr))
                {
                    responseModel = JsonConvert.DeserializeObject<ResponseModel>(respStr);
                }
            }
            catch (WebException ex)
            {
                responseModel.Message = ex.Message;
            }
            catch (Exception ex)
            {
                responseModel.Message = ex.Message;
            }
            return responseModel;
        }

        public ResponseModel ReqPost(string url, object obj)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                string reqUrl = (BaseUrl.EndsWith("/") ? BaseUrl : BaseUrl + "/") + url;
                string respStr = "";
                respStr = HttpPost(reqUrl, JsonConvert.SerializeObject(obj));

                respStr = HttpUtility.HtmlDecode(respStr);
                if (!string.IsNullOrEmpty(respStr))
                {
                    responseModel = JsonConvert.DeserializeObject<ResponseModel>(respStr);
                }
            }
            catch (WebException ex)
            {
                responseModel.Message = ex.Message;
            }
            catch (Exception ex)
            {
                responseModel.Message = ex.Message;
            }
            return responseModel;
        }

        public string HttpPost(string url, string content)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            // ServicePointManager.SecurityProtocol = (SecurityProtocolType)192 | (SecurityProtocolType)768 | (SecurityProtocolType)3072;
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;
            httpWebRequest.ContentType = APPLICATION_JSON;
            httpWebRequest.Method = "POST";
            byte[] b = System.Text.Encoding.UTF8.GetBytes(content);
            httpWebRequest.ContentLength = b.Length;

            Stream writer;
            try
            {
                writer = httpWebRequest.GetRequestStream();
            }
            catch (Exception)
            {
                throw;
            }

            writer.Write(b, 0, b.Length);
            writer.Close();

            HttpWebResponse httpWebResponse;
            try
            {
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string encodings = httpWebResponse.ContentEncoding;
            }
            catch (WebException we)
            {
                httpWebResponse = we.Response as HttpWebResponse;
            }

            Stream stream = httpWebResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);
            string s = streamReader.ReadToEnd();
            streamReader.Close();
            return s;
        }

        public string HttpGet(string url, string content)
        {
            string retString = "";

           HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + (content == "" ? "" : "?") + content);
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = APPLICATION_JSON;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream myResponseStream = response.GetResponseStream())
            {
                using (StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8))
                {
                    retString = myStreamReader.ReadToEnd();
                }
            }
            return retString;
        }

        public string HttpPut(string url, string content)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = APPLICATION_JSON;
            httpWebRequest.Method = "PUT";
            byte[] b = System.Text.Encoding.UTF8.GetBytes(content);
            httpWebRequest.ContentLength = b.Length;

            Stream writer;
            try
            {
                writer = httpWebRequest.GetRequestStream();
            }
            catch (Exception)
            {
                throw;
            }

            writer.Write(b, 0, b.Length);
            writer.Close();

            HttpWebResponse httpWebResponse;
            try
            {
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string encodings = httpWebResponse.ContentEncoding;
            }
            catch (WebException we)
            {
                httpWebResponse = we.Response as HttpWebResponse;
            }

            Stream stream = httpWebResponse.GetResponseStream();
            StreamReader streamReader = new StreamReader(stream);

            string s = streamReader.ReadToEnd();
            streamReader.Close();

            return s;
        }

        public string HttpDelete(string url, string content)
        {
            string retString = "";
            try
            {
               //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + (content == "" ? "" : "?") + content);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "DELETE";
                request.ContentType = APPLICATION_JSON;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream myResponseStream = response.GetResponseStream())
                {
                    using (StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8))
                    {
                        retString = myStreamReader.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return retString;
        }
    }

    public enum ReqType
    {
        Post,
        Get,
        Delete,
        Put
    }
}
