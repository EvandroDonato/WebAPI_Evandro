using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Evandro.Models;
using WebAPI_Evandro.Service.FuncionarioService;

namespace WebAPI_Evandro.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  //[EnableCors("AllowSpecificOrigin")]
  public class FuncionarioController : ControllerBase
  {
    private readonly IFuncionarioInterface _funcionarioInterface;
    public FuncionarioController(IFuncionarioInterface funcionarioInterface) 
    {
      _funcionarioInterface = funcionarioInterface;
    }
    
    [HttpGet("Get")]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncionarios()
    { 
      return Ok(await _funcionarioInterface.GetFuncionarios());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> GetFuncionariosByid(int id)
    {
      ServiceResponse<FuncionarioModel> serviceResponse = await _funcionarioInterface.GetFuncionarioById(id);

      return Ok(serviceResponse);
    }

    [HttpPost("Create")]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionarios(FuncionarioModel novoFuncionario)
    {
      return Ok(await _funcionarioInterface.CreateFuncionario(novoFuncionario));
    }

    [HttpPut("Inativa")]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> InativaFuncionario(int id)
    {
      ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.InativaFuncionario(id);
      return Ok(serviceResponse);
    }

    [HttpPut("Update")]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> UpdateFuncionario(FuncionarioModel editadoFuncionario)
    {
      ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.UpdateFuncionario(editadoFuncionario);
      return Ok(serviceResponse);
    }

    [HttpDelete("Delete")]
    public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> DeleteFuncionario(int id)
    {
      ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.DeleteFuncionario(id);
      return Ok(serviceResponse);
    }

  }
}
