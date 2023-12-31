<?php
/**
 * Transactions
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
 * Transactions Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class Transactions implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'Transactions';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'display_card_number' => 'string',
'card_holder_type' => 'string',
'transaction_date' => '\DateTime',
'transaction_posting_date' => '\DateTime',
'merchant_name' => 'string',
'transaction_code' => 'string',
'transaction_description' => 'string',
'transaction_type' => 'string',
'foreign_transaction_amount' => 'double',
'foreign_currency_code' => 'string',
'transaction_amount' => 'double',
'currency_code' => 'string',
'eligible_for_equal_payment_plan' => 'string',
'transaction_reference_id' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'display_card_number' => null,
'card_holder_type' => null,
'transaction_date' => 'date',
'transaction_posting_date' => 'date',
'merchant_name' => null,
'transaction_code' => null,
'transaction_description' => null,
'transaction_type' => null,
'foreign_transaction_amount' => 'double',
'foreign_currency_code' => null,
'transaction_amount' => 'double',
'currency_code' => null,
'eligible_for_equal_payment_plan' => null,
'transaction_reference_id' => null    ];

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
        'display_card_number' => 'displayCardNumber',
'card_holder_type' => 'cardHolderType',
'transaction_date' => 'transactionDate',
'transaction_posting_date' => 'transactionPostingDate',
'merchant_name' => 'merchantName',
'transaction_code' => 'transactionCode',
'transaction_description' => 'transactionDescription',
'transaction_type' => 'transactionType',
'foreign_transaction_amount' => 'foreignTransactionAmount',
'foreign_currency_code' => 'foreignCurrencyCode',
'transaction_amount' => 'transactionAmount',
'currency_code' => 'currencyCode',
'eligible_for_equal_payment_plan' => 'eligibleForEqualPaymentPlan',
'transaction_reference_id' => 'transactionReferenceId'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'display_card_number' => 'setDisplayCardNumber',
'card_holder_type' => 'setCardHolderType',
'transaction_date' => 'setTransactionDate',
'transaction_posting_date' => 'setTransactionPostingDate',
'merchant_name' => 'setMerchantName',
'transaction_code' => 'setTransactionCode',
'transaction_description' => 'setTransactionDescription',
'transaction_type' => 'setTransactionType',
'foreign_transaction_amount' => 'setForeignTransactionAmount',
'foreign_currency_code' => 'setForeignCurrencyCode',
'transaction_amount' => 'setTransactionAmount',
'currency_code' => 'setCurrencyCode',
'eligible_for_equal_payment_plan' => 'setEligibleForEqualPaymentPlan',
'transaction_reference_id' => 'setTransactionReferenceId'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'display_card_number' => 'getDisplayCardNumber',
'card_holder_type' => 'getCardHolderType',
'transaction_date' => 'getTransactionDate',
'transaction_posting_date' => 'getTransactionPostingDate',
'merchant_name' => 'getMerchantName',
'transaction_code' => 'getTransactionCode',
'transaction_description' => 'getTransactionDescription',
'transaction_type' => 'getTransactionType',
'foreign_transaction_amount' => 'getForeignTransactionAmount',
'foreign_currency_code' => 'getForeignCurrencyCode',
'transaction_amount' => 'getTransactionAmount',
'currency_code' => 'getCurrencyCode',
'eligible_for_equal_payment_plan' => 'getEligibleForEqualPaymentPlan',
'transaction_reference_id' => 'getTransactionReferenceId'    ];

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
        $this->container['display_card_number'] = isset($data['display_card_number']) ? $data['display_card_number'] : null;
        $this->container['card_holder_type'] = isset($data['card_holder_type']) ? $data['card_holder_type'] : null;
        $this->container['transaction_date'] = isset($data['transaction_date']) ? $data['transaction_date'] : null;
        $this->container['transaction_posting_date'] = isset($data['transaction_posting_date']) ? $data['transaction_posting_date'] : null;
        $this->container['merchant_name'] = isset($data['merchant_name']) ? $data['merchant_name'] : null;
        $this->container['transaction_code'] = isset($data['transaction_code']) ? $data['transaction_code'] : null;
        $this->container['transaction_description'] = isset($data['transaction_description']) ? $data['transaction_description'] : null;
        $this->container['transaction_type'] = isset($data['transaction_type']) ? $data['transaction_type'] : null;
        $this->container['foreign_transaction_amount'] = isset($data['foreign_transaction_amount']) ? $data['foreign_transaction_amount'] : null;
        $this->container['foreign_currency_code'] = isset($data['foreign_currency_code']) ? $data['foreign_currency_code'] : null;
        $this->container['transaction_amount'] = isset($data['transaction_amount']) ? $data['transaction_amount'] : null;
        $this->container['currency_code'] = isset($data['currency_code']) ? $data['currency_code'] : null;
        $this->container['eligible_for_equal_payment_plan'] = isset($data['eligible_for_equal_payment_plan']) ? $data['eligible_for_equal_payment_plan'] : null;
        $this->container['transaction_reference_id'] = isset($data['transaction_reference_id']) ? $data['transaction_reference_id'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['display_card_number'] === null) {
            $invalidProperties[] = "'display_card_number' can't be null";
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
     * Gets display_card_number
     *
     * @return string
     */
    public function getDisplayCardNumber()
    {
        return $this->container['display_card_number'];
    }

    /**
     * Sets display_card_number
     *
     * @param string $display_card_number A masked card number that can be displayed to the customer
     *
     * @return $this
     */
    public function setDisplayCardNumber($display_card_number)
    {
        $this->container['display_card_number'] = $display_card_number;

        return $this;
    }

    /**
     * Gets card_holder_type
     *
     * @return string
     */
    public function getCardHolderType()
    {
        return $this->container['card_holder_type'];
    }

    /**
     * Sets card_holder_type
     *
     * @param string $card_holder_type Indicator to specify whether the card is primary or supplementary.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setCardHolderType($card_holder_type)
    {
        $this->container['card_holder_type'] = $card_holder_type;

        return $this;
    }

    /**
     * Gets transaction_date
     *
     * @return \DateTime
     */
    public function getTransactionDate()
    {
        return $this->container['transaction_date'];
    }

    /**
     * Sets transaction_date
     *
     * @param \DateTime $transaction_date The transaction date in ISO 8601 format YYYY-MM-DD
     *
     * @return $this
     */
    public function setTransactionDate($transaction_date)
    {
        $this->container['transaction_date'] = $transaction_date;

        return $this;
    }

    /**
     * Gets transaction_posting_date
     *
     * @return \DateTime
     */
    public function getTransactionPostingDate()
    {
        return $this->container['transaction_posting_date'];
    }

    /**
     * Sets transaction_posting_date
     *
     * @param \DateTime $transaction_posting_date The transaction posting date in ISO 8601 format YYYY-MM-DD
     *
     * @return $this
     */
    public function setTransactionPostingDate($transaction_posting_date)
    {
        $this->container['transaction_posting_date'] = $transaction_posting_date;

        return $this;
    }

    /**
     * Gets merchant_name
     *
     * @return string
     */
    public function getMerchantName()
    {
        return $this->container['merchant_name'];
    }

    /**
     * Sets merchant_name
     *
     * @param string $merchant_name The merchant name with which this transaction was made.
     *
     * @return $this
     */
    public function setMerchantName($merchant_name)
    {
        $this->container['merchant_name'] = $merchant_name;

        return $this;
    }

    /**
     * Gets transaction_code
     *
     * @return string
     */
    public function getTransactionCode()
    {
        return $this->container['transaction_code'];
    }

    /**
     * Sets transaction_code
     *
     * @param string $transaction_code The transaction code
     *
     * @return $this
     */
    public function setTransactionCode($transaction_code)
    {
        $this->container['transaction_code'] = $transaction_code;

        return $this;
    }

    /**
     * Gets transaction_description
     *
     * @return string
     */
    public function getTransactionDescription()
    {
        return $this->container['transaction_description'];
    }

    /**
     * Sets transaction_description
     *
     * @param string $transaction_description Transaction description from the merchant, POS or bank.
     *
     * @return $this
     */
    public function setTransactionDescription($transaction_description)
    {
        $this->container['transaction_description'] = $transaction_description;

        return $this;
    }

    /**
     * Gets transaction_type
     *
     * @return string
     */
    public function getTransactionType()
    {
        return $this->container['transaction_type'];
    }

    /**
     * Sets transaction_type
     *
     * @param string $transaction_type The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setTransactionType($transaction_type)
    {
        $this->container['transaction_type'] = $transaction_type;

        return $this;
    }

    /**
     * Gets foreign_transaction_amount
     *
     * @return double
     */
    public function getForeignTransactionAmount()
    {
        return $this->container['foreign_transaction_amount'];
    }

    /**
     * Sets foreign_transaction_amount
     *
     * @param double $foreign_transaction_amount The transaction amount in the foreign currency
     *
     * @return $this
     */
    public function setForeignTransactionAmount($foreign_transaction_amount)
    {
        $this->container['foreign_transaction_amount'] = $foreign_transaction_amount;

        return $this;
    }

    /**
     * Gets foreign_currency_code
     *
     * @return string
     */
    public function getForeignCurrencyCode()
    {
        return $this->container['foreign_currency_code'];
    }

    /**
     * Sets foreign_currency_code
     *
     * @param string $foreign_currency_code The foreign currency code of the transaction in ISO 4217 format
     *
     * @return $this
     */
    public function setForeignCurrencyCode($foreign_currency_code)
    {
        $this->container['foreign_currency_code'] = $foreign_currency_code;

        return $this;
    }

    /**
     * Gets transaction_amount
     *
     * @return double
     */
    public function getTransactionAmount()
    {
        return $this->container['transaction_amount'];
    }

    /**
     * Sets transaction_amount
     *
     * @param double $transaction_amount Transaction amount in local currency
     *
     * @return $this
     */
    public function setTransactionAmount($transaction_amount)
    {
        $this->container['transaction_amount'] = $transaction_amount;

        return $this;
    }

    /**
     * Gets currency_code
     *
     * @return string
     */
    public function getCurrencyCode()
    {
        return $this->container['currency_code'];
    }

    /**
     * Sets currency_code
     *
     * @param string $currency_code The currency code of the transaction in ISO 4217 format
     *
     * @return $this
     */
    public function setCurrencyCode($currency_code)
    {
        $this->container['currency_code'] = $currency_code;

        return $this;
    }

    /**
     * Gets eligible_for_equal_payment_plan
     *
     * @return string
     */
    public function getEligibleForEqualPaymentPlan()
    {
        return $this->container['eligible_for_equal_payment_plan'];
    }

    /**
     * Sets eligible_for_equal_payment_plan
     *
     * @param string $eligible_for_equal_payment_plan The EPP allowed indicator. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setEligibleForEqualPaymentPlan($eligible_for_equal_payment_plan)
    {
        $this->container['eligible_for_equal_payment_plan'] = $eligible_for_equal_payment_plan;

        return $this;
    }

    /**
     * Gets transaction_reference_id
     *
     * @return string
     */
    public function getTransactionReferenceId()
    {
        return $this->container['transaction_reference_id'];
    }

    /**
     * Sets transaction_reference_id
     *
     * @param string $transaction_reference_id The unique transaction reference Id used to identify this transaction from all the other transactions,
     *
     * @return $this
     */
    public function setTransactionReferenceId($transaction_reference_id)
    {
        $this->container['transaction_reference_id'] = $transaction_reference_id;

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
