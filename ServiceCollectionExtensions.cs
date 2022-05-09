using ContosoRecipies.Models;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;

namespace ContosoRecipies
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMongoDB(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoDatabaseOptions>(configuration.GetSection("MongoDatabase"));
            services.AddSingleton<IMongoClient>(provider => new MongoClient(configuration["MongoDatabase"]));

            var pack = new ConventionPack();
            pack.Add(new CamelCaseElementNameConvention());

            ConventionRegistry.Register("Custom Convetions", pack, t => true);
            BsonClassMap.RegisterClassMap<Recipie>(cm =>
            {
                cm.AutoMap();
            });
            return services;
        }
    }
}
