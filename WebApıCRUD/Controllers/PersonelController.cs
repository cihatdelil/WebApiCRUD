using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApıCRUD.Controllers.Model;

namespace WebApıCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            if (PersonelManager.personels.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(PersonelManager.personels);
        }
        [HttpGet("Getpersonels")]
        public ActionResult Get(int id) 
        { 
            var personel = PersonelManager.personels.SingleOrDefault(x=>x.Id==id);
            if(personel==null)
            {
                return NotFound("No List Found");
            }
            return Ok(personel);
        }
        [HttpPost]
        public ActionResult Save(Personel p)
        {
            PersonelManager.personels.Add(p);

            return Ok(PersonelManager.personels);
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var personel = PersonelManager.personels.SingleOrDefault(x => x.Id == id);

            if(personel== null) 
            {
                return NotFound("No List Found");
            }
            PersonelManager.personels.Remove(personel);
            if (PersonelManager.personels.Count == 0)
            {
                return NotFound("No List Found");
            }
            return Ok(PersonelManager.personels);
        }

        [HttpPut]
        public ActionResult Put(Personel p)
        {
            var personel = PersonelManager.personels.SingleOrDefault(x => x.Id == p.Id);
            personel.Name=p.Name;   
            personel.Title=p.Title;
            return Ok(PersonelManager.personels);
        }
    }
}
