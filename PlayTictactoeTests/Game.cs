﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayTictactoeTests
{
    public class Game
    {
        private readonly IWebDriver _webDriver;

        private By _cellTopLeft = By.CssSelector("div.square:nth-child(1)");
        private By _cellTopRight = By.CssSelector("div.square:nth-child(3)");
        private By _cellTop = By.CssSelector("div.square:nth-child(2)");
        private By _celliTheMiddleOnTheLeft = By.CssSelector("div.square:nth-child(4)");
        private By _cellTheMiddleOnTheRight = By.CssSelector("div.square:nth-child(6)");
        private By _cellTheMiddleOnThe = By.CssSelector("div.square:nth-child(5)");
        private By _cellBottomLeft = By.CssSelector("div.square:nth-child(7)");
        private By _cellBottomRight = By.CssSelector("div.square:nth-child(9)");
        private By _cellBottom = By.CssSelector("div.square:nth-child(8)");
        private By _accountBlockMassage = By.CssSelector("div.FormErrorText__error---nzyq:nth-child(1) > div:nth-child(1)");
        private By _x = By.CssSelector("div.x");

        public Game(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public Game OpenPage()
        {
            _webDriver.Navigate().GoToUrl("https://playtictactoe.org/");
            return this;
        }

        public void ClickCellTopLeft()
        {
            _webDriver.FindElement(_cellTopLeft).Click();
        }
    }
}

