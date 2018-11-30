using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Weinrechnerlel.Helper
{
    class Online
    {
        public string ip;
        private static int pingTimeOut = 2500;
        private static int ttl = 500;

        internal static bool OnlineStatus(string ip)
        {
          

                PingOptions po = new PingOptions(ttl, true);
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] data = enc.GetBytes("pingdata");
                Ping p = new Ping();
                try
                {
                    PingReply pr = p.Send(ip, pingTimeOut, data, po);
                    if (pr.Status == IPStatus.Success)
                    {
                        return true;
                    }
                }
                catch (Exception)
            {
                
            }




            return false;
        }
    }
}
