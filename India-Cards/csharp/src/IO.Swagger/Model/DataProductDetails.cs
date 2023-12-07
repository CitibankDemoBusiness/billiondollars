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
    /// DataProductDetails
    /// </summary>
    [DataContract]
        public partial class DataProductDetails :  IEquatable<DataProductDetails>, IValidatableObject
    {
        /// <summary>
        /// Type of product
        /// </summary>
        /// <value>Type of product</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ProductTypeEnum
        {
            /// <summary>
            /// Enum Americanexpress for value: american_express
            /// </summary>
            [EnumMember(Value = "american_express")]
            Americanexpress = 1,
            /// <summary>
            /// Enum Jcb for value: jcb
            /// </summary>
            [EnumMember(Value = "jcb")]
            Jcb = 2,
            /// <summary>
            /// Enum Mastercard for value: mastercard
            /// </summary>
            [EnumMember(Value = "mastercard")]
            Mastercard = 3,
            /// <summary>
            /// Enum Mydebit for value: mydebit
            /// </summary>
            [EnumMember(Value = "mydebit")]
            Mydebit = 4,
            /// <summary>
            /// Enum Others for value: others
            /// </summary>
            [EnumMember(Value = "others")]
            Others = 5,
            /// <summary>
            /// Enum Switch for value: switch
            /// </summary>
            [EnumMember(Value = "switch")]
            Switch = 6,
            /// <summary>
            /// Enum Unionpay for value: unionpay
            /// </summary>
            [EnumMember(Value = "unionpay")]
            Unionpay = 7,
            /// <summary>
            /// Enum Visa for value: visa
            /// </summary>
            [EnumMember(Value = "visa")]
            Visa = 8        }
        /// <summary>
        /// Type of product
        /// </summary>
        /// <value>Type of product</value>
        [DataMember(Name="product_type", EmitDefaultValue=false)]
        public ProductTypeEnum ProductType { get; set; }
        /// <summary>
        /// Type of sub-product
        /// </summary>
        /// <value>Type of sub-product</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SubProductTypeEnum
        {
            /// <summary>
            /// Enum Black for value: black
            /// </summary>
            [EnumMember(Value = "black")]
            Black = 1,
            /// <summary>
            /// Enum Classic for value: classic
            /// </summary>
            [EnumMember(Value = "classic")]
            Classic = 2,
            /// <summary>
            /// Enum Commercial for value: commercial
            /// </summary>
            [EnumMember(Value = "commercial")]
            Commercial = 3,
            /// <summary>
            /// Enum Diamond for value: diamond
            /// </summary>
            [EnumMember(Value = "diamond")]
            Diamond = 4,
            /// <summary>
            /// Enum Electron for value: electron
            /// </summary>
            [EnumMember(Value = "electron")]
            Electron = 5,
            /// <summary>
            /// Enum Generic for value: generic
            /// </summary>
            [EnumMember(Value = "generic")]
            Generic = 6,
            /// <summary>
            /// Enum Gold for value: gold
            /// </summary>
            [EnumMember(Value = "gold")]
            Gold = 7,
            /// <summary>
            /// Enum Infinite for value: infinite
            /// </summary>
            [EnumMember(Value = "infinite")]
            Infinite = 8,
            /// <summary>
            /// Enum Infiniteprivilege for value: infinite_privilege
            /// </summary>
            [EnumMember(Value = "infinite_privilege")]
            Infiniteprivilege = 9,
            /// <summary>
            /// Enum Maestro for value: maestro
            /// </summary>
            [EnumMember(Value = "maestro")]
            Maestro = 10,
            /// <summary>
            /// Enum Others for value: others
            /// </summary>
            [EnumMember(Value = "others")]
            Others = 11,
            /// <summary>
            /// Enum Platinum for value: platinum
            /// </summary>
            [EnumMember(Value = "platinum")]
            Platinum = 12,
            /// <summary>
            /// Enum Reserve for value: reserve
            /// </summary>
            [EnumMember(Value = "reserve")]
            Reserve = 13,
            /// <summary>
            /// Enum Signature for value: signature
            /// </summary>
            [EnumMember(Value = "signature")]
            Signature = 14,
            /// <summary>
            /// Enum World for value: world
            /// </summary>
            [EnumMember(Value = "world")]
            World = 15,
            /// <summary>
            /// Enum Worldelite for value: world_elite
            /// </summary>
            [EnumMember(Value = "world_elite")]
            Worldelite = 16        }
        /// <summary>
        /// Type of sub-product
        /// </summary>
        /// <value>Type of sub-product</value>
        [DataMember(Name="sub_product_type", EmitDefaultValue=false)]
        public SubProductTypeEnum? SubProductType { get; set; }
        /// <summary>
        /// Type of card
        /// </summary>
        /// <value>Type of card</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum CardTypeEnum
        {
            /// <summary>
            /// Enum Creditcard for value: credit_card
            /// </summary>
            [EnumMember(Value = "credit_card")]
            Creditcard = 1,
            /// <summary>
            /// Enum Debitcard for value: debit_card
            /// </summary>
            [EnumMember(Value = "debit_card")]
            Debitcard = 2,
            /// <summary>
            /// Enum Chargecard for value: charge_card
            /// </summary>
            [EnumMember(Value = "charge_card")]
            Chargecard = 3,
            /// <summary>
            /// Enum Prepaidcard for value: prepaid_card
            /// </summary>
            [EnumMember(Value = "prepaid_card")]
            Prepaidcard = 4        }
        /// <summary>
        /// Type of card
        /// </summary>
        /// <value>Type of card</value>
        [DataMember(Name="card_type", EmitDefaultValue=false)]
        public CardTypeEnum CardType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataProductDetails" /> class.
        /// </summary>
        /// <param name="name">Product name (required).</param>
        /// <param name="description">Product description (required).</param>
        /// <param name="productType">Type of product (required).</param>
        /// <param name="subProductType">Type of sub-product.</param>
        /// <param name="shariahCompliance">The indicator for Islamic or Conventional card (required).</param>
        /// <param name="shariahComplianceRemark">Approval body for shariah compliance.</param>
        /// <param name="cardType">Type of card (required).</param>
        /// <param name="pdsUrl">URL for product disclosure sheet (required).</param>
        /// <param name="imageUrl">Absolute URL to image in SVG format.</param>
        /// <param name="disclaimerUrl">Absolute URL for product disclaimer.</param>
        public DataProductDetails(string name = default(string), string description = default(string), ProductTypeEnum productType = default(ProductTypeEnum), SubProductTypeEnum? subProductType = default(SubProductTypeEnum?), bool? shariahCompliance = default(bool?), string shariahComplianceRemark = default(string), CardTypeEnum cardType = default(CardTypeEnum), string pdsUrl = default(string), string imageUrl = default(string), string disclaimerUrl = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DataProductDetails and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new InvalidDataException("description is a required property for DataProductDetails and cannot be null");
            }
            else
            {
                this.Description = description;
            }
            // to ensure "productType" is required (not null)
            if (productType == null)
            {
                throw new InvalidDataException("productType is a required property for DataProductDetails and cannot be null");
            }
            else
            {
                this.ProductType = productType;
            }
            // to ensure "shariahCompliance" is required (not null)
            if (shariahCompliance == null)
            {
                throw new InvalidDataException("shariahCompliance is a required property for DataProductDetails and cannot be null");
            }
            else
            {
                this.ShariahCompliance = shariahCompliance;
            }
            // to ensure "cardType" is required (not null)
            if (cardType == null)
            {
                throw new InvalidDataException("cardType is a required property for DataProductDetails and cannot be null");
            }
            else
            {
                this.CardType = cardType;
            }
            // to ensure "pdsUrl" is required (not null)
            if (pdsUrl == null)
            {
                throw new InvalidDataException("pdsUrl is a required property for DataProductDetails and cannot be null");
            }
            else
            {
                this.PdsUrl = pdsUrl;
            }
            this.SubProductType = subProductType;
            this.ShariahComplianceRemark = shariahComplianceRemark;
            this.ImageUrl = imageUrl;
            this.DisclaimerUrl = disclaimerUrl;
        }
        
        /// <summary>
        /// Product name
        /// </summary>
        /// <value>Product name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Product description
        /// </summary>
        /// <value>Product description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }



        /// <summary>
        /// The indicator for Islamic or Conventional card
        /// </summary>
        /// <value>The indicator for Islamic or Conventional card</value>
        [DataMember(Name="shariah_compliance", EmitDefaultValue=false)]
        public bool? ShariahCompliance { get; set; }

        /// <summary>
        /// Approval body for shariah compliance
        /// </summary>
        /// <value>Approval body for shariah compliance</value>
        [DataMember(Name="shariah_compliance_remark", EmitDefaultValue=false)]
        public string ShariahComplianceRemark { get; set; }


        /// <summary>
        /// URL for product disclosure sheet
        /// </summary>
        /// <value>URL for product disclosure sheet</value>
        [DataMember(Name="pds_url", EmitDefaultValue=false)]
        public string PdsUrl { get; set; }

        /// <summary>
        /// Absolute URL to image in SVG format
        /// </summary>
        /// <value>Absolute URL to image in SVG format</value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Absolute URL for product disclaimer
        /// </summary>
        /// <value>Absolute URL for product disclaimer</value>
        [DataMember(Name="disclaimer_url", EmitDefaultValue=false)]
        public string DisclaimerUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataProductDetails {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  SubProductType: ").Append(SubProductType).Append("\n");
            sb.Append("  ShariahCompliance: ").Append(ShariahCompliance).Append("\n");
            sb.Append("  ShariahComplianceRemark: ").Append(ShariahComplianceRemark).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  PdsUrl: ").Append(PdsUrl).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  DisclaimerUrl: ").Append(DisclaimerUrl).Append("\n");
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
            return this.Equals(input as DataProductDetails);
        }

        /// <summary>
        /// Returns true if DataProductDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DataProductDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataProductDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.SubProductType == input.SubProductType ||
                    (this.SubProductType != null &&
                    this.SubProductType.Equals(input.SubProductType))
                ) && 
                (
                    this.ShariahCompliance == input.ShariahCompliance ||
                    (this.ShariahCompliance != null &&
                    this.ShariahCompliance.Equals(input.ShariahCompliance))
                ) && 
                (
                    this.ShariahComplianceRemark == input.ShariahComplianceRemark ||
                    (this.ShariahComplianceRemark != null &&
                    this.ShariahComplianceRemark.Equals(input.ShariahComplianceRemark))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.PdsUrl == input.PdsUrl ||
                    (this.PdsUrl != null &&
                    this.PdsUrl.Equals(input.PdsUrl))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.DisclaimerUrl == input.DisclaimerUrl ||
                    (this.DisclaimerUrl != null &&
                    this.DisclaimerUrl.Equals(input.DisclaimerUrl))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.SubProductType != null)
                    hashCode = hashCode * 59 + this.SubProductType.GetHashCode();
                if (this.ShariahCompliance != null)
                    hashCode = hashCode * 59 + this.ShariahCompliance.GetHashCode();
                if (this.ShariahComplianceRemark != null)
                    hashCode = hashCode * 59 + this.ShariahComplianceRemark.GetHashCode();
                if (this.CardType != null)
                    hashCode = hashCode * 59 + this.CardType.GetHashCode();
                if (this.PdsUrl != null)
                    hashCode = hashCode * 59 + this.PdsUrl.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.DisclaimerUrl != null)
                    hashCode = hashCode * 59 + this.DisclaimerUrl.GetHashCode();
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
