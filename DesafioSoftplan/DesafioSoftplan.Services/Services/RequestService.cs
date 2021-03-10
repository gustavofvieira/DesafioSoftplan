using Newtonsoft.Json;
using RestSharp;

namespace DesafioSoftplan.Services.Services
{
    public class RequestService
    {
        protected readonly IAcessInfo _accessInfo;
        public RequestService(IAcessInfo accessInfo)
        {
            _accessInfo = accessInfo;
        }

        private static IRestRequest CreateRestRequest(string path, Method method, object payload = null, List<Parameter> parameters = null)
        {
            var request = RequestEngine.CreateRequest(path, method);

            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new CustomSerializer(new JsonSerializer());
            request.AddHeader("Content-Type", "application/json");

            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    request.AddParameter(param);
                }
            }

            if (payload == null) return request;

            if (method != Method.GET && method != Method.DELETE)
            {
                request.AddBody(payload);
            }

            return request;
        }

        public virtual TEntity MakeRequest<TEntity>(string path, Method method, object payload = null, List<Parameter> parameters = null)
        {
            var request = CreateRestRequest(path, method, payload, parameters);

            var client = RequestEngine.CreateClient(_accessInfo);

            var response = RequestEngine.ExecuteRequest<TEntity>(client, request, _accessInfo);

            return response;
        }
    }
}
