using CleanWebAPI.Models.MoviesModels;
using MediatR;

namespace CleanWebAPI.CQRS.Movies.Requests
{
    public class GetMovieQuery : IRequest<Movie>
    {
        public string? SearchTerm { get; }

        public GetMovieQuery(string? searchTerm)
        {
            SearchTerm = searchTerm;
        }
    }
}
