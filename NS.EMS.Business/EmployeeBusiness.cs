using NS.EMS.Data.Entities;
using NS.EMS.Model;
using NS.EMS.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace NS.EMS.Business
{
    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepo _IEmployeeRepo;
        public EmployeeBusiness(IEmployeeRepo IEmployeeRepo)
        {
            _IEmployeeRepo = IEmployeeRepo;
        }

        public bool AddEmployee(EmpDeptModel EmpDept)
        {
            return _IEmployeeRepo.AddEmployee(EmpDept);
        }
        public List<EmpDeptModel> ShowDetail()
        {

            return _IEmployeeRepo.ShowDetail();

        }

        public List<EmpDeptModel> UpdateEmployee(int id)
        {
            return _IEmployeeRepo.UpdateEmployee(id);
        }

        public bool FinalUpdate(EmpDeptModel EmpDept)
        {
            return _IEmployeeRepo.FinalUpdate(EmpDept);
        }

        public List<EmpDeptModel> DeleteEmployee(int id)
        {
            return _IEmployeeRepo.DeleteEmployee(id);
        }

        public bool FinalDelete(EmpDeptModel EmpDept)
        {
            return _IEmployeeRepo.FinalDelete(EmpDept);
        }
    }
}
