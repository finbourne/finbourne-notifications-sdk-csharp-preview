/*
 * FINBOURNE Notifications API
 *
 * ### Introduction   # Error Codes   | Code|Name|Description | | - --|- --|- -- | | <a name=\"-1\">-1</a>|Unknown error|An unexpected error was encountered on our side. | | <a name=\"144\">144</a>|Duplicate In Parameter Set|  | | <a name=\"151\">151</a>|Invalid Parameter Value|  | | <a name=\"156\">156</a>|Concurrency Conflict Failure|  | | <a name=\"689\">689</a>|The supplied pagination token is invalid|  | | <a name=\"692\">692</a>|This endpoint does not support impersonation|  | | <a name=\"711\">711</a>|Subscription already exists|  | | <a name=\"712\">712</a>|Could not find subscription|  | | <a name=\"713\">713</a>|Notification already exists|  | | <a name=\"714\">714</a>|Could not find notification|  | | <a name=\"734\">734</a>|Email address is incorrectly formatted.|  | | <a name=\"740\">740</a>|Event type was missing|  | | <a name=\"741\">741</a>|Unknown event type|  | | <a name=\"747\">747</a>|Duplicate sort field used.|  | | <a name=\"748\">748</a>|Defined template attributes failure.|  | | <a name=\"749\">749</a>|Operation on wrong notification type.|  | | <a name=\"759\">759</a>|Invalid configuration item path|  | | <a name=\"760\">760</a>|Invalid configuration set type|  | | <a name=\"761\">761</a>|Invalid webhook HTTP content|  | | <a name=\"762\">762</a>|A failure occured when making a webhook request|  | | <a name=\"776\">776</a>|Delivery already exists|  | | <a name=\"777\">777</a>|Delivery not found|  | | <a name=\"779\">779</a>|Invalid message content|  | | <a name=\"794\">794</a>|Cannot modify the existing subscription.|  | | <a name=\"871\">871</a>|The specified impersonated user does not exist|  | | <a name=\"884\">884</a>|Missing licence to access feature.|  | | <a name=\"885\">885</a>|Error sending to AWS SQS.|  | 
 *
 * The version of the OpenAPI document: 0.1.1050
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
    /// The information required to create a notification which, when processed, will send an notification to Azure  Service Bus
    /// </summary>
    [DataContract(Name = "UpdateAzureServiceBusNotification")]
    public partial class UpdateAzureServiceBusNotification : IEquatable<UpdateAzureServiceBusNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzureServiceBusNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAzureServiceBusNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAzureServiceBusNotification" /> class.
        /// </summary>
        /// <param name="_namespace">Reference to namespace from Configuration Store (required).</param>
        /// <param name="queueName">Reference to  queue name from Configuration Store (required).</param>
        /// <param name="body">The body of the Azure Service Bus Message (required).</param>
        /// <param name="description">The summary of the services provided by the notification (required).</param>
        /// <param name="tenantId">Reference to tenant ID from Configuration Store (required).</param>
        /// <param name="clientId">Reference to client ID from Configuration Store (required).</param>
        /// <param name="clientSecret">Reference to client Secret from Configuration Store (required).</param>
        public UpdateAzureServiceBusNotification(string _namespace = default(string), string queueName = default(string), string body = default(string), string description = default(string), string tenantId = default(string), string clientId = default(string), string clientSecret = default(string))
        {
            // to ensure "_namespace" is required (not null)
            this.Namespace = _namespace ?? throw new ArgumentNullException("_namespace is a required property for UpdateAzureServiceBusNotification and cannot be null");
            // to ensure "queueName" is required (not null)
            this.QueueName = queueName ?? throw new ArgumentNullException("queueName is a required property for UpdateAzureServiceBusNotification and cannot be null");
            // to ensure "body" is required (not null)
            this.Body = body ?? throw new ArgumentNullException("body is a required property for UpdateAzureServiceBusNotification and cannot be null");
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for UpdateAzureServiceBusNotification and cannot be null");
            // to ensure "tenantId" is required (not null)
            this.TenantId = tenantId ?? throw new ArgumentNullException("tenantId is a required property for UpdateAzureServiceBusNotification and cannot be null");
            // to ensure "clientId" is required (not null)
            this.ClientId = clientId ?? throw new ArgumentNullException("clientId is a required property for UpdateAzureServiceBusNotification and cannot be null");
            // to ensure "clientSecret" is required (not null)
            this.ClientSecret = clientSecret ?? throw new ArgumentNullException("clientSecret is a required property for UpdateAzureServiceBusNotification and cannot be null");
        }

        /// <summary>
        /// Reference to namespace from Configuration Store
        /// </summary>
        /// <value>Reference to namespace from Configuration Store</value>
        [DataMember(Name = "namespace", IsRequired = true, EmitDefaultValue = false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Reference to  queue name from Configuration Store
        /// </summary>
        /// <value>Reference to  queue name from Configuration Store</value>
        [DataMember(Name = "queueName", IsRequired = true, EmitDefaultValue = false)]
        public string QueueName { get; set; }

        /// <summary>
        /// The body of the Azure Service Bus Message
        /// </summary>
        /// <value>The body of the Azure Service Bus Message</value>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// The summary of the services provided by the notification
        /// </summary>
        /// <value>The summary of the services provided by the notification</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Reference to tenant ID from Configuration Store
        /// </summary>
        /// <value>Reference to tenant ID from Configuration Store</value>
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Reference to client ID from Configuration Store
        /// </summary>
        /// <value>Reference to client ID from Configuration Store</value>
        [DataMember(Name = "clientId", IsRequired = true, EmitDefaultValue = false)]
        public string ClientId { get; set; }

        /// <summary>
        /// Reference to client Secret from Configuration Store
        /// </summary>
        /// <value>Reference to client Secret from Configuration Store</value>
        [DataMember(Name = "clientSecret", IsRequired = true, EmitDefaultValue = false)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAzureServiceBusNotification {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  QueueName: ").Append(QueueName).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
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
            return this.Equals(input as UpdateAzureServiceBusNotification);
        }

        /// <summary>
        /// Returns true if UpdateAzureServiceBusNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAzureServiceBusNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAzureServiceBusNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.QueueName == input.QueueName ||
                    (this.QueueName != null &&
                    this.QueueName.Equals(input.QueueName))
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.ClientSecret == input.ClientSecret ||
                    (this.ClientSecret != null &&
                    this.ClientSecret.Equals(input.ClientSecret))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.QueueName != null)
                    hashCode = hashCode * 59 + this.QueueName.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hashCode = hashCode * 59 + this.ClientSecret.GetHashCode();
                return hashCode;
            }
        }

    }
}
