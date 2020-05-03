using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NotebookApi.Models;

namespace NotebookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<TblUsers> Get()
        {
            using (var context = new NotebookDBContext())
            {
                //***add a user
                //TblUsers tblUser = new TblUsers();
                //tblUser.UserName = "atakanert";
                //tblUser.UserPassword = "1234";
                //context.TblUsers.Add(tblUser);
                //context.SaveChanges();

                //***update user 
                //TblUsers tblUsers = context.TblUsers.Where(user => user.UserName == "atakan").FirstOrDefault();
                //tblUsers.UserPassword = "123456767";
                //context.SaveChanges();

                //***delete user
                //TblUsers tblUsers = context.TblUsers.Where(user => user.UserName == "atakan").FirstOrDefault();
                //context.TblUsers.Remove(tblUsers);
                //context.SaveChanges();

                //***get user by paramater
                //return context.TblUsers.Where(user => user.UserName == "atakan").ToList();

                //***get all users
                return context.TblUsers.ToList();
            }
        }
    }
}
