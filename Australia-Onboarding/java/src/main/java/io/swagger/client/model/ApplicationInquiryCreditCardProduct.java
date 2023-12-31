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
import io.swagger.client.model.ApplicationInquiryBalanceTransferDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * ApplicationInquiryCreditCardProduct
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationInquiryCreditCardProduct {
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

  @SerializedName("requestedCreditLimit")
  private Double requestedCreditLimit = null;

  @SerializedName("balanceTransferDetails")
  private List<ApplicationInquiryBalanceTransferDetails> balanceTransferDetails = null;

  public ApplicationInquiryCreditCardProduct productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product.
   * @return productCode
  **/
  @Schema(example = "VC830", required = true, description = "A unique code that identifies the product.")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public ApplicationInquiryCreditCardProduct sourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
    return this;
  }

   /**
   * A source code to identify the product
   * @return sourceCode
  **/
  @Schema(example = "WW5ARCE1", required = true, description = "A source code to identify the product")
  public String getSourceCode() {
    return sourceCode;
  }

  public void setSourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
  }

  public ApplicationInquiryCreditCardProduct organization(String organization) {
    this.organization = organization;
    return this;
  }

   /**
   * Card issuing organization name
   * @return organization
  **/
  @Schema(example = "888", required = true, description = "Card issuing organization name")
  public String getOrganization() {
    return organization;
  }

  public void setOrganization(String organization) {
    this.organization = organization;
  }

  public ApplicationInquiryCreditCardProduct logo(String logo) {
    this.logo = logo;
    return this;
  }

   /**
   * Product logo to identify the product
   * @return logo
  **/
  @Schema(example = "830", required = true, description = "Product logo to identify the product")
  public String getLogo() {
    return logo;
  }

  public void setLogo(String logo) {
    this.logo = logo;
  }

  public ApplicationInquiryCreditCardProduct requestCreditShield(Boolean requestCreditShield) {
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

  public ApplicationInquiryCreditCardProduct embossName(String embossName) {
    this.embossName = embossName;
    return this;
  }

   /**
   * Name to be embossed on card.
   * @return embossName
  **/
  @Schema(example = "Matthew Hayden", description = "Name to be embossed on card.")
  public String getEmbossName() {
    return embossName;
  }

  public void setEmbossName(String embossName) {
    this.embossName = embossName;
  }

  public ApplicationInquiryCreditCardProduct billingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
    return this;
  }

   /**
   * Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field as the referenceCode parameter to retrieve the values.
   * @return billingAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field as the referenceCode parameter to retrieve the values.")
  public String getBillingAddress() {
    return billingAddress;
  }

  public void setBillingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
  }

  public ApplicationInquiryCreditCardProduct cardDeliveryAddress(String cardDeliveryAddress) {
    this.cardDeliveryAddress = cardDeliveryAddress;
    return this;
  }

   /**
   * Card delivery address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
   * @return cardDeliveryAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Card delivery address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.")
  public String getCardDeliveryAddress() {
    return cardDeliveryAddress;
  }

  public void setCardDeliveryAddress(String cardDeliveryAddress) {
    this.cardDeliveryAddress = cardDeliveryAddress;
  }

  public ApplicationInquiryCreditCardProduct pinDeliveryAddress(String pinDeliveryAddress) {
    this.pinDeliveryAddress = pinDeliveryAddress;
    return this;
  }

   /**
   * Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
   * @return pinDeliveryAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.")
  public String getPinDeliveryAddress() {
    return pinDeliveryAddress;
  }

  public void setPinDeliveryAddress(String pinDeliveryAddress) {
    this.pinDeliveryAddress = pinDeliveryAddress;
  }

  public ApplicationInquiryCreditCardProduct giftCode(String giftCode) {
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

  public ApplicationInquiryCreditCardProduct creditLimitIncreaseIndicator(Boolean creditLimitIncreaseIndicator) {
    this.creditLimitIncreaseIndicator = creditLimitIncreaseIndicator;
    return this;
  }

   /**
   * Option  to review the credit limit in the future.Valid values: true and false
   * @return creditLimitIncreaseIndicator
  **/
  @Schema(example = "true", description = "Option  to review the credit limit in the future.Valid values: true and false")
  public Boolean isCreditLimitIncreaseIndicator() {
    return creditLimitIncreaseIndicator;
  }

  public void setCreditLimitIncreaseIndicator(Boolean creditLimitIncreaseIndicator) {
    this.creditLimitIncreaseIndicator = creditLimitIncreaseIndicator;
  }

  public ApplicationInquiryCreditCardProduct requestedCreditLimit(Double requestedCreditLimit) {
    this.requestedCreditLimit = requestedCreditLimit;
    return this;
  }

   /**
   * Credit limit accepted by applicant
   * @return requestedCreditLimit
  **/
  @Schema(example = "25000.25", description = "Credit limit accepted by applicant")
  public Double getRequestedCreditLimit() {
    return requestedCreditLimit;
  }

  public void setRequestedCreditLimit(Double requestedCreditLimit) {
    this.requestedCreditLimit = requestedCreditLimit;
  }

  public ApplicationInquiryCreditCardProduct balanceTransferDetails(List<ApplicationInquiryBalanceTransferDetails> balanceTransferDetails) {
    this.balanceTransferDetails = balanceTransferDetails;
    return this;
  }

  public ApplicationInquiryCreditCardProduct addBalanceTransferDetailsItem(ApplicationInquiryBalanceTransferDetails balanceTransferDetailsItem) {
    if (this.balanceTransferDetails == null) {
      this.balanceTransferDetails = new ArrayList<ApplicationInquiryBalanceTransferDetails>();
    }
    this.balanceTransferDetails.add(balanceTransferDetailsItem);
    return this;
  }

   /**
   * Get balanceTransferDetails
   * @return balanceTransferDetails
  **/
  @Schema(description = "")
  public List<ApplicationInquiryBalanceTransferDetails> getBalanceTransferDetails() {
    return balanceTransferDetails;
  }

  public void setBalanceTransferDetails(List<ApplicationInquiryBalanceTransferDetails> balanceTransferDetails) {
    this.balanceTransferDetails = balanceTransferDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationInquiryCreditCardProduct applicationInquiryCreditCardProduct = (ApplicationInquiryCreditCardProduct) o;
    return Objects.equals(this.productCode, applicationInquiryCreditCardProduct.productCode) &&
        Objects.equals(this.sourceCode, applicationInquiryCreditCardProduct.sourceCode) &&
        Objects.equals(this.organization, applicationInquiryCreditCardProduct.organization) &&
        Objects.equals(this.logo, applicationInquiryCreditCardProduct.logo) &&
        Objects.equals(this.requestCreditShield, applicationInquiryCreditCardProduct.requestCreditShield) &&
        Objects.equals(this.embossName, applicationInquiryCreditCardProduct.embossName) &&
        Objects.equals(this.billingAddress, applicationInquiryCreditCardProduct.billingAddress) &&
        Objects.equals(this.cardDeliveryAddress, applicationInquiryCreditCardProduct.cardDeliveryAddress) &&
        Objects.equals(this.pinDeliveryAddress, applicationInquiryCreditCardProduct.pinDeliveryAddress) &&
        Objects.equals(this.giftCode, applicationInquiryCreditCardProduct.giftCode) &&
        Objects.equals(this.creditLimitIncreaseIndicator, applicationInquiryCreditCardProduct.creditLimitIncreaseIndicator) &&
        Objects.equals(this.requestedCreditLimit, applicationInquiryCreditCardProduct.requestedCreditLimit) &&
        Objects.equals(this.balanceTransferDetails, applicationInquiryCreditCardProduct.balanceTransferDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, sourceCode, organization, logo, requestCreditShield, embossName, billingAddress, cardDeliveryAddress, pinDeliveryAddress, giftCode, creditLimitIncreaseIndicator, requestedCreditLimit, balanceTransferDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationInquiryCreditCardProduct {\n");
    
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
    sb.append("    requestedCreditLimit: ").append(toIndentedString(requestedCreditLimit)).append("\n");
    sb.append("    balanceTransferDetails: ").append(toIndentedString(balanceTransferDetails)).append("\n");
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
