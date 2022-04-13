,using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{    
    [ApiController]
    [Route("api/employees")]
    public class EmployeeController : ControllerBase
    {       
        public string GetEmployees()
        {
            return "Personel Listesi";
        }
        [Route("{id}")]
        public string GetEmployeeByID(int id)
        {
            return "Tek Personel";
        }

        [Route("~/sehirpersonel/{city}")]    //diğer actionlardan farklı olarak en üstteki route tanımlamasını ezerek çalışır.
        [Route("stuff/{city}")]        //yukarıdaki tanımlamanın üzerine çalışır. Bir üstteki kural ile birlikte çalışabilir.
        public string GetEmployeeByCity(int city)
        {
            return city + "Tek Personel";
        }
    }
}
