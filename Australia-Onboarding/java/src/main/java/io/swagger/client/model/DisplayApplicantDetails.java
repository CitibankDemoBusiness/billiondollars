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
import io.swagger.client.model.ECMAddress;
import io.swagger.client.model.ECMName;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * DisplayApplicantDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class DisplayApplicantDetails {
  @SerializedName("name")
  private ECMName name = null;

  @SerializedName("address")
  private List<ECMAddress> address = null;

  public DisplayApplicantDetails name(ECMName name) {
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @Schema(required = true, description = "")
  public ECMName getName() {
    return name;
  }

  public void setName(ECMName name) {
    this.name = name;
  }

  public DisplayApplicantDetails address(List<ECMAddress> address) {
    this.address = address;
    return this;
  }

  public DisplayApplicantDetails addAddressItem(ECMAddress addressItem) {
    if (this.address == null) {
      this.address = new ArrayList<ECMAddress>();
    }
    this.address.add(addressItem);
    return this;
  }

   /**
   * Get address
   * @return address
  **/
  @Schema(description = "")
  public List<ECMAddress> getAddress() {
    return address;
  }

  public void setAddress(List<ECMAddress> address) {
    this.address = address;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DisplayApplicantDetails displayApplicantDetails = (DisplayApplicantDetails) o;
    return Objects.equals(this.name, displayApplicantDetails.name) &&
        Objects.equals(this.address, displayApplicantDetails.address);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, address);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DisplayApplicantDetails {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
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
