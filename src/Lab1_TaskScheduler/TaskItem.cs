using System;

namespace Lab1_TaskScheduler.Models
{
	public class TaskItem
	{
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public DateTime Deadline { get; set; }
		public int Priority { get; set; } // 1-5, где 5 - наивысший
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public bool IsCompleted { get; set; }

		public override string ToString()
		{
			return $"{Title} (Приоритет: {Priority}, Дедлайн: {Deadline:dd.MM.yyyy})";
		}
	}
}