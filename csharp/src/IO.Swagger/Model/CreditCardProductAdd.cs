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
    /// CreditCardProductAdd
    /// </summary>
    [DataContract]
        public partial class CreditCardProductAdd :  IEquatable<CreditCardProductAdd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardProductAdd" /> class.
        /// </summary>
        /// <param name="productCode">A unique code that identifies the product..</param>
        /// <param name="sourceCode">A source code to identify the product (required).</param>
        /// <param name="organization">Card issuing organization name (required).</param>
        /// <param name="logo">Product logo to identify the product (required).</param>
        /// <param name="requestCreditShield">Insurance enrolment for outstanding balance on the card. Valid values: true and false.</param>
        /// <param name="requestedCreditLimit">Credit limit requested by applicant for the product..</param>
        /// <param name="embossName">Name to be embossed on card.If blank, bank will assign automatically based on the market norms..</param>
        /// <param name="billingAddress">Billing address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description..</param>
        /// <param name="cardDeliveryAddress">Card delivery address of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description..</param>
        /// <param name="pinDeliveryAddress">Delivery address  for card pin of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description..</param>
        /// <param name="cardDeliveryBranch">Pick-up branch detail of the Citi bank for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryBranch} resource to get valid value of this field..</param>
        /// <param name="cardDeliveryOption">Pick-up option for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryOption} resource to get valid value of this field..</param>
        /// <param name="giftCode">A  unique code that identifies the gift offered along with the product.</param>
        /// <param name="creditLimitIncreaseIndicator">Option  to review the credit limit in the future.Valid values: true and false.</param>
        public CreditCardProductAdd(string productCode = default(string), string sourceCode = default(string), string organization = default(string), string logo = default(string), bool? requestCreditShield = default(bool?), double? requestedCreditLimit = default(double?), string embossName = default(string), string billingAddress = default(string), string cardDeliveryAddress = default(string), string pinDeliveryAddress = default(string), string cardDeliveryBranch = default(string), string cardDeliveryOption = default(string), string giftCode = default(string), bool? creditLimitIncreaseIndicator = default(bool?))
        {
            // to ensure "sourceCode" is required (not null)
            if (sourceCode == null)
            {
                throw new InvalidDataException("sourceCode is a required property for CreditCardProductAdd and cannot be null");
            }
            else
            {
                this.SourceCode = sourceCode;
            }
            // to ensure "organization" is required (not null)
            if (organization == null)
            {
                throw new InvalidDataException("organization is a required property for CreditCardProductAdd and cannot be null");
            }
            else
            {
                this.Organization = organization;
            }
            // to ensure "logo" is required (not null)
            if (logo == null)
            {
                throw new InvalidDataException("logo is a required property for CreditCardProductAdd and cannot be null");
            }
            else
            {
                this.Logo = logo;
            }
            this.ProductCode = productCode;
            this.RequestCreditShield = requestCreditShield;
            this.RequestedCreditLimit = requestedCreditLimit;
            this.EmbossName = embossName;
            this.BillingAddress = billingAddress;
            this.CardDeliveryAddress = cardDeliveryAddress;
            this.PinDeliveryAddress = pinDeliveryAddress;
            this.CardDeliveryBranch = cardDeliveryBranch;
            this.CardDeliveryOption = cardDeliveryOption;
            this.GiftCode = giftCode;
            this.CreditLimitIncreaseIndicator = creditLimitIncreaseIndicator;
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
        /// Insurance enrolment for outstanding balance on the card. Valid values: true and false
        /// </summary>
        /// <value>Insurance enrolment for outstanding balance on the card. Valid values: true and false</value>
        [DataMember(Name="requestCreditShield", EmitDefaultValue=false)]
        public bool? RequestCreditShield { get; set; }

        /// <summary>
        /// Credit limit requested by applicant for the product.
        /// </summary>
        /// <value>Credit limit requested by applicant for the product.</value>
        [DataMember(Name="requestedCreditLimit", EmitDefaultValue=false)]
        public double? RequestedCreditLimit { get; set; }

        /// <summary>
        /// Name to be embossed on card.If blank, bank will assign automatically based on the market norms.
        /// </summary>
        /// <value>Name to be embossed on card.If blank, bank will assign automatically based on the market norms.</value>
        [DataMember(Name="embossName", EmitDefaultValue=false)]
        public string EmbossName { get; set; }

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
        /// Delivery address  for card pin of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
        /// </summary>
        /// <value>Delivery address  for card pin of the applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.</value>
        [DataMember(Name="pinDeliveryAddress", EmitDefaultValue=false)]
        public string PinDeliveryAddress { get; set; }

        /// <summary>
        /// Pick-up branch detail of the Citi bank for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryBranch} resource to get valid value of this field.
        /// </summary>
        /// <value>Pick-up branch detail of the Citi bank for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryBranch} resource to get valid value of this field.</value>
        [DataMember(Name="cardDeliveryBranch", EmitDefaultValue=false)]
        public string CardDeliveryBranch { get; set; }

        /// <summary>
        /// Pick-up option for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryOption} resource to get valid value of this field.
        /// </summary>
        /// <value>Pick-up option for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryOption} resource to get valid value of this field.</value>
        [DataMember(Name="cardDeliveryOption", EmitDefaultValue=false)]
        public string CardDeliveryOption { get; set; }

        /// <summary>
        /// A  unique code that identifies the gift offered along with the product
        /// </summary>
        /// <value>A  unique code that identifies the gift offered along with the product</value>
        [DataMember(Name="giftCode", EmitDefaultValue=false)]
        public string GiftCode { get; set; }

        /// <summary>
        /// Option  to review the credit limit in the future.Valid values: true and false
        /// </summary>
        /// <value>Option  to review the credit limit in the future.Valid values: true and false</value>
        [DataMember(Name="creditLimitIncreaseIndicator", EmitDefaultValue=false)]
        public bool? CreditLimitIncreaseIndicator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditCardProductAdd {\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  SourceCode: ").Append(SourceCode).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  RequestCreditShield: ").Append(RequestCreditShield).Append("\n");
            sb.Append("  RequestedCreditLimit: ").Append(RequestedCreditLimit).Append("\n");
            sb.Append("  EmbossName: ").Append(EmbossName).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  CardDeliveryAddress: ").Append(CardDeliveryAddress).Append("\n");
            sb.Append("  PinDeliveryAddress: ").Append(PinDeliveryAddress).Append("\n");
            sb.Append("  CardDeliveryBranch: ").Append(CardDeliveryBranch).Append("\n");
            sb.Append("  CardDeliveryOption: ").Append(CardDeliveryOption).Append("\n");
            sb.Append("  GiftCode: ").Append(GiftCode).Append("\n");
            sb.Append("  CreditLimitIncreaseIndicator: ").Append(CreditLimitIncreaseIndicator).Append("\n");
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
            return this.Equals(input as CreditCardProductAdd);
        }

        /// <summary>
        /// Returns true if CreditCardProductAdd instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditCardProductAdd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCardProductAdd input)
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
                    this.RequestCreditShield == input.RequestCreditShield ||
                    (this.RequestCreditShield != null &&
                    this.RequestCreditShield.Equals(input.RequestCreditShield))
                ) && 
                (
                    this.RequestedCreditLimit == input.RequestedCreditLimit ||
                    (this.RequestedCreditLimit != null &&
                    this.RequestedCreditLimit.Equals(input.RequestedCreditLimit))
                ) && 
                (
                    this.EmbossName == input.EmbossName ||
                    (this.EmbossName != null &&
                    this.EmbossName.Equals(input.EmbossName))
                ) && 
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
                ) && 
                (
                    this.CardDeliveryBranch == input.CardDeliveryBranch ||
                    (this.CardDeliveryBranch != null &&
                    this.CardDeliveryBranch.Equals(input.CardDeliveryBranch))
                ) && 
                (
                    this.CardDeliveryOption == input.CardDeliveryOption ||
                    (this.CardDeliveryOption != null &&
                    this.CardDeliveryOption.Equals(input.CardDeliveryOption))
                ) && 
                (
                    this.GiftCode == input.GiftCode ||
                    (this.GiftCode != null &&
                    this.GiftCode.Equals(input.GiftCode))
                ) && 
                (
                    this.CreditLimitIncreaseIndicator == input.CreditLimitIncreaseIndicator ||
                    (this.CreditLimitIncreaseIndicator != null &&
                    this.CreditLimitIncreaseIndicator.Equals(input.CreditLimitIncreaseIndicator))
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
                if (this.RequestCreditShield != null)
                    hashCode = hashCode * 59 + this.RequestCreditShield.GetHashCode();
                if (this.RequestedCreditLimit != null)
                    hashCode = hashCode * 59 + this.RequestedCreditLimit.GetHashCode();
                if (this.EmbossName != null)
                    hashCode = hashCode * 59 + this.EmbossName.GetHashCode();
                if (this.BillingAddress != null)
                    hashCode = hashCode * 59 + this.BillingAddress.GetHashCode();
                if (this.CardDeliveryAddress != null)
                    hashCode = hashCode * 59 + this.CardDeliveryAddress.GetHashCode();
                if (this.PinDeliveryAddress != null)
                    hashCode = hashCode * 59 + this.PinDeliveryAddress.GetHashCode();
                if (this.CardDeliveryBranch != null)
                    hashCode = hashCode * 59 + this.CardDeliveryBranch.GetHashCode();
                if (this.CardDeliveryOption != null)
                    hashCode = hashCode * 59 + this.CardDeliveryOption.GetHashCode();
                if (this.GiftCode != null)
                    hashCode = hashCode * 59 + this.GiftCode.GetHashCode();
                if (this.CreditLimitIncreaseIndicator != null)
                    hashCode = hashCode * 59 + this.CreditLimitIncreaseIndicator.GetHashCode();
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
