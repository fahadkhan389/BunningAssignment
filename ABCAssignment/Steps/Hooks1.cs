using BunningAssignment.Common;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace BunningAssignment.Steps
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks


        [BeforeScenario]
        public void BeforeScenario()
        {
            PropertiesCollection.driver = new FirefoxDriver();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            PropertiesCollection.driver.Close();
            PropertiesCollection.driver.Quit();

        }
    }
}
