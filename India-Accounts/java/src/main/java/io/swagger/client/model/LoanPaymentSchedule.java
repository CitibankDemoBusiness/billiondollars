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
 * LoanPaymentSchedule
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class LoanPaymentSchedule {
  @SerializedName("installmentNumber")
  private Integer installmentNumber = null;

  @SerializedName("principalAmount")
  private Double principalAmount = null;

  @SerializedName("installmentInterestAmount")
  private Double installmentInterestAmount = null;

  @SerializedName("installmentAmount")
  private Double installmentAmount = null;

  @SerializedName("installmentDate")
  private LocalDate installmentDate = null;

  public LoanPaymentSchedule installmentNumber(Integer installmentNumber) {
    this.installmentNumber = installmentNumber;
    return this;
  }

   /**
   * The installment number of the total number of installments
   * @return installmentNumber
  **/
  @Schema(example = "2", description = "The installment number of the total number of installments")
  public Integer getInstallmentNumber() {
    return installmentNumber;
  }

  public void setInstallmentNumber(Integer installmentNumber) {
    this.installmentNumber = installmentNumber;
  }

  public LoanPaymentSchedule principalAmount(Double principalAmount) {
    this.principalAmount = principalAmount;
    return this;
  }

   /**
   * The portion of the principal amount paid for the loan.
   * @return principalAmount
  **/
  @Schema(example = "8333.33", description = "The portion of the principal amount paid for the loan.")
  public Double getPrincipalAmount() {
    return principalAmount;
  }

  public void setPrincipalAmount(Double principalAmount) {
    this.principalAmount = principalAmount;
  }

  public LoanPaymentSchedule installmentInterestAmount(Double installmentInterestAmount) {
    this.installmentInterestAmount = installmentInterestAmount;
    return this;
  }

   /**
   * The interest amount to be paid as installment
   * @return installmentInterestAmount
  **/
  @Schema(example = "47.25", description = "The interest amount to be paid as installment")
  public Double getInstallmentInterestAmount() {
    return installmentInterestAmount;
  }

  public void setInstallmentInterestAmount(Double installmentInterestAmount) {
    this.installmentInterestAmount = installmentInterestAmount;
  }

  public LoanPaymentSchedule installmentAmount(Double installmentAmount) {
    this.installmentAmount = installmentAmount;
    return this;
  }

   /**
   * Installment amount to be payed by customer in order to repay the loan.
   * @return installmentAmount
  **/
  @Schema(example = "8380.58", description = "Installment amount to be payed by customer in order to repay the loan.")
  public Double getInstallmentAmount() {
    return installmentAmount;
  }

  public void setInstallmentAmount(Double installmentAmount) {
    this.installmentAmount = installmentAmount;
  }

  public LoanPaymentSchedule installmentDate(LocalDate installmentDate) {
    this.installmentDate = installmentDate;
    return this;
  }

   /**
   * Date of installment in ISO 8601 date format YYYY-MM-DD
   * @return installmentDate
  **/
  @Schema(description = "Date of installment in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getInstallmentDate() {
    return installmentDate;
  }

  public void setInstallmentDate(LocalDate installmentDate) {
    this.installmentDate = installmentDate;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LoanPaymentSchedule loanPaymentSchedule = (LoanPaymentSchedule) o;
    return Objects.equals(this.installmentNumber, loanPaymentSchedule.installmentNumber) &&
        Objects.equals(this.principalAmount, loanPaymentSchedule.principalAmount) &&
        Objects.equals(this.installmentInterestAmount, loanPaymentSchedule.installmentInterestAmount) &&
        Objects.equals(this.installmentAmount, loanPaymentSchedule.installmentAmount) &&
        Objects.equals(this.installmentDate, loanPaymentSchedule.installmentDate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(installmentNumber, principalAmount, installmentInterestAmount, installmentAmount, installmentDate);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LoanPaymentSchedule {\n");
    
    sb.append("    installmentNumber: ").append(toIndentedString(installmentNumber)).append("\n");
    sb.append("    principalAmount: ").append(toIndentedString(principalAmount)).append("\n");
    sb.append("    installmentInterestAmount: ").append(toIndentedString(installmentInterestAmount)).append("\n");
    sb.append("    installmentAmount: ").append(toIndentedString(installmentAmount)).append("\n");
    sb.append("    installmentDate: ").append(toIndentedString(installmentDate)).append("\n");
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