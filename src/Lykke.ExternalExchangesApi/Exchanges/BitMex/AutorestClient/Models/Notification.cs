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
    /// Account Notifications
    /// </summary>
    public partial class Notification
    {
        /// <summary>
        /// Initializes a new instance of the Notification class.
        /// </summary>
        public Notification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Notification class.
        /// </summary>
        /// <param name="type">Possible values include: 'success', 'error',
        /// 'info'</param>
        public Notification(System.DateTime date, string title, string body, double ttl, double? id = default(double?), string type = default(string), bool? closable = default(bool?), bool? persist = default(bool?), bool? waitForVisibility = default(bool?), string sound = default(string))
        {
            Id = id;
            Date = date;
            Title = title;
            Body = body;
            Ttl = ttl;
            Type = type;
            Closable = closable;
            Persist = persist;
            WaitForVisibility = waitForVisibility;
            Sound = sound;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public double? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        public System.DateTime Date { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public double Ttl { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'success', 'error', 'info'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "closable")]
        public bool? Closable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "persist")]
        public bool? Persist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "waitForVisibility")]
        public bool? WaitForVisibility { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sound")]
        public string Sound { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (Body == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Body");
            }
        }
    }
}
