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
import io.swagger.client.model.BalanceTransferDetails;
import io.swagger.client.model.EqualPaymentPlan;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * ReadyCreditProduct
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ReadyCreditProduct {
  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("sourceCode")
  private String sourceCode = null;

  @SerializedName("organization")
  private String organization = null;

  @SerializedName("logo")
  private String logo = null;

  @SerializedName("requestCreditShield")
  private Boolean requestCreditShield = null;

  @SerializedName("embossName")
  private String embossName = null;

  @SerializedName("billingAddress")
  private String billingAddress = null;

  @SerializedName("cardDeliveryAddress")
  private String cardDeliveryAddress = null;

  @SerializedName("pinDeliveryAddress")
  private String pinDeliveryAddress = null;

  @SerializedName("giftCode")
  private String giftCode = null;

  @SerializedName("creditLimitIncreaseIndicator")
  private Boolean creditLimitIncreaseIndicator = null;

  @SerializedName("atmRequiredFlag")
  private Boolean atmRequiredFlag = null;

  @SerializedName("chequeBookRequiredFlag")
  private Boolean chequeBookRequiredFlag = null;

  @SerializedName("balanceTransferDetails")
  private List<BalanceTransferDetails> balanceTransferDetails = null;

  @SerializedName("loanPurpose")
  private String loanPurpose = null;

  @SerializedName("requestedCreditLimit")
  private Double requestedCreditLimit = null;

  @SerializedName("equalPaymentPlan")
  private List<EqualPaymentPlan> equalPaymentPlan = null;

  @SerializedName("atmPinRegistrationFlag")
  private Boolean atmPinRegistrationFlag = null;

  @SerializedName("creditLimitAcceptedFlag")
  private Boolean creditLimitAcceptedFlag = null;

  public ReadyCreditProduct productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "US251", required = true, description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public ReadyCreditProduct sourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
    return this;
  }

   /**
   * A source code to identify the product
   * @return sourceCode
  **/
  @Schema(example = "PGP144", required = true, description = "A source code to identify the product")
  public String getSourceCode() {
    return sourceCode;
  }

  public void setSourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
  }

  public ReadyCreditProduct organization(String organization) {
    this.organization = organization;
    return this;
  }

   /**
   * Card issuing organization name
   * @return organization
  **/
  @Schema(example = "030", required = true, description = "Card issuing organization name")
  public String getOrganization() {
    return organization;
  }

  public void setOrganization(String organization) {
    this.organization = organization;
  }

  public ReadyCreditProduct logo(String logo) {
    this.logo = logo;
    return this;
  }

   /**
   * Product logo to identify the product
   * @return logo
  **/
  @Schema(example = "PNC1", required = true, description = "Product logo to identify the product")
  public String getLogo() {
    return logo;
  }

  public void setLogo(String logo) {
    this.logo = logo;
  }

  public ReadyCreditProduct requestCreditShield(Boolean requestCreditShield) {
    this.requestCreditShield = requestCreditShield;
    return this;
  }

   /**
   * Insurance enrolment for outstanding balance on the card. Valid values: true and false
   * @return requestCreditShield
  **/
  @Schema(example = "false", description = "Insurance enrolment for outstanding balance on the card. Valid values: true and false")
  public Boolean isRequestCreditShield() {
    return requestCreditShield;
  }

  public void setRequestCreditShield(Boolean requestCreditShield) {
    this.requestCreditShield = requestCreditShield;
  }

  public ReadyCreditProduct embossName(String embossName) {
    this.embossName = embossName;
    return this;
  }

   /**
   * Name to be embossed on card
   * @return embossName
  **/
  @Schema(example = "Matthew Hayden", description = "Name to be embossed on card")
  public String getEmbossName() {
    return embossName;
  }

  public void setEmbossName(String embossName) {
    this.embossName = embossName;
  }

  public ReadyCreditProduct billingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
    return this;
  }

   /**
   * Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
   * @return billingAddress
  **/
  @Schema(example = "OFFICE_ADDRESS", description = "Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.")
  public String getBillingAddress() {
    return billingAddress;
  }

  public void setBillingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
  }

  public ReadyCreditProduct cardDeliveryAddress(String cardDeliveryAddress) {
    this.cardDeliveryAddress = cardDeliveryAddress;
    return this;
  }

   /**
   * Card delivery address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
   * @return cardDeliveryAddress
  **/
  @Schema(example = "OFFICE_ADDRESS", description = "Card delivery address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.")
  public String getCardDeliveryAddress() {
    return cardDeliveryAddress;
  }

  public void setCardDeliveryAddress(String cardDeliveryAddress) {
    this.cardDeliveryAddress = cardDeliveryAddress;
  }

  public ReadyCreditProduct pinDeliveryAddress(String pinDeliveryAddress) {
    this.pinDeliveryAddress = pinDeliveryAddress;
    return this;
  }

   /**
   * Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
   * @return pinDeliveryAddress
  **/
  @Schema(example = "OFFICE_ADDRESS", description = "Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.")
  public String getPinDeliveryAddress() {
    return pinDeliveryAddress;
  }

  public void setPinDeliveryAddress(String pinDeliveryAddress) {
    this.pinDeliveryAddress = pinDeliveryAddress;
  }

  public ReadyCreditProduct giftCode(String giftCode) {
    this.giftCode = giftCode;
    return this;
  }

   /**
   * A  unique code that identifies the gift offered along with the product
   * @return giftCode
  **/
  @Schema(example = "gc123", description = "A  unique code that identifies the gift offered along with the product")
  public String getGiftCode() {
    return giftCode;
  }

  public void setGiftCode(String giftCode) {
    this.giftCode = giftCode;
  }

  public ReadyCreditProduct creditLimitIncreaseIndicator(Boolean creditLimitIncreaseIndicator) {
    this.creditLimitIncreaseIndicator = creditLimitIncreaseIndicator;
    return this;
  }

   /**
   * Option for to review the credit limit in the future.Valid values: true and false
   * @return creditLimitIncreaseIndicator
  **/
  @Schema(example = "true", description = "Option for to review the credit limit in the future.Valid values: true and false")
  public Boolean isCreditLimitIncreaseIndicator() {
    return creditLimitIncreaseIndicator;
  }

  public void setCreditLimitIncreaseIndicator(Boolean creditLimitIncreaseIndicator) {
    this.creditLimitIncreaseIndicator = creditLimitIncreaseIndicator;
  }

  public ReadyCreditProduct atmRequiredFlag(Boolean atmRequiredFlag) {
    this.atmRequiredFlag = atmRequiredFlag;
    return this;
  }

   /**
   * Option to get ATM card along with product. Valid values: true and false
   * @return atmRequiredFlag
  **/
  @Schema(example = "true", description = "Option to get ATM card along with product. Valid values: true and false")
  public Boolean isAtmRequiredFlag() {
    return atmRequiredFlag;
  }

  public void setAtmRequiredFlag(Boolean atmRequiredFlag) {
    this.atmRequiredFlag = atmRequiredFlag;
  }

  public ReadyCreditProduct chequeBookRequiredFlag(Boolean chequeBookRequiredFlag) {
    this.chequeBookRequiredFlag = chequeBookRequiredFlag;
    return this;
  }

   /**
   * Option to get cheque book along with product. Valid values: true and false
   * @return chequeBookRequiredFlag
  **/
  @Schema(example = "true", description = "Option to get cheque book along with product. Valid values: true and false")
  public Boolean isChequeBookRequiredFlag() {
    return chequeBookRequiredFlag;
  }

  public void setChequeBookRequiredFlag(Boolean chequeBookRequiredFlag) {
    this.chequeBookRequiredFlag = chequeBookRequiredFlag;
  }

  public ReadyCreditProduct balanceTransferDetails(List<BalanceTransferDetails> balanceTransferDetails) {
    this.balanceTransferDetails = balanceTransferDetails;
    return this;
  }

  public ReadyCreditProduct addBalanceTransferDetailsItem(BalanceTransferDetails balanceTransferDetailsItem) {
    if (this.balanceTransferDetails == null) {
      this.balanceTransferDetails = new ArrayList<BalanceTransferDetails>();
    }
    this.balanceTransferDetails.add(balanceTransferDetailsItem);
    return this;
  }

   /**
   * Get balanceTransferDetails
   * @return balanceTransferDetails
  **/
  @Schema(description = "")
  public List<BalanceTransferDetails> getBalanceTransferDetails() {
    return balanceTransferDetails;
  }

  public void setBalanceTransferDetails(List<BalanceTransferDetails> balanceTransferDetails) {
    this.balanceTransferDetails = balanceTransferDetails;
  }

  public ReadyCreditProduct loanPurpose(String loanPurpose) {
    this.loanPurpose = loanPurpose;
    return this;
  }

   /**
   * Purpose of loan. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.
   * @return loanPurpose
  **/
  @Schema(example = "PERSONAL", description = "Purpose of loan. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.")
  public String getLoanPurpose() {
    return loanPurpose;
  }

  public void setLoanPurpose(String loanPurpose) {
    this.loanPurpose = loanPurpose;
  }

  public ReadyCreditProduct requestedCreditLimit(Double requestedCreditLimit) {
    this.requestedCreditLimit = requestedCreditLimit;
    return this;
  }

   /**
   * Credit limit requested by applicant for the product.
   * @return requestedCreditLimit
  **/
  @Schema(example = "8000.0", description = "Credit limit requested by applicant for the product.")
  public Double getRequestedCreditLimit() {
    return requestedCreditLimit;
  }

  public void setRequestedCreditLimit(Double requestedCreditLimit) {
    this.requestedCreditLimit = requestedCreditLimit;
  }

  public ReadyCreditProduct equalPaymentPlan(List<EqualPaymentPlan> equalPaymentPlan) {
    this.equalPaymentPlan = equalPaymentPlan;
    return this;
  }

  public ReadyCreditProduct addEqualPaymentPlanItem(EqualPaymentPlan equalPaymentPlanItem) {
    if (this.equalPaymentPlan == null) {
      this.equalPaymentPlan = new ArrayList<EqualPaymentPlan>();
    }
    this.equalPaymentPlan.add(equalPaymentPlanItem);
    return this;
  }

   /**
   * Get equalPaymentPlan
   * @return equalPaymentPlan
  **/
  @Schema(description = "")
  public List<EqualPaymentPlan> getEqualPaymentPlan() {
    return equalPaymentPlan;
  }

  public void setEqualPaymentPlan(List<EqualPaymentPlan> equalPaymentPlan) {
    this.equalPaymentPlan = equalPaymentPlan;
  }

  public ReadyCreditProduct atmPinRegistrationFlag(Boolean atmPinRegistrationFlag) {
    this.atmPinRegistrationFlag = atmPinRegistrationFlag;
    return this;
  }

   /**
   * Flag to indicate if ATM PIN for the card is registered already by customer.
   * @return atmPinRegistrationFlag
  **/
  @Schema(example = "true", description = "Flag to indicate if ATM PIN for the card is registered already by customer.")
  public Boolean isAtmPinRegistrationFlag() {
    return atmPinRegistrationFlag;
  }

  public void setAtmPinRegistrationFlag(Boolean atmPinRegistrationFlag) {
    this.atmPinRegistrationFlag = atmPinRegistrationFlag;
  }

  public ReadyCreditProduct creditLimitAcceptedFlag(Boolean creditLimitAcceptedFlag) {
    this.creditLimitAcceptedFlag = creditLimitAcceptedFlag;
    return this;
  }

   /**
   * Flag to indicate acceptance of customer for the ready credit limit.
   * @return creditLimitAcceptedFlag
  **/
  @Schema(example = "true", description = "Flag to indicate acceptance of customer for the ready credit limit.")
  public Boolean isCreditLimitAcceptedFlag() {
    return creditLimitAcceptedFlag;
  }

  public void setCreditLimitAcceptedFlag(Boolean creditLimitAcceptedFlag) {
    this.creditLimitAcceptedFlag = creditLimitAcceptedFlag;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ReadyCreditProduct readyCreditProduct = (ReadyCreditProduct) o;
    return Objects.equals(this.productCode, readyCreditProduct.productCode) &&
        Objects.equals(this.sourceCode, readyCreditProduct.sourceCode) &&
        Objects.equals(this.organization, readyCreditProduct.organization) &&
        Objects.equals(this.logo, readyCreditProduct.logo) &&
        Objects.equals(this.requestCreditShield, readyCreditProduct.requestCreditShield) &&
        Objects.equals(this.embossName, readyCreditProduct.embossName) &&
        Objects.equals(this.billingAddress, readyCreditProduct.billingAddress) &&
        Objects.equals(this.cardDeliveryAddress, readyCreditProduct.cardDeliveryAddress) &&
        Objects.equals(this.pinDeliveryAddress, readyCreditProduct.pinDeliveryAddress) &&
        Objects.equals(this.giftCode, readyCreditProduct.giftCode) &&
        Objects.equals(this.creditLimitIncreaseIndicator, readyCreditProduct.creditLimitIncreaseIndicator) &&
        Objects.equals(this.atmRequiredFlag, readyCreditProduct.atmRequiredFlag) &&
        Objects.equals(this.chequeBookRequiredFlag, readyCreditProduct.chequeBookRequiredFlag) &&
        Objects.equals(this.balanceTransferDetails, readyCreditProduct.balanceTransferDetails) &&
        Objects.equals(this.loanPurpose, readyCreditProduct.loanPurpose) &&
        Objects.equals(this.requestedCreditLimit, readyCreditProduct.requestedCreditLimit) &&
        Objects.equals(this.equalPaymentPlan, readyCreditProduct.equalPaymentPlan) &&
        Objects.equals(this.atmPinRegistrationFlag, readyCreditProduct.atmPinRegistrationFlag) &&
        Objects.equals(this.creditLimitAcceptedFlag, readyCreditProduct.creditLimitAcceptedFlag);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, sourceCode, organization, logo, requestCreditShield, embossName, billingAddress, cardDeliveryAddress, pinDeliveryAddress, giftCode, creditLimitIncreaseIndicator, atmRequiredFlag, chequeBookRequiredFlag, balanceTransferDetails, loanPurpose, requestedCreditLimit, equalPaymentPlan, atmPinRegistrationFlag, creditLimitAcceptedFlag);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ReadyCreditProduct {\n");
    
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    sourceCode: ").append(toIndentedString(sourceCode)).append("\n");
    sb.append("    organization: ").append(toIndentedString(organization)).append("\n");
    sb.append("    logo: ").append(toIndentedString(logo)).append("\n");
    sb.append("    requestCreditShield: ").append(toIndentedString(requestCreditShield)).append("\n");
    sb.append("    embossName: ").append(toIndentedString(embossName)).append("\n");
    sb.append("    billingAddress: ").append(toIndentedString(billingAddress)).append("\n");
    sb.append("    cardDeliveryAddress: ").append(toIndentedString(cardDeliveryAddress)).append("\n");
    sb.append("    pinDeliveryAddress: ").append(toIndentedString(pinDeliveryAddress)).append("\n");
    sb.append("    giftCode: ").append(toIndentedString(giftCode)).append("\n");
    sb.append("    creditLimitIncreaseIndicator: ").append(toIndentedString(creditLimitIncreaseIndicator)).append("\n");
    sb.append("    atmRequiredFlag: ").append(toIndentedString(atmRequiredFlag)).append("\n");
    sb.append("    chequeBookRequiredFlag: ").append(toIndentedString(chequeBookRequiredFlag)).append("\n");
    sb.append("    balanceTransferDetails: ").append(toIndentedString(balanceTransferDetails)).append("\n");
    sb.append("    loanPurpose: ").append(toIndentedString(loanPurpose)).append("\n");
    sb.append("    requestedCreditLimit: ").append(toIndentedString(requestedCreditLimit)).append("\n");
    sb.append("    equalPaymentPlan: ").append(toIndentedString(equalPaymentPlan)).append("\n");
    sb.append("    atmPinRegistrationFlag: ").append(toIndentedString(atmPinRegistrationFlag)).append("\n");
    sb.append("    creditLimitAcceptedFlag: ").append(toIndentedString(creditLimitAcceptedFlag)).append("\n");
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
