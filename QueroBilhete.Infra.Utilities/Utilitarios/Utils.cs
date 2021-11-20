using System.Net;

namespace QueroBilhete.Infra.Utilities.Utilitarios
{
    public class Utils
    {
        public static bool ChecaConexaoInternet()
        {
            try
            {
                using (var client = new WebClient())
                {
                    WebProxy wp = new WebProxy();
                    client.Proxy = wp;
                    using var stream = client.OpenRead("http://www.google.com");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
