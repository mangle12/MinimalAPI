//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<CustomerRepository>();

//var app = builder.Build();

//app.MapGet("/customers", (CustomerRepository repo) =>
// {
//     return repo.GetAll;
// });

//app.MapGet("/customers/{id}", (CustomerRepository repo, Guid id) =>
//{
//    var customer = repo.GetById(id);
//    return customer is not null ? Results.Ok(customer) : Results.NotFound();
//});

//app.MapPost("/customers", (CustomerRepository repo, Customer customer) =>
//{
//    repo.Create(customer);
//    return Results.Created($"/customers/{customer.Id}", customer);
//});

//app.MapPut("/customers/{id}", (CustomerRepository repo, Guid id, Customer updatedCustomer) =>
//{
//    var customer = repo.GetById(id);
//    if(customer is null)
//    { 
//        return Results.NotFound();
//    }

//    repo.Update(updatedCustomer);
//    return Results.Ok(updatedCustomer);
//});

//app.MapDelete("/customers/{id}", (CustomerRepository repo, Guid id) =>
//{
//    repo.Delete(id);
//    return Results.Ok();
//});


//app.Run();
//record Customer(Guid Id, string FullName);

//class CustomerRepository
//{
//    private readonly Dictionary<Guid, Customer> _customers = new();

//    public void Create(Customer? customer)
//    {
//        if (customer is null)
//        {
//            return;
//        }

//        _customers[customer.Id] = customer;
//    }

//    public Customer? GetById(Guid id)
//    {
//        return _customers.GetValueOrDefault(id);
//    }

//    public List<Customer> GetAll()
//    {
//        return _customers.Values.ToList();
//    }

//    public void Update(Customer customer)
//    {
//        var existingCustomer = GetById(customer.Id);
//        if (existingCustomer is null)
//        {
//            return;
//        }

//        _customers[customer.Id] = customer;
//    }

//    public void Delete(Guid id)
//    {
//        _customers.Remove(id);
//    }
//}