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
 * ApplicantUpdateConsentDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicantUpdateConsentDetails {
  @SerializedName("consentType")
  private String consentType = null;

  @SerializedName("isConsentGiven")
  private Boolean isConsentGiven = null;

  public ApplicantUpdateConsentDetails consentType(String consentType) {
    this.consentType = consentType;
    return this;
  }

   /**
   * Applicant&#x27;s consent types. This is a reference data field. Please use /v1/apac/utilities/referenceData/{consentType} resource to get valid value of this field with description. You can use consentType field name as the referenceCode parameter to retrieve the values.
   * @return consentType
  **/
  @Schema(example = "PDP_CONSENT", description = "Applicant's consent types. This is a reference data field. Please use /v1/apac/utilities/referenceData/{consentType} resource to get valid value of this field with description. You can use consentType field name as the referenceCode parameter to retrieve the values.")
  public String getConsentType() {
    return consentType;
  }

  public void setConsentType(String consentType) {
    this.consentType = consentType;
  }

  public ApplicantUpdateConsentDetails isConsentGiven(Boolean isConsentGiven) {
    this.isConsentGiven = isConsentGiven;
    return this;
  }

   /**
   * Consent flag. Valid values: true and false
   * @return isConsentGiven
  **/
  @Schema(example = "true", description = "Consent flag. Valid values: true and false")
  public Boolean isIsConsentGiven() {
    return isConsentGiven;
  }

  public void setIsConsentGiven(Boolean isConsentGiven) {
    this.isConsentGiven = isConsentGiven;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicantUpdateConsentDetails applicantUpdateConsentDetails = (ApplicantUpdateConsentDetails) o;
    return Objects.equals(this.consentType, applicantUpdateConsentDetails.consentType) &&
        Objects.equals(this.isConsentGiven, applicantUpdateConsentDetails.isConsentGiven);
  }

  @Override
  public int hashCode() {
    return Objects.hash(consentType, isConsentGiven);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicantUpdateConsentDetails {\n");
    
    sb.append("    consentType: ").append(toIndentedString(consentType)).append("\n");
    sb.append("    isConsentGiven: ").append(toIndentedString(isConsentGiven)).append("\n");
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
