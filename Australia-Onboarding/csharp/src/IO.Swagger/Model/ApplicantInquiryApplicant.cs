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
    /// ApplicantInquiryApplicant
    /// </summary>
    [DataContract]
        public partial class ApplicantInquiryApplicant :  IEquatable<ApplicantInquiryApplicant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicantInquiryApplicant" /> class.
        /// </summary>
        /// <param name="applicantType">Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values. (required).</param>
        /// <param name="applicantId">Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here..</param>
        /// <param name="motherMaidenName">Mothers maiden name.</param>
        /// <param name="name">name (required).</param>
        /// <param name="demographics">demographics.</param>
        /// <param name="address">address.</param>
        /// <param name="email">email.</param>
        /// <param name="phone">phone.</param>
        /// <param name="financialInformation">financialInformation.</param>
        /// <param name="employmentDetails">employmentDetails.</param>
        /// <param name="identificationDocumentDetails">identificationDocumentDetails.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="partnerCustomerDetails">partnerCustomerDetails.</param>
        /// <param name="consentDetails">consentDetails.</param>
        /// <param name="requiredDocuments">requiredDocuments.</param>
        /// <param name="kycInformation">kycInformation.</param>
        /// <param name="contactConsent">contactConsent.</param>
        public ApplicantInquiryApplicant(string applicantType = default(string), string applicantId = default(string), string motherMaidenName = default(string), ApplicantInquiryName name = default(ApplicantInquiryName), ApplicantInquiryDemographics demographics = default(ApplicantInquiryDemographics), List<ApplicantInquiryAddress> address = default(List<ApplicantInquiryAddress>), List<ApplicantInquiryEmail> email = default(List<ApplicantInquiryEmail>), List<ApplicantInquiryPhone> phone = default(List<ApplicantInquiryPhone>), ApplicantInquiryFinancialInformation financialInformation = default(ApplicantInquiryFinancialInformation), List<ApplicantInquiryEmploymentDetails> employmentDetails = default(List<ApplicantInquiryEmploymentDetails>), List<ApplicantInquiryIdentificationDocumentDetails> identificationDocumentDetails = default(List<ApplicantInquiryIdentificationDocumentDetails>), ApplicantInquiryAdditionalData additionalData = default(ApplicantInquiryAdditionalData), ApplicantInquiryPartnerCustomerDetails partnerCustomerDetails = default(ApplicantInquiryPartnerCustomerDetails), List<ApplicantInquiryConsentDetails> consentDetails = default(List<ApplicantInquiryConsentDetails>), List<ApplicantInquiryRequiredDocuments> requiredDocuments = default(List<ApplicantInquiryRequiredDocuments>), ApplicantInquiryKycInformation kycInformation = default(ApplicantInquiryKycInformation), ApplicantInquiryContactConsent contactConsent = default(ApplicantInquiryContactConsent))
        {
            // to ensure "applicantType" is required (not null)
            if (applicantType == null)
            {
                throw new InvalidDataException("applicantType is a required property for ApplicantInquiryApplicant and cannot be null");
            }
            else
            {
                this.ApplicantType = applicantType;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ApplicantInquiryApplicant and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.ApplicantId = applicantId;
            this.MotherMaidenName = motherMaidenName;
            this.Demographics = demographics;
            this.Address = address;
            this.Email = email;
            this.Phone = phone;
            this.FinancialInformation = financialInformation;
            this.EmploymentDetails = employmentDetails;
            this.IdentificationDocumentDetails = identificationDocumentDetails;
            this.AdditionalData = additionalData;
            this.PartnerCustomerDetails = partnerCustomerDetails;
            this.ConsentDetails = consentDetails;
            this.RequiredDocuments = requiredDocuments;
            this.KycInformation = kycInformation;
            this.ContactConsent = contactConsent;
        }
        
        /// <summary>
        /// Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Type of an applicant.This is a reference data field.Please use /utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions. You can use the fieldname as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="applicantType", EmitDefaultValue=false)]
        public string ApplicantType { get; set; }

        /// <summary>
        /// Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.
        /// </summary>
        /// <value>Unique ID created for an Applicant. This is retuned back in ApplicantAdd response and the same should be passed here.</value>
        [DataMember(Name="applicantId", EmitDefaultValue=false)]
        public string ApplicantId { get; set; }

        /// <summary>
        /// Mothers maiden name
        /// </summary>
        /// <value>Mothers maiden name</value>
        [DataMember(Name="motherMaidenName", EmitDefaultValue=false)]
        public string MotherMaidenName { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public ApplicantInquiryName Name { get; set; }

        /// <summary>
        /// Gets or Sets Demographics
        /// </summary>
        [DataMember(Name="demographics", EmitDefaultValue=false)]
        public ApplicantInquiryDemographics Demographics { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public List<ApplicantInquiryAddress> Address { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public List<ApplicantInquiryEmail> Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public List<ApplicantInquiryPhone> Phone { get; set; }

        /// <summary>
        /// Gets or Sets FinancialInformation
        /// </summary>
        [DataMember(Name="financialInformation", EmitDefaultValue=false)]
        public ApplicantInquiryFinancialInformation FinancialInformation { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentDetails
        /// </summary>
        [DataMember(Name="employmentDetails", EmitDefaultValue=false)]
        public List<ApplicantInquiryEmploymentDetails> EmploymentDetails { get; set; }

        /// <summary>
        /// Gets or Sets IdentificationDocumentDetails
        /// </summary>
        [DataMember(Name="identificationDocumentDetails", EmitDefaultValue=false)]
        public List<ApplicantInquiryIdentificationDocumentDetails> IdentificationDocumentDetails { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalData
        /// </summary>
        [DataMember(Name="additionalData", EmitDefaultValue=false)]
        public ApplicantInquiryAdditionalData AdditionalData { get; set; }

        /// <summary>
        /// Gets or Sets PartnerCustomerDetails
        /// </summary>
        [DataMember(Name="partnerCustomerDetails", EmitDefaultValue=false)]
        public ApplicantInquiryPartnerCustomerDetails PartnerCustomerDetails { get; set; }

        /// <summary>
        /// Gets or Sets ConsentDetails
        /// </summary>
        [DataMember(Name="consentDetails", EmitDefaultValue=false)]
        public List<ApplicantInquiryConsentDetails> ConsentDetails { get; set; }

        /// <summary>
        /// Gets or Sets RequiredDocuments
        /// </summary>
        [DataMember(Name="requiredDocuments", EmitDefaultValue=false)]
        public List<ApplicantInquiryRequiredDocuments> RequiredDocuments { get; set; }

        /// <summary>
        /// Gets or Sets KycInformation
        /// </summary>
        [DataMember(Name="kycInformation", EmitDefaultValue=false)]
        public ApplicantInquiryKycInformation KycInformation { get; set; }

        /// <summary>
        /// Gets or Sets ContactConsent
        /// </summary>
        [DataMember(Name="contactConsent", EmitDefaultValue=false)]
        public ApplicantInquiryContactConsent ContactConsent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicantInquiryApplicant {\n");
            sb.Append("  ApplicantType: ").Append(ApplicantType).Append("\n");
            sb.Append("  ApplicantId: ").Append(ApplicantId).Append("\n");
            sb.Append("  MotherMaidenName: ").Append(MotherMaidenName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Demographics: ").Append(Demographics).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  FinancialInformation: ").Append(FinancialInformation).Append("\n");
            sb.Append("  EmploymentDetails: ").Append(EmploymentDetails).Append("\n");
            sb.Append("  IdentificationDocumentDetails: ").Append(IdentificationDocumentDetails).Append("\n");
            sb.Append("  AdditionalData: ").Append(AdditionalData).Append("\n");
            sb.Append("  PartnerCustomerDetails: ").Append(PartnerCustomerDetails).Append("\n");
            sb.Append("  ConsentDetails: ").Append(ConsentDetails).Append("\n");
            sb.Append("  RequiredDocuments: ").Append(RequiredDocuments).Append("\n");
            sb.Append("  KycInformation: ").Append(KycInformation).Append("\n");
            sb.Append("  ContactConsent: ").Append(ContactConsent).Append("\n");
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
            return this.Equals(input as ApplicantInquiryApplicant);
        }

        /// <summary>
        /// Returns true if ApplicantInquiryApplicant instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicantInquiryApplicant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicantInquiryApplicant input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicantType == input.ApplicantType ||
                    (this.ApplicantType != null &&
                    this.ApplicantType.Equals(input.ApplicantType))
                ) && 
                (
                    this.ApplicantId == input.ApplicantId ||
                    (this.ApplicantId != null &&
                    this.ApplicantId.Equals(input.ApplicantId))
                ) && 
                (
                    this.MotherMaidenName == input.MotherMaidenName ||
                    (this.MotherMaidenName != null &&
                    this.MotherMaidenName.Equals(input.MotherMaidenName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.Email == input.Email ||
                    this.Email != null &&
                    input.Email != null &&
                    this.Email.SequenceEqual(input.Email)
                ) && 
                (
                    this.Phone == input.Phone ||
                    this.Phone != null &&
                    input.Phone != null &&
                    this.Phone.SequenceEqual(input.Phone)
                ) && 
                (
                    this.FinancialInformation == input.FinancialInformation ||
                    (this.FinancialInformation != null &&
                    this.FinancialInformation.Equals(input.FinancialInformation))
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
                    this.RequiredDocuments == input.RequiredDocuments ||
                    this.RequiredDocuments != null &&
                    input.RequiredDocuments != null &&
                    this.RequiredDocuments.SequenceEqual(input.RequiredDocuments)
                ) && 
                (
                    this.KycInformation == input.KycInformation ||
                    (this.KycInformation != null &&
                    this.KycInformation.Equals(input.KycInformation))
                ) && 
                (
                    this.ContactConsent == input.ContactConsent ||
                    (this.ContactConsent != null &&
                    this.ContactConsent.Equals(input.ContactConsent))
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
                if (this.ApplicantType != null)
                    hashCode = hashCode * 59 + this.ApplicantType.GetHashCode();
                if (this.ApplicantId != null)
                    hashCode = hashCode * 59 + this.ApplicantId.GetHashCode();
                if (this.MotherMaidenName != null)
                    hashCode = hashCode * 59 + this.MotherMaidenName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Demographics != null)
                    hashCode = hashCode * 59 + this.Demographics.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.FinancialInformation != null)
                    hashCode = hashCode * 59 + this.FinancialInformation.GetHashCode();
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
                if (this.RequiredDocuments != null)
                    hashCode = hashCode * 59 + this.RequiredDocuments.GetHashCode();
                if (this.KycInformation != null)
                    hashCode = hashCode * 59 + this.KycInformation.GetHashCode();
                if (this.ContactConsent != null)
                    hashCode = hashCode * 59 + this.ContactConsent.GetHashCode();
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
