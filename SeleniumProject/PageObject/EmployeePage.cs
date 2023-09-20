using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumProject.Handler;

namespace SeleniumProject.PageObject
{
    /*
    * Pagina para representar la página del Formulario Empleado
    */
    public class EmployeePage
    {
        //Selenium Driver
        protected IWebDriver Driver;

        //Localizadores
        protected By Form = By.Id("formEmployee");


        //Constructor. Lanza una excepción si el título de la pagina del Formulario Empleado no es el correcto

        public EmployeePage(IWebDriver driver)
        {
            Driver = driver;

        if(!Driver.Title.Equals("Swag Labs"))
                throw new Exception("This is not the Employee page");
        }
        //Método para detectar si el formulario del empleado esta cargado
        //Retorna true si el elemento del formulario esta presente si no retorna falso
        public bool FormIsPresent() 
        {
            return WaitHandler.ElementIsPresent(Driver, Form);
        }

    }
}
