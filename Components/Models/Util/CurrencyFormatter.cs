using System.Globalization;

namespace Contabilidad_APP.Components.Models.Util
{
    public static class CurrencyFormatter
    {
        private static CultureInfo colombianCulture = new CultureInfo("es-CO");
        private static NumberStyles numberStyles = NumberStyles.Currency | NumberStyles.Number;

        public static string FormatToCop(string amount)
        {
            // no permite decimales
            amount.Trim().Replace(colombianCulture.NumberFormat.CurrencySymbol, "");

            if (decimal.TryParse(amount, numberStyles, colombianCulture, out decimal number))
            {
                return String.Format(colombianCulture, "{0:C0}", number).ToString();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Failed to convert the input.");
                return amount.ToString();
            }
        }
    }
}
