/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.386
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
    /// A notification object
    /// </summary>
    [DataContract(Name = "Notification")]
    public partial class Notification : IEquatable<Notification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Notification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="id">The identifier of the notification (required).</param>
        /// <param name="description">The summary of the services provided by the notification.</param>
        /// <param name="deliveryChannel">The medium through which the notification is delivered (required).</param>
        /// <param name="recipients">Recipient of the notification (required).</param>
        /// <param name="content">The contents of the notification (required).</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">The time at which the subscription was made (required).</param>
        /// <param name="createdBy">The user who made the subscription (required).</param>
        /// <param name="lastModifiedAt">The time at which the subscription was last modified (required).</param>
        /// <param name="lastModifiedBy">The user who last modified the subscription (required).</param>
        public Notification(string id = default(string), string description = default(string), string deliveryChannel = default(string), Dictionary<string, Object> recipients = default(Dictionary<string, Object>), Dictionary<string, Object> content = default(Dictionary<string, Object>), NotificationStatus status = default(NotificationStatus), DateTimeOffset createdAt = default(DateTimeOffset), string createdBy = default(string), DateTimeOffset lastModifiedAt = default(DateTimeOffset), string lastModifiedBy = default(string))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Notification and cannot be null");
            // to ensure "deliveryChannel" is required (not null)
            this.DeliveryChannel = deliveryChannel ?? throw new ArgumentNullException("deliveryChannel is a required property for Notification and cannot be null");
            // to ensure "recipients" is required (not null)
            this.Recipients = recipients ?? throw new ArgumentNullException("recipients is a required property for Notification and cannot be null");
            // to ensure "content" is required (not null)
            this.Content = content ?? throw new ArgumentNullException("content is a required property for Notification and cannot be null");
            this.CreatedAt = createdAt;
            // to ensure "createdBy" is required (not null)
            this.CreatedBy = createdBy ?? throw new ArgumentNullException("createdBy is a required property for Notification and cannot be null");
            this.LastModifiedAt = lastModifiedAt;
            // to ensure "lastModifiedBy" is required (not null)
            this.LastModifiedBy = lastModifiedBy ?? throw new ArgumentNullException("lastModifiedBy is a required property for Notification and cannot be null");
            this.Description = description;
            this.Status = status;
        }

        /// <summary>
        /// The identifier of the notification
        /// </summary>
        /// <value>The identifier of the notification</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The summary of the services provided by the notification
        /// </summary>
        /// <value>The summary of the services provided by the notification</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The medium through which the notification is delivered
        /// </summary>
        /// <value>The medium through which the notification is delivered</value>
        [DataMember(Name = "deliveryChannel", IsRequired = true, EmitDefaultValue = false)]
        public string DeliveryChannel { get; set; }

        /// <summary>
        /// Recipient of the notification
        /// </summary>
        /// <value>Recipient of the notification</value>
        [DataMember(Name = "recipients", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, Object> Recipients { get; set; }

        /// <summary>
        /// The contents of the notification
        /// </summary>
        /// <value>The contents of the notification</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, Object> Content { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public NotificationStatus Status { get; set; }

        /// <summary>
        /// The time at which the subscription was made
        /// </summary>
        /// <value>The time at which the subscription was made</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The user who made the subscription
        /// </summary>
        /// <value>The user who made the subscription</value>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// The time at which the subscription was last modified
        /// </summary>
        /// <value>The time at which the subscription was last modified</value>
        [DataMember(Name = "lastModifiedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset LastModifiedAt { get; set; }

        /// <summary>
        /// The user who last modified the subscription
        /// </summary>
        /// <value>The user who last modified the subscription</value>
        [DataMember(Name = "lastModifiedBy", IsRequired = true, EmitDefaultValue = false)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeliveryChannel: ").Append(DeliveryChannel).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModifiedAt: ").Append(LastModifiedAt).Append("\n");
            sb.Append("  LastModifiedBy: ").Append(LastModifiedBy).Append("\n");
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
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DeliveryChannel == input.DeliveryChannel ||
                    (this.DeliveryChannel != null &&
                    this.DeliveryChannel.Equals(input.DeliveryChannel))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.Content == input.Content ||
                    this.Content != null &&
                    input.Content != null &&
                    this.Content.SequenceEqual(input.Content)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.LastModifiedAt == input.LastModifiedAt ||
                    (this.LastModifiedAt != null &&
                    this.LastModifiedAt.Equals(input.LastModifiedAt))
                ) && 
                (
                    this.LastModifiedBy == input.LastModifiedBy ||
                    (this.LastModifiedBy != null &&
                    this.LastModifiedBy.Equals(input.LastModifiedBy))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DeliveryChannel != null)
                    hashCode = hashCode * 59 + this.DeliveryChannel.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModifiedAt != null)
                    hashCode = hashCode * 59 + this.LastModifiedAt.GetHashCode();
                if (this.LastModifiedBy != null)
                    hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
                return hashCode;
            }
        }

    }
}
