using DataModel.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebApi.DataContext;
using WebApi.Infrastructure.IRepository;

namespace WebApi.Infrastructure.Repository
{
    public class AmazonLabelOrderListRepository : Repository<AmazonShippingOrderlist> ,IAmazonLabelOrderListRepository
    {
        private readonly ApplicationDbContext _context;

        public AmazonLabelOrderListRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<AmazonShippingOrderlist>> GetAmazonShippingOrderlists()
        {
            return await _context.AmazonShippingOrderlists.ToListAsync();
        }
    }
}
