using src.Models;

namespace src.Repositrory
{
    public interface ICaulacbo
    {
        Caulacbo Add(Caulacbo caulacbo);
        Caulacbo Update(Caulacbo caulacbo);
        Caulacbo Delete(string caulacboId);
        Caulacbo Getclb(string caulacboId);
        IEnumerable<Caulacbo> GetAllclb();
    }
}



