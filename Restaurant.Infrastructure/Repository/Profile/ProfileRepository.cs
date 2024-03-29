using Restaurant.Domain.Entities;
using Restaurant.Domain.SeedWork;
using System.Data.SqlClient;
using System.Data;

namespace Restaurant.Infrastructure.Repository.Profile
{
    public class ProfileRepository : BaseRepository, IProfileRepository
    {
        public ProfileRepository(ILogger logger) : base(logger) { }

        public void Delete(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_Delete");
                _commandText = "USP_Restaurant_Profile_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetProfileDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Profile_Delete");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_Delete");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método DeleteAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_DeleteAsync");
                _commandText = "USP_Restaurant_Profile_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetProfileDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Profile_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_DeleteAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método DeleteAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<ProfileEntity> Get()
        {
            List<ProfileEntity> list = new List<ProfileEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_Get");
                _commandText = "USP_Restaurant_Profile_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetListProfile(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Profile_Get");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_Get");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método Get, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public async Task<List<ProfileEntity>> GetAsync()
        {
            List<ProfileEntity> list = new List<ProfileEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_GetAsync");
                _commandText = "USP_Restaurant_Profile_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetListProfile(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Profile_GetAsync");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_GetAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método Get, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public ProfileEntity GetById(int id)
        {
            ProfileEntity entity = new ProfileEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_GetById");
                _commandText = "USP_Restaurant_Profile_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetProfile(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Profile_GetById");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_GetById");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método GetById, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public async Task<ProfileEntity> GetByIdAsync(int id)
        {
            ProfileEntity entity = new ProfileEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_GetByIdAsync");
                _commandText = "USP_Restaurant_Profile_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetProfile(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Profile_GetByIdAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método GetByIdAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public void Post(ProfileEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_Post");
                _commandText = "USP_Restaurant_Profile_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetProfileInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Profile_Post");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_Post");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método Post, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(ProfileEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_PostAsync");
                _commandText = "USP_Restaurant_Profile_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetProfileInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Profile_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_PostAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método PostAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(ProfileEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_Put");
                _commandText = "USP_Restaurant_Profile_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetProfileUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Profile_Put");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_Put");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método Put, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(ProfileEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Profile_PutAsync");
                _commandText = "USP_Restaurant_Profile_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetProfileUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Profile_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Profile_PutAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Profile, método PutAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #region Helpers

        private static void GetListProfile(SqlDataReader sqlDataReader, List<ProfileEntity> listVehicleProfileModel)
        {
            ProfileEntity brandModel = new ProfileEntity();
            GetProfile(sqlDataReader, brandModel);
            listVehicleProfileModel.Add(brandModel);
        }

        private static void GetProfile(SqlDataReader sqlDataReader, ProfileEntity brandModel)
        {
            brandModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
            brandModel.IdUser = Convert.ToInt32(sqlDataReader["IdUser"]);
            brandModel.Name = Convert.ToString(sqlDataReader["Name"]);
            brandModel.Status = Convert.ToBoolean(sqlDataReader["Status"]);
            brandModel.DateInsert = Convert.ToDateTime(sqlDataReader["DateInsert"]);
            brandModel.DateUpdate = Convert.ToDateTime(sqlDataReader["DateUpdate"]);
        }

        private static void GetProfileInsert(SqlCommand sqlCommand, ProfileEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.IdUser);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetProfileUpdate(SqlCommand sqlCommand, ProfileEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@Id", entity.Id);
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.IdUser);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetProfileDelete(SqlCommand sqlCommand, int id)
        {
            sqlCommand.Parameters.AddWithValue("@Id", id);
        }

        #endregion

    }
}
