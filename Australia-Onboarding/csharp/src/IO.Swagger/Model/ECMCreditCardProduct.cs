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
    /// ECMCreditCardProduct
    /// </summary>
    [DataContract]
        public partial class ECMCreditCardProduct :  IEquatable<ECMCreditCardProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ECMCreditCardProduct" /> class.
        /// </summary>
        /// <param name="giftCode">A unique code that identifies the gift offered along with the product.</param>
        public ECMCreditCardProduct(string giftCode = default(string))
        {
            this.GiftCode = giftCode;
        }
        
        /// <summary>
        /// A unique code that identifies the gift offered along with the product
        /// </summary>
        /// <value>A unique code that identifies the gift offered along with the product</value>
        [DataMember(Name="giftCode", EmitDefaultValue=false)]
        public string GiftCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ECMCreditCardProduct {\n");
            sb.Append("  GiftCode: ").Append(GiftCode).Append("\n");
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
            return this.Equals(input as ECMCreditCardProduct);
        }

        /// <summary>
        /// Returns true if ECMCreditCardProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of ECMCreditCardProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ECMCreditCardProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GiftCode == input.GiftCode ||
                    (this.GiftCode != null &&
                    this.GiftCode.Equals(input.GiftCode))
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
                if (this.GiftCode != null)
                    hashCode = hashCode * 59 + this.GiftCode.GetHashCode();
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
