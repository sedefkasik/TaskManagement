using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TaskManagement.entity;

namespace TaskManagement.Data
{
    public class TaskManagementContext : DbContext
    {
        public TaskManagementContext (DbContextOptions<TaskManagementContext> options)
            : base(options)
        {
        }

        public DbSet<TaskManagement.entity.TaskHistory> TaskHistory { get; set; }
        //DbSet = veri tabanindakı bir tabloya karşılık gelır. Bu sınıf Entıtıy Framework sınıfıdır.
    }
}
