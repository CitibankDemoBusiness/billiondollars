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
import io.swagger.client.model.Loan;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * LoanSummaryResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class LoanSummaryResponse {
  @SerializedName("loans")
  private List<Loan> loans = null;

  @SerializedName("nextStartIndex")
  private String nextStartIndex = null;

  public LoanSummaryResponse loans(List<Loan> loans) {
    this.loans = loans;
    return this;
  }

  public LoanSummaryResponse addLoansItem(Loan loansItem) {
    if (this.loans == null) {
      this.loans = new ArrayList<Loan>();
    }
    this.loans.add(loansItem);
    return this;
  }

   /**
   * Get loans
   * @return loans
  **/
  @Schema(description = "")
  public List<Loan> getLoans() {
    return loans;
  }

  public void setLoans(List<Loan> loans) {
    this.loans = loans;
  }

  public LoanSummaryResponse nextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
    return this;
  }

   /**
   * The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.
   * @return nextStartIndex
  **/
  @Schema(example = "11", description = "The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.")
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
    LoanSummaryResponse loanSummaryResponse = (LoanSummaryResponse) o;
    return Objects.equals(this.loans, loanSummaryResponse.loans) &&
        Objects.equals(this.nextStartIndex, loanSummaryResponse.nextStartIndex);
  }

  @Override
  public int hashCode() {
    return Objects.hash(loans, nextStartIndex);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LoanSummaryResponse {\n");
    
    sb.append("    loans: ").append(toIndentedString(loans)).append("\n");
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
