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
    public class msnNewsController : ControllerBase
    {
        public async Task<IActionResult> msnNews()
        {
            List<msnData> data = await msn.GetNews();

            if (data == null)
            {
                return NotFound();
            }

            return new ObjectResult(data);

        }
    }
}