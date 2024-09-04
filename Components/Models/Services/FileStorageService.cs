namespace Contabilidad_APP.Components.Models.Services
{
    using Contabilidad_APP.Components.Models.Interfaces;
    using System.IO;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class FileStorageService<T> : IStorageService<T>
    {
        private readonly string filePath;

        public FileStorageService(string filename)
        {
            filePath = Path.Combine(FileSystem.AppDataDirectory, filename);
        }

        public async Task SaveDataAsync(T data)
        {
            var json = JsonSerializer.Serialize(data);
            await File.WriteAllTextAsync(filePath, json);
        }

        public async Task<T> LoadDataAsync()
        {
            if (File.Exists(filePath))
            {
                var json = await File.ReadAllTextAsync(filePath);
                return JsonSerializer.Deserialize<T>(json);
            }
            return default;
        }
    }

}
