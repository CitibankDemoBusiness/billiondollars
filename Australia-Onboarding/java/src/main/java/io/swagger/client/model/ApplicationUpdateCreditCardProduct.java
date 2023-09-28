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
import io.swagger.client.model.ApplicationUpdateBalanceTransferDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * ApplicationUpdateCreditCardProduct
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationUpdateCreditCardProduct {
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

  @SerializedName("balanceTransferDetails")
  private List<ApplicationUpdateBalanceTransferDetails> balanceTransferDetails = null;

  public ApplicationUpdateCreditCardProduct productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product.
   * @return productCode
  **/
  @Schema(example = "VC830", description = "A unique code that identifies the product.")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public ApplicationUpdateCreditCardProduct sourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
    return this;
  }

   /**
   * A source code to identify the product
   * @return sourceCode
  **/
  @Schema(example = "WW5ARCE1", description = "A source code to identify the product")
  public String getSourceCode() {
    return sourceCode;
  }

  public void setSourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
  }

  public ApplicationUpdateCreditCardProduct organization(String organization) {
    this.organization = organization;
    return this;
  }

   /**
   * Card issuing organization name
   * @return organization
  **/
  @Schema(example = "888", description = "Card issuing organization name")
  public String getOrganization() {
    return organization;
  }

  public void setOrganization(String organization) {
    this.organization = organization;
  }

  public ApplicationUpdateCreditCardProduct logo(String logo) {
    this.logo = logo;
    return this;
  }

   /**
   * Product logo to identify the product
   * @return logo
  **/
  @Schema(example = "830", description = "Product logo to identify the product")
  public String getLogo() {
    return logo;
  }

  public void setLogo(String logo) {
    this.logo = logo;
  }

  public ApplicationUpdateCreditCardProduct requestCreditShield(Boolean requestCreditShield) {
    this.requestCreditShield = requestCreditShield;
    return this;
  }

   /**
   * Insurance enrolment for outstanding balance on the card. Valid values: true and false
   * @return requestCreditShield
  **/
  @Schema(example = "true", description = "Insurance enrolment for outstanding balance on the card. Valid values: true and false")
  public Boolean isRequestCreditShield() {
    return requestCreditShield;
  }

  public void setRequestCreditShield(Boolean requestCreditShield) {
    this.requestCreditShield = requestCreditShield;
  }

  public ApplicationUpdateCreditCardProduct embossName(String embossName) {
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

  public ApplicationUpdateCreditCardProduct billingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
    return this;
  }

   /**
   * Billing address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
   * @return billingAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Billing address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.")
  public String getBillingAddress() {
    return billingAddress;
  }

  public void setBillingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
  }

  public ApplicationUpdateCreditCardProduct cardDeliveryAddress(String cardDeliveryAddress) {
    this.cardDeliveryAddress = cardDeliveryAddress;
    return this;
  }

   /**
   * Card delivery address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
   * @return cardDeliveryAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Card delivery address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.")
  public String getCardDeliveryAddress() {
    return cardDeliveryAddress;
  }

  public void setCardDeliveryAddress(String cardDeliveryAddress) {
    this.cardDeliveryAddress = cardDeliveryAddress;
  }

  public ApplicationUpdateCreditCardProduct pinDeliveryAddress(String pinDeliveryAddress) {
    this.pinDeliveryAddress = pinDeliveryAddress;
    return this;
  }

   /**
   * Delivery address  for card pin of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
   * @return pinDeliveryAddress
  **/
  @Schema(example = "HOME_ADDRESS", description = "Delivery address  for card pin of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.")
  public String getPinDeliveryAddress() {
    return pinDeliveryAddress;
  }

  public void setPinDeliveryAddress(String pinDeliveryAddress) {
    this.pinDeliveryAddress = pinDeliveryAddress;
  }

  public ApplicationUpdateCreditCardProduct giftCode(String giftCode) {
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

  public ApplicationUpdateCreditCardProduct creditLimitIncreaseIndicator(Boolean creditLimitIncreaseIndicator) {
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

  public ApplicationUpdateCreditCardProduct balanceTransferDetails(List<ApplicationUpdateBalanceTransferDetails> balanceTransferDetails) {
    this.balanceTransferDetails = balanceTransferDetails;
    return this;
  }

  public ApplicationUpdateCreditCardProduct addBalanceTransferDetailsItem(ApplicationUpdateBalanceTransferDetails balanceTransferDetailsItem) {
    if (this.balanceTransferDetails == null) {
      this.balanceTransferDetails = new ArrayList<ApplicationUpdateBalanceTransferDetails>();
    }
    this.balanceTransferDetails.add(balanceTransferDetailsItem);
    return this;
  }

   /**
   * Get balanceTransferDetails
   * @return balanceTransferDetails
  **/
  @Schema(description = "")
  public List<ApplicationUpdateBalanceTransferDetails> getBalanceTransferDetails() {
    return balanceTransferDetails;
  }

  public void setBalanceTransferDetails(List<ApplicationUpdateBalanceTransferDetails> balanceTransferDetails) {
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
    ApplicationUpdateCreditCardProduct applicationUpdateCreditCardProduct = (ApplicationUpdateCreditCardProduct) o;
    return Objects.equals(this.productCode, applicationUpdateCreditCardProduct.productCode) &&
        Objects.equals(this.sourceCode, applicationUpdateCreditCardProduct.sourceCode) &&
        Objects.equals(this.organization, applicationUpdateCreditCardProduct.organization) &&
        Objects.equals(this.logo, applicationUpdateCreditCardProduct.logo) &&
        Objects.equals(this.requestCreditShield, applicationUpdateCreditCardProduct.requestCreditShield) &&
        Objects.equals(this.embossName, applicationUpdateCreditCardProduct.embossName) &&
        Objects.equals(this.billingAddress, applicationUpdateCreditCardProduct.billingAddress) &&
        Objects.equals(this.cardDeliveryAddress, applicationUpdateCreditCardProduct.cardDeliveryAddress) &&
        Objects.equals(this.pinDeliveryAddress, applicationUpdateCreditCardProduct.pinDeliveryAddress) &&
        Objects.equals(this.giftCode, applicationUpdateCreditCardProduct.giftCode) &&
        Objects.equals(this.creditLimitIncreaseIndicator, applicationUpdateCreditCardProduct.creditLimitIncreaseIndicator) &&
        Objects.equals(this.balanceTransferDetails, applicationUpdateCreditCardProduct.balanceTransferDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, sourceCode, organization, logo, requestCreditShield, embossName, billingAddress, cardDeliveryAddress, pinDeliveryAddress, giftCode, creditLimitIncreaseIndicator, balanceTransferDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationUpdateCreditCardProduct {\n");
    
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