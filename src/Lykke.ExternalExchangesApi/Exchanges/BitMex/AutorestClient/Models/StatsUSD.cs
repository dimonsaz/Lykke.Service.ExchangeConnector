// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using Microsoft.Rest;
using Newtonsoft.Json;

namespace Lykke.ExternalExchangesApi.Exchanges.BitMex.AutorestClient.Models
{
    public partial class StatsUSD
    {
        /// <summary>
        /// Initializes a new instance of the StatsUSD class.
        /// </summary>
        public StatsUSD()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StatsUSD class.
        /// </summary>
        public StatsUSD(string rootSymbol, string currency = default(string), double? turnover24h = default(double?), double? turnover30d = default(double?), double? turnover365d = default(double?), double? turnover = default(double?))
        {
            RootSymbol = rootSymbol;
            Currency = currency;
            Turnover24h = turnover24h;
            Turnover30d = turnover30d;
            Turnover365d = turnover365d;
            Turnover = turnover;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rootSymbol")]
        public string RootSymbol { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "currency")]
        public string Currency { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "turnover24h")]
        public double? Turnover24h { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "turnover30d")]
        public double? Turnover30d { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "turnover365d")]
        public double? Turnover365d { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "turnover")]
        public double? Turnover { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RootSymbol == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RootSymbol");
            }
        }
    }
}
