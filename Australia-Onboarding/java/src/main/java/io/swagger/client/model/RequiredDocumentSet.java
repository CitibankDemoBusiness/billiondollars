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
 * RequiredDocumentSet
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class RequiredDocumentSet {
  @SerializedName("documentSet")
  private String documentSet = null;

  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("proofType")
  private String proofType = null;

  @SerializedName("applicantType")
  private String applicantType = null;

  public RequiredDocumentSet documentSet(String documentSet) {
    this.documentSet = documentSet;
    return this;
  }

   /**
   * Document set a mandated combination of document types for each proof. This is a reference data field. Please use /v1/utilities/referenceData/{documentIdType} resource to get valid values of this field with descriptions.
   * @return documentSet
  **/
  @Schema(example = "PAYSLIP,PENSION_SLIP", description = "Document set a mandated combination of document types for each proof. This is a reference data field. Please use /v1/utilities/referenceData/{documentIdType} resource to get valid values of this field with descriptions.")
  public String getDocumentSet() {
    return documentSet;
  }

  public void setDocumentSet(String documentSet) {
    this.documentSet = documentSet;
  }

  public RequiredDocumentSet productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "830", description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public RequiredDocumentSet proofType(String proofType) {
    this.proofType = proofType;
    return this;
  }

   /**
   * Type of document. This is a reference data field. Please use /v1/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions.
   * @return proofType
  **/
  @Schema(example = "INCOME_PROOF", description = "Type of document. This is a reference data field. Please use /v1/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions.")
  public String getProofType() {
    return proofType;
  }

  public void setProofType(String proofType) {
    this.proofType = proofType;
  }

  public RequiredDocumentSet applicantType(String applicantType) {
    this.applicantType = applicantType;
    return this;
  }

   /**
   * Applicant relationship with the Bank. Currently supported value is primary.This is a reference data data field. Please use /v1/utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions
   * @return applicantType
  **/
  @Schema(example = "PRIMARY_APPLICANT", description = "Applicant relationship with the Bank. Currently supported value is primary.This is a reference data data field. Please use /v1/utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions")
  public String getApplicantType() {
    return applicantType;
  }

  public void setApplicantType(String applicantType) {
    this.applicantType = applicantType;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RequiredDocumentSet requiredDocumentSet = (RequiredDocumentSet) o;
    return Objects.equals(this.documentSet, requiredDocumentSet.documentSet) &&
        Objects.equals(this.productCode, requiredDocumentSet.productCode) &&
        Objects.equals(this.proofType, requiredDocumentSet.proofType) &&
        Objects.equals(this.applicantType, requiredDocumentSet.applicantType);
  }

  @Override
  public int hashCode() {
    return Objects.hash(documentSet, productCode, proofType, applicantType);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RequiredDocumentSet {\n");
    
    sb.append("    documentSet: ").append(toIndentedString(documentSet)).append("\n");
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    proofType: ").append(toIndentedString(proofType)).append("\n");
    sb.append("    applicantType: ").append(toIndentedString(applicantType)).append("\n");
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
