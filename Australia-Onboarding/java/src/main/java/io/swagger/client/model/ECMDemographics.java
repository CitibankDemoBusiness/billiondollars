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
 * ECMDemographics
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ECMDemographics {
  @SerializedName("gender")
  private String gender = null;

  @SerializedName("dateOfBirth")
  private LocalDate dateOfBirth = null;

  @SerializedName("nationality")
  private String nationality = null;

  public ECMDemographics gender(String gender) {
    this.gender = gender;
    return this;
  }

   /**
   * Gender/sex. This is a reference data field. Please use /v1/utilities/referenceData/{gender} resource to get valid value of this field with description.
   * @return gender
  **/
  @Schema(description = "Gender/sex. This is a reference data field. Please use /v1/utilities/referenceData/{gender} resource to get valid value of this field with description.")
  public String getGender() {
    return gender;
  }

  public void setGender(String gender) {
    this.gender = gender;
  }

  public ECMDemographics dateOfBirth(LocalDate dateOfBirth) {
    this.dateOfBirth = dateOfBirth;
    return this;
  }

   /**
   * Applicants date of birth in ISO 8601 date format YYYY-MM-DD
   * @return dateOfBirth
  **/
  @Schema(description = "Applicants date of birth in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getDateOfBirth() {
    return dateOfBirth;
  }

  public void setDateOfBirth(LocalDate dateOfBirth) {
    this.dateOfBirth = dateOfBirth;
  }

  public ECMDemographics nationality(String nationality) {
    this.nationality = nationality;
    return this;
  }

   /**
   * Applicants nationality. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description.
   * @return nationality
  **/
  @Schema(description = "Applicants nationality. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description.")
  public String getNationality() {
    return nationality;
  }

  public void setNationality(String nationality) {
    this.nationality = nationality;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ECMDemographics ecMDemographics = (ECMDemographics) o;
    return Objects.equals(this.gender, ecMDemographics.gender) &&
        Objects.equals(this.dateOfBirth, ecMDemographics.dateOfBirth) &&
        Objects.equals(this.nationality, ecMDemographics.nationality);
  }

  @Override
  public int hashCode() {
    return Objects.hash(gender, dateOfBirth, nationality);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ECMDemographics {\n");
    
    sb.append("    gender: ").append(toIndentedString(gender)).append("\n");
    sb.append("    dateOfBirth: ").append(toIndentedString(dateOfBirth)).append("\n");
    sb.append("    nationality: ").append(toIndentedString(nationality)).append("\n");
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