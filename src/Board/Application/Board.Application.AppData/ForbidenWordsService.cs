using Board.Contracts;

namespace Board.Application.AppData;

/// <summary>
/// Реализация сервиса запрещенных слов
/// </summary>
public class ForbidenWordsService : IForbidenWordsService

{
    /// <summary>
    /// Метод получения запрещенных слов
    /// </summary>
    /// <returns>Список запрещенных слов</returns>
    public string[] GetForbidenWords()
    {
        return new[] {"мопед"};
    }

}
