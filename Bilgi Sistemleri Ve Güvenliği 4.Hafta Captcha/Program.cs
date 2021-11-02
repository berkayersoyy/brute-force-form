using System.IO;
using System.Reflection;
using System.Threading;
using Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bilgi_Sistemleri_Ve_Güvenliği_4.Hafta_Captcha
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(3000);
            IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            string link = @"http://localhost:52230/";
            driver.Navigate().GoToUrl(link);
            driver.FindElement(By.Id("username")).SendKeys("Hakan Tancan");
            driver.FindElement(By.Id("phone")).SendKeys("05372890104");
            driver.FindElement(By.Id("adress")).SendKeys("Elazığ Merkez");
            var captcha = driver.FindElement(By.Id("captchaa"));
            string captchaSource = captcha.GetAttribute("src");
            var captchaText = OCRHelper.Recognize(captchaSource);
            driver.FindElement(By.Id("captcha")).SendKeys(captchaText);
            driver.FindElement(By.Id("submitbutton")).Click();
            







        }
    }
}
