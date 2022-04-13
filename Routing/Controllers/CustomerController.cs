using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [Route("customers")]
        public string GetCustomers()
        {
            return "Müşteri Listesi";
        }

        [Route("customers/{id}")]
        public string GetCustomerByID(string id)
        {
            return id + " Kodlu Tek Müşteri Bilgileri";
        }

        [Route("parametresiz/{id}")]
        public string Parametresiz()
        {
            int id = (int)Request.RouteValues["id"];
            return id + " Kodlu Tek Müşteri Bilgileri";
        }

        //[Route("customers/{name}")]           !!!!!!!!!!!HATA VERİR. 15. SATIR - CUSTOMERS/ID İLE CUSTOMERS/NAME AYNI ALGILANIR
        //public string GetCustomerByName(string name)
        //{
        //    return name + " İsimli Tek Müşteri Bilgileri";
        //}
        //
        //AŞAĞIDAKİ ŞEKİLDE YAPILABİLİR
 
        [Route("customers/name/{name}")]     //[Route("{name}/customers")] şeklinde çalışabilse de pek tercih edilmez. Spesifik durumlarda yapılabilir.
        public string GetCustomerByName(string name)
        {
            return name + " İsimli Tek Müşteri Bilgileri";
        }

    }
}
