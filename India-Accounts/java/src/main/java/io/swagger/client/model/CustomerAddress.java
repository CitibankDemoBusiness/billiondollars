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
 * CustomerAddress
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class CustomerAddress {
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

  public CustomerAddress addressLine1(String addressLine1) {
    this.addressLine1 = addressLine1;
    return this;
  }

   /**
   * Address line 1
   * @return addressLine1
  **/
  @Schema(example = "12", description = "Address line 1")
  public String getAddressLine1() {
    return addressLine1;
  }

  public void setAddressLine1(String addressLine1) {
    this.addressLine1 = addressLine1;
  }

  public CustomerAddress addressLine2(String addressLine2) {
    this.addressLine2 = addressLine2;
    return this;
  }

   /**
   * Address line 2
   * @return addressLine2
  **/
  @Schema(example = "24", description = "Address line 2")
  public String getAddressLine2() {
    return addressLine2;
  }

  public void setAddressLine2(String addressLine2) {
    this.addressLine2 = addressLine2;
  }

  public CustomerAddress addressLine3(String addressLine3) {
    this.addressLine3 = addressLine3;
    return this;
  }

   /**
   * Address line 3
   * @return addressLine3
  **/
  @Schema(example = "209", description = "Address line 3")
  public String getAddressLine3() {
    return addressLine3;
  }

  public void setAddressLine3(String addressLine3) {
    this.addressLine3 = addressLine3;
  }

  public CustomerAddress addressLine4(String addressLine4) {
    this.addressLine4 = addressLine4;
    return this;
  }

   /**
   * Address line 4
   * @return addressLine4
  **/
  @Schema(example = "Warsaw", description = "Address line 4")
  public String getAddressLine4() {
    return addressLine4;
  }

  public void setAddressLine4(String addressLine4) {
    this.addressLine4 = addressLine4;
  }

  public CustomerAddress cityName(String cityName) {
    this.cityName = cityName;
    return this;
  }

   /**
   * City
   * @return cityName
  **/
  @Schema(example = "Warsaw", description = "City")
  public String getCityName() {
    return cityName;
  }

  public void setCityName(String cityName) {
    this.cityName = cityName;
  }

  public CustomerAddress state(String state) {
    this.state = state;
    return this;
  }

   /**
   * State.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description.
   * @return state
  **/
  @Schema(example = "Mazowieckie", description = "State.This is a reference data field. Please use /v1/utilities/referenceData/{addressState} resource to get valid value of this field with description.")
  public String getState() {
    return state;
  }

  public void setState(String state) {
    this.state = state;
  }

  public CustomerAddress postalCode(String postalCode) {
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

  public CustomerAddress provinceCode(String provinceCode) {
    this.provinceCode = provinceCode;
    return this;
  }

   /**
   * Province code
   * @return provinceCode
  **/
  @Schema(example = "Mazowieckie", description = "Province code")
  public String getProvinceCode() {
    return provinceCode;
  }

  public void setProvinceCode(String provinceCode) {
    this.provinceCode = provinceCode;
  }

  public CustomerAddress countryCode(String countryCode) {
    this.countryCode = countryCode;
    return this;
  }

   /**
   * ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values.
   * @return countryCode
  **/
  @Schema(example = "PL", description = "ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values.")
  public String getCountryCode() {
    return countryCode;
  }

  public void setCountryCode(String countryCode) {
    this.countryCode = countryCode;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CustomerAddress customerAddress = (CustomerAddress) o;
    return Objects.equals(this.addressLine1, customerAddress.addressLine1) &&
        Objects.equals(this.addressLine2, customerAddress.addressLine2) &&
        Objects.equals(this.addressLine3, customerAddress.addressLine3) &&
        Objects.equals(this.addressLine4, customerAddress.addressLine4) &&
        Objects.equals(this.cityName, customerAddress.cityName) &&
        Objects.equals(this.state, customerAddress.state) &&
        Objects.equals(this.postalCode, customerAddress.postalCode) &&
        Objects.equals(this.provinceCode, customerAddress.provinceCode) &&
        Objects.equals(this.countryCode, customerAddress.countryCode);
  }

  @Override
  public int hashCode() {
    return Objects.hash(addressLine1, addressLine2, addressLine3, addressLine4, cityName, state, postalCode, provinceCode, countryCode);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CustomerAddress {\n");
    
    sb.append("    addressLine1: ").append(toIndentedString(addressLine1)).append("\n");
    sb.append("    addressLine2: ").append(toIndentedString(addressLine2)).append("\n");
    sb.append("    addressLine3: ").append(toIndentedString(addressLine3)).append("\n");
    sb.append("    addressLine4: ").append(toIndentedString(addressLine4)).append("\n");
    sb.append("    cityName: ").append(toIndentedString(cityName)).append("\n");
    sb.append("    state: ").append(toIndentedString(state)).append("\n");
    sb.append("    postalCode: ").append(toIndentedString(postalCode)).append("\n");
    sb.append("    provinceCode: ").append(toIndentedString(provinceCode)).append("\n");
    sb.append("    countryCode: ").append(toIndentedString(countryCode)).append("\n");
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
