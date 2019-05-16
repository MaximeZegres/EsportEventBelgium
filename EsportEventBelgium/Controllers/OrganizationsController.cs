using AutoMapper;
using EsportEventBelgium.Entities;
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
            try
            {
                var organizationsFromRepo = _esportEventRepository.GetOrganizations();
                var organizations = Mapper.Map<IEnumerable<OrganizationDTO>>(organizationsFromRepo);

                return Ok(organizations);
            } catch (Exception)
            {
                return StatusCode(500, "Unexpected fault happened. Try again later.");
            }
            
        }

        [HttpGet("{id}", Name = "GetOrganization")]
        public IActionResult GetOrganization(int id)
        {
            try
            {
                var organizationFromRepo = _esportEventRepository.GetOrganization(id);

                if (organizationFromRepo == null)
                {
                    return NotFound();
                }


                var organization = Mapper.Map<OrganizationDTO>(organizationFromRepo);
                return Ok(organization);

            } catch (Exception)
            {
                return StatusCode(500, "Unexpected fault happened. Try again later.");
            }         
        }


        [HttpPost]
        public IActionResult CreateOrganization([FromBody] OrganizationForCreationDTO organization)
        {
            if (organization == null)
            {
                return BadRequest();
            }

            var organizationEntity = Mapper.Map<Organization>(organization);

            _esportEventRepository.AddOrganization(organizationEntity);

            if (!_esportEventRepository.Save())
            {
                return StatusCode(500, "Unexpected fault happened. Try again later.");
            }

            var organizationToReturn = Mapper.Map<OrganizationDTO>(organizationEntity);

            return CreatedAtRoute("GetOrganization",
                                  new { id = organizationToReturn.Id },
                                  organizationToReturn);
        }


    }
}
