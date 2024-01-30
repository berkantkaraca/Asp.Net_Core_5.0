using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature
{
    public class FeatureList : ViewComponent
    {
        FeatureManeger featureManeger = new FeatureManeger(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = featureManeger.TGetList();
            return View(values);
        }
    }
}
