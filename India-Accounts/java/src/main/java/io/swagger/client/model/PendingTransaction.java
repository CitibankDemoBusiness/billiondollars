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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.LocalDate;
/**
 * PendingTransaction
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class PendingTransaction {
  @SerializedName("transactionDate")
  private LocalDate transactionDate = null;

  @SerializedName("transactionDescription")
  private String transactionDescription = null;

  @SerializedName("transactionAuthorizationCode")
  private String transactionAuthorizationCode = null;

  @SerializedName("transactionReferenceId")
  private String transactionReferenceId = null;

  @SerializedName("merchantName")
  private String merchantName = null;

  @SerializedName("transactionAmount")
  private Double transactionAmount = null;

  public PendingTransaction transactionDate(LocalDate transactionDate) {
    this.transactionDate = transactionDate;
    return this;
  }

   /**
   * Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,
   * @return transactionDate
  **/
  @Schema(example = "Sun May 21 00:00:00 UTC 2017", required = true, description = "Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting,")
  public LocalDate getTransactionDate() {
    return transactionDate;
  }

  public void setTransactionDate(LocalDate transactionDate) {
    this.transactionDate = transactionDate;
  }

  public PendingTransaction transactionDescription(String transactionDescription) {
    this.transactionDescription = transactionDescription;
    return this;
  }

   /**
   * Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.
   * @return transactionDescription
  **/
  @Schema(example = "INTEREST PAYMENT", required = true, description = "Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.")
  public String getTransactionDescription() {
    return transactionDescription;
  }

  public void setTransactionDescription(String transactionDescription) {
    this.transactionDescription = transactionDescription;
  }

  public PendingTransaction transactionAuthorizationCode(String transactionAuthorizationCode) {
    this.transactionAuthorizationCode = transactionAuthorizationCode;
    return this;
  }

   /**
   * Transaction authorization code is a unique to a sales credit card transaction to indicate that the sale has been authorized. This is applicable only for pending transactions.
   * @return transactionAuthorizationCode
  **/
  @Schema(example = "987012", description = "Transaction authorization code is a unique to a sales credit card transaction to indicate that the sale has been authorized. This is applicable only for pending transactions.")
  public String getTransactionAuthorizationCode() {
    return transactionAuthorizationCode;
  }

  public void setTransactionAuthorizationCode(String transactionAuthorizationCode) {
    this.transactionAuthorizationCode = transactionAuthorizationCode;
  }

  public PendingTransaction transactionReferenceId(String transactionReferenceId) {
    this.transactionReferenceId = transactionReferenceId;
    return this;
  }

   /**
   * Reference Id to uniquely identify the transaction.
   * @return transactionReferenceId
  **/
  @Schema(example = "ALKJ78", description = "Reference Id to uniquely identify the transaction.")
  public String getTransactionReferenceId() {
    return transactionReferenceId;
  }

  public void setTransactionReferenceId(String transactionReferenceId) {
    this.transactionReferenceId = transactionReferenceId;
  }

  public PendingTransaction merchantName(String merchantName) {
    this.merchantName = merchantName;
    return this;
  }

   /**
   * Transaction merchant name.
   * @return merchantName
  **/
  @Schema(example = "Amzon Inc", description = "Transaction merchant name.")
  public String getMerchantName() {
    return merchantName;
  }

  public void setMerchantName(String merchantName) {
    this.merchantName = merchantName;
  }

  public PendingTransaction transactionAmount(Double transactionAmount) {
    this.transactionAmount = transactionAmount;
    return this;
  }

   /**
   * Transaction amount in local currency.
   * @return transactionAmount
  **/
  @Schema(example = "50.55", required = true, description = "Transaction amount in local currency.")
  public Double getTransactionAmount() {
    return transactionAmount;
  }

  public void setTransactionAmount(Double transactionAmount) {
    this.transactionAmount = transactionAmount;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    PendingTransaction pendingTransaction = (PendingTransaction) o;
    return Objects.equals(this.transactionDate, pendingTransaction.transactionDate) &&
        Objects.equals(this.transactionDescription, pendingTransaction.transactionDescription) &&
        Objects.equals(this.transactionAuthorizationCode, pendingTransaction.transactionAuthorizationCode) &&
        Objects.equals(this.transactionReferenceId, pendingTransaction.transactionReferenceId) &&
        Objects.equals(this.merchantName, pendingTransaction.merchantName) &&
        Objects.equals(this.transactionAmount, pendingTransaction.transactionAmount);
  }

  @Override
  public int hashCode() {
    return Objects.hash(transactionDate, transactionDescription, transactionAuthorizationCode, transactionReferenceId, merchantName, transactionAmount);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class PendingTransaction {\n");
    
    sb.append("    transactionDate: ").append(toIndentedString(transactionDate)).append("\n");
    sb.append("    transactionDescription: ").append(toIndentedString(transactionDescription)).append("\n");
    sb.append("    transactionAuthorizationCode: ").append(toIndentedString(transactionAuthorizationCode)).append("\n");
    sb.append("    transactionReferenceId: ").append(toIndentedString(transactionReferenceId)).append("\n");
    sb.append("    merchantName: ").append(toIndentedString(merchantName)).append("\n");
    sb.append("    transactionAmount: ").append(toIndentedString(transactionAmount)).append("\n");
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