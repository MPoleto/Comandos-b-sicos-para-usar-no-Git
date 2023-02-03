using System.Net;
using Microsoft.AspNetCore.Mvc;
using src.Models;
using src.Services;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase 
{
    private readonly PersonService _service;

    public PersonController(PersonService service)
    {
        this._service = service;
    }

    /// <summary>
    /// Buscar os dados de uma pessoa
    /// </summary>
    /// <param name="id"> Informar o id da pessoa para recuperar os dados </param>
    /// <response code="200"> Success - Exibe os dados da pessoa cadastrada </response>
    /// <response code="404"> Not Found - Se o id não for encontrado ou for inválido </response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Person> GetById(int id)
    {
        var result = _service.FindById(id);

        if(result is null)
        {
            return NotFound(new 
            {
                msg = $"Cadastro do id {id} não foi encontrado",
                status = HttpStatusCode.NotFound
            });
        }
        return Ok(result);
    }

    /// <summary>
    /// Buscar todas as pessoas cadastradas
    /// </summary>
    /// <response code="200"> Success - Exibe os dados de todas as pessoas </response>
    /// <response code="204"> No Content - Se não houver cadastros </response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public ActionResult<List<Person>> GetAll()
    {
        // Person human = new Person("Nome", 27, "12345678900");
        // Contract newContract = new Contract("abc123", 50.63);
        // human.Contracts.Add(newContract);
        // return human;

        var result = _service.FindAll();

        if(!result.Any())
        {
            return NoContent();
        }
        return Ok(result);
    }

    /// <summary>
    /// Cadastrar os dados de uma pessoa
    /// </summary>
    /// <param name="person"> Informar os dados da pessoa e dos contratos da mesma </param>
    /// <response code="201"> Success - Exibe os dados da pessoa cadastrada </response>
    /// <response code="400"> Bad Request - Se houver algum erro </response>
    /// <response code="500"> Internal Server Error - Erro inesperado </response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<Person> Create([FromBody]Person person)
    {
        if (!ModelState.IsValid) return BadRequest();
        
        var result = _service.Add(person);
        
        return Created("Criado", result); //person
    }

    /// <summary>
    /// Alterar os dados de uma pessoa
    /// </summary>
    /// <param name="id"> Informar o id da pessoa cadastrada </param>
    /// <param name="person"> Informar os dados da pessoa e dos contratos da mesma </param>
    /// <response code="200"> Success - Exibe os dados atualizados e uma mensagem de confirmação </response>
    /// <response code="400"> Bad Request - Se houver algum erro </response>
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Object> Update([FromRoute]int id, [FromBody]Person person)
    {
        if (!ModelState.IsValid) return BadRequest();

        try
        {
            _service.Update(id, person);
        }
        catch (System.Exception)
        {
            return BadRequest(new 
            {
                msg = $"Houve erro ao enviar solicitação de atualização do id {id}",
                status = HttpStatusCode.BadRequest
            });
        }

        return Ok(new 
        {
            msg = $"Dados do id {id} atualizados",
            status = HttpStatusCode.OK
        });
    }

    /// <summary>
    /// Apagar o cadastro de uma pessoa
    /// </summary>
    /// <param name="id"> Informar o id do cadastro que será removido </param>
    /// <response code="201"> Success - Exibe os dados da pessoa cadastrada </response>
    /// <response code="200"> Success - Exibe uma mensagem de confirmação </response>
    /// <response code="500"> Internal Server Error - Erro inesperado </response>
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public ActionResult<Object> Delete([FromRoute]int id)
    {
        _service.Remove(id);

        return Ok(new 
        {
            msg = $"Id {id} deletado",
            status = HttpStatusCode.OK
        });
    }
}