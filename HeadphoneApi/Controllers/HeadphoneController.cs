using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HeadphoneLib;
using HeadphoneApi.Services;

namespace HeadphoneApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeadphoneController : ControllerBase
    {
        private DatabaseHandler _dbh;
        public HeadphoneController()
        {
            this._dbh = new DatabaseHandler();
        }

        [HttpGet]
        public List<Headphone> GetAll()
        {
            return this._dbh.GetAllHeadphones();
        }

        // [HttpGet("{id}")]
        // public Headphone GetHeadphoneById(int id) {
        //     if (id > -1 && id < this._headphones.Count()) {
        //         return this._headphones[id - 1];
        //     }

        //     return null;
        // }
    }
}
