using Microsoft.AspNetCore.Mvc;
using Pokebook.api.Models;
using Pokebook.api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokebook.api.Controllers
{
    public class ControllerCrudBase<T, R> : ControllerBase
        where T : EntityBase
        where R : Repository<T>
    {
        protected R repository;
        public ControllerCrudBase(R r)
        {
            repository = r;
        }
        // GET: api/T
        [HttpGet]
        public virtual async Task<IActionResult> Get()
        {
            return Ok(await repository.ListAll());
        }

        // GET: api/T/2
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(Guid id)
        {
            return Ok(await repository.GetById(id));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] Guid id, [FromBody] T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != entity.Id)
            {
                return BadRequest();
            }

            T e = await repository.Update(entity);
            if (e == null)
            {
                return NotFound();
            }
            return Ok(e);
        }

        // POST: api/T
        [HttpPost]
        public async Task<IActionResult> PostPublisher([FromBody] T entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            T e = await repository.Add(entity);
            if (e == null)
            {
                return NotFound();
            }
            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/T/3
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await repository.Delete(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
    }
}
