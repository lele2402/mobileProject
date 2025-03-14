using SQLite;
using MeteoApp;

namespace MeteoApp.Services
{
    public class LocalDatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public LocalDatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Location>().Wait();
            _database.CreateTableAsync<WeatherInfo>().Wait();
            _database.CreateTableAsync<NotificationPreferences>().Wait();
        }

        // CRUD per Location
        public Task<int> AddLocationAsync(Location location) => _database.InsertAsync(location);
        public Task<List<Location>> GetLocationsAsync() => _database.Table<Location>().ToListAsync();
        public Task<int> UpdateLocationAsync(Location location) => _database.UpdateAsync(location);
        public Task<int> DeleteLocationAsync(Location location) => _database.DeleteAsync(location);

        // CRUD per WeatherInfo
        public Task<int> AddWeatherInfoAsync(WeatherInfo weather) => _database.InsertAsync(weather);
        public Task<List<WeatherInfo>> GetWeatherInfoAsync(int locationId) =>
            _database.Table<WeatherInfo>().Where(w => w.LocationId == locationId).ToListAsync();
    }
}