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
import io.swagger.client.model.ApplicationAddCountrySpecificAddress;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ApplicationAddAddress
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationAddAddress {
  @SerializedName("addressType")
  private String addressType = null;

  @SerializedName("addressLine1")
  private String addressLine1 = null;

  @SerializedName("addressLine2")
  private String addressLine2 = null;

  @SerializedName("addressLine3")
  private String addressLine3 = null;

  @SerializedName("addressLine4")
  private String addressLine4 = null;

  @SerializedName("cityName")
  private String cityName = null;

  @SerializedName("state")
  private String state = null;

  @SerializedName("postalCode")
  private String postalCode = null;

  @SerializedName("provinceCode")
  private String provinceCode = null;

  @SerializedName("countryCode")
  private String countryCode = null;

  @SerializedName("okToMail")
  private Boolean okToMail = null;

  @SerializedName("residenceDurationInYears")
  private Integer residenceDurationInYears = null;

  @SerializedName("residenceDurationInMonths")
  private Integer residenceDurationInMonths = null;

  @SerializedName("countrySpecificAddress")
  private ApplicationAddCountrySpecificAddress countrySpecificAddress = null;

  public ApplicationAddAddress addressType(String addressType) {
    this.addressType = addressType;
    return this;
  }

   /**
   * Type of address. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.
   * @return addressType
  **/
  @Schema(example = "HOME_ADDRESS", description = "Type of address. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values.")
  public String getAddressType() {
    return addressType;
  }

  public void setAddressType(String addressType) {
    this.addressType = addressType;
  }

  public ApplicationAddAddress addressLine1(String addressLine1) {
    this.addressLine1 = addressLine1;
    return this;
  }

   /**
   * Address line 1
   * @return addressLine1
  **/
  @Schema(example = "40A Orchard Road", description = "Address line 1")
  public String getAddressLine1() {
    return addressLine1;
  }

  public void setAddressLine1(String addressLine1) {
    this.addressLine1 = addressLine1;
  }

  public ApplicationAddAddress addressLine2(String addressLine2) {
    this.addressLine2 = addressLine2;
    return this;
  }

   /**
   * Address line 2
   * @return addressLine2
  **/
  @Schema(example = "#99-99 Macdonald House", description = "Address line 2")
  public String getAddressLine2() {
    return addressLine2;
  }

  public void setAddressLine2(String addressLine2) {
    this.addressLine2 = addressLine2;
  }

  public ApplicationAddAddress addressLine3(String addressLine3) {
    this.addressLine3 = addressLine3;
    return this;
  }

   /**
   * Address line 3
   * @return addressLine3
  **/
  @Schema(example = "Orchard Avenue 2", description = "Address line 3")
  public String getAddressLine3() {
    return addressLine3;
  }

  public void setAddressLine3(String addressLine3) {
    this.addressLine3 = addressLine3;
  }

  public ApplicationAddAddress addressLine4(String addressLine4) {
    this.addressLine4 = addressLine4;
    return this;
  }

   /**
   * Address line 4
   * @return addressLine4
  **/
  @Schema(example = "Street 65", description = "Address line 4")
  public String getAddressLine4() {
    return addressLine4;
  }

  public void setAddressLine4(String addressLine4) {
    this.addressLine4 = addressLine4;
  }

  public ApplicationAddAddress cityName(String cityName) {
    this.cityName = cityName;
    return this;
  }

   /**
   * City
   * @return cityName
  **/
  @Schema(example = "Singapore", description = "City")
  public String getCityName() {
    return cityName;
  }

  public void setCityName(String cityName) {
    this.cityName = cityName;
  }

  public ApplicationAddAddress state(String state) {
    this.state = state;
    return this;
  }

   /**
   * State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values.
   * @return state
  **/
  @Schema(example = "Singapore", description = "State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values.")
  public String getState() {
    return state;
  }

  public void setState(String state) {
    this.state = state;
  }

  public ApplicationAddAddress postalCode(String postalCode) {
    this.postalCode = postalCode;
    return this;
  }

   /**
   * Postal/ZIP code
   * @return postalCode
  **/
  @Schema(example = "345346", description = "Postal/ZIP code")
  public String getPostalCode() {
    return postalCode;
  }

  public void setPostalCode(String postalCode) {
    this.postalCode = postalCode;
  }

  public ApplicationAddAddress provinceCode(String provinceCode) {
    this.provinceCode = provinceCode;
    return this;
  }

   /**
   * Province code
   * @return provinceCode
  **/
  @Schema(example = "Singapore", description = "Province code")
  public String getProvinceCode() {
    return provinceCode;
  }

  public void setProvinceCode(String provinceCode) {
    this.provinceCode = provinceCode;
  }

  public ApplicationAddAddress countryCode(String countryCode) {
    this.countryCode = countryCode;
    return this;
  }

   /**
   * ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values.
   * @return countryCode
  **/
  @Schema(example = "SG", description = "ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values.")
  public String getCountryCode() {
    return countryCode;
  }

  public void setCountryCode(String countryCode) {
    this.countryCode = countryCode;
  }

  public ApplicationAddAddress okToMail(Boolean okToMail) {
    this.okToMail = okToMail;
    return this;
  }

   /**
   * Applicant&#x27;s consent for receiving mail. Valid values: true and false
   * @return okToMail
  **/
  @Schema(example = "true", description = "Applicant's consent for receiving mail. Valid values: true and false")
  public Boolean isOkToMail() {
    return okToMail;
  }

  public void setOkToMail(Boolean okToMail) {
    this.okToMail = okToMail;
  }

  public ApplicationAddAddress residenceDurationInYears(Integer residenceDurationInYears) {
    this.residenceDurationInYears = residenceDurationInYears;
    return this;
  }

   /**
   * Applicant&#x27;s residence duration in the current address in years. Applicable only for residential address.
   * @return residenceDurationInYears
  **/
  @Schema(example = "5", description = "Applicant's residence duration in the current address in years. Applicable only for residential address.")
  public Integer getResidenceDurationInYears() {
    return residenceDurationInYears;
  }

  public void setResidenceDurationInYears(Integer residenceDurationInYears) {
    this.residenceDurationInYears = residenceDurationInYears;
  }

  public ApplicationAddAddress residenceDurationInMonths(Integer residenceDurationInMonths) {
    this.residenceDurationInMonths = residenceDurationInMonths;
    return this;
  }

   /**
   * Applicant&#x27;s residence duration in the current address in months. Applicable only for residential address.
   * @return residenceDurationInMonths
  **/
  @Schema(example = "4", description = "Applicant's residence duration in the current address in months. Applicable only for residential address.")
  public Integer getResidenceDurationInMonths() {
    return residenceDurationInMonths;
  }

  public void setResidenceDurationInMonths(Integer residenceDurationInMonths) {
    this.residenceDurationInMonths = residenceDurationInMonths;
  }

  public ApplicationAddAddress countrySpecificAddress(ApplicationAddCountrySpecificAddress countrySpecificAddress) {
    this.countrySpecificAddress = countrySpecificAddress;
    return this;
  }

   /**
   * Get countrySpecificAddress
   * @return countrySpecificAddress
  **/
  @Schema(description = "")
  public ApplicationAddCountrySpecificAddress getCountrySpecificAddress() {
    return countrySpecificAddress;
  }

  public void setCountrySpecificAddress(ApplicationAddCountrySpecificAddress countrySpecificAddress) {
    this.countrySpecificAddress = countrySpecificAddress;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationAddAddress applicationAddAddress = (ApplicationAddAddress) o;
    return Objects.equals(this.addressType, applicationAddAddress.addressType) &&
        Objects.equals(this.addressLine1, applicationAddAddress.addressLine1) &&
        Objects.equals(this.addressLine2, applicationAddAddress.addressLine2) &&
        Objects.equals(this.addressLine3, applicationAddAddress.addressLine3) &&
        Objects.equals(this.addressLine4, applicationAddAddress.addressLine4) &&
        Objects.equals(this.cityName, applicationAddAddress.cityName) &&
        Objects.equals(this.state, applicationAddAddress.state) &&
        Objects.equals(this.postalCode, applicationAddAddress.postalCode) &&
        Objects.equals(this.provinceCode, applicationAddAddress.provinceCode) &&
        Objects.equals(this.countryCode, applicationAddAddress.countryCode) &&
        Objects.equals(this.okToMail, applicationAddAddress.okToMail) &&
        Objects.equals(this.residenceDurationInYears, applicationAddAddress.residenceDurationInYears) &&
        Objects.equals(this.residenceDurationInMonths, applicationAddAddress.residenceDurationInMonths) &&
        Objects.equals(this.countrySpecificAddress, applicationAddAddress.countrySpecificAddress);
  }

  @Override
  public int hashCode() {
    return Objects.hash(addressType, addressLine1, addressLine2, addressLine3, addressLine4, cityName, state, postalCode, provinceCode, countryCode, okToMail, residenceDurationInYears, residenceDurationInMonths, countrySpecificAddress);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationAddAddress {\n");
    
    sb.append("    addressType: ").append(toIndentedString(addressType)).append("\n");
    sb.append("    addressLine1: ").append(toIndentedString(addressLine1)).append("\n");
    sb.append("    addressLine2: ").append(toIndentedString(addressLine2)).append("\n");
    sb.append("    addressLine3: ").append(toIndentedString(addressLine3)).append("\n");
    sb.append("    addressLine4: ").append(toIndentedString(addressLine4)).append("\n");
    sb.append("    cityName: ").append(toIndentedString(cityName)).append("\n");
    sb.append("    state: ").append(toIndentedString(state)).append("\n");
    sb.append("    postalCode: ").append(toIndentedString(postalCode)).append("\n");
    sb.append("    provinceCode: ").append(toIndentedString(provinceCode)).append("\n");
    sb.append("    countryCode: ").append(toIndentedString(countryCode)).append("\n");
    sb.append("    okToMail: ").append(toIndentedString(okToMail)).append("\n");
    sb.append("    residenceDurationInYears: ").append(toIndentedString(residenceDurationInYears)).append("\n");
    sb.append("    residenceDurationInMonths: ").append(toIndentedString(residenceDurationInMonths)).append("\n");
    sb.append("    countrySpecificAddress: ").append(toIndentedString(countrySpecificAddress)).append("\n");
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