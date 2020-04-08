using Android.Net;
using System;
using System.Net;
using System.Net.Http;

namespace Bd.MobileApi.Data.Management
{
    public static class HttpClientProvider
    {
        public static HttpClient Client = new HttpClient();

        public static string BaseUrl;

        static HttpClientProvider()
        {
            ServicePointManager.ServerCertificateValidationCallback += (o, cert, chain, errors) => true;
            Client = new HttpClient(new HttpClientHandler());
            BaseUrl = @"https://10.0.2.2:44301/Api/";
        }



        public static string AppUsersUrl => "AppUsers";



        public static  string ProductUrl => "Products";
        public static HttpClient Create()
        {
            return Client;
        }
    }
}
