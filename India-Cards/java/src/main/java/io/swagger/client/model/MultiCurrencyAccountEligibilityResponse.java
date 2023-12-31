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
import io.swagger.client.model.AccountDetails;
import io.swagger.client.model.CurrencyDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * MultiCurrencyAccountEligibilityResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class MultiCurrencyAccountEligibilityResponse {
  @SerializedName("displayCardNumber")
  private String displayCardNumber = null;

  @SerializedName("cardId")
  private String cardId = null;

  @SerializedName("atmCardFlag")
  private Boolean atmCardFlag = null;

  @SerializedName("cardEnrollmentStatus")
  private String cardEnrollmentStatus = null;

  @SerializedName("eligibleForCurrencyAddition")
  private String eligibleForCurrencyAddition = null;

  @SerializedName("accountDetails")
  private List<AccountDetails> accountDetails = null;

  @SerializedName("currencyDetails")
  private List<CurrencyDetails> currencyDetails = null;

  public MultiCurrencyAccountEligibilityResponse displayCardNumber(String displayCardNumber) {
    this.displayCardNumber = displayCardNumber;
    return this;
  }

   /**
   * A masked card number that can be displayed to the customer.
   * @return displayCardNumber
  **/
  @Schema(example = "********4678", required = true, description = "A masked card number that can be displayed to the customer.")
  public String getDisplayCardNumber() {
    return displayCardNumber;
  }

  public void setDisplayCardNumber(String displayCardNumber) {
    this.displayCardNumber = displayCardNumber;
  }

  public MultiCurrencyAccountEligibilityResponse cardId(String cardId) {
    this.cardId = cardId;
    return this;
  }

   /**
   * The customer card identifier in encrypted format
   * @return cardId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", required = true, description = "The customer card identifier in encrypted format")
  public String getCardId() {
    return cardId;
  }

  public void setCardId(String cardId) {
    this.cardId = cardId;
  }

  public MultiCurrencyAccountEligibilityResponse atmCardFlag(Boolean atmCardFlag) {
    this.atmCardFlag = atmCardFlag;
    return this;
  }

   /**
   * Flag to identify if the cardNumbre in response is ATM card.
   * @return atmCardFlag
  **/
  @Schema(example = "true", description = "Flag to identify if the cardNumbre in response is ATM card.")
  public Boolean isAtmCardFlag() {
    return atmCardFlag;
  }

  public void setAtmCardFlag(Boolean atmCardFlag) {
    this.atmCardFlag = atmCardFlag;
  }

  public MultiCurrencyAccountEligibilityResponse cardEnrollmentStatus(String cardEnrollmentStatus) {
    this.cardEnrollmentStatus = cardEnrollmentStatus;
    return this;
  }

   /**
   * This field is to indicate if the  card is enrolled for Multi Currency Account or not.Please use /v1/apac/utilities/referenceData/{cardEnrollmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
   * @return cardEnrollmentStatus
  **/
  @Schema(example = "ENROLLED", required = true, description = "This field is to indicate if the  card is enrolled for Multi Currency Account or not.Please use /v1/apac/utilities/referenceData/{cardEnrollmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.")
  public String getCardEnrollmentStatus() {
    return cardEnrollmentStatus;
  }

  public void setCardEnrollmentStatus(String cardEnrollmentStatus) {
    this.cardEnrollmentStatus = cardEnrollmentStatus;
  }

  public MultiCurrencyAccountEligibilityResponse eligibleForCurrencyAddition(String eligibleForCurrencyAddition) {
    this.eligibleForCurrencyAddition = eligibleForCurrencyAddition;
    return this;
  }

   /**
   * Eligible to add new currency.This is a reference data field. Please use /utilities/referenceData/{ eligibleForCurrencyAddition} resource to get valid value of this field with description.
   * @return eligibleForCurrencyAddition
  **/
  @Schema(example = "ELIGIBLE_TO_ADD_NEW_CURRENCY", description = "Eligible to add new currency.This is a reference data field. Please use /utilities/referenceData/{ eligibleForCurrencyAddition} resource to get valid value of this field with description.")
  public String getEligibleForCurrencyAddition() {
    return eligibleForCurrencyAddition;
  }

  public void setEligibleForCurrencyAddition(String eligibleForCurrencyAddition) {
    this.eligibleForCurrencyAddition = eligibleForCurrencyAddition;
  }

  public MultiCurrencyAccountEligibilityResponse accountDetails(List<AccountDetails> accountDetails) {
    this.accountDetails = accountDetails;
    return this;
  }

  public MultiCurrencyAccountEligibilityResponse addAccountDetailsItem(AccountDetails accountDetailsItem) {
    if (this.accountDetails == null) {
      this.accountDetails = new ArrayList<AccountDetails>();
    }
    this.accountDetails.add(accountDetailsItem);
    return this;
  }

   /**
   * Get accountDetails
   * @return accountDetails
  **/
  @Schema(description = "")
  public List<AccountDetails> getAccountDetails() {
    return accountDetails;
  }

  public void setAccountDetails(List<AccountDetails> accountDetails) {
    this.accountDetails = accountDetails;
  }

  public MultiCurrencyAccountEligibilityResponse currencyDetails(List<CurrencyDetails> currencyDetails) {
    this.currencyDetails = currencyDetails;
    return this;
  }

  public MultiCurrencyAccountEligibilityResponse addCurrencyDetailsItem(CurrencyDetails currencyDetailsItem) {
    if (this.currencyDetails == null) {
      this.currencyDetails = new ArrayList<CurrencyDetails>();
    }
    this.currencyDetails.add(currencyDetailsItem);
    return this;
  }

   /**
   * Get currencyDetails
   * @return currencyDetails
  **/
  @Schema(description = "")
  public List<CurrencyDetails> getCurrencyDetails() {
    return currencyDetails;
  }

  public void setCurrencyDetails(List<CurrencyDetails> currencyDetails) {
    this.currencyDetails = currencyDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MultiCurrencyAccountEligibilityResponse multiCurrencyAccountEligibilityResponse = (MultiCurrencyAccountEligibilityResponse) o;
    return Objects.equals(this.displayCardNumber, multiCurrencyAccountEligibilityResponse.displayCardNumber) &&
        Objects.equals(this.cardId, multiCurrencyAccountEligibilityResponse.cardId) &&
        Objects.equals(this.atmCardFlag, multiCurrencyAccountEligibilityResponse.atmCardFlag) &&
        Objects.equals(this.cardEnrollmentStatus, multiCurrencyAccountEligibilityResponse.cardEnrollmentStatus) &&
        Objects.equals(this.eligibleForCurrencyAddition, multiCurrencyAccountEligibilityResponse.eligibleForCurrencyAddition) &&
        Objects.equals(this.accountDetails, multiCurrencyAccountEligibilityResponse.accountDetails) &&
        Objects.equals(this.currencyDetails, multiCurrencyAccountEligibilityResponse.currencyDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(displayCardNumber, cardId, atmCardFlag, cardEnrollmentStatus, eligibleForCurrencyAddition, accountDetails, currencyDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MultiCurrencyAccountEligibilityResponse {\n");
    
    sb.append("    displayCardNumber: ").append(toIndentedString(displayCardNumber)).append("\n");
    sb.append("    cardId: ").append(toIndentedString(cardId)).append("\n");
    sb.append("    atmCardFlag: ").append(toIndentedString(atmCardFlag)).append("\n");
    sb.append("    cardEnrollmentStatus: ").append(toIndentedString(cardEnrollmentStatus)).append("\n");
    sb.append("    eligibleForCurrencyAddition: ").append(toIndentedString(eligibleForCurrencyAddition)).append("\n");
    sb.append("    accountDetails: ").append(toIndentedString(accountDetails)).append("\n");
    sb.append("    currencyDetails: ").append(toIndentedString(currencyDetails)).append("\n");
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
