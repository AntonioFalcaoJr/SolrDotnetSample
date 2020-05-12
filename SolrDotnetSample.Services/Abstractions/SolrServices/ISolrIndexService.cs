namespace poc_console_solr.Services.Abstractions.SolrServices
{
    public interface ISolrIndexService<in T>
    {
        bool AddUpdate(T document);
        bool Delete(T document);
    }
}