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
import io.swagger.client.model.CorporateOfficerDetails;
import io.swagger.client.model.HistoryAndIntradayTransaction;
import io.swagger.client.model.PendingAuthorizationTransaction;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest {
  @SerializedName("tokenizedCardNumber")
  private String tokenizedCardNumber = null;

  @SerializedName("corporateOfficerDetails")
  private CorporateOfficerDetails corporateOfficerDetails = null;

  @SerializedName("transactionType")
  private String transactionType = null;

  @SerializedName("pendingAuthorizationTransaction")
  private PendingAuthorizationTransaction pendingAuthorizationTransaction = null;

  @SerializedName("historyAndIntradayTransaction")
  private HistoryAndIntradayTransaction historyAndIntradayTransaction = null;

  public RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest tokenizedCardNumber(String tokenizedCardNumber) {
    this.tokenizedCardNumber = tokenizedCardNumber;
    return this;
  }

   /**
   * Tokenized card number
   * @return tokenizedCardNumber
  **/
  @Schema(example = "asdsdf56751d5675k59", required = true, description = "Tokenized card number")
  public String getTokenizedCardNumber() {
    return tokenizedCardNumber;
  }

  public void setTokenizedCardNumber(String tokenizedCardNumber) {
    this.tokenizedCardNumber = tokenizedCardNumber;
  }

  public RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest corporateOfficerDetails(CorporateOfficerDetails corporateOfficerDetails) {
    this.corporateOfficerDetails = corporateOfficerDetails;
    return this;
  }

   /**
   * Get corporateOfficerDetails
   * @return corporateOfficerDetails
  **/
  @Schema(description = "")
  public CorporateOfficerDetails getCorporateOfficerDetails() {
    return corporateOfficerDetails;
  }

  public void setCorporateOfficerDetails(CorporateOfficerDetails corporateOfficerDetails) {
    this.corporateOfficerDetails = corporateOfficerDetails;
  }

  public RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest transactionType(String transactionType) {
    this.transactionType = transactionType;
    return this;
  }

   /**
   * transactionType. This is a reference data field. Please use /v1/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions
   * @return transactionType
  **/
  @Schema(example = "PENDING", required = true, description = "transactionType. This is a reference data field. Please use /v1/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions")
  public String getTransactionType() {
    return transactionType;
  }

  public void setTransactionType(String transactionType) {
    this.transactionType = transactionType;
  }

  public RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest pendingAuthorizationTransaction(PendingAuthorizationTransaction pendingAuthorizationTransaction) {
    this.pendingAuthorizationTransaction = pendingAuthorizationTransaction;
    return this;
  }

   /**
   * Get pendingAuthorizationTransaction
   * @return pendingAuthorizationTransaction
  **/
  @Schema(description = "")
  public PendingAuthorizationTransaction getPendingAuthorizationTransaction() {
    return pendingAuthorizationTransaction;
  }

  public void setPendingAuthorizationTransaction(PendingAuthorizationTransaction pendingAuthorizationTransaction) {
    this.pendingAuthorizationTransaction = pendingAuthorizationTransaction;
  }

  public RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest historyAndIntradayTransaction(HistoryAndIntradayTransaction historyAndIntradayTransaction) {
    this.historyAndIntradayTransaction = historyAndIntradayTransaction;
    return this;
  }

   /**
   * Get historyAndIntradayTransaction
   * @return historyAndIntradayTransaction
  **/
  @Schema(description = "")
  public HistoryAndIntradayTransaction getHistoryAndIntradayTransaction() {
    return historyAndIntradayTransaction;
  }

  public void setHistoryAndIntradayTransaction(HistoryAndIntradayTransaction historyAndIntradayTransaction) {
    this.historyAndIntradayTransaction = historyAndIntradayTransaction;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest = (RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest) o;
    return Objects.equals(this.tokenizedCardNumber, retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.tokenizedCardNumber) &&
        Objects.equals(this.corporateOfficerDetails, retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.corporateOfficerDetails) &&
        Objects.equals(this.transactionType, retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.transactionType) &&
        Objects.equals(this.pendingAuthorizationTransaction, retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.pendingAuthorizationTransaction) &&
        Objects.equals(this.historyAndIntradayTransaction, retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.historyAndIntradayTransaction);
  }

  @Override
  public int hashCode() {
    return Objects.hash(tokenizedCardNumber, corporateOfficerDetails, transactionType, pendingAuthorizationTransaction, historyAndIntradayTransaction);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest {\n");
    
    sb.append("    tokenizedCardNumber: ").append(toIndentedString(tokenizedCardNumber)).append("\n");
    sb.append("    corporateOfficerDetails: ").append(toIndentedString(corporateOfficerDetails)).append("\n");
    sb.append("    transactionType: ").append(toIndentedString(transactionType)).append("\n");
    sb.append("    pendingAuthorizationTransaction: ").append(toIndentedString(pendingAuthorizationTransaction)).append("\n");
    sb.append("    historyAndIntradayTransaction: ").append(toIndentedString(historyAndIntradayTransaction)).append("\n");
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
