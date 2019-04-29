using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using InterviewTestTemplatev2.Controllers;
using InterviewTestTemplatev2.Data;

namespace InterviewTestTemplatev2.Test
{
    [TestClass]
    public class CalculateBounesTest
    {
          [TestMethod]
          public void Calculate()
          {
           var result = HrEmployee.CalculateBonus(1, 100000);
           Assert.AreEqual(result, 100000m * 60000 / 654750);
          }
    }
}
