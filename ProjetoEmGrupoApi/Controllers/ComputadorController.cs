using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoEmGrupoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputadorController : ControllerBase
    {
        private ComputadorRepository repo;

        public ComputadorController()
        {
            this.repo = new ComputadorRepository();
        }

        [HttpGet("TrazerTodosComputadores")]
        public List<Computador> GetAll()
        {
            return this.repo.GetAll();
        }

        [HttpGet("TrazerComputadorPorId")]
        public Computador GetById(int id)
        {
            return this.repo.GetById(id);
        }

        [HttpPost("InserirComputador")]
        public string InserirComputador(Computador model)
        {
            return this.repo.Create(model);
        }

        [HttpPut("AtualizarComputador")]
        public string AtualizarComputador(Computador model)
        {
            return this.repo.Update(model);
        }

        [HttpDelete("DeletarComputador")]
        public string DeletarComputador(int id)
        {
            return this.repo.Delete(id);
        }
    }
}
