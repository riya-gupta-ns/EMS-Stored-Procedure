using Microsoft.EntityFrameworkCore;
using NS.EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Data.Entities
{
    public partial class EmployeeDBContext : DbContext
    {
        public virtual DbSet<EmpDeptModel> EmpDept { get; set; }
    }
}
