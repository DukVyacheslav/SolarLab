using Board.Contracts.Posts;

namespace Board.Application.AppData.Contexts.Posts.Services;

/// <inheritdoc />
public class PostService : IPostService 
{
    /// <inheritdoc />
    public async Task<CreatePostDto> AddPost(CreatePostDto dto, CancellationToken cancellation)
    {
        if(IsValid(dto))
        {
            //Вызов репозитория для сохраниения в БД

            //Возврат результата
            return await Task.Run(function: () => dto, cancellation);
        }
        return new CreatePostDto();
    }
    

    private bool IsValid(CreatePostDto dto)
    {
        // Логика валидации
        
        return true;
    }
}
