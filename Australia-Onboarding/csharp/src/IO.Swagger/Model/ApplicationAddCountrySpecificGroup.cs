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
    /// ApplicationAddCountrySpecificGroup
    /// </summary>
    [DataContract]
        public partial class ApplicationAddCountrySpecificGroup :  IEquatable<ApplicationAddCountrySpecificGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationAddCountrySpecificGroup" /> class.
        /// </summary>
        /// <param name="bumiputraIndicator">Indicator to specify the regional race and other indigenous peoples of Southeast Asia, and used particularly in Malaysia. Valid values: true and false..</param>
        /// <param name="disabilityIndicator">The instruments issued to applicants are provided with special needs like brailed characters on statements. Valid values: true and false..</param>
        /// <param name="unionPayCardNumber">Applicant&#x27;s union pay card number to link the product..</param>
        /// <param name="taxFileNumber">Applicant&#x27;s tax file number to link the product..</param>
        public ApplicationAddCountrySpecificGroup(bool? bumiputraIndicator = default(bool?), bool? disabilityIndicator = default(bool?), string unionPayCardNumber = default(string), string taxFileNumber = default(string))
        {
            this.BumiputraIndicator = bumiputraIndicator;
            this.DisabilityIndicator = disabilityIndicator;
            this.UnionPayCardNumber = unionPayCardNumber;
            this.TaxFileNumber = taxFileNumber;
        }
        
        /// <summary>
        /// Indicator to specify the regional race and other indigenous peoples of Southeast Asia, and used particularly in Malaysia. Valid values: true and false.
        /// </summary>
        /// <value>Indicator to specify the regional race and other indigenous peoples of Southeast Asia, and used particularly in Malaysia. Valid values: true and false.</value>
        [DataMember(Name="bumiputraIndicator", EmitDefaultValue=false)]
        public bool? BumiputraIndicator { get; set; }

        /// <summary>
        /// The instruments issued to applicants are provided with special needs like brailed characters on statements. Valid values: true and false.
        /// </summary>
        /// <value>The instruments issued to applicants are provided with special needs like brailed characters on statements. Valid values: true and false.</value>
        [DataMember(Name="disabilityIndicator", EmitDefaultValue=false)]
        public bool? DisabilityIndicator { get; set; }

        /// <summary>
        /// Applicant&#x27;s union pay card number to link the product.
        /// </summary>
        /// <value>Applicant&#x27;s union pay card number to link the product.</value>
        [DataMember(Name="unionPayCardNumber", EmitDefaultValue=false)]
        public string UnionPayCardNumber { get; set; }

        /// <summary>
        /// Applicant&#x27;s tax file number to link the product.
        /// </summary>
        /// <value>Applicant&#x27;s tax file number to link the product.</value>
        [DataMember(Name="taxFileNumber", EmitDefaultValue=false)]
        public string TaxFileNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationAddCountrySpecificGroup {\n");
            sb.Append("  BumiputraIndicator: ").Append(BumiputraIndicator).Append("\n");
            sb.Append("  DisabilityIndicator: ").Append(DisabilityIndicator).Append("\n");
            sb.Append("  UnionPayCardNumber: ").Append(UnionPayCardNumber).Append("\n");
            sb.Append("  TaxFileNumber: ").Append(TaxFileNumber).Append("\n");
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
            return this.Equals(input as ApplicationAddCountrySpecificGroup);
        }

        /// <summary>
        /// Returns true if ApplicationAddCountrySpecificGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationAddCountrySpecificGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationAddCountrySpecificGroup input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BumiputraIndicator == input.BumiputraIndicator ||
                    (this.BumiputraIndicator != null &&
                    this.BumiputraIndicator.Equals(input.BumiputraIndicator))
                ) && 
                (
                    this.DisabilityIndicator == input.DisabilityIndicator ||
                    (this.DisabilityIndicator != null &&
                    this.DisabilityIndicator.Equals(input.DisabilityIndicator))
                ) && 
                (
                    this.UnionPayCardNumber == input.UnionPayCardNumber ||
                    (this.UnionPayCardNumber != null &&
                    this.UnionPayCardNumber.Equals(input.UnionPayCardNumber))
                ) && 
                (
                    this.TaxFileNumber == input.TaxFileNumber ||
                    (this.TaxFileNumber != null &&
                    this.TaxFileNumber.Equals(input.TaxFileNumber))
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
                if (this.BumiputraIndicator != null)
                    hashCode = hashCode * 59 + this.BumiputraIndicator.GetHashCode();
                if (this.DisabilityIndicator != null)
                    hashCode = hashCode * 59 + this.DisabilityIndicator.GetHashCode();
                if (this.UnionPayCardNumber != null)
                    hashCode = hashCode * 59 + this.UnionPayCardNumber.GetHashCode();
                if (this.TaxFileNumber != null)
                    hashCode = hashCode * 59 + this.TaxFileNumber.GetHashCode();
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
