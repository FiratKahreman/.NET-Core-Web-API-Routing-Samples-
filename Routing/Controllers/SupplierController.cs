using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    //ROUTE CONSTRAINTS  (Kurallar kombine edilebilir. örn:[Route("{id:int:min(10):max(50)}")]

    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        [Route("{id:int}")]   //parametre için kural koyma (her tip kullanılamaz) String gönderirsek 404 geri döner.
        public string GetSupplierByID(int id)
        {
            return "Tedarikçi";
        }

        [Route("{name?}")]   //bu parametre gelebilir de gelmeyebilir de. String null geçirebilir ancak int geçiremez. Nullable int!?
        public string GetSupplierByName(string name)
        {
            return "Tedarikçi";
        }

        [Route("{city:alpha}")]    //alpha numeric
        public string GetSupplierByCity(string city)
        {
            return "Tedarikçi";
        }

        [Route("{city:length(5)}")]   //karakter sınırlaması    maxlength ve minlength de kullanılabilir. 
        public string GetSupplierByCity2(string city)
        {
            return "Tedarikçi";
        }


    }
}
