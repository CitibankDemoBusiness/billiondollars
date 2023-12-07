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
import io.swagger.client.model.LoanPaymentAccountDetails;
import io.swagger.client.model.LoanRepaymentDetails;
import io.swagger.client.model.SuggestedDisbursementAccount;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * UnsecuredLoanProduct
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class UnsecuredLoanProduct {
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

  @SerializedName("disbursementOption")
  private String disbursementOption = null;

  @SerializedName("loanPurpose")
  private String loanPurpose = null;

  @SerializedName("tenor")
  private String tenor = null;

  @SerializedName("tenor1")
  private String tenor1 = null;

  @SerializedName("penaltyScheme")
  private String penaltyScheme = null;

  @SerializedName("loanRepaymentDetails")
  private LoanRepaymentDetails loanRepaymentDetails = null;

  @SerializedName("loanPaymentAccountDetails")
  private List<LoanPaymentAccountDetails> loanPaymentAccountDetails = null;

  @SerializedName("atmPinRegistrationFlag")
  private Boolean atmPinRegistrationFlag = null;

  @SerializedName("suggestedDisbursementAccounts")
  private List<SuggestedDisbursementAccount> suggestedDisbursementAccounts = null;

  public UnsecuredLoanProduct productCode(String productCode) {
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

  public UnsecuredLoanProduct sourceCode(String sourceCode) {
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

  public UnsecuredLoanProduct organization(String organization) {
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

  public UnsecuredLoanProduct logo(String logo) {
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

  public UnsecuredLoanProduct requestCreditShield(Boolean requestCreditShield) {
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

  public UnsecuredLoanProduct billingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
    return this;
  }

   /**
   * Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.
   * @return billingAddress
  **/
  @Schema(example = "LEGAL_OR_RESIDENTIAL_ADDRESS", description = "Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description.")
  public String getBillingAddress() {
    return billingAddress;
  }

  public void setBillingAddress(String billingAddress) {
    this.billingAddress = billingAddress;
  }

  public UnsecuredLoanProduct giftCode(String giftCode) {
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

  public UnsecuredLoanProduct requestedLoanAmount(Double requestedLoanAmount) {
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

  public UnsecuredLoanProduct disbursementOption(String disbursementOption) {
    this.disbursementOption = disbursementOption;
    return this;
  }

   /**
   * Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.
   * @return disbursementOption
  **/
  @Schema(example = "BANK_ACCOUNT", description = "Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.")
  public String getDisbursementOption() {
    return disbursementOption;
  }

  public void setDisbursementOption(String disbursementOption) {
    this.disbursementOption = disbursementOption;
  }

  public UnsecuredLoanProduct loanPurpose(String loanPurpose) {
    this.loanPurpose = loanPurpose;
    return this;
  }

   /**
   * This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.
   * @return loanPurpose
  **/
  @Schema(example = "PERSONAL", description = "This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.")
  public String getLoanPurpose() {
    return loanPurpose;
  }

  public void setLoanPurpose(String loanPurpose) {
    this.loanPurpose = loanPurpose;
  }

  public UnsecuredLoanProduct tenor(String tenor) {
    this.tenor = tenor;
    return this;
  }

   /**
   * Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. You can use tenor field name as the referenceCode parameter to retrieve the values.
   * @return tenor
  **/
  @Schema(example = "36_MONTHS", description = "Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. You can use tenor field name as the referenceCode parameter to retrieve the values.")
  public String getTenor() {
    return tenor;
  }

  public void setTenor(String tenor) {
    this.tenor = tenor;
  }

  public UnsecuredLoanProduct tenor1(String tenor1) {
    this.tenor1 = tenor1;
    return this;
  }

   /**
   * This refers to the number of months of the 1st tenor. For Tiered-rate UPL , customer enjoys/ endure lower/ higher rate in the first few months.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. 
   * @return tenor1
  **/
  @Schema(example = "3_MONTHS", description = "This refers to the number of months of the 1st tenor. For Tiered-rate UPL , customer enjoys/ endure lower/ higher rate in the first few months.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. ")
  public String getTenor1() {
    return tenor1;
  }

  public void setTenor1(String tenor1) {
    this.tenor1 = tenor1;
  }

  public UnsecuredLoanProduct penaltyScheme(String penaltyScheme) {
    this.penaltyScheme = penaltyScheme;
    return this;
  }

   /**
   * This field is used to determine the penalty that will be applied to customer who do early principal repayment/loan closure.It is to be selected by the customer. This is a reference data field. Please use /v1/utilities/referenceData/{penaltyScheme} resource to get valid value of this field with description.
   * @return penaltyScheme
  **/
  @Schema(example = "NON_PENALTY_FLAT_RATE", description = "This field is used to determine the penalty that will be applied to customer who do early principal repayment/loan closure.It is to be selected by the customer. This is a reference data field. Please use /v1/utilities/referenceData/{penaltyScheme} resource to get valid value of this field with description.")
  public String getPenaltyScheme() {
    return penaltyScheme;
  }

  public void setPenaltyScheme(String penaltyScheme) {
    this.penaltyScheme = penaltyScheme;
  }

  public UnsecuredLoanProduct loanRepaymentDetails(LoanRepaymentDetails loanRepaymentDetails) {
    this.loanRepaymentDetails = loanRepaymentDetails;
    return this;
  }

   /**
   * Get loanRepaymentDetails
   * @return loanRepaymentDetails
  **/
  @Schema(description = "")
  public LoanRepaymentDetails getLoanRepaymentDetails() {
    return loanRepaymentDetails;
  }

  public void setLoanRepaymentDetails(LoanRepaymentDetails loanRepaymentDetails) {
    this.loanRepaymentDetails = loanRepaymentDetails;
  }

  public UnsecuredLoanProduct loanPaymentAccountDetails(List<LoanPaymentAccountDetails> loanPaymentAccountDetails) {
    this.loanPaymentAccountDetails = loanPaymentAccountDetails;
    return this;
  }

  public UnsecuredLoanProduct addLoanPaymentAccountDetailsItem(LoanPaymentAccountDetails loanPaymentAccountDetailsItem) {
    if (this.loanPaymentAccountDetails == null) {
      this.loanPaymentAccountDetails = new ArrayList<LoanPaymentAccountDetails>();
    }
    this.loanPaymentAccountDetails.add(loanPaymentAccountDetailsItem);
    return this;
  }

   /**
   * Get loanPaymentAccountDetails
   * @return loanPaymentAccountDetails
  **/
  @Schema(description = "")
  public List<LoanPaymentAccountDetails> getLoanPaymentAccountDetails() {
    return loanPaymentAccountDetails;
  }

  public void setLoanPaymentAccountDetails(List<LoanPaymentAccountDetails> loanPaymentAccountDetails) {
    this.loanPaymentAccountDetails = loanPaymentAccountDetails;
  }

  public UnsecuredLoanProduct atmPinRegistrationFlag(Boolean atmPinRegistrationFlag) {
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

  public UnsecuredLoanProduct suggestedDisbursementAccounts(List<SuggestedDisbursementAccount> suggestedDisbursementAccounts) {
    this.suggestedDisbursementAccounts = suggestedDisbursementAccounts;
    return this;
  }

  public UnsecuredLoanProduct addSuggestedDisbursementAccountsItem(SuggestedDisbursementAccount suggestedDisbursementAccountsItem) {
    if (this.suggestedDisbursementAccounts == null) {
      this.suggestedDisbursementAccounts = new ArrayList<SuggestedDisbursementAccount>();
    }
    this.suggestedDisbursementAccounts.add(suggestedDisbursementAccountsItem);
    return this;
  }

   /**
   * Get suggestedDisbursementAccounts
   * @return suggestedDisbursementAccounts
  **/
  @Schema(description = "")
  public List<SuggestedDisbursementAccount> getSuggestedDisbursementAccounts() {
    return suggestedDisbursementAccounts;
  }

  public void setSuggestedDisbursementAccounts(List<SuggestedDisbursementAccount> suggestedDisbursementAccounts) {
    this.suggestedDisbursementAccounts = suggestedDisbursementAccounts;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    UnsecuredLoanProduct unsecuredLoanProduct = (UnsecuredLoanProduct) o;
    return Objects.equals(this.productCode, unsecuredLoanProduct.productCode) &&
        Objects.equals(this.sourceCode, unsecuredLoanProduct.sourceCode) &&
        Objects.equals(this.organization, unsecuredLoanProduct.organization) &&
        Objects.equals(this.logo, unsecuredLoanProduct.logo) &&
        Objects.equals(this.requestCreditShield, unsecuredLoanProduct.requestCreditShield) &&
        Objects.equals(this.billingAddress, unsecuredLoanProduct.billingAddress) &&
        Objects.equals(this.giftCode, unsecuredLoanProduct.giftCode) &&
        Objects.equals(this.requestedLoanAmount, unsecuredLoanProduct.requestedLoanAmount) &&
        Objects.equals(this.disbursementOption, unsecuredLoanProduct.disbursementOption) &&
        Objects.equals(this.loanPurpose, unsecuredLoanProduct.loanPurpose) &&
        Objects.equals(this.tenor, unsecuredLoanProduct.tenor) &&
        Objects.equals(this.tenor1, unsecuredLoanProduct.tenor1) &&
        Objects.equals(this.penaltyScheme, unsecuredLoanProduct.penaltyScheme) &&
        Objects.equals(this.loanRepaymentDetails, unsecuredLoanProduct.loanRepaymentDetails) &&
        Objects.equals(this.loanPaymentAccountDetails, unsecuredLoanProduct.loanPaymentAccountDetails) &&
        Objects.equals(this.atmPinRegistrationFlag, unsecuredLoanProduct.atmPinRegistrationFlag) &&
        Objects.equals(this.suggestedDisbursementAccounts, unsecuredLoanProduct.suggestedDisbursementAccounts);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, sourceCode, organization, logo, requestCreditShield, billingAddress, giftCode, requestedLoanAmount, disbursementOption, loanPurpose, tenor, tenor1, penaltyScheme, loanRepaymentDetails, loanPaymentAccountDetails, atmPinRegistrationFlag, suggestedDisbursementAccounts);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class UnsecuredLoanProduct {\n");
    
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    sourceCode: ").append(toIndentedString(sourceCode)).append("\n");
    sb.append("    organization: ").append(toIndentedString(organization)).append("\n");
    sb.append("    logo: ").append(toIndentedString(logo)).append("\n");
    sb.append("    requestCreditShield: ").append(toIndentedString(requestCreditShield)).append("\n");
    sb.append("    billingAddress: ").append(toIndentedString(billingAddress)).append("\n");
    sb.append("    giftCode: ").append(toIndentedString(giftCode)).append("\n");
    sb.append("    requestedLoanAmount: ").append(toIndentedString(requestedLoanAmount)).append("\n");
    sb.append("    disbursementOption: ").append(toIndentedString(disbursementOption)).append("\n");
    sb.append("    loanPurpose: ").append(toIndentedString(loanPurpose)).append("\n");
    sb.append("    tenor: ").append(toIndentedString(tenor)).append("\n");
    sb.append("    tenor1: ").append(toIndentedString(tenor1)).append("\n");
    sb.append("    penaltyScheme: ").append(toIndentedString(penaltyScheme)).append("\n");
    sb.append("    loanRepaymentDetails: ").append(toIndentedString(loanRepaymentDetails)).append("\n");
    sb.append("    loanPaymentAccountDetails: ").append(toIndentedString(loanPaymentAccountDetails)).append("\n");
    sb.append("    atmPinRegistrationFlag: ").append(toIndentedString(atmPinRegistrationFlag)).append("\n");
    sb.append("    suggestedDisbursementAccounts: ").append(toIndentedString(suggestedDisbursementAccounts)).append("\n");
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
