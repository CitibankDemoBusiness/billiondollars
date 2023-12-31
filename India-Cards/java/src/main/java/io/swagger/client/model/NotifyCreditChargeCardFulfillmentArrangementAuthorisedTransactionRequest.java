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
 * NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest {
  @SerializedName("requestId")
  private String requestId = null;

  @SerializedName("vopTransactionId")
  private String vopTransactionId = null;

  @SerializedName("actionType")
  private String actionType = null;

  @SerializedName("distributorId")
  private String distributorId = null;

  @SerializedName("cardId")
  private String cardId = null;

  @SerializedName("userId")
  private String userId = null;

  @SerializedName("creditStatus")
  private String creditStatus = null;

  @SerializedName("requestDateTime")
  private String requestDateTime = null;

  @SerializedName("offerId")
  private Integer offerId = null;

  @SerializedName("settlementCurrency")
  private String settlementCurrency = null;

  @SerializedName("rewardSettlementCurrency")
  private Double rewardSettlementCurrency = null;

  @SerializedName("billingCurrency")
  private String billingCurrency = null;

  @SerializedName("rewardBillingCurrency")
  private Double rewardBillingCurrency = null;

  @SerializedName("merchantName")
  private String merchantName = null;

  @SerializedName("transactionDate")
  private String transactionDate = null;

  @SerializedName("transactionBillingAmount")
  private Double transactionBillingAmount = null;

  @SerializedName("transactionSettlementAmount")
  private Double transactionSettlementAmount = null;

  @SerializedName("remarks")
  private String remarks = null;

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest requestId(String requestId) {
    this.requestId = requestId;
    return this;
  }

   /**
   * This field provides the unique request ID generated from the VOX platform. Will be used for tracking and audit purposes
   * @return requestId
  **/
  @Schema(example = "f2b4d4d796c344e387563396", required = true, description = "This field provides the unique request ID generated from the VOX platform. Will be used for tracking and audit purposes")
  public String getRequestId() {
    return requestId;
  }

  public void setRequestId(String requestId) {
    this.requestId = requestId;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest vopTransactionId(String vopTransactionId) {
    this.vopTransactionId = vopTransactionId;
    return this;
  }

   /**
   * This field specifies the VOP transaction ID of the original transaction, that triggered the reward.
   * @return vopTransactionId
  **/
  @Schema(example = "45446e6d4c32486f455a4165374a4768", required = true, description = "This field specifies the VOP transaction ID of the original transaction, that triggered the reward.")
  public String getVopTransactionId() {
    return vopTransactionId;
  }

  public void setVopTransactionId(String vopTransactionId) {
    this.vopTransactionId = vopTransactionId;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest actionType(String actionType) {
    this.actionType = actionType;
    return this;
  }

   /**
   * This field specifies the action to be performed for the request.Valid Value is Notify
   * @return actionType
  **/
  @Schema(example = "Notify", required = true, description = "This field specifies the action to be performed for the request.Valid Value is Notify")
  public String getActionType() {
    return actionType;
  }

  public void setActionType(String actionType) {
    this.actionType = actionType;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest distributorId(String distributorId) {
    this.distributorId = distributorId;
    return this;
  }

   /**
   * This field specifies the Distributor ID. Important when an aggregator (who is serving for more than one distributor) is building the API end point.
   * @return distributorId
  **/
  @Schema(example = "45446e6d", required = true, description = "This field specifies the Distributor ID. Important when an aggregator (who is serving for more than one distributor) is building the API end point.")
  public String getDistributorId() {
    return distributorId;
  }

  public void setDistributorId(String distributorId) {
    this.distributorId = distributorId;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest cardId(String cardId) {
    this.cardId = cardId;
    return this;
  }

   /**
   * This field provides the card id generated during cardholder enrolment at VOX.
   * @return cardId
  **/
  @Schema(example = "056ed7a9fe17ea11b17e005056ab64a1", required = true, description = "This field provides the card id generated during cardholder enrolment at VOX.")
  public String getCardId() {
    return cardId;
  }

  public void setCardId(String cardId) {
    this.cardId = cardId;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest userId(String userId) {
    this.userId = userId;
    return this;
  }

   /**
   * This field provides the external user id generated during cardholder enrolment at VOX.
   * @return userId
  **/
  @Schema(example = "2019a12c02v34a1e12", required = true, description = "This field provides the external user id generated during cardholder enrolment at VOX.")
  public String getUserId() {
    return userId;
  }

  public void setUserId(String userId) {
    this.userId = userId;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest creditStatus(String creditStatus) {
    this.creditStatus = creditStatus;
    return this;
  }

   /**
   * This field specifies the reward credit status.Valid Values are Successful, Eligible, Failed
   * @return creditStatus
  **/
  @Schema(example = "Eligible", required = true, description = "This field specifies the reward credit status.Valid Values are Successful, Eligible, Failed")
  public String getCreditStatus() {
    return creditStatus;
  }

  public void setCreditStatus(String creditStatus) {
    this.creditStatus = creditStatus;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest requestDateTime(String requestDateTime) {
    this.requestDateTime = requestDateTime;
    return this;
  }

   /**
   * This field specifies the date and time which the reward request is initiated in the format YYYY-MM-DD HH:MM:SS
   * @return requestDateTime
  **/
  @Schema(example = "2021-04-29 04:05:06", required = true, description = "This field specifies the date and time which the reward request is initiated in the format YYYY-MM-DD HH:MM:SS")
  public String getRequestDateTime() {
    return requestDateTime;
  }

  public void setRequestDateTime(String requestDateTime) {
    this.requestDateTime = requestDateTime;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest offerId(Integer offerId) {
    this.offerId = offerId;
    return this;
  }

   /**
   * This will be the VOX qualified offer ID, which the reward is given, Will be used for tracking and audit purposes.
   * @return offerId
  **/
  @Schema(example = "6", required = true, description = "This will be the VOX qualified offer ID, which the reward is given, Will be used for tracking and audit purposes.")
  public Integer getOfferId() {
    return offerId;
  }

  public void setOfferId(Integer offerId) {
    this.offerId = offerId;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest settlementCurrency(String settlementCurrency) {
    this.settlementCurrency = settlementCurrency;
    return this;
  }

   /**
   * This field specifies the reward currency of the original offer
   * @return settlementCurrency
  **/
  @Schema(example = "036", required = true, description = "This field specifies the reward currency of the original offer")
  public String getSettlementCurrency() {
    return settlementCurrency;
  }

  public void setSettlementCurrency(String settlementCurrency) {
    this.settlementCurrency = settlementCurrency;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest rewardSettlementCurrency(Double rewardSettlementCurrency) {
    this.rewardSettlementCurrency = rewardSettlementCurrency;
    return this;
  }

   /**
   * This field specifies the cashback reward value in Settlement Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00
   * @return rewardSettlementCurrency
  **/
  @Schema(example = "100.25", required = true, description = "This field specifies the cashback reward value in Settlement Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00")
  public Double getRewardSettlementCurrency() {
    return rewardSettlementCurrency;
  }

  public void setRewardSettlementCurrency(Double rewardSettlementCurrency) {
    this.rewardSettlementCurrency = rewardSettlementCurrency;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest billingCurrency(String billingCurrency) {
    this.billingCurrency = billingCurrency;
    return this;
  }

   /**
   * This field specifies the customer purchase currency derived from the VOP transaction.
   * @return billingCurrency
  **/
  @Schema(example = "036", required = true, description = "This field specifies the customer purchase currency derived from the VOP transaction.")
  public String getBillingCurrency() {
    return billingCurrency;
  }

  public void setBillingCurrency(String billingCurrency) {
    this.billingCurrency = billingCurrency;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest rewardBillingCurrency(Double rewardBillingCurrency) {
    this.rewardBillingCurrency = rewardBillingCurrency;
    return this;
  }

   /**
   * This field specifies the cashback reward value in Settlement Billing Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00
   * @return rewardBillingCurrency
  **/
  @Schema(example = "100.25", required = true, description = "This field specifies the cashback reward value in Settlement Billing Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00")
  public Double getRewardBillingCurrency() {
    return rewardBillingCurrency;
  }

  public void setRewardBillingCurrency(Double rewardBillingCurrency) {
    this.rewardBillingCurrency = rewardBillingCurrency;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest merchantName(String merchantName) {
    this.merchantName = merchantName;
    return this;
  }

   /**
   * This field provides the merchant name
   * @return merchantName
  **/
  @Schema(example = "Lady Musgrave Experience", required = true, description = "This field provides the merchant name")
  public String getMerchantName() {
    return merchantName;
  }

  public void setMerchantName(String merchantName) {
    this.merchantName = merchantName;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest transactionDate(String transactionDate) {
    this.transactionDate = transactionDate;
    return this;
  }

   /**
   * This field specifies the transaction date retrieved from the VOP Transaction in the format YYYY-MM-DD HH:MM:SS
   * @return transactionDate
  **/
  @Schema(example = "2021-04-29 04:05:06", required = true, description = "This field specifies the transaction date retrieved from the VOP Transaction in the format YYYY-MM-DD HH:MM:SS")
  public String getTransactionDate() {
    return transactionDate;
  }

  public void setTransactionDate(String transactionDate) {
    this.transactionDate = transactionDate;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest transactionBillingAmount(Double transactionBillingAmount) {
    this.transactionBillingAmount = transactionBillingAmount;
    return this;
  }

   /**
   * This field specifies transaction amount in billing currency as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00
   * @return transactionBillingAmount
  **/
  @Schema(example = "100.0", required = true, description = "This field specifies transaction amount in billing currency as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00")
  public Double getTransactionBillingAmount() {
    return transactionBillingAmount;
  }

  public void setTransactionBillingAmount(Double transactionBillingAmount) {
    this.transactionBillingAmount = transactionBillingAmount;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest transactionSettlementAmount(Double transactionSettlementAmount) {
    this.transactionSettlementAmount = transactionSettlementAmount;
    return this;
  }

   /**
   * This field specifies transaction amount in settlement currency  as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00
   * @return transactionSettlementAmount
  **/
  @Schema(example = "100.0", required = true, description = "This field specifies transaction amount in settlement currency  as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00")
  public Double getTransactionSettlementAmount() {
    return transactionSettlementAmount;
  }

  public void setTransactionSettlementAmount(Double transactionSettlementAmount) {
    this.transactionSettlementAmount = transactionSettlementAmount;
  }

  public NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest remarks(String remarks) {
    this.remarks = remarks;
    return this;
  }

   /**
   * This field is used to pass additional information required by the partner for their records. This can pass an empty value as well.
   * @return remarks
  **/
  @Schema(example = "Any additional Information", description = "This field is used to pass additional information required by the partner for their records. This can pass an empty value as well.")
  public String getRemarks() {
    return remarks;
  }

  public void setRemarks(String remarks) {
    this.remarks = remarks;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest = (NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest) o;
    return Objects.equals(this.requestId, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.requestId) &&
        Objects.equals(this.vopTransactionId, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.vopTransactionId) &&
        Objects.equals(this.actionType, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.actionType) &&
        Objects.equals(this.distributorId, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.distributorId) &&
        Objects.equals(this.cardId, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.cardId) &&
        Objects.equals(this.userId, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.userId) &&
        Objects.equals(this.creditStatus, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.creditStatus) &&
        Objects.equals(this.requestDateTime, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.requestDateTime) &&
        Objects.equals(this.offerId, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.offerId) &&
        Objects.equals(this.settlementCurrency, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.settlementCurrency) &&
        Objects.equals(this.rewardSettlementCurrency, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.rewardSettlementCurrency) &&
        Objects.equals(this.billingCurrency, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.billingCurrency) &&
        Objects.equals(this.rewardBillingCurrency, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.rewardBillingCurrency) &&
        Objects.equals(this.merchantName, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.merchantName) &&
        Objects.equals(this.transactionDate, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.transactionDate) &&
        Objects.equals(this.transactionBillingAmount, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.transactionBillingAmount) &&
        Objects.equals(this.transactionSettlementAmount, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.transactionSettlementAmount) &&
        Objects.equals(this.remarks, notifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.remarks);
  }

  @Override
  public int hashCode() {
    return Objects.hash(requestId, vopTransactionId, actionType, distributorId, cardId, userId, creditStatus, requestDateTime, offerId, settlementCurrency, rewardSettlementCurrency, billingCurrency, rewardBillingCurrency, merchantName, transactionDate, transactionBillingAmount, transactionSettlementAmount, remarks);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest {\n");
    
    sb.append("    requestId: ").append(toIndentedString(requestId)).append("\n");
    sb.append("    vopTransactionId: ").append(toIndentedString(vopTransactionId)).append("\n");
    sb.append("    actionType: ").append(toIndentedString(actionType)).append("\n");
    sb.append("    distributorId: ").append(toIndentedString(distributorId)).append("\n");
    sb.append("    cardId: ").append(toIndentedString(cardId)).append("\n");
    sb.append("    userId: ").append(toIndentedString(userId)).append("\n");
    sb.append("    creditStatus: ").append(toIndentedString(creditStatus)).append("\n");
    sb.append("    requestDateTime: ").append(toIndentedString(requestDateTime)).append("\n");
    sb.append("    offerId: ").append(toIndentedString(offerId)).append("\n");
    sb.append("    settlementCurrency: ").append(toIndentedString(settlementCurrency)).append("\n");
    sb.append("    rewardSettlementCurrency: ").append(toIndentedString(rewardSettlementCurrency)).append("\n");
    sb.append("    billingCurrency: ").append(toIndentedString(billingCurrency)).append("\n");
    sb.append("    rewardBillingCurrency: ").append(toIndentedString(rewardBillingCurrency)).append("\n");
    sb.append("    merchantName: ").append(toIndentedString(merchantName)).append("\n");
    sb.append("    transactionDate: ").append(toIndentedString(transactionDate)).append("\n");
    sb.append("    transactionBillingAmount: ").append(toIndentedString(transactionBillingAmount)).append("\n");
    sb.append("    transactionSettlementAmount: ").append(toIndentedString(transactionSettlementAmount)).append("\n");
    sb.append("    remarks: ").append(toIndentedString(remarks)).append("\n");
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
