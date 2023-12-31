<?php
/**
 * DataFeesChargesFeeChargeDetail
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
 * DataFeesChargesFeeChargeDetail Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class DataFeesChargesFeeChargeDetail implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'data_fees_charges_fee_charge_detail';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'item' => 'string',
'chargeable' => 'bool',
'amount' => 'double',
'amount_currency_code' => 'string',
'percentage' => 'double',
'remark' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'item' => null,
'chargeable' => null,
'amount' => 'double',
'amount_currency_code' => null,
'percentage' => 'double',
'remark' => null    ];

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
        'item' => 'item',
'chargeable' => 'chargeable',
'amount' => 'amount',
'amount_currency_code' => 'amount_currency_code',
'percentage' => 'percentage',
'remark' => 'remark'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'item' => 'setItem',
'chargeable' => 'setChargeable',
'amount' => 'setAmount',
'amount_currency_code' => 'setAmountCurrencyCode',
'percentage' => 'setPercentage',
'remark' => 'setRemark'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'item' => 'getItem',
'chargeable' => 'getChargeable',
'amount' => 'getAmount',
'amount_currency_code' => 'getAmountCurrencyCode',
'percentage' => 'getPercentage',
'remark' => 'getRemark'    ];

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

    const ITEM_ACTUAL_MONTHLY_MANAGEMENT = 'actual_monthly_management';
const ITEM_ANNUAL = 'annual';
const ITEM_ATM_WITHDRAWAL = 'atm_withdrawal';
const ITEM_CARD_REPLACEMENT = 'card_replacement';
const ITEM_CASH_ADVANCE = 'cash_advance';
const ITEM_CASH_WITHDRAWAL = 'cash_withdrawal';
const ITEM_EARLY_SETTLEMENT = 'early_settlement';
const ITEM_FINANCE_CHARGE_CASH_ADVANCE = 'finance_charge_cash_advance';
const ITEM_FINANCE_CHARGE_RETAIL = 'finance_charge_retail';
const ITEM_FIXED_MONTHLY_MANAGEMENT = 'fixed_monthly_management';
const ITEM_LATE_PAYMENT = 'late_payment';
const ITEM_MINIMUM_MONTHLY_PAYMENT = 'minimum_monthly_payment';
const ITEM_OTHERS = 'others';
const ITEM_OVERSEA_TRANSACTION = 'oversea_transaction';
const ITEM_OVERSEA_TRANSACTION_CONVERSION = 'oversea_transaction_conversion';
const ITEM_SALES_DRAFT_RETRIEVAL_COPY = 'sales_draft_retrieval_copy';
const ITEM_SERVICE_TAX = 'service_tax';
const ITEM_STARTER_PACK = 'starter_pack';
const ITEM_STATEMENT_COPY = 'statement_copy';

    /**
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getItemAllowableValues()
    {
        return [
            self::ITEM_ACTUAL_MONTHLY_MANAGEMENT,
self::ITEM_ANNUAL,
self::ITEM_ATM_WITHDRAWAL,
self::ITEM_CARD_REPLACEMENT,
self::ITEM_CASH_ADVANCE,
self::ITEM_CASH_WITHDRAWAL,
self::ITEM_EARLY_SETTLEMENT,
self::ITEM_FINANCE_CHARGE_CASH_ADVANCE,
self::ITEM_FINANCE_CHARGE_RETAIL,
self::ITEM_FIXED_MONTHLY_MANAGEMENT,
self::ITEM_LATE_PAYMENT,
self::ITEM_MINIMUM_MONTHLY_PAYMENT,
self::ITEM_OTHERS,
self::ITEM_OVERSEA_TRANSACTION,
self::ITEM_OVERSEA_TRANSACTION_CONVERSION,
self::ITEM_SALES_DRAFT_RETRIEVAL_COPY,
self::ITEM_SERVICE_TAX,
self::ITEM_STARTER_PACK,
self::ITEM_STATEMENT_COPY,        ];
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
        $this->container['item'] = isset($data['item']) ? $data['item'] : null;
        $this->container['chargeable'] = isset($data['chargeable']) ? $data['chargeable'] : null;
        $this->container['amount'] = isset($data['amount']) ? $data['amount'] : null;
        $this->container['amount_currency_code'] = isset($data['amount_currency_code']) ? $data['amount_currency_code'] : 'MYR';
        $this->container['percentage'] = isset($data['percentage']) ? $data['percentage'] : null;
        $this->container['remark'] = isset($data['remark']) ? $data['remark'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['item'] === null) {
            $invalidProperties[] = "'item' can't be null";
        }
        $allowedValues = $this->getItemAllowableValues();
        if (!is_null($this->container['item']) && !in_array($this->container['item'], $allowedValues, true)) {
            $invalidProperties[] = sprintf(
                "invalid value for 'item', must be one of '%s'",
                implode("', '", $allowedValues)
            );
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
     * Gets item
     *
     * @return string
     */
    public function getItem()
    {
        return $this->container['item'];
    }

    /**
     * Sets item
     *
     * @param string $item item
     *
     * @return $this
     */
    public function setItem($item)
    {
        $allowedValues = $this->getItemAllowableValues();
        if (!in_array($item, $allowedValues, true)) {
            throw new \InvalidArgumentException(
                sprintf(
                    "Invalid value for 'item', must be one of '%s'",
                    implode("', '", $allowedValues)
                )
            );
        }
        $this->container['item'] = $item;

        return $this;
    }

    /**
     * Gets chargeable
     *
     * @return bool
     */
    public function getChargeable()
    {
        return $this->container['chargeable'];
    }

    /**
     * Sets chargeable
     *
     * @param bool $chargeable Indicator of chargeability
     *
     * @return $this
     */
    public function setChargeable($chargeable)
    {
        $this->container['chargeable'] = $chargeable;

        return $this;
    }

    /**
     * Gets amount
     *
     * @return double
     */
    public function getAmount()
    {
        return $this->container['amount'];
    }

    /**
     * Sets amount
     *
     * @param double $amount Amount for fee and charge up to two digits decimal
     *
     * @return $this
     */
    public function setAmount($amount)
    {
        $this->container['amount'] = $amount;

        return $this;
    }

    /**
     * Gets amount_currency_code
     *
     * @return string
     */
    public function getAmountCurrencyCode()
    {
        return $this->container['amount_currency_code'];
    }

    /**
     * Sets amount_currency_code
     *
     * @param string $amount_currency_code ISO-4217 3 characters currency code for fee and charge amount
     *
     * @return $this
     */
    public function setAmountCurrencyCode($amount_currency_code)
    {
        $this->container['amount_currency_code'] = $amount_currency_code;

        return $this;
    }

    /**
     * Gets percentage
     *
     * @return double
     */
    public function getPercentage()
    {
        return $this->container['percentage'];
    }

    /**
     * Sets percentage
     *
     * @param double $percentage Percentage of amount for fee and charge up to two digits decimal
     *
     * @return $this
     */
    public function setPercentage($percentage)
    {
        $this->container['percentage'] = $percentage;

        return $this;
    }

    /**
     * Gets remark
     *
     * @return string
     */
    public function getRemark()
    {
        return $this->container['remark'];
    }

    /**
     * Sets remark
     *
     * @param string $remark Additional notes for the fee and charge
     *
     * @return $this
     */
    public function setRemark($remark)
    {
        $this->container['remark'] = $remark;

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
