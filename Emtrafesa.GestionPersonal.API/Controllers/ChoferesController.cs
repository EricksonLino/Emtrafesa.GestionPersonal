﻿using Emtrafesa.GestionPersonal.Application.Dtos;
using Emtrafesa.GestionPersonal.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emtrafesa.GestionPersonal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoferesController : ControllerBase
    {
        private readonly IChoferApplication choferApplication;

        public ChoferesController(IChoferApplication choferApplication)
        {
            this.choferApplication = choferApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<ChoferDto>>> ListarChoferes()
        {
            var choferes = await choferApplication.ListarChoferes();
            return choferes;
        }

    }
}