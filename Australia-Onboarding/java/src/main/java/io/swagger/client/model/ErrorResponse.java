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
 * ErrorResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ErrorResponse {
  /**
   * Invalid - Request did not confirm to the specification and was unprocessed and rejected. Please fix the value and try again
   */
  @JsonAdapter(TypeEnum.Adapter.class)
  public enum TypeEnum {
    ERROR("error"),
    WARN("warn"),
    INVALID("invalid"),
    FATAL("fatal");

    private String value;

    TypeEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static TypeEnum fromValue(String text) {
      for (TypeEnum b : TypeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<TypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final TypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public TypeEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return TypeEnum.fromValue(String.valueOf(value));
      }
    }
  }  @SerializedName("type")
  private TypeEnum type = null;

  @SerializedName("code")
  private String code = null;

  @SerializedName("details")
  private String details = null;

  @SerializedName("location")
  private String location = null;

  @SerializedName("moreInfo")
  private Object moreInfo = null;

  public ErrorResponse type(TypeEnum type) {
    this.type = type;
    return this;
  }

   /**
   * Invalid - Request did not confirm to the specification and was unprocessed and rejected. Please fix the value and try again
   * @return type
  **/
  @Schema(required = true, description = "Invalid - Request did not confirm to the specification and was unprocessed and rejected. Please fix the value and try again")
  public TypeEnum getType() {
    return type;
  }

  public void setType(TypeEnum type) {
    this.type = type;
  }

  public ErrorResponse code(String code) {
    this.code = code;
    return this;
  }

   /**
   * Error code which qualifies the error
   * @return code
  **/
  @Schema(required = true, description = "Error code which qualifies the error")
  public String getCode() {
    return code;
  }

  public void setCode(String code) {
    this.code = code;
  }

  public ErrorResponse details(String details) {
    this.details = details;
    return this;
  }

   /**
   * Human readable explanation specific to the occurrence of the problem
   * @return details
  **/
  @Schema(description = "Human readable explanation specific to the occurrence of the problem")
  public String getDetails() {
    return details;
  }

  public void setDetails(String details) {
    this.details = details;
  }

  public ErrorResponse location(String location) {
    this.location = location;
    return this;
  }

   /**
   * The name of the field that resulted in the error
   * @return location
  **/
  @Schema(description = "The name of the field that resulted in the error")
  public String getLocation() {
    return location;
  }

  public void setLocation(String location) {
    this.location = location;
  }

  public ErrorResponse moreInfo(Object moreInfo) {
    this.moreInfo = moreInfo;
    return this;
  }

   /**
   * URI to human readable documentation of the error
   * @return moreInfo
  **/
  @Schema(description = "URI to human readable documentation of the error")
  public Object getMoreInfo() {
    return moreInfo;
  }

  public void setMoreInfo(Object moreInfo) {
    this.moreInfo = moreInfo;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ErrorResponse errorResponse = (ErrorResponse) o;
    return Objects.equals(this.type, errorResponse.type) &&
        Objects.equals(this.code, errorResponse.code) &&
        Objects.equals(this.details, errorResponse.details) &&
        Objects.equals(this.location, errorResponse.location) &&
        Objects.equals(this.moreInfo, errorResponse.moreInfo);
  }

  @Override
  public int hashCode() {
    return Objects.hash(type, code, details, location, moreInfo);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ErrorResponse {\n");
    
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    code: ").append(toIndentedString(code)).append("\n");
    sb.append("    details: ").append(toIndentedString(details)).append("\n");
    sb.append("    location: ").append(toIndentedString(location)).append("\n");
    sb.append("    moreInfo: ").append(toIndentedString(moreInfo)).append("\n");
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
