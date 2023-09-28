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
 * Interest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class Interest {
  @SerializedName("productGroup")
  private String productGroup = null;

  @SerializedName("campaignId")
  private String campaignId = null;

  @SerializedName("waveId")
  private String waveId = null;

  public Interest productGroup(String productGroup) {
    this.productGroup = productGroup;
    return this;
  }

   /**
   * A unique code that identifies the product group. This is prospect selected product
   * @return productGroup
  **/
  @Schema(example = "VC830", required = true, description = "A unique code that identifies the product group. This is prospect selected product")
  public String getProductGroup() {
    return productGroup;
  }

  public void setProductGroup(String productGroup) {
    this.productGroup = productGroup;
  }

  public Interest campaignId(String campaignId) {
    this.campaignId = campaignId;
    return this;
  }

   /**
   * Campaign Id. The unique identifier for campaign.
   * @return campaignId
  **/
  @Schema(example = "45645645", description = "Campaign Id. The unique identifier for campaign.")
  public String getCampaignId() {
    return campaignId;
  }

  public void setCampaignId(String campaignId) {
    this.campaignId = campaignId;
  }

  public Interest waveId(String waveId) {
    this.waveId = waveId;
    return this;
  }

   /**
   * Wave Id corresponding to campaign.
   * @return waveId
  **/
  @Schema(example = "23423", description = "Wave Id corresponding to campaign.")
  public String getWaveId() {
    return waveId;
  }

  public void setWaveId(String waveId) {
    this.waveId = waveId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Interest interest = (Interest) o;
    return Objects.equals(this.productGroup, interest.productGroup) &&
        Objects.equals(this.campaignId, interest.campaignId) &&
        Objects.equals(this.waveId, interest.waveId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(productGroup, campaignId, waveId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Interest {\n");
    
    sb.append("    productGroup: ").append(toIndentedString(productGroup)).append("\n");
    sb.append("    campaignId: ").append(toIndentedString(campaignId)).append("\n");
    sb.append("    waveId: ").append(toIndentedString(waveId)).append("\n");
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