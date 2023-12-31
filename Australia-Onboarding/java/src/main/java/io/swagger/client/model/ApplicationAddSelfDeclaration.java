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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ApplicationAddSelfDeclaration
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddSelfDeclaration {
  @SerializedName("totalActiveCreditCardLimitAmount")
  private Double totalActiveCreditCardLimitAmount = null;

  @SerializedName("anticipatedIncomeDecreaseCode")
  private String anticipatedIncomeDecreaseCode = null;

  @SerializedName("loanTakenIndicator")
  private Boolean loanTakenIndicator = null;

  @SerializedName("monthlyRepaymentForAllExtLoans")
  private Double monthlyRepaymentForAllExtLoans = null;

  public ApplicationAddSelfDeclaration totalActiveCreditCardLimitAmount(Double totalActiveCreditCardLimitAmount) {
    this.totalActiveCreditCardLimitAmount = totalActiveCreditCardLimitAmount;
    return this;
  }

   /**
   * Total credit limit of all the credit cards the applicant is holding
   * @return totalActiveCreditCardLimitAmount
  **/
  @Schema(example = "23000.25", description = "Total credit limit of all the credit cards the applicant is holding")
  public Double getTotalActiveCreditCardLimitAmount() {
    return totalActiveCreditCardLimitAmount;
  }

  public void setTotalActiveCreditCardLimitAmount(Double totalActiveCreditCardLimitAmount) {
    this.totalActiveCreditCardLimitAmount = totalActiveCreditCardLimitAmount;
  }

  public ApplicationAddSelfDeclaration anticipatedIncomeDecreaseCode(String anticipatedIncomeDecreaseCode) {
    this.anticipatedIncomeDecreaseCode = anticipatedIncomeDecreaseCode;
    return this;
  }

   /**
   * Anticipated income decrease code. Valid values: Yes and No
   * @return anticipatedIncomeDecreaseCode
  **/
  @Schema(example = "Yes", description = "Anticipated income decrease code. Valid values: Yes and No")
  public String getAnticipatedIncomeDecreaseCode() {
    return anticipatedIncomeDecreaseCode;
  }

  public void setAnticipatedIncomeDecreaseCode(String anticipatedIncomeDecreaseCode) {
    this.anticipatedIncomeDecreaseCode = anticipatedIncomeDecreaseCode;
  }

  public ApplicationAddSelfDeclaration loanTakenIndicator(Boolean loanTakenIndicator) {
    this.loanTakenIndicator = loanTakenIndicator;
    return this;
  }

   /**
   * To indicate if any loan is outstanding.Valid values: true and false
   * @return loanTakenIndicator
  **/
  @Schema(example = "true", description = "To indicate if any loan is outstanding.Valid values: true and false")
  public Boolean isLoanTakenIndicator() {
    return loanTakenIndicator;
  }

  public void setLoanTakenIndicator(Boolean loanTakenIndicator) {
    this.loanTakenIndicator = loanTakenIndicator;
  }

  public ApplicationAddSelfDeclaration monthlyRepaymentForAllExtLoans(Double monthlyRepaymentForAllExtLoans) {
    this.monthlyRepaymentForAllExtLoans = monthlyRepaymentForAllExtLoans;
    return this;
  }

   /**
   * Customer declaration for his/her total monthly repayment amount for all the external loans.
   * @return monthlyRepaymentForAllExtLoans
  **/
  @Schema(example = "5000.25", description = "Customer declaration for his/her total monthly repayment amount for all the external loans.")
  public Double getMonthlyRepaymentForAllExtLoans() {
    return monthlyRepaymentForAllExtLoans;
  }

  public void setMonthlyRepaymentForAllExtLoans(Double monthlyRepaymentForAllExtLoans) {
    this.monthlyRepaymentForAllExtLoans = monthlyRepaymentForAllExtLoans;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddSelfDeclaration applicationAddSelfDeclaration = (ApplicationAddSelfDeclaration) o;
    return Objects.equals(this.totalActiveCreditCardLimitAmount, applicationAddSelfDeclaration.totalActiveCreditCardLimitAmount) &&
        Objects.equals(this.anticipatedIncomeDecreaseCode, applicationAddSelfDeclaration.anticipatedIncomeDecreaseCode) &&
        Objects.equals(this.loanTakenIndicator, applicationAddSelfDeclaration.loanTakenIndicator) &&
        Objects.equals(this.monthlyRepaymentForAllExtLoans, applicationAddSelfDeclaration.monthlyRepaymentForAllExtLoans);
  }

  @Override
  public int hashCode() {
    return Objects.hash(totalActiveCreditCardLimitAmount, anticipatedIncomeDecreaseCode, loanTakenIndicator, monthlyRepaymentForAllExtLoans);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddSelfDeclaration {\n");
    
    sb.append("    totalActiveCreditCardLimitAmount: ").append(toIndentedString(totalActiveCreditCardLimitAmount)).append("\n");
    sb.append("    anticipatedIncomeDecreaseCode: ").append(toIndentedString(anticipatedIncomeDecreaseCode)).append("\n");
    sb.append("    loanTakenIndicator: ").append(toIndentedString(loanTakenIndicator)).append("\n");
    sb.append("    monthlyRepaymentForAllExtLoans: ").append(toIndentedString(monthlyRepaymentForAllExtLoans)).append("\n");
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
