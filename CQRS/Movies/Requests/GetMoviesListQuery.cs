using CleanWebAPI.Models.MoviesModels;
using MediatR;

namespace CleanWebAPI.CQRS.Movies.Requests
{
    public class GetMoviesListQuery : IRequest<MovieFromSearch>
    {
        public string SearchTerm { get; }

        public GetMoviesListQuery(string searchTerm)
        {
            SearchTerm = searchTerm;
        }
    }
}
