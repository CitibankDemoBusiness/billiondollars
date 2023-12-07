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
import io.swagger.client.model.RewardAccount;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * RewardsInquiryResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class RewardsInquiryResponse {
  @SerializedName("rewardAccounts")
  private List<RewardAccount> rewardAccounts = new ArrayList<RewardAccount>();

  public RewardsInquiryResponse rewardAccounts(List<RewardAccount> rewardAccounts) {
    this.rewardAccounts = rewardAccounts;
    return this;
  }

  public RewardsInquiryResponse addRewardAccountsItem(RewardAccount rewardAccountsItem) {
    this.rewardAccounts.add(rewardAccountsItem);
    return this;
  }

   /**
   * Get rewardAccounts
   * @return rewardAccounts
  **/
  @Schema(required = true, description = "")
  public List<RewardAccount> getRewardAccounts() {
    return rewardAccounts;
  }

  public void setRewardAccounts(List<RewardAccount> rewardAccounts) {
    this.rewardAccounts = rewardAccounts;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RewardsInquiryResponse rewardsInquiryResponse = (RewardsInquiryResponse) o;
    return Objects.equals(this.rewardAccounts, rewardsInquiryResponse.rewardAccounts);
  }

  @Override
  public int hashCode() {
    return Objects.hash(rewardAccounts);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RewardsInquiryResponse {\n");
    
    sb.append("    rewardAccounts: ").append(toIndentedString(rewardAccounts)).append("\n");
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
