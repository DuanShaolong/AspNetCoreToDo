using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using AspNetCoreTodo.Services;
namespace AspNetCoreTodo.Controllers
{

    public class TodoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public TodoController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }
        public IActionResult Index()
        {
            // 从数据库获取 to-do 条目

            // 把条目置于 model 中

            // 使用 model 渲染视图
            return View();
        }

    }

}