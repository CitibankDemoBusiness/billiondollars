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
    /// ApplicationAddRequest
    /// </summary>
    [DataContract]
        public partial class ApplicationAddRequest :  IEquatable<ApplicationAddRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationAddRequest" /> class.
        /// </summary>
        /// <param name="product">product (required).</param>
        /// <param name="applicant">applicant (required).</param>
        public ApplicationAddRequest(ApplicationAddProduct product = default(ApplicationAddProduct), ApplicationAddApplicant applicant = default(ApplicationAddApplicant))
        {
            // to ensure "product" is required (not null)
            if (product == null)
            {
                throw new InvalidDataException("product is a required property for ApplicationAddRequest and cannot be null");
            }
            else
            {
                this.Product = product;
            }
            // to ensure "applicant" is required (not null)
            if (applicant == null)
            {
                throw new InvalidDataException("applicant is a required property for ApplicationAddRequest and cannot be null");
            }
            else
            {
                this.Applicant = applicant;
            }
        }
        
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public ApplicationAddProduct Product { get; set; }

        /// <summary>
        /// Gets or Sets Applicant
        /// </summary>
        [DataMember(Name="applicant", EmitDefaultValue=false)]
        public ApplicationAddApplicant Applicant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationAddRequest {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Applicant: ").Append(Applicant).Append("\n");
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
            return this.Equals(input as ApplicationAddRequest);
        }

        /// <summary>
        /// Returns true if ApplicationAddRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationAddRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationAddRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Applicant == input.Applicant ||
                    (this.Applicant != null &&
                    this.Applicant.Equals(input.Applicant))
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
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Applicant != null)
                    hashCode = hashCode * 59 + this.Applicant.GetHashCode();
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
