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
 * ApplicationAddEducation
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddEducation {
  @SerializedName("highestEducationLevel")
  private String highestEducationLevel = null;

  @SerializedName("yearOfGraduation")
  private String yearOfGraduation = null;

  @SerializedName("studentId")
  private String studentId = null;

  @SerializedName("university")
  private String university = null;

  public ApplicationAddEducation highestEducationLevel(String highestEducationLevel) {
    this.highestEducationLevel = highestEducationLevel;
    return this;
  }

   /**
   * Highest education level of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{highestEducationLevel} resource to get valid value of this field with description. You can use highestEducationLevel field name as the referenceCode parameter to retrieve the values.
   * @return highestEducationLevel
  **/
  @Schema(example = "MASTER", description = "Highest education level of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{highestEducationLevel} resource to get valid value of this field with description. You can use highestEducationLevel field name as the referenceCode parameter to retrieve the values.")
  public String getHighestEducationLevel() {
    return highestEducationLevel;
  }

  public void setHighestEducationLevel(String highestEducationLevel) {
    this.highestEducationLevel = highestEducationLevel;
  }

  public ApplicationAddEducation yearOfGraduation(String yearOfGraduation) {
    this.yearOfGraduation = yearOfGraduation;
    return this;
  }

   /**
   * Year of completing graduation. This is required if applicant is a student
   * @return yearOfGraduation
  **/
  @Schema(example = "2003", description = "Year of completing graduation. This is required if applicant is a student")
  public String getYearOfGraduation() {
    return yearOfGraduation;
  }

  public void setYearOfGraduation(String yearOfGraduation) {
    this.yearOfGraduation = yearOfGraduation;
  }

  public ApplicationAddEducation studentId(String studentId) {
    this.studentId = studentId;
    return this;
  }

   /**
   * Unique ID of the student. This is required if applicant is a student
   * @return studentId
  **/
  @Schema(example = "STID234567", description = "Unique ID of the student. This is required if applicant is a student")
  public String getStudentId() {
    return studentId;
  }

  public void setStudentId(String studentId) {
    this.studentId = studentId;
  }

  public ApplicationAddEducation university(String university) {
    this.university = university;
    return this;
  }

   /**
   * University name. This is a reference data field. Please use /v1/apac/utilities/referenceData/{universityCode} resource to get valid value of this field with description. You can use university field name as the referenceCode parameter to retrieve the values.
   * @return university
  **/
  @Schema(example = "NTU", description = "University name. This is a reference data field. Please use /v1/apac/utilities/referenceData/{universityCode} resource to get valid value of this field with description. You can use university field name as the referenceCode parameter to retrieve the values.")
  public String getUniversity() {
    return university;
  }

  public void setUniversity(String university) {
    this.university = university;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddEducation applicationAddEducation = (ApplicationAddEducation) o;
    return Objects.equals(this.highestEducationLevel, applicationAddEducation.highestEducationLevel) &&
        Objects.equals(this.yearOfGraduation, applicationAddEducation.yearOfGraduation) &&
        Objects.equals(this.studentId, applicationAddEducation.studentId) &&
        Objects.equals(this.university, applicationAddEducation.university);
  }

  @Override
  public int hashCode() {
    return Objects.hash(highestEducationLevel, yearOfGraduation, studentId, university);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddEducation {\n");
    
    sb.append("    highestEducationLevel: ").append(toIndentedString(highestEducationLevel)).append("\n");
    sb.append("    yearOfGraduation: ").append(toIndentedString(yearOfGraduation)).append("\n");
    sb.append("    studentId: ").append(toIndentedString(studentId)).append("\n");
    sb.append("    university: ").append(toIndentedString(university)).append("\n");
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
