using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_cms_first.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc_cms_first.Controllers
{
    /// <summary>
    /// 处理逻辑
    /// </summary>
    public class ContentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var contents = new List<Content>();
            for (int i = 1; i < 10; i++)
            {
                contents.Add(new Content { ID = i, Title = $"{i}的标题", Contents = $"{i}的内容", Status = 1, Add_time = DateTime.Now.AddDays(-i) });

            }
            return View(new ContentViewModel { Contents = contents });

        }
    }
}
