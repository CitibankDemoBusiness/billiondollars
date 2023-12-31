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
    /// ProductConfirmationUpdate
    /// </summary>
    [DataContract]
        public partial class ProductConfirmationUpdate :  IEquatable<ProductConfirmationUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductConfirmationUpdate" /> class.
        /// </summary>
        /// <param name="productCode">A unique code that identifies the product.</param>
        /// <param name="sourceCode">A source code to identify the product.</param>
        /// <param name="organization">Card issuing Organisation code.</param>
        /// <param name="loanSpecificSelection">loanSpecificSelection.</param>
        public ProductConfirmationUpdate(string productCode = default(string), string sourceCode = default(string), string organization = default(string), LoanSpecificSelectionUpdate loanSpecificSelection = default(LoanSpecificSelectionUpdate))
        {
            this.ProductCode = productCode;
            this.SourceCode = sourceCode;
            this.Organization = organization;
            this.LoanSpecificSelection = loanSpecificSelection;
        }
        
        /// <summary>
        /// A unique code that identifies the product
        /// </summary>
        /// <value>A unique code that identifies the product</value>
        [DataMember(Name="productCode", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// A source code to identify the product
        /// </summary>
        /// <value>A source code to identify the product</value>
        [DataMember(Name="sourceCode", EmitDefaultValue=false)]
        public string SourceCode { get; set; }

        /// <summary>
        /// Card issuing Organisation code
        /// </summary>
        /// <value>Card issuing Organisation code</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets LoanSpecificSelection
        /// </summary>
        [DataMember(Name="loanSpecificSelection", EmitDefaultValue=false)]
        public LoanSpecificSelectionUpdate LoanSpecificSelection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductConfirmationUpdate {\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  SourceCode: ").Append(SourceCode).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  LoanSpecificSelection: ").Append(LoanSpecificSelection).Append("\n");
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
            return this.Equals(input as ProductConfirmationUpdate);
        }

        /// <summary>
        /// Returns true if ProductConfirmationUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductConfirmationUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductConfirmationUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.SourceCode == input.SourceCode ||
                    (this.SourceCode != null &&
                    this.SourceCode.Equals(input.SourceCode))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.LoanSpecificSelection == input.LoanSpecificSelection ||
                    (this.LoanSpecificSelection != null &&
                    this.LoanSpecificSelection.Equals(input.LoanSpecificSelection))
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
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
                if (this.SourceCode != null)
                    hashCode = hashCode * 59 + this.SourceCode.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.LoanSpecificSelection != null)
                    hashCode = hashCode * 59 + this.LoanSpecificSelection.GetHashCode();
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
