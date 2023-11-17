using DataModel.Models;

namespace WebApi.Infrastructure.IRepository
{
    public interface IAmazonLabelOrderListRepository : IRepository<AmazonShippingOrderlist>
    {
        Task<IEnumerable<AmazonShippingOrderlist>> GetAmazonShippingOrderlists();
    }
}
