using MKTMarket.Core.DataAccess.EntityFramework;
using MKTMarket.Northwind.DataAccess.Abstract;
using MKTMarket.Northwind.Entities.Concrete;

namespace MKTMarket.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategorytDal
    {

    }
}
