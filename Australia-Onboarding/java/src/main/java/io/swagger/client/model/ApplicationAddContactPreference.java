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
/**
 * ApplicationAddContactPreference
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddContactPreference {
  @SerializedName("sendSmsAdviceFlag")
  private Boolean sendSmsAdviceFlag = null;

  @SerializedName("sendEmailAdviceFlag")
  private Boolean sendEmailAdviceFlag = null;

  @SerializedName("preferredMailingAddress")
  private String preferredMailingAddress = null;

  @SerializedName("eStatementEnrollmentFlag")
  private Boolean eStatementEnrollmentFlag = null;

  public ApplicationAddContactPreference sendSmsAdviceFlag(Boolean sendSmsAdviceFlag) {
    this.sendSmsAdviceFlag = sendSmsAdviceFlag;
    return this;
  }

   /**
   * Applicant&#x27;s subscription for receiving advices through SMS. Valid values: true and false
   * @return sendSmsAdviceFlag
  **/
  @Schema(example = "true", description = "Applicant's subscription for receiving advices through SMS. Valid values: true and false")
  public Boolean isSendSmsAdviceFlag() {
    return sendSmsAdviceFlag;
  }

  public void setSendSmsAdviceFlag(Boolean sendSmsAdviceFlag) {
    this.sendSmsAdviceFlag = sendSmsAdviceFlag;
  }

  public ApplicationAddContactPreference sendEmailAdviceFlag(Boolean sendEmailAdviceFlag) {
    this.sendEmailAdviceFlag = sendEmailAdviceFlag;
    return this;
  }

   /**
   * Applicant&#x27;s subscription for receiving advices through email. Valid values: true and false
   * @return sendEmailAdviceFlag
  **/
  @Schema(example = "true", description = "Applicant's subscription for receiving advices through email. Valid values: true and false")
  public Boolean isSendEmailAdviceFlag() {
    return sendEmailAdviceFlag;
  }

  public void setSendEmailAdviceFlag(Boolean sendEmailAdviceFlag) {
    this.sendEmailAdviceFlag = sendEmailAdviceFlag;
  }

  public ApplicationAddContactPreference preferredMailingAddress(String preferredMailingAddress) {
    this.preferredMailingAddress = preferredMailingAddress;
    return this;
  }

   /**
   * Preferred Mailing Address by applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use preferredMailingAddress field name as the referenceCode parameter to retrieve the values.
   * @return preferredMailingAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Preferred Mailing Address by applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use preferredMailingAddress field name as the referenceCode parameter to retrieve the values.")
  public String getPreferredMailingAddress() {
    return preferredMailingAddress;
  }

  public void setPreferredMailingAddress(String preferredMailingAddress) {
    this.preferredMailingAddress = preferredMailingAddress;
  }

  public ApplicationAddContactPreference eStatementEnrollmentFlag(Boolean eStatementEnrollmentFlag) {
    this.eStatementEnrollmentFlag = eStatementEnrollmentFlag;
    return this;
  }

   /**
   * Applicant&#x27;s subscription for receiving statement over email. Valid values: true and false
   * @return eStatementEnrollmentFlag
  **/
  @Schema(example = "true", description = "Applicant's subscription for receiving statement over email. Valid values: true and false")
  public Boolean isEStatementEnrollmentFlag() {
    return eStatementEnrollmentFlag;
  }

  public void setEStatementEnrollmentFlag(Boolean eStatementEnrollmentFlag) {
    this.eStatementEnrollmentFlag = eStatementEnrollmentFlag;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddContactPreference applicationAddContactPreference = (ApplicationAddContactPreference) o;
    return Objects.equals(this.sendSmsAdviceFlag, applicationAddContactPreference.sendSmsAdviceFlag) &&
        Objects.equals(this.sendEmailAdviceFlag, applicationAddContactPreference.sendEmailAdviceFlag) &&
        Objects.equals(this.preferredMailingAddress, applicationAddContactPreference.preferredMailingAddress) &&
        Objects.equals(this.eStatementEnrollmentFlag, applicationAddContactPreference.eStatementEnrollmentFlag);
  }

  @Override
  public int hashCode() {
    return Objects.hash(sendSmsAdviceFlag, sendEmailAdviceFlag, preferredMailingAddress, eStatementEnrollmentFlag);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddContactPreference {\n");
    
    sb.append("    sendSmsAdviceFlag: ").append(toIndentedString(sendSmsAdviceFlag)).append("\n");
    sb.append("    sendEmailAdviceFlag: ").append(toIndentedString(sendEmailAdviceFlag)).append("\n");
    sb.append("    preferredMailingAddress: ").append(toIndentedString(preferredMailingAddress)).append("\n");
    sb.append("    eStatementEnrollmentFlag: ").append(toIndentedString(eStatementEnrollmentFlag)).append("\n");
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
