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
    /// ApplicationInquiryDemographics
    /// </summary>
    [DataContract]
        public partial class ApplicationInquiryDemographics :  IEquatable<ApplicationInquiryDemographics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationInquiryDemographics" /> class.
        /// </summary>
        /// <param name="gender">Gender/sex. This is a reference data field. Please use /v1/apac/utilities/referenceData/{gender} resource to get valid value of this field with description. You can use gender field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="dateOfBirth">Applicant&#x27;s date of birth in  ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="placeOfBirth">Applicant&#x27;s place of birth.</param>
        /// <param name="countryOfBirth">Applicant&#x27;s Country of birth. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryOfBirth field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="nationality">Applicant&#x27;s nationality. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use nationality field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="domicileCountryCode">Domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="permanentResidencyCountryCode">Permanent residency country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use domicileCountryCode field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="maritalStatus">Applicant&#x27;s marital status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{maritalStatus} resource to get valid value of this field with description. You can use maritalStatus field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="residencyStatus">Indicate status of residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceStatus} resource to get valid value of this field with description. You can use residenceStatus field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="residenceType">Type of Residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceType} resource to get valid value of this field with description. You can use residenceType field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="taxDomicileCountryCode">Tax domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use taxDomicileCountryCode field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="spokenLanguageCode">Code for spoken language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use spokenLanguageCode field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="correspondenceLanguageCode">Code for correspondence language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use correspondenceLanguageCode field name as the referenceCode parameter to retrieve the values..</param>
        public ApplicationInquiryDemographics(string gender = default(string), DateTime? dateOfBirth = default(DateTime?), string placeOfBirth = default(string), string countryOfBirth = default(string), string nationality = default(string), string domicileCountryCode = default(string), string permanentResidencyCountryCode = default(string), string maritalStatus = default(string), string residencyStatus = default(string), string residenceType = default(string), string taxDomicileCountryCode = default(string), string spokenLanguageCode = default(string), string correspondenceLanguageCode = default(string))
        {
            this.Gender = gender;
            this.DateOfBirth = dateOfBirth;
            this.PlaceOfBirth = placeOfBirth;
            this.CountryOfBirth = countryOfBirth;
            this.Nationality = nationality;
            this.DomicileCountryCode = domicileCountryCode;
            this.PermanentResidencyCountryCode = permanentResidencyCountryCode;
            this.MaritalStatus = maritalStatus;
            this.ResidencyStatus = residencyStatus;
            this.ResidenceType = residenceType;
            this.TaxDomicileCountryCode = taxDomicileCountryCode;
            this.SpokenLanguageCode = spokenLanguageCode;
            this.CorrespondenceLanguageCode = correspondenceLanguageCode;
        }
        
        /// <summary>
        /// Gender/sex. This is a reference data field. Please use /v1/apac/utilities/referenceData/{gender} resource to get valid value of this field with description. You can use gender field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Gender/sex. This is a reference data field. Please use /v1/apac/utilities/referenceData/{gender} resource to get valid value of this field with description. You can use gender field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }

        /// <summary>
        /// Applicant&#x27;s date of birth in  ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>Applicant&#x27;s date of birth in  ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="dateOfBirth", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Applicant&#x27;s place of birth
        /// </summary>
        /// <value>Applicant&#x27;s place of birth</value>
        [DataMember(Name="placeOfBirth", EmitDefaultValue=false)]
        public string PlaceOfBirth { get; set; }

        /// <summary>
        /// Applicant&#x27;s Country of birth. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryOfBirth field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Applicant&#x27;s Country of birth. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryOfBirth field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="countryOfBirth", EmitDefaultValue=false)]
        public string CountryOfBirth { get; set; }

        /// <summary>
        /// Applicant&#x27;s nationality. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use nationality field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Applicant&#x27;s nationality. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use nationality field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="nationality", EmitDefaultValue=false)]
        public string Nationality { get; set; }

        /// <summary>
        /// Domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="domicileCountryCode", EmitDefaultValue=false)]
        public string DomicileCountryCode { get; set; }

        /// <summary>
        /// Permanent residency country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use domicileCountryCode field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Permanent residency country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use domicileCountryCode field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="permanentResidencyCountryCode", EmitDefaultValue=false)]
        public string PermanentResidencyCountryCode { get; set; }

        /// <summary>
        /// Applicant&#x27;s marital status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{maritalStatus} resource to get valid value of this field with description. You can use maritalStatus field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Applicant&#x27;s marital status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{maritalStatus} resource to get valid value of this field with description. You can use maritalStatus field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="maritalStatus", EmitDefaultValue=false)]
        public string MaritalStatus { get; set; }

        /// <summary>
        /// Indicate status of residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceStatus} resource to get valid value of this field with description. You can use residenceStatus field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Indicate status of residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceStatus} resource to get valid value of this field with description. You can use residenceStatus field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="residencyStatus", EmitDefaultValue=false)]
        public string ResidencyStatus { get; set; }

        /// <summary>
        /// Type of Residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceType} resource to get valid value of this field with description. You can use residenceType field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Type of Residence. This is a reference data field. Please use /v1/apac/utilities/referenceData/{residenceType} resource to get valid value of this field with description. You can use residenceType field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="residenceType", EmitDefaultValue=false)]
        public string ResidenceType { get; set; }

        /// <summary>
        /// Tax domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use taxDomicileCountryCode field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Tax domicile country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use taxDomicileCountryCode field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="taxDomicileCountryCode", EmitDefaultValue=false)]
        public string TaxDomicileCountryCode { get; set; }

        /// <summary>
        /// Code for spoken language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use spokenLanguageCode field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Code for spoken language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use spokenLanguageCode field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="spokenLanguageCode", EmitDefaultValue=false)]
        public string SpokenLanguageCode { get; set; }

        /// <summary>
        /// Code for correspondence language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use correspondenceLanguageCode field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>Code for correspondence language of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{spokenLanguageCode} resource to get valid value of this field with description. You can use correspondenceLanguageCode field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="correspondenceLanguageCode", EmitDefaultValue=false)]
        public string CorrespondenceLanguageCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationInquiryDemographics {\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  PlaceOfBirth: ").Append(PlaceOfBirth).Append("\n");
            sb.Append("  CountryOfBirth: ").Append(CountryOfBirth).Append("\n");
            sb.Append("  Nationality: ").Append(Nationality).Append("\n");
            sb.Append("  DomicileCountryCode: ").Append(DomicileCountryCode).Append("\n");
            sb.Append("  PermanentResidencyCountryCode: ").Append(PermanentResidencyCountryCode).Append("\n");
            sb.Append("  MaritalStatus: ").Append(MaritalStatus).Append("\n");
            sb.Append("  ResidencyStatus: ").Append(ResidencyStatus).Append("\n");
            sb.Append("  ResidenceType: ").Append(ResidenceType).Append("\n");
            sb.Append("  TaxDomicileCountryCode: ").Append(TaxDomicileCountryCode).Append("\n");
            sb.Append("  SpokenLanguageCode: ").Append(SpokenLanguageCode).Append("\n");
            sb.Append("  CorrespondenceLanguageCode: ").Append(CorrespondenceLanguageCode).Append("\n");
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
            return this.Equals(input as ApplicationInquiryDemographics);
        }

        /// <summary>
        /// Returns true if ApplicationInquiryDemographics instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationInquiryDemographics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationInquiryDemographics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.PlaceOfBirth == input.PlaceOfBirth ||
                    (this.PlaceOfBirth != null &&
                    this.PlaceOfBirth.Equals(input.PlaceOfBirth))
                ) && 
                (
                    this.CountryOfBirth == input.CountryOfBirth ||
                    (this.CountryOfBirth != null &&
                    this.CountryOfBirth.Equals(input.CountryOfBirth))
                ) && 
                (
                    this.Nationality == input.Nationality ||
                    (this.Nationality != null &&
                    this.Nationality.Equals(input.Nationality))
                ) && 
                (
                    this.DomicileCountryCode == input.DomicileCountryCode ||
                    (this.DomicileCountryCode != null &&
                    this.DomicileCountryCode.Equals(input.DomicileCountryCode))
                ) && 
                (
                    this.PermanentResidencyCountryCode == input.PermanentResidencyCountryCode ||
                    (this.PermanentResidencyCountryCode != null &&
                    this.PermanentResidencyCountryCode.Equals(input.PermanentResidencyCountryCode))
                ) && 
                (
                    this.MaritalStatus == input.MaritalStatus ||
                    (this.MaritalStatus != null &&
                    this.MaritalStatus.Equals(input.MaritalStatus))
                ) && 
                (
                    this.ResidencyStatus == input.ResidencyStatus ||
                    (this.ResidencyStatus != null &&
                    this.ResidencyStatus.Equals(input.ResidencyStatus))
                ) && 
                (
                    this.ResidenceType == input.ResidenceType ||
                    (this.ResidenceType != null &&
                    this.ResidenceType.Equals(input.ResidenceType))
                ) && 
                (
                    this.TaxDomicileCountryCode == input.TaxDomicileCountryCode ||
                    (this.TaxDomicileCountryCode != null &&
                    this.TaxDomicileCountryCode.Equals(input.TaxDomicileCountryCode))
                ) && 
                (
                    this.SpokenLanguageCode == input.SpokenLanguageCode ||
                    (this.SpokenLanguageCode != null &&
                    this.SpokenLanguageCode.Equals(input.SpokenLanguageCode))
                ) && 
                (
                    this.CorrespondenceLanguageCode == input.CorrespondenceLanguageCode ||
                    (this.CorrespondenceLanguageCode != null &&
                    this.CorrespondenceLanguageCode.Equals(input.CorrespondenceLanguageCode))
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
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.PlaceOfBirth != null)
                    hashCode = hashCode * 59 + this.PlaceOfBirth.GetHashCode();
                if (this.CountryOfBirth != null)
                    hashCode = hashCode * 59 + this.CountryOfBirth.GetHashCode();
                if (this.Nationality != null)
                    hashCode = hashCode * 59 + this.Nationality.GetHashCode();
                if (this.DomicileCountryCode != null)
                    hashCode = hashCode * 59 + this.DomicileCountryCode.GetHashCode();
                if (this.PermanentResidencyCountryCode != null)
                    hashCode = hashCode * 59 + this.PermanentResidencyCountryCode.GetHashCode();
                if (this.MaritalStatus != null)
                    hashCode = hashCode * 59 + this.MaritalStatus.GetHashCode();
                if (this.ResidencyStatus != null)
                    hashCode = hashCode * 59 + this.ResidencyStatus.GetHashCode();
                if (this.ResidenceType != null)
                    hashCode = hashCode * 59 + this.ResidenceType.GetHashCode();
                if (this.TaxDomicileCountryCode != null)
                    hashCode = hashCode * 59 + this.TaxDomicileCountryCode.GetHashCode();
                if (this.SpokenLanguageCode != null)
                    hashCode = hashCode * 59 + this.SpokenLanguageCode.GetHashCode();
                if (this.CorrespondenceLanguageCode != null)
                    hashCode = hashCode * 59 + this.CorrespondenceLanguageCode.GetHashCode();
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
