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
    /// ApplicantUpdateCreditCardProduct
    /// </summary>
    [DataContract]
        public partial class ApplicantUpdateCreditCardProduct :  IEquatable<ApplicantUpdateCreditCardProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicantUpdateCreditCardProduct" /> class.
        /// </summary>
        /// <param name="embossName">Name to be embossed on card..</param>
        /// <param name="requestedCreditLimit">Credit limit accepted by applicant.</param>
        /// <param name="overseasCardActivationFlag">Flag to activate the card for overseas usage.Valid values: true and false.</param>
        public ApplicantUpdateCreditCardProduct(string embossName = default(string), double? requestedCreditLimit = default(double?), bool? overseasCardActivationFlag = default(bool?))
        {
            this.EmbossName = embossName;
            this.RequestedCreditLimit = requestedCreditLimit;
            this.OverseasCardActivationFlag = overseasCardActivationFlag;
        }
        
        /// <summary>
        /// Name to be embossed on card.
        /// </summary>
        /// <value>Name to be embossed on card.</value>
        [DataMember(Name="embossName", EmitDefaultValue=false)]
        public string EmbossName { get; set; }

        /// <summary>
        /// Credit limit accepted by applicant
        /// </summary>
        /// <value>Credit limit accepted by applicant</value>
        [DataMember(Name="requestedCreditLimit", EmitDefaultValue=false)]
        public double? RequestedCreditLimit { get; set; }

        /// <summary>
        /// Flag to activate the card for overseas usage.Valid values: true and false
        /// </summary>
        /// <value>Flag to activate the card for overseas usage.Valid values: true and false</value>
        [DataMember(Name="overseasCardActivationFlag", EmitDefaultValue=false)]
        public bool? OverseasCardActivationFlag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicantUpdateCreditCardProduct {\n");
            sb.Append("  EmbossName: ").Append(EmbossName).Append("\n");
            sb.Append("  RequestedCreditLimit: ").Append(RequestedCreditLimit).Append("\n");
            sb.Append("  OverseasCardActivationFlag: ").Append(OverseasCardActivationFlag).Append("\n");
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
            return this.Equals(input as ApplicantUpdateCreditCardProduct);
        }

        /// <summary>
        /// Returns true if ApplicantUpdateCreditCardProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicantUpdateCreditCardProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicantUpdateCreditCardProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmbossName == input.EmbossName ||
                    (this.EmbossName != null &&
                    this.EmbossName.Equals(input.EmbossName))
                ) && 
                (
                    this.RequestedCreditLimit == input.RequestedCreditLimit ||
                    (this.RequestedCreditLimit != null &&
                    this.RequestedCreditLimit.Equals(input.RequestedCreditLimit))
                ) && 
                (
                    this.OverseasCardActivationFlag == input.OverseasCardActivationFlag ||
                    (this.OverseasCardActivationFlag != null &&
                    this.OverseasCardActivationFlag.Equals(input.OverseasCardActivationFlag))
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
                if (this.EmbossName != null)
                    hashCode = hashCode * 59 + this.EmbossName.GetHashCode();
                if (this.RequestedCreditLimit != null)
                    hashCode = hashCode * 59 + this.RequestedCreditLimit.GetHashCode();
                if (this.OverseasCardActivationFlag != null)
                    hashCode = hashCode * 59 + this.OverseasCardActivationFlag.GetHashCode();
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
