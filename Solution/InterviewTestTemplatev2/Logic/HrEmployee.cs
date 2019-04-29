using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.Data
{
    public partial class HrEmployee
    {
        private static MvcInterviewV3Entities1 db = new MvcInterviewV3Entities1();

        public static IEnumerable<HrEmployee> GetEmployeeList() => db.HrEmployees.ToList();

        public static HrEmployee FindById(int employeeId)
        {
            var result = db.HrEmployees.FirstOrDefault(item => item.ID == employeeId);

            if (result == null)
                throw new ValidationException($"There's no {nameof(HrEmployee)} with the Id of {employeeId}");

            return result;
        }

        public static decimal CalculateBonus(int employeeId, int poolAmount)
        {
            var hrEmployee = FindById(employeeId);
            var totalSalary = db.HrEmployees.Sum(item => item.Salary);

            if (totalSalary == 0)
                throw new ValidationException("Total Salary may not be zero!");

            return (decimal)poolAmount * hrEmployee.Salary / totalSalary;
        }
    }
}
