/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.927
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
    /// The information required to create a notification which, when processed, will send an notification to Amazon SQS
    /// </summary>
    [DataContract(Name = "CreateAwsSqsNotification")]
    public partial class CreateAwsSqsNotification : IEquatable<CreateAwsSqsNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAwsSqsNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAwsSqsNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAwsSqsNotification" /> class.
        /// </summary>
        /// <param name="apiKeyRef">Reference to API key from Configuration Store (required).</param>
        /// <param name="apiSecretRef">Reference to API secret from Configuration Store (required).</param>
        /// <param name="body">The body of the Amazon Queue Message (required).</param>
        /// <param name="description">The summary of the services provided by the notification (required).</param>
        /// <param name="queueUrlRef">Reference to queue url from Configuration Store (required).</param>
        public CreateAwsSqsNotification(string apiKeyRef = default(string), string apiSecretRef = default(string), string body = default(string), string description = default(string), string queueUrlRef = default(string))
        {
            // to ensure "apiKeyRef" is required (not null)
            this.ApiKeyRef = apiKeyRef ?? throw new ArgumentNullException("apiKeyRef is a required property for CreateAwsSqsNotification and cannot be null");
            // to ensure "apiSecretRef" is required (not null)
            this.ApiSecretRef = apiSecretRef ?? throw new ArgumentNullException("apiSecretRef is a required property for CreateAwsSqsNotification and cannot be null");
            // to ensure "body" is required (not null)
            this.Body = body ?? throw new ArgumentNullException("body is a required property for CreateAwsSqsNotification and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for CreateAwsSqsNotification and cannot be null");
            // to ensure "queueUrlRef" is required (not null)
            this.QueueUrlRef = queueUrlRef ?? throw new ArgumentNullException("queueUrlRef is a required property for CreateAwsSqsNotification and cannot be null");
        }

        /// <summary>
        /// Reference to API key from Configuration Store
        /// </summary>
        /// <value>Reference to API key from Configuration Store</value>
        [DataMember(Name = "apiKeyRef", IsRequired = true, EmitDefaultValue = false)]
        public string ApiKeyRef { get; set; }

        /// <summary>
        /// Reference to API secret from Configuration Store
        /// </summary>
        /// <value>Reference to API secret from Configuration Store</value>
        [DataMember(Name = "apiSecretRef", IsRequired = true, EmitDefaultValue = false)]
        public string ApiSecretRef { get; set; }

        /// <summary>
        /// The body of the Amazon Queue Message
        /// </summary>
        /// <value>The body of the Amazon Queue Message</value>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// The summary of the services provided by the notification
        /// </summary>
        /// <value>The summary of the services provided by the notification</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Reference to queue url from Configuration Store
        /// </summary>
        /// <value>Reference to queue url from Configuration Store</value>
        [DataMember(Name = "queueUrlRef", IsRequired = true, EmitDefaultValue = false)]
        public string QueueUrlRef { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAwsSqsNotification {\n");
            sb.Append("  ApiKeyRef: ").Append(ApiKeyRef).Append("\n");
            sb.Append("  ApiSecretRef: ").Append(ApiSecretRef).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  QueueUrlRef: ").Append(QueueUrlRef).Append("\n");
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
            return this.Equals(input as CreateAwsSqsNotification);
        }

        /// <summary>
        /// Returns true if CreateAwsSqsNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAwsSqsNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAwsSqsNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApiKeyRef == input.ApiKeyRef ||
                    (this.ApiKeyRef != null &&
                    this.ApiKeyRef.Equals(input.ApiKeyRef))
                ) && 
                (
                    this.ApiSecretRef == input.ApiSecretRef ||
                    (this.ApiSecretRef != null &&
                    this.ApiSecretRef.Equals(input.ApiSecretRef))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.QueueUrlRef == input.QueueUrlRef ||
                    (this.QueueUrlRef != null &&
                    this.QueueUrlRef.Equals(input.QueueUrlRef))
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
                if (this.ApiKeyRef != null)
                    hashCode = hashCode * 59 + this.ApiKeyRef.GetHashCode();
                if (this.ApiSecretRef != null)
                    hashCode = hashCode * 59 + this.ApiSecretRef.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.QueueUrlRef != null)
                    hashCode = hashCode * 59 + this.QueueUrlRef.GetHashCode();
                return hashCode;
            }
        }

    }
}
