using MySql.Data.MySqlClient;

string connectionString =
    "server=127.0.0.1;port=3306;database=world;user=root;password=root;";

PrintTopCountries(connectionString);

static void PrintTopCountries(string connectionString)
{
    using var connection = new MySqlConnection(connectionString);
    connection.Open();

    string sql = @"
        SELECT Code, Name, Continent, Region, Population
        FROM country
        ORDER BY Population DESC
        LIMIT 10;
    ";

    using var command = new MySqlCommand(sql, connection);
    using var reader = command.ExecuteReader();

    Console.WriteLine("Top 10 Countries by Population");
    Console.WriteLine("--------------------------------");

    while (reader.Read())
    {
        Console.WriteLine(
            $"{reader["Code"],-5} {reader["Name"],-35} {reader["Continent"],-15} {reader["Region"],-25} {reader["Population"]}");
    }
}