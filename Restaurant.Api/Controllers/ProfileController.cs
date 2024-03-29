using Restaurant.Domain.Entities;
using Restaurant.Service.Service.Profile;
using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase, IController<ProfileEntity>
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IProfileService _profileService;

        public ProfileController(ILogger<ProfileController> logger, IProfileService profileService)
        {
            this._logger = logger;
            this._profileService = profileService;
        }

        [HttpGet(Name = "GetProfile")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProfileEntity>))]
        public async Task<IActionResult> Get()
        {
            try
            {
                this._logger.LogInformation("WebApi_Profile_GetAsync_Entry");
                var ret = await _profileService.GetAsync();
                this._logger.LogInformation("WebApi_Profile_GetAsync_Exit");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Profile_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Profile, rota Get " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ProfileEntity>))]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Profile_GetByIdAsync_Entry");
                var ret = await _profileService.GetByIdAsync(id);
                this._logger.LogInformation("WebApi_Profile_GetByIdAsync_Entry");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Profile_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Profile, rota GetByIdAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpPost(Name = "InsertProfile")]
        public async Task Post(ProfileEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Profile_PostAsync_Entry");
                await _profileService.PostAsync(entity);
                this._logger.LogInformation("WebApi_Profile_PostAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Profile_PostAsync_Exception");
                string mensagem = "Erro ao consumir a controler Profile, rota PostAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpPut(Name = "UpdateProfile")]
        public async Task Put(ProfileEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Profile_PutAsync_Entry");
                await _profileService.PutAsync(entity);
                this._logger.LogInformation("WebApi_Profile_PutAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Profile_PutAsync_Exception");
                string mensagem = "Erro ao consumir a controler Profile, rota Put " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Profile_DeleteAsync_Entry");
                await _profileService.DeleteAsync(id);
                this._logger.LogInformation("WebApi_Profile_DeleteAsync_Exit");
            }
            catch (Exception ex)
            {
                _logger.LogInformation("WebApi_Profile_DeleteAsync_Exception");
                string mensagem = "Erro ao consumir a controler Profile, rota DeleteAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }
    }
}