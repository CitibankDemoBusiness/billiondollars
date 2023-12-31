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
 * ApplicationAddName
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddName {
  @SerializedName("salutation")
  private String salutation = null;

  @SerializedName("givenName")
  private String givenName = null;

  @SerializedName("middleName")
  private String middleName = null;

  @SerializedName("surname")
  private String surname = null;

  @SerializedName("localEnglishGivenName")
  private String localEnglishGivenName = null;

  @SerializedName("localEnglishSurname")
  private String localEnglishSurname = null;

  @SerializedName("aliasName")
  private String aliasName = null;

  @SerializedName("fullName")
  private String fullName = null;

  @SerializedName("saluteBy")
  private String saluteBy = null;

  public ApplicationAddName salutation(String salutation) {
    this.salutation = salutation;
    return this;
  }

   /**
   * Salutation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{salutation} resource to get valid value of this field with description. You can use salutation field name as the referenceCode parameter to retrieve the values.
   * @return salutation
  **/
  @Schema(example = "Mr", description = "Salutation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{salutation} resource to get valid value of this field with description. You can use salutation field name as the referenceCode parameter to retrieve the values.")
  public String getSalutation() {
    return salutation;
  }

  public void setSalutation(String salutation) {
    this.salutation = salutation;
  }

  public ApplicationAddName givenName(String givenName) {
    this.givenName = givenName;
    return this;
  }

   /**
   * Given/first name of the applicant
   * @return givenName
  **/
  @Schema(example = "Matthew", required = true, description = "Given/first name of the applicant")
  public String getGivenName() {
    return givenName;
  }

  public void setGivenName(String givenName) {
    this.givenName = givenName;
  }

  public ApplicationAddName middleName(String middleName) {
    this.middleName = middleName;
    return this;
  }

   /**
   * Middle name of the applicant
   * @return middleName
  **/
  @Schema(example = "Du", description = "Middle name of the applicant")
  public String getMiddleName() {
    return middleName;
  }

  public void setMiddleName(String middleName) {
    this.middleName = middleName;
  }

  public ApplicationAddName surname(String surname) {
    this.surname = surname;
    return this;
  }

   /**
   * Surname/last name of the applicant
   * @return surname
  **/
  @Schema(example = "Hayden", description = "Surname/last name of the applicant")
  public String getSurname() {
    return surname;
  }

  public void setSurname(String surname) {
    this.surname = surname;
  }

  public ApplicationAddName localEnglishGivenName(String localEnglishGivenName) {
    this.localEnglishGivenName = localEnglishGivenName;
    return this;
  }

   /**
   * Local given name in English
   * @return localEnglishGivenName
  **/
  @Schema(example = "Matthew", description = "Local given name in English")
  public String getLocalEnglishGivenName() {
    return localEnglishGivenName;
  }

  public void setLocalEnglishGivenName(String localEnglishGivenName) {
    this.localEnglishGivenName = localEnglishGivenName;
  }

  public ApplicationAddName localEnglishSurname(String localEnglishSurname) {
    this.localEnglishSurname = localEnglishSurname;
    return this;
  }

   /**
   * Local surname in English
   * @return localEnglishSurname
  **/
  @Schema(example = "Hayden", description = "Local surname in English")
  public String getLocalEnglishSurname() {
    return localEnglishSurname;
  }

  public void setLocalEnglishSurname(String localEnglishSurname) {
    this.localEnglishSurname = localEnglishSurname;
  }

  public ApplicationAddName aliasName(String aliasName) {
    this.aliasName = aliasName;
    return this;
  }

   /**
   * Alias name of the applicant
   * @return aliasName
  **/
  @Schema(example = "Matt", description = "Alias name of the applicant")
  public String getAliasName() {
    return aliasName;
  }

  public void setAliasName(String aliasName) {
    this.aliasName = aliasName;
  }

  public ApplicationAddName fullName(String fullName) {
    this.fullName = fullName;
    return this;
  }

   /**
   * Full name of the applicant.
   * @return fullName
  **/
  @Schema(example = "John Bill Smith", description = "Full name of the applicant.")
  public String getFullName() {
    return fullName;
  }

  public void setFullName(String fullName) {
    this.fullName = fullName;
  }

  public ApplicationAddName saluteBy(String saluteBy) {
    this.saluteBy = saluteBy;
    return this;
  }

   /**
   * Contains value with which applicant like to be addressed. This is a reference data field. Please use /v1/apac/utilities/referenceData/{saluteBy} resource to get valid value of this field with description. You can use saluteBy field name as the referenceCode parameter to retrieve the values.
   * @return saluteBy
  **/
  @Schema(example = "SURNAME", description = "Contains value with which applicant like to be addressed. This is a reference data field. Please use /v1/apac/utilities/referenceData/{saluteBy} resource to get valid value of this field with description. You can use saluteBy field name as the referenceCode parameter to retrieve the values.")
  public String getSaluteBy() {
    return saluteBy;
  }

  public void setSaluteBy(String saluteBy) {
    this.saluteBy = saluteBy;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddName applicationAddName = (ApplicationAddName) o;
    return Objects.equals(this.salutation, applicationAddName.salutation) &&
        Objects.equals(this.givenName, applicationAddName.givenName) &&
        Objects.equals(this.middleName, applicationAddName.middleName) &&
        Objects.equals(this.surname, applicationAddName.surname) &&
        Objects.equals(this.localEnglishGivenName, applicationAddName.localEnglishGivenName) &&
        Objects.equals(this.localEnglishSurname, applicationAddName.localEnglishSurname) &&
        Objects.equals(this.aliasName, applicationAddName.aliasName) &&
        Objects.equals(this.fullName, applicationAddName.fullName) &&
        Objects.equals(this.saluteBy, applicationAddName.saluteBy);
  }

  @Override
  public int hashCode() {
    return Objects.hash(salutation, givenName, middleName, surname, localEnglishGivenName, localEnglishSurname, aliasName, fullName, saluteBy);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddName {\n");
    
    sb.append("    salutation: ").append(toIndentedString(salutation)).append("\n");
    sb.append("    givenName: ").append(toIndentedString(givenName)).append("\n");
    sb.append("    middleName: ").append(toIndentedString(middleName)).append("\n");
    sb.append("    surname: ").append(toIndentedString(surname)).append("\n");
    sb.append("    localEnglishGivenName: ").append(toIndentedString(localEnglishGivenName)).append("\n");
    sb.append("    localEnglishSurname: ").append(toIndentedString(localEnglishSurname)).append("\n");
    sb.append("    aliasName: ").append(toIndentedString(aliasName)).append("\n");
    sb.append("    fullName: ").append(toIndentedString(fullName)).append("\n");
    sb.append("    saluteBy: ").append(toIndentedString(saluteBy)).append("\n");
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
