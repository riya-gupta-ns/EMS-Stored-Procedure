using NS.EMS.Data.Entities;
using NS.EMS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Repository
{
    public interface IEmployeeRepo
    {
        //bool AddEmployee(EmployeeModel employeeModel);

        bool AddEmployee(EmpDeptModel EmpDept);

        // List<Employee> ShowDetail();

        List<EmpDeptModel> ShowDetail();
        // bool UpdateEmployee(EmployeeModel employeeModel, int id);
        //bool UpdateEmployee(int id);


        List<EmpDeptModel> UpdateEmployee(int id);
        bool FinalUpdate(EmpDeptModel EmpDept);

        List<EmpDeptModel> DeleteEmployee(int id);
        //bool FinalDelete(EmpDeptModel EmpDept);

        bool FinalDelete(EmpDeptModel EmpDept);
    }
}
