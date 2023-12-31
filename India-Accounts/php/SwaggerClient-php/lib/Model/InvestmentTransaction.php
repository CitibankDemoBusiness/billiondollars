<?php
/**
 * InvestmentTransaction
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
 * InvestmentTransaction Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class InvestmentTransaction implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'InvestmentTransaction';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'order_date' => '\DateTime',
'order_reference_id' => 'string',
'order_type' => 'string',
'code' => 'string',
'name' => 'string',
'currency_code' => 'string',
'transaction_amount' => 'double',
'price' => 'double',
'order_status' => 'string',
'gross_amount' => 'double',
'order_quantity' => 'double',
'order_medium' => 'string',
'filled_quantity' => 'double',
'balance_quantity' => 'double',
'stock_market_code' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'order_date' => 'date',
'order_reference_id' => null,
'order_type' => null,
'code' => null,
'name' => null,
'currency_code' => null,
'transaction_amount' => 'double',
'price' => 'double',
'order_status' => null,
'gross_amount' => 'double',
'order_quantity' => 'double',
'order_medium' => null,
'filled_quantity' => 'double',
'balance_quantity' => 'double',
'stock_market_code' => null    ];

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
        'order_date' => 'orderDate',
'order_reference_id' => 'orderReferenceId',
'order_type' => 'orderType',
'code' => 'code',
'name' => 'name',
'currency_code' => 'currencyCode',
'transaction_amount' => 'transactionAmount',
'price' => 'price',
'order_status' => 'orderStatus',
'gross_amount' => 'grossAmount',
'order_quantity' => 'orderQuantity',
'order_medium' => 'orderMedium',
'filled_quantity' => 'filledQuantity',
'balance_quantity' => 'balanceQuantity',
'stock_market_code' => 'stockMarketCode'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'order_date' => 'setOrderDate',
'order_reference_id' => 'setOrderReferenceId',
'order_type' => 'setOrderType',
'code' => 'setCode',
'name' => 'setName',
'currency_code' => 'setCurrencyCode',
'transaction_amount' => 'setTransactionAmount',
'price' => 'setPrice',
'order_status' => 'setOrderStatus',
'gross_amount' => 'setGrossAmount',
'order_quantity' => 'setOrderQuantity',
'order_medium' => 'setOrderMedium',
'filled_quantity' => 'setFilledQuantity',
'balance_quantity' => 'setBalanceQuantity',
'stock_market_code' => 'setStockMarketCode'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'order_date' => 'getOrderDate',
'order_reference_id' => 'getOrderReferenceId',
'order_type' => 'getOrderType',
'code' => 'getCode',
'name' => 'getName',
'currency_code' => 'getCurrencyCode',
'transaction_amount' => 'getTransactionAmount',
'price' => 'getPrice',
'order_status' => 'getOrderStatus',
'gross_amount' => 'getGrossAmount',
'order_quantity' => 'getOrderQuantity',
'order_medium' => 'getOrderMedium',
'filled_quantity' => 'getFilledQuantity',
'balance_quantity' => 'getBalanceQuantity',
'stock_market_code' => 'getStockMarketCode'    ];

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
        $this->container['order_date'] = isset($data['order_date']) ? $data['order_date'] : null;
        $this->container['order_reference_id'] = isset($data['order_reference_id']) ? $data['order_reference_id'] : null;
        $this->container['order_type'] = isset($data['order_type']) ? $data['order_type'] : null;
        $this->container['code'] = isset($data['code']) ? $data['code'] : null;
        $this->container['name'] = isset($data['name']) ? $data['name'] : null;
        $this->container['currency_code'] = isset($data['currency_code']) ? $data['currency_code'] : null;
        $this->container['transaction_amount'] = isset($data['transaction_amount']) ? $data['transaction_amount'] : null;
        $this->container['price'] = isset($data['price']) ? $data['price'] : null;
        $this->container['order_status'] = isset($data['order_status']) ? $data['order_status'] : null;
        $this->container['gross_amount'] = isset($data['gross_amount']) ? $data['gross_amount'] : null;
        $this->container['order_quantity'] = isset($data['order_quantity']) ? $data['order_quantity'] : null;
        $this->container['order_medium'] = isset($data['order_medium']) ? $data['order_medium'] : null;
        $this->container['filled_quantity'] = isset($data['filled_quantity']) ? $data['filled_quantity'] : null;
        $this->container['balance_quantity'] = isset($data['balance_quantity']) ? $data['balance_quantity'] : null;
        $this->container['stock_market_code'] = isset($data['stock_market_code']) ? $data['stock_market_code'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

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
     * Gets order_date
     *
     * @return \DateTime
     */
    public function getOrderDate()
    {
        return $this->container['order_date'];
    }

    /**
     * Sets order_date
     *
     * @param \DateTime $order_date Order date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting
     *
     * @return $this
     */
    public function setOrderDate($order_date)
    {
        $this->container['order_date'] = $order_date;

        return $this;
    }

    /**
     * Gets order_reference_id
     *
     * @return string
     */
    public function getOrderReferenceId()
    {
        return $this->container['order_reference_id'];
    }

    /**
     * Sets order_reference_id
     *
     * @param string $order_reference_id Reference Id to uniquely identify the investment transaction
     *
     * @return $this
     */
    public function setOrderReferenceId($order_reference_id)
    {
        $this->container['order_reference_id'] = $order_reference_id;

        return $this;
    }

    /**
     * Gets order_type
     *
     * @return string
     */
    public function getOrderType()
    {
        return $this->container['order_type'];
    }

    /**
     * Sets order_type
     *
     * @param string $order_type This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderType} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setOrderType($order_type)
    {
        $this->container['order_type'] = $order_type;

        return $this;
    }

    /**
     * Gets code
     *
     * @return string
     */
    public function getCode()
    {
        return $this->container['code'];
    }

    /**
     * Sets code
     *
     * @param string $code Order code to uniquely identify the transaction,
     *
     * @return $this
     */
    public function setCode($code)
    {
        $this->container['code'] = $code;

        return $this;
    }

    /**
     * Gets name
     *
     * @return string
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     *
     * @param string $name Unique name  for fund/stock
     *
     * @return $this
     */
    public function setName($name)
    {
        $this->container['name'] = $name;

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
     * @param string $currency_code The currency code of the transaction in ISO 4217 format,
     *
     * @return $this
     */
    public function setCurrencyCode($currency_code)
    {
        $this->container['currency_code'] = $currency_code;

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
     * @param double $transaction_amount Transaction amount in local currency.
     *
     * @return $this
     */
    public function setTransactionAmount($transaction_amount)
    {
        $this->container['transaction_amount'] = $transaction_amount;

        return $this;
    }

    /**
     * Gets price
     *
     * @return double
     */
    public function getPrice()
    {
        return $this->container['price'];
    }

    /**
     * Sets price
     *
     * @param double $price Order price of  trade
     *
     * @return $this
     */
    public function setPrice($price)
    {
        $this->container['price'] = $price;

        return $this;
    }

    /**
     * Gets order_status
     *
     * @return string
     */
    public function getOrderStatus()
    {
        return $this->container['order_status'];
    }

    /**
     * Sets order_status
     *
     * @param string $order_status This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderStatus} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setOrderStatus($order_status)
    {
        $this->container['order_status'] = $order_status;

        return $this;
    }

    /**
     * Gets gross_amount
     *
     * @return double
     */
    public function getGrossAmount()
    {
        return $this->container['gross_amount'];
    }

    /**
     * Sets gross_amount
     *
     * @param double $gross_amount The total amount of the transaction
     *
     * @return $this
     */
    public function setGrossAmount($gross_amount)
    {
        $this->container['gross_amount'] = $gross_amount;

        return $this;
    }

    /**
     * Gets order_quantity
     *
     * @return double
     */
    public function getOrderQuantity()
    {
        return $this->container['order_quantity'];
    }

    /**
     * Sets order_quantity
     *
     * @param double $order_quantity Total number of units ordered
     *
     * @return $this
     */
    public function setOrderQuantity($order_quantity)
    {
        $this->container['order_quantity'] = $order_quantity;

        return $this;
    }

    /**
     * Gets order_medium
     *
     * @return string
     */
    public function getOrderMedium()
    {
        return $this->container['order_medium'];
    }

    /**
     * Sets order_medium
     *
     * @param string $order_medium The medium used by customer to place order.This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderMedium} resource to get possible values of This field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setOrderMedium($order_medium)
    {
        $this->container['order_medium'] = $order_medium;

        return $this;
    }

    /**
     * Gets filled_quantity
     *
     * @return double
     */
    public function getFilledQuantity()
    {
        return $this->container['filled_quantity'];
    }

    /**
     * Sets filled_quantity
     *
     * @param double $filled_quantity Number of units received
     *
     * @return $this
     */
    public function setFilledQuantity($filled_quantity)
    {
        $this->container['filled_quantity'] = $filled_quantity;

        return $this;
    }

    /**
     * Gets balance_quantity
     *
     * @return double
     */
    public function getBalanceQuantity()
    {
        return $this->container['balance_quantity'];
    }

    /**
     * Sets balance_quantity
     *
     * @param double $balance_quantity Number of units not received
     *
     * @return $this
     */
    public function setBalanceQuantity($balance_quantity)
    {
        $this->container['balance_quantity'] = $balance_quantity;

        return $this;
    }

    /**
     * Gets stock_market_code
     *
     * @return string
     */
    public function getStockMarketCode()
    {
        return $this->container['stock_market_code'];
    }

    /**
     * Sets stock_market_code
     *
     * @param string $stock_market_code Trading market code for securities
     *
     * @return $this
     */
    public function setStockMarketCode($stock_market_code)
    {
        $this->container['stock_market_code'] = $stock_market_code;

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
