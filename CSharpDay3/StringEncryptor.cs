using System.Text;

namespace CSharpDay3
{
    public class StringEncryptor
    {
        public static string encrypt(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var result in data)
            {
                char a = (char) (result + 1);
                sb.Append(a);
            }

            return sb.ToString();
        }
        
        public static string decrypt(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var result in data)
            {
                char a = (char) (result-1);
                sb.Append(a);
            }

            return sb.ToString();
        }
    }
}