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
import io.swagger.client.model.InvestmentTransaction;
import io.swagger.client.model.Transaction;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * TransactionDetailsResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class TransactionDetailsResponse {
  @SerializedName("transactions")
  private List<Transaction> transactions = null;

  @SerializedName("investmentTransaction")
  private List<InvestmentTransaction> investmentTransaction = null;

  @SerializedName("nextStartIndex")
  private String nextStartIndex = null;

  public TransactionDetailsResponse transactions(List<Transaction> transactions) {
    this.transactions = transactions;
    return this;
  }

  public TransactionDetailsResponse addTransactionsItem(Transaction transactionsItem) {
    if (this.transactions == null) {
      this.transactions = new ArrayList<Transaction>();
    }
    this.transactions.add(transactionsItem);
    return this;
  }

   /**
   * Transactions list
   * @return transactions
  **/
  @Schema(description = "Transactions list")
  public List<Transaction> getTransactions() {
    return transactions;
  }

  public void setTransactions(List<Transaction> transactions) {
    this.transactions = transactions;
  }

  public TransactionDetailsResponse investmentTransaction(List<InvestmentTransaction> investmentTransaction) {
    this.investmentTransaction = investmentTransaction;
    return this;
  }

  public TransactionDetailsResponse addInvestmentTransactionItem(InvestmentTransaction investmentTransactionItem) {
    if (this.investmentTransaction == null) {
      this.investmentTransaction = new ArrayList<InvestmentTransaction>();
    }
    this.investmentTransaction.add(investmentTransactionItem);
    return this;
  }

   /**
   * Investment Transactions list
   * @return investmentTransaction
  **/
  @Schema(description = "Investment Transactions list")
  public List<InvestmentTransaction> getInvestmentTransaction() {
    return investmentTransaction;
  }

  public void setInvestmentTransaction(List<InvestmentTransaction> investmentTransaction) {
    this.investmentTransaction = investmentTransaction;
  }

  public TransactionDetailsResponse nextStartIndex(String nextStartIndex) {
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
    TransactionDetailsResponse transactionDetailsResponse = (TransactionDetailsResponse) o;
    return Objects.equals(this.transactions, transactionDetailsResponse.transactions) &&
        Objects.equals(this.investmentTransaction, transactionDetailsResponse.investmentTransaction) &&
        Objects.equals(this.nextStartIndex, transactionDetailsResponse.nextStartIndex);
  }

  @Override
  public int hashCode() {
    return Objects.hash(transactions, investmentTransaction, nextStartIndex);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class TransactionDetailsResponse {\n");
    
    sb.append("    transactions: ").append(toIndentedString(transactions)).append("\n");
    sb.append("    investmentTransaction: ").append(toIndentedString(investmentTransaction)).append("\n");
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
