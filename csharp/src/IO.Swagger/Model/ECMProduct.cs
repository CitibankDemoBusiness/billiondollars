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
    /// ECMProduct
    /// </summary>
    [DataContract]
        public partial class ECMProduct :  IEquatable<ECMProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ECMProduct" /> class.
        /// </summary>
        /// <param name="productCode">A unique code that identifies the product. (required).</param>
        /// <param name="sourceCode">A source code to identify the product (required).</param>
        /// <param name="organization">Card issuing organization name (required).</param>
        /// <param name="logo">Product logo to identify the product (required).</param>
        /// <param name="creditCardProduct">creditCardProduct.</param>
        public ECMProduct(string productCode = default(string), string sourceCode = default(string), string organization = default(string), string logo = default(string), ECMCreditCardProduct creditCardProduct = default(ECMCreditCardProduct))
        {
            // to ensure "productCode" is required (not null)
            if (productCode == null)
            {
                throw new InvalidDataException("productCode is a required property for ECMProduct and cannot be null");
            }
            else
            {
                this.ProductCode = productCode;
            }
            // to ensure "sourceCode" is required (not null)
            if (sourceCode == null)
            {
                throw new InvalidDataException("sourceCode is a required property for ECMProduct and cannot be null");
            }
            else
            {
                this.SourceCode = sourceCode;
            }
            // to ensure "organization" is required (not null)
            if (organization == null)
            {
                throw new InvalidDataException("organization is a required property for ECMProduct and cannot be null");
            }
            else
            {
                this.Organization = organization;
            }
            // to ensure "logo" is required (not null)
            if (logo == null)
            {
                throw new InvalidDataException("logo is a required property for ECMProduct and cannot be null");
            }
            else
            {
                this.Logo = logo;
            }
            this.CreditCardProduct = creditCardProduct;
        }
        
        /// <summary>
        /// A unique code that identifies the product.
        /// </summary>
        /// <value>A unique code that identifies the product.</value>
        [DataMember(Name="productCode", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// A source code to identify the product
        /// </summary>
        /// <value>A source code to identify the product</value>
        [DataMember(Name="sourceCode", EmitDefaultValue=false)]
        public string SourceCode { get; set; }

        /// <summary>
        /// Card issuing organization name
        /// </summary>
        /// <value>Card issuing organization name</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }

        /// <summary>
        /// Product logo to identify the product
        /// </summary>
        /// <value>Product logo to identify the product</value>
        [DataMember(Name="logo", EmitDefaultValue=false)]
        public string Logo { get; set; }

        /// <summary>
        /// Gets or Sets CreditCardProduct
        /// </summary>
        [DataMember(Name="creditCardProduct", EmitDefaultValue=false)]
        public ECMCreditCardProduct CreditCardProduct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ECMProduct {\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  SourceCode: ").Append(SourceCode).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  CreditCardProduct: ").Append(CreditCardProduct).Append("\n");
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
            return this.Equals(input as ECMProduct);
        }

        /// <summary>
        /// Returns true if ECMProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of ECMProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ECMProduct input)
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
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.CreditCardProduct == input.CreditCardProduct ||
                    (this.CreditCardProduct != null &&
                    this.CreditCardProduct.Equals(input.CreditCardProduct))
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
                if (this.Logo != null)
                    hashCode = hashCode * 59 + this.Logo.GetHashCode();
                if (this.CreditCardProduct != null)
                    hashCode = hashCode * 59 + this.CreditCardProduct.GetHashCode();
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