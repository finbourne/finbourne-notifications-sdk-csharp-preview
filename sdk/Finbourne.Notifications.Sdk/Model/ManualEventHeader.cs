/*
 * FINBOURNE Notifications API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Notifications.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Notifications.Sdk.Model
{
    /// <summary>
    /// The header of the manual event
    /// </summary>
    [DataContract(Name = "ManualEventHeader")]
    public partial class ManualEventHeader : IEquatable<ManualEventHeader>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManualEventHeader" /> class.
        /// </summary>
        /// <param name="timestamp">The timestamp of the manual event.</param>
        /// <param name="eventId">The event ID of the manual event.</param>
        /// <param name="userId">The user ID of the manual event.</param>
        /// <param name="requestId">The request ID of the manual event.</param>
        public ManualEventHeader(DateTimeOffset timestamp = default(DateTimeOffset), string eventId = default(string), string userId = default(string), string requestId = default(string))
        {
            this.Timestamp = timestamp;
            this.EventId = eventId;
            this.UserId = userId;
            this.RequestId = requestId;
        }

        /// <summary>
        /// The timestamp of the manual event
        /// </summary>
        /// <value>The timestamp of the manual event</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The event ID of the manual event
        /// </summary>
        /// <value>The event ID of the manual event</value>
        [DataMember(Name = "eventId", EmitDefaultValue = true)]
        public string EventId { get; set; }

        /// <summary>
        /// The user ID of the manual event
        /// </summary>
        /// <value>The user ID of the manual event</value>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// The request ID of the manual event
        /// </summary>
        /// <value>The request ID of the manual event</value>
        [DataMember(Name = "requestId", EmitDefaultValue = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManualEventHeader {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ManualEventHeader);
        }

        /// <summary>
        /// Returns true if ManualEventHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of ManualEventHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManualEventHeader input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                if (this.EventId != null)
                {
                    hashCode = (hashCode * 59) + this.EventId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
