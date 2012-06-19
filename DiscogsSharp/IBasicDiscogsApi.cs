using DiscogsSharp.Abstractions;

namespace DiscogsSharp
{
    public interface IBasicDiscogsApi
    {
        Artist GetArtistById(long id);
        Release GetReleaseById(long id);
        Master GetMasterById(long id);
        Label GetLabelById(long id);
    }
}
