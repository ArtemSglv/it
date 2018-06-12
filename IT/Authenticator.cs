using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IT
{
    class Authenticator
    {
        public static void Login(string login, string pass)
        {
            DB.Connect();

            string user_str = DB.SelectUser(CalculateMD5Hash(pass), login);

            if (user_str != "")
            {
                var splitArr = user_str.Split(' ');
                CurrentUser.user = new User(Convert.ToInt32(splitArr[0]), splitArr[1], splitArr[2], splitArr[4], splitArr[3]);
               
            }
            else { throw new AuthenticationException("Пользователь не найден!\r\nПроверьте логин и пароль!"); }
        }

        private static string CalculateMD5Hash(string input)
        {

            // step 1, calculate MD5 hash from input

            MD5 md5 = System.Security.Cryptography.MD5.Create();

            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);

            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)

            {

                sb.Append(hash[i].ToString("x2"));

            }

            return sb.ToString();

        }
    }
}
