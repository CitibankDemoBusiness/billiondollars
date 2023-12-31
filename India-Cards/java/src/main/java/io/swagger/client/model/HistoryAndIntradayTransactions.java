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
import io.swagger.client.model.HistoryAndIntradayTransactionRecords;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * HistoryAndIntradayTransactions
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class HistoryAndIntradayTransactions {
  @SerializedName("nextStartIndex")
  private String nextStartIndex = null;

  @SerializedName("moreIndicator")
  private String moreIndicator = null;

  @SerializedName("numberOfTransactions")
  private Integer numberOfTransactions = null;

  @SerializedName("historyAndIntradayTransactionRecords")
  private List<HistoryAndIntradayTransactionRecords> historyAndIntradayTransactionRecords = null;

  public HistoryAndIntradayTransactions nextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
    return this;
  }

   /**
   * For pagination - the starting index for retrieving the next page/batch of records.
   * @return nextStartIndex
  **/
  @Schema(example = "21", description = "For pagination - the starting index for retrieving the next page/batch of records.")
  public String getNextStartIndex() {
    return nextStartIndex;
  }

  public void setNextStartIndex(String nextStartIndex) {
    this.nextStartIndex = nextStartIndex;
  }

  public HistoryAndIntradayTransactions moreIndicator(String moreIndicator) {
    this.moreIndicator = moreIndicator;
    return this;
  }

   /**
   * This field indicates that more records are available for retrieval.
   * @return moreIndicator
  **/
  @Schema(example = "Y", description = "This field indicates that more records are available for retrieval.")
  public String getMoreIndicator() {
    return moreIndicator;
  }

  public void setMoreIndicator(String moreIndicator) {
    this.moreIndicator = moreIndicator;
  }

  public HistoryAndIntradayTransactions numberOfTransactions(Integer numberOfTransactions) {
    this.numberOfTransactions = numberOfTransactions;
    return this;
  }

   /**
   * Number of Transactions
   * @return numberOfTransactions
  **/
  @Schema(example = "20", description = "Number of Transactions")
  public Integer getNumberOfTransactions() {
    return numberOfTransactions;
  }

  public void setNumberOfTransactions(Integer numberOfTransactions) {
    this.numberOfTransactions = numberOfTransactions;
  }

  public HistoryAndIntradayTransactions historyAndIntradayTransactionRecords(List<HistoryAndIntradayTransactionRecords> historyAndIntradayTransactionRecords) {
    this.historyAndIntradayTransactionRecords = historyAndIntradayTransactionRecords;
    return this;
  }

  public HistoryAndIntradayTransactions addHistoryAndIntradayTransactionRecordsItem(HistoryAndIntradayTransactionRecords historyAndIntradayTransactionRecordsItem) {
    if (this.historyAndIntradayTransactionRecords == null) {
      this.historyAndIntradayTransactionRecords = new ArrayList<HistoryAndIntradayTransactionRecords>();
    }
    this.historyAndIntradayTransactionRecords.add(historyAndIntradayTransactionRecordsItem);
    return this;
  }

   /**
   * Get historyAndIntradayTransactionRecords
   * @return historyAndIntradayTransactionRecords
  **/
  @Schema(description = "")
  public List<HistoryAndIntradayTransactionRecords> getHistoryAndIntradayTransactionRecords() {
    return historyAndIntradayTransactionRecords;
  }

  public void setHistoryAndIntradayTransactionRecords(List<HistoryAndIntradayTransactionRecords> historyAndIntradayTransactionRecords) {
    this.historyAndIntradayTransactionRecords = historyAndIntradayTransactionRecords;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    HistoryAndIntradayTransactions historyAndIntradayTransactions = (HistoryAndIntradayTransactions) o;
    return Objects.equals(this.nextStartIndex, historyAndIntradayTransactions.nextStartIndex) &&
        Objects.equals(this.moreIndicator, historyAndIntradayTransactions.moreIndicator) &&
        Objects.equals(this.numberOfTransactions, historyAndIntradayTransactions.numberOfTransactions) &&
        Objects.equals(this.historyAndIntradayTransactionRecords, historyAndIntradayTransactions.historyAndIntradayTransactionRecords);
  }

  @Override
  public int hashCode() {
    return Objects.hash(nextStartIndex, moreIndicator, numberOfTransactions, historyAndIntradayTransactionRecords);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class HistoryAndIntradayTransactions {\n");
    
    sb.append("    nextStartIndex: ").append(toIndentedString(nextStartIndex)).append("\n");
    sb.append("    moreIndicator: ").append(toIndentedString(moreIndicator)).append("\n");
    sb.append("    numberOfTransactions: ").append(toIndentedString(numberOfTransactions)).append("\n");
    sb.append("    historyAndIntradayTransactionRecords: ").append(toIndentedString(historyAndIntradayTransactionRecords)).append("\n");
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
