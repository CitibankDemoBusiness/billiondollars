/*
 * Cards
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest {
  @SerializedName("controlFlowId")
  private String controlFlowId = null;

  @SerializedName("orgCode")
  private String orgCode = null;

  @SerializedName("loanAmount")
  private Double loanAmount = null;

  @SerializedName("promotionId")
  private String promotionId = null;

  @SerializedName("loanTenure")
  private String loanTenure = null;

  @SerializedName("startIndex")
  private String startIndex = null;

  @SerializedName("requestSize")
  private Integer requestSize = null;

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest controlFlowId(String controlFlowId) {
    this.controlFlowId = controlFlowId;
    return this;
  }

   /**
   * Control flow id is used to control the flow for subsequent requests in the session
   * @return controlFlowId
  **/
  @Schema(required = true, description = "Control flow id is used to control the flow for subsequent requests in the session")
  public String getControlFlowId() {
    return controlFlowId;
  }

  public void setControlFlowId(String controlFlowId) {
    this.controlFlowId = controlFlowId;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest orgCode(String orgCode) {
    this.orgCode = orgCode;
    return this;
  }

   /**
   * Organization of the card
   * @return orgCode
  **/
  @Schema(example = "324", required = true, description = "Organization of the card")
  public String getOrgCode() {
    return orgCode;
  }

  public void setOrgCode(String orgCode) {
    this.orgCode = orgCode;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest loanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
    return this;
  }

   /**
   * Loan amount availed by customer
   * @return loanAmount
  **/
  @Schema(example = "16000.0", required = true, description = "Loan amount availed by customer")
  public Double getLoanAmount() {
    return loanAmount;
  }

  public void setLoanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest promotionId(String promotionId) {
    this.promotionId = promotionId;
    return this;
  }

   /**
   * Promotion ID for the loan offered
   * @return promotionId
  **/
  @Schema(example = "IU4587948", required = true, description = "Promotion ID for the loan offered")
  public String getPromotionId() {
    return promotionId;
  }

  public void setPromotionId(String promotionId) {
    this.promotionId = promotionId;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest loanTenure(String loanTenure) {
    this.loanTenure = loanTenure;
    return this;
  }

   /**
   * Tenure of loan against card.
   * @return loanTenure
  **/
  @Schema(example = "3", required = true, description = "Tenure of loan against card.")
  public String getLoanTenure() {
    return loanTenure;
  }

  public void setLoanTenure(String loanTenure) {
    this.loanTenure = loanTenure;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest startIndex(String startIndex) {
    this.startIndex = startIndex;
    return this;
  }

   /**
   * Start index of next fetch of records
   * @return startIndex
  **/
  @Schema(example = "25", description = "Start index of next fetch of records")
  public String getStartIndex() {
    return startIndex;
  }

  public void setStartIndex(String startIndex) {
    this.startIndex = startIndex;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest requestSize(Integer requestSize) {
    this.requestSize = requestSize;
    return this;
  }

   /**
   * Number of records required
   * @return requestSize
  **/
  @Schema(example = "24", description = "Number of records required")
  public Integer getRequestSize() {
    return requestSize;
  }

  public void setRequestSize(Integer requestSize) {
    this.requestSize = requestSize;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest = (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest) o;
    return Objects.equals(this.controlFlowId, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest.controlFlowId) &&
        Objects.equals(this.orgCode, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest.orgCode) &&
        Objects.equals(this.loanAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest.loanAmount) &&
        Objects.equals(this.promotionId, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest.promotionId) &&
        Objects.equals(this.loanTenure, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest.loanTenure) &&
        Objects.equals(this.startIndex, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest.startIndex) &&
        Objects.equals(this.requestSize, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest.requestSize);
  }

  @Override
  public int hashCode() {
    return Objects.hash(controlFlowId, orgCode, loanAmount, promotionId, loanTenure, startIndex, requestSize);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest {\n");
    
    sb.append("    controlFlowId: ").append(toIndentedString(controlFlowId)).append("\n");
    sb.append("    orgCode: ").append(toIndentedString(orgCode)).append("\n");
    sb.append("    loanAmount: ").append(toIndentedString(loanAmount)).append("\n");
    sb.append("    promotionId: ").append(toIndentedString(promotionId)).append("\n");
    sb.append("    loanTenure: ").append(toIndentedString(loanTenure)).append("\n");
    sb.append("    startIndex: ").append(toIndentedString(startIndex)).append("\n");
    sb.append("    requestSize: ").append(toIndentedString(requestSize)).append("\n");
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
