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
import io.swagger.client.model.CorporateOfficerDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.LocalDate;
/**
 * InitiateCreditChargeCardCorporateCardsClosureRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class InitiateCreditChargeCardCorporateCardsClosureRequest {
  @SerializedName("tokenizedCardNumber")
  private String tokenizedCardNumber = null;

  @SerializedName("corporateOfficerDetails")
  private CorporateOfficerDetails corporateOfficerDetails = null;

  @SerializedName("cancellationReasonCode")
  private String cancellationReasonCode = null;

  @SerializedName("cancellationType")
  private String cancellationType = null;

  @SerializedName("effectiveCancelDate")
  private LocalDate effectiveCancelDate = null;

  @SerializedName("postalMailCode")
  private String postalMailCode = null;

  @SerializedName("permenantAccountClosureFlag")
  private Boolean permenantAccountClosureFlag = null;

  @SerializedName("consentGivenFlag")
  private Boolean consentGivenFlag = null;

  public InitiateCreditChargeCardCorporateCardsClosureRequest tokenizedCardNumber(String tokenizedCardNumber) {
    this.tokenizedCardNumber = tokenizedCardNumber;
    return this;
  }

   /**
   * Tokenized card number
   * @return tokenizedCardNumber
  **/
  @Schema(example = "asdsdf2341d5166h", required = true, description = "Tokenized card number")
  public String getTokenizedCardNumber() {
    return tokenizedCardNumber;
  }

  public void setTokenizedCardNumber(String tokenizedCardNumber) {
    this.tokenizedCardNumber = tokenizedCardNumber;
  }

  public InitiateCreditChargeCardCorporateCardsClosureRequest corporateOfficerDetails(CorporateOfficerDetails corporateOfficerDetails) {
    this.corporateOfficerDetails = corporateOfficerDetails;
    return this;
  }

   /**
   * Get corporateOfficerDetails
   * @return corporateOfficerDetails
  **/
  @Schema(description = "")
  public CorporateOfficerDetails getCorporateOfficerDetails() {
    return corporateOfficerDetails;
  }

  public void setCorporateOfficerDetails(CorporateOfficerDetails corporateOfficerDetails) {
    this.corporateOfficerDetails = corporateOfficerDetails;
  }

  public InitiateCreditChargeCardCorporateCardsClosureRequest cancellationReasonCode(String cancellationReasonCode) {
    this.cancellationReasonCode = cancellationReasonCode;
    return this;
  }

   /**
   * cancellationReasonCode. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationReasonCode} resource to get possible values of this field with descriptions
   * @return cancellationReasonCode
  **/
  @Schema(example = "HIGH _FEES", description = "cancellationReasonCode. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationReasonCode} resource to get possible values of this field with descriptions")
  public String getCancellationReasonCode() {
    return cancellationReasonCode;
  }

  public void setCancellationReasonCode(String cancellationReasonCode) {
    this.cancellationReasonCode = cancellationReasonCode;
  }

  public InitiateCreditChargeCardCorporateCardsClosureRequest cancellationType(String cancellationType) {
    this.cancellationType = cancellationType;
    return this;
  }

   /**
   * cancellationReasonDescription. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationType} resource to get possible values of this field with descriptions
   * @return cancellationType
  **/
  @Schema(example = "VOLUNTARY", description = "cancellationReasonDescription. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationType} resource to get possible values of this field with descriptions")
  public String getCancellationType() {
    return cancellationType;
  }

  public void setCancellationType(String cancellationType) {
    this.cancellationType = cancellationType;
  }

  public InitiateCreditChargeCardCorporateCardsClosureRequest effectiveCancelDate(LocalDate effectiveCancelDate) {
    this.effectiveCancelDate = effectiveCancelDate;
    return this;
  }

   /**
   * Cancellation date in ISO 8601 date format YYYY-MM-DD
   * @return effectiveCancelDate
  **/
  @Schema(example = "Thu Feb 02 00:00:00 UTC 2012", description = "Cancellation date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getEffectiveCancelDate() {
    return effectiveCancelDate;
  }

  public void setEffectiveCancelDate(LocalDate effectiveCancelDate) {
    this.effectiveCancelDate = effectiveCancelDate;
  }

  public InitiateCreditChargeCardCorporateCardsClosureRequest postalMailCode(String postalMailCode) {
    this.postalMailCode = postalMailCode;
    return this;
  }

   /**
   * Mail letter code if business opt to send letter to customer. This is a reference data field. Please use /v1/utilities/referenceData/{postalMailCode} resource to get possible values of this field with descriptions.
   * @return postalMailCode
  **/
  @Schema(example = "BOQ_ACCOUNT_CLOSURE_LETTER", description = "Mail letter code if business opt to send letter to customer. This is a reference data field. Please use /v1/utilities/referenceData/{postalMailCode} resource to get possible values of this field with descriptions.")
  public String getPostalMailCode() {
    return postalMailCode;
  }

  public void setPostalMailCode(String postalMailCode) {
    this.postalMailCode = postalMailCode;
  }

  public InitiateCreditChargeCardCorporateCardsClosureRequest permenantAccountClosureFlag(Boolean permenantAccountClosureFlag) {
    this.permenantAccountClosureFlag = permenantAccountClosureFlag;
    return this;
  }

   /**
   * Permanent Account Closure Flag
   * @return permenantAccountClosureFlag
  **/
  @Schema(example = "true", description = "Permanent Account Closure Flag")
  public Boolean isPermenantAccountClosureFlag() {
    return permenantAccountClosureFlag;
  }

  public void setPermenantAccountClosureFlag(Boolean permenantAccountClosureFlag) {
    this.permenantAccountClosureFlag = permenantAccountClosureFlag;
  }

  public InitiateCreditChargeCardCorporateCardsClosureRequest consentGivenFlag(Boolean consentGivenFlag) {
    this.consentGivenFlag = consentGivenFlag;
    return this;
  }

   /**
   * This is consent flag from the customer to pay back if any outstanding on that account while closure
   * @return consentGivenFlag
  **/
  @Schema(example = "true", description = "This is consent flag from the customer to pay back if any outstanding on that account while closure")
  public Boolean isConsentGivenFlag() {
    return consentGivenFlag;
  }

  public void setConsentGivenFlag(Boolean consentGivenFlag) {
    this.consentGivenFlag = consentGivenFlag;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InitiateCreditChargeCardCorporateCardsClosureRequest initiateCreditChargeCardCorporateCardsClosureRequest = (InitiateCreditChargeCardCorporateCardsClosureRequest) o;
    return Objects.equals(this.tokenizedCardNumber, initiateCreditChargeCardCorporateCardsClosureRequest.tokenizedCardNumber) &&
        Objects.equals(this.corporateOfficerDetails, initiateCreditChargeCardCorporateCardsClosureRequest.corporateOfficerDetails) &&
        Objects.equals(this.cancellationReasonCode, initiateCreditChargeCardCorporateCardsClosureRequest.cancellationReasonCode) &&
        Objects.equals(this.cancellationType, initiateCreditChargeCardCorporateCardsClosureRequest.cancellationType) &&
        Objects.equals(this.effectiveCancelDate, initiateCreditChargeCardCorporateCardsClosureRequest.effectiveCancelDate) &&
        Objects.equals(this.postalMailCode, initiateCreditChargeCardCorporateCardsClosureRequest.postalMailCode) &&
        Objects.equals(this.permenantAccountClosureFlag, initiateCreditChargeCardCorporateCardsClosureRequest.permenantAccountClosureFlag) &&
        Objects.equals(this.consentGivenFlag, initiateCreditChargeCardCorporateCardsClosureRequest.consentGivenFlag);
  }

  @Override
  public int hashCode() {
    return Objects.hash(tokenizedCardNumber, corporateOfficerDetails, cancellationReasonCode, cancellationType, effectiveCancelDate, postalMailCode, permenantAccountClosureFlag, consentGivenFlag);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InitiateCreditChargeCardCorporateCardsClosureRequest {\n");
    
    sb.append("    tokenizedCardNumber: ").append(toIndentedString(tokenizedCardNumber)).append("\n");
    sb.append("    corporateOfficerDetails: ").append(toIndentedString(corporateOfficerDetails)).append("\n");
    sb.append("    cancellationReasonCode: ").append(toIndentedString(cancellationReasonCode)).append("\n");
    sb.append("    cancellationType: ").append(toIndentedString(cancellationType)).append("\n");
    sb.append("    effectiveCancelDate: ").append(toIndentedString(effectiveCancelDate)).append("\n");
    sb.append("    postalMailCode: ").append(toIndentedString(postalMailCode)).append("\n");
    sb.append("    permenantAccountClosureFlag: ").append(toIndentedString(permenantAccountClosureFlag)).append("\n");
    sb.append("    consentGivenFlag: ").append(toIndentedString(consentGivenFlag)).append("\n");
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
