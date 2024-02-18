/* 
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
 *
 * OpenAPI spec version: 1.0.0
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// ECMIdentificationDocumentDetails
    /// </summary>
    [DataContract]
        public partial class ECMIdentificationDocumentDetails :  IEquatable<ECMIdentificationDocumentDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ECMIdentificationDocumentDetails" /> class.
        /// </summary>
        /// <param name="idType">Type of Identification document. This is a reference data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions.</param>
        /// <param name="idNumber">Unique identifier of identification document..</param>
        /// <param name="isPrimaryId">Flag to mark primary identification document. Valid values: true and false.</param>
        public ECMIdentificationDocumentDetails(string idType = default(string), string idNumber = default(string), bool? isPrimaryId = default(bool?))
        {
            this.IdType = idType;
            this.IdNumber = idNumber;
            this.IsPrimaryId = isPrimaryId;
        }
        
        /// <summary>
        /// Type of Identification document. This is a reference data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions
        /// </summary>
        /// <value>Type of Identification document. This is a reference data field. Please use /v1/utilities/referenceData/{idType} resource to get valid values of this field with descriptions</value>
        [DataMember(Name="idType", EmitDefaultValue=false)]
        public string IdType { get; set; }

        /// <summary>
        /// Unique identifier of identification document.
        /// </summary>
        /// <value>Unique identifier of identification document.</value>
        [DataMember(Name="idNumber", EmitDefaultValue=false)]
        public string IdNumber { get; set; }

        /// <summary>
        /// Flag to mark primary identification document. Valid values: true and false
        /// </summary>
        /// <value>Flag to mark primary identification document. Valid values: true and false</value>
        [DataMember(Name="isPrimaryId", EmitDefaultValue=false)]
        public bool? IsPrimaryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ECMIdentificationDocumentDetails {\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  IsPrimaryId: ").Append(IsPrimaryId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ECMIdentificationDocumentDetails);
        }

        /// <summary>
        /// Returns true if ECMIdentificationDocumentDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ECMIdentificationDocumentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ECMIdentificationDocumentDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdType == input.IdType ||
                    (this.IdType != null &&
                    this.IdType.Equals(input.IdType))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.IsPrimaryId == input.IsPrimaryId ||
                    (this.IsPrimaryId != null &&
                    this.IsPrimaryId.Equals(input.IsPrimaryId))
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
                if (this.IdType != null)
                    hashCode = hashCode * 59 + this.IdType.GetHashCode();
                if (this.IdNumber != null)
                    hashCode = hashCode * 59 + this.IdNumber.GetHashCode();
                if (this.IsPrimaryId != null)
                    hashCode = hashCode * 59 + this.IsPrimaryId.GetHashCode();
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