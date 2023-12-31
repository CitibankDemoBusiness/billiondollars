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
import io.swagger.client.model.BalanceTransferBookings;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
/**
 * BalanceTransferBookingRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class BalanceTransferBookingRequest {
  @SerializedName("tenor")
  private BigDecimal tenor = null;

  @SerializedName("balanceTransferBookings")
  private List<BalanceTransferBookings> balanceTransferBookings = new ArrayList<BalanceTransferBookings>();

  public BalanceTransferBookingRequest tenor(BigDecimal tenor) {
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

  public BalanceTransferBookingRequest balanceTransferBookings(List<BalanceTransferBookings> balanceTransferBookings) {
    this.balanceTransferBookings = balanceTransferBookings;
    return this;
  }

  public BalanceTransferBookingRequest addBalanceTransferBookingsItem(BalanceTransferBookings balanceTransferBookingsItem) {
    this.balanceTransferBookings.add(balanceTransferBookingsItem);
    return this;
  }

   /**
   * Get balanceTransferBookings
   * @return balanceTransferBookings
  **/
  @Schema(required = true, description = "")
  public List<BalanceTransferBookings> getBalanceTransferBookings() {
    return balanceTransferBookings;
  }

  public void setBalanceTransferBookings(List<BalanceTransferBookings> balanceTransferBookings) {
    this.balanceTransferBookings = balanceTransferBookings;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BalanceTransferBookingRequest balanceTransferBookingRequest = (BalanceTransferBookingRequest) o;
    return Objects.equals(this.tenor, balanceTransferBookingRequest.tenor) &&
        Objects.equals(this.balanceTransferBookings, balanceTransferBookingRequest.balanceTransferBookings);
  }

  @Override
  public int hashCode() {
    return Objects.hash(tenor, balanceTransferBookings);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BalanceTransferBookingRequest {\n");
    
    sb.append("    tenor: ").append(toIndentedString(tenor)).append("\n");
    sb.append("    balanceTransferBookings: ").append(toIndentedString(balanceTransferBookings)).append("\n");
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
