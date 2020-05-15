namespace poc_console_solr.Services.Models
{
    public abstract class Model<TId>
        where TId : struct
    {
        public virtual TId? Id { get; set; }
    }
}