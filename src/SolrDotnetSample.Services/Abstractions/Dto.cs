namespace SolrDotnetSample.Services.Abstractions
{
    public abstract class Dto<TId>
        where TId : struct
    {
        public TId Id { get; set; }
    }
}