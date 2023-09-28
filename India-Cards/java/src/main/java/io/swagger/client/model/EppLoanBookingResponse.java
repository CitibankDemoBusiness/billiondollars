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
import io.swagger.client.model.EppTransaction;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * EppLoanBookingResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class EppLoanBookingResponse {
  @SerializedName("eppTransaction")
  private EppTransaction eppTransaction = null;

  public EppLoanBookingResponse eppTransaction(EppTransaction eppTransaction) {
    this.eppTransaction = eppTransaction;
    return this;
  }

   /**
   * Get eppTransaction
   * @return eppTransaction
  **/
  @Schema(required = true, description = "")
  public EppTransaction getEppTransaction() {
    return eppTransaction;
  }

  public void setEppTransaction(EppTransaction eppTransaction) {
    this.eppTransaction = eppTransaction;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EppLoanBookingResponse eppLoanBookingResponse = (EppLoanBookingResponse) o;
    return Objects.equals(this.eppTransaction, eppLoanBookingResponse.eppTransaction);
  }

  @Override
  public int hashCode() {
    return Objects.hash(eppTransaction);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EppLoanBookingResponse {\n");
    
    sb.append("    eppTransaction: ").append(toIndentedString(eppTransaction)).append("\n");
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