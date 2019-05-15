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
    [Route("api / organizations /{organizationId}/events")]
    public class EventsController : Controller
    {
        private readonly IEsportEventRepository _esportEventRepository;

        public EventsController(IEsportEventRepository esportEventRepository)
        {
            _esportEventRepository = esportEventRepository;
        }

        [HttpGet]
        public IActionResult GetEventsForOrganizations(int organizationId)
        {
            var eventsForOrganizationFromRepo = _esportEventRepository.GetEventsForOrganization(organizationId);

            var eventsForOrganization = Mapper.Map<IEnumerable<EventDTO>>(eventsForOrganizationFromRepo);

            return Ok(eventsForOrganization);
        }

        [HttpGet("{id}")]
        public IActionResult GetEventForOrganizationsById(int organizationId, int eventId)
        {
            var eventForOrganizationFromRepo = _esportEventRepository.GetEventForOrganizationById(organizationId, eventId);

            var eventForOrganizationById = Mapper.Map<IEnumerable<EventDTO>>(eventForOrganizationFromRepo);

            return Ok(eventForOrganizationById);
        }


    }
}
