namespace Contabilidad_APP.Components.Models.Interfaces
{
    public interface IStorageService<T>
    {
        Task SaveDataAsync(T data);
        Task<T> LoadDataAsync();
    }

}
