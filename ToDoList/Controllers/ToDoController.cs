using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        private readonly ITodoItemService _todoItemService;

        public ToDoController(ITodoItemService todoItemService)
        {
            this._todoItemService = todoItemService;
        }
        public async Task<IActionResult> Index()
        {
            //从数据库获取to-do条目
            var items = await _todoItemService.GetIncompleteItemsAsync();

            //把条目置于model中
            var model = new ToDoViewModel()
            {
                Items = items
            };

            //使用model渲染视图
            return View(model);
        }
    }
}
