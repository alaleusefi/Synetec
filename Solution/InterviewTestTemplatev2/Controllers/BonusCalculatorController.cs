using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InterviewTestTemplatev2.Data;
using InterviewTestTemplatev2.ViewModels;


namespace InterviewTestTemplatev2.Controllers
{
    public class BonusCalculatorController : Controller
    {
        public MvcInterviewV3Entities1 db = new MvcInterviewV3Entities1();

        // GET: BonusPool
        public ActionResult Input()
        {
            var viewModel = new BonusCalculatorInput
            {
                AllEmployees = HrEmployee.GetEmployeeList()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calculate(BonusCalculatorInput model)
        {
            if (ModelState.IsValid)
            {

                int selectedEmployeeId = model.SelectedEmployeeId;
                int totalBonusPool = model.BonusPoolAmount;
                //TODO: Validate all incoming values from client side
                //TODO: Use attributes built into the framework for validation

                var selectedEmployee = HrEmployee.FindById(selectedEmployeeId);
                var bonusAllocation = HrEmployee.CalculateBonus(model.SelectedEmployeeId, model.BonusPoolAmount);

                var viewModel = new BonusCalculatorResult
                {
                    hrEmployee = selectedEmployee,
                    bonusPoolAllocation = bonusAllocation
                };

                return View("Result", viewModel);
            }
            else
            {
                model.AllEmployees = HrEmployee.GetEmployeeList();
                return View("Input", model);

            }
        }
    }
}