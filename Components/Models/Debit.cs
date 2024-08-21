using Contabilidad_APP.Components.Models.Util;

namespace Contabilidad_APP.Components.Models
{
    public class Debit
    {
        private decimal _amount;
        private DateTime _date;
        private string _description;

        public decimal Amount { get => _amount; set => _amount = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Description { get => _description; set => _description = value; }

        public Debit(decimal amount, DateTime date, string description)
        {
            _amount = amount;
            _date = date;
            _description = description;
        }

        public string FormattedAmount => CurrencyFormatter.FormatToCop(_amount.ToString());
    }
}
