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
 * RequiredDocuments
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class RequiredDocuments {
  @SerializedName("documentIdType")
  private String documentIdType = null;

  @SerializedName("documentStatus")
  private String documentStatus = null;

  @SerializedName("productCode")
  private String productCode = null;

  @SerializedName("proofType")
  private String proofType = null;

  @SerializedName("linkedDocumentId")
  private String linkedDocumentId = null;

  @SerializedName("applicantType")
  private String applicantType = null;

  public RequiredDocuments documentIdType(String documentIdType) {
    this.documentIdType = documentIdType;
    return this;
  }

   /**
   * Document ID for each proof. This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentIdType} resource to get valid values of this field with descriptions.You can use the documentIdType as the referenceCode parameter to retrieve the values.
   * @return documentIdType
  **/
  @Schema(example = "PAYSLIP", description = "Document ID for each proof. This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentIdType} resource to get valid values of this field with descriptions.You can use the documentIdType as the referenceCode parameter to retrieve the values.")
  public String getDocumentIdType() {
    return documentIdType;
  }

  public void setDocumentIdType(String documentIdType) {
    this.documentIdType = documentIdType;
  }

  public RequiredDocuments documentStatus(String documentStatus) {
    this.documentStatus = documentStatus;
    return this;
  }

   /**
   * Status of document ID proof. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{documentStatus} resource to get valid values of this field with descriptions
   * @return documentStatus
  **/
  @Schema(example = "SUBMITTED", description = "Status of document ID proof. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{documentStatus} resource to get valid values of this field with descriptions")
  public String getDocumentStatus() {
    return documentStatus;
  }

  public void setDocumentStatus(String documentStatus) {
    this.documentStatus = documentStatus;
  }

  public RequiredDocuments productCode(String productCode) {
    this.productCode = productCode;
    return this;
  }

   /**
   * A unique code that identifies the product
   * @return productCode
  **/
  @Schema(example = "VC830", description = "A unique code that identifies the product")
  public String getProductCode() {
    return productCode;
  }

  public void setProductCode(String productCode) {
    this.productCode = productCode;
  }

  public RequiredDocuments proofType(String proofType) {
    this.proofType = proofType;
    return this;
  }

   /**
   * Type of document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions.You can use the proofType as the referenceCode parameter to retrieve the values.
   * @return proofType
  **/
  @Schema(example = "INCOME_PROOF", description = "Type of document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions.You can use the proofType as the referenceCode parameter to retrieve the values.")
  public String getProofType() {
    return proofType;
  }

  public void setProofType(String proofType) {
    this.proofType = proofType;
  }

  public RequiredDocuments linkedDocumentId(String linkedDocumentId) {
    this.linkedDocumentId = linkedDocumentId;
    return this;
  }

   /**
   * Linked document id is used to link different documents for the required documents/proof type.
   * @return linkedDocumentId
  **/
  @Schema(example = "02", description = "Linked document id is used to link different documents for the required documents/proof type.")
  public String getLinkedDocumentId() {
    return linkedDocumentId;
  }

  public void setLinkedDocumentId(String linkedDocumentId) {
    this.linkedDocumentId = linkedDocumentId;
  }

  public RequiredDocuments applicantType(String applicantType) {
    this.applicantType = applicantType;
    return this;
  }

   /**
   * Applicant relationship with the Bank. Currently supported value is primary.This is a reference data data field. Please use /v1/apac/utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions
   * @return applicantType
  **/
  @Schema(example = "PRIMARY_APPLICANT_MAIN_APPLICANT", description = "Applicant relationship with the Bank. Currently supported value is primary.This is a reference data data field. Please use /v1/apac/utilities/referenceData/{applicantType} resource to get valid values of this field with descriptions")
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
    RequiredDocuments requiredDocuments = (RequiredDocuments) o;
    return Objects.equals(this.documentIdType, requiredDocuments.documentIdType) &&
        Objects.equals(this.documentStatus, requiredDocuments.documentStatus) &&
        Objects.equals(this.productCode, requiredDocuments.productCode) &&
        Objects.equals(this.proofType, requiredDocuments.proofType) &&
        Objects.equals(this.linkedDocumentId, requiredDocuments.linkedDocumentId) &&
        Objects.equals(this.applicantType, requiredDocuments.applicantType);
  }

  @Override
  public int hashCode() {
    return Objects.hash(documentIdType, documentStatus, productCode, proofType, linkedDocumentId, applicantType);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RequiredDocuments {\n");
    
    sb.append("    documentIdType: ").append(toIndentedString(documentIdType)).append("\n");
    sb.append("    documentStatus: ").append(toIndentedString(documentStatus)).append("\n");
    sb.append("    productCode: ").append(toIndentedString(productCode)).append("\n");
    sb.append("    proofType: ").append(toIndentedString(proofType)).append("\n");
    sb.append("    linkedDocumentId: ").append(toIndentedString(linkedDocumentId)).append("\n");
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