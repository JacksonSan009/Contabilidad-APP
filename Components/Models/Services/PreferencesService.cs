using Contabilidad_APP.Components.Models.Interfaces;

namespace Contabilidad_APP.Components.Models.Services
{
    public class PreferencesService : IStorageService<decimal>
    {
        private readonly string key;

        public PreferencesService(string key)
        {
            this.key = key;
        }

        public Task SaveDataAsync(decimal data)
        {
            Preferences.Set(key, data.ToString());  // Use the correct key to save data
            return Task.CompletedTask;
        }

        public Task<decimal> LoadDataAsync()
        {
            string storedValue = Preferences.Get(key, "0");  // Use the correct key to load data
            decimal value = decimal.Parse(storedValue);
            return Task.FromResult(value);
        }
    }
}
