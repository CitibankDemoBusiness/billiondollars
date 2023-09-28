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
    /// ApplicationUpdateApplicant
    /// </summary>
    [DataContract]
        public partial class ApplicationUpdateApplicant :  IEquatable<ApplicationUpdateApplicant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUpdateApplicant" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="phone">phone.</param>
        /// <param name="email">email.</param>
        /// <param name="ocr">ocr.</param>
        /// <param name="demographics">demographics.</param>
        /// <param name="address">address.</param>
        /// <param name="contactPreference">contactPreference.</param>
        /// <param name="contactConsent">contactConsent.</param>
        /// <param name="financialInformation">financialInformation.</param>
        /// <param name="motherMaidenName">Mother&#x27;s maiden name.</param>
        /// <param name="education">education.</param>
        /// <param name="employmentDetails">employmentDetails.</param>
        /// <param name="identificationDocumentDetails">identificationDocumentDetails.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="partnerCustomerDetails">partnerCustomerDetails.</param>
        /// <param name="consentDetails">consentDetails.</param>
        /// <param name="marketingConsent">marketingConsent.</param>
        /// <param name="selfDeclaration">selfDeclaration.</param>
        /// <param name="kycInformation">kycInformation.</param>
        public ApplicationUpdateApplicant(ApplicationUpdateName name = default(ApplicationUpdateName), List<ApplicationUpdatePhone> phone = default(List<ApplicationUpdatePhone>), List<ApplicationUpdateEmail> email = default(List<ApplicationUpdateEmail>), ApplicationUpdateOcr ocr = default(ApplicationUpdateOcr), ApplicationUpdateDemographics demographics = default(ApplicationUpdateDemographics), List<ApplicationUpdateAddress> address = default(List<ApplicationUpdateAddress>), ApplicationUpdateContactPreference contactPreference = default(ApplicationUpdateContactPreference), ApplicationUpdateContactConsent contactConsent = default(ApplicationUpdateContactConsent), ApplicationUpdateFinancialInformation financialInformation = default(ApplicationUpdateFinancialInformation), string motherMaidenName = default(string), ApplicationUpdateEducation education = default(ApplicationUpdateEducation), List<ApplicationUpdateEmploymentDetails> employmentDetails = default(List<ApplicationUpdateEmploymentDetails>), List<ApplicationUpdateIdentificationDocumentDetails> identificationDocumentDetails = default(List<ApplicationUpdateIdentificationDocumentDetails>), ApplicationUpdateAdditionalData additionalData = default(ApplicationUpdateAdditionalData), ApplicationUpdatePartnerCustomerDetails partnerCustomerDetails = default(ApplicationUpdatePartnerCustomerDetails), List<ApplicationUpdateConsentDetails> consentDetails = default(List<ApplicationUpdateConsentDetails>), ApplicationUpdateMarketingConsent marketingConsent = default(ApplicationUpdateMarketingConsent), ApplicationUpdateSelfDeclaration selfDeclaration = default(ApplicationUpdateSelfDeclaration), ApplicationUpdateKycInformation kycInformation = default(ApplicationUpdateKycInformation))
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Ocr = ocr;
            this.Demographics = demographics;
            this.Address = address;
            this.ContactPreference = contactPreference;
            this.ContactConsent = contactConsent;
            this.FinancialInformation = financialInformation;
            this.MotherMaidenName = motherMaidenName;
            this.Education = education;
            this.EmploymentDetails = employmentDetails;
            this.IdentificationDocumentDetails = identificationDocumentDetails;
            this.AdditionalData = additionalData;
            this.PartnerCustomerDetails = partnerCustomerDetails;
            this.ConsentDetails = consentDetails;
            this.MarketingConsent = marketingConsent;
            this.SelfDeclaration = selfDeclaration;
            this.KycInformation = kycInformation;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public ApplicationUpdateName Name { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public List<ApplicationUpdatePhone> Phone { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public List<ApplicationUpdateEmail> Email { get; set; }

        /// <summary>
        /// Gets or Sets Ocr
        /// </summary>
        [DataMember(Name="ocr", EmitDefaultValue=false)]
        public ApplicationUpdateOcr Ocr { get; set; }

        /// <summary>
        /// Gets or Sets Demographics
        /// </summary>
        [DataMember(Name="demographics", EmitDefaultValue=false)]
        public ApplicationUpdateDemographics Demographics { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public List<ApplicationUpdateAddress> Address { get; set; }

        /// <summary>
        /// Gets or Sets ContactPreference
        /// </summary>
        [DataMember(Name="contactPreference", EmitDefaultValue=false)]
        public ApplicationUpdateContactPreference ContactPreference { get; set; }

        /// <summary>
        /// Gets or Sets ContactConsent
        /// </summary>
        [DataMember(Name="contactConsent", EmitDefaultValue=false)]
        public ApplicationUpdateContactConsent ContactConsent { get; set; }

        /// <summary>
        /// Gets or Sets FinancialInformation
        /// </summary>
        [DataMember(Name="financialInformation", EmitDefaultValue=false)]
        public ApplicationUpdateFinancialInformation FinancialInformation { get; set; }

        /// <summary>
        /// Mother&#x27;s maiden name
        /// </summary>
        /// <value>Mother&#x27;s maiden name</value>
        [DataMember(Name="motherMaidenName", EmitDefaultValue=false)]
        public string MotherMaidenName { get; set; }

        /// <summary>
        /// Gets or Sets Education
        /// </summary>
        [DataMember(Name="education", EmitDefaultValue=false)]
        public ApplicationUpdateEducation Education { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentDetails
        /// </summary>
        [DataMember(Name="employmentDetails", EmitDefaultValue=false)]
        public List<ApplicationUpdateEmploymentDetails> EmploymentDetails { get; set; }

        /// <summary>
        /// Gets or Sets IdentificationDocumentDetails
        /// </summary>
        [DataMember(Name="identificationDocumentDetails", EmitDefaultValue=false)]
        public List<ApplicationUpdateIdentificationDocumentDetails> IdentificationDocumentDetails { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalData
        /// </summary>
        [DataMember(Name="additionalData", EmitDefaultValue=false)]
        public ApplicationUpdateAdditionalData AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets PartnerCustomerDetails
        /// </summary>
        [DataMember(Name="partnerCustomerDetails", EmitDefaultValue=false)]
        public ApplicationUpdatePartnerCustomerDetails PartnerCustomerDetails { get; set; }

        /// <summary>
        /// Gets or Sets ConsentDetails
        /// </summary>
        [DataMember(Name="consentDetails", EmitDefaultValue=false)]
        public List<ApplicationUpdateConsentDetails> ConsentDetails { get; set; }

        /// <summary>
        /// Gets or Sets MarketingConsent
        /// </summary>
        [DataMember(Name="marketingConsent", EmitDefaultValue=false)]
        public ApplicationUpdateMarketingConsent MarketingConsent { get; set; }

        /// <summary>
        /// Gets or Sets SelfDeclaration
        /// </summary>
        [DataMember(Name="selfDeclaration", EmitDefaultValue=false)]
        public ApplicationUpdateSelfDeclaration SelfDeclaration { get; set; }

        /// <summary>
        /// Gets or Sets KycInformation
        /// </summary>
        [DataMember(Name="kycInformation", EmitDefaultValue=false)]
        public ApplicationUpdateKycInformation KycInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationUpdateApplicant {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Ocr: ").Append(Ocr).Append("\n");
            sb.Append("  Demographics: ").Append(Demographics).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ContactPreference: ").Append(ContactPreference).Append("\n");
            sb.Append("  ContactConsent: ").Append(ContactConsent).Append("\n");
            sb.Append("  FinancialInformation: ").Append(FinancialInformation).Append("\n");
            sb.Append("  MotherMaidenName: ").Append(MotherMaidenName).Append("\n");
            sb.Append("  Education: ").Append(Education).Append("\n");
            sb.Append("  EmploymentDetails: ").Append(EmploymentDetails).Append("\n");
            sb.Append("  IdentificationDocumentDetails: ").Append(IdentificationDocumentDetails).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  PartnerCustomerDetails: ").Append(PartnerCustomerDetails).Append("\n");
            sb.Append("  ConsentDetails: ").Append(ConsentDetails).Append("\n");
            sb.Append("  MarketingConsent: ").Append(MarketingConsent).Append("\n");
            sb.Append("  SelfDeclaration: ").Append(SelfDeclaration).Append("\n");
            sb.Append("  KycInformation: ").Append(KycInformation).Append("\n");
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
            return this.Equals(input as ApplicationUpdateApplicant);
        }

        /// <summary>
        /// Returns true if ApplicationUpdateApplicant instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationUpdateApplicant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUpdateApplicant input)
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
                    this.Phone == input.Phone ||
                    this.Phone != null &&
                    input.Phone != null &&
                    this.Phone.SequenceEqual(input.Phone)
                ) && 
                (
                    this.Email == input.Email ||
                    this.Email != null &&
                    input.Email != null &&
                    this.Email.SequenceEqual(input.Email)
                ) && 
                (
                    this.Ocr == input.Ocr ||
                    (this.Ocr != null &&
                    this.Ocr.Equals(input.Ocr))
                ) && 
                (
                    this.Demographics == input.Demographics ||
                    (this.Demographics != null &&
                    this.Demographics.Equals(input.Demographics))
                ) && 
                (
                    this.Address == input.Address ||
                    this.Address != null &&
                    input.Address != null &&
                    this.Address.SequenceEqual(input.Address)
                ) && 
                (
                    this.ContactPreference == input.ContactPreference ||
                    (this.ContactPreference != null &&
                    this.ContactPreference.Equals(input.ContactPreference))
                ) && 
                (
                    this.ContactConsent == input.ContactConsent ||
                    (this.ContactConsent != null &&
                    this.ContactConsent.Equals(input.ContactConsent))
                ) && 
                (
                    this.FinancialInformation == input.FinancialInformation ||
                    (this.FinancialInformation != null &&
                    this.FinancialInformation.Equals(input.FinancialInformation))
                ) && 
                (
                    this.MotherMaidenName == input.MotherMaidenName ||
                    (this.MotherMaidenName != null &&
                    this.MotherMaidenName.Equals(input.MotherMaidenName))
                ) && 
                (
                    this.Education == input.Education ||
                    (this.Education != null &&
                    this.Education.Equals(input.Education))
                ) && 
                (
                    this.EmploymentDetails == input.EmploymentDetails ||
                    this.EmploymentDetails != null &&
                    input.EmploymentDetails != null &&
                    this.EmploymentDetails.SequenceEqual(input.EmploymentDetails)
                ) && 
                (
                    this.IdentificationDocumentDetails == input.IdentificationDocumentDetails ||
                    this.IdentificationDocumentDetails != null &&
                    input.IdentificationDocumentDetails != null &&
                    this.IdentificationDocumentDetails.SequenceEqual(input.IdentificationDocumentDetails)
                ) && 
                (
                    this.AdditionalData == input.AdditionalData ||
                    (this.AdditionalData != null &&
                    this.AdditionalData.Equals(input.AdditionalData))
                ) && 
                (
                    this.PartnerCustomerDetails == input.PartnerCustomerDetails ||
                    (this.PartnerCustomerDetails != null &&
                    this.PartnerCustomerDetails.Equals(input.PartnerCustomerDetails))
                ) && 
                (
                    this.ConsentDetails == input.ConsentDetails ||
                    this.ConsentDetails != null &&
                    input.ConsentDetails != null &&
                    this.ConsentDetails.SequenceEqual(input.ConsentDetails)
                ) && 
                (
                    this.MarketingConsent == input.MarketingConsent ||
                    (this.MarketingConsent != null &&
                    this.MarketingConsent.Equals(input.MarketingConsent))
                ) && 
                (
                    this.SelfDeclaration == input.SelfDeclaration ||
                    (this.SelfDeclaration != null &&
                    this.SelfDeclaration.Equals(input.SelfDeclaration))
                ) && 
                (
                    this.KycInformation == input.KycInformation ||
                    (this.KycInformation != null &&
                    this.KycInformation.Equals(input.KycInformation))
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
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Ocr != null)
                    hashCode = hashCode * 59 + this.Ocr.GetHashCode();
                if (this.Demographics != null)
                    hashCode = hashCode * 59 + this.Demographics.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.ContactPreference != null)
                    hashCode = hashCode * 59 + this.ContactPreference.GetHashCode();
                if (this.ContactConsent != null)
                    hashCode = hashCode * 59 + this.ContactConsent.GetHashCode();
                if (this.FinancialInformation != null)
                    hashCode = hashCode * 59 + this.FinancialInformation.GetHashCode();
                if (this.MotherMaidenName != null)
                    hashCode = hashCode * 59 + this.MotherMaidenName.GetHashCode();
                if (this.Education != null)
                    hashCode = hashCode * 59 + this.Education.GetHashCode();
                if (this.EmploymentDetails != null)
                    hashCode = hashCode * 59 + this.EmploymentDetails.GetHashCode();
                if (this.IdentificationDocumentDetails != null)
                    hashCode = hashCode * 59 + this.IdentificationDocumentDetails.GetHashCode();
                if (this.AdditionalData != null)
                    hashCode = hashCode * 59 + this.AdditionalData.GetHashCode();
                if (this.PartnerCustomerDetails != null)
                    hashCode = hashCode * 59 + this.PartnerCustomerDetails.GetHashCode();
                if (this.ConsentDetails != null)
                    hashCode = hashCode * 59 + this.ConsentDetails.GetHashCode();
                if (this.MarketingConsent != null)
                    hashCode = hashCode * 59 + this.MarketingConsent.GetHashCode();
                if (this.SelfDeclaration != null)
                    hashCode = hashCode * 59 + this.SelfDeclaration.GetHashCode();
                if (this.KycInformation != null)
                    hashCode = hashCode * 59 + this.KycInformation.GetHashCode();
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