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

            var actualresult = _webDriver.FindElement(By.CssSelector("div.x"));
            var result = _webDriver.FindElement(By.CssSelector("div.square:nth-child(1)"));

            Assert.AreNotEqual(result, actualresult);

        }

        [Test]
        public void CheckIconChangesFromOnePlayerToTwo()
        {
            var game = new Game(_webDriver);

            game.OpenPage();
            game.ClickPlayTwoPlayers();

            var actualresult = _webDriver.FindElement(By.CssSelector("p.p2")).Text;
            
            Assert.AreEqual("2P", actualresult);

        }

        [Test]
        public void CheckDisplaTheVictoryOfTheFirstPlayer()
        {
            var game = new Game(_webDriver);

            game.OpenPage();
            game.ClickPlayTwoPlayers();
            game.ClickCellTopLeft();
            game.ClickCellTopRight();
            game.ClickCelliTheMiddleOnTheLeftt();
            game.ClickCelliTheMiddleOnTheRight();
            game.ClickCellBottomLeftt();

            var actualresult = _webDriver.FindElement(By.CssSelector(".player1 > span.score")).Text;
           
            Assert.AreEqual("1",actualresult); 
        }

        [Test]
        public void CheckDisplaTheVictoryOfTheCoputer()
        {
            var game = new Game(_webDriver);

            game.OpenPage();
            game.ClickCellTopLeft();
            game.ClickCellTop();
            game.ClickCelliTheMiddleOnTheLeftt();
            
            var actualresult = _webDriver.FindElement(By.CssSelector("p.player2 > span.score.appear")).Text;
            Thread.Sleep(3000);

            Assert.AreEqual("1", actualresult); 
        }
    }
}
