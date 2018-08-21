namespace Nullforce.Api.DeviantArt.Rest
{
    public interface IMatureContent<T> where T : class
    {
        T WithMatureContent(bool allowMature = true);
    }
}
