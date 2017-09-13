using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mohamed.Dawood
{
    public static class Encryption
    {
        public static string GenerateHash(string Text)
        {
            byte[] tmpSource = ASCIIEncoding.UTF8.GetBytes(Text);
            StringBuilder byts = new StringBuilder();
            foreach (var ch in tmpSource)
            {
                byts.Append(ch);
            }
            Text = byts.ToString();
            byts.Clear();
            var sqrt = (int)Math.Sqrt(Text.Length);
            var sumx = 0;
            var sumy = 0;
            for (int i = 0; i < sqrt; i++)
            {
                for (int x = 0; x < sqrt; x++)
                {
                    sumx += int.Parse(Text[sqrt * i + x].ToString());
                    sumy += int.Parse(Text[sqrt * x + i].ToString());
                }
                byts.Append(sumx);
                byts.Append(sumy);
                sumy = 0;
                sumx = 0;
            }
            if (sqrt * sqrt < Text.Length)
                byts.Append(Text.Substring(sqrt * sqrt));


            tmpSource = Encoding.UTF8.GetBytes(byts.ToString());
            byts.Clear();
            HashAlgorithm algorithm = SHA256.Create();
            byte[] tmpHash;
            tmpHash = algorithm.ComputeHash(tmpSource);
            for (int i = 0; i < tmpHash.Length; i++)
            {
                byts.Append(tmpHash[i].ToString("X2"));
            }
            return byts.ToString();
        }
    }
}
