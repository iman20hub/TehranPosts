using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TehranPosts.Core.InterfaceServices;
using TehranPosts.Domain.Models;

namespace TehranPosts.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IBlogService _blogService;

        public BlogController(ILogger<WeatherForecastController> logger, IBlogService blogService)
        {
            _logger = logger;
            _blogService = blogService;
        }

        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return _blogService.GetAll();
        }
    }
}
