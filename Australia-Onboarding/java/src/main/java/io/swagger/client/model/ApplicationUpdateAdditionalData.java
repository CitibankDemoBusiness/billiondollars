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
import io.swagger.client.model.ApplicationUpdateCountrySpecificGroup;
import io.swagger.client.model.ApplicationUpdatePrimaryBankDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
/**
 * ApplicationUpdateAdditionalData
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationUpdateAdditionalData {
  @SerializedName("numberOfDependents")
  private BigDecimal numberOfDependents = null;

  @SerializedName("staffIndicator")
  private Boolean staffIndicator = null;

  @SerializedName("businessNature")
  private String businessNature = null;

  @SerializedName("emergencyContactName")
  private String emergencyContactName = null;

  @SerializedName("emergencyContactPhoneNumber")
  private String emergencyContactPhoneNumber = null;

  @SerializedName("overLimitConsentFlag")
  private Boolean overLimitConsentFlag = null;

  @SerializedName("countrySpecificGroup")
  private ApplicationUpdateCountrySpecificGroup countrySpecificGroup = null;

  @SerializedName("primaryBankDetails")
  private ApplicationUpdatePrimaryBankDetails primaryBankDetails = null;

  @SerializedName("referralGivenName")
  private String referralGivenName = null;

  @SerializedName("referralSurname")
  private String referralSurname = null;

  @SerializedName("relatedToCitiEmployeeFlag")
  private Boolean relatedToCitiEmployeeFlag = null;

  @SerializedName("relatedCitiEmployeeName")
  private String relatedCitiEmployeeName = null;

  @SerializedName("relatedCitiEmployeeDepartment")
  private String relatedCitiEmployeeDepartment = null;

  @SerializedName("creditCardUsagePurpose")
  private String creditCardUsagePurpose = null;

  public ApplicationUpdateAdditionalData numberOfDependents(BigDecimal numberOfDependents) {
    this.numberOfDependents = numberOfDependents;
    return this;
  }

   /**
   * Number of dependants
   * @return numberOfDependents
  **/
  @Schema(example = "2.0", description = "Number of dependants")
  public BigDecimal getNumberOfDependents() {
    return numberOfDependents;
  }

  public void setNumberOfDependents(BigDecimal numberOfDependents) {
    this.numberOfDependents = numberOfDependents;
  }

  public ApplicationUpdateAdditionalData staffIndicator(Boolean staffIndicator) {
    this.staffIndicator = staffIndicator;
    return this;
  }

   /**
   * Flag to indicates if applicant is a Citi Staff. Valid values: true and false
   * @return staffIndicator
  **/
  @Schema(example = "true", description = "Flag to indicates if applicant is a Citi Staff. Valid values: true and false")
  public Boolean isStaffIndicator() {
    return staffIndicator;
  }

  public void setStaffIndicator(Boolean staffIndicator) {
    this.staffIndicator = staffIndicator;
  }

  public ApplicationUpdateAdditionalData businessNature(String businessNature) {
    this.businessNature = businessNature;
    return this;
  }

   /**
   * Business nature of the applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{businessNature} resource to get valid value of this field with description. You can use businessNature field name as the referenceCode parameter to retrieve the values.
   * @return businessNature
  **/
  @Schema(example = "BANKING_FINANCIAL_INSTITUTIONS", description = "Business nature of the applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{businessNature} resource to get valid value of this field with description. You can use businessNature field name as the referenceCode parameter to retrieve the values.")
  public String getBusinessNature() {
    return businessNature;
  }

  public void setBusinessNature(String businessNature) {
    this.businessNature = businessNature;
  }

  public ApplicationUpdateAdditionalData emergencyContactName(String emergencyContactName) {
    this.emergencyContactName = emergencyContactName;
    return this;
  }

   /**
   * Emergency Contact Name
   * @return emergencyContactName
  **/
  @Schema(example = "Pearline", description = "Emergency Contact Name")
  public String getEmergencyContactName() {
    return emergencyContactName;
  }

  public void setEmergencyContactName(String emergencyContactName) {
    this.emergencyContactName = emergencyContactName;
  }

  public ApplicationUpdateAdditionalData emergencyContactPhoneNumber(String emergencyContactPhoneNumber) {
    this.emergencyContactPhoneNumber = emergencyContactPhoneNumber;
    return this;
  }

   /**
   * Emergency Contact Number.
   * @return emergencyContactPhoneNumber
  **/
  @Schema(example = "65012301", description = "Emergency Contact Number.")
  public String getEmergencyContactPhoneNumber() {
    return emergencyContactPhoneNumber;
  }

  public void setEmergencyContactPhoneNumber(String emergencyContactPhoneNumber) {
    this.emergencyContactPhoneNumber = emergencyContactPhoneNumber;
  }

  public ApplicationUpdateAdditionalData overLimitConsentFlag(Boolean overLimitConsentFlag) {
    this.overLimitConsentFlag = overLimitConsentFlag;
    return this;
  }

   /**
   * Customer Consent on spending more than the limit assigned to him. Valid values: true and false
   * @return overLimitConsentFlag
  **/
  @Schema(example = "true", description = "Customer Consent on spending more than the limit assigned to him. Valid values: true and false")
  public Boolean isOverLimitConsentFlag() {
    return overLimitConsentFlag;
  }

  public void setOverLimitConsentFlag(Boolean overLimitConsentFlag) {
    this.overLimitConsentFlag = overLimitConsentFlag;
  }

  public ApplicationUpdateAdditionalData countrySpecificGroup(ApplicationUpdateCountrySpecificGroup countrySpecificGroup) {
    this.countrySpecificGroup = countrySpecificGroup;
    return this;
  }

   /**
   * Get countrySpecificGroup
   * @return countrySpecificGroup
  **/
  @Schema(description = "")
  public ApplicationUpdateCountrySpecificGroup getCountrySpecificGroup() {
    return countrySpecificGroup;
  }

  public void setCountrySpecificGroup(ApplicationUpdateCountrySpecificGroup countrySpecificGroup) {
    this.countrySpecificGroup = countrySpecificGroup;
  }

  public ApplicationUpdateAdditionalData primaryBankDetails(ApplicationUpdatePrimaryBankDetails primaryBankDetails) {
    this.primaryBankDetails = primaryBankDetails;
    return this;
  }

   /**
   * Get primaryBankDetails
   * @return primaryBankDetails
  **/
  @Schema(description = "")
  public ApplicationUpdatePrimaryBankDetails getPrimaryBankDetails() {
    return primaryBankDetails;
  }

  public void setPrimaryBankDetails(ApplicationUpdatePrimaryBankDetails primaryBankDetails) {
    this.primaryBankDetails = primaryBankDetails;
  }

  public ApplicationUpdateAdditionalData referralGivenName(String referralGivenName) {
    this.referralGivenName = referralGivenName;
    return this;
  }

   /**
   * Referral First Name.
   * @return referralGivenName
  **/
  @Schema(example = "Maxwell", description = "Referral First Name.")
  public String getReferralGivenName() {
    return referralGivenName;
  }

  public void setReferralGivenName(String referralGivenName) {
    this.referralGivenName = referralGivenName;
  }

  public ApplicationUpdateAdditionalData referralSurname(String referralSurname) {
    this.referralSurname = referralSurname;
    return this;
  }

   /**
   * Referral Surname/Last Name.
   * @return referralSurname
  **/
  @Schema(example = "Gate", description = "Referral Surname/Last Name.")
  public String getReferralSurname() {
    return referralSurname;
  }

  public void setReferralSurname(String referralSurname) {
    this.referralSurname = referralSurname;
  }

  public ApplicationUpdateAdditionalData relatedToCitiEmployeeFlag(Boolean relatedToCitiEmployeeFlag) {
    this.relatedToCitiEmployeeFlag = relatedToCitiEmployeeFlag;
    return this;
  }

   /**
   * Self declaration if applicant has any relation with citi bank employee. Valid values: true and false
   * @return relatedToCitiEmployeeFlag
  **/
  @Schema(example = "true", description = "Self declaration if applicant has any relation with citi bank employee. Valid values: true and false")
  public Boolean isRelatedToCitiEmployeeFlag() {
    return relatedToCitiEmployeeFlag;
  }

  public void setRelatedToCitiEmployeeFlag(Boolean relatedToCitiEmployeeFlag) {
    this.relatedToCitiEmployeeFlag = relatedToCitiEmployeeFlag;
  }

  public ApplicationUpdateAdditionalData relatedCitiEmployeeName(String relatedCitiEmployeeName) {
    this.relatedCitiEmployeeName = relatedCitiEmployeeName;
    return this;
  }

   /**
   * Name of the citi employee if applicant has any relation with citi bank employee.
   * @return relatedCitiEmployeeName
  **/
  @Schema(example = "Anderson", description = "Name of the citi employee if applicant has any relation with citi bank employee.")
  public String getRelatedCitiEmployeeName() {
    return relatedCitiEmployeeName;
  }

  public void setRelatedCitiEmployeeName(String relatedCitiEmployeeName) {
    this.relatedCitiEmployeeName = relatedCitiEmployeeName;
  }

  public ApplicationUpdateAdditionalData relatedCitiEmployeeDepartment(String relatedCitiEmployeeDepartment) {
    this.relatedCitiEmployeeDepartment = relatedCitiEmployeeDepartment;
    return this;
  }

   /**
   * Department of citi employee if applicant has any relation with citi bank employee.
   * @return relatedCitiEmployeeDepartment
  **/
  @Schema(example = "Finance", description = "Department of citi employee if applicant has any relation with citi bank employee.")
  public String getRelatedCitiEmployeeDepartment() {
    return relatedCitiEmployeeDepartment;
  }

  public void setRelatedCitiEmployeeDepartment(String relatedCitiEmployeeDepartment) {
    this.relatedCitiEmployeeDepartment = relatedCitiEmployeeDepartment;
  }

  public ApplicationUpdateAdditionalData creditCardUsagePurpose(String creditCardUsagePurpose) {
    this.creditCardUsagePurpose = creditCardUsagePurpose;
    return this;
  }

   /**
   * Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/apac/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description.
   * @return creditCardUsagePurpose
  **/
  @Schema(example = "PERSONAL", description = "Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/apac/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description.")
  public String getCreditCardUsagePurpose() {
    return creditCardUsagePurpose;
  }

  public void setCreditCardUsagePurpose(String creditCardUsagePurpose) {
    this.creditCardUsagePurpose = creditCardUsagePurpose;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationUpdateAdditionalData applicationUpdateAdditionalData = (ApplicationUpdateAdditionalData) o;
    return Objects.equals(this.numberOfDependents, applicationUpdateAdditionalData.numberOfDependents) &&
        Objects.equals(this.staffIndicator, applicationUpdateAdditionalData.staffIndicator) &&
        Objects.equals(this.businessNature, applicationUpdateAdditionalData.businessNature) &&
        Objects.equals(this.emergencyContactName, applicationUpdateAdditionalData.emergencyContactName) &&
        Objects.equals(this.emergencyContactPhoneNumber, applicationUpdateAdditionalData.emergencyContactPhoneNumber) &&
        Objects.equals(this.overLimitConsentFlag, applicationUpdateAdditionalData.overLimitConsentFlag) &&
        Objects.equals(this.countrySpecificGroup, applicationUpdateAdditionalData.countrySpecificGroup) &&
        Objects.equals(this.primaryBankDetails, applicationUpdateAdditionalData.primaryBankDetails) &&
        Objects.equals(this.referralGivenName, applicationUpdateAdditionalData.referralGivenName) &&
        Objects.equals(this.referralSurname, applicationUpdateAdditionalData.referralSurname) &&
        Objects.equals(this.relatedToCitiEmployeeFlag, applicationUpdateAdditionalData.relatedToCitiEmployeeFlag) &&
        Objects.equals(this.relatedCitiEmployeeName, applicationUpdateAdditionalData.relatedCitiEmployeeName) &&
        Objects.equals(this.relatedCitiEmployeeDepartment, applicationUpdateAdditionalData.relatedCitiEmployeeDepartment) &&
        Objects.equals(this.creditCardUsagePurpose, applicationUpdateAdditionalData.creditCardUsagePurpose);
  }

  @Override
  public int hashCode() {
    return Objects.hash(numberOfDependents, staffIndicator, businessNature, emergencyContactName, emergencyContactPhoneNumber, overLimitConsentFlag, countrySpecificGroup, primaryBankDetails, referralGivenName, referralSurname, relatedToCitiEmployeeFlag, relatedCitiEmployeeName, relatedCitiEmployeeDepartment, creditCardUsagePurpose);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationUpdateAdditionalData {\n");
    
    sb.append("    numberOfDependents: ").append(toIndentedString(numberOfDependents)).append("\n");
    sb.append("    staffIndicator: ").append(toIndentedString(staffIndicator)).append("\n");
    sb.append("    businessNature: ").append(toIndentedString(businessNature)).append("\n");
    sb.append("    emergencyContactName: ").append(toIndentedString(emergencyContactName)).append("\n");
    sb.append("    emergencyContactPhoneNumber: ").append(toIndentedString(emergencyContactPhoneNumber)).append("\n");
    sb.append("    overLimitConsentFlag: ").append(toIndentedString(overLimitConsentFlag)).append("\n");
    sb.append("    countrySpecificGroup: ").append(toIndentedString(countrySpecificGroup)).append("\n");
    sb.append("    primaryBankDetails: ").append(toIndentedString(primaryBankDetails)).append("\n");
    sb.append("    referralGivenName: ").append(toIndentedString(referralGivenName)).append("\n");
    sb.append("    referralSurname: ").append(toIndentedString(referralSurname)).append("\n");
    sb.append("    relatedToCitiEmployeeFlag: ").append(toIndentedString(relatedToCitiEmployeeFlag)).append("\n");
    sb.append("    relatedCitiEmployeeName: ").append(toIndentedString(relatedCitiEmployeeName)).append("\n");
    sb.append("    relatedCitiEmployeeDepartment: ").append(toIndentedString(relatedCitiEmployeeDepartment)).append("\n");
    sb.append("    creditCardUsagePurpose: ").append(toIndentedString(creditCardUsagePurpose)).append("\n");
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
