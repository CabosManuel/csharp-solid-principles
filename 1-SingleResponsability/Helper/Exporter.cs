using System.Collections;
using System.Reflection;
using System.Text;

namespace SingleResponsability.Helper;
public class Exporter
{
    /// <summary>
    /// Exporta la colección a <c>Students.csv</c>. Sobrescribe el archivo si existe.
    /// </summary>
    public void ExportCsv<T>(IEnumerable<T> items)
    {
        // Obtener un array de propiedades del tipo genérico
        PropertyInfo[] properties = typeof(T).GetProperties();

        StringBuilder stringBuilder = new();

        // Agregar primera fila de cabezeras (usando el nombre de las propiedades de esa clase) separadas por punto y coma
        stringBuilder.AppendLine( string.Join(";", properties.Select(p => p.Name)) );

        foreach (T item in items)
        {
            // Recorrer cada propiedad, fomatear su valor a string, almacenarlo en otro array cells y agregar
            // una linea nueva con sus valores
            string[] cells = properties.Select(
                p => FormatValue(p.GetValue(item))
            ).ToArray();
            stringBuilder.AppendLine(string.Join(";", cells));
        }

        // Ruta y nombre del archivo y crearlo
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv");
        File.WriteAllText(path, stringBuilder.ToString(), Encoding.Unicode);
    }

    /// <summary>
    /// Formatea un valor para una celda CSV (normaliza null, colecciones y strings).
    /// </summary>
    /// <returns>Cadena escapada lista para escribir en el CSV.</returns>
    private static string FormatValue(object? value)
    {
        if (value == null) return string.Empty;
        if (value is string val) return Escape(val);

        // Si es una colección IEnumerable y no es un string, recorrerla, escaparla y retornar un string separado por "|"
        if (value is IEnumerable enumerable && value is not string)
        {
            List<string> parts = [];
            foreach (object element in enumerable)
            {
               parts.Add(Escape(element?.ToString() ?? string.Empty));
            }
            return string.Join("|", parts);
        }
        return Escape(value.ToString());
    }

    /// <summary>
    /// Escapa ';' convirtiéndolo en '\;' y sustituye saltos de línea por espacios.
    /// </summary>
    /// <returns>Texto escapado.</returns>
    private static string Escape(string? input)
    {
        if (input == null) return string.Empty;
        return input
            .Replace(";", "\\;")
            .Replace("\r", " ")
            .Replace("\n", " ");
    }
}
