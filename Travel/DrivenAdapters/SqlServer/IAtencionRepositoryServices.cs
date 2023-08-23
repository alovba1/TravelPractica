namespace Travel.DrivenAdapters.SqlServer
{
    public interface ILibroRepository<T> where T : class
    {
        Task<List<T>> GetAllLibros();
        Task<List<bool>> SaveLibros(T modelo);
        Task<List<bool>> UpdateLibros(T modelo);
        Task<List<bool>> DeleteLibros(int id);
    }
}
