using System;
using SolrDotnetSample.Domain.Abstractions;

namespace SolrDotnetSample.Domain.Entities
{
    public class Post : Entity<Guid>
    {
        public Post(Guid id, string description, string title, double price, DateTime expiryDate, DateTime postDate, bool isActive, bool isSold)
        {
            SetId(id);
            SetDescription(description);
            SetTitle(title);
            SetPrice(price);
            SetExpiryDate(expiryDate);
            SetPostDate(postDate);
            SetIsActive(isActive);
            SetIsSold(isSold);
        }

        public string Description { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public bool IsActive { get; private set; }
        public bool IsSold { get; private set; }
        public DateTime PostDate { get; private set; }
        public double Price { get; private set; }
        public string Title { get; private set; }

        protected sealed override void SetId(Guid id) => Id = id;
        private void SetDescription(string description) => Description = description;
        private void SetExpiryDate(DateTime expiryDate) => ExpiryDate = expiryDate;
        private void SetIsActive(bool isActive) => IsActive = isActive;
        private void SetIsSold(bool isSold) => IsSold = isSold;
        private void SetPostDate(DateTime postDate) => PostDate = postDate;
        private void SetPrice(double price) => Price = price;
        private void SetTitle(string title) => Title = title;
    }
}