using System.ComponentModel.DataAnnotations;

namespace Board.Contracts.Attributes;

/// <summary>
/// Атрибут валидации по имени объявления
/// </summary>
public class NameValidationAttribute: ValidationAttribute
{ 
    /// <inheritdoc/>
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        string? valueAsString = value as string;

        var service = validationContext.GetService(typeof(IForbidenWordsService)) as IForbidenWordsService;

        var forbidenWords = service.GetForbidenWords();

        return forbidenWords.Contains(valueAsString) 
            ? new ValidationResult("Наименование содержит запрещенные слова")
            : ValidationResult.Success;
    }
}