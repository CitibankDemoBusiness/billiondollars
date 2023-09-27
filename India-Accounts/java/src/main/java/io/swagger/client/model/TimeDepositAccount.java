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
 * TimeDepositAccount
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class TimeDepositAccount {
  @SerializedName("productName")
  private String productName = null;

  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("originalPrincipalAmount")
  private Double originalPrincipalAmount = null;

  @SerializedName("currencyCode")
  private String currencyCode = null;

  @SerializedName("interestRate")
  private Double interestRate = null;

  @SerializedName("openingDate")
  private LocalDate openingDate = null;

  @SerializedName("maturityDate")
  private LocalDate maturityDate = null;

  @SerializedName("nextInterestPaymentDate")
  private LocalDate nextInterestPaymentDate = null;

  @SerializedName("interestAmountDue")
  private Double interestAmountDue = null;

  @SerializedName("renewalInstructions")
  private String renewalInstructions = null;

  @SerializedName("tenorTerm")
  private Integer tenorTerm = null;

  @SerializedName("tenorPeriod")
  private String tenorPeriod = null;

  @SerializedName("baseCurrencyMaturityAmount")
  private Double baseCurrencyMaturityAmount = null;

  @SerializedName("maturityInterestAmount")
  private Double maturityInterestAmount = null;

  @SerializedName("lastInterestPaymentAmount")
  private Double lastInterestPaymentAmount = null;

  public TimeDepositAccount productName(String productName) {
    this.productName = productName;
    return this;
  }

   /**
   * The name of the product
   * @return productName
  **/
  @Schema(example = "Time Deposit Account", description = "The name of the product")
  public String getProductName() {
    return productName;
  }

  public void setProductName(String productName) {
    this.productName = productName;
  }

  public TimeDepositAccount productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "0600_VC101", description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public TimeDepositAccount displayAccountNumber(String displayAccountNumber) {
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

  public TimeDepositAccount originalPrincipalAmount(Double originalPrincipalAmount) {
    this.originalPrincipalAmount = originalPrincipalAmount;
    return this;
  }

   /**
   * The original principal amount when account opened.
   * @return originalPrincipalAmount
  **/
  @Schema(example = "10000.25", description = "The original principal amount when account opened.")
  public Double getOriginalPrincipalAmount() {
    return originalPrincipalAmount;
  }

  public void setOriginalPrincipalAmount(Double originalPrincipalAmount) {
    this.originalPrincipalAmount = originalPrincipalAmount;
  }

  public TimeDepositAccount currencyCode(String currencyCode) {
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

  public TimeDepositAccount interestRate(Double interestRate) {
    this.interestRate = interestRate;
    return this;
  }

   /**
   * The rate of interest applicable for the time deposit
   * @return interestRate
  **/
  @Schema(example = "0.0525", description = "The rate of interest applicable for the time deposit")
  public Double getInterestRate() {
    return interestRate;
  }

  public void setInterestRate(Double interestRate) {
    this.interestRate = interestRate;
  }

  public TimeDepositAccount openingDate(LocalDate openingDate) {
    this.openingDate = openingDate;
    return this;
  }

   /**
   * The opening date of the time deposit, in ISO 8601 format YYYY-MM-DD
   * @return openingDate
  **/
  @Schema(example = "Tue Dec 01 00:00:00 UTC 2015", description = "The opening date of the time deposit, in ISO 8601 format YYYY-MM-DD")
  public LocalDate getOpeningDate() {
    return openingDate;
  }

  public void setOpeningDate(LocalDate openingDate) {
    this.openingDate = openingDate;
  }

  public TimeDepositAccount maturityDate(LocalDate maturityDate) {
    this.maturityDate = maturityDate;
    return this;
  }

   /**
   * The date when the time deposit will mature, in ISO 8601 format YYYY-MM-DD
   * @return maturityDate
  **/
  @Schema(example = "Tue Dec 13 00:00:00 UTC 2016", description = "The date when the time deposit will mature, in ISO 8601 format YYYY-MM-DD")
  public LocalDate getMaturityDate() {
    return maturityDate;
  }

  public void setMaturityDate(LocalDate maturityDate) {
    this.maturityDate = maturityDate;
  }

  public TimeDepositAccount nextInterestPaymentDate(LocalDate nextInterestPaymentDate) {
    this.nextInterestPaymentDate = nextInterestPaymentDate;
    return this;
  }

   /**
   * The date when interest will be paid by Citibank, in ISO8601 format YYYY-MM-DD
   * @return nextInterestPaymentDate
  **/
  @Schema(example = "Sun Jan 01 00:00:00 UTC 2017", description = "The date when interest will be paid by Citibank, in ISO8601 format YYYY-MM-DD")
  public LocalDate getNextInterestPaymentDate() {
    return nextInterestPaymentDate;
  }

  public void setNextInterestPaymentDate(LocalDate nextInterestPaymentDate) {
    this.nextInterestPaymentDate = nextInterestPaymentDate;
  }

  public TimeDepositAccount interestAmountDue(Double interestAmountDue) {
    this.interestAmountDue = interestAmountDue;
    return this;
  }

   /**
   * The accrued interest amount which has not yet been paid by Citibank
   * @return interestAmountDue
  **/
  @Schema(example = "100.25", description = "The accrued interest amount which has not yet been paid by Citibank")
  public Double getInterestAmountDue() {
    return interestAmountDue;
  }

  public void setInterestAmountDue(Double interestAmountDue) {
    this.interestAmountDue = interestAmountDue;
  }

  public TimeDepositAccount renewalInstructions(String renewalInstructions) {
    this.renewalInstructions = renewalInstructions;
    return this;
  }

   /**
   * The instructions for time deposit renewal. This is a reference data field. Please use /v1/apac/utilities/referenceData/{renewalInstructions} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
   * @return renewalInstructions
  **/
  @Schema(example = "RENEW_PRINCIPAL_ONLY", description = "The instructions for time deposit renewal. This is a reference data field. Please use /v1/apac/utilities/referenceData/{renewalInstructions} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.")
  public String getRenewalInstructions() {
    return renewalInstructions;
  }

  public void setRenewalInstructions(String renewalInstructions) {
    this.renewalInstructions = renewalInstructions;
  }

  public TimeDepositAccount tenorTerm(Integer tenorTerm) {
    this.tenorTerm = tenorTerm;
    return this;
  }

   /**
   * The tenor term for the deposit, expressed as a whole number
   * @return tenorTerm
  **/
  @Schema(example = "12", description = "The tenor term for the deposit, expressed as a whole number")
  public Integer getTenorTerm() {
    return tenorTerm;
  }

  public void setTenorTerm(Integer tenorTerm) {
    this.tenorTerm = tenorTerm;
  }

  public TimeDepositAccount tenorPeriod(String tenorPeriod) {
    this.tenorPeriod = tenorPeriod;
    return this;
  }

   /**
   * The unit of the tenor term. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
   * @return tenorPeriod
  **/
  @Schema(example = "MONTHS", description = "The unit of the tenor term. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.")
  public String getTenorPeriod() {
    return tenorPeriod;
  }

  public void setTenorPeriod(String tenorPeriod) {
    this.tenorPeriod = tenorPeriod;
  }

  public TimeDepositAccount baseCurrencyMaturityAmount(Double baseCurrencyMaturityAmount) {
    this.baseCurrencyMaturityAmount = baseCurrencyMaturityAmount;
    return this;
  }

   /**
   * The investment amount and accrued interest in base currency
   * @return baseCurrencyMaturityAmount
  **/
  @Schema(example = "145071.25", description = "The investment amount and accrued interest in base currency")
  public Double getBaseCurrencyMaturityAmount() {
    return baseCurrencyMaturityAmount;
  }

  public void setBaseCurrencyMaturityAmount(Double baseCurrencyMaturityAmount) {
    this.baseCurrencyMaturityAmount = baseCurrencyMaturityAmount;
  }

  public TimeDepositAccount maturityInterestAmount(Double maturityInterestAmount) {
    this.maturityInterestAmount = maturityInterestAmount;
    return this;
  }

   /**
   * The accrued interest in base currency.
   * @return maturityInterestAmount
  **/
  @Schema(example = "5071.25", description = "The accrued interest in base currency.")
  public Double getMaturityInterestAmount() {
    return maturityInterestAmount;
  }

  public void setMaturityInterestAmount(Double maturityInterestAmount) {
    this.maturityInterestAmount = maturityInterestAmount;
  }

  public TimeDepositAccount lastInterestPaymentAmount(Double lastInterestPaymentAmount) {
    this.lastInterestPaymentAmount = lastInterestPaymentAmount;
    return this;
  }

   /**
   * Last interest amount for the time deposit account
   * @return lastInterestPaymentAmount
  **/
  @Schema(example = "107.25", description = "Last interest amount for the time deposit account")
  public Double getLastInterestPaymentAmount() {
    return lastInterestPaymentAmount;
  }

  public void setLastInterestPaymentAmount(Double lastInterestPaymentAmount) {
    this.lastInterestPaymentAmount = lastInterestPaymentAmount;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    TimeDepositAccount timeDepositAccount = (TimeDepositAccount) o;
    return Objects.equals(this.productName, timeDepositAccount.productName) &&
        Objects.equals(this.productCode, timeDepositAccount.productCode) &&
        Objects.equals(this.displayAccountNumber, timeDepositAccount.displayAccountNumber) &&
        Objects.equals(this.originalPrincipalAmount, timeDepositAccount.originalPrincipalAmount) &&
        Objects.equals(this.currencyCode, timeDepositAccount.currencyCode) &&
        Objects.equals(this.interestRate, timeDepositAccount.interestRate) &&
        Objects.equals(this.openingDate, timeDepositAccount.openingDate) &&
        Objects.equals(this.maturityDate, timeDepositAccount.maturityDate) &&
        Objects.equals(this.nextInterestPaymentDate, timeDepositAccount.nextInterestPaymentDate) &&
        Objects.equals(this.interestAmountDue, timeDepositAccount.interestAmountDue) &&
        Objects.equals(this.renewalInstructions, timeDepositAccount.renewalInstructions) &&
        Objects.equals(this.tenorTerm, timeDepositAccount.tenorTerm) &&
        Objects.equals(this.tenorPeriod, timeDepositAccount.tenorPeriod) &&
        Objects.equals(this.baseCurrencyMaturityAmount, timeDepositAccount.baseCurrencyMaturityAmount) &&
        Objects.equals(this.maturityInterestAmount, timeDepositAccount.maturityInterestAmount) &&
        Objects.equals(this.lastInterestPaymentAmount, timeDepositAccount.lastInterestPaymentAmount);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productName, productCode, displayAccountNumber, originalPrincipalAmount, currencyCode, interestRate, openingDate, maturityDate, nextInterestPaymentDate, interestAmountDue, renewalInstructions, tenorTerm, tenorPeriod, baseCurrencyMaturityAmount, maturityInterestAmount, lastInterestPaymentAmount);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TimeDepositAccount {\n");
    
    sb.append("    productName: ").append(toIndentedString(productName)).append("\n");
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    originalPrincipalAmount: ").append(toIndentedString(originalPrincipalAmount)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
    sb.append("    interestRate: ").append(toIndentedString(interestRate)).append("\n");
    sb.append("    openingDate: ").append(toIndentedString(openingDate)).append("\n");
    sb.append("    maturityDate: ").append(toIndentedString(maturityDate)).append("\n");
    sb.append("    nextInterestPaymentDate: ").append(toIndentedString(nextInterestPaymentDate)).append("\n");
    sb.append("    interestAmountDue: ").append(toIndentedString(interestAmountDue)).append("\n");
    sb.append("    renewalInstructions: ").append(toIndentedString(renewalInstructions)).append("\n");
    sb.append("    tenorTerm: ").append(toIndentedString(tenorTerm)).append("\n");
    sb.append("    tenorPeriod: ").append(toIndentedString(tenorPeriod)).append("\n");
    sb.append("    baseCurrencyMaturityAmount: ").append(toIndentedString(baseCurrencyMaturityAmount)).append("\n");
    sb.append("    maturityInterestAmount: ").append(toIndentedString(maturityInterestAmount)).append("\n");
    sb.append("    lastInterestPaymentAmount: ").append(toIndentedString(lastInterestPaymentAmount)).append("\n");
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
