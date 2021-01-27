using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online.Classified.DataAccess
{
    public class Category
    {
        public  DataTable SelectAll()
        {
            string SQLQuery = "Select Id, CategoryImage, Name, Status " +
                                " from Category ";

            SqlCommand command = new SqlCommand(SQLQuery);
            return SQLHelper.ExecuteDataTable(command);


        }
        public static DataTable SelectById(int Id)
        {
            string sql = "Select Id, CategoryImage, Name, Status " +
                                " from Category  where [Id] =@Id ";

            SqlCommand command = new SqlCommand(sql);

            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            return SQLHelper.ExecuteDataTable(command);
        }
        public static bool Update(int Id, string CategoryImage, string Name, bool Status)
        {
            string SQLQuery = "UPDATE Category SET " +
                "CategoryImage = @CategoryImage,Name =@Name, Status=@Status  where Id=@Id";

            SqlCommand command = new SqlCommand(SQLQuery);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@CategoryImage", SqlDbType.VarChar).Value = CategoryImage;
            command.Parameters.Add("@Name", SqlDbType.Text).Value = Name;
            command.Parameters.Add("@Status", SqlDbType.Bit).Value = Status;



            return SQLHelper.ExecuteNonQuery(command);

        }
        public static bool Insert(String categoryImage, String name, bool status)
        {
            string SQLQuery = "INSERT INTO [Category] (CategoryImage, Name, Status ) VALUES	( @categoryImage, @name, @status)";

            SqlCommand command = new SqlCommand();
            command.CommandText = SQLQuery;

            AddParameters(command, categoryImage, name, status);

            return Convert.ToBoolean(SQLHelper.ExecuteNonQuery(command));
        }
        private static void AddParameters(SqlCommand command,  String CategoryImage, String Name, bool Status)
        {
           
            command.Parameters.AddWithValue("@CategoryImage", CategoryImage);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Status", Status);
        }
    }
}
