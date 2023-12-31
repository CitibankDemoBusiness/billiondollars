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
import io.swagger.client.model.LoanBookingPlan;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse {
  @SerializedName("customerName")
  private String customerName = null;

  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("accountGroup")
  private String accountGroup = null;

  @SerializedName("maximumEligibleLoanAmount")
  private Double maximumEligibleLoanAmount = null;

  @SerializedName("minimumEligibleLoanAmount")
  private Double minimumEligibleLoanAmount = null;

  @SerializedName("offerIndicator")
  private String offerIndicator = null;

  @SerializedName("loanBookingPlan")
  private List<LoanBookingPlan> loanBookingPlan = null;

  @SerializedName("lopCategory")
  private String lopCategory = null;

  public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse customerName(String customerName) {
    this.customerName = customerName;
    return this;
  }

   /**
   * This refers to the name of the customer.
   * @return customerName
  **/
  @Schema(example = "John Watson", required = true, description = "This refers to the name of the customer.")
  public String getCustomerName() {
    return customerName;
  }

  public void setCustomerName(String customerName) {
    this.customerName = customerName;
  }

  public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayAccountNumber
  **/
  @Schema(example = "XXXXXX2361", description = "A masked account number that can be displayed to the customer")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse accountGroup(String accountGroup) {
    this.accountGroup = accountGroup;
    return this;
  }

   /**
   * Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description.
   * @return accountGroup
  **/
  @Schema(example = "SAVINGS_AND_INVESTMENTS", description = "Account Group associated with the source Account.This is a reference data field. Please use /v1/utilities/referenceData/{accountGroup} resource to get valid value of this field with description.")
  public String getAccountGroup() {
    return accountGroup;
  }

  public void setAccountGroup(String accountGroup) {
    this.accountGroup = accountGroup;
  }

  public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse maximumEligibleLoanAmount(Double maximumEligibleLoanAmount) {
    this.maximumEligibleLoanAmount = maximumEligibleLoanAmount;
    return this;
  }

   /**
   * The maximum amount of credit that extend to a customer
   * @return maximumEligibleLoanAmount
  **/
  @Schema(example = "5000.0", required = true, description = "The maximum amount of credit that extend to a customer")
  public Double getMaximumEligibleLoanAmount() {
    return maximumEligibleLoanAmount;
  }

  public void setMaximumEligibleLoanAmount(Double maximumEligibleLoanAmount) {
    this.maximumEligibleLoanAmount = maximumEligibleLoanAmount;
  }

  public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse minimumEligibleLoanAmount(Double minimumEligibleLoanAmount) {
    this.minimumEligibleLoanAmount = minimumEligibleLoanAmount;
    return this;
  }

   /**
   * The minimum amount of credit that extend to a customer
   * @return minimumEligibleLoanAmount
  **/
  @Schema(example = "500.0", required = true, description = "The minimum amount of credit that extend to a customer")
  public Double getMinimumEligibleLoanAmount() {
    return minimumEligibleLoanAmount;
  }

  public void setMinimumEligibleLoanAmount(Double minimumEligibleLoanAmount) {
    this.minimumEligibleLoanAmount = minimumEligibleLoanAmount;
  }

  public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse offerIndicator(String offerIndicator) {
    this.offerIndicator = offerIndicator;
    return this;
  }

   /**
   * Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description.
   * @return offerIndicator
  **/
  @Schema(example = "RATE_BASED", required = true, description = "Indicator to determine if offer is rate or fee based. This is a reference data field. Please use /v1/apac/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description.")
  public String getOfferIndicator() {
    return offerIndicator;
  }

  public void setOfferIndicator(String offerIndicator) {
    this.offerIndicator = offerIndicator;
  }

  public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse loanBookingPlan(List<LoanBookingPlan> loanBookingPlan) {
    this.loanBookingPlan = loanBookingPlan;
    return this;
  }

  public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse addLoanBookingPlanItem(LoanBookingPlan loanBookingPlanItem) {
    if (this.loanBookingPlan == null) {
      this.loanBookingPlan = new ArrayList<LoanBookingPlan>();
    }
    this.loanBookingPlan.add(loanBookingPlanItem);
    return this;
  }

   /**
   * Get loanBookingPlan
   * @return loanBookingPlan
  **/
  @Schema(description = "")
  public List<LoanBookingPlan> getLoanBookingPlan() {
    return loanBookingPlan;
  }

  public void setLoanBookingPlan(List<LoanBookingPlan> loanBookingPlan) {
    this.loanBookingPlan = loanBookingPlan;
  }

  public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse lopCategory(String lopCategory) {
    this.lopCategory = lopCategory;
    return this;
  }

   /**
   * Indicator to determine the type of LOP Offer. This is a reference data field. Please use /v1/utilities/referenceData/{lopCategory} resource to get valid value of this field with description.
   * @return lopCategory
  **/
  @Schema(example = "LOAN_OVER_PHONE", description = "Indicator to determine the type of LOP Offer. This is a reference data field. Please use /v1/utilities/referenceData/{lopCategory} resource to get valid value of this field with description.")
  public String getLopCategory() {
    return lopCategory;
  }

  public void setLopCategory(String lopCategory) {
    this.lopCategory = lopCategory;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse evaluateCustomerEligibilityAssessmentCheckPreLoginResponse = (EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse) o;
    return Objects.equals(this.customerName, evaluateCustomerEligibilityAssessmentCheckPreLoginResponse.customerName) &&
        Objects.equals(this.displayAccountNumber, evaluateCustomerEligibilityAssessmentCheckPreLoginResponse.displayAccountNumber) &&
        Objects.equals(this.accountGroup, evaluateCustomerEligibilityAssessmentCheckPreLoginResponse.accountGroup) &&
        Objects.equals(this.maximumEligibleLoanAmount, evaluateCustomerEligibilityAssessmentCheckPreLoginResponse.maximumEligibleLoanAmount) &&
        Objects.equals(this.minimumEligibleLoanAmount, evaluateCustomerEligibilityAssessmentCheckPreLoginResponse.minimumEligibleLoanAmount) &&
        Objects.equals(this.offerIndicator, evaluateCustomerEligibilityAssessmentCheckPreLoginResponse.offerIndicator) &&
        Objects.equals(this.loanBookingPlan, evaluateCustomerEligibilityAssessmentCheckPreLoginResponse.loanBookingPlan) &&
        Objects.equals(this.lopCategory, evaluateCustomerEligibilityAssessmentCheckPreLoginResponse.lopCategory);
  }

  @Override
  public int hashCode() {
    return Objects.hash(customerName, displayAccountNumber, accountGroup, maximumEligibleLoanAmount, minimumEligibleLoanAmount, offerIndicator, loanBookingPlan, lopCategory);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse {\n");
    
    sb.append("    customerName: ").append(toIndentedString(customerName)).append("\n");
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    accountGroup: ").append(toIndentedString(accountGroup)).append("\n");
    sb.append("    maximumEligibleLoanAmount: ").append(toIndentedString(maximumEligibleLoanAmount)).append("\n");
    sb.append("    minimumEligibleLoanAmount: ").append(toIndentedString(minimumEligibleLoanAmount)).append("\n");
    sb.append("    offerIndicator: ").append(toIndentedString(offerIndicator)).append("\n");
    sb.append("    loanBookingPlan: ").append(toIndentedString(loanBookingPlan)).append("\n");
    sb.append("    lopCategory: ").append(toIndentedString(lopCategory)).append("\n");
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
