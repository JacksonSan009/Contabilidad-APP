using Contabilidad_APP.Components.Models.Interfaces;

namespace Contabilidad_APP.Components.Models.Util
{
    public class StorageManager<T>
    {
        private readonly IStorageService<T> storageService;

        public StorageManager(IStorageService<T> storageService)
        {
            this.storageService = storageService;
        }

        public Task SaveDataAsync(T data)
        {
            return storageService.SaveDataAsync(data);
        }

        public Task<T> LoadDataAsync()
        {
            return storageService.LoadDataAsync();
        }
    }

}
