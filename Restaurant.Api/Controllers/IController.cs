using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Api.Controllers
{
    public interface IController<T> where T : class
    {
        Task<IActionResult> Get();
        Task<IActionResult> GetById(int id);
        Task Post(T entity);
        Task Put(T entity);
        Task Delete(int id);
    }
}
