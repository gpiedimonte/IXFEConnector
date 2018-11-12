/* 
 * OAuth API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model.Account
{
    /// <summary>
    /// RestHttpResponseError
    /// </summary>
    [DataContract]
    public partial class RestHttpResponseError :  IEquatable<RestHttpResponseError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RestHttpResponseError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RestHttpResponseError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RestHttpResponseError" /> class.
        /// </summary>
        /// <param name="Code">Code (required).</param>
        /// <param name="Reason">Reason (required).</param>
        /// <param name="Message">Message (required).</param>
        public RestHttpResponseError(string Code = default(string), string Reason = default(string), string Message = default(string))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for RestHttpResponseError and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Reason" is required (not null)
            if (Reason == null)
            {
                throw new InvalidDataException("Reason is a required property for RestHttpResponseError and cannot be null");
            }
            else
            {
                this.Reason = Reason;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for RestHttpResponseError and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestHttpResponseError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestHttpResponseError);
        }

        /// <summary>
        /// Returns true if RestHttpResponseError instances are equal
        /// </summary>
        /// <param name="input">Instance of RestHttpResponseError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RestHttpResponseError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
