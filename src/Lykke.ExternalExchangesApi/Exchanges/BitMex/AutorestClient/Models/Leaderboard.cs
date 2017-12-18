// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

using Microsoft.Rest;
using Newtonsoft.Json;

namespace Lykke.ExternalExchangesApi.Exchanges.BitMex.AutorestClient.Models
{
    /// <summary>
    /// Information on Top Users
    /// </summary>
    public partial class Leaderboard
    {
        /// <summary>
        /// Initializes a new instance of the Leaderboard class.
        /// </summary>
        public Leaderboard()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Leaderboard class.
        /// </summary>
        public Leaderboard(string name, bool? isRealName = default(bool?), bool? isMe = default(bool?), double? profit = default(double?))
        {
            Name = name;
            IsRealName = isRealName;
            IsMe = isMe;
            Profit = profit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isRealName")]
        public bool? IsRealName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isMe")]
        public bool? IsMe { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "profit")]
        public double? Profit { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
