using Restaurant.Domain.Entities;
using Restaurant.Service.Service;
using Restaurant.Service.Service.User;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase, IController<UserEntity>
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            this._logger = logger;
            this._userService = userService;
        }

        [HttpGet(Name = "GetUser")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserEntity>))]
        public async Task<IActionResult> Get()
        {
            try
            {
                this._logger.LogInformation("WebApi_User_GetAsync_Entry");
                var ret = await _userService.GetAsync();
                this._logger.LogInformation("WebApi_User_GetAsync_Exit");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_User_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler User, rota Get " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<UserEntity>))]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_User_GetByIdAsync_Entry");
                var ret = await _userService.GetByIdAsync(id);
                this._logger.LogInformation("WebApi_User_GetByIdAsync_Entry");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_User_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler User, rota GetByIdAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpPost(Name = "InsertUser")]
        public async Task Post(UserEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_User_PostAsync_Entry");
                await _userService.PostAsync(entity);
                this._logger.LogInformation("WebApi_User_PostAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_User_PostAsync_Exception");
                string mensagem = "Erro ao consumir a controler User, rota PostAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpPut(Name = "UpdateUser")]
        public async Task Put(UserEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_User_PutAsync_Entry");
                await _userService.PutAsync(entity);
                this._logger.LogInformation("WebApi_User_PutAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_User_PutAsync_Exception");
                string mensagem = "Erro ao consumir a controler User, rota Put " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_User_DeleteAsync_Entry");
                await _userService.DeleteAsync(id);
                this._logger.LogInformation("WebApi_User_DeleteAsync_Exit");
            }
            catch (Exception ex)
            {
                _logger.LogInformation("WebApi_User_DeleteAsync_Exception");
                string mensagem = "Erro ao consumir a controler User, rota DeleteAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }
    }
}