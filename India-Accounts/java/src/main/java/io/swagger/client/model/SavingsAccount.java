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
 * SavingsAccount
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class SavingsAccount {
  @SerializedName("productName")
  private String productName = null;

  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("currentBalance")
  private Double currentBalance = null;

  @SerializedName("availableBalance")
  private Double availableBalance = null;

  @SerializedName("currencyCode")
  private String currencyCode = null;

  @SerializedName("lastStatementDate")
  private LocalDate lastStatementDate = null;

  @SerializedName("holdAmount")
  private Double holdAmount = null;

  @SerializedName("openingDate")
  private LocalDate openingDate = null;

  @SerializedName("floatAmount")
  private Double floatAmount = null;

  @SerializedName("totalInterestAmount")
  private Double totalInterestAmount = null;

  public SavingsAccount productName(String productName) {
    this.productName = productName;
    return this;
  }

   /**
   * The name of the product
   * @return productName
  **/
  @Schema(example = "Personal Saving Account", description = "The name of the product")
  public String getProductName() {
    return productName;
  }

  public void setProductName(String productName) {
    this.productName = productName;
  }

  public SavingsAccount productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "0200_VC400", description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public SavingsAccount displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayAccountNumber
  **/
  @Schema(example = "XXXXXX2391", required = true, description = "A masked account number that can be displayed to the customer")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public SavingsAccount currentBalance(Double currentBalance) {
    this.currentBalance = currentBalance;
    return this;
  }

   /**
   * The current balance including any pending or in progress deposits and withdrawals
   * @return currentBalance
  **/
  @Schema(example = "10000.25", description = "The current balance including any pending or in progress deposits and withdrawals")
  public Double getCurrentBalance() {
    return currentBalance;
  }

  public void setCurrentBalance(Double currentBalance) {
    this.currentBalance = currentBalance;
  }

  public SavingsAccount availableBalance(Double availableBalance) {
    this.availableBalance = availableBalance;
    return this;
  }

   /**
   * The amount available  to withdraw or transfer immediately
   * @return availableBalance
  **/
  @Schema(example = "15000.25", description = "The amount available  to withdraw or transfer immediately")
  public Double getAvailableBalance() {
    return availableBalance;
  }

  public void setAvailableBalance(Double availableBalance) {
    this.availableBalance = availableBalance;
  }

  public SavingsAccount currencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
    return this;
  }

   /**
   * The currency code of the account in ISO 4217 format
   * @return currencyCode
  **/
  @Schema(example = "EUR", description = "The currency code of the account in ISO 4217 format")
  public String getCurrencyCode() {
    return currencyCode;
  }

  public void setCurrencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
  }

  public SavingsAccount lastStatementDate(LocalDate lastStatementDate) {
    this.lastStatementDate = lastStatementDate;
    return this;
  }

   /**
   * The date of the last statement in ISO 8601 date format YYYY-MM-DD
   * @return lastStatementDate
  **/
  @Schema(example = "Thu Jun 25 00:00:00 UTC 2015", description = "The date of the last statement in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getLastStatementDate() {
    return lastStatementDate;
  }

  public void setLastStatementDate(LocalDate lastStatementDate) {
    this.lastStatementDate = lastStatementDate;
  }

  public SavingsAccount holdAmount(Double holdAmount) {
    this.holdAmount = holdAmount;
    return this;
  }

   /**
   * A portion of account balance unavailable for use for a set period
   * @return holdAmount
  **/
  @Schema(example = "12900.12", description = "A portion of account balance unavailable for use for a set period")
  public Double getHoldAmount() {
    return holdAmount;
  }

  public void setHoldAmount(Double holdAmount) {
    this.holdAmount = holdAmount;
  }

  public SavingsAccount openingDate(LocalDate openingDate) {
    this.openingDate = openingDate;
    return this;
  }

   /**
   * Saving account opening date in ISO 8601 date format YYYY-MM-DD
   * @return openingDate
  **/
  @Schema(example = "Sat Dec 01 00:00:00 UTC 2007", description = "Saving account opening date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getOpeningDate() {
    return openingDate;
  }

  public void setOpeningDate(LocalDate openingDate) {
    this.openingDate = openingDate;
  }

  public SavingsAccount floatAmount(Double floatAmount) {
    this.floatAmount = floatAmount;
    return this;
  }

   /**
   * The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a savings account. These funds are unavailable for withdrawal until they are paid by the drawee bank.
   * @return floatAmount
  **/
  @Schema(example = "250000.25", description = "The total amount of funds that have not yet been cleared through the collection process for cheque and other instruments deposited to a savings account. These funds are unavailable for withdrawal until they are paid by the drawee bank.")
  public Double getFloatAmount() {
    return floatAmount;
  }

  public void setFloatAmount(Double floatAmount) {
    this.floatAmount = floatAmount;
  }

  public SavingsAccount totalInterestAmount(Double totalInterestAmount) {
    this.totalInterestAmount = totalInterestAmount;
    return this;
  }

   /**
   * Total interest amount on the saving account
   * @return totalInterestAmount
  **/
  @Schema(example = "1250.25", description = "Total interest amount on the saving account")
  public Double getTotalInterestAmount() {
    return totalInterestAmount;
  }

  public void setTotalInterestAmount(Double totalInterestAmount) {
    this.totalInterestAmount = totalInterestAmount;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    SavingsAccount savingsAccount = (SavingsAccount) o;
    return Objects.equals(this.productName, savingsAccount.productName) &&
        Objects.equals(this.productCode, savingsAccount.productCode) &&
        Objects.equals(this.displayAccountNumber, savingsAccount.displayAccountNumber) &&
        Objects.equals(this.currentBalance, savingsAccount.currentBalance) &&
        Objects.equals(this.availableBalance, savingsAccount.availableBalance) &&
        Objects.equals(this.currencyCode, savingsAccount.currencyCode) &&
        Objects.equals(this.lastStatementDate, savingsAccount.lastStatementDate) &&
        Objects.equals(this.holdAmount, savingsAccount.holdAmount) &&
        Objects.equals(this.openingDate, savingsAccount.openingDate) &&
        Objects.equals(this.floatAmount, savingsAccount.floatAmount) &&
        Objects.equals(this.totalInterestAmount, savingsAccount.totalInterestAmount);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productName, productCode, displayAccountNumber, currentBalance, availableBalance, currencyCode, lastStatementDate, holdAmount, openingDate, floatAmount, totalInterestAmount);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class SavingsAccount {\n");
    
    sb.append("    productName: ").append(toIndentedString(productName)).append("\n");
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    currentBalance: ").append(toIndentedString(currentBalance)).append("\n");
    sb.append("    availableBalance: ").append(toIndentedString(availableBalance)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
    sb.append("    lastStatementDate: ").append(toIndentedString(lastStatementDate)).append("\n");
    sb.append("    holdAmount: ").append(toIndentedString(holdAmount)).append("\n");
    sb.append("    openingDate: ").append(toIndentedString(openingDate)).append("\n");
    sb.append("    floatAmount: ").append(toIndentedString(floatAmount)).append("\n");
    sb.append("    totalInterestAmount: ").append(toIndentedString(totalInterestAmount)).append("\n");
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
