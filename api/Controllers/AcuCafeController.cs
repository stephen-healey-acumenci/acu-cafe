using System;
using FullStackAcuCafe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FullStackAcuCafe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AcuCafeController : ControllerBase
    {
        private readonly ILogger<AcuCafeController> _logger;

        public AcuCafeController()
        {
            _logger = new Logger<AcuCafeController>(LoggerFactory.Create(x => { }));
        }

        [HttpPost]
        public string OrderDrink(Order order)
        {
            _logger.LogInformation("Starting order");

            Drink drink = new Drink();
            if (order.Type == "Coffee")
            {
                drink = new Coffee();
            }
            else if (order.Type == "Tea")
            {
                drink = new Tea();
            }
            else if (order.Type == "Ice Tea")
            {
                drink = new IceTea();
            }


            string message = "";

            try
            {
                message = drink.Prepare(drink.Cost());
            }
            catch(Exception ex) {
                _logger.LogError(ex, "Unable to prepare the drink");
            }

            return message;
        }
    }
}
