using Microsoft.AspNetCore.Mvc;

namespace SolrDotnetSample.WebApi.Controllers
{
    [ApiController, Route("api/v{version:apiVersion}/[controller]")]
    public abstract class PostsControllerBase : ControllerBase { }
}