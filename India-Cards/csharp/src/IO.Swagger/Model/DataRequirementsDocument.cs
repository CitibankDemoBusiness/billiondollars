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
    /// DataRequirementsDocument
    /// </summary>
    [DataContract]
        public partial class DataRequirementsDocument :  IEquatable<DataRequirementsDocument>, IValidatableObject
    {
        /// <summary>
        /// Type of document
        /// </summary>
        /// <value>Type of document</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ItemEnum
        {
            /// <summary>
            /// Enum Bankstatement for value: bank_statement
            /// </summary>
            [EnumMember(Value = "bank_statement")]
            Bankstatement = 1,
            /// <summary>
            /// Enum Businessregistrationcertificate for value: business_registration_certificate
            /// </summary>
            [EnumMember(Value = "business_registration_certificate")]
            Businessregistrationcertificate = 2,
            /// <summary>
            /// Enum Commisionstatement for value: commision_statement
            /// </summary>
            [EnumMember(Value = "commision_statement")]
            Commisionstatement = 3,
            /// <summary>
            /// Enum Dividendstatement for value: dividend_statement
            /// </summary>
            [EnumMember(Value = "dividend_statement")]
            Dividendstatement = 4,
            /// <summary>
            /// Enum Employmentconfirmationletter for value: employment_confirmation_letter
            /// </summary>
            [EnumMember(Value = "employment_confirmation_letter")]
            Employmentconfirmationletter = 5,
            /// <summary>
            /// Enum Epfstatement for value: epf_statement
            /// </summary>
            [EnumMember(Value = "epf_statement")]
            Epfstatement = 6,
            /// <summary>
            /// Enum Form24 for value: form_24
            /// </summary>
            [EnumMember(Value = "form_24")]
            Form24 = 7,
            /// <summary>
            /// Enum Form49 for value: form_49
            /// </summary>
            [EnumMember(Value = "form_49")]
            Form49 = 8,
            /// <summary>
            /// Enum Form9 for value: form_9
            /// </summary>
            [EnumMember(Value = "form_9")]
            Form9 = 9,
            /// <summary>
            /// Enum Identitycardpassport for value: identity_card_passport
            /// </summary>
            [EnumMember(Value = "identity_card_passport")]
            Identitycardpassport = 10,
            /// <summary>
            /// Enum Intereststatement for value: interest_statement
            /// </summary>
            [EnumMember(Value = "interest_statement")]
            Intereststatement = 11,
            /// <summary>
            /// Enum Others for value: others
            /// </summary>
            [EnumMember(Value = "others")]
            Others = 12,
            /// <summary>
            /// Enum Salaryslip for value: salary_slip
            /// </summary>
            [EnumMember(Value = "salary_slip")]
            Salaryslip = 13,
            /// <summary>
            /// Enum Taxreceipt for value: tax_receipt
            /// </summary>
            [EnumMember(Value = "tax_receipt")]
            Taxreceipt = 14,
            /// <summary>
            /// Enum Taxreturns for value: tax_returns
            /// </summary>
            [EnumMember(Value = "tax_returns")]
            Taxreturns = 15,
            /// <summary>
            /// Enum Travelvisa for value: travel_visa
            /// </summary>
            [EnumMember(Value = "travel_visa")]
            Travelvisa = 16,
            /// <summary>
            /// Enum Validworkpermit for value: valid_work_permit
            /// </summary>
            [EnumMember(Value = "valid_work_permit")]
            Validworkpermit = 17        }
        /// <summary>
        /// Type of document
        /// </summary>
        /// <value>Type of document</value>
        [DataMember(Name="item", EmitDefaultValue=false)]
        public ItemEnum? Item { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DataRequirementsDocument" /> class.
        /// </summary>
        /// <param name="item">Type of document.</param>
        /// <param name="remark">Additional note for the document.</param>
        public DataRequirementsDocument(ItemEnum? item = default(ItemEnum?), string remark = default(string))
        {
            this.Item = item;
            this.Remark = remark;
        }
        

        /// <summary>
        /// Additional note for the document
        /// </summary>
        /// <value>Additional note for the document</value>
        [DataMember(Name="remark", EmitDefaultValue=false)]
        public string Remark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataRequirementsDocument {\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
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
            return this.Equals(input as DataRequirementsDocument);
        }

        /// <summary>
        /// Returns true if DataRequirementsDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of DataRequirementsDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataRequirementsDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
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
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.Remark != null)
                    hashCode = hashCode * 59 + this.Remark.GetHashCode();
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
