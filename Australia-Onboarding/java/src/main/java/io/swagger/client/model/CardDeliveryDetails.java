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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * CardDeliveryDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class CardDeliveryDetails {
  @SerializedName("cardDeliveryStatus")
  private String cardDeliveryStatus = null;

  @SerializedName("airwayBillNumber")
  private String airwayBillNumber = null;

  @SerializedName("deliveryMethod")
  private String deliveryMethod = null;

  @SerializedName("cardDeliveryDate")
  private String cardDeliveryDate = null;

  @SerializedName("receivedBy")
  private String receivedBy = null;

  @SerializedName("displayCardNumber")
  private String displayCardNumber = null;

  public CardDeliveryDetails cardDeliveryStatus(String cardDeliveryStatus) {
    this.cardDeliveryStatus = cardDeliveryStatus;
    return this;
  }

   /**
   * Cd delivery status.  This is a reference data field. Please use /v1/utilities/referenceData/{cardDeliveryStatus} resource to get possible values of this field with descriptions.
   * @return cardDeliveryStatus
  **/
  @Schema(description = "Cd delivery status.  This is a reference data field. Please use /v1/utilities/referenceData/{cardDeliveryStatus} resource to get possible values of this field with descriptions.")
  public String getCardDeliveryStatus() {
    return cardDeliveryStatus;
  }

  public void setCardDeliveryStatus(String cardDeliveryStatus) {
    this.cardDeliveryStatus = cardDeliveryStatus;
  }

  public CardDeliveryDetails airwayBillNumber(String airwayBillNumber) {
    this.airwayBillNumber = airwayBillNumber;
    return this;
  }

   /**
   * New Field in EPCDFIL. This field denotes the Airway Bill Number or reference number provided by the courier company for the dispatch.
   * @return airwayBillNumber
  **/
  @Schema(description = "New Field in EPCDFIL. This field denotes the Airway Bill Number or reference number provided by the courier company for the dispatch.")
  public String getAirwayBillNumber() {
    return airwayBillNumber;
  }

  public void setAirwayBillNumber(String airwayBillNumber) {
    this.airwayBillNumber = airwayBillNumber;
  }

  public CardDeliveryDetails deliveryMethod(String deliveryMethod) {
    this.deliveryMethod = deliveryMethod;
    return this;
  }

   /**
   * New Field in EPCDFIL. This field denotes the mode through which the card was disptached. Valid Values :  &#x27;Courier&#x27; or &#x27;Post&#x27; 
   * @return deliveryMethod
  **/
  @Schema(description = "New Field in EPCDFIL. This field denotes the mode through which the card was disptached. Valid Values :  'Courier' or 'Post' ")
  public String getDeliveryMethod() {
    return deliveryMethod;
  }

  public void setDeliveryMethod(String deliveryMethod) {
    this.deliveryMethod = deliveryMethod;
  }

  public CardDeliveryDetails cardDeliveryDate(String cardDeliveryDate) {
    this.cardDeliveryDate = cardDeliveryDate;
    return this;
  }

   /**
   * New Field in EPCDFIL This field denotes the date of card delivery.
   * @return cardDeliveryDate
  **/
  @Schema(description = "New Field in EPCDFIL This field denotes the date of card delivery.")
  public String getCardDeliveryDate() {
    return cardDeliveryDate;
  }

  public void setCardDeliveryDate(String cardDeliveryDate) {
    this.cardDeliveryDate = cardDeliveryDate;
  }

  public CardDeliveryDetails receivedBy(String receivedBy) {
    this.receivedBy = receivedBy;
    return this;
  }

   /**
   * New Field in EPCDFIL. This field denotes the Name and Relationship of the individual who has received the card on behalf of the cardholder. If the card holder has received the card, then this field will have the value as ‘Self’.
   * @return receivedBy
  **/
  @Schema(description = "New Field in EPCDFIL. This field denotes the Name and Relationship of the individual who has received the card on behalf of the cardholder. If the card holder has received the card, then this field will have the value as ‘Self’.")
  public String getReceivedBy() {
    return receivedBy;
  }

  public void setReceivedBy(String receivedBy) {
    this.receivedBy = receivedBy;
  }

  public CardDeliveryDetails displayCardNumber(String displayCardNumber) {
    this.displayCardNumber = displayCardNumber;
    return this;
  }

   /**
   * Card last four Digit.
   * @return displayCardNumber
  **/
  @Schema(description = "Card last four Digit.")
  public String getDisplayCardNumber() {
    return displayCardNumber;
  }

  public void setDisplayCardNumber(String displayCardNumber) {
    this.displayCardNumber = displayCardNumber;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CardDeliveryDetails cardDeliveryDetails = (CardDeliveryDetails) o;
    return Objects.equals(this.cardDeliveryStatus, cardDeliveryDetails.cardDeliveryStatus) &&
        Objects.equals(this.airwayBillNumber, cardDeliveryDetails.airwayBillNumber) &&
        Objects.equals(this.deliveryMethod, cardDeliveryDetails.deliveryMethod) &&
        Objects.equals(this.cardDeliveryDate, cardDeliveryDetails.cardDeliveryDate) &&
        Objects.equals(this.receivedBy, cardDeliveryDetails.receivedBy) &&
        Objects.equals(this.displayCardNumber, cardDeliveryDetails.displayCardNumber);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cardDeliveryStatus, airwayBillNumber, deliveryMethod, cardDeliveryDate, receivedBy, displayCardNumber);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CardDeliveryDetails {\n");
    
    sb.append("    cardDeliveryStatus: ").append(toIndentedString(cardDeliveryStatus)).append("\n");
    sb.append("    airwayBillNumber: ").append(toIndentedString(airwayBillNumber)).append("\n");
    sb.append("    deliveryMethod: ").append(toIndentedString(deliveryMethod)).append("\n");
    sb.append("    cardDeliveryDate: ").append(toIndentedString(cardDeliveryDate)).append("\n");
    sb.append("    receivedBy: ").append(toIndentedString(receivedBy)).append("\n");
    sb.append("    displayCardNumber: ").append(toIndentedString(displayCardNumber)).append("\n");
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
