using NS.EMS.Data.Entities;
using NS.EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
    public interface IEmployeeBusiness
    {
        bool AddEmployee(EmpDeptModel EmpDept);
        List<EmpDeptModel> ShowDetail();
   
        List<EmpDeptModel> UpdateEmployee(int id);
        bool FinalUpdate(EmpDeptModel EmpDept);
        List<EmpDeptModel> DeleteEmployee(int id);
        bool FinalDelete(EmpDeptModel EmpDept);
    }
}
