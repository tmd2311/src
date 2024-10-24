using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Models.CauThuModels;
namespace src.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CauThuAPIController : ControllerBase
    {
        QlgiaiBongDaContext db= new QlgiaiBongDaContext();  

        [HttpGet]
        public IEnumerable<CauThu> GetAllSach()
        {
            var cauthu = (from p in db.Cauthus
                        select new CauThu
                        {
                            HoVaTen=p.HoVaTen,
                            CauLacBoId=p.CauLacBoId,
                            CauThuId=p.CauThuId,
                            Anh=p.Anh
                            
                        }).ToList();
            return cauthu;
        }

        [HttpGet("{maClb}")]
        public IEnumerable<CauThu> GetAllSach(string maClb)
        {
            var sach = (from p in db.Cauthus
                        where p.CauLacBoId == maClb
                        select new CauThu
                        {
                            HoVaTen = p.HoVaTen,
                            CauLacBoId = p.CauLacBoId,
                            CauThuId = p.CauThuId,
                            Anh = p.Anh
                        }).ToList();
            return sach;

        }
    }
}
