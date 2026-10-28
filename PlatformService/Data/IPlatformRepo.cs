using PlatformService.Models;

namespace PlatFormService.Data;

public interface IPlatformRepo
{
    bool SaveChanges();

    Platform GetPlatformById(int id);
    IEnumerable<Platform> GetAllPlatforms();
    void CreatePlatform(Platform platform);
}