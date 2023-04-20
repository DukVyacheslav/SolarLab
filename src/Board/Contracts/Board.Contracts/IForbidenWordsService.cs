namespace Board.Contracts;

/// <summary>
/// Сервис запрещенных слов
/// </summary>
public interface IForbidenWordsService
{
    string[] GetForbidenWords();
}
