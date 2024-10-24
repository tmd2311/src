using src.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using src.Repositrory;

using src.Repositrory;
namespace Bai1.ViewComponents
{
    public class CauLacBoViewComponent : ViewComponent
    {
        private readonly ICaulacbo _Clb;
        public CauLacBoViewComponent(ICaulacbo clb)
        {
            _Clb = clb;
        }
        public IViewComponentResult Invoke()
        {
            var clb = _Clb.GetAllclb().OrderBy(x => x.CauLacBoId);
            return View(clb);
        }
    }
}
