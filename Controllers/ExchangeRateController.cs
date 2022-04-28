using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExchangeRate.Dtos;
using ExchangeRate.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExchangeRate.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {
        //GET api/commands/datesList/fromCurrency/toCurrency
        [HttpGet("{datesList}/{fromCurrency}/{toCurrency}")]
        public async Task<ActionResult<string>> GetAllCommands(string datesList, string fromCurrency, string toCurrency)
        {
            var infoDto = new InfoDto();

            string[] dates = datesList.Split(',').Distinct().ToArray();

            List<DateRate> rates = await new LoadFromService().LoadData(dates, fromCurrency, toCurrency);

            infoDto =new PopulateInfo().ReturnInfo(rates);

            if (!ModelState.IsValid)
                return NotFound();

            JsonConvert.SerializeObject(infoDto, Formatting.None);

            return Ok(JsonConvert.SerializeObject(infoDto, Formatting.None));

        }
    }
}