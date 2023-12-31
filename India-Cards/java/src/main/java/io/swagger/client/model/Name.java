/*
 * Cards
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
 * Name
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class Name {
  @SerializedName("surname")
  private String surname = null;

  @SerializedName("givenName")
  private String givenName = null;

  @SerializedName("middleName")
  private String middleName = null;

  @SerializedName("salutation")
  private String salutation = null;

  public Name surname(String surname) {
    this.surname = surname;
    return this;
  }

   /**
   * Surname/last name of the applicant
   * @return surname
  **/
  @Schema(example = "Smith", required = true, description = "Surname/last name of the applicant")
  public String getSurname() {
    return surname;
  }

  public void setSurname(String surname) {
    this.surname = surname;
  }

  public Name givenName(String givenName) {
    this.givenName = givenName;
    return this;
  }

   /**
   * Given/first name of the applicant
   * @return givenName
  **/
  @Schema(example = "John", required = true, description = "Given/first name of the applicant")
  public String getGivenName() {
    return givenName;
  }

  public void setGivenName(String givenName) {
    this.givenName = givenName;
  }

  public Name middleName(String middleName) {
    this.middleName = middleName;
    return this;
  }

   /**
   * Middle name of the applicant
   * @return middleName
  **/
  @Schema(example = "Bill", description = "Middle name of the applicant")
  public String getMiddleName() {
    return middleName;
  }

  public void setMiddleName(String middleName) {
    this.middleName = middleName;
  }

  public Name salutation(String salutation) {
    this.salutation = salutation;
    return this;
  }

   /**
   * Salutation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{salutation} resource to get valid value of this field with description.
   * @return salutation
  **/
  @Schema(example = "Mr", required = true, description = "Salutation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{salutation} resource to get valid value of this field with description.")
  public String getSalutation() {
    return salutation;
  }

  public void setSalutation(String salutation) {
    this.salutation = salutation;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Name name = (Name) o;
    return Objects.equals(this.surname, name.surname) &&
        Objects.equals(this.givenName, name.givenName) &&
        Objects.equals(this.middleName, name.middleName) &&
        Objects.equals(this.salutation, name.salutation);
  }

  @Override
  public int hashCode() {
    return Objects.hash(surname, givenName, middleName, salutation);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Name {\n");
    
    sb.append("    surname: ").append(toIndentedString(surname)).append("\n");
    sb.append("    givenName: ").append(toIndentedString(givenName)).append("\n");
    sb.append("    middleName: ").append(toIndentedString(middleName)).append("\n");
    sb.append("    salutation: ").append(toIndentedString(salutation)).append("\n");
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
