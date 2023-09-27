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
import io.swagger.client.model.EppLoanBooking;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
/**
 * EppLoanBookingRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class EppLoanBookingRequest {
  @SerializedName("eppLoanBookingType")
  private String eppLoanBookingType = null;

  @SerializedName("tenor")
  private BigDecimal tenor = null;

  @SerializedName("eppLoanBooking")
  private List<EppLoanBooking> eppLoanBooking = new ArrayList<EppLoanBooking>();

  public EppLoanBookingRequest eppLoanBookingType(String eppLoanBookingType) {
    this.eppLoanBookingType = eppLoanBookingType;
    return this;
  }

   /**
   * Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/apac/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description.
   * @return eppLoanBookingType
  **/
  @Schema(example = "TRANSACTION", required = true, description = "Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/apac/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description.")
  public String getEppLoanBookingType() {
    return eppLoanBookingType;
  }

  public void setEppLoanBookingType(String eppLoanBookingType) {
    this.eppLoanBookingType = eppLoanBookingType;
  }

  public EppLoanBookingRequest tenor(BigDecimal tenor) {
    this.tenor = tenor;
    return this;
  }

   /**
   * Tenure of loan in months.
   * @return tenor
  **/
  @Schema(example = "6.0", required = true, description = "Tenure of loan in months.")
  public BigDecimal getTenor() {
    return tenor;
  }

  public void setTenor(BigDecimal tenor) {
    this.tenor = tenor;
  }

  public EppLoanBookingRequest eppLoanBooking(List<EppLoanBooking> eppLoanBooking) {
    this.eppLoanBooking = eppLoanBooking;
    return this;
  }

  public EppLoanBookingRequest addEppLoanBookingItem(EppLoanBooking eppLoanBookingItem) {
    this.eppLoanBooking.add(eppLoanBookingItem);
    return this;
  }

   /**
   * EPP Loan Booking Pre-process
   * @return eppLoanBooking
  **/
  @Schema(required = true, description = "EPP Loan Booking Pre-process")
  public List<EppLoanBooking> getEppLoanBooking() {
    return eppLoanBooking;
  }

  public void setEppLoanBooking(List<EppLoanBooking> eppLoanBooking) {
    this.eppLoanBooking = eppLoanBooking;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EppLoanBookingRequest eppLoanBookingRequest = (EppLoanBookingRequest) o;
    return Objects.equals(this.eppLoanBookingType, eppLoanBookingRequest.eppLoanBookingType) &&
        Objects.equals(this.tenor, eppLoanBookingRequest.tenor) &&
        Objects.equals(this.eppLoanBooking, eppLoanBookingRequest.eppLoanBooking);
  }

  @Override
  public int hashCode() {
    return Objects.hash(eppLoanBookingType, tenor, eppLoanBooking);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EppLoanBookingRequest {\n");
    
    sb.append("    eppLoanBookingType: ").append(toIndentedString(eppLoanBookingType)).append("\n");
    sb.append("    tenor: ").append(toIndentedString(tenor)).append("\n");
    sb.append("    eppLoanBooking: ").append(toIndentedString(eppLoanBooking)).append("\n");
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
