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
import org.threeten.bp.LocalDate;
/**
 * Product
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class Product {
  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("productDescription")
  private String productDescription = null;

  @SerializedName("sourceCode")
  private String sourceCode = null;

  @SerializedName("logo")
  private String logo = null;

  @SerializedName("organisation")
  private String organisation = null;

  @SerializedName("productType")
  private String productType = null;

  @SerializedName("minimumCreditLimitAmount")
  private Double minimumCreditLimitAmount = null;

  @SerializedName("maximumCreditLimitAmount")
  private Double maximumCreditLimitAmount = null;

  @SerializedName("annualFeeAmount")
  private Double annualFeeAmount = null;

  @SerializedName("currencyCode")
  private String currencyCode = null;

  @SerializedName("interestRate")
  private Double interestRate = null;

  @SerializedName("latePaymentFee")
  private Double latePaymentFee = null;

  @SerializedName("importantInformations")
  private String importantInformations = null;

  @SerializedName("termsAndConditions")
  private String termsAndConditions = null;

  @SerializedName("agreementStartDate")
  private LocalDate agreementStartDate = null;

  @SerializedName("agreementExpiryDate")
  private LocalDate agreementExpiryDate = null;

  public Product productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product.
   * @return productCode
  **/
  @Schema(example = "VC380", required = true, description = "A unique code that identifies the product.")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public Product productDescription(String productDescription) {
    this.productDescription = productDescription;
    return this;
  }

   /**
   * Detailed information about offered product
   * @return productDescription
  **/
  @Schema(example = "Citibank SMRT Visa Card", required = true, description = "Detailed information about offered product")
  public String getProductDescription() {
    return productDescription;
  }

  public void setProductDescription(String productDescription) {
    this.productDescription = productDescription;
  }

  public Product sourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
    return this;
  }

   /**
   * A source code to identify the product.
   * @return sourceCode
  **/
  @Schema(example = "WW5ARCE1", required = true, description = "A source code to identify the product.")
  public String getSourceCode() {
    return sourceCode;
  }

  public void setSourceCode(String sourceCode) {
    this.sourceCode = sourceCode;
  }

  public Product logo(String logo) {
    this.logo = logo;
    return this;
  }

   /**
   * Logo to identify the product.
   * @return logo
  **/
  @Schema(example = "830", description = "Logo to identify the product.")
  public String getLogo() {
    return logo;
  }

  public void setLogo(String logo) {
    this.logo = logo;
  }

  public Product organisation(String organisation) {
    this.organisation = organisation;
    return this;
  }

   /**
   * Card issuing organization name
   * @return organisation
  **/
  @Schema(example = "888", description = "Card issuing organization name")
  public String getOrganisation() {
    return organisation;
  }

  public void setOrganisation(String organisation) {
    this.organisation = organisation;
  }

  public Product productType(String productType) {
    this.productType = productType;
    return this;
  }

   /**
   * Type of the product.This is a reference data field. Please use /v1/apac/utilities/referenceData/{productType} resource to get valid values of this field with descriptions.
   * @return productType
  **/
  @Schema(example = "CC", required = true, description = "Type of the product.This is a reference data field. Please use /v1/apac/utilities/referenceData/{productType} resource to get valid values of this field with descriptions.")
  public String getProductType() {
    return productType;
  }

  public void setProductType(String productType) {
    this.productType = productType;
  }

  public Product minimumCreditLimitAmount(Double minimumCreditLimitAmount) {
    this.minimumCreditLimitAmount = minimumCreditLimitAmount;
    return this;
  }

   /**
   * Minimum credit limit amount for the product type
   * @return minimumCreditLimitAmount
  **/
  @Schema(example = "5000.25", required = true, description = "Minimum credit limit amount for the product type")
  public Double getMinimumCreditLimitAmount() {
    return minimumCreditLimitAmount;
  }

  public void setMinimumCreditLimitAmount(Double minimumCreditLimitAmount) {
    this.minimumCreditLimitAmount = minimumCreditLimitAmount;
  }

  public Product maximumCreditLimitAmount(Double maximumCreditLimitAmount) {
    this.maximumCreditLimitAmount = maximumCreditLimitAmount;
    return this;
  }

   /**
   * Maximum credit limit amount for the product type
   * @return maximumCreditLimitAmount
  **/
  @Schema(example = "10000.25", required = true, description = "Maximum credit limit amount for the product type")
  public Double getMaximumCreditLimitAmount() {
    return maximumCreditLimitAmount;
  }

  public void setMaximumCreditLimitAmount(Double maximumCreditLimitAmount) {
    this.maximumCreditLimitAmount = maximumCreditLimitAmount;
  }

  public Product annualFeeAmount(Double annualFeeAmount) {
    this.annualFeeAmount = annualFeeAmount;
    return this;
  }

   /**
   * Annual fees for product type and source code
   * @return annualFeeAmount
  **/
  @Schema(example = "100.25", description = "Annual fees for product type and source code")
  public Double getAnnualFeeAmount() {
    return annualFeeAmount;
  }

  public void setAnnualFeeAmount(Double annualFeeAmount) {
    this.annualFeeAmount = annualFeeAmount;
  }

  public Product currencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
    return this;
  }

   /**
   * The currency code in ISO 4217 format
   * @return currencyCode
  **/
  @Schema(example = "SGD", required = true, description = "The currency code in ISO 4217 format")
  public String getCurrencyCode() {
    return currencyCode;
  }

  public void setCurrencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
  }

  public Product interestRate(Double interestRate) {
    this.interestRate = interestRate;
    return this;
  }

   /**
   * Annual interest rate
   * @return interestRate
  **/
  @Schema(example = "28.25", required = true, description = "Annual interest rate")
  public Double getInterestRate() {
    return interestRate;
  }

  public void setInterestRate(Double interestRate) {
    this.interestRate = interestRate;
  }

  public Product latePaymentFee(Double latePaymentFee) {
    this.latePaymentFee = latePaymentFee;
    return this;
  }

   /**
   * Late payment fee for the product type and source code
   * @return latePaymentFee
  **/
  @Schema(example = "150.25", required = true, description = "Late payment fee for the product type and source code")
  public Double getLatePaymentFee() {
    return latePaymentFee;
  }

  public void setLatePaymentFee(Double latePaymentFee) {
    this.latePaymentFee = latePaymentFee;
  }

  public Product importantInformations(String importantInformations) {
    this.importantInformations = importantInformations;
    return this;
  }

   /**
   * Important informations to know about the product type
   * @return importantInformations
  **/
  @Schema(example = "All Rewards are subject to the terms and conditions of the Citibank Rewards Program.", required = true, description = "Important informations to know about the product type")
  public String getImportantInformations() {
    return importantInformations;
  }

  public void setImportantInformations(String importantInformations) {
    this.importantInformations = importantInformations;
  }

  public Product termsAndConditions(String termsAndConditions) {
    this.termsAndConditions = termsAndConditions;
    return this;
  }

   /**
   * Fees, charges and credit criteria apply. Terms and conditions apply and are available upon request. Cards are offered, issued and administered by Citigroup Pty Limited.Allow up to 15 working days to process your Application subject to verification.
   * @return termsAndConditions
  **/
  @Schema(example = "Terms and conditions", required = true, description = "Fees, charges and credit criteria apply. Terms and conditions apply and are available upon request. Cards are offered, issued and administered by Citigroup Pty Limited.Allow up to 15 working days to process your Application subject to verification.")
  public String getTermsAndConditions() {
    return termsAndConditions;
  }

  public void setTermsAndConditions(String termsAndConditions) {
    this.termsAndConditions = termsAndConditions;
  }

  public Product agreementStartDate(LocalDate agreementStartDate) {
    this.agreementStartDate = agreementStartDate;
    return this;
  }

   /**
   * Product validity start date in ISO 8601 date format YYYY-MM-DD
   * @return agreementStartDate
  **/
  @Schema(example = "Mon Oct 10 00:00:00 UTC 2016", required = true, description = "Product validity start date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getAgreementStartDate() {
    return agreementStartDate;
  }

  public void setAgreementStartDate(LocalDate agreementStartDate) {
    this.agreementStartDate = agreementStartDate;
  }

  public Product agreementExpiryDate(LocalDate agreementExpiryDate) {
    this.agreementExpiryDate = agreementExpiryDate;
    return this;
  }

   /**
   * Product validity expiry date in ISO 8601 date format YYYY-MM-DD
   * @return agreementExpiryDate
  **/
  @Schema(example = "Mon Dec 10 00:00:00 UTC 2018", required = true, description = "Product validity expiry date in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getAgreementExpiryDate() {
    return agreementExpiryDate;
  }

  public void setAgreementExpiryDate(LocalDate agreementExpiryDate) {
    this.agreementExpiryDate = agreementExpiryDate;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Product product = (Product) o;
    return Objects.equals(this.productCode, product.productCode) &&
        Objects.equals(this.productDescription, product.productDescription) &&
        Objects.equals(this.sourceCode, product.sourceCode) &&
        Objects.equals(this.logo, product.logo) &&
        Objects.equals(this.organisation, product.organisation) &&
        Objects.equals(this.productType, product.productType) &&
        Objects.equals(this.minimumCreditLimitAmount, product.minimumCreditLimitAmount) &&
        Objects.equals(this.maximumCreditLimitAmount, product.maximumCreditLimitAmount) &&
        Objects.equals(this.annualFeeAmount, product.annualFeeAmount) &&
        Objects.equals(this.currencyCode, product.currencyCode) &&
        Objects.equals(this.interestRate, product.interestRate) &&
        Objects.equals(this.latePaymentFee, product.latePaymentFee) &&
        Objects.equals(this.importantInformations, product.importantInformations) &&
        Objects.equals(this.termsAndConditions, product.termsAndConditions) &&
        Objects.equals(this.agreementStartDate, product.agreementStartDate) &&
        Objects.equals(this.agreementExpiryDate, product.agreementExpiryDate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, productDescription, sourceCode, logo, organisation, productType, minimumCreditLimitAmount, maximumCreditLimitAmount, annualFeeAmount, currencyCode, interestRate, latePaymentFee, importantInformations, termsAndConditions, agreementStartDate, agreementExpiryDate);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Product {\n");
    
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    productDescription: ").append(toIndentedString(productDescription)).append("\n");
    sb.append("    sourceCode: ").append(toIndentedString(sourceCode)).append("\n");
    sb.append("    logo: ").append(toIndentedString(logo)).append("\n");
    sb.append("    organisation: ").append(toIndentedString(organisation)).append("\n");
    sb.append("    productType: ").append(toIndentedString(productType)).append("\n");
    sb.append("    minimumCreditLimitAmount: ").append(toIndentedString(minimumCreditLimitAmount)).append("\n");
    sb.append("    maximumCreditLimitAmount: ").append(toIndentedString(maximumCreditLimitAmount)).append("\n");
    sb.append("    annualFeeAmount: ").append(toIndentedString(annualFeeAmount)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
    sb.append("    interestRate: ").append(toIndentedString(interestRate)).append("\n");
    sb.append("    latePaymentFee: ").append(toIndentedString(latePaymentFee)).append("\n");
    sb.append("    importantInformations: ").append(toIndentedString(importantInformations)).append("\n");
    sb.append("    termsAndConditions: ").append(toIndentedString(termsAndConditions)).append("\n");
    sb.append("    agreementStartDate: ").append(toIndentedString(agreementStartDate)).append("\n");
    sb.append("    agreementExpiryDate: ").append(toIndentedString(agreementExpiryDate)).append("\n");
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