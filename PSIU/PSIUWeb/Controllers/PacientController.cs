﻿using Microsoft.AspNetCore.Mvc;
using PSIUWeb.Data.Interface;

namespace PSIUWeb.Controllers
{
    public class PacientController : Controller
    {
        private IPacientRepository pacientRepository;
        public PacientController(
            IPacientRepository _pacientRepo
        )
        {
            pacientRepository = _pacientRepo;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
