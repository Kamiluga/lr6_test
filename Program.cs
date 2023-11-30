using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace lr6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test1 = new Test1();
        }


    }

    public class Test1
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Kamilya\\Desktop\\учеба\\_тест\\Web\\chromedriver-win64\\chromedriver.exe");
           
        }

        [Test]
        public void Testir1()
        {
            Console.WriteLine("Тестирование первого сайта: \n");
            //1
            driver.Navigate().GoToUrl("https://sites.google.com/view/vstrechha/");
            var title = driver.Title;
            Console.WriteLine("Открыта страница: " + title);
            
            //2-3
            var search3 = driver.FindElement(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[2]/div[1]/div/a"));
            Console.WriteLine("Отображается расписание: " + search3.Displayed);
            search3.Click();

            //4-5
            var search5 = driver.FindElement(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[3]/div[1]/div/a"));
            Console.WriteLine("Элемент Выступающие активен: " + search5.Enabled);
            search5.Click();

            //6
            var search6 = driver.FindElement(By.XPath("//*[@id=\"h.70b08238bba11d7c_23\"]/div/div/p/a/span"));
            Console.WriteLine("Первый участник найден: " + search6.Displayed);

            //7-8
            var search7 = driver.FindElement(By.XPath("//*[@id=\"WDxLfe\"]/ul/li[4]/div[1]/div/a"));
            Console.WriteLine("Элемент Место проведения активен: " + search7.Enabled);
            search7.Click();
            var search8 = driver.FindElement(By.Id("h.497473fdcd0c362a_0"));
            Console.WriteLine("Как добраться найдено: " + search8.Displayed);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }

    public class Test2
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Kamilya\\Desktop\\учеба\\_тест\\Web\\chromedriver-win64\\chromedriver.exe");
        }

        [Test]
        public void Testir2()
        {
            Console.WriteLine("Тестирование второго сайта: \n");
            //1
            driver.Navigate().GoToUrl("https://www.mos.ru/");
            var title = driver.Title;
            Console.WriteLine("Открыта страница: " + title);

            //2-3
            var search3 = driver.FindElement(By.XPath("//*[@id=\"mos_footer\"]/footer/div[1]/div[1]/nav/div[2]/ul/li[5]/a"));
            Console.WriteLine("Элемент Все услуги отображается: " + search3.Displayed);
            search3.Click();

            //4-5
            var search5 = driver.FindElement(By.XPath("//*[@id=\"mos-catalog_category-list\"]/div[2]/a[2]/div[2]"));
            Console.WriteLine("Элемент образование активен: " + search5.Enabled);
            search5.Click();

            //6-7
            var search7 = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div[1]/div/div[3]/div[2]/a[5]/div"));
            Console.WriteLine("Элемент ВУЗ отображается: " + search7.Displayed);
            search7.Click();

            //8
            var search8 = driver.FindElement(By.XPath("//*[@id=\"root\"]/div/div[2]/div[2]/div/div/a[1]"));
            Console.WriteLine("Элемент оформления карты москвича активен: " + search8.Enabled);
            search8.Click();
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
