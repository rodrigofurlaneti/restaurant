using Restaurant.Domain.Entities;
using Restaurant.Domain.SeedWork;
using Restaurant.Infrastructure.Repository.User;

namespace Restaurant.Service.Service.User
{
    public class UserService : BaseService, IUserService
    {
        #region Property

        public readonly IUserRepository _userRepository;


        #endregion

        #region Constructor

        public UserService(ILogger logger, IUserRepository userRepository) : base(logger)
        {
            _userRepository = userRepository;
        }

        #endregion

        #region Methods

        public void Delete(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_User_Delete");
                _userRepository.Delete(id);
                this._logger.TraceExit("Service_User_Delete");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método Delete, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_User_DeleteAsync");
                await _userRepository.DeleteAsync(id);
                this._logger.TraceExit("Service_User_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método DeleteAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<UserEntity> Get()
        {
            try
            {
                this._logger.TraceEntry("Service_User_Get");
                var ret = _userRepository.Get();
                this._logger.TraceExit("Service_User_Get");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_Get");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método Get, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<List<UserEntity>> GetAsync()
        {
            try
            {
                this._logger.TraceEntry("Service_User_GetAsync");
                var ret = await _userRepository.GetAsync();
                this._logger.TraceExit("Service_User_GetAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_GetAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método GetAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public UserEntity GetById(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_User_GetById");
                var ret = _userRepository.GetById(id);
                this._logger.TraceExit("Service_User_GetById");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_GetById");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método GetById, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<UserEntity> GetByIdAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_User_GetByIdAsync");
                var ret = await _userRepository.GetByIdAsync(id);
                this._logger.TraceExit("Service_User_GetByIdAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método GetByIdAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Post(UserEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_User_Post");
                _userRepository.Post(entity);
                this._logger.TraceExit("Service_User_Post");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_Post");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método Post, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(UserEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_User_PostAsync");
                await _userRepository.PostAsync(entity);
                this._logger.TraceExit("Service_User_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_PostAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método PostAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(UserEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_User_Put");
                _userRepository.Put(entity);
                this._logger.TraceExit("Service_User_Put");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_Put");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método Put, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(UserEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_User_PutAsync");
                await _userRepository.PutAsync(entity);
                this._logger.TraceExit("Service_User_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_User_PutAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade User, método PutAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #endregion
    }
}
