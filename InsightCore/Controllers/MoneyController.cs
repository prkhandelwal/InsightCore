using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ScrapeService.Models;
using ScrapeService.ScrapeServices;

namespace InsightCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyController : ControllerBase
    {
        public async Task<IActionResult> Money()
        {
            List<msnData> data = await msn.GetMoney();

            if (data == null)
            {
                return NotFound();
            }

            return new ObjectResult(data);
        }
    }
}