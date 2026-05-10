using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace LibraryDataAccess
{
    public class clsBooksDataAccess
    {
        public static DataTable GetListOfBooks()
        {
            DataTable dtAllBooks = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllBooks", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllBooks.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                }

            }
            return dtAllBooks;
        }

        public static DataTable GetListOfAvailableCopies()
        {
            DataTable dtAllBooks = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAvailableCopies", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllBooks.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                }

            }
            return dtAllBooks;
        }

        public static DataTable GetListOfAllCopies()
        {
            DataTable dtAllBooks = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_AllCopiesWithStatus", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllBooks.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                }

            }
            return dtAllBooks;
        }



        public static BookDTO FindBookInfoByID(int ID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_FindBookByID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookID", ID);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var PhotoOrdinal = reader.GetOrdinal("PhotoURL");
                            string PhotoURL = reader.IsDBNull(PhotoOrdinal) ? "" : reader.GetString(PhotoOrdinal);
                            return new BookDTO(
                                reader.GetInt32(reader.GetOrdinal("BookID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("ISBN")),
                                reader.GetDateTime(reader.GetOrdinal("PublicationDate")),
                                reader.GetString(reader.GetOrdinal("Language")),
                                reader.GetInt32(reader.GetOrdinal("NumberOfPages")),
                                reader.GetInt32(reader.GetOrdinal("Price")),
                                reader.GetInt32(reader.GetOrdinal("Edition")),
                                reader.GetString(reader.GetOrdinal("Bio")),
                                PhotoURL
                                );
                        }

                    }


                }
            }
            return null;
        }

        public static BookDTO FindBookInfoByTitle(string Title)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetBookInfosByTitle", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", Title);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var PhotoOrdinal = reader.GetOrdinal("PhotoURL");
                            string PhotoURL = reader.IsDBNull(PhotoOrdinal) ? "" : reader.GetString(PhotoOrdinal);
                            return new BookDTO(
                                reader.GetInt32(reader.GetOrdinal("BookID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("ISBN")),
                                reader.GetDateTime(reader.GetOrdinal("PublicationDate")),
                                reader.GetString(reader.GetOrdinal("Language")),
                                reader.GetInt32(reader.GetOrdinal("NumberOfPages")),
                                reader.GetInt32(reader.GetOrdinal("Price")),
                                reader.GetInt32(reader.GetOrdinal("Edition")),
                                reader.GetString(reader.GetOrdinal("Bio")),
                                PhotoURL
                                );
                        }

                    }


                }
            }
            return null;
        }

      
        public static CopyBookDTO FindFirstAvailableCopy(string Title, string Format = "Physical")
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_SearchForFirstCopyByTitle", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", Title);
                    cmd.Parameters.AddWithValue("@Format", Format);
                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var PhotoOrdinal = reader.GetOrdinal("PhotoURL");
                            string PhotoURL = reader.IsDBNull(PhotoOrdinal) ? "" : reader.GetString(PhotoOrdinal);
                            return new CopyBookDTO(
                                reader.GetInt32(reader.GetOrdinal("BookID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("ISBN")),
                                reader.GetDateTime(reader.GetOrdinal("PublicationDate")),
                                reader.GetString(reader.GetOrdinal("Language")),
                                reader.GetInt32(reader.GetOrdinal("NumberOfPages")),
                                reader.GetInt32(reader.GetOrdinal("Price")),
                                reader.GetInt32(reader.GetOrdinal("Edition")),
                                reader.GetString(reader.GetOrdinal("Bio")),
                                PhotoURL ,
                                reader.GetInt32(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("FormatName")),
                                reader.GetString(reader.GetOrdinal("StatusName"))
                                );
                        }

                    }


                }
            }
            return null;
        }

        public static CopyBookDTO FindFirstAvailableCopy(int BookID, string Format = "Physical")
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("FindFirstAvaialableCopyByBookID", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookID", BookID);
                    cmd.Parameters.AddWithValue("@Format", Format);
                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var PhotoOrdinal = reader.GetOrdinal("PhotoURL");
                            string PhotoURL = reader.IsDBNull(PhotoOrdinal) ? "" : reader.GetString(PhotoOrdinal);
                            return new CopyBookDTO(
                                reader.GetInt32(reader.GetOrdinal("BookID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("ISBN")),
                                reader.GetDateTime(reader.GetOrdinal("PublicationDate")),
                                reader.GetString(reader.GetOrdinal("Language")),
                                reader.GetInt32(reader.GetOrdinal("NumberOfPages")),
                                reader.GetInt32(reader.GetOrdinal("Price")),
                                reader.GetInt32(reader.GetOrdinal("Edition")),
                                reader.GetString(reader.GetOrdinal("Bio")),
                                PhotoURL,
                                reader.GetInt32(reader.GetOrdinal("CopyID")),
                                reader.GetString(reader.GetOrdinal("FormatName")),
                                reader.GetString(reader.GetOrdinal("StatusName"))
                                );
                        }

                    }


                }
            }
            return null;
        }
       

        public static CopyBookDTO FindCopyByID(int ID, BookDTO DTO)
        {

            if (DTO == null)
            {
                throw new Exception("Book DTO is null , try the other overloaded method");
            }

            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetCopyInfo", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CopyID", ID);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new CopyBookDTO(
                                DTO,
                                reader.GetInt32(reader.GetOrdinal("CopyID")),
                                reader.GetString(reader.GetOrdinal("FormatName")),
                                reader.GetString(reader.GetOrdinal("StatusName"))
                                );
                        }

                    }


                }
            }
            return null;
        }

        public static int BorrowBookCopy(int CopyID, int UserID, DateTime BorrowingDate, DateTime ReturnDate)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddBookToBorrowedBooks", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@CopyBookID", CopyID);
                command.Parameters.AddWithValue("@BDate", BorrowingDate);
                command.Parameters.AddWithValue("@RDate", ReturnDate);

                var outputIdParam = new SqlParameter("@BorrowID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                return (int)outputIdParam.Value;
            }
        }

        public static DataTable GetCategorizedBooksList()
        {
            DataTable dtAllBooks = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllCategorizedBooks", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllBooks.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return dtAllBooks;
        }



        public static DataTable GetAllCopies()
        {
            DataTable dtAllBooks = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select * from CopiesView order by CopyID desc", conx))
                {
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllBooks.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                }

            }
            return dtAllBooks;
        }

        public static DataTable GetAllCopiesForOneBook(int BookID)
        {
            DataTable dtAllBooks = new DataTable();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllCopiesOfSpecificBook", conx))
                {
                    cmd.Parameters.AddWithValue("@BookID", BookID);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (reader.HasRows)
                            {
                                dtAllBooks.Load(reader);
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                    }


                }

            }
            return dtAllBooks;
        }

        public static CopyBookDTO FindCopyByID(int CopyID)
        {
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetCopyInfoAttachedToOriginalBook", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CopyID", CopyID);

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var PhotoOrdinal = reader.GetOrdinal("PhotoURL");
                            string PhotoURL = reader.IsDBNull(PhotoOrdinal) ? "" : reader.GetString(PhotoOrdinal);
                            return new CopyBookDTO(
                                reader.GetInt32(reader.GetOrdinal("BookID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("ISBN")),
                                reader.GetDateTime(reader.GetOrdinal("PublicationDate")),
                                reader.GetString(reader.GetOrdinal("Language")),
                                reader.GetInt32(reader.GetOrdinal("NumberOfPages")),
                                reader.GetInt32(reader.GetOrdinal("Price")),
                                reader.GetInt32(reader.GetOrdinal("Edition")),
                                reader.GetString(reader.GetOrdinal("Bio")),
                                PhotoURL,
                                reader.GetInt32(reader.GetOrdinal("CopyID")),
                                reader.GetString(reader.GetOrdinal("FormatName")),
                                reader.GetString(reader.GetOrdinal("StatusName"))
                                );
                        }

                    }


                }
            }
            return null;
        }
        public static int AddNewBook(string title, string iSBN, DateTime publicationDate, string language, int numberOfPages, double price, int edition, string Bio, string PhotoURL = "")
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddBook", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@ISBN", iSBN);
                command.Parameters.AddWithValue("@PublicationDate", publicationDate);
                command.Parameters.AddWithValue("@Language", language);
                command.Parameters.AddWithValue("@NumberOfPages", numberOfPages);
                command.Parameters.AddWithValue("@Edition", edition);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Bio", Bio);
                if (string.IsNullOrEmpty(PhotoURL))
                {
                    command.Parameters.AddWithValue("@PhotoURL", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@PhotoURL", PhotoURL);
                }



                var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                return (int)outputIdParam.Value;
            }


        }

        public static bool AddCopies(int NumberOfCopies, int BookID, int FormatID)
        {
            try
            {
                using (var connection = new SqlConnection(clsConnection.ConnectionString))
                using (var command = new SqlCommand("SP_AddBookCopy", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BookID", BookID);
                    command.Parameters.AddWithValue("@FormatID", FormatID);
                    command.Parameters.AddWithValue("@NumberOfCopies", NumberOfCopies);

                    var outputIdParam = new SqlParameter("@ReturnValue", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputIdParam);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return (int)outputIdParam.Value == 1;

                }
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public static Dictionary<string, int> GetAllCategories()
        {
            Dictionary<string, int> DicCategories = new Dictionary<string, int>();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetCategories", conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!DicCategories.ContainsKey(reader.GetString(reader.GetOrdinal("Name"))))
                            {
                                DicCategories.Add(reader.GetString(reader.GetOrdinal("Name")), reader.GetInt32(reader.GetOrdinal("ID")));
                            }
                        }
                    }
                }
            }
            return DicCategories;
        }

        public static bool AddBookToCategory(int BookID, int CategoryID)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_AddBookToCategory", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookID", BookID);
                command.Parameters.AddWithValue("@CategoryID", CategoryID);

                var outputIdParam = new SqlParameter("@NewID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                return (int)outputIdParam.Value > 0;

            }
        }

        public static bool UpdateBook(int iD, string title, string iSBN, DateTime publicationDate, string language, int numberOfPages,
            double price, int edition, string photoURL, string bio)
        {
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_UpdateBook", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookID", iD);
                command.Parameters.AddWithValue("@Title", title);
                command.Parameters.AddWithValue("@ISBN", iSBN);
                command.Parameters.AddWithValue("@PublicationDate", publicationDate);
                command.Parameters.AddWithValue("@Language", language);
                command.Parameters.AddWithValue("@NumberOfPages", numberOfPages);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Edition", edition);
                command.Parameters.AddWithValue("@PhotoURL", photoURL);
                command.Parameters.AddWithValue("@Bio", bio);

                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
        }

        public static bool IsThisBookCategorized(int BookID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsThisBookCategorized", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookID", BookID);

                    try
                    {
                        
                        SqlDataReader reader = cmd.ExecuteReader();

                        isFound = reader.HasRows;
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return isFound;
                }
            }
        }

        public static bool DeleteBook(int bookId)
        {
            int rowsAffected = -1;
            using (var connection = new SqlConnection(clsConnection.ConnectionString))
            using (var command = new SqlCommand("SP_DeleteBook", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BookID", bookId);

                try
                {
                    connection.Open();

                     rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                }
              
                return (rowsAffected > 0);
            }
        }
        public static bool IsThisBookLinkedAlreadyToThisCategory(int BookID,int CategoryID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_IsBookLinkedToThisCategory", connection))
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@BookID", BookID);
                    cmd.Parameters.AddWithValue("@CategoryID", BookID);

                    try
                    {

                        SqlDataReader reader = cmd.ExecuteReader();

                        isFound = reader.HasRows;
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                    }
                    finally
                    {
                        connection.Close();
                    }
                    return isFound;
                }
            }
        }

        public static List<BookDTO> GetBooksListForAPI()
        {
            List<BookDTO> liBooks = new List<BookDTO>();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_RetriveBooksList",conx))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var PhotoOrdinal = reader.GetOrdinal("PhotoURL");
                            string PhotoURL = reader.IsDBNull(PhotoOrdinal) ? "" : reader.GetString(PhotoOrdinal);

                            liBooks.Add(new BookDTO(reader.GetInt32(reader.GetOrdinal("BookID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("ISBN")),
                                reader.GetDateTime(reader.GetOrdinal("PublicationDate")),
                                reader.GetString(reader.GetOrdinal("Language")),
                                reader.GetInt32(reader.GetOrdinal("NumberOfPages")),
                                Convert.ToDouble(reader.GetInt32(reader.GetOrdinal("Price"))),
                                reader.GetInt32(reader.GetOrdinal("Edition")),
                                reader.GetString(reader.GetOrdinal("Bio")),
                                PhotoURL
                                ));
                        }
                    }
                }
            }
            return liBooks;
        }

        

       

        
      

        public static List<CopyBookDTO> GetAllCopiesAsDTO()
        {
            List<CopyBookDTO> liCopies = new List<CopyBookDTO>();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select * from CopiesView order by CopyID desc", conx))
                {
                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var PhotoOrdinal = reader.GetOrdinal("PhotoURL");
                            string PhotoURL = reader.IsDBNull(PhotoOrdinal) ? "" : reader.GetString(PhotoOrdinal);

                            liCopies.Add(new CopyBookDTO(
                                reader.GetInt32(reader.GetOrdinal("BookID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("ISBN")),
                                reader.GetDateTime(reader.GetOrdinal("PublicationDate")),
                                reader.GetString(reader.GetOrdinal("Language")),
                                reader.GetInt32(reader.GetOrdinal("NumberOfPages")),
                                reader.GetInt32(reader.GetOrdinal("Price")),
                                reader.GetInt32(reader.GetOrdinal("Edition")),
                                reader.GetString(reader.GetOrdinal("Bio")),
                                PhotoURL,
                                reader.GetInt32(reader.GetOrdinal("CopyID")),
                                reader.GetString(reader.GetOrdinal("FormatName")),
                                reader.GetString(reader.GetOrdinal("StatusName"))
                            ));
                        }
                    }
                }
            }
            return liCopies;
        }

        public static List<CopyBookDTO> GetAllCopiesForOneBookAsDTO(int BookID)
        {
            List<CopyBookDTO> liCopies = new List<CopyBookDTO>();
            using (SqlConnection conx = new SqlConnection(clsConnection.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAllCopiesOfSpecificBook", conx))
                {
                    cmd.Parameters.AddWithValue("@BookID", BookID);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var PhotoOrdinal = reader.GetOrdinal("PhotoURL");
                            string PhotoURL = reader.IsDBNull(PhotoOrdinal) ? "" : reader.GetString(PhotoOrdinal);

                            liCopies.Add(new CopyBookDTO(
                                reader.GetInt32(reader.GetOrdinal("BookID")),
                                reader.GetString(reader.GetOrdinal("Title")),
                                reader.GetString(reader.GetOrdinal("ISBN")),
                                reader.GetDateTime(reader.GetOrdinal("PublicationDate")),
                                reader.GetString(reader.GetOrdinal("Language")),
                                reader.GetInt32(reader.GetOrdinal("NumberOfPages")),
                                reader.GetInt32(reader.GetOrdinal("Price")),
                                reader.GetInt32(reader.GetOrdinal("Edition")),
                                reader.GetString(reader.GetOrdinal("Bio")),
                                PhotoURL,
                                reader.GetInt32(reader.GetOrdinal("CopyID")),
                                reader.GetString(reader.GetOrdinal("FormatName")),
                                reader.GetString(reader.GetOrdinal("StatusName"))
                            ));
                        }
                    }
                }
            }
            return liCopies;
        }

    }
}
