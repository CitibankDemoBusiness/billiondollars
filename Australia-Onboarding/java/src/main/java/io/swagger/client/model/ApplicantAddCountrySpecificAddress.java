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
 * ApplicantAddCountrySpecificAddress
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicantAddCountrySpecificAddress {
  @SerializedName("unitNumber")
  private String unitNumber = null;

  @SerializedName("floorNumber")
  private String floorNumber = null;

  @SerializedName("blockNumber")
  private String blockNumber = null;

  @SerializedName("buildingName")
  private String buildingName = null;

  @SerializedName("estateName")
  private String estateName = null;

  @SerializedName("streetNumber")
  private String streetNumber = null;

  @SerializedName("streetName")
  private String streetName = null;

  @SerializedName("streetType")
  private String streetType = null;

  public ApplicantAddCountrySpecificAddress unitNumber(String unitNumber) {
    this.unitNumber = unitNumber;
    return this;
  }

   /**
   * Applicant&#x27;s unit number
   * @return unitNumber
  **/
  @Schema(example = "265", description = "Applicant's unit number")
  public String getUnitNumber() {
    return unitNumber;
  }

  public void setUnitNumber(String unitNumber) {
    this.unitNumber = unitNumber;
  }

  public ApplicantAddCountrySpecificAddress floorNumber(String floorNumber) {
    this.floorNumber = floorNumber;
    return this;
  }

   /**
   * Applicant&#x27;s floor number
   * @return floorNumber
  **/
  @Schema(example = "12", description = "Applicant's floor number")
  public String getFloorNumber() {
    return floorNumber;
  }

  public void setFloorNumber(String floorNumber) {
    this.floorNumber = floorNumber;
  }

  public ApplicantAddCountrySpecificAddress blockNumber(String blockNumber) {
    this.blockNumber = blockNumber;
    return this;
  }

   /**
   * Applicant&#x27;s block number
   * @return blockNumber
  **/
  @Schema(example = "141", description = "Applicant's block number")
  public String getBlockNumber() {
    return blockNumber;
  }

  public void setBlockNumber(String blockNumber) {
    this.blockNumber = blockNumber;
  }

  public ApplicantAddCountrySpecificAddress buildingName(String buildingName) {
    this.buildingName = buildingName;
    return this;
  }

   /**
   * Applicant&#x27;s building name
   * @return buildingName
  **/
  @Schema(example = "Cardiff", description = "Applicant's building name")
  public String getBuildingName() {
    return buildingName;
  }

  public void setBuildingName(String buildingName) {
    this.buildingName = buildingName;
  }

  public ApplicantAddCountrySpecificAddress estateName(String estateName) {
    this.estateName = estateName;
    return this;
  }

   /**
   * Applicant&#x27;s estate name
   * @return estateName
  **/
  @Schema(example = "Orchard Estate", description = "Applicant's estate name")
  public String getEstateName() {
    return estateName;
  }

  public void setEstateName(String estateName) {
    this.estateName = estateName;
  }

  public ApplicantAddCountrySpecificAddress streetNumber(String streetNumber) {
    this.streetNumber = streetNumber;
    return this;
  }

   /**
   * Applicant&#x27;s street number
   * @return streetNumber
  **/
  @Schema(example = "99", description = "Applicant's street number")
  public String getStreetNumber() {
    return streetNumber;
  }

  public void setStreetNumber(String streetNumber) {
    this.streetNumber = streetNumber;
  }

  public ApplicantAddCountrySpecificAddress streetName(String streetName) {
    this.streetName = streetName;
    return this;
  }

   /**
   * Applicant&#x27;s street name
   * @return streetName
  **/
  @Schema(example = "George Street", description = "Applicant's street name")
  public String getStreetName() {
    return streetName;
  }

  public void setStreetName(String streetName) {
    this.streetName = streetName;
  }

  public ApplicantAddCountrySpecificAddress streetType(String streetType) {
    this.streetType = streetType;
    return this;
  }

   /**
   * Applicant&#x27;s street type. This is a reference data field.Please use /v1/apac/utilities/referenceData/{streetType} resource to get valid value of this field with description. You can use streetType field name as the referenceCode parameter to retrieve the values
   * @return streetType
  **/
  @Schema(example = "ARCADE", description = "Applicant's street type. This is a reference data field.Please use /v1/apac/utilities/referenceData/{streetType} resource to get valid value of this field with description. You can use streetType field name as the referenceCode parameter to retrieve the values")
  public String getStreetType() {
    return streetType;
  }

  public void setStreetType(String streetType) {
    this.streetType = streetType;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicantAddCountrySpecificAddress applicantAddCountrySpecificAddress = (ApplicantAddCountrySpecificAddress) o;
    return Objects.equals(this.unitNumber, applicantAddCountrySpecificAddress.unitNumber) &&
        Objects.equals(this.floorNumber, applicantAddCountrySpecificAddress.floorNumber) &&
        Objects.equals(this.blockNumber, applicantAddCountrySpecificAddress.blockNumber) &&
        Objects.equals(this.buildingName, applicantAddCountrySpecificAddress.buildingName) &&
        Objects.equals(this.estateName, applicantAddCountrySpecificAddress.estateName) &&
        Objects.equals(this.streetNumber, applicantAddCountrySpecificAddress.streetNumber) &&
        Objects.equals(this.streetName, applicantAddCountrySpecificAddress.streetName) &&
        Objects.equals(this.streetType, applicantAddCountrySpecificAddress.streetType);
  }

  @Override
  public int hashCode() {
    return Objects.hash(unitNumber, floorNumber, blockNumber, buildingName, estateName, streetNumber, streetName, streetType);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicantAddCountrySpecificAddress {\n");
    
    sb.append("    unitNumber: ").append(toIndentedString(unitNumber)).append("\n");
    sb.append("    floorNumber: ").append(toIndentedString(floorNumber)).append("\n");
    sb.append("    blockNumber: ").append(toIndentedString(blockNumber)).append("\n");
    sb.append("    buildingName: ").append(toIndentedString(buildingName)).append("\n");
    sb.append("    estateName: ").append(toIndentedString(estateName)).append("\n");
    sb.append("    streetNumber: ").append(toIndentedString(streetNumber)).append("\n");
    sb.append("    streetName: ").append(toIndentedString(streetName)).append("\n");
    sb.append("    streetType: ").append(toIndentedString(streetType)).append("\n");
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
