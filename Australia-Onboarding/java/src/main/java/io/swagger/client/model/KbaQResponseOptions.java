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
 * KbaQResponseOptions
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class KbaQResponseOptions {
  @SerializedName("optionSequenceNumber")
  private Integer optionSequenceNumber = null;

  @SerializedName("optionText")
  private String optionText = null;

  public KbaQResponseOptions optionSequenceNumber(Integer optionSequenceNumber) {
    this.optionSequenceNumber = optionSequenceNumber;
    return this;
  }

   /**
   * Option sequence number
   * @return optionSequenceNumber
  **/
  @Schema(example = "1", description = "Option sequence number")
  public Integer getOptionSequenceNumber() {
    return optionSequenceNumber;
  }

  public void setOptionSequenceNumber(Integer optionSequenceNumber) {
    this.optionSequenceNumber = optionSequenceNumber;
  }

  public KbaQResponseOptions optionText(String optionText) {
    this.optionText = optionText;
    return this;
  }

   /**
   * Option text to be displayed to the end user.
   * @return optionText
  **/
  @Schema(example = "KURT ECKERD REINECKE", description = "Option text to be displayed to the end user.")
  public String getOptionText() {
    return optionText;
  }

  public void setOptionText(String optionText) {
    this.optionText = optionText;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    KbaQResponseOptions kbaQResponseOptions = (KbaQResponseOptions) o;
    return Objects.equals(this.optionSequenceNumber, kbaQResponseOptions.optionSequenceNumber) &&
        Objects.equals(this.optionText, kbaQResponseOptions.optionText);
  }

  @Override
  public int hashCode() {
    return Objects.hash(optionSequenceNumber, optionText);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class KbaQResponseOptions {\n");
    
    sb.append("    optionSequenceNumber: ").append(toIndentedString(optionSequenceNumber)).append("\n");
    sb.append("    optionText: ").append(toIndentedString(optionText)).append("\n");
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
