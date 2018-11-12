/* 
 * REGISTRY API V1
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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

namespace IO.Swagger.Model.Aoos
{
    /// <summary>
    /// AooUosListResponse
    /// </summary>
    [DataContract]
    public partial class AooUosListResponse :  IEquatable<AooUosListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AooUosListResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AooUosListResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AooUosListResponse" /> class.
        /// </summary>
        /// <param name="AooUos">AooUos (required).</param>
        public AooUosListResponse(List<AooUoInfo> AooUos = default(List<AooUoInfo>))
        {
            // to ensure "AooUos" is required (not null)
            if (AooUos == null)
            {
                throw new InvalidDataException("AooUos is a required property for AooUosListResponse and cannot be null");
            }
            else
            {
                this.AooUos = AooUos;
            }
        }
        
        /// <summary>
        /// Gets or Sets AooUos
        /// </summary>
        [DataMember(Name="aooUos", EmitDefaultValue=false)]
        public List<AooUoInfo> AooUos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AooUosListResponse {\n");
            sb.Append("  AooUos: ").Append(AooUos).Append("\n");
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
            return this.Equals(input as AooUosListResponse);
        }

        /// <summary>
        /// Returns true if AooUosListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AooUosListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AooUosListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AooUos == input.AooUos ||
                    this.AooUos != null &&
                    this.AooUos.SequenceEqual(input.AooUos)
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
                if (this.AooUos != null)
                    hashCode = hashCode * 59 + this.AooUos.GetHashCode();
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
