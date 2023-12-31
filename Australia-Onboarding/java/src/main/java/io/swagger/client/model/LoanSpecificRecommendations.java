/*
 * Onboarding
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
import io.swagger.client.model.RepaymentSchedule;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import org.threeten.bp.LocalDate;
/**
 * LoanSpecificRecommendations
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class LoanSpecificRecommendations {
  @SerializedName("loanAmount")
  private Double loanAmount = null;

  @SerializedName("tenor")
  private String tenor = null;

  @SerializedName("interestRate")
  private Double interestRate = null;

  @SerializedName("handlingFee")
  private Double handlingFee = null;

  @SerializedName("installmentAmount")
  private Double installmentAmount = null;

  @SerializedName("annualPercentageRate")
  private Double annualPercentageRate = null;

  @SerializedName("totalPrincipalAmount")
  private Double totalPrincipalAmount = null;

  @SerializedName("totalInterestAmount")
  private Double totalInterestAmount = null;

  @SerializedName("totalInstallmentAmount")
  private Double totalInstallmentAmount = null;

  @SerializedName("repaymentScheduleIssueDate")
  private LocalDate repaymentScheduleIssueDate = null;

  @SerializedName("repaymentSchedule")
  private List<RepaymentSchedule> repaymentSchedule = null;

  public LoanSpecificRecommendations loanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
    return this;
  }

   /**
   * Eligible Loan amount.
   * @return loanAmount
  **/
  @Schema(example = "25000.25", description = "Eligible Loan amount.")
  public Double getLoanAmount() {
    return loanAmount;
  }

  public void setLoanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
  }

  public LoanSpecificRecommendations tenor(String tenor) {
    this.tenor = tenor;
    return this;
  }

   /**
   * Tenor for the loan repayment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description.
   * @return tenor
  **/
  @Schema(example = "45", description = "Tenor for the loan repayment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description.")
  public String getTenor() {
    return tenor;
  }

  public void setTenor(String tenor) {
    this.tenor = tenor;
  }

  public LoanSpecificRecommendations interestRate(Double interestRate) {
    this.interestRate = interestRate;
    return this;
  }

   /**
   * The rate of interest applicable to product
   * @return interestRate
  **/
  @Schema(example = "5.25", description = "The rate of interest applicable to product")
  public Double getInterestRate() {
    return interestRate;
  }

  public void setInterestRate(Double interestRate) {
    this.interestRate = interestRate;
  }

  public LoanSpecificRecommendations handlingFee(Double handlingFee) {
    this.handlingFee = handlingFee;
    return this;
  }

   /**
   * Handling fee to be paid.
   * @return handlingFee
  **/
  @Schema(example = "5.25", description = "Handling fee to be paid.")
  public Double getHandlingFee() {
    return handlingFee;
  }

  public void setHandlingFee(Double handlingFee) {
    this.handlingFee = handlingFee;
  }

  public LoanSpecificRecommendations installmentAmount(Double installmentAmount) {
    this.installmentAmount = installmentAmount;
    return this;
  }

   /**
   * Installment amount to be paid.
   * @return installmentAmount
  **/
  @Schema(example = "500.25", description = "Installment amount to be paid.")
  public Double getInstallmentAmount() {
    return installmentAmount;
  }

  public void setInstallmentAmount(Double installmentAmount) {
    this.installmentAmount = installmentAmount;
  }

  public LoanSpecificRecommendations annualPercentageRate(Double annualPercentageRate) {
    this.annualPercentageRate = annualPercentageRate;
    return this;
  }

   /**
   * Applicable Annual Percentage Rate
   * @return annualPercentageRate
  **/
  @Schema(example = "5.25", description = "Applicable Annual Percentage Rate")
  public Double getAnnualPercentageRate() {
    return annualPercentageRate;
  }

  public void setAnnualPercentageRate(Double annualPercentageRate) {
    this.annualPercentageRate = annualPercentageRate;
  }

  public LoanSpecificRecommendations totalPrincipalAmount(Double totalPrincipalAmount) {
    this.totalPrincipalAmount = totalPrincipalAmount;
    return this;
  }

   /**
   * Total principal to be paid by customer
   * @return totalPrincipalAmount
  **/
  @Schema(example = "5000.25", description = "Total principal to be paid by customer")
  public Double getTotalPrincipalAmount() {
    return totalPrincipalAmount;
  }

  public void setTotalPrincipalAmount(Double totalPrincipalAmount) {
    this.totalPrincipalAmount = totalPrincipalAmount;
  }

  public LoanSpecificRecommendations totalInterestAmount(Double totalInterestAmount) {
    this.totalInterestAmount = totalInterestAmount;
    return this;
  }

   /**
   * Total interest to be paid by customer
   * @return totalInterestAmount
  **/
  @Schema(example = "500.25", description = "Total interest to be paid by customer")
  public Double getTotalInterestAmount() {
    return totalInterestAmount;
  }

  public void setTotalInterestAmount(Double totalInterestAmount) {
    this.totalInterestAmount = totalInterestAmount;
  }

  public LoanSpecificRecommendations totalInstallmentAmount(Double totalInstallmentAmount) {
    this.totalInstallmentAmount = totalInstallmentAmount;
    return this;
  }

   /**
   * Total installment amount to be paid by customer
   * @return totalInstallmentAmount
  **/
  @Schema(example = "500.25", description = "Total installment amount to be paid by customer")
  public Double getTotalInstallmentAmount() {
    return totalInstallmentAmount;
  }

  public void setTotalInstallmentAmount(Double totalInstallmentAmount) {
    this.totalInstallmentAmount = totalInstallmentAmount;
  }

  public LoanSpecificRecommendations repaymentScheduleIssueDate(LocalDate repaymentScheduleIssueDate) {
    this.repaymentScheduleIssueDate = repaymentScheduleIssueDate;
    return this;
  }

   /**
   * Repayment schedule start date in ISO 8601 date format YYYY-MM-DD
   * @return repaymentScheduleIssueDate
  **/
  @Schema(example = "Fri Sep 15 00:00:00 UTC 1972", description = "Repayment schedule start date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getRepaymentScheduleIssueDate() {
    return repaymentScheduleIssueDate;
  }

  public void setRepaymentScheduleIssueDate(LocalDate repaymentScheduleIssueDate) {
    this.repaymentScheduleIssueDate = repaymentScheduleIssueDate;
  }

  public LoanSpecificRecommendations repaymentSchedule(List<RepaymentSchedule> repaymentSchedule) {
    this.repaymentSchedule = repaymentSchedule;
    return this;
  }

  public LoanSpecificRecommendations addRepaymentScheduleItem(RepaymentSchedule repaymentScheduleItem) {
    if (this.repaymentSchedule == null) {
      this.repaymentSchedule = new ArrayList<RepaymentSchedule>();
    }
    this.repaymentSchedule.add(repaymentScheduleItem);
    return this;
  }

   /**
   * Get repaymentSchedule
   * @return repaymentSchedule
  **/
  @Schema(description = "")
  public List<RepaymentSchedule> getRepaymentSchedule() {
    return repaymentSchedule;
  }

  public void setRepaymentSchedule(List<RepaymentSchedule> repaymentSchedule) {
    this.repaymentSchedule = repaymentSchedule;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LoanSpecificRecommendations loanSpecificRecommendations = (LoanSpecificRecommendations) o;
    return Objects.equals(this.loanAmount, loanSpecificRecommendations.loanAmount) &&
        Objects.equals(this.tenor, loanSpecificRecommendations.tenor) &&
        Objects.equals(this.interestRate, loanSpecificRecommendations.interestRate) &&
        Objects.equals(this.handlingFee, loanSpecificRecommendations.handlingFee) &&
        Objects.equals(this.installmentAmount, loanSpecificRecommendations.installmentAmount) &&
        Objects.equals(this.annualPercentageRate, loanSpecificRecommendations.annualPercentageRate) &&
        Objects.equals(this.totalPrincipalAmount, loanSpecificRecommendations.totalPrincipalAmount) &&
        Objects.equals(this.totalInterestAmount, loanSpecificRecommendations.totalInterestAmount) &&
        Objects.equals(this.totalInstallmentAmount, loanSpecificRecommendations.totalInstallmentAmount) &&
        Objects.equals(this.repaymentScheduleIssueDate, loanSpecificRecommendations.repaymentScheduleIssueDate) &&
        Objects.equals(this.repaymentSchedule, loanSpecificRecommendations.repaymentSchedule);
  }

  @Override
  public int hashCode() {
    return Objects.hash(loanAmount, tenor, interestRate, handlingFee, installmentAmount, annualPercentageRate, totalPrincipalAmount, totalInterestAmount, totalInstallmentAmount, repaymentScheduleIssueDate, repaymentSchedule);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LoanSpecificRecommendations {\n");
    
    sb.append("    loanAmount: ").append(toIndentedString(loanAmount)).append("\n");
    sb.append("    tenor: ").append(toIndentedString(tenor)).append("\n");
    sb.append("    interestRate: ").append(toIndentedString(interestRate)).append("\n");
    sb.append("    handlingFee: ").append(toIndentedString(handlingFee)).append("\n");
    sb.append("    installmentAmount: ").append(toIndentedString(installmentAmount)).append("\n");
    sb.append("    annualPercentageRate: ").append(toIndentedString(annualPercentageRate)).append("\n");
    sb.append("    totalPrincipalAmount: ").append(toIndentedString(totalPrincipalAmount)).append("\n");
    sb.append("    totalInterestAmount: ").append(toIndentedString(totalInterestAmount)).append("\n");
    sb.append("    totalInstallmentAmount: ").append(toIndentedString(totalInstallmentAmount)).append("\n");
    sb.append("    repaymentScheduleIssueDate: ").append(toIndentedString(repaymentScheduleIssueDate)).append("\n");
    sb.append("    repaymentSchedule: ").append(toIndentedString(repaymentSchedule)).append("\n");
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
