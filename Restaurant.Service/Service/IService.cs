namespace Restaurant.Service.Service
{
    public interface IService<T> where T : class
    {
        List<T> Get();
        Task<List<T>> GetAsync();
        T GetById(int id);
        Task<T> GetByIdAsync(int id);
        void Post(T entity);
        Task PostAsync(T entity);
        void Put(T entity);
        Task PutAsync(T entity);
        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
