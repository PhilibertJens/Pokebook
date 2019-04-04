using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokebook.core.Data;
using Pokebook.core.Models;
using Pokebook.core.Repositories;
using System;
using System.Threading.Tasks;

namespace Pokebook.api.Controllers
{
    public class ControllerCrudBase<T> : ControllerBase 
        where T : EntityBase//TODO: ask how to implement this all
    {
        public IRepository<T> Repository { get; set; }
        protected UnitOfWork unitOfWork;
        public ControllerCrudBase(PokebookContext dbc, IMapper m, GenericRepository<T> repo)
        {
            Repository = repo;
            unitOfWork = new UnitOfWork(dbc, m);
        }
        // GET: api/T
        [HttpGet]
        public virtual IActionResult Get()
        {
            return Ok(Repository.ListAll());
        }

        // GET: api/T/2
        [HttpGet("{id}")]
        public virtual IActionResult Get(Guid id)
        {
            return Ok(Repository.FindById(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromRoute] Guid id, [FromBody] T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != entity.Id)
            {
                return BadRequest();
            }

            int dbChanges = unitOfWork.Complete();
            if (dbChanges == 0)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        // POST: api/T
        [HttpPost]
        public IActionResult Post([FromBody] T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            T e = Repository.Add(entity);
            int dbChanges = unitOfWork.Complete();
            if (e == null)
            {
                return NotFound();
            }
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/T/3
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var toremove = Repository.FindById(id);
            var entity = Repository.Remove(toremove);
            int dbChanges = unitOfWork.Complete();
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
    }
}
