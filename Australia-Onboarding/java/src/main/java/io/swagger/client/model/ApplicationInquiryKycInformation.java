/*
 * Onboarding
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.LocalDate;
/**
 * ApplicationInquiryKycInformation
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationInquiryKycInformation {
  @SerializedName("selfPublicFigureDeclarationFlag")
  private Boolean selfPublicFigureDeclarationFlag = null;

  @SerializedName("publicFigureOfficeStatus")
  private String publicFigureOfficeStatus = null;

  @SerializedName("publicFigureOfficeDetails")
  private String publicFigureOfficeDetails = null;

  @SerializedName("publicFigureOfficeStartDate")
  private LocalDate publicFigureOfficeStartDate = null;

  @SerializedName("publicFigureOfficeEndDate")
  private LocalDate publicFigureOfficeEndDate = null;

  @SerializedName("isRelatedToSeniorPublicFigure")
  private Boolean isRelatedToSeniorPublicFigure = null;

  @SerializedName("relatedSeniorPublicFigureName")
  private String relatedSeniorPublicFigureName = null;

  @SerializedName("relatedSeniorPublicFigureDesignation")
  private String relatedSeniorPublicFigureDesignation = null;

  @SerializedName("relatedSpfCountryOfGovernment")
  private String relatedSpfCountryOfGovernment = null;

  @SerializedName("relatedSeniorPublicFigureDepartment")
  private String relatedSeniorPublicFigureDepartment = null;

  @SerializedName("relationshipWithSeniorPublicFigure")
  private String relationshipWithSeniorPublicFigure = null;

  @SerializedName("relatedSeniorPublicFigureLastName")
  private String relatedSeniorPublicFigureLastName = null;

  @SerializedName("usTaxStatus")
  private String usTaxStatus = null;

  @SerializedName("usTaxId")
  private String usTaxId = null;

  public ApplicationInquiryKycInformation selfPublicFigureDeclarationFlag(Boolean selfPublicFigureDeclarationFlag) {
    this.selfPublicFigureDeclarationFlag = selfPublicFigureDeclarationFlag;
    return this;
  }

   /**
   * Flag for self declaration if applicant is public figure. Valid values: true and false
   * @return selfPublicFigureDeclarationFlag
  **/
  @Schema(example = "true", description = "Flag for self declaration if applicant is public figure. Valid values: true and false")
  public Boolean isSelfPublicFigureDeclarationFlag() {
    return selfPublicFigureDeclarationFlag;
  }

  public void setSelfPublicFigureDeclarationFlag(Boolean selfPublicFigureDeclarationFlag) {
    this.selfPublicFigureDeclarationFlag = selfPublicFigureDeclarationFlag;
  }

  public ApplicationInquiryKycInformation publicFigureOfficeStatus(String publicFigureOfficeStatus) {
    this.publicFigureOfficeStatus = publicFigureOfficeStatus;
    return this;
  }

   /**
   * Flag for status of public office if applicant is public figure
   * @return publicFigureOfficeStatus
  **/
  @Schema(example = "Active", description = "Flag for status of public office if applicant is public figure")
  public String getPublicFigureOfficeStatus() {
    return publicFigureOfficeStatus;
  }

  public void setPublicFigureOfficeStatus(String publicFigureOfficeStatus) {
    this.publicFigureOfficeStatus = publicFigureOfficeStatus;
  }

  public ApplicationInquiryKycInformation publicFigureOfficeDetails(String publicFigureOfficeDetails) {
    this.publicFigureOfficeDetails = publicFigureOfficeDetails;
    return this;
  }

   /**
   * Office details if applicant is public figure
   * @return publicFigureOfficeDetails
  **/
  @Schema(example = "Department of education and training", description = "Office details if applicant is public figure")
  public String getPublicFigureOfficeDetails() {
    return publicFigureOfficeDetails;
  }

  public void setPublicFigureOfficeDetails(String publicFigureOfficeDetails) {
    this.publicFigureOfficeDetails = publicFigureOfficeDetails;
  }

  public ApplicationInquiryKycInformation publicFigureOfficeStartDate(LocalDate publicFigureOfficeStartDate) {
    this.publicFigureOfficeStartDate = publicFigureOfficeStartDate;
    return this;
  }

   /**
   * Public figure office start date in ISO 8601 date format YYYY-MM-DD
   * @return publicFigureOfficeStartDate
  **/
  @Schema(example = "Wed Apr 12 00:00:00 UTC 2017", description = "Public figure office start date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getPublicFigureOfficeStartDate() {
    return publicFigureOfficeStartDate;
  }

  public void setPublicFigureOfficeStartDate(LocalDate publicFigureOfficeStartDate) {
    this.publicFigureOfficeStartDate = publicFigureOfficeStartDate;
  }

  public ApplicationInquiryKycInformation publicFigureOfficeEndDate(LocalDate publicFigureOfficeEndDate) {
    this.publicFigureOfficeEndDate = publicFigureOfficeEndDate;
    return this;
  }

   /**
   * Public figure office end date in ISO 8601 date format YYYY-MM-DD
   * @return publicFigureOfficeEndDate
  **/
  @Schema(example = "Sat Apr 11 00:00:00 UTC 2020", description = "Public figure office end date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getPublicFigureOfficeEndDate() {
    return publicFigureOfficeEndDate;
  }

  public void setPublicFigureOfficeEndDate(LocalDate publicFigureOfficeEndDate) {
    this.publicFigureOfficeEndDate = publicFigureOfficeEndDate;
  }

  public ApplicationInquiryKycInformation isRelatedToSeniorPublicFigure(Boolean isRelatedToSeniorPublicFigure) {
    this.isRelatedToSeniorPublicFigure = isRelatedToSeniorPublicFigure;
    return this;
  }

   /**
   * Self declaration if applicant has any relation with senior public figure. Valid values: true and false
   * @return isRelatedToSeniorPublicFigure
  **/
  @Schema(example = "true", description = "Self declaration if applicant has any relation with senior public figure. Valid values: true and false")
  public Boolean isIsRelatedToSeniorPublicFigure() {
    return isRelatedToSeniorPublicFigure;
  }

  public void setIsRelatedToSeniorPublicFigure(Boolean isRelatedToSeniorPublicFigure) {
    this.isRelatedToSeniorPublicFigure = isRelatedToSeniorPublicFigure;
  }

  public ApplicationInquiryKycInformation relatedSeniorPublicFigureName(String relatedSeniorPublicFigureName) {
    this.relatedSeniorPublicFigureName = relatedSeniorPublicFigureName;
    return this;
  }

   /**
   * Senior Public Figure Name
   * @return relatedSeniorPublicFigureName
  **/
  @Schema(example = "Dan Lee", description = "Senior Public Figure Name")
  public String getRelatedSeniorPublicFigureName() {
    return relatedSeniorPublicFigureName;
  }

  public void setRelatedSeniorPublicFigureName(String relatedSeniorPublicFigureName) {
    this.relatedSeniorPublicFigureName = relatedSeniorPublicFigureName;
  }

  public ApplicationInquiryKycInformation relatedSeniorPublicFigureDesignation(String relatedSeniorPublicFigureDesignation) {
    this.relatedSeniorPublicFigureDesignation = relatedSeniorPublicFigureDesignation;
    return this;
  }

   /**
   * Public figure designation.
   * @return relatedSeniorPublicFigureDesignation
  **/
  @Schema(example = "Member of Parliament", description = "Public figure designation.")
  public String getRelatedSeniorPublicFigureDesignation() {
    return relatedSeniorPublicFigureDesignation;
  }

  public void setRelatedSeniorPublicFigureDesignation(String relatedSeniorPublicFigureDesignation) {
    this.relatedSeniorPublicFigureDesignation = relatedSeniorPublicFigureDesignation;
  }

  public ApplicationInquiryKycInformation relatedSpfCountryOfGovernment(String relatedSpfCountryOfGovernment) {
    this.relatedSpfCountryOfGovernment = relatedSpfCountryOfGovernment;
    return this;
  }

   /**
   * Senior Public Figure Country of Government
   * @return relatedSpfCountryOfGovernment
  **/
  @Schema(example = "SG", description = "Senior Public Figure Country of Government")
  public String getRelatedSpfCountryOfGovernment() {
    return relatedSpfCountryOfGovernment;
  }

  public void setRelatedSpfCountryOfGovernment(String relatedSpfCountryOfGovernment) {
    this.relatedSpfCountryOfGovernment = relatedSpfCountryOfGovernment;
  }

  public ApplicationInquiryKycInformation relatedSeniorPublicFigureDepartment(String relatedSeniorPublicFigureDepartment) {
    this.relatedSeniorPublicFigureDepartment = relatedSeniorPublicFigureDepartment;
    return this;
  }

   /**
   * Department Senior Public Figure belongs to
   * @return relatedSeniorPublicFigureDepartment
  **/
  @Schema(example = "Ministry", description = "Department Senior Public Figure belongs to")
  public String getRelatedSeniorPublicFigureDepartment() {
    return relatedSeniorPublicFigureDepartment;
  }

  public void setRelatedSeniorPublicFigureDepartment(String relatedSeniorPublicFigureDepartment) {
    this.relatedSeniorPublicFigureDepartment = relatedSeniorPublicFigureDepartment;
  }

  public ApplicationInquiryKycInformation relationshipWithSeniorPublicFigure(String relationshipWithSeniorPublicFigure) {
    this.relationshipWithSeniorPublicFigure = relationshipWithSeniorPublicFigure;
    return this;
  }

   /**
   * Senior Public Figure relationship with applicant
   * @return relationshipWithSeniorPublicFigure
  **/
  @Schema(example = "Father", description = "Senior Public Figure relationship with applicant")
  public String getRelationshipWithSeniorPublicFigure() {
    return relationshipWithSeniorPublicFigure;
  }

  public void setRelationshipWithSeniorPublicFigure(String relationshipWithSeniorPublicFigure) {
    this.relationshipWithSeniorPublicFigure = relationshipWithSeniorPublicFigure;
  }

  public ApplicationInquiryKycInformation relatedSeniorPublicFigureLastName(String relatedSeniorPublicFigureLastName) {
    this.relatedSeniorPublicFigureLastName = relatedSeniorPublicFigureLastName;
    return this;
  }

   /**
   * Senior Public Figure Last Name
   * @return relatedSeniorPublicFigureLastName
  **/
  @Schema(example = "Lee", description = "Senior Public Figure Last Name")
  public String getRelatedSeniorPublicFigureLastName() {
    return relatedSeniorPublicFigureLastName;
  }

  public void setRelatedSeniorPublicFigureLastName(String relatedSeniorPublicFigureLastName) {
    this.relatedSeniorPublicFigureLastName = relatedSeniorPublicFigureLastName;
  }

  public ApplicationInquiryKycInformation usTaxStatus(String usTaxStatus) {
    this.usTaxStatus = usTaxStatus;
    return this;
  }

   /**
   * US Tax status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values.
   * @return usTaxStatus
  **/
  @Schema(example = "US_PERSON_REPORTABLE_DOCUMENTED", description = "US Tax status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values.")
  public String getUsTaxStatus() {
    return usTaxStatus;
  }

  public void setUsTaxStatus(String usTaxStatus) {
    this.usTaxStatus = usTaxStatus;
  }

  public ApplicationInquiryKycInformation usTaxId(String usTaxId) {
    this.usTaxId = usTaxId;
    return this;
  }

   /**
   * US Tax ID
   * @return usTaxId
  **/
  @Schema(example = "US234567", description = "US Tax ID")
  public String getUsTaxId() {
    return usTaxId;
  }

  public void setUsTaxId(String usTaxId) {
    this.usTaxId = usTaxId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationInquiryKycInformation applicationInquiryKycInformation = (ApplicationInquiryKycInformation) o;
    return Objects.equals(this.selfPublicFigureDeclarationFlag, applicationInquiryKycInformation.selfPublicFigureDeclarationFlag) &&
        Objects.equals(this.publicFigureOfficeStatus, applicationInquiryKycInformation.publicFigureOfficeStatus) &&
        Objects.equals(this.publicFigureOfficeDetails, applicationInquiryKycInformation.publicFigureOfficeDetails) &&
        Objects.equals(this.publicFigureOfficeStartDate, applicationInquiryKycInformation.publicFigureOfficeStartDate) &&
        Objects.equals(this.publicFigureOfficeEndDate, applicationInquiryKycInformation.publicFigureOfficeEndDate) &&
        Objects.equals(this.isRelatedToSeniorPublicFigure, applicationInquiryKycInformation.isRelatedToSeniorPublicFigure) &&
        Objects.equals(this.relatedSeniorPublicFigureName, applicationInquiryKycInformation.relatedSeniorPublicFigureName) &&
        Objects.equals(this.relatedSeniorPublicFigureDesignation, applicationInquiryKycInformation.relatedSeniorPublicFigureDesignation) &&
        Objects.equals(this.relatedSpfCountryOfGovernment, applicationInquiryKycInformation.relatedSpfCountryOfGovernment) &&
        Objects.equals(this.relatedSeniorPublicFigureDepartment, applicationInquiryKycInformation.relatedSeniorPublicFigureDepartment) &&
        Objects.equals(this.relationshipWithSeniorPublicFigure, applicationInquiryKycInformation.relationshipWithSeniorPublicFigure) &&
        Objects.equals(this.relatedSeniorPublicFigureLastName, applicationInquiryKycInformation.relatedSeniorPublicFigureLastName) &&
        Objects.equals(this.usTaxStatus, applicationInquiryKycInformation.usTaxStatus) &&
        Objects.equals(this.usTaxId, applicationInquiryKycInformation.usTaxId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(selfPublicFigureDeclarationFlag, publicFigureOfficeStatus, publicFigureOfficeDetails, publicFigureOfficeStartDate, publicFigureOfficeEndDate, isRelatedToSeniorPublicFigure, relatedSeniorPublicFigureName, relatedSeniorPublicFigureDesignation, relatedSpfCountryOfGovernment, relatedSeniorPublicFigureDepartment, relationshipWithSeniorPublicFigure, relatedSeniorPublicFigureLastName, usTaxStatus, usTaxId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationInquiryKycInformation {\n");
    
    sb.append("    selfPublicFigureDeclarationFlag: ").append(toIndentedString(selfPublicFigureDeclarationFlag)).append("\n");
    sb.append("    publicFigureOfficeStatus: ").append(toIndentedString(publicFigureOfficeStatus)).append("\n");
    sb.append("    publicFigureOfficeDetails: ").append(toIndentedString(publicFigureOfficeDetails)).append("\n");
    sb.append("    publicFigureOfficeStartDate: ").append(toIndentedString(publicFigureOfficeStartDate)).append("\n");
    sb.append("    publicFigureOfficeEndDate: ").append(toIndentedString(publicFigureOfficeEndDate)).append("\n");
    sb.append("    isRelatedToSeniorPublicFigure: ").append(toIndentedString(isRelatedToSeniorPublicFigure)).append("\n");
    sb.append("    relatedSeniorPublicFigureName: ").append(toIndentedString(relatedSeniorPublicFigureName)).append("\n");
    sb.append("    relatedSeniorPublicFigureDesignation: ").append(toIndentedString(relatedSeniorPublicFigureDesignation)).append("\n");
    sb.append("    relatedSpfCountryOfGovernment: ").append(toIndentedString(relatedSpfCountryOfGovernment)).append("\n");
    sb.append("    relatedSeniorPublicFigureDepartment: ").append(toIndentedString(relatedSeniorPublicFigureDepartment)).append("\n");
    sb.append("    relationshipWithSeniorPublicFigure: ").append(toIndentedString(relationshipWithSeniorPublicFigure)).append("\n");
    sb.append("    relatedSeniorPublicFigureLastName: ").append(toIndentedString(relatedSeniorPublicFigureLastName)).append("\n");
    sb.append("    usTaxStatus: ").append(toIndentedString(usTaxStatus)).append("\n");
    sb.append("    usTaxId: ").append(toIndentedString(usTaxId)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
