using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace BdMobApp.ViewModelServices
{
    public static class HttpsValidation
    {
        static string PUBLIC_KEY = @"https://10.0.2.2:44301";
        public static void Initialize()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            // ServicePointManager.ServerCertificateValidationCallback = OnValidateCertificate;  
            //Generate Public Key and replace publickey variable   
            //  ServicePointManager.ServerCertificateValidationCallback = GenerateSSLPublicKey;  
            ServicePointManager.ServerCertificateValidationCallback = OnValidateCertificate;

        }


        public static bool OnValidateCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            var certPublicString = certificate?.GetPublicKeyString();
            var keysMatch = PUBLIC_KEY == certPublicString;
            return keysMatch;
        }

        static string GenerateSSLPublicKey(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            string certPublicString = certificate?.GetPublicKeyString();
            return certPublicString;
        }
    }
}
