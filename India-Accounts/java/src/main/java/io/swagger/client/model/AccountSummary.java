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
import io.swagger.client.model.CallDepositAccountSummary;
import io.swagger.client.model.CheckingAccountSummary;
import io.swagger.client.model.CreditCardAccountSummary;
import io.swagger.client.model.LoanAccountSummary;
import io.swagger.client.model.MutualFundAccountSummary;
import io.swagger.client.model.PremiumDepositAccountSummary;
import io.swagger.client.model.ReadyCreditAccountSummary;
import io.swagger.client.model.SavingsAccountSummary;
import io.swagger.client.model.SecuritiesBrokerageAccountSummary;
import io.swagger.client.model.TimeDepositAccountSummary;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * AccountSummary
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class AccountSummary {
  @SerializedName("checkingAccountSummary")
  private CheckingAccountSummary checkingAccountSummary = null;

  @SerializedName("savingsAccountSummary")
  private SavingsAccountSummary savingsAccountSummary = null;

  @SerializedName("creditCardAccountSummary")
  private CreditCardAccountSummary creditCardAccountSummary = null;

  @SerializedName("readyCreditAccountSummary")
  private ReadyCreditAccountSummary readyCreditAccountSummary = null;

  @SerializedName("loanAccountSummary")
  private LoanAccountSummary loanAccountSummary = null;

  @SerializedName("mutualFundAccountSummary")
  private MutualFundAccountSummary mutualFundAccountSummary = null;

  @SerializedName("securitiesBrokerageAccountSummary")
  private SecuritiesBrokerageAccountSummary securitiesBrokerageAccountSummary = null;

  @SerializedName("callDepositAccountSummary")
  private CallDepositAccountSummary callDepositAccountSummary = null;

  @SerializedName("premiumDepositAccountSummary")
  private PremiumDepositAccountSummary premiumDepositAccountSummary = null;

  @SerializedName("timeDepositAccountSummary")
  private TimeDepositAccountSummary timeDepositAccountSummary = null;

  public AccountSummary checkingAccountSummary(CheckingAccountSummary checkingAccountSummary) {
    this.checkingAccountSummary = checkingAccountSummary;
    return this;
  }

   /**
   * Get checkingAccountSummary
   * @return checkingAccountSummary
  **/
  @Schema(description = "")
  public CheckingAccountSummary getCheckingAccountSummary() {
    return checkingAccountSummary;
  }

  public void setCheckingAccountSummary(CheckingAccountSummary checkingAccountSummary) {
    this.checkingAccountSummary = checkingAccountSummary;
  }

  public AccountSummary savingsAccountSummary(SavingsAccountSummary savingsAccountSummary) {
    this.savingsAccountSummary = savingsAccountSummary;
    return this;
  }

   /**
   * Get savingsAccountSummary
   * @return savingsAccountSummary
  **/
  @Schema(description = "")
  public SavingsAccountSummary getSavingsAccountSummary() {
    return savingsAccountSummary;
  }

  public void setSavingsAccountSummary(SavingsAccountSummary savingsAccountSummary) {
    this.savingsAccountSummary = savingsAccountSummary;
  }

  public AccountSummary creditCardAccountSummary(CreditCardAccountSummary creditCardAccountSummary) {
    this.creditCardAccountSummary = creditCardAccountSummary;
    return this;
  }

   /**
   * Get creditCardAccountSummary
   * @return creditCardAccountSummary
  **/
  @Schema(description = "")
  public CreditCardAccountSummary getCreditCardAccountSummary() {
    return creditCardAccountSummary;
  }

  public void setCreditCardAccountSummary(CreditCardAccountSummary creditCardAccountSummary) {
    this.creditCardAccountSummary = creditCardAccountSummary;
  }

  public AccountSummary readyCreditAccountSummary(ReadyCreditAccountSummary readyCreditAccountSummary) {
    this.readyCreditAccountSummary = readyCreditAccountSummary;
    return this;
  }

   /**
   * Get readyCreditAccountSummary
   * @return readyCreditAccountSummary
  **/
  @Schema(description = "")
  public ReadyCreditAccountSummary getReadyCreditAccountSummary() {
    return readyCreditAccountSummary;
  }

  public void setReadyCreditAccountSummary(ReadyCreditAccountSummary readyCreditAccountSummary) {
    this.readyCreditAccountSummary = readyCreditAccountSummary;
  }

  public AccountSummary loanAccountSummary(LoanAccountSummary loanAccountSummary) {
    this.loanAccountSummary = loanAccountSummary;
    return this;
  }

   /**
   * Get loanAccountSummary
   * @return loanAccountSummary
  **/
  @Schema(description = "")
  public LoanAccountSummary getLoanAccountSummary() {
    return loanAccountSummary;
  }

  public void setLoanAccountSummary(LoanAccountSummary loanAccountSummary) {
    this.loanAccountSummary = loanAccountSummary;
  }

  public AccountSummary mutualFundAccountSummary(MutualFundAccountSummary mutualFundAccountSummary) {
    this.mutualFundAccountSummary = mutualFundAccountSummary;
    return this;
  }

   /**
   * Get mutualFundAccountSummary
   * @return mutualFundAccountSummary
  **/
  @Schema(description = "")
  public MutualFundAccountSummary getMutualFundAccountSummary() {
    return mutualFundAccountSummary;
  }

  public void setMutualFundAccountSummary(MutualFundAccountSummary mutualFundAccountSummary) {
    this.mutualFundAccountSummary = mutualFundAccountSummary;
  }

  public AccountSummary securitiesBrokerageAccountSummary(SecuritiesBrokerageAccountSummary securitiesBrokerageAccountSummary) {
    this.securitiesBrokerageAccountSummary = securitiesBrokerageAccountSummary;
    return this;
  }

   /**
   * Get securitiesBrokerageAccountSummary
   * @return securitiesBrokerageAccountSummary
  **/
  @Schema(description = "")
  public SecuritiesBrokerageAccountSummary getSecuritiesBrokerageAccountSummary() {
    return securitiesBrokerageAccountSummary;
  }

  public void setSecuritiesBrokerageAccountSummary(SecuritiesBrokerageAccountSummary securitiesBrokerageAccountSummary) {
    this.securitiesBrokerageAccountSummary = securitiesBrokerageAccountSummary;
  }

  public AccountSummary callDepositAccountSummary(CallDepositAccountSummary callDepositAccountSummary) {
    this.callDepositAccountSummary = callDepositAccountSummary;
    return this;
  }

   /**
   * Get callDepositAccountSummary
   * @return callDepositAccountSummary
  **/
  @Schema(description = "")
  public CallDepositAccountSummary getCallDepositAccountSummary() {
    return callDepositAccountSummary;
  }

  public void setCallDepositAccountSummary(CallDepositAccountSummary callDepositAccountSummary) {
    this.callDepositAccountSummary = callDepositAccountSummary;
  }

  public AccountSummary premiumDepositAccountSummary(PremiumDepositAccountSummary premiumDepositAccountSummary) {
    this.premiumDepositAccountSummary = premiumDepositAccountSummary;
    return this;
  }

   /**
   * Get premiumDepositAccountSummary
   * @return premiumDepositAccountSummary
  **/
  @Schema(description = "")
  public PremiumDepositAccountSummary getPremiumDepositAccountSummary() {
    return premiumDepositAccountSummary;
  }

  public void setPremiumDepositAccountSummary(PremiumDepositAccountSummary premiumDepositAccountSummary) {
    this.premiumDepositAccountSummary = premiumDepositAccountSummary;
  }

  public AccountSummary timeDepositAccountSummary(TimeDepositAccountSummary timeDepositAccountSummary) {
    this.timeDepositAccountSummary = timeDepositAccountSummary;
    return this;
  }

   /**
   * Get timeDepositAccountSummary
   * @return timeDepositAccountSummary
  **/
  @Schema(description = "")
  public TimeDepositAccountSummary getTimeDepositAccountSummary() {
    return timeDepositAccountSummary;
  }

  public void setTimeDepositAccountSummary(TimeDepositAccountSummary timeDepositAccountSummary) {
    this.timeDepositAccountSummary = timeDepositAccountSummary;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AccountSummary accountSummary = (AccountSummary) o;
    return Objects.equals(this.checkingAccountSummary, accountSummary.checkingAccountSummary) &&
        Objects.equals(this.savingsAccountSummary, accountSummary.savingsAccountSummary) &&
        Objects.equals(this.creditCardAccountSummary, accountSummary.creditCardAccountSummary) &&
        Objects.equals(this.readyCreditAccountSummary, accountSummary.readyCreditAccountSummary) &&
        Objects.equals(this.loanAccountSummary, accountSummary.loanAccountSummary) &&
        Objects.equals(this.mutualFundAccountSummary, accountSummary.mutualFundAccountSummary) &&
        Objects.equals(this.securitiesBrokerageAccountSummary, accountSummary.securitiesBrokerageAccountSummary) &&
        Objects.equals(this.callDepositAccountSummary, accountSummary.callDepositAccountSummary) &&
        Objects.equals(this.premiumDepositAccountSummary, accountSummary.premiumDepositAccountSummary) &&
        Objects.equals(this.timeDepositAccountSummary, accountSummary.timeDepositAccountSummary);
  }

  @Override
  public int hashCode() {
    return Objects.hash(checkingAccountSummary, savingsAccountSummary, creditCardAccountSummary, readyCreditAccountSummary, loanAccountSummary, mutualFundAccountSummary, securitiesBrokerageAccountSummary, callDepositAccountSummary, premiumDepositAccountSummary, timeDepositAccountSummary);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AccountSummary {\n");
    
    sb.append("    checkingAccountSummary: ").append(toIndentedString(checkingAccountSummary)).append("\n");
    sb.append("    savingsAccountSummary: ").append(toIndentedString(savingsAccountSummary)).append("\n");
    sb.append("    creditCardAccountSummary: ").append(toIndentedString(creditCardAccountSummary)).append("\n");
    sb.append("    readyCreditAccountSummary: ").append(toIndentedString(readyCreditAccountSummary)).append("\n");
    sb.append("    loanAccountSummary: ").append(toIndentedString(loanAccountSummary)).append("\n");
    sb.append("    mutualFundAccountSummary: ").append(toIndentedString(mutualFundAccountSummary)).append("\n");
    sb.append("    securitiesBrokerageAccountSummary: ").append(toIndentedString(securitiesBrokerageAccountSummary)).append("\n");
    sb.append("    callDepositAccountSummary: ").append(toIndentedString(callDepositAccountSummary)).append("\n");
    sb.append("    premiumDepositAccountSummary: ").append(toIndentedString(premiumDepositAccountSummary)).append("\n");
    sb.append("    timeDepositAccountSummary: ").append(toIndentedString(timeDepositAccountSummary)).append("\n");
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
