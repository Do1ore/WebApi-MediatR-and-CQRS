namespace CleanWebAPI.Models.MoviesModels
{

    public class MovieFromSearch
    {
        public List<Search> Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
    }
}
