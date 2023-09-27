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
import io.swagger.client.model.ListResponse;
import io.swagger.client.model.LoanPaymentSchedule;
import io.swagger.client.model.LoanSummary;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse {
  @SerializedName("listResponse")
  private ListResponse listResponse = null;

  @SerializedName("orgCode")
  private String orgCode = null;

  @SerializedName("loanAmortizationSchedule")
  private List<LoanPaymentSchedule> loanAmortizationSchedule = null;

  @SerializedName("loanSummary")
  private LoanSummary loanSummary = null;

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse listResponse(ListResponse listResponse) {
    this.listResponse = listResponse;
    return this;
  }

   /**
   * Get listResponse
   * @return listResponse
  **/
  @Schema(description = "")
  public ListResponse getListResponse() {
    return listResponse;
  }

  public void setListResponse(ListResponse listResponse) {
    this.listResponse = listResponse;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse orgCode(String orgCode) {
    this.orgCode = orgCode;
    return this;
  }

   /**
   * Organization of the card
   * @return orgCode
  **/
  @Schema(example = "324", description = "Organization of the card")
  public String getOrgCode() {
    return orgCode;
  }

  public void setOrgCode(String orgCode) {
    this.orgCode = orgCode;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse loanAmortizationSchedule(List<LoanPaymentSchedule> loanAmortizationSchedule) {
    this.loanAmortizationSchedule = loanAmortizationSchedule;
    return this;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse addLoanAmortizationScheduleItem(LoanPaymentSchedule loanAmortizationScheduleItem) {
    if (this.loanAmortizationSchedule == null) {
      this.loanAmortizationSchedule = new ArrayList<LoanPaymentSchedule>();
    }
    this.loanAmortizationSchedule.add(loanAmortizationScheduleItem);
    return this;
  }

   /**
   * Get loanAmortizationSchedule
   * @return loanAmortizationSchedule
  **/
  @Schema(description = "")
  public List<LoanPaymentSchedule> getLoanAmortizationSchedule() {
    return loanAmortizationSchedule;
  }

  public void setLoanAmortizationSchedule(List<LoanPaymentSchedule> loanAmortizationSchedule) {
    this.loanAmortizationSchedule = loanAmortizationSchedule;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse loanSummary(LoanSummary loanSummary) {
    this.loanSummary = loanSummary;
    return this;
  }

   /**
   * Get loanSummary
   * @return loanSummary
  **/
  @Schema(description = "")
  public LoanSummary getLoanSummary() {
    return loanSummary;
  }

  public void setLoanSummary(LoanSummary loanSummary) {
    this.loanSummary = loanSummary;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse = (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse) o;
    return Objects.equals(this.listResponse, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.listResponse) &&
        Objects.equals(this.orgCode, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.orgCode) &&
        Objects.equals(this.loanAmortizationSchedule, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.loanAmortizationSchedule) &&
        Objects.equals(this.loanSummary, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.loanSummary);
  }

  @Override
  public int hashCode() {
    return Objects.hash(listResponse, orgCode, loanAmortizationSchedule, loanSummary);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse {\n");
    
    sb.append("    listResponse: ").append(toIndentedString(listResponse)).append("\n");
    sb.append("    orgCode: ").append(toIndentedString(orgCode)).append("\n");
    sb.append("    loanAmortizationSchedule: ").append(toIndentedString(loanAmortizationSchedule)).append("\n");
    sb.append("    loanSummary: ").append(toIndentedString(loanSummary)).append("\n");
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
