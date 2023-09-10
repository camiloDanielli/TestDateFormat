
namespace Ucu.Poo.TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd".  ̶N̷o̷ ̷s̷e̷ ̷c̷o̷n̷t̷r̷o̷l̷a̷ ̷q̷u̷e̷ ̷l̷a̷ ̷f̷e̷c̷h̷a̷ ̷r̷e̷c̷i̷b̷i̷d̷a̷ ̷t̷e̷n̷g̷a̷ ̷e̷l̷ ̷f̷o̷r̷m̷a̷t̷o̷
    ///  ̶a̷s̷u̷m̷i̷d̷o̷  ------> ahora si
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if (string.IsNullOrEmpty(date))
            {
                return string.Empty;
            } else {
                 string[] parts = date.Split('/');

                 if (parts.Length == 3 && parts[0].Length == 2 && parts[1].Length == 2 && parts[2].Length == 4)
                 {
                    return parts[2] + "-" + parts[1] + "-" + parts[0];
                 } else {
                    return string.Empty;
                 }
                
            }
}
}
