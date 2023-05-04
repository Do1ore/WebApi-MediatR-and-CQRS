using CleanWebAPI.CQRS.Movies.Requests;
using CleanWebAPI.Models.MoviesModels;
using MediatR;
using Newtonsoft.Json;
using RestSharp;
using System.Runtime.CompilerServices;

namespace CleanWebAPI.CQRS.Movies.Hadlers
{
    public class GetMovieHandler : IRequestHandler<GetMovieQuery, Movie>
    {
        private readonly ILogger<GetMovieHandler> _logger;

        public GetMovieHandler(ILogger<GetMovieHandler> logger)
        {
            _logger = logger;
        }

        public async Task<Movie> Handle(GetMovieQuery request, CancellationToken cancellationToken)
        {
            var client = new RestClient();
            Movie? result = new();
            try
            {
                // Создаем объект RestRequest с методом GET и указываем URL-адрес ресурса
                var restRequest = new RestRequest("http://www.omdbapi.com", Method.Get);

                // Добавляем параметры запроса, если необходимо
                restRequest.AddParameter("apikey", "da979bab");
                restRequest.AddParameter("t", $"{request.SearchTerm}");

                // Выполняем запрос и получаем ответ
                var response = await client.ExecuteAsync(restRequest);
                await Task.WhenAll();
                if (response.IsSuccessful)
                {
                    result = JsonConvert.DeserializeObject<Movie>(response.Content!);
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
