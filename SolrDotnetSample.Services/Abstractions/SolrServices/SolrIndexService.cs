using System;
using SolrNet;
using SolrNet.Exceptions;

namespace poc_console_solr.Services.Abstractions.SolrServices
{
    public abstract class SolrIndexService<T, TSolrOperations> : ISolrIndexService<T>
        where TSolrOperations : ISolrOperations<T>
    {
        private readonly TSolrOperations _solr;

        protected SolrIndexService(ISolrOperations<T> solr)
        {
            _solr = (TSolrOperations) solr;
        }

        public bool AddUpdate(T document)
        {
            try
            {
                // If the id already exists, the record is updated, otherwise added                         
                var responseHeader = _solr.Add(document);
                
                if(responseHeader.Status != 0)
                    throw new Exception("error");
                    
                _solr.Commit();
                return true;
            }
            catch (SolrNetException ex)
            {
                //Log exception
                throw ex;
                return false;
            }
        }

        public bool Delete(T document)
        {
            try
            {
                //Can also delete by id                
                _solr.Delete(document);
                _solr.Commit();
                return true;
            }
            catch (SolrNetException ex)
            {
                //Log exception
                return false;
            }
        }
    }
}