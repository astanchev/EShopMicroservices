namespace Catalog.API.Products.CreateProduct;

using BuildingBlocks.CQRS;

using Catalog.API.Models;

using System.Threading;
using System.Threading.Tasks;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price)
    : ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //Buisness logic to create Product

        //Create Product entity from command object
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };

        //TODO save to DB 

        //return CreateProductResult result

        return new CreateProductResult(Guid.NewGuid());
    }
}

