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
    /// Data
    /// </summary>
    [DataContract]
        public partial class Data :  IEquatable<Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Data" /> class.
        /// </summary>
        /// <param name="productDetails">productDetails.</param>
        /// <param name="requirements">requirements.</param>
        /// <param name="productOfferings">productOfferings.</param>
        /// <param name="feesCharges">feesCharges.</param>
        /// <param name="promotions">promotions.</param>
        public Data(DataProductDetails productDetails = default(DataProductDetails), DataRequirements requirements = default(DataRequirements), DataProductOfferings productOfferings = default(DataProductOfferings), DataFeesCharges feesCharges = default(DataFeesCharges), DataPromotions promotions = default(DataPromotions))
        {
            this.ProductDetails = productDetails;
            this.Requirements = requirements;
            this.ProductOfferings = productOfferings;
            this.FeesCharges = feesCharges;
            this.Promotions = promotions;
        }
        
        /// <summary>
        /// Gets or Sets ProductDetails
        /// </summary>
        [DataMember(Name="product_details", EmitDefaultValue=false)]
        public DataProductDetails ProductDetails { get; set; }

        /// <summary>
        /// Gets or Sets Requirements
        /// </summary>
        [DataMember(Name="requirements", EmitDefaultValue=false)]
        public DataRequirements Requirements { get; set; }

        /// <summary>
        /// Gets or Sets ProductOfferings
        /// </summary>
        [DataMember(Name="product_offerings", EmitDefaultValue=false)]
        public DataProductOfferings ProductOfferings { get; set; }

        /// <summary>
        /// Gets or Sets FeesCharges
        /// </summary>
        [DataMember(Name="fees_charges", EmitDefaultValue=false)]
        public DataFeesCharges FeesCharges { get; set; }

        /// <summary>
        /// Gets or Sets Promotions
        /// </summary>
        [DataMember(Name="promotions", EmitDefaultValue=false)]
        public DataPromotions Promotions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Data {\n");
            sb.Append("  ProductDetails: ").Append(ProductDetails).Append("\n");
            sb.Append("  Requirements: ").Append(Requirements).Append("\n");
            sb.Append("  ProductOfferings: ").Append(ProductOfferings).Append("\n");
            sb.Append("  FeesCharges: ").Append(FeesCharges).Append("\n");
            sb.Append("  Promotions: ").Append(Promotions).Append("\n");
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
            return this.Equals(input as Data);
        }

        /// <summary>
        /// Returns true if Data instances are equal
        /// </summary>
        /// <param name="input">Instance of Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductDetails == input.ProductDetails ||
                    (this.ProductDetails != null &&
                    this.ProductDetails.Equals(input.ProductDetails))
                ) && 
                (
                    this.Requirements == input.Requirements ||
                    (this.Requirements != null &&
                    this.Requirements.Equals(input.Requirements))
                ) && 
                (
                    this.ProductOfferings == input.ProductOfferings ||
                    (this.ProductOfferings != null &&
                    this.ProductOfferings.Equals(input.ProductOfferings))
                ) && 
                (
                    this.FeesCharges == input.FeesCharges ||
                    (this.FeesCharges != null &&
                    this.FeesCharges.Equals(input.FeesCharges))
                ) && 
                (
                    this.Promotions == input.Promotions ||
                    (this.Promotions != null &&
                    this.Promotions.Equals(input.Promotions))
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
                if (this.ProductDetails != null)
                    hashCode = hashCode * 59 + this.ProductDetails.GetHashCode();
                if (this.Requirements != null)
                    hashCode = hashCode * 59 + this.Requirements.GetHashCode();
                if (this.ProductOfferings != null)
                    hashCode = hashCode * 59 + this.ProductOfferings.GetHashCode();
                if (this.FeesCharges != null)
                    hashCode = hashCode * 59 + this.FeesCharges.GetHashCode();
                if (this.Promotions != null)
                    hashCode = hashCode * 59 + this.Promotions.GetHashCode();
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
