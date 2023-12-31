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
    /// ECMCreditCardProductUpdate
    /// </summary>
    [DataContract]
        public partial class ECMCreditCardProductUpdate :  IEquatable<ECMCreditCardProductUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ECMCreditCardProductUpdate" /> class.
        /// </summary>
        /// <param name="billingAddress">Billing address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description..</param>
        /// <param name="cardDeliveryAddress">Card delivery address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description..</param>
        /// <param name="pinDeliveryAddress">Delivery address for card pin of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description..</param>
        public ECMCreditCardProductUpdate(string billingAddress = default(string), string cardDeliveryAddress = default(string), string pinDeliveryAddress = default(string))
        {
            this.BillingAddress = billingAddress;
            this.CardDeliveryAddress = cardDeliveryAddress;
            this.PinDeliveryAddress = pinDeliveryAddress;
        }
        
        /// <summary>
        /// Billing address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Billing address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public string BillingAddress { get; set; }

        /// <summary>
        /// Card delivery address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Card delivery address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.</value>
        [DataMember(Name="cardDeliveryAddress", EmitDefaultValue=false)]
        public string CardDeliveryAddress { get; set; }

        /// <summary>
        /// Delivery address for card pin of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Delivery address for card pin of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.</value>
        [DataMember(Name="pinDeliveryAddress", EmitDefaultValue=false)]
        public string PinDeliveryAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ECMCreditCardProductUpdate {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  CardDeliveryAddress: ").Append(CardDeliveryAddress).Append("\n");
            sb.Append("  PinDeliveryAddress: ").Append(PinDeliveryAddress).Append("\n");
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
            return this.Equals(input as ECMCreditCardProductUpdate);
        }

        /// <summary>
        /// Returns true if ECMCreditCardProductUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of ECMCreditCardProductUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ECMCreditCardProductUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BillingAddress == input.BillingAddress ||
                    (this.BillingAddress != null &&
                    this.BillingAddress.Equals(input.BillingAddress))
                ) && 
                (
                    this.CardDeliveryAddress == input.CardDeliveryAddress ||
                    (this.CardDeliveryAddress != null &&
                    this.CardDeliveryAddress.Equals(input.CardDeliveryAddress))
                ) && 
                (
                    this.PinDeliveryAddress == input.PinDeliveryAddress ||
                    (this.PinDeliveryAddress != null &&
                    this.PinDeliveryAddress.Equals(input.PinDeliveryAddress))
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
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.CardDeliveryAddress != null)
                    hashCode = hashCode * 59 + this.CardDeliveryAddress.GetHashCode();
                if (this.PinDeliveryAddress != null)
                    hashCode = hashCode * 59 + this.PinDeliveryAddress.GetHashCode();
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
