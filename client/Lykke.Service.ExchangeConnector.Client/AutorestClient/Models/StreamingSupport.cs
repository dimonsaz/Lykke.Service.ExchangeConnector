// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Lykke.Service.ExchangeConnector.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A description of the exchange streaming capabilities
    /// </summary>
    public partial class StreamingSupport
    {
        /// <summary>
        /// Initializes a new instance of the StreamingSupport class.
        /// </summary>
        public StreamingSupport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StreamingSupport class.
        /// </summary>
        /// <param name="orderBooks">Can stream order books</param>
        /// <param name="orders">Can stream orders updates</param>
        public StreamingSupport(bool? orderBooks = default(bool?), bool? orders = default(bool?))
        {
            OrderBooks = orderBooks;
            Orders = orders;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets can stream order books
        /// </summary>
        [JsonProperty(PropertyName = "orderBooks")]
        public bool? OrderBooks { get; private set; }

        /// <summary>
        /// Gets can stream orders updates
        /// </summary>
        [JsonProperty(PropertyName = "orders")]
        public bool? Orders { get; private set; }

    }
}
