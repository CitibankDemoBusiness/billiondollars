/* 
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
    /// OverseasCardUsageRequest
    /// </summary>
    [DataContract]
        public partial class OverseasCardUsageRequest :  IEquatable<OverseasCardUsageRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverseasCardUsageRequest" /> class.
        /// </summary>
        /// <param name="activationRequest">activationRequest.</param>
        /// <param name="overseasCardUsageOption">Activation code for overseas card Usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardUsageOption} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values (required).</param>
        public OverseasCardUsageRequest(ActivationRequest activationRequest = default(ActivationRequest), string overseasCardUsageOption = default(string))
        {
            // to ensure "overseasCardUsageOption" is required (not null)
            if (overseasCardUsageOption == null)
            {
                throw new InvalidDataException("overseasCardUsageOption is a required property for OverseasCardUsageRequest and cannot be null");
            }
            else
            {
                this.OverseasCardUsageOption = overseasCardUsageOption;
            }
            this.ActivationRequest = activationRequest;
        }
        
        /// <summary>
        /// Gets or Sets ActivationRequest
        /// </summary>
        [DataMember(Name="ActivationRequest", EmitDefaultValue=false)]
        public ActivationRequest ActivationRequest { get; set; }

        /// <summary>
        /// Activation code for overseas card Usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardUsageOption} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values
        /// </summary>
        /// <value>Activation code for overseas card Usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardUsageOption} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values</value>
        [DataMember(Name="overseasCardUsageOption", EmitDefaultValue=false)]
        public string OverseasCardUsageOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OverseasCardUsageRequest {\n");
            sb.Append("  ActivationRequest: ").Append(ActivationRequest).Append("\n");
            sb.Append("  OverseasCardUsageOption: ").Append(OverseasCardUsageOption).Append("\n");
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
            return this.Equals(input as OverseasCardUsageRequest);
        }

        /// <summary>
        /// Returns true if OverseasCardUsageRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OverseasCardUsageRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverseasCardUsageRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivationRequest == input.ActivationRequest ||
                    (this.ActivationRequest != null &&
                    this.ActivationRequest.Equals(input.ActivationRequest))
                ) && 
                (
                    this.OverseasCardUsageOption == input.OverseasCardUsageOption ||
                    (this.OverseasCardUsageOption != null &&
                    this.OverseasCardUsageOption.Equals(input.OverseasCardUsageOption))
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
                if (this.ActivationRequest != null)
                    hashCode = hashCode * 59 + this.ActivationRequest.GetHashCode();
                if (this.OverseasCardUsageOption != null)
                    hashCode = hashCode * 59 + this.OverseasCardUsageOption.GetHashCode();
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