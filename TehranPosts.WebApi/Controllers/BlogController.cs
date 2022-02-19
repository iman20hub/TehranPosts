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
        private readonly IBaseServiceAsync<Blog> _blogServiceAsync;

        public BlogController(ILogger<WeatherForecastController> logger, IBlogService blogService, IBaseServiceAsync<Blog> blogServiceAsync)
        {
            _logger = logger;
            _blogService = blogService;
            _blogServiceAsync = blogServiceAsync;
        }

        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return _blogService.GetAll();
        }

        [HttpGet]
        [Route("GetAsync")]
        public async Task<IEnumerable<Blog>> GetAsync()
        {
            return await _blogServiceAsync.GetAll();
        }
    }
}
