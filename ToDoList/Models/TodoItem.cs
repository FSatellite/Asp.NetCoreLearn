using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// C# 用于这种类型保存一个 日期/时间 的戳记和一个与 UTC 偏移量表示的时区。把时期、时间和时区一起保存，有助于在不同时区的系统上准确地显示时间
        /// </summary>
        public DateTimeOffset? DueAt { get; set; }
    }
}
