using BuildingBlocks.CQRS;
using CatalogAPI.Models;
using MediatR;
using System.ComponentModel;

namespace CatalogAPI.Products.CreateProduct;

public record CreateProductCommand(string Name, List<string> Category, string Description, string ImageFile, decimal Price ) : ICommand<CreateProductResult>;
public record CreateProductResult(Guid Id);

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //1.create Product entity from command object
        //2.save to database
        //3.return CreateProductResult result

        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price,
        };
        //TODO
        //2.save to database

        //3.return CreateProductResult result


        return new CreateProductResult(Guid.NewGuid());

        throw new NotImplementedException();
    }
}
