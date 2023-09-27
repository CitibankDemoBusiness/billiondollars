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
 * ApplicationInquiryCreditSpecificRecommendations
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationInquiryCreditSpecificRecommendations {
  @SerializedName("recommendedCreditLimit")
  private Double recommendedCreditLimit = null;

  @SerializedName("btMaximumLoanPercentage")
  private Double btMaximumLoanPercentage = null;

  @SerializedName("btMonthlyInterestRate")
  private Double btMonthlyInterestRate = null;

  @SerializedName("eppMaximumLoanPercentage")
  private Double eppMaximumLoanPercentage = null;

  @SerializedName("eppMonthlyInterestRate")
  private Double eppMonthlyInterestRate = null;

  @SerializedName("btCampaignId")
  private String btCampaignId = null;

  @SerializedName("eppPromoId")
  private String eppPromoId = null;

  public ApplicationInquiryCreditSpecificRecommendations recommendedCreditLimit(Double recommendedCreditLimit) {
    this.recommendedCreditLimit = recommendedCreditLimit;
    return this;
  }

   /**
   * Recommended credit limit
   * @return recommendedCreditLimit
  **/
  @Schema(example = "25000.25", description = "Recommended credit limit")
  public Double getRecommendedCreditLimit() {
    return recommendedCreditLimit;
  }

  public void setRecommendedCreditLimit(Double recommendedCreditLimit) {
    this.recommendedCreditLimit = recommendedCreditLimit;
  }

  public ApplicationInquiryCreditSpecificRecommendations btMaximumLoanPercentage(Double btMaximumLoanPercentage) {
    this.btMaximumLoanPercentage = btMaximumLoanPercentage;
    return this;
  }

   /**
   * Balance transfer maximum loan percentage. Applicable to Counter and Cross-sell offers
   * @return btMaximumLoanPercentage
  **/
  @Schema(example = "95.25", description = "Balance transfer maximum loan percentage. Applicable to Counter and Cross-sell offers")
  public Double getBtMaximumLoanPercentage() {
    return btMaximumLoanPercentage;
  }

  public void setBtMaximumLoanPercentage(Double btMaximumLoanPercentage) {
    this.btMaximumLoanPercentage = btMaximumLoanPercentage;
  }

  public ApplicationInquiryCreditSpecificRecommendations btMonthlyInterestRate(Double btMonthlyInterestRate) {
    this.btMonthlyInterestRate = btMonthlyInterestRate;
    return this;
  }

   /**
   * Balance transfer monthly interest rate. Applicable to Counter and Cross-sell offers
   * @return btMonthlyInterestRate
  **/
  @Schema(example = "95.25", description = "Balance transfer monthly interest rate. Applicable to Counter and Cross-sell offers")
  public Double getBtMonthlyInterestRate() {
    return btMonthlyInterestRate;
  }

  public void setBtMonthlyInterestRate(Double btMonthlyInterestRate) {
    this.btMonthlyInterestRate = btMonthlyInterestRate;
  }

  public ApplicationInquiryCreditSpecificRecommendations eppMaximumLoanPercentage(Double eppMaximumLoanPercentage) {
    this.eppMaximumLoanPercentage = eppMaximumLoanPercentage;
    return this;
  }

   /**
   * Equal payment plan max loan percentage. Applicable to Counter and Cross-sell offers
   * @return eppMaximumLoanPercentage
  **/
  @Schema(example = "5.25", description = "Equal payment plan max loan percentage. Applicable to Counter and Cross-sell offers")
  public Double getEppMaximumLoanPercentage() {
    return eppMaximumLoanPercentage;
  }

  public void setEppMaximumLoanPercentage(Double eppMaximumLoanPercentage) {
    this.eppMaximumLoanPercentage = eppMaximumLoanPercentage;
  }

  public ApplicationInquiryCreditSpecificRecommendations eppMonthlyInterestRate(Double eppMonthlyInterestRate) {
    this.eppMonthlyInterestRate = eppMonthlyInterestRate;
    return this;
  }

   /**
   * Equal payment plan monthly interest rate. Applicable to Counter and Cross-sell offers
   * @return eppMonthlyInterestRate
  **/
  @Schema(example = "5.25", description = "Equal payment plan monthly interest rate. Applicable to Counter and Cross-sell offers")
  public Double getEppMonthlyInterestRate() {
    return eppMonthlyInterestRate;
  }

  public void setEppMonthlyInterestRate(Double eppMonthlyInterestRate) {
    this.eppMonthlyInterestRate = eppMonthlyInterestRate;
  }

  public ApplicationInquiryCreditSpecificRecommendations btCampaignId(String btCampaignId) {
    this.btCampaignId = btCampaignId;
    return this;
  }

   /**
   * Balance transfer CampaignId. Applicable to Counter and Cross-sell offers.
   * @return btCampaignId
  **/
  @Schema(example = "34543634", description = "Balance transfer CampaignId. Applicable to Counter and Cross-sell offers.")
  public String getBtCampaignId() {
    return btCampaignId;
  }

  public void setBtCampaignId(String btCampaignId) {
    this.btCampaignId = btCampaignId;
  }

  public ApplicationInquiryCreditSpecificRecommendations eppPromoId(String eppPromoId) {
    this.eppPromoId = eppPromoId;
    return this;
  }

   /**
   * PromoId of equal payment plan. Applicable for ready credit, Counter and Cross-sell offers
   * @return eppPromoId
  **/
  @Schema(example = "34543634", description = "PromoId of equal payment plan. Applicable for ready credit, Counter and Cross-sell offers")
  public String getEppPromoId() {
    return eppPromoId;
  }

  public void setEppPromoId(String eppPromoId) {
    this.eppPromoId = eppPromoId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationInquiryCreditSpecificRecommendations applicationInquiryCreditSpecificRecommendations = (ApplicationInquiryCreditSpecificRecommendations) o;
    return Objects.equals(this.recommendedCreditLimit, applicationInquiryCreditSpecificRecommendations.recommendedCreditLimit) &&
        Objects.equals(this.btMaximumLoanPercentage, applicationInquiryCreditSpecificRecommendations.btMaximumLoanPercentage) &&
        Objects.equals(this.btMonthlyInterestRate, applicationInquiryCreditSpecificRecommendations.btMonthlyInterestRate) &&
        Objects.equals(this.eppMaximumLoanPercentage, applicationInquiryCreditSpecificRecommendations.eppMaximumLoanPercentage) &&
        Objects.equals(this.eppMonthlyInterestRate, applicationInquiryCreditSpecificRecommendations.eppMonthlyInterestRate) &&
        Objects.equals(this.btCampaignId, applicationInquiryCreditSpecificRecommendations.btCampaignId) &&
        Objects.equals(this.eppPromoId, applicationInquiryCreditSpecificRecommendations.eppPromoId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(recommendedCreditLimit, btMaximumLoanPercentage, btMonthlyInterestRate, eppMaximumLoanPercentage, eppMonthlyInterestRate, btCampaignId, eppPromoId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationInquiryCreditSpecificRecommendations {\n");
    
    sb.append("    recommendedCreditLimit: ").append(toIndentedString(recommendedCreditLimit)).append("\n");
    sb.append("    btMaximumLoanPercentage: ").append(toIndentedString(btMaximumLoanPercentage)).append("\n");
    sb.append("    btMonthlyInterestRate: ").append(toIndentedString(btMonthlyInterestRate)).append("\n");
    sb.append("    eppMaximumLoanPercentage: ").append(toIndentedString(eppMaximumLoanPercentage)).append("\n");
    sb.append("    eppMonthlyInterestRate: ").append(toIndentedString(eppMonthlyInterestRate)).append("\n");
    sb.append("    btCampaignId: ").append(toIndentedString(btCampaignId)).append("\n");
    sb.append("    eppPromoId: ").append(toIndentedString(eppPromoId)).append("\n");
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
