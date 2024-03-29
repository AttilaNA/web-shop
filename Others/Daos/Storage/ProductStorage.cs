using WebShop.Models;

namespace WebShop.Others.Daos.Storage;

public class ProductStorage : IProductDao
{
    private List<Product> Products { get; set; }

    public ProductStorage()
    {
        Products = new List<Product>();
    }

    public void Add(Product item)
    {
        Products.Add(item);
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }

    public Product Get(int id)
    {
        return Products.Select(product => product).FirstOrDefault(product => product.Id == id);
    }

    public IEnumerable<Product> GetAll()
    {
        return Products;
    }

    public IEnumerable<Product> GetBy(Supplier supplier)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetBy(Category category)
    {
        throw new NotImplementedException();
    }
}