using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace GitHubProject
{
    [TestFixture]
    class SampleProject
    {
        IWebDriver driver;

        [Test]
        public void searchPage()
        {
            driver = new ChromeDriver();
            driver.Url = "https://www.google.com/";
            Thread.Sleep(TimeSpan.FromSeconds(2));

            driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Thread.Sleep(TimeSpan.FromSeconds(2));

            driver.Close();
        }
    }
}
