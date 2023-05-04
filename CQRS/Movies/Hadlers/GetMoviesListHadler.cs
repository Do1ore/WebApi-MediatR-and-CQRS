using CleanWebAPI.CQRS.Movies.Requests;
using CleanWebAPI.Models.MoviesModels;
using MediatR;
using Newtonsoft.Json;
using RestSharp;
using System.Runtime.CompilerServices;

namespace CleanWebAPI.CQRS.Movies.Hadlers
{
    public class GetMoviesListHadler : IRequestHandler<GetMoviesListQuery, MovieFromSearch>
    {
        private readonly ILogger<GetMoviesListHadler> _logger;

        public GetMoviesListHadler(ILogger<GetMoviesListHadler> logger)
        {
            _logger = logger;
        }

        public async Task<MovieFromSearch> Handle(GetMoviesListQuery request, CancellationToken cancellationToken)
        {
            var client = new RestClient();
            MovieFromSearch? result = new();
            try
            {
                // Создаем объект RestRequest с методом GET и указываем URL-адрес ресурса
                var restRequest = new RestRequest("http://www.omdbapi.com", Method.Get);

                // Добавляем параметры запроса, если необходимо
                restRequest.AddParameter("apikey", "da979bab");
                restRequest.AddParameter("s", $"{request.SearchTerm}");

                // Выполняем запрос и получаем ответ
                var response = await client.ExecuteAsync(restRequest);
                await Task.WhenAll();
                if (response.IsSuccessful)
                {
                    result = JsonConvert.DeserializeObject<MovieFromSearch>(response.Content!);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error when receiving a request: {0}", ex.Message);
            }

            _logger.LogInformation("Request for a single movie completed succesfull");

            return result;
        }
    }
}
