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
/**
 * CardFunctionsAllowed
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class CardFunctionsAllowed {
  @SerializedName("cardFunction")
  private String cardFunction = null;

  public CardFunctionsAllowed cardFunction(String cardFunction) {
    this.cardFunction = cardFunction;
    return this;
  }

   /**
   * Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
   * @return cardFunction
  **/
  @Schema(example = "CREDIT_LIMIT_INCREASE", description = "Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.")
  public String getCardFunction() {
    return cardFunction;
  }

  public void setCardFunction(String cardFunction) {
    this.cardFunction = cardFunction;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CardFunctionsAllowed cardFunctionsAllowed = (CardFunctionsAllowed) o;
    return Objects.equals(this.cardFunction, cardFunctionsAllowed.cardFunction);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cardFunction);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CardFunctionsAllowed {\n");
    
    sb.append("    cardFunction: ").append(toIndentedString(cardFunction)).append("\n");
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
