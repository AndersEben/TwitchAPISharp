using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TwitchAPISharp.Options;

namespace TwitchAPISharp.Data
{
    class Functions
    {
        public static WebClient CreateWebclient(string clientID, TokenType type, string token, bool uplaod=false)
        {
            WebClient webClient = new WebClient();

            if (clientID != null)
                webClient.Headers.Add("Client-ID", clientID);
            if (token != null)
                webClient.Headers.Add("Authorization", type.ToString() + " " + token);
            if (uplaod)
                webClient.Headers.Add("Content-Type", "application/json");

            webClient.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko)");
            webClient.Proxy = WebRequest.DefaultWebProxy;

            return webClient;
        }

        public static async Task<string> GETRequest(string token, string clientID,string url, TokenType type = TokenType.Bearer)
        {

            WebClient _wc = CreateWebclient(clientID,type,token);

            string result = null;

            _wc.DownloadStringCompleted += (o, e) =>
            {
                try
                {
                    result = e.Result;
                }
                catch (Exception)
                {
                    result = null;
                }
            };

            await _wc.DownloadStringTaskAsync(url);

            return result;

        }

        public static async Task<string> POSTRequest(string token, string clientID, string url,string data,TokenType type = TokenType.Bearer )
        {

            WebClient _wc = CreateWebclient(clientID, type, token, true);

            byte[] result = null;

            _wc.UploadDataCompleted += (o, e) =>
            {
                try
                {
                    result = e.Result;
                }
                catch (Exception)
                {
                    result = null;
                }
            };

            var ttt = await _wc.UploadDataTaskAsync(url, "POST", System.Text.Encoding.UTF8.GetBytes(data));

            return System.Text.Encoding.UTF8.GetString(result);

        }

        public static async Task<string> PUTRequest(string token, string clientID, string url, string data, TokenType type = TokenType.Bearer)
        {

            WebClient _wc = CreateWebclient(clientID, type, token, true);

            byte[] result = null;

            _wc.UploadDataCompleted += (o, e) =>
            {
                try
                {
                    result = e.Result;
                }
                catch (Exception)
                {
                    result = null;
                }
            };

            var ttt = await _wc.UploadDataTaskAsync(url, "PUT", System.Text.Encoding.UTF8.GetBytes(data));

            return System.Text.Encoding.UTF8.GetString(result);

        }

        public static async Task<string> PATCHRequest(string token, string clientID, string url, string data, TokenType type = TokenType.Bearer)
        {

            WebClient _wc = CreateWebclient(clientID, type, token, true);

            byte[] result = null;

            _wc.UploadDataCompleted += (o, e) =>
            {
                try
                {
                    result = e.Result;
                }
                catch (Exception)
                {
                    result = null;
                }
            };

            var ttt = await _wc.UploadDataTaskAsync(url, "PATCH", System.Text.Encoding.UTF8.GetBytes(data));

            return System.Text.Encoding.UTF8.GetString(result);
        }

        public static async Task<string> DELETERequest(string token, string clientID, string url, string data, TokenType type = TokenType.Bearer)
        {

            WebClient _wc = CreateWebclient(clientID, type, token, true);

            byte[] result = null;

            _wc.UploadDataCompleted += (o, e) =>
            {
                try
                {
                    result = e.Result;
                }
                catch (Exception)
                {
                    result = null;
                }
            };

            var ttt = await _wc.UploadDataTaskAsync(url, "DELETE", System.Text.Encoding.UTF8.GetBytes(data));

            return System.Text.Encoding.UTF8.GetString(result);
        }

        public static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

    }
}
