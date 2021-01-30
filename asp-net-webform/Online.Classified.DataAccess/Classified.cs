using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Classified.DataAccess
{
    public class Classified
    {
        public DataTable SelectAll()
        {
            string SQLQuery = "Select TOP 4 Id, CategoryId, Title, PictureUrl, Description, Location, Price, PhoneNumber, IsRecommended" +
                                " from Classified ";

            SqlCommand command = new SqlCommand(SQLQuery);
            return SQLHelper.ExecuteDataTable(command);


        }
        public DataTable SelectById(int Id)
        {
            string sql = "Select Id, CategoryId, Title, PictureUrl, Description, Location, Price, PhoneNumber, IsRecommended " +
                                " from Classified  where [Id] =@Id ";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            return SQLHelper.ExecuteDataTable(command);
        }
        public DataTable SelectByCategoryId(int CategoryId)
        {
            string sql = "Select TOP 4 * " +
                                " from Classified  where [CategoryId] =@CategoryId";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = CategoryId;
            return SQLHelper.ExecuteDataTable(command);
        }
        public DataTable SelectRecommended()
        {
            string sql = "Select TOP 4 * " +
                                " from Classified  where [IsRecommended] =@CategoryId";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.Add("@CategoryId", SqlDbType.Bit).Value = true;
            return SQLHelper.ExecuteDataTable(command);
        }
        public static bool Update(int Id, string CategoryId, string Title, string PictureUrl, string Description, string Location, string Price, string PhoneNumber, bool IsRecommended)
        {
            string SQLQuery = "UPDATE Classified SET " +
                "CategoryId = @CategoryId,Title =@Title, PictureUrl=@PictureUrl,Description=@Description,Location=@Location, Price=@Price,PhoneNumber=@PhoneNumber, IsRecommended=@IsRecommended    where Id=@Id";

            SqlCommand command = new SqlCommand(SQLQuery);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@CategoryId", SqlDbType.Int).Value = CategoryId;
            command.Parameters.Add("@Title", SqlDbType.Text).Value = Title;
            command.Parameters.Add("@PictureUrl", SqlDbType.Text).Value = PictureUrl;
            command.Parameters.Add("@Description", SqlDbType.Text).Value = Description;
            command.Parameters.Add("@Location", SqlDbType.Text).Value = Location;
            command.Parameters.Add("@Price", SqlDbType.Text).Value = Price;
            command.Parameters.Add("@PhoneNumber", SqlDbType.Text).Value = PhoneNumber;
            command.Parameters.Add("@IsRecommended", SqlDbType.Bit).Value = IsRecommended;



            return SQLHelper.ExecuteNonQuery(command);

        }
        public static bool Insert(string CategoryId, string Title, string PictureUrl, string Description, string Location, string Price, string PhoneNumber, bool IsRecommended)
        {
            string SQLQuery = "INSERT INTO [Category] ( CategoryId, Title, PictureUrl, Description, Location, Price, PhoneNumber, IsRecommended ) VALUES	(@CategoryId, @Title, @PictureUrl, @Description, @Location, @Price, @PhoneNumber, @IsRecommended)";

            SqlCommand command = new SqlCommand();
            command.CommandText = SQLQuery;

            AddParameters(command, CategoryId, Title, PictureUrl, Description, Location, Price, PhoneNumber, IsRecommended);

            return Convert.ToBoolean(SQLHelper.ExecuteNonQuery(command));
        }
        private static void AddParameters(SqlCommand command, string CategoryId, string Title, string PictureUrl, string Description, string Location, string Price, string PhoneNumber, bool IsRecommended)
        {
            command.Parameters.AddWithValue("@CategoryId", CategoryId);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@PictureUrl", PictureUrl);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Location", Location);
            command.Parameters.AddWithValue("@Price", Price);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@IsRecommended", IsRecommended);
        }
    }
}
