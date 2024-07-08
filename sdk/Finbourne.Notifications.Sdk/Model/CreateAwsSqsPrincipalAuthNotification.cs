/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.973
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
    /// The information required to create a notification which, when processed, will send an notification to Amazon SQS using principal authentication
    /// </summary>
    [DataContract(Name = "CreateAwsSqsPrincipalAuthNotification")]
    public partial class CreateAwsSqsPrincipalAuthNotification : IEquatable<CreateAwsSqsPrincipalAuthNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAwsSqsPrincipalAuthNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateAwsSqsPrincipalAuthNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAwsSqsPrincipalAuthNotification" /> class.
        /// </summary>
        /// <param name="body">The body of the Amazon Queue Message (required).</param>
        /// <param name="description">The summary of the services provided by the notification (required).</param>
        /// <param name="queueUrlRef">Reference to queue url from Configuration Store (required).</param>
        public CreateAwsSqsPrincipalAuthNotification(string body = default(string), string description = default(string), string queueUrlRef = default(string))
        {
            // to ensure "body" is required (not null)
            this.Body = body ?? throw new ArgumentNullException("body is a required property for CreateAwsSqsPrincipalAuthNotification and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for CreateAwsSqsPrincipalAuthNotification and cannot be null");
            // to ensure "queueUrlRef" is required (not null)
            this.QueueUrlRef = queueUrlRef ?? throw new ArgumentNullException("queueUrlRef is a required property for CreateAwsSqsPrincipalAuthNotification and cannot be null");
        }

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
            sb.Append("class CreateAwsSqsPrincipalAuthNotification {\n");
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
            return this.Equals(input as CreateAwsSqsPrincipalAuthNotification);
        }

        /// <summary>
        /// Returns true if CreateAwsSqsPrincipalAuthNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAwsSqsPrincipalAuthNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAwsSqsPrincipalAuthNotification input)
        {
            if (input == null)
                return false;

            return 
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
