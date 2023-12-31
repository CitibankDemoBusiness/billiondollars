/* 
 * Money Movement
 *
 * <P>The Money Movement API allow you to move money from Citi customers account. Transfers can be made to predefined payees by customer and individuals not included in the payee list</P> The segment of API will allow to perform below category of transfers:<br><br><b>Personal Transfer-</b> Allowing customer to initiate the money transfers within customer�s own Citi accounts.<br><br><b>Internal transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi accounts locally.<br><br><b>External transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other bank accounts locally.<br><br><b>Bill Payment-</b> Allowing customer to initiate the bill payment from customer Citi own accounts to billing organization.<br><br><b>Citi Global Transfer-</b> Allowing customer to initiate the money transfer from customer Citi own accounts to other Citi bank accounts across various Countries.<br><br><b>SEPA Transfer-</b> Allowing customer to initiate money transfer to other European bank accounts within the SEPA territory.<br><br><b>Cross border transfer-</b> Allowing customer to initiate money transfer from customer own account to cross border bank accounts.<br>
 *
 * OpenAPI spec version: 1.0.0e
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
    /// MerchantInformationML
    /// </summary>
    [DataContract]
        public partial class MerchantInformationML :  IEquatable<MerchantInformationML>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantInformationML" /> class.
        /// </summary>
        /// <param name="billerCategoryCode">Biller Category Code is a classification code that is assigned by a bank to a biller.This is a reference data field. Please use /v1/utilities/referenceData/{billerCategoryCode} resource to get valid value of this field with description (required).</param>
        /// <param name="merchants">merchants (required).</param>
        public MerchantInformationML(string billerCategoryCode = default(string), List<Merchant> merchants = default(List<Merchant>))
        {
            // to ensure "billerCategoryCode" is required (not null)
            if (billerCategoryCode == null)
            {
                throw new InvalidDataException("billerCategoryCode is a required property for MerchantInformationML and cannot be null");
            }
            else
            {
                this.BillerCategoryCode = billerCategoryCode;
            }
            // to ensure "merchants" is required (not null)
            if (merchants == null)
            {
                throw new InvalidDataException("merchants is a required property for MerchantInformationML and cannot be null");
            }
            else
            {
                this.Merchants = merchants;
            }
        }
        
        /// <summary>
        /// Biller Category Code is a classification code that is assigned by a bank to a biller.This is a reference data field. Please use /v1/utilities/referenceData/{billerCategoryCode} resource to get valid value of this field with description
        /// </summary>
        /// <value>Biller Category Code is a classification code that is assigned by a bank to a biller.This is a reference data field. Please use /v1/utilities/referenceData/{billerCategoryCode} resource to get valid value of this field with description</value>
        [DataMember(Name="billerCategoryCode", EmitDefaultValue=false)]
        public string BillerCategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets Merchants
        /// </summary>
        [DataMember(Name="merchants", EmitDefaultValue=false)]
        public List<Merchant> Merchants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MerchantInformationML {\n");
            sb.Append("  BillerCategoryCode: ").Append(BillerCategoryCode).Append("\n");
            sb.Append("  Merchants: ").Append(Merchants).Append("\n");
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
            return this.Equals(input as MerchantInformationML);
        }

        /// <summary>
        /// Returns true if MerchantInformationML instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantInformationML to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantInformationML input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillerCategoryCode == input.BillerCategoryCode ||
                    (this.BillerCategoryCode != null &&
                    this.BillerCategoryCode.Equals(input.BillerCategoryCode))
                ) && 
                (
                    this.Merchants == input.Merchants ||
                    this.Merchants != null &&
                    input.Merchants != null &&
                    this.Merchants.SequenceEqual(input.Merchants)
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
                if (this.BillerCategoryCode != null)
                    hashCode = hashCode * 59 + this.BillerCategoryCode.GetHashCode();
                if (this.Merchants != null)
                    hashCode = hashCode * 59 + this.Merchants.GetHashCode();
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
