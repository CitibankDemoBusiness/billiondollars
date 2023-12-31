/* 
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
    /// Applicant
    /// </summary>
    [DataContract]
        public partial class Applicant :  IEquatable<Applicant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Applicant" /> class.
        /// </summary>
        /// <param name="consentDetails">consentDetails.</param>
        /// <param name="employmentDetails">employmentDetails.</param>
        /// <param name="financialInformation">financialInformation.</param>
        /// <param name="address">address.</param>
        /// <param name="phone">phone.</param>
        public Applicant(List<ConsentDetails> consentDetails = default(List<ConsentDetails>), List<EmploymentDetails> employmentDetails = default(List<EmploymentDetails>), FinancialInformation financialInformation = default(FinancialInformation), List<Address> address = default(List<Address>), List<Phone> phone = default(List<Phone>))
        {
            this.ConsentDetails = consentDetails;
            this.EmploymentDetails = employmentDetails;
            this.FinancialInformation = financialInformation;
            this.Address = address;
            this.Phone = phone;
        }
        
        /// <summary>
        /// Gets or Sets ConsentDetails
        /// </summary>
        [DataMember(Name="consentDetails", EmitDefaultValue=false)]
        public List<ConsentDetails> ConsentDetails { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentDetails
        /// </summary>
        [DataMember(Name="employmentDetails", EmitDefaultValue=false)]
        public List<EmploymentDetails> EmploymentDetails { get; set; }

        /// <summary>
        /// Gets or Sets FinancialInformation
        /// </summary>
        [DataMember(Name="financialInformation", EmitDefaultValue=false)]
        public FinancialInformation FinancialInformation { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public List<Address> Address { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public List<Phone> Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Applicant {\n");
            sb.Append("  ConsentDetails: ").Append(ConsentDetails).Append("\n");
            sb.Append("  EmploymentDetails: ").Append(EmploymentDetails).Append("\n");
            sb.Append("  FinancialInformation: ").Append(FinancialInformation).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(input as Applicant);
        }

        /// <summary>
        /// Returns true if Applicant instances are equal
        /// </summary>
        /// <param name="input">Instance of Applicant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Applicant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConsentDetails == input.ConsentDetails ||
                    this.ConsentDetails != null &&
                    input.ConsentDetails != null &&
                    this.ConsentDetails.SequenceEqual(input.ConsentDetails)
                ) && 
                (
                    this.EmploymentDetails == input.EmploymentDetails ||
                    this.EmploymentDetails != null &&
                    input.EmploymentDetails != null &&
                    this.EmploymentDetails.SequenceEqual(input.EmploymentDetails)
                ) && 
                (
                    this.FinancialInformation == input.FinancialInformation ||
                    (this.FinancialInformation != null &&
                    this.FinancialInformation.Equals(input.FinancialInformation))
                ) && 
                (
                    this.Address == input.Address ||
                    this.Address != null &&
                    input.Address != null &&
                    this.Address.SequenceEqual(input.Address)
                ) && 
                (
                    this.Phone == input.Phone ||
                    this.Phone != null &&
                    input.Phone != null &&
                    this.Phone.SequenceEqual(input.Phone)
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
                if (this.ConsentDetails != null)
                    hashCode = hashCode * 59 + this.ConsentDetails.GetHashCode();
                if (this.EmploymentDetails != null)
                    hashCode = hashCode * 59 + this.EmploymentDetails.GetHashCode();
                if (this.FinancialInformation != null)
                    hashCode = hashCode * 59 + this.FinancialInformation.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
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
