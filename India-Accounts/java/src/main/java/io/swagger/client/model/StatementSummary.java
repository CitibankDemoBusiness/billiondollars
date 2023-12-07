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
import io.swagger.client.model.PrivateLabelCreditCards;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.LocalDate;
/**
 * StatementSummary
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class StatementSummary {
  @SerializedName("outstandingBalance")
  private Double outstandingBalance = null;

  @SerializedName("creditLimit")
  private Double creditLimit = null;

  @SerializedName("activeEqualPaymentPlanCount")
  private Double activeEqualPaymentPlanCount = null;

  @SerializedName("beginningBalanceAmount")
  private Double beginningBalanceAmount = null;

  @SerializedName("totalDebitAmount")
  private Double totalDebitAmount = null;

  @SerializedName("totalCreditAmount")
  private Double totalCreditAmount = null;

  @SerializedName("netInterestAmount")
  private Double netInterestAmount = null;

  @SerializedName("paymentDueDate")
  private LocalDate paymentDueDate = null;

  @SerializedName("pastDueAmount")
  private Double pastDueAmount = null;

  @SerializedName("cashAdvanceLimit")
  private Double cashAdvanceLimit = null;

  @SerializedName("cycleToDateFeeAmount")
  private Double cycleToDateFeeAmount = null;

  @SerializedName("interestPaidAmount")
  private Double interestPaidAmount = null;

  @SerializedName("billingCurrencyCode")
  private String billingCurrencyCode = null;

  @SerializedName("cashAdvanceAvailableAmount")
  private Double cashAdvanceAvailableAmount = null;

  @SerializedName("retailCycleInterestRate")
  private Double retailCycleInterestRate = null;

  @SerializedName("cashCycleInterestRate")
  private Double cashCycleInterestRate = null;

  @SerializedName("privateLabelCreditCards")
  private PrivateLabelCreditCards privateLabelCreditCards = null;

  public StatementSummary outstandingBalance(Double outstandingBalance) {
    this.outstandingBalance = outstandingBalance;
    return this;
  }

   /**
   * Outstanding balance amount on the statement date
   * @return outstandingBalance
  **/
  @Schema(example = "10000.25", description = "Outstanding balance amount on the statement date")
  public Double getOutstandingBalance() {
    return outstandingBalance;
  }

  public void setOutstandingBalance(Double outstandingBalance) {
    this.outstandingBalance = outstandingBalance;
  }

  public StatementSummary creditLimit(Double creditLimit) {
    this.creditLimit = creditLimit;
    return this;
  }

   /**
   * The maximum amount of credit that extend to a customer
   * @return creditLimit
  **/
  @Schema(example = "12000.25", description = "The maximum amount of credit that extend to a customer")
  public Double getCreditLimit() {
    return creditLimit;
  }

  public void setCreditLimit(Double creditLimit) {
    this.creditLimit = creditLimit;
  }

  public StatementSummary activeEqualPaymentPlanCount(Double activeEqualPaymentPlanCount) {
    this.activeEqualPaymentPlanCount = activeEqualPaymentPlanCount;
    return this;
  }

   /**
   * Number of active plans under equal payment plan
   * @return activeEqualPaymentPlanCount
  **/
  @Schema(example = "5.25", description = "Number of active plans under equal payment plan")
  public Double getActiveEqualPaymentPlanCount() {
    return activeEqualPaymentPlanCount;
  }

  public void setActiveEqualPaymentPlanCount(Double activeEqualPaymentPlanCount) {
    this.activeEqualPaymentPlanCount = activeEqualPaymentPlanCount;
  }

  public StatementSummary beginningBalanceAmount(Double beginningBalanceAmount) {
    this.beginningBalanceAmount = beginningBalanceAmount;
    return this;
  }

   /**
   * Balance as on Last Statement Date
   * @return beginningBalanceAmount
  **/
  @Schema(example = "5000.25", description = "Balance as on Last Statement Date")
  public Double getBeginningBalanceAmount() {
    return beginningBalanceAmount;
  }

  public void setBeginningBalanceAmount(Double beginningBalanceAmount) {
    this.beginningBalanceAmount = beginningBalanceAmount;
  }

  public StatementSummary totalDebitAmount(Double totalDebitAmount) {
    this.totalDebitAmount = totalDebitAmount;
    return this;
  }

   /**
   * Total debits made during the statement period
   * @return totalDebitAmount
  **/
  @Schema(example = "4000.25", description = "Total debits made during the statement period")
  public Double getTotalDebitAmount() {
    return totalDebitAmount;
  }

  public void setTotalDebitAmount(Double totalDebitAmount) {
    this.totalDebitAmount = totalDebitAmount;
  }

  public StatementSummary totalCreditAmount(Double totalCreditAmount) {
    this.totalCreditAmount = totalCreditAmount;
    return this;
  }

   /**
   * Total payments made during the statement period.
   * @return totalCreditAmount
  **/
  @Schema(example = "2000.25", description = "Total payments made during the statement period.")
  public Double getTotalCreditAmount() {
    return totalCreditAmount;
  }

  public void setTotalCreditAmount(Double totalCreditAmount) {
    this.totalCreditAmount = totalCreditAmount;
  }

  public StatementSummary netInterestAmount(Double netInterestAmount) {
    this.netInterestAmount = netInterestAmount;
    return this;
  }

   /**
   * Total interest amount of monetary transactions posted to cardholder account
   * @return netInterestAmount
  **/
  @Schema(example = "500.25", description = "Total interest amount of monetary transactions posted to cardholder account")
  public Double getNetInterestAmount() {
    return netInterestAmount;
  }

  public void setNetInterestAmount(Double netInterestAmount) {
    this.netInterestAmount = netInterestAmount;
  }

  public StatementSummary paymentDueDate(LocalDate paymentDueDate) {
    this.paymentDueDate = paymentDueDate;
    return this;
  }

   /**
   * Next payment due date in ISO 8601 date format YYYY-MM-DD
   * @return paymentDueDate
  **/
  @Schema(example = "Mon Dec 05 00:00:00 UTC 2016", description = "Next payment due date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getPaymentDueDate() {
    return paymentDueDate;
  }

  public void setPaymentDueDate(LocalDate paymentDueDate) {
    this.paymentDueDate = paymentDueDate;
  }

  public StatementSummary pastDueAmount(Double pastDueAmount) {
    this.pastDueAmount = pastDueAmount;
    return this;
  }

   /**
   * Past due amount to be paid
   * @return pastDueAmount
  **/
  @Schema(example = "2000.25", description = "Past due amount to be paid")
  public Double getPastDueAmount() {
    return pastDueAmount;
  }

  public void setPastDueAmount(Double pastDueAmount) {
    this.pastDueAmount = pastDueAmount;
  }

  public StatementSummary cashAdvanceLimit(Double cashAdvanceLimit) {
    this.cashAdvanceLimit = cashAdvanceLimit;
    return this;
  }

   /**
   * Some percentage of credit limit to withdraw cash
   * @return cashAdvanceLimit
  **/
  @Schema(example = "5000.25", description = "Some percentage of credit limit to withdraw cash")
  public Double getCashAdvanceLimit() {
    return cashAdvanceLimit;
  }

  public void setCashAdvanceLimit(Double cashAdvanceLimit) {
    this.cashAdvanceLimit = cashAdvanceLimit;
  }

  public StatementSummary cycleToDateFeeAmount(Double cycleToDateFeeAmount) {
    this.cycleToDateFeeAmount = cycleToDateFeeAmount;
    return this;
  }

   /**
   * The total fee applied in the cycle
   * @return cycleToDateFeeAmount
  **/
  @Schema(example = "400.25", description = "The total fee applied in the cycle")
  public Double getCycleToDateFeeAmount() {
    return cycleToDateFeeAmount;
  }

  public void setCycleToDateFeeAmount(Double cycleToDateFeeAmount) {
    this.cycleToDateFeeAmount = cycleToDateFeeAmount;
  }

  public StatementSummary interestPaidAmount(Double interestPaidAmount) {
    this.interestPaidAmount = interestPaidAmount;
    return this;
  }

   /**
   * Interest amount paid on the credit card from the last billing cycle.
   * @return interestPaidAmount
  **/
  @Schema(example = "350.25", description = "Interest amount paid on the credit card from the last billing cycle.")
  public Double getInterestPaidAmount() {
    return interestPaidAmount;
  }

  public void setInterestPaidAmount(Double interestPaidAmount) {
    this.interestPaidAmount = interestPaidAmount;
  }

  public StatementSummary billingCurrencyCode(String billingCurrencyCode) {
    this.billingCurrencyCode = billingCurrencyCode;
    return this;
  }

   /**
   * Billing currency code in  in ISO 4217 format
   * @return billingCurrencyCode
  **/
  @Schema(example = "SGD", description = "Billing currency code in  in ISO 4217 format")
  public String getBillingCurrencyCode() {
    return billingCurrencyCode;
  }

  public void setBillingCurrencyCode(String billingCurrencyCode) {
    this.billingCurrencyCode = billingCurrencyCode;
  }

  public StatementSummary cashAdvanceAvailableAmount(Double cashAdvanceAvailableAmount) {
    this.cashAdvanceAvailableAmount = cashAdvanceAvailableAmount;
    return this;
  }

   /**
   * Available Cash Amount for withdrawal
   * @return cashAdvanceAvailableAmount
  **/
  @Schema(example = "2500.25", description = "Available Cash Amount for withdrawal")
  public Double getCashAdvanceAvailableAmount() {
    return cashAdvanceAvailableAmount;
  }

  public void setCashAdvanceAvailableAmount(Double cashAdvanceAvailableAmount) {
    this.cashAdvanceAvailableAmount = cashAdvanceAvailableAmount;
  }

  public StatementSummary retailCycleInterestRate(Double retailCycleInterestRate) {
    this.retailCycleInterestRate = retailCycleInterestRate;
    return this;
  }

   /**
   * Retail Interest Rate for merchant transactions.
   * @return retailCycleInterestRate
  **/
  @Schema(example = "8.12", description = "Retail Interest Rate for merchant transactions.")
  public Double getRetailCycleInterestRate() {
    return retailCycleInterestRate;
  }

  public void setRetailCycleInterestRate(Double retailCycleInterestRate) {
    this.retailCycleInterestRate = retailCycleInterestRate;
  }

  public StatementSummary cashCycleInterestRate(Double cashCycleInterestRate) {
    this.cashCycleInterestRate = cashCycleInterestRate;
    return this;
  }

   /**
   * Cash Interest Rate for withdrawal
   * @return cashCycleInterestRate
  **/
  @Schema(example = "9.25", description = "Cash Interest Rate for withdrawal")
  public Double getCashCycleInterestRate() {
    return cashCycleInterestRate;
  }

  public void setCashCycleInterestRate(Double cashCycleInterestRate) {
    this.cashCycleInterestRate = cashCycleInterestRate;
  }

  public StatementSummary privateLabelCreditCards(PrivateLabelCreditCards privateLabelCreditCards) {
    this.privateLabelCreditCards = privateLabelCreditCards;
    return this;
  }

   /**
   * Get privateLabelCreditCards
   * @return privateLabelCreditCards
  **/
  @Schema(description = "")
  public PrivateLabelCreditCards getPrivateLabelCreditCards() {
    return privateLabelCreditCards;
  }

  public void setPrivateLabelCreditCards(PrivateLabelCreditCards privateLabelCreditCards) {
    this.privateLabelCreditCards = privateLabelCreditCards;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StatementSummary statementSummary = (StatementSummary) o;
    return Objects.equals(this.outstandingBalance, statementSummary.outstandingBalance) &&
        Objects.equals(this.creditLimit, statementSummary.creditLimit) &&
        Objects.equals(this.activeEqualPaymentPlanCount, statementSummary.activeEqualPaymentPlanCount) &&
        Objects.equals(this.beginningBalanceAmount, statementSummary.beginningBalanceAmount) &&
        Objects.equals(this.totalDebitAmount, statementSummary.totalDebitAmount) &&
        Objects.equals(this.totalCreditAmount, statementSummary.totalCreditAmount) &&
        Objects.equals(this.netInterestAmount, statementSummary.netInterestAmount) &&
        Objects.equals(this.paymentDueDate, statementSummary.paymentDueDate) &&
        Objects.equals(this.pastDueAmount, statementSummary.pastDueAmount) &&
        Objects.equals(this.cashAdvanceLimit, statementSummary.cashAdvanceLimit) &&
        Objects.equals(this.cycleToDateFeeAmount, statementSummary.cycleToDateFeeAmount) &&
        Objects.equals(this.interestPaidAmount, statementSummary.interestPaidAmount) &&
        Objects.equals(this.billingCurrencyCode, statementSummary.billingCurrencyCode) &&
        Objects.equals(this.cashAdvanceAvailableAmount, statementSummary.cashAdvanceAvailableAmount) &&
        Objects.equals(this.retailCycleInterestRate, statementSummary.retailCycleInterestRate) &&
        Objects.equals(this.cashCycleInterestRate, statementSummary.cashCycleInterestRate) &&
        Objects.equals(this.privateLabelCreditCards, statementSummary.privateLabelCreditCards);
  }

  @Override
  public int hashCode() {
    return Objects.hash(outstandingBalance, creditLimit, activeEqualPaymentPlanCount, beginningBalanceAmount, totalDebitAmount, totalCreditAmount, netInterestAmount, paymentDueDate, pastDueAmount, cashAdvanceLimit, cycleToDateFeeAmount, interestPaidAmount, billingCurrencyCode, cashAdvanceAvailableAmount, retailCycleInterestRate, cashCycleInterestRate, privateLabelCreditCards);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StatementSummary {\n");
    
    sb.append("    outstandingBalance: ").append(toIndentedString(outstandingBalance)).append("\n");
    sb.append("    creditLimit: ").append(toIndentedString(creditLimit)).append("\n");
    sb.append("    activeEqualPaymentPlanCount: ").append(toIndentedString(activeEqualPaymentPlanCount)).append("\n");
    sb.append("    beginningBalanceAmount: ").append(toIndentedString(beginningBalanceAmount)).append("\n");
    sb.append("    totalDebitAmount: ").append(toIndentedString(totalDebitAmount)).append("\n");
    sb.append("    totalCreditAmount: ").append(toIndentedString(totalCreditAmount)).append("\n");
    sb.append("    netInterestAmount: ").append(toIndentedString(netInterestAmount)).append("\n");
    sb.append("    paymentDueDate: ").append(toIndentedString(paymentDueDate)).append("\n");
    sb.append("    pastDueAmount: ").append(toIndentedString(pastDueAmount)).append("\n");
    sb.append("    cashAdvanceLimit: ").append(toIndentedString(cashAdvanceLimit)).append("\n");
    sb.append("    cycleToDateFeeAmount: ").append(toIndentedString(cycleToDateFeeAmount)).append("\n");
    sb.append("    interestPaidAmount: ").append(toIndentedString(interestPaidAmount)).append("\n");
    sb.append("    billingCurrencyCode: ").append(toIndentedString(billingCurrencyCode)).append("\n");
    sb.append("    cashAdvanceAvailableAmount: ").append(toIndentedString(cashAdvanceAvailableAmount)).append("\n");
    sb.append("    retailCycleInterestRate: ").append(toIndentedString(retailCycleInterestRate)).append("\n");
    sb.append("    cashCycleInterestRate: ").append(toIndentedString(cashCycleInterestRate)).append("\n");
    sb.append("    privateLabelCreditCards: ").append(toIndentedString(privateLabelCreditCards)).append("\n");
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
