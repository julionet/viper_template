using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace VIPER.Service
{
    public static class WebapiSerializer
    {
        public static U HttpPost<T, U>(T objeto, string uri, string metodo)
        {
            uri = metodo == "" ? uri.Remove(uri.Length - 1) : uri;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Global.Instance.UsuarioAPI}:{Global.Instance.SenhaAPI}")));

                HttpResponseMessage result = client.PostAsJsonAsync(metodo, objeto).Result;
                if (result.IsSuccessStatusCode)
                    return result.Content.ReadAsAsync<U>().Result;
                else
                    return default;
            }
        }

        public static U HttpPut<T, U>(T objeto, string uri, string metodo)
        {
            uri = metodo == "" ? uri.Remove(uri.Length - 1) : uri;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Global.Instance.UsuarioAPI}:{Global.Instance.SenhaAPI}")));

                HttpResponseMessage result = client.PutAsJsonAsync(metodo, objeto).Result;
                if (result.IsSuccessStatusCode)
                    return result.Content.ReadAsAsync<U>().Result;
                else
                    return default;
            }
        }

        public static string HttpDelete(string uri, string metodo)
        {
            uri = metodo == "" ? uri.Remove(uri.Length - 1) : uri;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Global.Instance.UsuarioAPI}:{Global.Instance.SenhaAPI}")));

                HttpResponseMessage result = client.DeleteAsync(metodo).Result;
                if (result.IsSuccessStatusCode)
                    return result.Content.ReadAsAsync<string>().Result;
                else
                    return default;
            }
        }

        public static T HttpGet<T>(string uri, string metodo)
        {
            uri = metodo == "" ? uri.Remove(uri.Length - 1) : uri;
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri(uri);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{Global.Instance.UsuarioAPI}:{Global.Instance.SenhaAPI}")));

                    HttpResponseMessage response = client.GetAsync(metodo).Result;
                    if (response.IsSuccessStatusCode)
                        return response.Content.ReadAsAsync<T>().Result;
                    else
                        return default;
                }
                catch
                {
                    return default;
                }
            }
        }
    }
}
