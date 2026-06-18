var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

//Routing

//Orders
//
//reading orders
app.MapGet("/Orders", () =>
{
    return "Return all the orders available";

});
//reading or getting orders on thje basis of id
app.MapGet("/Orders/{id}", (int id) =>
{
    return $"Getting order with id:{id}"; 
});
//creating orders
app.MapPost("/Orders", () =>
{
    return "Order added successfully";
});
//updating orders
app.MapPut("/Orders/{id}",(int id)=>
{
    return $"order with a value {id} is updated";
});
//Deleting orders
app.MapDelete("/Orders/{id}", (int id) => 
{
    return $"ortder with {id} deleted";
});
app.MapPatch("/Orders/{id}", (int id) =>
{
    return $"value with {id} is updated as patch works";
});


app.Run();