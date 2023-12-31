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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import org.threeten.bp.LocalDate;
/**
 * StatementList
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class StatementList {
  @SerializedName("statementId")
  private String statementId = null;

  @SerializedName("statementDate")
  private LocalDate statementDate = null;

  public StatementList statementId(String statementId) {
    this.statementId = statementId;
    return this;
  }

   /**
   * Unique identifier for the statement
   * @return statementId
  **/
  @Schema(example = "123456789", description = "Unique identifier for the statement")
  public String getStatementId() {
    return statementId;
  }

  public void setStatementId(String statementId) {
    this.statementId = statementId;
  }

  public StatementList statementDate(LocalDate statementDate) {
    this.statementDate = statementDate;
    return this;
  }

   /**
   * Date on which the account statement has been generated in ISO 8601 date format YYYY-MM-DD
   * @return statementDate
  **/
  @Schema(example = "Mon Aug 01 00:00:00 UTC 2016", description = "Date on which the account statement has been generated in ISO 8601 date format YYYY-MM-DD")
  public LocalDate getStatementDate() {
    return statementDate;
  }

  public void setStatementDate(LocalDate statementDate) {
    this.statementDate = statementDate;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StatementList statementList = (StatementList) o;
    return Objects.equals(this.statementId, statementList.statementId) &&
        Objects.equals(this.statementDate, statementList.statementDate);
  }

  @Override
  public int hashCode() {
    return Objects.hash(statementId, statementDate);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StatementList {\n");
    
    sb.append("    statementId: ").append(toIndentedString(statementId)).append("\n");
    sb.append("    statementDate: ").append(toIndentedString(statementDate)).append("\n");
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
