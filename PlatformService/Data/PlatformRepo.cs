using PlatformService.Models;

namespace PlatFormService.Data;

public class PlatformRepo : IPlatformRepo
{
    private readonly AppDbContext _db;

    PlatformRepo(AppDbContext db)
    {
        _db = db;
    }
    public void CreatePlatform(Platform platform)
    {
        if (platform == null)
            throw new ArgumentNullException(nameof(platform));

        _db.Platforms.Add(platform);
    }

    public IEnumerable<Platform> GetAllPlatforms()
    {
        return _db.Platforms.ToList();
    }

    public Platform GetPlatformById(int id)
    {
        return _db.Platforms.FirstOrDefault(x => x.Id == id);
    }

    public bool SaveChanges()
    {
        return _db.SaveChanges() >= 0;
    }
}