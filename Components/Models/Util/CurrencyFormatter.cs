using System.Globalization;

namespace Contabilidad_APP.Components.Models.Util
{
    public static class CurrencyFormatter
    {
        private static CultureInfo colombianCulture = new CultureInfo("es-CO");
        private static NumberStyles numberStyles = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;

        public static string FormatToCop(string amount)
        {
            // no permite decimales
            amount.Trim()
                .Replace(colombianCulture.NumberFormat.CurrencySymbol, "")
                .Replace(".", "")
                .Replace(',', '.');

            if (decimal.TryParse(amount, numberStyles, colombianCulture, out decimal number))
            {
                return string.Format(colombianCulture, "{0:C0}", number).Replace("$", "");
            }

            return "";
        }
    }
}
