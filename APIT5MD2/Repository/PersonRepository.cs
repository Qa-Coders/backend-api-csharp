using System.Data.SqlClient;
using APIT5MD2.Domain;
using Dapper;

namespace APIT5MD2.Repository
{
    public sealed class PersonRepository : IPersonRepository
    {
        private readonly string _connectionString;
        
        public PersonRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("PersonDataServer");
        }

        public IEnumerable<Person> ListAll()
        {
            using var connection = new SqlConnection(_connectionString);
            var personData = connection.Query<Person>(sql:"SELECT * FROM Person");
            return personData;
        }

        public int Insert(long step)
        {
            using var connection = new SqlConnection(_connectionString);
            var query = "INSERT INTO Person (number) values (@step)";
            var result = connection.Execute(query, param:new { step = step });

            return result;
        }
    }
}
