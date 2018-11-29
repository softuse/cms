using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using mvc_cms_first.Log;
using mvc_cms_first.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc_cms_first.Controllers
{
    /// <summary>
    /// 处理逻辑
    /// </summary>
    public class ContentController : Controller
    {
        //private readonly Content contents;
        //public ContentController(IOptions<Content> option)
        //{
        //    contents = option.Value;
        //}
        private readonly Logger _logger;

        private readonly List<Content> contents;
        public ContentController(IOptions<List<Content>> options, IOptions<Logger> option)
        {
            contents = options.Value;
            _logger = option.Value;  //这地方注入要注意  .json中的写法, "Logger": { "LoggerType":"mvc_cms_first.ILog.DatabaseLogger" },
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            string _loggerType = _logger.LoggerType;

            ILog logger = ObjectBuildFactory<ILog>.Instance(_loggerType);
            var contents = new List<Content>();
            for (int i = 1; i < 10; i++)
            {
                contents.Add(new Content { ID = i, Title = $"{logger.Info("test")}的标题", Contents = $"{i}的内容", Status = 1, Add_time = DateTime.Now.AddDays(-i) });

            }
            return View(new ContentViewModel { Contents = contents });

            // return View(new ContentViewModel { Contents =new List<Content> { contents } });

           
           // logger.Info("test");


            return View(new ContentViewModel { Contents =  contents  });

        }
    }
}
