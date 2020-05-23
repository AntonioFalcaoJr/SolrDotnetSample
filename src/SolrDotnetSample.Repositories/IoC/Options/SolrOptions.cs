namespace SolrDotnetSample.Repositories.IoC.Options
{
    public class SolrOptions
    {
        public string BaseAddress { get; set; }
        public string Core { get; set; }
        public string Url => BaseAddress + Core;
    }
}