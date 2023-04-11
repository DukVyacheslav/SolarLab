using  Board.Contracts.Posts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Board.Host.Api.Controllers;

/// <summary>
/// Контроллер для работы с объявлениями
/// </summary>
[ApiController]
[Route(template:"[controller]")]

public class PostsController:ControllerBase 
{
    private readonly ILogger<PostsController> _logger;

    /// <summary>
    /// Инициализирует экземпляр <see cref="PostsController"/>
    /// </summary>
    /// <param name="logger"> Сервис логирования </param>
    public PostsController(ILogger<PostsController> logger)
    {
       _logger=logger; 
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet(template:"get-posts")]
    public async Task<IActionResult> Get()
    {
        _logger.LogInformation(message:$"Запрос объявлений");

        return await Task.Run(Ok);
    }

    /// <summary>
    /// Сохраняет новое объявление
    /// </summary>
    /// <param name="model"> Модель создания объявления </param>
    /// <returns> Модель созданного объявления </returns>
    [HttpPost]
    public async Task<IActionResult> CreatePost([FromBody] CreatePostDto model)
    {
        _logger.LogInformation(message:$"{JsonConvert.SerializeObject(model)}");

        return await Task.Run( function:() => Created(uri:string.Empty, value:null));
    }
}
