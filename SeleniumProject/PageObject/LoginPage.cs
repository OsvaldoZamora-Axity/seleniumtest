using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumProject.PageObject
{
    /*
     * Pagina para representar la página del login
     */
    public class LoginPage
    {
        //Selenium Driver
        protected IWebDriver Driver;

        //Localizadores
        protected By UserInput = By.Id("user-name");
        protected By PasswordInput = By.Id("password");
        protected By LoginButton = By.Id("login-button");

        //Constructor. Lanza una excepción si el título de la página del Login no es el correcto
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;

            if(!Driver.Title.Equals("Swag Labs"))
                throw new Exception("This is not the login page");
        }

        //Método para escribir el usuario
        public void TypeUserName(string user)
        {
            Driver.FindElement(UserInput).SendKeys(user);
        }

        //Método para escribir el password
        public void TypePassword(string password)
        {
            Driver.FindElement(PasswordInput).SendKeys(password);
        }
        //Método para hacer click en el botón login
        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButton).Click();
        }
        
        //Método para logearse. Retoma la página del Formulario de Empleado
        public EmployeePage LoginAs(string user, string password)
        {
            TypeUserName(user);
            TypePassword(password);
            ClickLoginButton();
            return new EmployeePage(Driver);
        }
        
    }
}
