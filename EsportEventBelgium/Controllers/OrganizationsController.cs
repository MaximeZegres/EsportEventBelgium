using AutoMapper;
using EsportEventBelgium.Models;
using EsportEventBelgium.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportEventBelgium.Controllers
{
    [Route("api/[controller]")]
    public class OrganizationsController : Controller
    {
        private readonly IEsportEventRepository _esportEventRepository;

        public OrganizationsController(IEsportEventRepository esportEventRepository)
        {
            _esportEventRepository = esportEventRepository;
        }


        [HttpGet]
        public IActionResult GetOrganizations()
        {
            var organizationsFromRepo = _esportEventRepository.GetOrganizations();
            var organizations = Mapper.Map<IEnumerable<OrganizationDTO>>(organizationsFromRepo);

            return Ok(organizations);
        }

        [HttpGet("id")]
        public IActionResult GetOrganization(int id)
        {

            var organizationFromRepo = _esportEventRepository.GetOrganization(id);
            
            if(organizationFromRepo == null)
            {
                return NotFound();
            }


            var organization = Mapper.Map<OrganizationDTO>(organizationFromRepo);
            return Ok(organization);
        }

    }
}
