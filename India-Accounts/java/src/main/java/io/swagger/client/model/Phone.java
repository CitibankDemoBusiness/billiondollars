/*
 * Accounts
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
 * Phone
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class Phone {
  @SerializedName("phoneType")
  private String phoneType = null;

  @SerializedName("phoneCountryCode")
  private String phoneCountryCode = null;

  @SerializedName("areaCode")
  private String areaCode = null;

  @SerializedName("phoneNumber")
  private String phoneNumber = null;

  @SerializedName("extension")
  private String extension = null;

  public Phone phoneType(String phoneType) {
    this.phoneType = phoneType;
    return this;
  }

   /**
   * The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/utilities/referenceData/{phoneType} resource to get valid value of this field with description.
   * @return phoneType
  **/
  @Schema(example = "PRIMARY_MOBILE_NUMBER", description = "The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/utilities/referenceData/{phoneType} resource to get valid value of this field with description.")
  public String getPhoneType() {
    return phoneType;
  }

  public void setPhoneType(String phoneType) {
    this.phoneType = phoneType;
  }

  public Phone phoneCountryCode(String phoneCountryCode) {
    this.phoneCountryCode = phoneCountryCode;
    return this;
  }

   /**
   * Country code of phone number
   * @return phoneCountryCode
  **/
  @Schema(example = "61", description = "Country code of phone number")
  public String getPhoneCountryCode() {
    return phoneCountryCode;
  }

  public void setPhoneCountryCode(String phoneCountryCode) {
    this.phoneCountryCode = phoneCountryCode;
  }

  public Phone areaCode(String areaCode) {
    this.areaCode = areaCode;
    return this;
  }

   /**
   * The area code of phone number
   * @return areaCode
  **/
  @Schema(example = "2", description = "The area code of phone number")
  public String getAreaCode() {
    return areaCode;
  }

  public void setAreaCode(String areaCode) {
    this.areaCode = areaCode;
  }

  public Phone phoneNumber(String phoneNumber) {
    this.phoneNumber = phoneNumber;
    return this;
  }

   /**
   * Applicants phone number
   * @return phoneNumber
  **/
  @Schema(example = "64042321", description = "Applicants phone number")
  public String getPhoneNumber() {
    return phoneNumber;
  }

  public void setPhoneNumber(String phoneNumber) {
    this.phoneNumber = phoneNumber;
  }

  public Phone extension(String extension) {
    this.extension = extension;
    return this;
  }

   /**
   * Extension of telephone number
   * @return extension
  **/
  @Schema(example = "23", description = "Extension of telephone number")
  public String getExtension() {
    return extension;
  }

  public void setExtension(String extension) {
    this.extension = extension;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Phone phone = (Phone) o;
    return Objects.equals(this.phoneType, phone.phoneType) &&
        Objects.equals(this.phoneCountryCode, phone.phoneCountryCode) &&
        Objects.equals(this.areaCode, phone.areaCode) &&
        Objects.equals(this.phoneNumber, phone.phoneNumber) &&
        Objects.equals(this.extension, phone.extension);
  }

  @Override
  public int hashCode() {
    return Objects.hash(phoneType, phoneCountryCode, areaCode, phoneNumber, extension);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Phone {\n");
    
    sb.append("    phoneType: ").append(toIndentedString(phoneType)).append("\n");
    sb.append("    phoneCountryCode: ").append(toIndentedString(phoneCountryCode)).append("\n");
    sb.append("    areaCode: ").append(toIndentedString(areaCode)).append("\n");
    sb.append("    phoneNumber: ").append(toIndentedString(phoneNumber)).append("\n");
    sb.append("    extension: ").append(toIndentedString(extension)).append("\n");
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
