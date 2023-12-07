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
import io.swagger.client.model.CreditCardStatement;
import io.swagger.client.model.ErrorResponse;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * CreditCardStatementSummary
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class CreditCardStatementSummary {
  @SerializedName("cardId")
  private String cardId = null;

  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("eligibleSourceAcctsForPaymentFlag")
  private Boolean eligibleSourceAcctsForPaymentFlag = null;

  @SerializedName("eppEligibleAmount")
  private Double eppEligibleAmount = null;

  @SerializedName("eppMinimumEligibleAmount")
  private Double eppMinimumEligibleAmount = null;

  @SerializedName("eppMinimumInstallmentAmount")
  private Double eppMinimumInstallmentAmount = null;

  @SerializedName("creditCardStatement")
  private List<CreditCardStatement> creditCardStatement = null;

  @SerializedName("statementSummaryErrorDetails")
  private ErrorResponse statementSummaryErrorDetails = null;

  @SerializedName("nextStartIndex")
  private String nextStartIndex = null;

  public CreditCardStatementSummary cardId(String cardId) {
    this.cardId = cardId;
    return this;
  }

   /**
   * The card id  in encrypted format
   * @return cardId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", required = true, description = "The card id  in encrypted format")
  public String getCardId() {
    return cardId;
  }

  public void setCardId(String cardId) {
    this.cardId = cardId;
  }

  public CreditCardStatementSummary displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayAccountNumber
  **/
  @Schema(example = "XXXXXXXXXXXX2364", required = true, description = "A masked account number that can be displayed to the customer")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public CreditCardStatementSummary eligibleSourceAcctsForPaymentFlag(Boolean eligibleSourceAcctsForPaymentFlag) {
    this.eligibleSourceAcctsForPaymentFlag = eligibleSourceAcctsForPaymentFlag;
    return this;
  }

   /**
   * ’Flag to indicate if eligible source accounts are available to make credit card payment on-line.
   * @return eligibleSourceAcctsForPaymentFlag
  **/
  @Schema(example = "true", description = "’Flag to indicate if eligible source accounts are available to make credit card payment on-line.")
  public Boolean isEligibleSourceAcctsForPaymentFlag() {
    return eligibleSourceAcctsForPaymentFlag;
  }

  public void setEligibleSourceAcctsForPaymentFlag(Boolean eligibleSourceAcctsForPaymentFlag) {
    this.eligibleSourceAcctsForPaymentFlag = eligibleSourceAcctsForPaymentFlag;
  }

  public CreditCardStatementSummary eppEligibleAmount(Double eppEligibleAmount) {
    this.eppEligibleAmount = eppEligibleAmount;
    return this;
  }

   /**
   * Eligible amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;.
   * @return eppEligibleAmount
  **/
  @Schema(example = "2500.25", description = "Eligible amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.")
  public Double getEppEligibleAmount() {
    return eppEligibleAmount;
  }

  public void setEppEligibleAmount(Double eppEligibleAmount) {
    this.eppEligibleAmount = eppEligibleAmount;
  }

  public CreditCardStatementSummary eppMinimumEligibleAmount(Double eppMinimumEligibleAmount) {
    this.eppMinimumEligibleAmount = eppMinimumEligibleAmount;
    return this;
  }

   /**
   * Minimum eligible amount for which Equal Payment Plan can be booked. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;.
   * @return eppMinimumEligibleAmount
  **/
  @Schema(example = "1000.25", description = "Minimum eligible amount for which Equal Payment Plan can be booked. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.")
  public Double getEppMinimumEligibleAmount() {
    return eppMinimumEligibleAmount;
  }

  public void setEppMinimumEligibleAmount(Double eppMinimumEligibleAmount) {
    this.eppMinimumEligibleAmount = eppMinimumEligibleAmount;
  }

  public CreditCardStatementSummary eppMinimumInstallmentAmount(Double eppMinimumInstallmentAmount) {
    this.eppMinimumInstallmentAmount = eppMinimumInstallmentAmount;
    return this;
  }

   /**
   * Minimum instalment amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;.
   * @return eppMinimumInstallmentAmount
  **/
  @Schema(example = "200.25", description = "Minimum instalment amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.")
  public Double getEppMinimumInstallmentAmount() {
    return eppMinimumInstallmentAmount;
  }

  public void setEppMinimumInstallmentAmount(Double eppMinimumInstallmentAmount) {
    this.eppMinimumInstallmentAmount = eppMinimumInstallmentAmount;
  }

  public CreditCardStatementSummary creditCardStatement(List<CreditCardStatement> creditCardStatement) {
    this.creditCardStatement = creditCardStatement;
    return this;
  }

  public CreditCardStatementSummary addCreditCardStatementItem(CreditCardStatement creditCardStatementItem) {
    if (this.creditCardStatement == null) {
      this.creditCardStatement = new ArrayList<CreditCardStatement>();
    }
    this.creditCardStatement.add(creditCardStatementItem);
    return this;
  }

   /**
   * Get creditCardStatement
   * @return creditCardStatement
  **/
  @Schema(description = "")
  public List<CreditCardStatement> getCreditCardStatement() {
    return creditCardStatement;
  }

  public void setCreditCardStatement(List<CreditCardStatement> creditCardStatement) {
    this.creditCardStatement = creditCardStatement;
  }

  public CreditCardStatementSummary statementSummaryErrorDetails(ErrorResponse statementSummaryErrorDetails) {
    this.statementSummaryErrorDetails = statementSummaryErrorDetails;
    return this;
  }

   /**
   * Get statementSummaryErrorDetails
   * @return statementSummaryErrorDetails
  **/
  @Schema(description = "")
  public ErrorResponse getStatementSummaryErrorDetails() {
    return statementSummaryErrorDetails;
  }

  public void setStatementSummaryErrorDetails(ErrorResponse statementSummaryErrorDetails) {
    this.statementSummaryErrorDetails = statementSummaryErrorDetails;
  }

  public CreditCardStatementSummary nextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
    return this;
  }

   /**
   * In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
   * @return nextStartIndex
  **/
  @Schema(example = "11", description = "In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.")
  public String getNextStartIndex() {
    return nextStartIndex;
  }

  public void setNextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CreditCardStatementSummary creditCardStatementSummary = (CreditCardStatementSummary) o;
    return Objects.equals(this.cardId, creditCardStatementSummary.cardId) &&
        Objects.equals(this.displayAccountNumber, creditCardStatementSummary.displayAccountNumber) &&
        Objects.equals(this.eligibleSourceAcctsForPaymentFlag, creditCardStatementSummary.eligibleSourceAcctsForPaymentFlag) &&
        Objects.equals(this.eppEligibleAmount, creditCardStatementSummary.eppEligibleAmount) &&
        Objects.equals(this.eppMinimumEligibleAmount, creditCardStatementSummary.eppMinimumEligibleAmount) &&
        Objects.equals(this.eppMinimumInstallmentAmount, creditCardStatementSummary.eppMinimumInstallmentAmount) &&
        Objects.equals(this.creditCardStatement, creditCardStatementSummary.creditCardStatement) &&
        Objects.equals(this.statementSummaryErrorDetails, creditCardStatementSummary.statementSummaryErrorDetails) &&
        Objects.equals(this.nextStartIndex, creditCardStatementSummary.nextStartIndex);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cardId, displayAccountNumber, eligibleSourceAcctsForPaymentFlag, eppEligibleAmount, eppMinimumEligibleAmount, eppMinimumInstallmentAmount, creditCardStatement, statementSummaryErrorDetails, nextStartIndex);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CreditCardStatementSummary {\n");
    
    sb.append("    cardId: ").append(toIndentedString(cardId)).append("\n");
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    eligibleSourceAcctsForPaymentFlag: ").append(toIndentedString(eligibleSourceAcctsForPaymentFlag)).append("\n");
    sb.append("    eppEligibleAmount: ").append(toIndentedString(eppEligibleAmount)).append("\n");
    sb.append("    eppMinimumEligibleAmount: ").append(toIndentedString(eppMinimumEligibleAmount)).append("\n");
    sb.append("    eppMinimumInstallmentAmount: ").append(toIndentedString(eppMinimumInstallmentAmount)).append("\n");
    sb.append("    creditCardStatement: ").append(toIndentedString(creditCardStatement)).append("\n");
    sb.append("    statementSummaryErrorDetails: ").append(toIndentedString(statementSummaryErrorDetails)).append("\n");
    sb.append("    nextStartIndex: ").append(toIndentedString(nextStartIndex)).append("\n");
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
