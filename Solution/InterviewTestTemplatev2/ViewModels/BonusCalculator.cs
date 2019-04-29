using InterviewTestTemplatev2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.ViewModels
{
    public class BonusCalculatorInput
    {
        public int BonusPoolAmount { get; set; }
        public IEnumerable<HrEmployee> AllEmployees { get; set; }
        public int SelectedEmployeeId { get; set; }
    }

    public class BonusCalculatorResult
    {
        public HrEmployee hrEmployee;
        public decimal bonusPoolAllocation;
    }
}