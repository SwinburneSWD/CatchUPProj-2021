using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HeadphoneLib;

namespace HeadphoneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeadphoneController : ControllerBase
    {
        public List<Headphone> _headphones = new List<Headphone> {
                                                        new Headphone { Id = 1, DriverType = "Dynamic", Catergory = "Over-Ear" },
                                                        new Headphone { Id = 2, DriverType = "Ortho", Catergory = "Open-Ear" },
                                                        new Headphone { Id = 3, DriverType = "BA", Catergory = "In-Ear" }
                                                        };


        public HeadphoneController()
        {

        }

        [HttpGet]
        public List<Headphone> GetAll()
        {
            return this._headphones;
        }

        [HttpGet("{id}")]
        public Headphone GetHeadphoneById(int id) {
            if (id > -1 && id < this._headphones.Count()) {
                return this._headphones[id - 1];
            }

            return null;
        }
    }
}
