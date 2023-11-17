namespace WebApi.Infrastructure.IRepository
{
    public interface IUnitofWork
    {
        IEmployeeRepository Employee { get; }
        IAmazonLabelOrderListRepository AmazonLabelOrderList { get; }
        void Save();
    }
}
