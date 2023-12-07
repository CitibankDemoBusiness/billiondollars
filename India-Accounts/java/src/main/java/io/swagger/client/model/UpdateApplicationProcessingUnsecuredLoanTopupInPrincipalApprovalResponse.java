/*
 * Accounts
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
import io.swagger.client.model.RequestedLoanTopupDecision;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.LocalDate;
/**
 * UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse {
  @SerializedName("applicationStage")
  private String applicationStage = null;

  @SerializedName("ipaExpiryDate")
  private LocalDate ipaExpiryDate = null;

  @SerializedName("requestedLoanTopupDecision")
  private RequestedLoanTopupDecision requestedLoanTopupDecision = null;

  public UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse applicationStage(String applicationStage) {
    this.applicationStage = applicationStage;
    return this;
  }

   /**
   * Current stage of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStage} resource to get possible value of this field with description.
   * @return applicationStage
  **/
  @Schema(example = "PRESCREENING", description = "Current stage of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStage} resource to get possible value of this field with description.")
  public String getApplicationStage() {
    return applicationStage;
  }

  public void setApplicationStage(String applicationStage) {
    this.applicationStage = applicationStage;
  }

  public UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse ipaExpiryDate(LocalDate ipaExpiryDate) {
    this.ipaExpiryDate = ipaExpiryDate;
    return this;
  }

   /**
   * In principle approval expiration date in ISO 8601 date format YYYY-MM-DD
   * @return ipaExpiryDate
  **/
  @Schema(description = "In principle approval expiration date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getIpaExpiryDate() {
    return ipaExpiryDate;
  }

  public void setIpaExpiryDate(LocalDate ipaExpiryDate) {
    this.ipaExpiryDate = ipaExpiryDate;
  }

  public UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse requestedLoanTopupDecision(RequestedLoanTopupDecision requestedLoanTopupDecision) {
    this.requestedLoanTopupDecision = requestedLoanTopupDecision;
    return this;
  }

   /**
   * Get requestedLoanTopupDecision
   * @return requestedLoanTopupDecision
  **/
  @Schema(description = "")
  public RequestedLoanTopupDecision getRequestedLoanTopupDecision() {
    return requestedLoanTopupDecision;
  }

  public void setRequestedLoanTopupDecision(RequestedLoanTopupDecision requestedLoanTopupDecision) {
    this.requestedLoanTopupDecision = requestedLoanTopupDecision;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse updateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse = (UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse) o;
    return Objects.equals(this.applicationStage, updateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse.applicationStage) &&
        Objects.equals(this.ipaExpiryDate, updateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse.ipaExpiryDate) &&
        Objects.equals(this.requestedLoanTopupDecision, updateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse.requestedLoanTopupDecision);
  }

  @Override
  public int hashCode() {
    return Objects.hash(applicationStage, ipaExpiryDate, requestedLoanTopupDecision);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse {\n");
    
    sb.append("    applicationStage: ").append(toIndentedString(applicationStage)).append("\n");
    sb.append("    ipaExpiryDate: ").append(toIndentedString(ipaExpiryDate)).append("\n");
    sb.append("    requestedLoanTopupDecision: ").append(toIndentedString(requestedLoanTopupDecision)).append("\n");
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
