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
/**
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse {
  @SerializedName("newLoanReferenceId")
  private String newLoanReferenceId = null;

  @SerializedName("nextInstallmentAmount")
  private Double nextInstallmentAmount = null;

  @SerializedName("nextInstallmentPrincipalAmount")
  private Double nextInstallmentPrincipalAmount = null;

  @SerializedName("interestRate")
  private Double interestRate = null;

  @SerializedName("totalInterestAmount")
  private Double totalInterestAmount = null;

  @SerializedName("loanBookingFee")
  private Double loanBookingFee = null;

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse newLoanReferenceId(String newLoanReferenceId) {
    this.newLoanReferenceId = newLoanReferenceId;
    return this;
  }

   /**
   * Unique refrence number associated with the loan.
   * @return newLoanReferenceId
  **/
  @Schema(example = "2019-07-03-08.32.29.422079", required = true, description = "Unique refrence number associated with the loan.")
  public String getNewLoanReferenceId() {
    return newLoanReferenceId;
  }

  public void setNewLoanReferenceId(String newLoanReferenceId) {
    this.newLoanReferenceId = newLoanReferenceId;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse nextInstallmentAmount(Double nextInstallmentAmount) {
    this.nextInstallmentAmount = nextInstallmentAmount;
    return this;
  }

   /**
   * Amount of money borrower has to pay as next installment.
   * @return nextInstallmentAmount
  **/
  @Schema(example = "1566.05", description = "Amount of money borrower has to pay as next installment.")
  public Double getNextInstallmentAmount() {
    return nextInstallmentAmount;
  }

  public void setNextInstallmentAmount(Double nextInstallmentAmount) {
    this.nextInstallmentAmount = nextInstallmentAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse nextInstallmentPrincipalAmount(Double nextInstallmentPrincipalAmount) {
    this.nextInstallmentPrincipalAmount = nextInstallmentPrincipalAmount;
    return this;
  }

   /**
   * Amount of money that contributes to principal component in next installment.
   * @return nextInstallmentPrincipalAmount
  **/
  @Schema(example = "100.25", description = "Amount of money that contributes to principal component in next installment.")
  public Double getNextInstallmentPrincipalAmount() {
    return nextInstallmentPrincipalAmount;
  }

  public void setNextInstallmentPrincipalAmount(Double nextInstallmentPrincipalAmount) {
    this.nextInstallmentPrincipalAmount = nextInstallmentPrincipalAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse interestRate(Double interestRate) {
    this.interestRate = interestRate;
    return this;
  }

   /**
   * Rate of Interest.Interest rate is the amount charged, expressed as a percentage of principal, by a lender to a borrower for the use of assets. Interest rates are typically noted on an annual basis, known as the annual percentage rate (APR).
   * @return interestRate
  **/
  @Schema(example = "0.25", description = "Rate of Interest.Interest rate is the amount charged, expressed as a percentage of principal, by a lender to a borrower for the use of assets. Interest rates are typically noted on an annual basis, known as the annual percentage rate (APR).")
  public Double getInterestRate() {
    return interestRate;
  }

  public void setInterestRate(Double interestRate) {
    this.interestRate = interestRate;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse totalInterestAmount(Double totalInterestAmount) {
    this.totalInterestAmount = totalInterestAmount;
    return this;
  }

   /**
   * Total amount of money that a borrower will have to pay as interest for amount borrowed.
   * @return totalInterestAmount
  **/
  @Schema(example = "1234.5", description = "Total amount of money that a borrower will have to pay as interest for amount borrowed.")
  public Double getTotalInterestAmount() {
    return totalInterestAmount;
  }

  public void setTotalInterestAmount(Double totalInterestAmount) {
    this.totalInterestAmount = totalInterestAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse loanBookingFee(Double loanBookingFee) {
    this.loanBookingFee = loanBookingFee;
    return this;
  }

   /**
   * Amount to be paid as fee for loan booking.
   * @return loanBookingFee
  **/
  @Schema(example = "100.25", description = "Amount to be paid as fee for loan booking.")
  public Double getLoanBookingFee() {
    return loanBookingFee;
  }

  public void setLoanBookingFee(Double loanBookingFee) {
    this.loanBookingFee = loanBookingFee;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse = (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse) o;
    return Objects.equals(this.newLoanReferenceId, retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.newLoanReferenceId) &&
        Objects.equals(this.nextInstallmentAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.nextInstallmentAmount) &&
        Objects.equals(this.nextInstallmentPrincipalAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.nextInstallmentPrincipalAmount) &&
        Objects.equals(this.interestRate, retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.interestRate) &&
        Objects.equals(this.totalInterestAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.totalInterestAmount) &&
        Objects.equals(this.loanBookingFee, retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.loanBookingFee);
  }

  @Override
  public int hashCode() {
    return Objects.hash(newLoanReferenceId, nextInstallmentAmount, nextInstallmentPrincipalAmount, interestRate, totalInterestAmount, loanBookingFee);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse {\n");
    
    sb.append("    newLoanReferenceId: ").append(toIndentedString(newLoanReferenceId)).append("\n");
    sb.append("    nextInstallmentAmount: ").append(toIndentedString(nextInstallmentAmount)).append("\n");
    sb.append("    nextInstallmentPrincipalAmount: ").append(toIndentedString(nextInstallmentPrincipalAmount)).append("\n");
    sb.append("    interestRate: ").append(toIndentedString(interestRate)).append("\n");
    sb.append("    totalInterestAmount: ").append(toIndentedString(totalInterestAmount)).append("\n");
    sb.append("    loanBookingFee: ").append(toIndentedString(loanBookingFee)).append("\n");
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
