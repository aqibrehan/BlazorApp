using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Infrastructure.IRepository;
using DataModel.Models;
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmazonLabelController : ControllerBase
    {
        private IAmazonLabelOrderListRepository _amazonLabelOrderListRepository;

        public AmazonLabelController(IAmazonLabelOrderListRepository amazonLabelOrderListRepository)
        {
            _amazonLabelOrderListRepository = amazonLabelOrderListRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetAmazonShippingOrderlists()
        {
            try
            {
                IEnumerable<AmazonShippingOrderlist> AmazonShippingOrderlist;

                AmazonShippingOrderlist = _amazonLabelOrderListRepository.GetAll();
                return Ok(AmazonShippingOrderlist);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in Retriveing Data from Database");
            }

        }
    }
}
