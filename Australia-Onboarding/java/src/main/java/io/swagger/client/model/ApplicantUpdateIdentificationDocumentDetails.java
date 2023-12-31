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
 * ApplicantUpdateIdentificationDocumentDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicantUpdateIdentificationDocumentDetails {
  @SerializedName("idType")
  private String idType = null;

  @SerializedName("idNumber")
  private String idNumber = null;

  @SerializedName("idExpiryDate")
  private LocalDate idExpiryDate = null;

  @SerializedName("idIssueDate")
  private LocalDate idIssueDate = null;

  @SerializedName("idIssuePlace")
  private String idIssuePlace = null;

  @SerializedName("idIssueState")
  private String idIssueState = null;

  @SerializedName("idIssueCountry")
  private String idIssueCountry = null;

  @SerializedName("isPrimaryId")
  private Boolean isPrimaryId = null;

  public ApplicantUpdateIdentificationDocumentDetails idType(String idType) {
    this.idType = idType;
    return this;
  }

   /**
   * Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions
   * @return idType
  **/
  @Schema(example = "PASSPORT", description = "Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions")
  public String getIdType() {
    return idType;
  }

  public void setIdType(String idType) {
    this.idType = idType;
  }

  public ApplicantUpdateIdentificationDocumentDetails idNumber(String idNumber) {
    this.idNumber = idNumber;
    return this;
  }

   /**
   * Unique identifier of identification document.
   * @return idNumber
  **/
  @Schema(example = "M0992136", description = "Unique identifier of identification document.")
  public String getIdNumber() {
    return idNumber;
  }

  public void setIdNumber(String idNumber) {
    this.idNumber = idNumber;
  }

  public ApplicantUpdateIdentificationDocumentDetails idExpiryDate(LocalDate idExpiryDate) {
    this.idExpiryDate = idExpiryDate;
    return this;
  }

   /**
   * Expiry date of identification document in ISO 8601 date format YYYY-MM-DD
   * @return idExpiryDate
  **/
  @Schema(example = "Thu Feb 29 00:00:00 UTC 2024", description = "Expiry date of identification document in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getIdExpiryDate() {
    return idExpiryDate;
  }

  public void setIdExpiryDate(LocalDate idExpiryDate) {
    this.idExpiryDate = idExpiryDate;
  }

  public ApplicantUpdateIdentificationDocumentDetails idIssueDate(LocalDate idIssueDate) {
    this.idIssueDate = idIssueDate;
    return this;
  }

   /**
   * Issuance date of identification document in ISO 8601 date format YYYY-MM-DD
   * @return idIssueDate
  **/
  @Schema(example = "Sat Mar 01 00:00:00 UTC 2014", description = "Issuance date of identification document in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getIdIssueDate() {
    return idIssueDate;
  }

  public void setIdIssueDate(LocalDate idIssueDate) {
    this.idIssueDate = idIssueDate;
  }

  public ApplicantUpdateIdentificationDocumentDetails idIssuePlace(String idIssuePlace) {
    this.idIssuePlace = idIssuePlace;
    return this;
  }

   /**
   * Identification document issuance place
   * @return idIssuePlace
  **/
  @Schema(example = "Canberra", description = "Identification document issuance place")
  public String getIdIssuePlace() {
    return idIssuePlace;
  }

  public void setIdIssuePlace(String idIssuePlace) {
    this.idIssuePlace = idIssuePlace;
  }

  public ApplicantUpdateIdentificationDocumentDetails idIssueState(String idIssueState) {
    this.idIssueState = idIssueState;
    return this;
  }

   /**
   * State from which identification document was issued
   * @return idIssueState
  **/
  @Schema(example = "Canberra", description = "State from which identification document was issued")
  public String getIdIssueState() {
    return idIssueState;
  }

  public void setIdIssueState(String idIssueState) {
    this.idIssueState = idIssueState;
  }

  public ApplicantUpdateIdentificationDocumentDetails idIssueCountry(String idIssueCountry) {
    this.idIssueCountry = idIssueCountry;
    return this;
  }

   /**
   * Country of issuance. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use idIssueCountry field name as the referenceCode parameter to retrieve the values.
   * @return idIssueCountry
  **/
  @Schema(example = "AUSTRALIA", description = "Country of issuance. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use idIssueCountry field name as the referenceCode parameter to retrieve the values.")
  public String getIdIssueCountry() {
    return idIssueCountry;
  }

  public void setIdIssueCountry(String idIssueCountry) {
    this.idIssueCountry = idIssueCountry;
  }

  public ApplicantUpdateIdentificationDocumentDetails isPrimaryId(Boolean isPrimaryId) {
    this.isPrimaryId = isPrimaryId;
    return this;
  }

   /**
   * Flag to mark primary identification document. Valid values: true and false
   * @return isPrimaryId
  **/
  @Schema(example = "true", description = "Flag to mark primary identification document. Valid values: true and false")
  public Boolean isIsPrimaryId() {
    return isPrimaryId;
  }

  public void setIsPrimaryId(Boolean isPrimaryId) {
    this.isPrimaryId = isPrimaryId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicantUpdateIdentificationDocumentDetails applicantUpdateIdentificationDocumentDetails = (ApplicantUpdateIdentificationDocumentDetails) o;
    return Objects.equals(this.idType, applicantUpdateIdentificationDocumentDetails.idType) &&
        Objects.equals(this.idNumber, applicantUpdateIdentificationDocumentDetails.idNumber) &&
        Objects.equals(this.idExpiryDate, applicantUpdateIdentificationDocumentDetails.idExpiryDate) &&
        Objects.equals(this.idIssueDate, applicantUpdateIdentificationDocumentDetails.idIssueDate) &&
        Objects.equals(this.idIssuePlace, applicantUpdateIdentificationDocumentDetails.idIssuePlace) &&
        Objects.equals(this.idIssueState, applicantUpdateIdentificationDocumentDetails.idIssueState) &&
        Objects.equals(this.idIssueCountry, applicantUpdateIdentificationDocumentDetails.idIssueCountry) &&
        Objects.equals(this.isPrimaryId, applicantUpdateIdentificationDocumentDetails.isPrimaryId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(idType, idNumber, idExpiryDate, idIssueDate, idIssuePlace, idIssueState, idIssueCountry, isPrimaryId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicantUpdateIdentificationDocumentDetails {\n");
    
    sb.append("    idType: ").append(toIndentedString(idType)).append("\n");
    sb.append("    idNumber: ").append(toIndentedString(idNumber)).append("\n");
    sb.append("    idExpiryDate: ").append(toIndentedString(idExpiryDate)).append("\n");
    sb.append("    idIssueDate: ").append(toIndentedString(idIssueDate)).append("\n");
    sb.append("    idIssuePlace: ").append(toIndentedString(idIssuePlace)).append("\n");
    sb.append("    idIssueState: ").append(toIndentedString(idIssueState)).append("\n");
    sb.append("    idIssueCountry: ").append(toIndentedString(idIssueCountry)).append("\n");
    sb.append("    isPrimaryId: ").append(toIndentedString(isPrimaryId)).append("\n");
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
