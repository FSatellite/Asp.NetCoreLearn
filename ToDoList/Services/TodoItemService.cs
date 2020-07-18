using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class TodoItemService : ITodoItemService
    {
        private readonly ApplicationDbContext _dbContext;
        public TodoItemService(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [ValidateAntiForgeryToken]
        public async Task<bool> AddItemAsync(TodoItem item)
        {
            item.Id = Guid.NewGuid();
            item.IsDone = false;
            item.DueAt = DateTimeOffset.Now.AddDays(3);

            _dbContext.Items.Add(item);
            return await _dbContext.SaveChangesAsync() == 1;
        }

        public async Task<TodoItem[]> GetIncompleteItemsAsync()
        {
            //return await _dbContext.Items.Where(x => x.IsDone == false).ToArrayAsync();
            return await _dbContext.Items.ToArrayAsync();
        }

        public async Task<bool> MarkDoneAsync(Guid id)
        {
            var item = _dbContext.Items.Where(x => x.Id == id).SingleOrDefaultAsync();

            if (item == null)
                return false;

            item.Result.IsDone = item.Result.IsDone == true ? false : true;
            return await _dbContext.SaveChangesAsync() == 1;
        }
    }
}
