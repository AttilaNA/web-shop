using WebShop.Models;
using WebShop.Others.Storage;

namespace WebShop.Others.Services;

public class WebShopService : IWebShopService
{
    private readonly IProductDao _productStorage;

    private readonly ICategoryDao _categoryStorage;

    private readonly ISupplierDao _supplierStorage;
    
    public WebShopService(IProductDao productStorage, ICategoryDao categoryStorage, ISupplierDao supplierStorage)
    {
        _productStorage = productStorage;
        _categoryStorage = categoryStorage;
        _supplierStorage = supplierStorage;
    }
    
    public Category GetProductCategory(int categoryId)
    {
        return _categoryStorage.Get(categoryId);
    }

    public IEnumerable<Product> GetProductsForCategory(int categoryId)
    {
        Category category = _categoryStorage.Get(categoryId);
        return _productStorage.GetBy(category);
    }
}