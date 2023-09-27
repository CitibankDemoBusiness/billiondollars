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
import io.swagger.client.model.ApplicationAddExistingLoanDetails;
import io.swagger.client.model.ApplicationAddExpenseDetails;
import io.swagger.client.model.ApplicationAddIncomeDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * ApplicationAddFinancialInformation
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddFinancialInformation {
  @SerializedName("hasForeseeableFinancialChanges")
  private Boolean hasForeseeableFinancialChanges = null;

  @SerializedName("nonBankDebtObligationFlag")
  private Boolean nonBankDebtObligationFlag = null;

  @SerializedName("expenseDetails")
  private List<ApplicationAddExpenseDetails> expenseDetails = null;

  @SerializedName("incomeDetails")
  private List<ApplicationAddIncomeDetails> incomeDetails = null;

  @SerializedName("existingLoanDetails")
  private List<ApplicationAddExistingLoanDetails> existingLoanDetails = null;

  public ApplicationAddFinancialInformation hasForeseeableFinancialChanges(Boolean hasForeseeableFinancialChanges) {
    this.hasForeseeableFinancialChanges = hasForeseeableFinancialChanges;
    return this;
  }

   /**
   * Indicates whether any foreseeable changes in customer&#x27;s financial circumstances.
   * @return hasForeseeableFinancialChanges
  **/
  @Schema(example = "true", description = "Indicates whether any foreseeable changes in customer's financial circumstances.")
  public Boolean isHasForeseeableFinancialChanges() {
    return hasForeseeableFinancialChanges;
  }

  public void setHasForeseeableFinancialChanges(Boolean hasForeseeableFinancialChanges) {
    this.hasForeseeableFinancialChanges = hasForeseeableFinancialChanges;
  }

  public ApplicationAddFinancialInformation nonBankDebtObligationFlag(Boolean nonBankDebtObligationFlag) {
    this.nonBankDebtObligationFlag = nonBankDebtObligationFlag;
    return this;
  }

   /**
   * Indicates if the applicant has any loan with any non-banking financial organization.
   * @return nonBankDebtObligationFlag
  **/
  @Schema(example = "true", description = "Indicates if the applicant has any loan with any non-banking financial organization.")
  public Boolean isNonBankDebtObligationFlag() {
    return nonBankDebtObligationFlag;
  }

  public void setNonBankDebtObligationFlag(Boolean nonBankDebtObligationFlag) {
    this.nonBankDebtObligationFlag = nonBankDebtObligationFlag;
  }

  public ApplicationAddFinancialInformation expenseDetails(List<ApplicationAddExpenseDetails> expenseDetails) {
    this.expenseDetails = expenseDetails;
    return this;
  }

  public ApplicationAddFinancialInformation addExpenseDetailsItem(ApplicationAddExpenseDetails expenseDetailsItem) {
    if (this.expenseDetails == null) {
      this.expenseDetails = new ArrayList<ApplicationAddExpenseDetails>();
    }
    this.expenseDetails.add(expenseDetailsItem);
    return this;
  }

   /**
   * Get expenseDetails
   * @return expenseDetails
  **/
  @Schema(description = "")
  public List<ApplicationAddExpenseDetails> getExpenseDetails() {
    return expenseDetails;
  }

  public void setExpenseDetails(List<ApplicationAddExpenseDetails> expenseDetails) {
    this.expenseDetails = expenseDetails;
  }

  public ApplicationAddFinancialInformation incomeDetails(List<ApplicationAddIncomeDetails> incomeDetails) {
    this.incomeDetails = incomeDetails;
    return this;
  }

  public ApplicationAddFinancialInformation addIncomeDetailsItem(ApplicationAddIncomeDetails incomeDetailsItem) {
    if (this.incomeDetails == null) {
      this.incomeDetails = new ArrayList<ApplicationAddIncomeDetails>();
    }
    this.incomeDetails.add(incomeDetailsItem);
    return this;
  }

   /**
   * Get incomeDetails
   * @return incomeDetails
  **/
  @Schema(description = "")
  public List<ApplicationAddIncomeDetails> getIncomeDetails() {
    return incomeDetails;
  }

  public void setIncomeDetails(List<ApplicationAddIncomeDetails> incomeDetails) {
    this.incomeDetails = incomeDetails;
  }

  public ApplicationAddFinancialInformation existingLoanDetails(List<ApplicationAddExistingLoanDetails> existingLoanDetails) {
    this.existingLoanDetails = existingLoanDetails;
    return this;
  }

  public ApplicationAddFinancialInformation addExistingLoanDetailsItem(ApplicationAddExistingLoanDetails existingLoanDetailsItem) {
    if (this.existingLoanDetails == null) {
      this.existingLoanDetails = new ArrayList<ApplicationAddExistingLoanDetails>();
    }
    this.existingLoanDetails.add(existingLoanDetailsItem);
    return this;
  }

   /**
   * Get existingLoanDetails
   * @return existingLoanDetails
  **/
  @Schema(description = "")
  public List<ApplicationAddExistingLoanDetails> getExistingLoanDetails() {
    return existingLoanDetails;
  }

  public void setExistingLoanDetails(List<ApplicationAddExistingLoanDetails> existingLoanDetails) {
    this.existingLoanDetails = existingLoanDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddFinancialInformation applicationAddFinancialInformation = (ApplicationAddFinancialInformation) o;
    return Objects.equals(this.hasForeseeableFinancialChanges, applicationAddFinancialInformation.hasForeseeableFinancialChanges) &&
        Objects.equals(this.nonBankDebtObligationFlag, applicationAddFinancialInformation.nonBankDebtObligationFlag) &&
        Objects.equals(this.expenseDetails, applicationAddFinancialInformation.expenseDetails) &&
        Objects.equals(this.incomeDetails, applicationAddFinancialInformation.incomeDetails) &&
        Objects.equals(this.existingLoanDetails, applicationAddFinancialInformation.existingLoanDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(hasForeseeableFinancialChanges, nonBankDebtObligationFlag, expenseDetails, incomeDetails, existingLoanDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddFinancialInformation {\n");
    
    sb.append("    hasForeseeableFinancialChanges: ").append(toIndentedString(hasForeseeableFinancialChanges)).append("\n");
    sb.append("    nonBankDebtObligationFlag: ").append(toIndentedString(nonBankDebtObligationFlag)).append("\n");
    sb.append("    expenseDetails: ").append(toIndentedString(expenseDetails)).append("\n");
    sb.append("    incomeDetails: ").append(toIndentedString(incomeDetails)).append("\n");
    sb.append("    existingLoanDetails: ").append(toIndentedString(existingLoanDetails)).append("\n");
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
