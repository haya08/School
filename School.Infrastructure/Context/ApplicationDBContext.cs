using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infrastructure.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(){}

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<TbStudent> students { get; set; }
        public virtual DbSet<TbDepartment> departments { get; set; }
        public virtual DbSet<TbSubject> subjects { get; set; }
        public virtual DbSet<TbStudentSubject> studentSubjects { get; set; }
        public virtual DbSet<TbDepartmentSubject> departmentSubjects { get; set; }
    }
}
