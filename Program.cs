using System.Data.SqlClient;

string connectionString = "Data Source=localhost; Initial Catalog=library-db;" +
    "Integrated Security=True";

AvailableCopies();

void AvailableCopies()
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        try
        {
            connection.Open();
            SqlCommand command = new SqlCommand(
                "SELECT c.id, b.title, b.author, b.year, b.plot, b.age_range, condition.name, c.library_code, c.publisher, c.[language], c.isbn, c.pages " +
                "FROM[copy] AS c " +
                "INNER JOIN book AS b ON c.book_id = b.id " +
                "INNER JOIN condition ON c.condition_id = condition.id " +
                "WHERE c.id NOT IN " +
                "(SELECT copy_id FROM lent WHERE[end] IS NOT NULL OR[end] < GETDATE());",
                connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11}",
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetInt32(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                    reader.GetString(9),
                    reader.GetInt32(10),
                    reader.GetInt32(11));
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}