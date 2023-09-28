/*
 * Cards
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
import io.swagger.client.model.LoanAmortizationSchedule;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse {
  @SerializedName("nextStartIndex")
  private String nextStartIndex = null;

  @SerializedName("loanAmortizationSchedule")
  private List<LoanAmortizationSchedule> loanAmortizationSchedule = null;

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse nextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
    return this;
  }

   /**
   * The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.
   * @return nextStartIndex
  **/
  @Schema(example = "11", description = "The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.")
  public String getNextStartIndex() {
    return nextStartIndex;
  }

  public void setNextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse loanAmortizationSchedule(List<LoanAmortizationSchedule> loanAmortizationSchedule) {
    this.loanAmortizationSchedule = loanAmortizationSchedule;
    return this;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse addLoanAmortizationScheduleItem(LoanAmortizationSchedule loanAmortizationScheduleItem) {
    if (this.loanAmortizationSchedule == null) {
      this.loanAmortizationSchedule = new ArrayList<LoanAmortizationSchedule>();
    }
    this.loanAmortizationSchedule.add(loanAmortizationScheduleItem);
    return this;
  }

   /**
   * Get loanAmortizationSchedule
   * @return loanAmortizationSchedule
  **/
  @Schema(description = "")
  public List<LoanAmortizationSchedule> getLoanAmortizationSchedule() {
    return loanAmortizationSchedule;
  }

  public void setLoanAmortizationSchedule(List<LoanAmortizationSchedule> loanAmortizationSchedule) {
    this.loanAmortizationSchedule = loanAmortizationSchedule;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse = (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse) o;
    return Objects.equals(this.nextStartIndex, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse.nextStartIndex) &&
        Objects.equals(this.loanAmortizationSchedule, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse.loanAmortizationSchedule);
  }

  @Override
  public int hashCode() {
    return Objects.hash(nextStartIndex, loanAmortizationSchedule);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse {\n");
    
    sb.append("    nextStartIndex: ").append(toIndentedString(nextStartIndex)).append("\n");
    sb.append("    loanAmortizationSchedule: ").append(toIndentedString(loanAmortizationSchedule)).append("\n");
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