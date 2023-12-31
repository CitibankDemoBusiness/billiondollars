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
 * RetrieveCreditChargeCardCorporateCardsDetailResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class RetrieveCreditChargeCardCorporateCardsDetailResponse {
  @SerializedName("cashWithdrawalAllowedFlag")
  private Boolean cashWithdrawalAllowedFlag = null;

  @SerializedName("permanentCreditLimitAmount")
  private Double permanentCreditLimitAmount = null;

  @SerializedName("currentBalanceAmount")
  private Double currentBalanceAmount = null;

  @SerializedName("cardStatus")
  private String cardStatus = null;

  public RetrieveCreditChargeCardCorporateCardsDetailResponse cashWithdrawalAllowedFlag(Boolean cashWithdrawalAllowedFlag) {
    this.cashWithdrawalAllowedFlag = cashWithdrawalAllowedFlag;
    return this;
  }

   /**
   * This field is used to indicate, whether the customer is allowed to withdraw cash or not
   * @return cashWithdrawalAllowedFlag
  **/
  @Schema(example = "true", description = "This field is used to indicate, whether the customer is allowed to withdraw cash or not")
  public Boolean isCashWithdrawalAllowedFlag() {
    return cashWithdrawalAllowedFlag;
  }

  public void setCashWithdrawalAllowedFlag(Boolean cashWithdrawalAllowedFlag) {
    this.cashWithdrawalAllowedFlag = cashWithdrawalAllowedFlag;
  }

  public RetrieveCreditChargeCardCorporateCardsDetailResponse permanentCreditLimitAmount(Double permanentCreditLimitAmount) {
    this.permanentCreditLimitAmount = permanentCreditLimitAmount;
    return this;
  }

   /**
   * This field is used to indicate the limit present on the card
   * @return permanentCreditLimitAmount
  **/
  @Schema(example = "200.0", description = "This field is used to indicate the limit present on the card")
  public Double getPermanentCreditLimitAmount() {
    return permanentCreditLimitAmount;
  }

  public void setPermanentCreditLimitAmount(Double permanentCreditLimitAmount) {
    this.permanentCreditLimitAmount = permanentCreditLimitAmount;
  }

  public RetrieveCreditChargeCardCorporateCardsDetailResponse currentBalanceAmount(Double currentBalanceAmount) {
    this.currentBalanceAmount = currentBalanceAmount;
    return this;
  }

   /**
   * This is the balance credit limit left after monthly spend
   * @return currentBalanceAmount
  **/
  @Schema(example = "200.0", description = "This is the balance credit limit left after monthly spend")
  public Double getCurrentBalanceAmount() {
    return currentBalanceAmount;
  }

  public void setCurrentBalanceAmount(Double currentBalanceAmount) {
    this.currentBalanceAmount = currentBalanceAmount;
  }

  public RetrieveCreditChargeCardCorporateCardsDetailResponse cardStatus(String cardStatus) {
    this.cardStatus = cardStatus;
    return this;
  }

   /**
   * This field shows the card status. This is a reference data field. Please use /v1/utilities/referenceData/{cardStatus} resource to get possible values of this field with descriptions
   * @return cardStatus
  **/
  @Schema(example = "ACTIVE", description = "This field shows the card status. This is a reference data field. Please use /v1/utilities/referenceData/{cardStatus} resource to get possible values of this field with descriptions")
  public String getCardStatus() {
    return cardStatus;
  }

  public void setCardStatus(String cardStatus) {
    this.cardStatus = cardStatus;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RetrieveCreditChargeCardCorporateCardsDetailResponse retrieveCreditChargeCardCorporateCardsDetailResponse = (RetrieveCreditChargeCardCorporateCardsDetailResponse) o;
    return Objects.equals(this.cashWithdrawalAllowedFlag, retrieveCreditChargeCardCorporateCardsDetailResponse.cashWithdrawalAllowedFlag) &&
        Objects.equals(this.permanentCreditLimitAmount, retrieveCreditChargeCardCorporateCardsDetailResponse.permanentCreditLimitAmount) &&
        Objects.equals(this.currentBalanceAmount, retrieveCreditChargeCardCorporateCardsDetailResponse.currentBalanceAmount) &&
        Objects.equals(this.cardStatus, retrieveCreditChargeCardCorporateCardsDetailResponse.cardStatus);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cashWithdrawalAllowedFlag, permanentCreditLimitAmount, currentBalanceAmount, cardStatus);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RetrieveCreditChargeCardCorporateCardsDetailResponse {\n");
    
    sb.append("    cashWithdrawalAllowedFlag: ").append(toIndentedString(cashWithdrawalAllowedFlag)).append("\n");
    sb.append("    permanentCreditLimitAmount: ").append(toIndentedString(permanentCreditLimitAmount)).append("\n");
    sb.append("    currentBalanceAmount: ").append(toIndentedString(currentBalanceAmount)).append("\n");
    sb.append("    cardStatus: ").append(toIndentedString(cardStatus)).append("\n");
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
