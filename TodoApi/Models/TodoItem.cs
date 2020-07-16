namespace WebApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }
    }

    /// <summary>
    /// DTO作用
    /// 防止过度发布。
    /// 隐藏客户端不应查看的属性。
    /// 省略一些属性以缩减有效负载大小。
    /// 平展包含嵌套对象的对象图。 对客户端而言，平展的对象图可能更方便。
    /// </summary>
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
