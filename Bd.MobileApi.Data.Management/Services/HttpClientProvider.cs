using Android.Net;
using System;
using System.Net;
using System.Net.Http;

namespace Bd.MobileApi.Data.Management
{
    public static class HttpClientProvider
    {
        public static HttpClient Client;

        public static string BaseUrl;

        static HttpClientProvider()
        {
            ServicePointManager.ServerCertificateValidationCallback += (o, cert, chain, errors) => true;
            Client = new HttpClient(new HttpClientHandler());
            BaseUrl = @"http://10.0.2.2:5000/Api/";
        }



        public static string AppUsersUrl => "AppUsers/GetAppUsers";



        public static  string ProductUrl => "Products/GetProducts";
        public static HttpClient Create()
        {
            return Client;
        }
    }
}
