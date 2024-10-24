using src.Models;
namespace src.Repositrory
{
    public class CaulacboR: ICaulacbo
    {
        private readonly QlgiaiBongDaContext _context;
        public CaulacboR(QlgiaiBongDaContext context)
        {
            _context = context;
        }
        public Caulacbo Add(Caulacbo caulacbo)
        {
            _context.Caulacbos.Add(caulacbo);
            _context.SaveChanges(); 
            return caulacbo;
        }

        public Caulacbo Delete(string caulacboId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Caulacbo> GetAllclb()
        {
            return _context.Caulacbos;
        }

        public Caulacbo Getclb(string caulacboId)
        {
            return _context.Caulacbos.Find(caulacboId);
        }

        public Caulacbo Update(Caulacbo caulacbo)
        {
            _context.Caulacbos.Update(caulacbo);
            _context.SaveChanges();
            return caulacbo;
        }
    }
}


