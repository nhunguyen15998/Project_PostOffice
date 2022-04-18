
﻿using post_office.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace post_office.Controllers.Administrator
{
    public class AuthController : Controller
    {
        //parameters
       
        public static  List<RoleModel> ls = new List<RoleModel>() { new RoleModel() { id = 1, code = "ADMIN", name = "Admin", createdAt = DateTime.Now } ,
        new RoleModel() { id = 2, code = "MANAGER", name = "Manager", createdAt = DateTime.Now } };
      
        /*VIEW*/
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            /*var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Test send email", "vohuyhngoctramm@gmail.com"));
            message.To.Add(new MailboxAddress("hehe", "us@gmail.com"));
            message.Subject = "test mail in asp.net core";
            message.Body = new TextPart("plain")
            {
                Text = "hello this is the first time im try send mail in aspnet core"
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("vohuyhngoctramm@gmail.com", "0907283275");
                client.Send(message);
                client.Disconnect(true);
            }*/
            return View();
        }

        //role
        public IActionResult Roles()
        {
            ViewBag.lsRole = ls;
            return View();
        }

        //users
        public IActionResult Users()
        {
            ViewBag.role_ls = new SelectList(ls, "id", "name");
            ViewBag.branch_ls = new SelectList(ls, "id", "name");
            ViewBag.ls_sts = UserModel.ls_sts;
            return View();
        }

        //branches
        public IActionResult Branches()
        {
            return View();
        }

        //services

        public IActionResult Service()
        {
            return View();
        } 
        
        //product cate

        public IActionResult ProductCategory()
        {
            return View();
        }
        //product 

        public IActionResult Products()
        {

            return View();
        }
        //attributes

        public IActionResult Attributes()
        {
            ViewBag.attr = AttributeModel.ls_type;
            return View();
        }

        /*END VIEW*/

    }
}
