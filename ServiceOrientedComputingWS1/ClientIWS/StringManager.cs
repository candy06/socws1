
namespace ClientIWS
{
    class StringManager
    {
        public string Trunc(string str, int maxLength)
        {
            if (str.Length >= maxLength)
            {
                string subString = str.Substring(0, maxLength);
                string result = subString + "...";
                return result;
            }
            return str;
        }
    }
}
