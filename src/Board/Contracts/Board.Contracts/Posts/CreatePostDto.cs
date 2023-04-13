namespace Board.Contracts.Posts;

/// <summary>
/// Модель создания объявления
/// </summary>
public class CreatePostDto
{
    /// <summary>
    /// Наименование
    /// </summary>
    /// <value></value>
    public string Name {  get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    /// <value></value>
    public string Description { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    /// <value></value>
    public DateTime CreationDate { get; set; }
}
