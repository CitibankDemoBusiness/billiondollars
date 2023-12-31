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
import io.swagger.client.model.CreditCardDetails;
import io.swagger.client.model.DebitCardDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * CardsLimitsAndEnrollmentsUpdateRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class CardsLimitsAndEnrollmentsUpdateRequest {
  @SerializedName("creditCardDetails")
  private CreditCardDetails creditCardDetails = null;

  @SerializedName("debitCardDetails")
  private DebitCardDetails debitCardDetails = null;

  public CardsLimitsAndEnrollmentsUpdateRequest creditCardDetails(CreditCardDetails creditCardDetails) {
    this.creditCardDetails = creditCardDetails;
    return this;
  }

   /**
   * Get creditCardDetails
   * @return creditCardDetails
  **/
  @Schema(description = "")
  public CreditCardDetails getCreditCardDetails() {
    return creditCardDetails;
  }

  public void setCreditCardDetails(CreditCardDetails creditCardDetails) {
    this.creditCardDetails = creditCardDetails;
  }

  public CardsLimitsAndEnrollmentsUpdateRequest debitCardDetails(DebitCardDetails debitCardDetails) {
    this.debitCardDetails = debitCardDetails;
    return this;
  }

   /**
   * Get debitCardDetails
   * @return debitCardDetails
  **/
  @Schema(description = "")
  public DebitCardDetails getDebitCardDetails() {
    return debitCardDetails;
  }

  public void setDebitCardDetails(DebitCardDetails debitCardDetails) {
    this.debitCardDetails = debitCardDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CardsLimitsAndEnrollmentsUpdateRequest cardsLimitsAndEnrollmentsUpdateRequest = (CardsLimitsAndEnrollmentsUpdateRequest) o;
    return Objects.equals(this.creditCardDetails, cardsLimitsAndEnrollmentsUpdateRequest.creditCardDetails) &&
        Objects.equals(this.debitCardDetails, cardsLimitsAndEnrollmentsUpdateRequest.debitCardDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(creditCardDetails, debitCardDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CardsLimitsAndEnrollmentsUpdateRequest {\n");
    
    sb.append("    creditCardDetails: ").append(toIndentedString(creditCardDetails)).append("\n");
    sb.append("    debitCardDetails: ").append(toIndentedString(debitCardDetails)).append("\n");
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
