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
 * ApplicationAddCreditCardProduct
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddCreditCardProduct {
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

  public ApplicationAddCreditCardProduct productCode(String productCode) {
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

  public ApplicationAddCreditCardProduct sourceCode(String sourceCode) {
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

  public ApplicationAddCreditCardProduct organization(String organization) {
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

  public ApplicationAddCreditCardProduct logo(String logo) {
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

  public ApplicationAddCreditCardProduct requestCreditShield(Boolean requestCreditShield) {
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

  public ApplicationAddCreditCardProduct embossName(String embossName) {
    this.embossName = embossName;
    return this;
  }

   /**
   * Name to be embossed on card.If blank, bank will assign automatically based on the market norms.
   * @return embossName
  **/
  @Schema(example = "Matthew Hyden", description = "Name to be embossed on card.If blank, bank will assign automatically based on the market norms.")
  public String getEmbossName() {
    return embossName;
  }

  public void setEmbossName(String embossName) {
    this.embossName = embossName;
  }

  public ApplicationAddCreditCardProduct billingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
    return this;
  }

   /**
   * Billing address of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field as the referenceCode parameter to retrieve the values.
   * @return billingAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Billing address of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field as the referenceCode parameter to retrieve the values.")
  public String getBillingAddress() {
    return billingAddress;
  }

  public void setBillingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
  }

  public ApplicationAddCreditCardProduct cardDeliveryAddress(String cardDeliveryAddress) {
    this.cardDeliveryAddress = cardDeliveryAddress;
    return this;
  }

   /**
   * Card delivery address of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
   * @return cardDeliveryAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Card delivery address of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.")
  public String getCardDeliveryAddress() {
    return cardDeliveryAddress;
  }

  public void setCardDeliveryAddress(String cardDeliveryAddress) {
    this.cardDeliveryAddress = cardDeliveryAddress;
  }

  public ApplicationAddCreditCardProduct pinDeliveryAddress(String pinDeliveryAddress) {
    this.pinDeliveryAddress = pinDeliveryAddress;
    return this;
  }

   /**
   * Delivery address  for card pin of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
   * @return pinDeliveryAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Delivery address  for card pin of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.")
  public String getPinDeliveryAddress() {
    return pinDeliveryAddress;
  }

  public void setPinDeliveryAddress(String pinDeliveryAddress) {
    this.pinDeliveryAddress = pinDeliveryAddress;
  }

  public ApplicationAddCreditCardProduct giftCode(String giftCode) {
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

  public ApplicationAddCreditCardProduct creditLimitIncreaseIndicator(Boolean creditLimitIncreaseIndicator) {
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


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddCreditCardProduct applicationAddCreditCardProduct = (ApplicationAddCreditCardProduct) o;
    return Objects.equals(this.productCode, applicationAddCreditCardProduct.productCode) &&
        Objects.equals(this.sourceCode, applicationAddCreditCardProduct.sourceCode) &&
        Objects.equals(this.organization, applicationAddCreditCardProduct.organization) &&
        Objects.equals(this.logo, applicationAddCreditCardProduct.logo) &&
        Objects.equals(this.requestCreditShield, applicationAddCreditCardProduct.requestCreditShield) &&
        Objects.equals(this.embossName, applicationAddCreditCardProduct.embossName) &&
        Objects.equals(this.billingAddress, applicationAddCreditCardProduct.billingAddress) &&
        Objects.equals(this.cardDeliveryAddress, applicationAddCreditCardProduct.cardDeliveryAddress) &&
        Objects.equals(this.pinDeliveryAddress, applicationAddCreditCardProduct.pinDeliveryAddress) &&
        Objects.equals(this.giftCode, applicationAddCreditCardProduct.giftCode) &&
        Objects.equals(this.creditLimitIncreaseIndicator, applicationAddCreditCardProduct.creditLimitIncreaseIndicator);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, sourceCode, organization, logo, requestCreditShield, embossName, billingAddress, cardDeliveryAddress, pinDeliveryAddress, giftCode, creditLimitIncreaseIndicator);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddCreditCardProduct {\n");
    
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