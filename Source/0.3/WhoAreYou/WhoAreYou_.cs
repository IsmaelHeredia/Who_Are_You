using System;
using System.Collections.Generic;
using System.Text;

using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace WhoAreYou
{
    class WhoAreYou_
    {
        public string Get_IP(string hostname)
        {
            string retorno = "";

            try
            {
                IPAddress[] find = Dns.GetHostAddresses(hostname);
                retorno = find[0].ToString();
            }
            catch
            {
                retorno = "Fuck";
            }

            return retorno;
        }

        public string Get_Hostname()
        {
            string retorno = "";

            try
            {
                retorno = System.Net.Dns.GetHostName();
            }
            catch
            {
                retorno = "Fuck";
            }

            return retorno;
        }

        public string Get_LocalIP()
        {
            string retorno = "";

            try
            {
                retorno = Get_IP(System.Net.Dns.GetHostName());
            }
            catch
            {
                retorno = "Fuck";
            }

            return retorno;
        }

        public string Get_RemoteIP()
        {

            string retorno = "";

            try
            {
                WebClient web = new WebClient();
                web.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";
                string codigofuente = web.DownloadString("http://whatismyipaddress.com/");

                Match founds = Regex.Match(codigofuente, "Click for more about (.*)\">", RegexOptions.IgnoreCase);
                if (founds.Success)
                {
                    retorno = founds.Groups[1].Value;
                }
                else
                {
                    retorno = "Fuck";
                }
            }
            catch
            {
                retorno = "Fuck";
            }

            return retorno;
        }

    }
}
