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
    /// ApplicationUpdateKycInformation
    /// </summary>
    [DataContract]
        public partial class ApplicationUpdateKycInformation :  IEquatable<ApplicationUpdateKycInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationUpdateKycInformation" /> class.
        /// </summary>
        /// <param name="selfPublicFigureDeclarationFlag">Flag for self declaration if applicant is public figure. Valid values: true and false.</param>
        /// <param name="publicFigureOfficeStatus">Flag for status of public office if applicant is public figure.</param>
        /// <param name="publicFigureOfficeDetails">Office details if applicant is public figure.</param>
        /// <param name="publicFigureOfficeStartDate">Public figure office start date in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="publicFigureOfficeEndDate">Public figure office end date in ISO 8601 date format YYYY-MM-DD.</param>
        /// <param name="isRelatedToSeniorPublicFigure">Self declaration if applicant has any relation with senior public figure. Valid values: true and false.</param>
        /// <param name="relatedSeniorPublicFigureName">Senior Public Figure Name.</param>
        /// <param name="relatedSpfCountryOfGovernment">Senior Public Figure Country of Government.</param>
        /// <param name="relatedSeniorPublicFigureDepartment">Department Senior Public Figure belongs to.</param>
        /// <param name="relationshipWithSeniorPublicFigure">Senior Public Figure relationship with applicant.</param>
        /// <param name="relatedSeniorPublicFigureLastName">Senior Public Figure Last Name.</param>
        /// <param name="usTaxStatus">US Tax status. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values..</param>
        /// <param name="usTaxId">US Tax ID.</param>
        public ApplicationUpdateKycInformation(bool? selfPublicFigureDeclarationFlag = default(bool?), string publicFigureOfficeStatus = default(string), string publicFigureOfficeDetails = default(string), DateTime? publicFigureOfficeStartDate = default(DateTime?), DateTime? publicFigureOfficeEndDate = default(DateTime?), bool? isRelatedToSeniorPublicFigure = default(bool?), string relatedSeniorPublicFigureName = default(string), string relatedSpfCountryOfGovernment = default(string), string relatedSeniorPublicFigureDepartment = default(string), string relationshipWithSeniorPublicFigure = default(string), string relatedSeniorPublicFigureLastName = default(string), string usTaxStatus = default(string), string usTaxId = default(string))
        {
            this.SelfPublicFigureDeclarationFlag = selfPublicFigureDeclarationFlag;
            this.PublicFigureOfficeStatus = publicFigureOfficeStatus;
            this.PublicFigureOfficeDetails = publicFigureOfficeDetails;
            this.PublicFigureOfficeStartDate = publicFigureOfficeStartDate;
            this.PublicFigureOfficeEndDate = publicFigureOfficeEndDate;
            this.IsRelatedToSeniorPublicFigure = isRelatedToSeniorPublicFigure;
            this.RelatedSeniorPublicFigureName = relatedSeniorPublicFigureName;
            this.RelatedSpfCountryOfGovernment = relatedSpfCountryOfGovernment;
            this.RelatedSeniorPublicFigureDepartment = relatedSeniorPublicFigureDepartment;
            this.RelationshipWithSeniorPublicFigure = relationshipWithSeniorPublicFigure;
            this.RelatedSeniorPublicFigureLastName = relatedSeniorPublicFigureLastName;
            this.UsTaxStatus = usTaxStatus;
            this.UsTaxId = usTaxId;
        }
        
        /// <summary>
        /// Flag for self declaration if applicant is public figure. Valid values: true and false
        /// </summary>
        /// <value>Flag for self declaration if applicant is public figure. Valid values: true and false</value>
        [DataMember(Name="selfPublicFigureDeclarationFlag", EmitDefaultValue=false)]
        public bool? SelfPublicFigureDeclarationFlag { get; set; }

        /// <summary>
        /// Flag for status of public office if applicant is public figure
        /// </summary>
        /// <value>Flag for status of public office if applicant is public figure</value>
        [DataMember(Name="publicFigureOfficeStatus", EmitDefaultValue=false)]
        public string PublicFigureOfficeStatus { get; set; }

        /// <summary>
        /// Office details if applicant is public figure
        /// </summary>
        /// <value>Office details if applicant is public figure</value>
        [DataMember(Name="publicFigureOfficeDetails", EmitDefaultValue=false)]
        public string PublicFigureOfficeDetails { get; set; }

        /// <summary>
        /// Public figure office start date in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>Public figure office start date in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="publicFigureOfficeStartDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PublicFigureOfficeStartDate { get; set; }

        /// <summary>
        /// Public figure office end date in ISO 8601 date format YYYY-MM-DD
        /// </summary>
        /// <value>Public figure office end date in ISO 8601 date format YYYY-MM-DD</value>
        [DataMember(Name="publicFigureOfficeEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? PublicFigureOfficeEndDate { get; set; }

        /// <summary>
        /// Self declaration if applicant has any relation with senior public figure. Valid values: true and false
        /// </summary>
        /// <value>Self declaration if applicant has any relation with senior public figure. Valid values: true and false</value>
        [DataMember(Name="isRelatedToSeniorPublicFigure", EmitDefaultValue=false)]
        public bool? IsRelatedToSeniorPublicFigure { get; set; }

        /// <summary>
        /// Senior Public Figure Name
        /// </summary>
        /// <value>Senior Public Figure Name</value>
        [DataMember(Name="relatedSeniorPublicFigureName", EmitDefaultValue=false)]
        public string RelatedSeniorPublicFigureName { get; set; }

        /// <summary>
        /// Senior Public Figure Country of Government
        /// </summary>
        /// <value>Senior Public Figure Country of Government</value>
        [DataMember(Name="relatedSpfCountryOfGovernment", EmitDefaultValue=false)]
        public string RelatedSpfCountryOfGovernment { get; set; }

        /// <summary>
        /// Department Senior Public Figure belongs to
        /// </summary>
        /// <value>Department Senior Public Figure belongs to</value>
        [DataMember(Name="relatedSeniorPublicFigureDepartment", EmitDefaultValue=false)]
        public string RelatedSeniorPublicFigureDepartment { get; set; }

        /// <summary>
        /// Senior Public Figure relationship with applicant
        /// </summary>
        /// <value>Senior Public Figure relationship with applicant</value>
        [DataMember(Name="relationshipWithSeniorPublicFigure", EmitDefaultValue=false)]
        public string RelationshipWithSeniorPublicFigure { get; set; }

        /// <summary>
        /// Senior Public Figure Last Name
        /// </summary>
        /// <value>Senior Public Figure Last Name</value>
        [DataMember(Name="relatedSeniorPublicFigureLastName", EmitDefaultValue=false)]
        public string RelatedSeniorPublicFigureLastName { get; set; }

        /// <summary>
        /// US Tax status. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values.
        /// </summary>
        /// <value>US Tax status. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values.</value>
        [DataMember(Name="usTaxStatus", EmitDefaultValue=false)]
        public string UsTaxStatus { get; set; }

        /// <summary>
        /// US Tax ID
        /// </summary>
        /// <value>US Tax ID</value>
        [DataMember(Name="usTaxId", EmitDefaultValue=false)]
        public string UsTaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationUpdateKycInformation {\n");
            sb.Append("  SelfPublicFigureDeclarationFlag: ").Append(SelfPublicFigureDeclarationFlag).Append("\n");
            sb.Append("  PublicFigureOfficeStatus: ").Append(PublicFigureOfficeStatus).Append("\n");
            sb.Append("  PublicFigureOfficeDetails: ").Append(PublicFigureOfficeDetails).Append("\n");
            sb.Append("  PublicFigureOfficeStartDate: ").Append(PublicFigureOfficeStartDate).Append("\n");
            sb.Append("  PublicFigureOfficeEndDate: ").Append(PublicFigureOfficeEndDate).Append("\n");
            sb.Append("  IsRelatedToSeniorPublicFigure: ").Append(IsRelatedToSeniorPublicFigure).Append("\n");
            sb.Append("  RelatedSeniorPublicFigureName: ").Append(RelatedSeniorPublicFigureName).Append("\n");
            sb.Append("  RelatedSpfCountryOfGovernment: ").Append(RelatedSpfCountryOfGovernment).Append("\n");
            sb.Append("  RelatedSeniorPublicFigureDepartment: ").Append(RelatedSeniorPublicFigureDepartment).Append("\n");
            sb.Append("  RelationshipWithSeniorPublicFigure: ").Append(RelationshipWithSeniorPublicFigure).Append("\n");
            sb.Append("  RelatedSeniorPublicFigureLastName: ").Append(RelatedSeniorPublicFigureLastName).Append("\n");
            sb.Append("  UsTaxStatus: ").Append(UsTaxStatus).Append("\n");
            sb.Append("  UsTaxId: ").Append(UsTaxId).Append("\n");
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
            return this.Equals(input as ApplicationUpdateKycInformation);
        }

        /// <summary>
        /// Returns true if ApplicationUpdateKycInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationUpdateKycInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationUpdateKycInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SelfPublicFigureDeclarationFlag == input.SelfPublicFigureDeclarationFlag ||
                    (this.SelfPublicFigureDeclarationFlag != null &&
                    this.SelfPublicFigureDeclarationFlag.Equals(input.SelfPublicFigureDeclarationFlag))
                ) && 
                (
                    this.PublicFigureOfficeStatus == input.PublicFigureOfficeStatus ||
                    (this.PublicFigureOfficeStatus != null &&
                    this.PublicFigureOfficeStatus.Equals(input.PublicFigureOfficeStatus))
                ) && 
                (
                    this.PublicFigureOfficeDetails == input.PublicFigureOfficeDetails ||
                    (this.PublicFigureOfficeDetails != null &&
                    this.PublicFigureOfficeDetails.Equals(input.PublicFigureOfficeDetails))
                ) && 
                (
                    this.PublicFigureOfficeStartDate == input.PublicFigureOfficeStartDate ||
                    (this.PublicFigureOfficeStartDate != null &&
                    this.PublicFigureOfficeStartDate.Equals(input.PublicFigureOfficeStartDate))
                ) && 
                (
                    this.PublicFigureOfficeEndDate == input.PublicFigureOfficeEndDate ||
                    (this.PublicFigureOfficeEndDate != null &&
                    this.PublicFigureOfficeEndDate.Equals(input.PublicFigureOfficeEndDate))
                ) && 
                (
                    this.IsRelatedToSeniorPublicFigure == input.IsRelatedToSeniorPublicFigure ||
                    (this.IsRelatedToSeniorPublicFigure != null &&
                    this.IsRelatedToSeniorPublicFigure.Equals(input.IsRelatedToSeniorPublicFigure))
                ) && 
                (
                    this.RelatedSeniorPublicFigureName == input.RelatedSeniorPublicFigureName ||
                    (this.RelatedSeniorPublicFigureName != null &&
                    this.RelatedSeniorPublicFigureName.Equals(input.RelatedSeniorPublicFigureName))
                ) && 
                (
                    this.RelatedSpfCountryOfGovernment == input.RelatedSpfCountryOfGovernment ||
                    (this.RelatedSpfCountryOfGovernment != null &&
                    this.RelatedSpfCountryOfGovernment.Equals(input.RelatedSpfCountryOfGovernment))
                ) && 
                (
                    this.RelatedSeniorPublicFigureDepartment == input.RelatedSeniorPublicFigureDepartment ||
                    (this.RelatedSeniorPublicFigureDepartment != null &&
                    this.RelatedSeniorPublicFigureDepartment.Equals(input.RelatedSeniorPublicFigureDepartment))
                ) && 
                (
                    this.RelationshipWithSeniorPublicFigure == input.RelationshipWithSeniorPublicFigure ||
                    (this.RelationshipWithSeniorPublicFigure != null &&
                    this.RelationshipWithSeniorPublicFigure.Equals(input.RelationshipWithSeniorPublicFigure))
                ) && 
                (
                    this.RelatedSeniorPublicFigureLastName == input.RelatedSeniorPublicFigureLastName ||
                    (this.RelatedSeniorPublicFigureLastName != null &&
                    this.RelatedSeniorPublicFigureLastName.Equals(input.RelatedSeniorPublicFigureLastName))
                ) && 
                (
                    this.UsTaxStatus == input.UsTaxStatus ||
                    (this.UsTaxStatus != null &&
                    this.UsTaxStatus.Equals(input.UsTaxStatus))
                ) && 
                (
                    this.UsTaxId == input.UsTaxId ||
                    (this.UsTaxId != null &&
                    this.UsTaxId.Equals(input.UsTaxId))
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
                if (this.SelfPublicFigureDeclarationFlag != null)
                    hashCode = hashCode * 59 + this.SelfPublicFigureDeclarationFlag.GetHashCode();
                if (this.PublicFigureOfficeStatus != null)
                    hashCode = hashCode * 59 + this.PublicFigureOfficeStatus.GetHashCode();
                if (this.PublicFigureOfficeDetails != null)
                    hashCode = hashCode * 59 + this.PublicFigureOfficeDetails.GetHashCode();
                if (this.PublicFigureOfficeStartDate != null)
                    hashCode = hashCode * 59 + this.PublicFigureOfficeStartDate.GetHashCode();
                if (this.PublicFigureOfficeEndDate != null)
                    hashCode = hashCode * 59 + this.PublicFigureOfficeEndDate.GetHashCode();
                if (this.IsRelatedToSeniorPublicFigure != null)
                    hashCode = hashCode * 59 + this.IsRelatedToSeniorPublicFigure.GetHashCode();
                if (this.RelatedSeniorPublicFigureName != null)
                    hashCode = hashCode * 59 + this.RelatedSeniorPublicFigureName.GetHashCode();
                if (this.RelatedSpfCountryOfGovernment != null)
                    hashCode = hashCode * 59 + this.RelatedSpfCountryOfGovernment.GetHashCode();
                if (this.RelatedSeniorPublicFigureDepartment != null)
                    hashCode = hashCode * 59 + this.RelatedSeniorPublicFigureDepartment.GetHashCode();
                if (this.RelationshipWithSeniorPublicFigure != null)
                    hashCode = hashCode * 59 + this.RelationshipWithSeniorPublicFigure.GetHashCode();
                if (this.RelatedSeniorPublicFigureLastName != null)
                    hashCode = hashCode * 59 + this.RelatedSeniorPublicFigureLastName.GetHashCode();
                if (this.UsTaxStatus != null)
                    hashCode = hashCode * 59 + this.UsTaxStatus.GetHashCode();
                if (this.UsTaxId != null)
                    hashCode = hashCode * 59 + this.UsTaxId.GetHashCode();
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