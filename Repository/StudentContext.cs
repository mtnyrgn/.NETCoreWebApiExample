using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class StudentContext : DbContext
    {
        public StudentContext( DbContextOptions<StudentContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region StudentContextEntities

            #endregion
        }
    }
}
