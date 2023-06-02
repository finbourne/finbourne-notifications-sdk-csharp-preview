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
    /// The information required to create or update an Api request notification
    /// </summary>
    [DataContract(Name = "ApiRequestNotificationType")]
    public partial class ApiRequestNotificationType : IEquatable<ApiRequestNotificationType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiRequestNotificationType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApiRequestNotificationType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiRequestNotificationType" /> class.
        /// </summary>
        /// <param name="type">The type of delivery mechanism for this notification (required).</param>
        /// <param name="httpMethod">The HTTP method such as GET, POST, etc. to use on the Api Request (required).</param>
        /// <param name="pathAndQuery">The url to send the request to. (required).</param>
        /// <param name="content">The content of the request.</param>
        public ApiRequestNotificationType(string type = default(string), string httpMethod = default(string), string pathAndQuery = default(string), Object content = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for ApiRequestNotificationType and cannot be null");
            }
            this.Type = type;
            // to ensure "httpMethod" is required (not null)
            if (httpMethod == null)
            {
                throw new ArgumentNullException("httpMethod is a required property for ApiRequestNotificationType and cannot be null");
            }
            this.HttpMethod = httpMethod;
            // to ensure "pathAndQuery" is required (not null)
            if (pathAndQuery == null)
            {
                throw new ArgumentNullException("pathAndQuery is a required property for ApiRequestNotificationType and cannot be null");
            }
            this.PathAndQuery = pathAndQuery;
            this.Content = content;
        }

        /// <summary>
        /// The type of delivery mechanism for this notification
        /// </summary>
        /// <value>The type of delivery mechanism for this notification</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The HTTP method such as GET, POST, etc. to use on the Api Request
        /// </summary>
        /// <value>The HTTP method such as GET, POST, etc. to use on the Api Request</value>
        [DataMember(Name = "httpMethod", IsRequired = true, EmitDefaultValue = true)]
        public string HttpMethod { get; set; }

        /// <summary>
        /// The url to send the request to.
        /// </summary>
        /// <value>The url to send the request to.</value>
        [DataMember(Name = "pathAndQuery", IsRequired = true, EmitDefaultValue = true)]
        public string PathAndQuery { get; set; }

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
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiRequestNotificationType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  PathAndQuery: ").Append(PathAndQuery).Append("\n");
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
            return this.Equals(input as ApiRequestNotificationType);
        }

        /// <summary>
        /// Returns true if ApiRequestNotificationType instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiRequestNotificationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiRequestNotificationType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    (this.HttpMethod != null &&
                    this.HttpMethod.Equals(input.HttpMethod))
                ) && 
                (
                    this.PathAndQuery == input.PathAndQuery ||
                    (this.PathAndQuery != null &&
                    this.PathAndQuery.Equals(input.PathAndQuery))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.HttpMethod != null)
                {
                    hashCode = (hashCode * 59) + this.HttpMethod.GetHashCode();
                }
                if (this.PathAndQuery != null)
                {
                    hashCode = (hashCode * 59) + this.PathAndQuery.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
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
            // Type (string) minLength
            if (this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            // HttpMethod (string) minLength
            if (this.HttpMethod != null && this.HttpMethod.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HttpMethod, length must be greater than 1.", new [] { "HttpMethod" });
            }

            // PathAndQuery (string) maxLength
            if (this.PathAndQuery != null && this.PathAndQuery.Length > 16384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PathAndQuery, length must be less than 16384.", new [] { "PathAndQuery" });
            }

            // PathAndQuery (string) minLength
            if (this.PathAndQuery != null && this.PathAndQuery.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PathAndQuery, length must be greater than 1.", new [] { "PathAndQuery" });
            }

            // PathAndQuery (string) pattern
            Regex regexPathAndQuery = new Regex(@"^([A-Za-z0-9-._~:\/?#[\]@!$&'()*+,;%=]|(\{\{([a-zA-Z0-9\s])*\}\}))*$", RegexOptions.CultureInvariant);
            if (false == regexPathAndQuery.Match(this.PathAndQuery).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PathAndQuery, must match a pattern of " + regexPathAndQuery, new [] { "PathAndQuery" });
            }

            yield break;
        }
    }
}
