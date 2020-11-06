using Microsoft.AspNetCore.Mvc;
using Contacts.Models;
using System;

namespace Contacts.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public JsonResult Incluir(ContactViewModel model)
        {
            using (var db = new ContactsContext())
            {

            }
            
            if (false)
            {
                return Json(Environment.NewLine);
            }
            else
            {
                return Json("Contato adicionado com sucesso");
            }
        }
    }
}