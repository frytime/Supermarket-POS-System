using System;
using System.Text;
using System.Security.Cryptography;

namespace Sales_System
{
    class Hash
    {

        public static string SaltGenerate(int size)
        {
            //Hello World
            var rng = new RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }


        public static string hashPass(string password, string salt)
        {

            string saltedpass = password + salt;

            SHA1CryptoServiceProvider cryptoServiceProvider = new SHA1CryptoServiceProvider();

            byte[] passbytes = Encoding.ASCII.GetBytes(saltedpass);

            byte[] hashedpass = cryptoServiceProvider.ComputeHash(passbytes);

            return Convert.ToBase64String(hashedpass);

        }

    }
}
