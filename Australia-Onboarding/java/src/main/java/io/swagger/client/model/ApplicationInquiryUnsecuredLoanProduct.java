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
 * ApplicationInquiryUnsecuredLoanProduct
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationInquiryUnsecuredLoanProduct {
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

  @SerializedName("billingAddress")
  private String billingAddress = null;

  @SerializedName("giftCode")
  private String giftCode = null;

  @SerializedName("requestedLoanAmount")
  private Double requestedLoanAmount = null;

  @SerializedName("tenor")
  private String tenor = null;

  public ApplicationInquiryUnsecuredLoanProduct productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "VC001", required = true, description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public ApplicationInquiryUnsecuredLoanProduct sourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
    return this;
  }

   /**
   * A source code to identify the product
   * @return sourceCode
  **/
  @Schema(example = "S1N7QYDC", required = true, description = "A source code to identify the product")
  public String getSourceCode() {
    return sourceCode;
  }

  public void setSourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
  }

  public ApplicationInquiryUnsecuredLoanProduct organization(String organization) {
    this.organization = organization;
    return this;
  }

   /**
   * Card issuing Organisation code
   * @return organization
  **/
  @Schema(example = "111", required = true, description = "Card issuing Organisation code")
  public String getOrganization() {
    return organization;
  }

  public void setOrganization(String organization) {
    this.organization = organization;
  }

  public ApplicationInquiryUnsecuredLoanProduct logo(String logo) {
    this.logo = logo;
    return this;
  }

   /**
   * Product logo to identify the product
   * @return logo
  **/
  @Schema(example = "001", required = true, description = "Product logo to identify the product")
  public String getLogo() {
    return logo;
  }

  public void setLogo(String logo) {
    this.logo = logo;
  }

  public ApplicationInquiryUnsecuredLoanProduct requestCreditShield(Boolean requestCreditShield) {
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

  public ApplicationInquiryUnsecuredLoanProduct billingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
    return this;
  }

   /**
   * Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
   * @return billingAddress
  **/
  @Schema(example = "LEGAL_OR_RESIDENTIAL_ADDRESS", description = "Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.")
  public String getBillingAddress() {
    return billingAddress;
  }

  public void setBillingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
  }

  public ApplicationInquiryUnsecuredLoanProduct giftCode(String giftCode) {
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

  public ApplicationInquiryUnsecuredLoanProduct requestedLoanAmount(Double requestedLoanAmount) {
    this.requestedLoanAmount = requestedLoanAmount;
    return this;
  }

   /**
   * Requested loan amount
   * @return requestedLoanAmount
  **/
  @Schema(example = "5500.25", description = "Requested loan amount")
  public Double getRequestedLoanAmount() {
    return requestedLoanAmount;
  }

  public void setRequestedLoanAmount(Double requestedLoanAmount) {
    this.requestedLoanAmount = requestedLoanAmount;
  }

  public ApplicationInquiryUnsecuredLoanProduct tenor(String tenor) {
    this.tenor = tenor;
    return this;
  }

   /**
   * Tenure of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. You can use tenor field name as the referenceCode parameter to retrieve the values.
   * @return tenor
  **/
  @Schema(example = "36_MONTHS", description = "Tenure of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. You can use tenor field name as the referenceCode parameter to retrieve the values.")
  public String getTenor() {
    return tenor;
  }

  public void setTenor(String tenor) {
    this.tenor = tenor;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationInquiryUnsecuredLoanProduct applicationInquiryUnsecuredLoanProduct = (ApplicationInquiryUnsecuredLoanProduct) o;
    return Objects.equals(this.productCode, applicationInquiryUnsecuredLoanProduct.productCode) &&
        Objects.equals(this.sourceCode, applicationInquiryUnsecuredLoanProduct.sourceCode) &&
        Objects.equals(this.organization, applicationInquiryUnsecuredLoanProduct.organization) &&
        Objects.equals(this.logo, applicationInquiryUnsecuredLoanProduct.logo) &&
        Objects.equals(this.requestCreditShield, applicationInquiryUnsecuredLoanProduct.requestCreditShield) &&
        Objects.equals(this.billingAddress, applicationInquiryUnsecuredLoanProduct.billingAddress) &&
        Objects.equals(this.giftCode, applicationInquiryUnsecuredLoanProduct.giftCode) &&
        Objects.equals(this.requestedLoanAmount, applicationInquiryUnsecuredLoanProduct.requestedLoanAmount) &&
        Objects.equals(this.tenor, applicationInquiryUnsecuredLoanProduct.tenor);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, sourceCode, organization, logo, requestCreditShield, billingAddress, giftCode, requestedLoanAmount, tenor);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationInquiryUnsecuredLoanProduct {\n");
    
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    sourceCode: ").append(toIndentedString(sourceCode)).append("\n");
    sb.append("    organization: ").append(toIndentedString(organization)).append("\n");
    sb.append("    logo: ").append(toIndentedString(logo)).append("\n");
    sb.append("    requestCreditShield: ").append(toIndentedString(requestCreditShield)).append("\n");
    sb.append("    billingAddress: ").append(toIndentedString(billingAddress)).append("\n");
    sb.append("    giftCode: ").append(toIndentedString(giftCode)).append("\n");
    sb.append("    requestedLoanAmount: ").append(toIndentedString(requestedLoanAmount)).append("\n");
    sb.append("    tenor: ").append(toIndentedString(tenor)).append("\n");
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
