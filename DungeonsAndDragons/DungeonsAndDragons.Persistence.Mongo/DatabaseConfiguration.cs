using System;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson.Serialization;
using DungeonsAndDragons.Persistence.Contracts;

namespace DungeonsAndDragons.Persistence.Mongo
{
    public class DatabaseConfiguration : IDatabaseConfiguration
    {
        static DatabaseConfiguration()
        {
            BsonSerializer.RegisterSerializationProvider(new ObjectIdentifierSerializer());
        }

        public DatabaseConfiguration(IConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            this.ConnectionString = configuration["Mongo:ConnectionString"];
            this.Database = configuration["Mongo:Database"];
        }

        public string ConnectionString { get; }

        public string Database { get; }
    }
}
