using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using InterviewTestTemplatev2.Controllers;



namespace InterviewTestTemplatev2.Test
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void Input()
        {
        //Arrange
        BonusCalculatorController controller = new BonusCalculatorController();

            //Act
            ViewResult result = controller.Input() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }     
    }
}
