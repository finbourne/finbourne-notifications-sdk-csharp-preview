/*
 * FINBOURNE Notifications API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.503
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
    /// The information required to update a Webhook notification
    /// </summary>
    [DataContract(Name = "UpdateWebhookNotification")]
    public partial class UpdateWebhookNotification : IEquatable<UpdateWebhookNotification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookNotification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateWebhookNotification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateWebhookNotification" /> class.
        /// </summary>
        /// <param name="description">The summary of the services provided by the notification (required).</param>
        /// <param name="httpMethod">The HTTP method such as GET, POST, etc. to use on the request (required).</param>
        /// <param name="url">The URL to send the request to (required).</param>
        /// <param name="authenticationType">The type of authentication to use on the request (required).</param>
        /// <param name="authenticationConfigurationItemPaths">The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39;                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      }.</param>
        /// <param name="contentType">The type of the content e.g. Json.</param>
        /// <param name="content">The content of the request.</param>
        public UpdateWebhookNotification(string description = default(string), string httpMethod = default(string), string url = default(string), string authenticationType = default(string), Dictionary<string, string> authenticationConfigurationItemPaths = default(Dictionary<string, string>), string contentType = default(string), Object content = default(Object))
        {
            // to ensure "description" is required (not null)
            this.Description = description ?? throw new ArgumentNullException("description is a required property for UpdateWebhookNotification and cannot be null");
            // to ensure "httpMethod" is required (not null)
            this.HttpMethod = httpMethod ?? throw new ArgumentNullException("httpMethod is a required property for UpdateWebhookNotification and cannot be null");
            // to ensure "url" is required (not null)
            this.Url = url ?? throw new ArgumentNullException("url is a required property for UpdateWebhookNotification and cannot be null");
            // to ensure "authenticationType" is required (not null)
            this.AuthenticationType = authenticationType ?? throw new ArgumentNullException("authenticationType is a required property for UpdateWebhookNotification and cannot be null");
            this.AuthenticationConfigurationItemPaths = authenticationConfigurationItemPaths;
            this.ContentType = contentType;
            this.Content = content;
        }

        /// <summary>
        /// The summary of the services provided by the notification
        /// </summary>
        /// <value>The summary of the services provided by the notification</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The HTTP method such as GET, POST, etc. to use on the request
        /// </summary>
        /// <value>The HTTP method such as GET, POST, etc. to use on the request</value>
        [DataMember(Name = "httpMethod", IsRequired = true, EmitDefaultValue = false)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The URL to send the request to
        /// </summary>
        /// <value>The URL to send the request to</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// The type of authentication to use on the request
        /// </summary>
        /// <value>The type of authentication to use on the request</value>
        [DataMember(Name = "authenticationType", IsRequired = true, EmitDefaultValue = false)]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39;                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      }
        /// </summary>
        /// <value>The paths of the Configuration Store configuration items that contain the authentication configuration. Each  authentication type requires different keys:  - Lusid - None required  - BasicAuth - Requires &#39;Username&#39; and &#39;Password&#39;  - BearerToken - Requires &#39;BearerToken&#39;                e.g. the following would be valid assuming that the config is present in the configuration store at the  specified paths:                    \&quot;authenticationType\&quot;: \&quot;BasicAuth\&quot;,      \&quot;authenticationConfigurationItemPaths\&quot;: {          \&quot;Username\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminUser\&quot;,          \&quot;Password\&quot;: \&quot;config://personal/myUserId/WebhookConfigurations/ExampleService/AdminPassword\&quot;      }</value>
        [DataMember(Name = "authenticationConfigurationItemPaths", EmitDefaultValue = true)]
        public Dictionary<string, string> AuthenticationConfigurationItemPaths { get; set; }

        /// <summary>
        /// The type of the content e.g. Json
        /// </summary>
        /// <value>The type of the content e.g. Json</value>
        [DataMember(Name = "contentType", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// The content of the request
        /// </summary>
        /// <value>The content of the request</value>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public Object Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateWebhookNotification {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  AuthenticationType: ").Append(AuthenticationType).Append("\n");
            sb.Append("  AuthenticationConfigurationItemPaths: ").Append(AuthenticationConfigurationItemPaths).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as UpdateWebhookNotification);
        }

        /// <summary>
        /// Returns true if UpdateWebhookNotification instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateWebhookNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateWebhookNotification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    (this.HttpMethod != null &&
                    this.HttpMethod.Equals(input.HttpMethod))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.AuthenticationType == input.AuthenticationType ||
                    (this.AuthenticationType != null &&
                    this.AuthenticationType.Equals(input.AuthenticationType))
                ) && 
                (
                    this.AuthenticationConfigurationItemPaths == input.AuthenticationConfigurationItemPaths ||
                    this.AuthenticationConfigurationItemPaths != null &&
                    input.AuthenticationConfigurationItemPaths != null &&
                    this.AuthenticationConfigurationItemPaths.SequenceEqual(input.AuthenticationConfigurationItemPaths)
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.HttpMethod != null)
                    hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.AuthenticationType != null)
                    hashCode = hashCode * 59 + this.AuthenticationType.GetHashCode();
                if (this.AuthenticationConfigurationItemPaths != null)
                    hashCode = hashCode * 59 + this.AuthenticationConfigurationItemPaths.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                return hashCode;
            }
        }

    }
}
