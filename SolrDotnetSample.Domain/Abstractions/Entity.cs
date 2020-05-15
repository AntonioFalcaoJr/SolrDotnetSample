using System.Linq;
using poc_console_solr.Domain.Notifications;

namespace poc_console_solr.Domain.Abstractions
{
    public abstract class Entity<TId>
        where TId : struct
    {
        protected Entity()
        {
            Notification = new Notification();
        }

        public TId Id { get; protected set; }
        public INotification Notification { get; }
        public bool Valid => Notification?.Errors?.Any() == false;

        protected abstract void SetId(TId id);
    }
}