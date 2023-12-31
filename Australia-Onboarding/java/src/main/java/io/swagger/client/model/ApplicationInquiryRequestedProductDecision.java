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
import io.swagger.client.model.ApplicationInquiryCreditSpecificRecommendations;
import io.swagger.client.model.ApplicationInquiryLoanSpecificRecommendations;
import io.swagger.client.model.ApplicationInquiryRequiredDocuments;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * ApplicationInquiryRequestedProductDecision
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationInquiryRequestedProductDecision {
  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("organisationName")
  private String organisationName = null;

  @SerializedName("sourceCode")
  private String sourceCode = null;

  @SerializedName("logo")
  private String logo = null;

  @SerializedName("creditDecision")
  private String creditDecision = null;

  @SerializedName("creditSpecificRecommendations")
  private List<ApplicationInquiryCreditSpecificRecommendations> creditSpecificRecommendations = null;

  @SerializedName("loanSpecificRecommendations")
  private List<ApplicationInquiryLoanSpecificRecommendations> loanSpecificRecommendations = null;

  @SerializedName("requiredDocuments")
  private List<ApplicationInquiryRequiredDocuments> requiredDocuments = null;

  public ApplicationInquiryRequestedProductDecision productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "VC830", required = true, description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public ApplicationInquiryRequestedProductDecision organisationName(String organisationName) {
    this.organisationName = organisationName;
    return this;
  }

   /**
   * Card issuing Organisation code
   * @return organisationName
  **/
  @Schema(example = "888", required = true, description = "Card issuing Organisation code")
  public String getOrganisationName() {
    return organisationName;
  }

  public void setOrganisationName(String organisationName) {
    this.organisationName = organisationName;
  }

  public ApplicationInquiryRequestedProductDecision sourceCode(String sourceCode) {
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

  public ApplicationInquiryRequestedProductDecision logo(String logo) {
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

  public ApplicationInquiryRequestedProductDecision creditDecision(String creditDecision) {
    this.creditDecision = creditDecision;
    return this;
  }

   /**
   * Evaluated Applicant Credit Decision
   * @return creditDecision
  **/
  @Schema(example = "IN_PRINCIPAL_PARTIAL_APPROVED", description = "Evaluated Applicant Credit Decision")
  public String getCreditDecision() {
    return creditDecision;
  }

  public void setCreditDecision(String creditDecision) {
    this.creditDecision = creditDecision;
  }

  public ApplicationInquiryRequestedProductDecision creditSpecificRecommendations(List<ApplicationInquiryCreditSpecificRecommendations> creditSpecificRecommendations) {
    this.creditSpecificRecommendations = creditSpecificRecommendations;
    return this;
  }

  public ApplicationInquiryRequestedProductDecision addCreditSpecificRecommendationsItem(ApplicationInquiryCreditSpecificRecommendations creditSpecificRecommendationsItem) {
    if (this.creditSpecificRecommendations == null) {
      this.creditSpecificRecommendations = new ArrayList<ApplicationInquiryCreditSpecificRecommendations>();
    }
    this.creditSpecificRecommendations.add(creditSpecificRecommendationsItem);
    return this;
  }

   /**
   * Get creditSpecificRecommendations
   * @return creditSpecificRecommendations
  **/
  @Schema(description = "")
  public List<ApplicationInquiryCreditSpecificRecommendations> getCreditSpecificRecommendations() {
    return creditSpecificRecommendations;
  }

  public void setCreditSpecificRecommendations(List<ApplicationInquiryCreditSpecificRecommendations> creditSpecificRecommendations) {
    this.creditSpecificRecommendations = creditSpecificRecommendations;
  }

  public ApplicationInquiryRequestedProductDecision loanSpecificRecommendations(List<ApplicationInquiryLoanSpecificRecommendations> loanSpecificRecommendations) {
    this.loanSpecificRecommendations = loanSpecificRecommendations;
    return this;
  }

  public ApplicationInquiryRequestedProductDecision addLoanSpecificRecommendationsItem(ApplicationInquiryLoanSpecificRecommendations loanSpecificRecommendationsItem) {
    if (this.loanSpecificRecommendations == null) {
      this.loanSpecificRecommendations = new ArrayList<ApplicationInquiryLoanSpecificRecommendations>();
    }
    this.loanSpecificRecommendations.add(loanSpecificRecommendationsItem);
    return this;
  }

   /**
   * Get loanSpecificRecommendations
   * @return loanSpecificRecommendations
  **/
  @Schema(description = "")
  public List<ApplicationInquiryLoanSpecificRecommendations> getLoanSpecificRecommendations() {
    return loanSpecificRecommendations;
  }

  public void setLoanSpecificRecommendations(List<ApplicationInquiryLoanSpecificRecommendations> loanSpecificRecommendations) {
    this.loanSpecificRecommendations = loanSpecificRecommendations;
  }

  public ApplicationInquiryRequestedProductDecision requiredDocuments(List<ApplicationInquiryRequiredDocuments> requiredDocuments) {
    this.requiredDocuments = requiredDocuments;
    return this;
  }

  public ApplicationInquiryRequestedProductDecision addRequiredDocumentsItem(ApplicationInquiryRequiredDocuments requiredDocumentsItem) {
    if (this.requiredDocuments == null) {
      this.requiredDocuments = new ArrayList<ApplicationInquiryRequiredDocuments>();
    }
    this.requiredDocuments.add(requiredDocumentsItem);
    return this;
  }

   /**
   * Get requiredDocuments
   * @return requiredDocuments
  **/
  @Schema(description = "")
  public List<ApplicationInquiryRequiredDocuments> getRequiredDocuments() {
    return requiredDocuments;
  }

  public void setRequiredDocuments(List<ApplicationInquiryRequiredDocuments> requiredDocuments) {
    this.requiredDocuments = requiredDocuments;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationInquiryRequestedProductDecision applicationInquiryRequestedProductDecision = (ApplicationInquiryRequestedProductDecision) o;
    return Objects.equals(this.productCode, applicationInquiryRequestedProductDecision.productCode) &&
        Objects.equals(this.organisationName, applicationInquiryRequestedProductDecision.organisationName) &&
        Objects.equals(this.sourceCode, applicationInquiryRequestedProductDecision.sourceCode) &&
        Objects.equals(this.logo, applicationInquiryRequestedProductDecision.logo) &&
        Objects.equals(this.creditDecision, applicationInquiryRequestedProductDecision.creditDecision) &&
        Objects.equals(this.creditSpecificRecommendations, applicationInquiryRequestedProductDecision.creditSpecificRecommendations) &&
        Objects.equals(this.loanSpecificRecommendations, applicationInquiryRequestedProductDecision.loanSpecificRecommendations) &&
        Objects.equals(this.requiredDocuments, applicationInquiryRequestedProductDecision.requiredDocuments);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productCode, organisationName, sourceCode, logo, creditDecision, creditSpecificRecommendations, loanSpecificRecommendations, requiredDocuments);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationInquiryRequestedProductDecision {\n");
    
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    organisationName: ").append(toIndentedString(organisationName)).append("\n");
    sb.append("    sourceCode: ").append(toIndentedString(sourceCode)).append("\n");
    sb.append("    logo: ").append(toIndentedString(logo)).append("\n");
    sb.append("    creditDecision: ").append(toIndentedString(creditDecision)).append("\n");
    sb.append("    creditSpecificRecommendations: ").append(toIndentedString(creditSpecificRecommendations)).append("\n");
    sb.append("    loanSpecificRecommendations: ").append(toIndentedString(loanSpecificRecommendations)).append("\n");
    sb.append("    requiredDocuments: ").append(toIndentedString(requiredDocuments)).append("\n");
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
