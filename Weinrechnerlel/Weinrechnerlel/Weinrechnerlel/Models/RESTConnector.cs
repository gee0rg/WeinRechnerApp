using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Weinrechnerlel
{
    public class RESTConnector
    {

        public string ConnectionUsername { get; set; }
        public string ConnectionUserPwd { get; set; }
        public string CertificateFile { get; set; }

        public X509Certificate Certificate { get; set; }


      //  private static readonly ILogger _log =
   // LoggingFactory.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private HttpWebRequest req;
        public RESTConnector()
        {
        }

        /// <summary>
        /// HTTP GET
        /// </summary>
        /// <param name="ServerURL">URL für den Aufruf</param>
        /// <param name="timeout">Timeout Wert für Request in Sekunden</param>
        /// <param name="useCertificate">HTTPS ServerZertifikatValidierung durchführen</param>
        /// <returns></returns>
        public virtual string HTTP_GET(string ServerURL, int timeout, bool useCertificate = false)
        /*#############################################################################################################################
         * Fnktion für HTTP_GET's 
        #############################################################################################################################*/
        {

            string Out = String.Empty;
            try
            {
               // _log.Info(string.Format("HTTP_GET, URL={0} timeout={1} ssl={2}.", ServerURL, timeout, useCertificate));

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ServerURL);
                //request.Credentials = new NetworkCredential(ConnectionUsername, ConnectionUserPwd);

                // Serverzertifikatsprüfung wird durchgeführt
                if (!useCertificate)
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                // Zertifikat muss bei Nutzung von Clientzertifikaten angegeben werden
                if (useCertificate && CertificateFile != null)
                {
                    X509Certificate cert = X509Certificate.CreateFromCertFile(CertificateFile);
                    request.ClientCertificates.Add(Certificate);
                }

                request.Method = "GET";
                request.Timeout = timeout * 1000;
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                response.Close();
                //_log.Info(string.Format("HTTP_GET, URL={0} Respone=OK.", ServerURL));
                ////_log.Debug(string.Format("HTTP_GET, URL={0} Respone={1}.", ServerURL, responseFromServer));
                return responseFromServer;
            }
            catch (ArgumentException ex)
            {
                //_log.Error("ArgumentException: ", ex);
                Out = string.Format("REST_HTTP_ERROR ::  Ungültiger Parameter in HTTP GET Request :: {0}", ex.Message);
                //return string.Format("REST_HTTP_ERROR ::  Ungültiger Parameter in HTTP GET Request :: {0}", ex.Message);
            }
            catch (WebException ex)
            {
                //_log.Error("WebException: ", ex);
                if (ex.Response != null)
                {
                    Stream dataStream = ex.Response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    
                  
                    return responseFromServer;
                }
                else
                    Out = string.Format("REST_HTTP_ERROR :: Exception beim HTTP GET Request :: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                //_log.Error("Exception: ", ex);
                Out = string.Format("REST_HTTP_ERROR :: Exception beim HTTP GET Request :: {0}", ex.Message);
            }
            //_log.Debug(string.Format("HTTP_POST, URL={0} ErrorText={1}.", ServerURL, Out));
      
            return Out;

        }

        /// <summary>
        /// HTTP_POST Aufruf 
        /// </summary>
        /// <param name="ServerURL">URL für den Aufruf</param>
        /// <param name="Data">Eingabedaten für den Request</param>
        /// <param name="timeout">Timeout Wert für Request in Sekunden</param>
        /// <param name="useCertificate">HTTPS ServerZertifikatValidierung durchführen</param>
        /// <returns></returns>
        public virtual string HTTP_POST(string ServerURL, string Data, int timeout, bool useCertificate = false)
        /*#############################################################################################################################
         * Funktion für HTTP_POST's 
        #############################################################################################################################*/
        {

            //_log.Info(string.Format("HTTP_POST, URL={0} timeout={1} ssl={2} Data={3}.", ServerURL, timeout, useCertificate, Data));

            string Out = String.Empty;
            req = (HttpWebRequest)WebRequest.Create(ServerURL);
            try
            {
                // Serverzertifikatsprüfung wird durchgeführt
                if (!useCertificate)
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                // Zertifikat muss bei Nutzung von Clientzertifikaten angegeben werden
                if (useCertificate && CertificateFile != null)
                {
                    X509Certificate cert = X509Certificate.CreateFromCertFile(CertificateFile);
                    req.ClientCertificates.Add(cert);
                }

                req.Method = "POST";
                req.ReadWriteTimeout = timeout * 1000;
                req.Timeout = timeout * 1000;
                req.ContentType = "application/json";
                req.Credentials = new NetworkCredential(ConnectionUsername, ConnectionUserPwd);
                byte[] sentData = Encoding.UTF8.GetBytes(Data);
                req.ContentLength = sentData.Length;
                using (System.IO.Stream sendStream = req.GetRequestStream())
                {
                    sendStream.Write(sentData, 0, sentData.Length);
                    sendStream.Close();

                }
                using (System.Net.WebResponse res = req.GetResponse())
                using (System.IO.Stream ReceiveStream = res.GetResponseStream())
                using (System.IO.StreamReader sr = new System.IO.StreamReader(ReceiveStream, Encoding.UTF8))
                {
                    Char[] read = new Char[256];
                    int count = sr.Read(read, 0, 256);
                    while (count > 0)
                    {
                        String str = new String(read, 0, count);
                        Out += str;
                        count = sr.Read(read, 0, 256);
                    }
                }
                req.Abort();
                return Out;
            }
            catch (ArgumentException ex)
            {
                //_log.Error("ArgumentException: ", ex);
                Out = string.Format("REST_HTTP_ERROR :: Ungültiger Parameter in HTTP POST Request :: {0}", ex.Message);
            }
            catch (WebException ex)
            {
                //_log.Error("WebException: ", ex);
                Out = string.Format("REST_HTTP_ERROR :: WebException beim HTTP POST Request :: {0}", ex.Message);
                if (ex.Response != null)
                {
                    Stream dataStream = ex.Response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                 
       
                    return responseFromServer;
                }
            }
            catch (Exception ex)
            {
                //_log.Error("Exception: ", ex);
                Out = string.Format("REST_HTTP_ERROR :: Exception beim HTTP POST Request :: {0}", ex.Message);
            }

            return Out;
        }

        public void HTTP_POST_ABORT()
        {
            if (req != null) req.Abort();

        }

        /// <summary>
        /// HTTP_DELETE Aufruf 
        /// </summary>
        /// <param name="ServerURL">URL für den Aufruf</param>
        /// <param name="timeout">Timeout Wert für Request in Sekunden</param>
        /// <param name="useCertificate">HTTPS ServerZertifikatValidierung durchführen</param>
        /// <returns></returns>
        public virtual string HTTP_DELETE(string ServerURL, int timeout, bool useCertificate = false)
        /*#############################################################################################################################
         * Funktion für HTTP_DELETE's 
        #############################################################################################################################*/
        {

            //_log.Info(string.Format("HTTP_DELETE, URL={0} timeout={1} ssl={2} .", ServerURL, timeout, useCertificate));

            string Out = String.Empty;
            req = (HttpWebRequest)WebRequest.Create(ServerURL);
            try
            {
                // Serverzertifikatsprüfung wird durchgeführt
                if (!useCertificate)
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                // Zertifikat muss bei Nutzung von Clientzertifikaten angegeben werden
                if (useCertificate && CertificateFile != null)
                {
                    X509Certificate cert = X509Certificate.CreateFromCertFile(CertificateFile);
                    req.ClientCertificates.Add(cert);
                }

                req.Method = "DELETE";
                req.Timeout = timeout * 1000;
                WebResponse response = req.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                //JObject MyJsonObject = JObject.Parse(responseFromServer);
                reader.Close();
                response.Close();

                req.Abort();
            }
            catch (ArgumentException ex)
            {
                //_log.Error("ArgumentException: ", ex);
                Out = string.Format("REST_HTTP_ERROR :: Ungültiger Parameter in HTTP DELETE Request :: {0}", ex.Message);
            }
            catch (WebException ex)
            {
                //_log.Error("WebException: ", ex);
                Out = string.Format("REST_HTTP_ERROR :: WebException beim HTTP DELETE Request :: {0}", ex.Message);
            }
            catch (Exception ex)
            {
                //_log.Error("Exception: ", ex);
                Out = string.Format("REST_HTTP_ERROR :: Exception beim HTTP DELETE Request :: {0}", ex.Message);
            }

            //_log.Info(string.Format("HTTP_DELETE, URL={0} Response={1}.", ServerURL, Out));
            return Out;
        }

    }


}
