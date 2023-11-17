using WebApi.DataContext;
using WebApi.Infrastructure.IRepository;

namespace WebApi.Infrastructure.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private ApplicationDbContext _context;

        public IEmployeeRepository Employee { get; private set; }
        public IAmazonLabelOrderListRepository AmazonLabelOrderList { get; private set; }

        public UnitofWork(ApplicationDbContext context)
        {
            _context = context;

            Employee = new EmplyeeRepository(context);
            AmazonLabelOrderList = new AmazonLabelOrderListRepository(context);

        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
