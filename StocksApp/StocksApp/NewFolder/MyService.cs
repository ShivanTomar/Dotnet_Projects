namespace StocksApp.NewFolder
{
    public class MyService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MyService(IHttpClientFactory httpClientFactory) { 
        
         _httpClientFactory = httpClientFactory;
        }

        public async Task method() {
            using (HttpClient httpclient=_httpClientFactory.CreateClient()) {

                HttpRequestMessage httpRequestMessage = new HttpRequestMessage()
                {

                    RequestUri = new Uri("url"),
                    Method = HttpMethod.Get,

                };
                   HttpResponseMessage  responseMessage=
                    await httpclient.SendAsync(httpRequestMessage);
            }
        }

    }
}
