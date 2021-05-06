using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace PlayTictactoeTests
{
    public class GameTest
    {
        private IWebDriver _webDriver;
        [SetUp]
        public void Setup()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());
            _webDriver = new FirefoxDriver();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            _webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);

        }
        [TearDown]
        public void TearDown()
        {
            _webDriver.Quit();
        }
        [Test]
        public void CheckTheXChaActerDisplay()
        {
            var game = new Game(_webDriver);
            game.OpenPage();
            game.ClickCellTopLeft();

          //  game.ClickCellTopLeft();
          //  game.ClickCelliTheMiddleOnTheLeftt();
          //  game.ClickCellTopLeft();
          //
            var actualresult = _webDriver.FindElement(By.CssSelector("div.x"));
            var result = _webDriver.FindElement(By.CssSelector("div.square:nth-child(1)"));

            Assert.AreNotEqual(result, actualresult);

        }

        [Test]
        public void Check()
        {
            var game = new Game(_webDriver);
            game.OpenPage();
            
            game.ClickPlayTwoPlayers();
            Thread.Sleep(3000);
            var actualresult = _webDriver.FindElement(By.CssSelector("p.p1"));
            var result = _webDriver.FindElement(By.CssSelector("p.p2"));
           
            Assert.AreNotEqual(result, actualresult);

        }
    }
}
