﻿// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SP1TestSuite1 : IDisposable
{
    public IWebDriver driver { get; private set; }
    public IDictionary<String, Object> vars { get; private set; }
    public IJavaScriptExecutor js { get; private set; }
    public SP1TestSuite1()
    {
        driver = new ChromeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<String, Object>();
    }
    public void Dispose()
    {
        driver.Quit();
    }

    [Fact]
    public void Test1_Calculator()
    {
        //driver.Navigate().GoToUrl("https://www.calculator.net/");
        //driver.FindElement(By.CssSelector("div:nth-child(3) > .scinm:nth-child(1)")).Click();
        //driver.FindElement(By.CssSelector("div:nth-child(3) > .scinm:nth-child(2)")).Click();
        //driver.FindElement(By.CssSelector("div:nth-child(3) > .sciop:nth-child(4)")).Click();
        //driver.FindElement(By.CssSelector("div:nth-child(3) > .sciop:nth-child(4)")).Click();
        //driver.FindElement(By.CssSelector("div:nth-child(2) > .scinm:nth-child(2)")).Click();
        //driver.FindElement(By.CssSelector("div:nth-child(3) > .scinm:nth-child(3)")).Click();
        //driver.FindElement(By.CssSelector(".scieq:nth-child(4)")).Click();
        //driver.FindElement(By.CssSelector("span[onclick='r(5)']")).Click();
        //driver.FindElement(By.XPath("//span[@onclick=\"r(\'+\')\"]")).Click();
        //driver.FindElement(By.CssSelector("[onclick=\"r(7)\"]")).Click();
        //driver.FindElement(By.CssSelector("div span[onclick=\"r(\'=\')\"]")).Click();

        //practised this testcase using selenium IDE
    }

    [Fact]
    public void Test2_Next()
    {
        driver.Navigate().GoToUrl("https://www.next.co.uk/");
        driver.FindElement(By.XPath("//a[@id='NI5'][@title='BOYS']")).Click();
        driver.FindElement(By.XPath("//a[@title='3-5yrs']")).Click();
        driver.FindElement(By.CssSelector("a[id='NI8'][title='BEAUTY']")).Click();

        //Testcase is successful but not able to run it sometimes. 
    }

    [Fact]

    public void Test3_Theonlinecalculator()
    {
        driver.Navigate().GoToUrl("https://www.theonlinecalculator.com/");
        driver.FindElement(By.Name("nine")).Click();
        driver.FindElement(By.Name("add")).Click();
        driver.FindElement(By.Name("five")).Click();
        driver.FindElement(By.Name("calculate")).Click();

        //Finding elements using Locators. 

    }

    [Fact]

    public void Test4_Theonlinecalculator()
    {
        driver.Navigate().GoToUrl("https://www.theonlinecalculator.com/");
        driver.FindElement(By.Id("display")).SendKeys("250");
        driver.FindElement(By.CssSelector("input[name='subtract']")).Click();
        driver.FindElement(By.Id("display")).SendKeys("200");
        driver.FindElement(By.XPath("//input[@name='calculate']")).Click();

        //Finding elements using CSS selectors & Xpath 

    }

    [Fact]

    public void Test5_BBC()
    {
        driver.Navigate().GoToUrl("https://www.bbc.co.uk/");
        driver.FindElement(By.CssSelector("ul.ssrcss-vp47zn-GlobalNavigationLinkList-En a.ssrcss-1wrc3mj-NavigationLink-AccountLink")).Click();
        driver.FindElement(By.CssSelector("input[type='email']")).SendKeys("pooji.j4@gmail.com");
        driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("Myfather40");
        driver.FindElement(By.Id("submit-button")).Click();

        //Testcase for Login page. 

    }

    [Fact]

    public void Test6_Rightmove()
    {
        driver.Navigate().GoToUrl("https://rightmove.co.uk/");
        driver.FindElement(By.Name("typeAheadInputField")).SendKeys("LE1 4QB");
        driver.FindElement(By.CssSelector(".residentialLetButton")).Click();
        //driver.FindElement(By.XPath("//a[contains(text(),'To Rent')]")).Click();
        driver.FindElement(By.Id("searchLocation")).SendKeys("LE14QB");
        driver.FindElement(By.CssSelector("input[type='submit']")).Click();

        //driver.FindElement(By.CssSelector("section a[href='/property-to-rent.html']")).Click();

        //Testcase to practise Sendkeys - Enter text in Textbox.

    }

    [Fact]
    public void Test7_calculator()
    {
        driver.Navigate().GoToUrl("https://www.calculator.net/");
        driver.FindElement(By.CssSelector("#calcSearchTerm")).SendKeys("Income Tax Calculator");

        IWebElement SearchEle = driver.FindElement(By.CssSelector("#bluebtn"));
        SearchEle.Click();

        //testcase to practise sendkeys - successful 

    }

    [Fact]
    public void Test8_calculator()
    {
        driver.Navigate().GoToUrl("https://www.calculator.net/");

        IWebElement ele = driver.FindElement(By.XPath("//a[contains(text(),'Financial Calculators')]"));

        String className = ele.GetCssValue("color").ToString();

        String href = ele.GetAttribute("href").ToString();


        //Testcase to practise Iwebelement. (ask again for lastline - not clear).
        // properties of attribute using GetCSSvalue & GetAttribute 
    }

    [Fact]

    public void Test9_calculator()
    {
        driver.Navigate().GoToUrl("https://rightmove.co.uk/");

        IWebElement ele1 = driver.FindElement(By.XPath("//a[contains(text(),'Visit the Rightmove Blog')]"));

        String className = ele1.GetCssValue("color").ToString();

        String href = ele1.GetAttribute("href").ToString();

        //driver.FindElement(By.XPath("//a[contains(text(),'To Rent' )]")).Click();
    }
}
