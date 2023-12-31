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
import io.swagger.client.model.ReferralTracking;
import io.swagger.client.model.UtilityBillDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ECMAdditionalDataUpdate
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ECMAdditionalDataUpdate {
  @SerializedName("cashPinFlag")
  private Boolean cashPinFlag = null;

  @SerializedName("utilityBillDetails")
  private UtilityBillDetails utilityBillDetails = null;

  @SerializedName("billingCycleDay")
  private String billingCycleDay = null;

  @SerializedName("applicationReferenceId")
  private String applicationReferenceId = null;

  @SerializedName("printingSerialNumber")
  private String printingSerialNumber = null;

  @SerializedName("accountFundSource")
  private String accountFundSource = null;

  @SerializedName("mediaId")
  private String mediaId = null;

  @SerializedName("referralTracking")
  private ReferralTracking referralTracking = null;

  public ECMAdditionalDataUpdate cashPinFlag(Boolean cashPinFlag) {
    this.cashPinFlag = cashPinFlag;
    return this;
  }

   /**
   * Indicates whether the customer wants a separate cash PIN.
   * @return cashPinFlag
  **/
  @Schema(description = "Indicates whether the customer wants a separate cash PIN.")
  public Boolean isCashPinFlag() {
    return cashPinFlag;
  }

  public void setCashPinFlag(Boolean cashPinFlag) {
    this.cashPinFlag = cashPinFlag;
  }

  public ECMAdditionalDataUpdate utilityBillDetails(UtilityBillDetails utilityBillDetails) {
    this.utilityBillDetails = utilityBillDetails;
    return this;
  }

   /**
   * Get utilityBillDetails
   * @return utilityBillDetails
  **/
  @Schema(description = "")
  public UtilityBillDetails getUtilityBillDetails() {
    return utilityBillDetails;
  }

  public void setUtilityBillDetails(UtilityBillDetails utilityBillDetails) {
    this.utilityBillDetails = utilityBillDetails;
  }

  public ECMAdditionalDataUpdate billingCycleDay(String billingCycleDay) {
    this.billingCycleDay = billingCycleDay;
    return this;
  }

   /**
   * Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description.
   * @return billingCycleDay
  **/
  @Schema(description = "Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description.")
  public String getBillingCycleDay() {
    return billingCycleDay;
  }

  public void setBillingCycleDay(String billingCycleDay) {
    this.billingCycleDay = billingCycleDay;
  }

  public ECMAdditionalDataUpdate applicationReferenceId(String applicationReferenceId) {
    this.applicationReferenceId = applicationReferenceId;
    return this;
  }

   /**
   * Unique reference ID associated with the application
   * @return applicationReferenceId
  **/
  @Schema(description = "Unique reference ID associated with the application")
  public String getApplicationReferenceId() {
    return applicationReferenceId;
  }

  public void setApplicationReferenceId(String applicationReferenceId) {
    this.applicationReferenceId = applicationReferenceId;
  }

  public ECMAdditionalDataUpdate printingSerialNumber(String printingSerialNumber) {
    this.printingSerialNumber = printingSerialNumber;
    return this;
  }

   /**
   * This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between
   * @return printingSerialNumber
  **/
  @Schema(description = "This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between")
  public String getPrintingSerialNumber() {
    return printingSerialNumber;
  }

  public void setPrintingSerialNumber(String printingSerialNumber) {
    this.printingSerialNumber = printingSerialNumber;
  }

  public ECMAdditionalDataUpdate accountFundSource(String accountFundSource) {
    this.accountFundSource = accountFundSource;
    return this;
  }

   /**
   * Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description.
   * @return accountFundSource
  **/
  @Schema(example = "BUSINESS_INCOME", description = "Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description.")
  public String getAccountFundSource() {
    return accountFundSource;
  }

  public void setAccountFundSource(String accountFundSource) {
    this.accountFundSource = accountFundSource;
  }

  public ECMAdditionalDataUpdate mediaId(String mediaId) {
    this.mediaId = mediaId;
    return this;
  }

   /**
   * The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application
   * @return mediaId
  **/
  @Schema(example = "71580", description = "The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application")
  public String getMediaId() {
    return mediaId;
  }

  public void setMediaId(String mediaId) {
    this.mediaId = mediaId;
  }

  public ECMAdditionalDataUpdate referralTracking(ReferralTracking referralTracking) {
    this.referralTracking = referralTracking;
    return this;
  }

   /**
   * Get referralTracking
   * @return referralTracking
  **/
  @Schema(description = "")
  public ReferralTracking getReferralTracking() {
    return referralTracking;
  }

  public void setReferralTracking(ReferralTracking referralTracking) {
    this.referralTracking = referralTracking;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ECMAdditionalDataUpdate ecMAdditionalDataUpdate = (ECMAdditionalDataUpdate) o;
    return Objects.equals(this.cashPinFlag, ecMAdditionalDataUpdate.cashPinFlag) &&
        Objects.equals(this.utilityBillDetails, ecMAdditionalDataUpdate.utilityBillDetails) &&
        Objects.equals(this.billingCycleDay, ecMAdditionalDataUpdate.billingCycleDay) &&
        Objects.equals(this.applicationReferenceId, ecMAdditionalDataUpdate.applicationReferenceId) &&
        Objects.equals(this.printingSerialNumber, ecMAdditionalDataUpdate.printingSerialNumber) &&
        Objects.equals(this.accountFundSource, ecMAdditionalDataUpdate.accountFundSource) &&
        Objects.equals(this.mediaId, ecMAdditionalDataUpdate.mediaId) &&
        Objects.equals(this.referralTracking, ecMAdditionalDataUpdate.referralTracking);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cashPinFlag, utilityBillDetails, billingCycleDay, applicationReferenceId, printingSerialNumber, accountFundSource, mediaId, referralTracking);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ECMAdditionalDataUpdate {\n");
    
    sb.append("    cashPinFlag: ").append(toIndentedString(cashPinFlag)).append("\n");
    sb.append("    utilityBillDetails: ").append(toIndentedString(utilityBillDetails)).append("\n");
    sb.append("    billingCycleDay: ").append(toIndentedString(billingCycleDay)).append("\n");
    sb.append("    applicationReferenceId: ").append(toIndentedString(applicationReferenceId)).append("\n");
    sb.append("    printingSerialNumber: ").append(toIndentedString(printingSerialNumber)).append("\n");
    sb.append("    accountFundSource: ").append(toIndentedString(accountFundSource)).append("\n");
    sb.append("    mediaId: ").append(toIndentedString(mediaId)).append("\n");
    sb.append("    referralTracking: ").append(toIndentedString(referralTracking)).append("\n");
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
