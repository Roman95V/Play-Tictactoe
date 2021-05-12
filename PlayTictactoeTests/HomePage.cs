using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTictactoeTests
{
    public class HomePage
    {
        private readonly IWebDriver _webDriver;
        private By _twoPlayers = By.CssSelector("path.p1");
        private By _cellTopLeft = By.CssSelector("div.square:nth-child(1)");
        private By _cellTopRight = By.CssSelector("div.square:nth-child(3)");
        private By _cellTop = By.CssSelector("div.square:nth-child(2)");
        private By _celliTheMiddleOnTheLeft = By.CssSelector("div.square:nth-child(4)");
        private By _cellTheMiddleOnTheRight = By.CssSelector("div.square:nth-child(6)");
        private By _cellTheMiddle = By.CssSelector("div.square:nth-child(5)");
        private By _cellBottomLeft = By.CssSelector("div.square:nth-child(7)");
        private By _cellBottomRight = By.CssSelector("div.square:nth-child(9)");
        private By _cellBottom = By.CssSelector("div.square:nth-child(8)");
        private  By _x = By.CssSelector("div.x");

        public HomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public HomePage OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public void ClickCellTopLeft()
        {
            _webDriver.FindElement(_cellTopLeft).Click();
        }

        public void ClickCellTop()
        {
            _webDriver.FindElement(_cellTop).Click();
        }

        public void ClickCelliTheMiddleOnTheLeftt()
        {
            _webDriver.FindElement(_celliTheMiddleOnTheLeft).Click();
        }

        public void ClickCelliTheMiddle()
        {
            _webDriver.FindElement(_cellTheMiddle).Click();
        }

        public void ClickCellBottomLeftt()
        {
            _webDriver.FindElement(_cellBottomLeft).Click();
        }

        public void ClickCellTopRight()
        {
            _webDriver.FindElement(_cellTopRight).Click();
        }

        public void ClickCelliTheMiddleOnTheRight()
        {
            _webDriver.FindElement(_cellTheMiddleOnTheRight).Click();
        }

        public void ClickCellBottomRight()
        {
            _webDriver.FindElement(_cellBottomRight).Click();
        }

        public void ClickCellBottom()
        {
            _webDriver.FindElement(_cellBottom).Click();
        }

        public void ClickPlayTwoPlayers()
        {
            _webDriver.FindElement(_twoPlayers).Click();
        }
    }
}


