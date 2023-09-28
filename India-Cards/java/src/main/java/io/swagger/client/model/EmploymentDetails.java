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
 * EmploymentDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class EmploymentDetails {
  @SerializedName("occupationCode")
  private String occupationCode = null;

  public EmploymentDetails occupationCode(String occupationCode) {
    this.occupationCode = occupationCode;
    return this;
  }

   /**
   * Occupation code. This is a reference data field. Please use /utilities/referenceData/{occupationCode} resource to get valid values of this field with descriptions.
   * @return occupationCode
  **/
  @Schema(example = "CONSULTANT", required = true, description = "Occupation code. This is a reference data field. Please use /utilities/referenceData/{occupationCode} resource to get valid values of this field with descriptions.")
  public String getOccupationCode() {
    return occupationCode;
  }

  public void setOccupationCode(String occupationCode) {
    this.occupationCode = occupationCode;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EmploymentDetails employmentDetails = (EmploymentDetails) o;
    return Objects.equals(this.occupationCode, employmentDetails.occupationCode);
  }

  @Override
  public int hashCode() {
    return Objects.hash(occupationCode);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EmploymentDetails {\n");
    
    sb.append("    occupationCode: ").append(toIndentedString(occupationCode)).append("\n");
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