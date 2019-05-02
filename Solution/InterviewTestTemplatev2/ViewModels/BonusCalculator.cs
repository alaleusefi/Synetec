using InterviewTestTemplatev2.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2.ViewModels
{
    public class BonusCalculatorInput
    {
        [Required(ErrorMessage = "{0} is mandatory.")]
        [Display(Name = "Pool amount")]
        [Validate]
        public int BonusPoolAmount { get; set; }

        [Display(Name = "Employee name")]
        public IEnumerable<HrEmployee> AllEmployees { get; set; }
        public int SelectedEmployeeId { get; set; }
    }

    public class BonusCalculatorResult
    {

        public decimal bonusPoolAllocation;

        public HrEmployee hrEmployee;
    }
}