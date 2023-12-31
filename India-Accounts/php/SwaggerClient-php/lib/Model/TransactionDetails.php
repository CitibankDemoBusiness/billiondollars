<?php
/**
 * TransactionDetails
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.29
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * TransactionDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class TransactionDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'TransactionDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'account_id' => 'string',
'transactions' => '\Swagger\Client\Model\Transaction[]',
'statements' => '\Swagger\Client\Model\Statements[]',
'investment_transaction' => '\Swagger\Client\Model\InvestmentTransaction[]',
'transaction_error_details' => '\Swagger\Client\Model\ErrorResponse',
'next_start_index' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'account_id' => null,
'transactions' => null,
'statements' => null,
'investment_transaction' => null,
'transaction_error_details' => null,
'next_start_index' => null    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'account_id' => 'accountId',
'transactions' => 'transactions',
'statements' => 'statements',
'investment_transaction' => 'investmentTransaction',
'transaction_error_details' => 'transactionErrorDetails',
'next_start_index' => 'nextStartIndex'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'account_id' => 'setAccountId',
'transactions' => 'setTransactions',
'statements' => 'setStatements',
'investment_transaction' => 'setInvestmentTransaction',
'transaction_error_details' => 'setTransactionErrorDetails',
'next_start_index' => 'setNextStartIndex'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'account_id' => 'getAccountId',
'transactions' => 'getTransactions',
'statements' => 'getStatements',
'investment_transaction' => 'getInvestmentTransaction',
'transaction_error_details' => 'getTransactionErrorDetails',
'next_start_index' => 'getNextStartIndex'    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['account_id'] = isset($data['account_id']) ? $data['account_id'] : null;
        $this->container['transactions'] = isset($data['transactions']) ? $data['transactions'] : null;
        $this->container['statements'] = isset($data['statements']) ? $data['statements'] : null;
        $this->container['investment_transaction'] = isset($data['investment_transaction']) ? $data['investment_transaction'] : null;
        $this->container['transaction_error_details'] = isset($data['transaction_error_details']) ? $data['transaction_error_details'] : null;
        $this->container['next_start_index'] = isset($data['next_start_index']) ? $data['next_start_index'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['account_id'] === null) {
            $invalidProperties[] = "'account_id' can't be null";
        }
        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets account_id
     *
     * @return string
     */
    public function getAccountId()
    {
        return $this->container['account_id'];
    }

    /**
     * Sets account_id
     *
     * @param string $account_id The account identifier in encrypted format.Typically, this is not displayed to the customer.
     *
     * @return $this
     */
    public function setAccountId($account_id)
    {
        $this->container['account_id'] = $account_id;

        return $this;
    }

    /**
     * Gets transactions
     *
     * @return \Swagger\Client\Model\Transaction[]
     */
    public function getTransactions()
    {
        return $this->container['transactions'];
    }

    /**
     * Sets transactions
     *
     * @param \Swagger\Client\Model\Transaction[] $transactions Transactions list
     *
     * @return $this
     */
    public function setTransactions($transactions)
    {
        $this->container['transactions'] = $transactions;

        return $this;
    }

    /**
     * Gets statements
     *
     * @return \Swagger\Client\Model\Statements[]
     */
    public function getStatements()
    {
        return $this->container['statements'];
    }

    /**
     * Sets statements
     *
     * @param \Swagger\Client\Model\Statements[] $statements Applicable only for credit cards and will be returned only in the first request. If there is additional data available then in subsequent request this will not be returned.
     *
     * @return $this
     */
    public function setStatements($statements)
    {
        $this->container['statements'] = $statements;

        return $this;
    }

    /**
     * Gets investment_transaction
     *
     * @return \Swagger\Client\Model\InvestmentTransaction[]
     */
    public function getInvestmentTransaction()
    {
        return $this->container['investment_transaction'];
    }

    /**
     * Sets investment_transaction
     *
     * @param \Swagger\Client\Model\InvestmentTransaction[] $investment_transaction Investment Transactions list
     *
     * @return $this
     */
    public function setInvestmentTransaction($investment_transaction)
    {
        $this->container['investment_transaction'] = $investment_transaction;

        return $this;
    }

    /**
     * Gets transaction_error_details
     *
     * @return \Swagger\Client\Model\ErrorResponse
     */
    public function getTransactionErrorDetails()
    {
        return $this->container['transaction_error_details'];
    }

    /**
     * Sets transaction_error_details
     *
     * @param \Swagger\Client\Model\ErrorResponse $transaction_error_details transaction_error_details
     *
     * @return $this
     */
    public function setTransactionErrorDetails($transaction_error_details)
    {
        $this->container['transaction_error_details'] = $transaction_error_details;

        return $this;
    }

    /**
     * Gets next_start_index
     *
     * @return string
     */
    public function getNextStartIndex()
    {
        return $this->container['next_start_index'];
    }

    /**
     * Sets next_start_index
     *
     * @param string $next_start_index In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
     *
     * @return $this
     */
    public function setNextStartIndex($next_start_index)
    {
        $this->container['next_start_index'] = $next_start_index;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
