using System.ComponentModel.DataAnnotations;
using Board.Contracts.Attributes;

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
    [Required(ErrorMessage = "Наименование не указано")]
    [StringLength(32, ErrorMessage = "Наименование слишком длинное", MinimumLength = 3)]
    [NameValidation]
    public string Name {  get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    /// <value></value>
    public string Description { get; set; }

    /// <summary>
    /// Номер объявления
    /// </summary>
    /// <value></value>
    [Range (1,9)]
    public int Number { get; set; }

    /// <summary>
    /// Тэги
    /// </summary>
    /// <value></value>
    [MaxLength(3)]
    public int[] Tags { get; set; }

    /// <summary>
    /// Дата создания
    /// </summary>
    /// <value></value>
    public DateTime CreationDate { get; set; }
 
}
