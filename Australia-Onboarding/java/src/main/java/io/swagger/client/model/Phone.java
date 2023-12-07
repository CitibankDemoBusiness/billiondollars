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
 * Phone
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
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

  @SerializedName("okToSms")
  private Boolean okToSms = null;

  @SerializedName("okToCall")
  private Boolean okToCall = null;

  public Phone phoneType(String phoneType) {
    this.phoneType = phoneType;
    return this;
  }

   /**
   * The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get possible values of this field with descriptions. You can use phoneType field name as the referenceCode parameter to retrieve the values.
   * @return phoneType
  **/
  @Schema(example = "HOME_PHONE_NUMBER", required = true, description = "The type of phone. Ex:OFFICE, HOME, MOBILE, PRIMARY_MOBILE, FAX. This is a reference data field. Please use /v1/apac/utilities/referenceData/{phoneType} resource to get possible values of this field with descriptions. You can use phoneType field name as the referenceCode parameter to retrieve the values.")
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
   * Country code of telephone number
   * @return phoneCountryCode
  **/
  @Schema(example = "65", description = "Country code of telephone number")
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
   * The area code of telephone number
   * @return areaCode
  **/
  @Schema(example = "02", description = "The area code of telephone number")
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
   * The phone number of prospect
   * @return phoneNumber
  **/
  @Schema(example = "64042408", required = true, description = "The phone number of prospect")
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
  @Schema(example = "234", description = "Extension of telephone number")
  public String getExtension() {
    return extension;
  }

  public void setExtension(String extension) {
    this.extension = extension;
  }

  public Phone okToSms(Boolean okToSms) {
    this.okToSms = okToSms;
    return this;
  }

   /**
   * Flag to indicate whether prospect wants to receive SMS or not. This is applicable only if phone type is MOBILE. Valid values: true and false
   * @return okToSms
  **/
  @Schema(example = "true", description = "Flag to indicate whether prospect wants to receive SMS or not. This is applicable only if phone type is MOBILE. Valid values: true and false")
  public Boolean isOkToSms() {
    return okToSms;
  }

  public void setOkToSms(Boolean okToSms) {
    this.okToSms = okToSms;
  }

  public Phone okToCall(Boolean okToCall) {
    this.okToCall = okToCall;
    return this;
  }

   /**
   * Flag to indicate whether prospect wants to receive calls or not. Valid values: true and false
   * @return okToCall
  **/
  @Schema(example = "true", description = "Flag to indicate whether prospect wants to receive calls or not. Valid values: true and false")
  public Boolean isOkToCall() {
    return okToCall;
  }

  public void setOkToCall(Boolean okToCall) {
    this.okToCall = okToCall;
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
        Objects.equals(this.extension, phone.extension) &&
        Objects.equals(this.okToSms, phone.okToSms) &&
        Objects.equals(this.okToCall, phone.okToCall);
  }

  @Override
  public int hashCode() {
    return Objects.hash(phoneType, phoneCountryCode, areaCode, phoneNumber, extension, okToSms, okToCall);
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
    sb.append("    okToSms: ").append(toIndentedString(okToSms)).append("\n");
    sb.append("    okToCall: ").append(toIndentedString(okToCall)).append("\n");
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
