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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
/**
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest {
  @SerializedName("loanAmount")
  private Double loanAmount = null;

  @SerializedName("tenor")
  private BigDecimal tenor = null;

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest loanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
    return this;
  }

   /**
   * Loan amount for easy payment plan booking.
   * @return loanAmount
  **/
  @Schema(example = "1500.0", description = "Loan amount for easy payment plan booking.")
  public Double getLoanAmount() {
    return loanAmount;
  }

  public void setLoanAmount(Double loanAmount) {
    this.loanAmount = loanAmount;
  }

  public RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest tenor(BigDecimal tenor) {
    this.tenor = tenor;
    return this;
  }

   /**
   * Tenure of loan in months.
   * @return tenor
  **/
  @Schema(example = "36.0", required = true, description = "Tenure of loan in months.")
  public BigDecimal getTenor() {
    return tenor;
  }

  public void setTenor(BigDecimal tenor) {
    this.tenor = tenor;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest = (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest) o;
    return Objects.equals(this.loanAmount, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.loanAmount) &&
        Objects.equals(this.tenor, retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.tenor);
  }

  @Override
  public int hashCode() {
    return Objects.hash(loanAmount, tenor);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest {\n");
    
    sb.append("    loanAmount: ").append(toIndentedString(loanAmount)).append("\n");
    sb.append("    tenor: ").append(toIndentedString(tenor)).append("\n");
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
