using MediatR;
using OnlinesShop.Core.Entities;
using OnlinesShop.Infrastructure.Contexts;

namespace OnlinesShop.Application.CQRS.ProductCommandQuery.Command;

public class SaveProductCommand : IRequest<SaveProductCommandResponse>
{
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public long Price { get; set; }
    public string Description { get; set; }
}

public class SaveProductCommandResponse
{
    public int ProductId { get; set; }
}

public class SaveProductCommandHandler : IRequestHandler<SaveProductCommand, SaveProductCommandResponse>
{
    private readonly OnlineShopDbContext _onlineShopDbContext;

    public SaveProductCommandHandler(OnlineShopDbContext onlineShopDbContext)
    {
        _onlineShopDbContext = onlineShopDbContext;
    }
    public async Task<SaveProductCommandResponse> Handle(SaveProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product
        {
            ProductName = request.ProductName,
            Price = request.Price,
        };
        await _onlineShopDbContext.Products.AddAsync(product);
        await _onlineShopDbContext.SaveChangesAsync();

        var response = new SaveProductCommandResponse
        {
            ProductId = product.Id
        };

        return response;
    }
}
