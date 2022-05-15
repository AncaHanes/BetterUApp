using System;
using System.Collections.Generic;
using System.Text;

namespace BetterU
{
    class ViewModelStatus
    {
        public IReadOnlyList<TasksItem> TasksAreas { get; }

        public ViewModelStatus()
        {
            var aux = App.Database.GetCompleteTasksAsync();
            float complete = aux.Result.Count;

            aux = App.Database.GetUncompleteTasksAsync();
            float uncomplete = aux.Result.Count;

            float total = complete + uncomplete;
           
            complete = complete / total * 100;
            uncomplete = uncomplete / total * 100;

            TasksAreas = new List<TasksItem>() {
            new TasksItem("Complete", complete),
            new TasksItem("Uncomplete", uncomplete),

        };
        }
    }
    class TasksItem
    {
        public string Name { get; }
        public double Area { get; }

        public TasksItem(string name, double area)
        {
            this.Name = name;
            this.Area = area;
        }
    }
}
