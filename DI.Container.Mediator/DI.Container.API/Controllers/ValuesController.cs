using DI.Container.Application;
using MediatR;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace DI.Container.API.Controllers
{
    public class ValuesController : ApiController
    {
        private IMediator mediator;
        public ValuesController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public async Task<IHttpActionResult> Post([FromBody] Request request)
        {
            return Ok(await mediator.Send(request));
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
