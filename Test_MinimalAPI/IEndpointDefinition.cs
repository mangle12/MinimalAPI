namespace Test_MinimalAPI
{
    public interface IEndpointDefinition
    {
        void DefineServices(IServiceCollection services);

        void DefineEndpoints(WebApplication app);
    }
}
