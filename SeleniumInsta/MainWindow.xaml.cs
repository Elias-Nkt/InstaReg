using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using OpenQA.Selenium;

namespace SeleniumInsta
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IWebDriver Browser;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.instagram.com/");

            IWebElement SearchInput = Browser.FindElement(By.Name("emailOrPhone"));
            SearchInput.SendKeys(emailorPhone.Text);

            IWebElement SearchInput1 = Browser.FindElement(By.Name("fullName"));
            SearchInput1.SendKeys(nameandSurname.Text);

            IWebElement SearchInput2 = Browser.FindElement(By.Name("username"));
            SearchInput2.SendKeys(nickname.Text);

            IWebElement SearchInput3 = Browser.FindElement(By.Name("password"));
            SearchInput3.SendKeys(password.Text);

            IWebElement SearchInput4 = Browser.FindElement(By.TagName("button"));
            SearchInput3.SendKeys(Keys.Enter);

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            Browser.Quit();
        }
    }
}
