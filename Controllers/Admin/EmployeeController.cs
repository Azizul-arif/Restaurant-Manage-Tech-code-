using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RestManage.Models;

namespace RestManage.Controllers.Admin
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EmployeeInfo(Employee obj)
        {
            string ConnectionStr = "Data Source=.;Initial Catalog=Resturant;Integrated Security=True";
            using (SqlConnection sqlCon = new SqlConnection(ConnectionStr))
            {
                string myQuery = "Insert into RES_Employee_Information (EmpName,DOB,JoiningDate,Img) values" +
                    " ('" + obj.EmployeeName + "','" + obj.Dob + "','" + obj.JoiningDate + "','" + obj.EmployeeImage + "')";

                using (SqlCommand sqlCommand = new SqlCommand(myQuery, sqlCon))
                {
                    sqlCon.Open();
                    sqlCommand.ExecuteNonQuery();

                    ViewBag.SaveMsg = "The New Employee Is " + obj.EmployeeName + " ";
                }
            }
            return View(obj);
        }
    }
}