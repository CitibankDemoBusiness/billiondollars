<?php
/**
 * NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest
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
 * NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'request_id' => 'string',
'vop_transaction_id' => 'string',
'action_type' => 'string',
'distributor_id' => 'string',
'card_id' => 'string',
'user_id' => 'string',
'credit_status' => 'string',
'request_date_time' => 'string',
'offer_id' => 'int',
'settlement_currency' => 'string',
'reward_settlement_currency' => 'double',
'billing_currency' => 'string',
'reward_billing_currency' => 'double',
'merchant_name' => 'string',
'transaction_date' => 'string',
'transaction_billing_amount' => 'double',
'transaction_settlement_amount' => 'double',
'remarks' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'request_id' => null,
'vop_transaction_id' => null,
'action_type' => null,
'distributor_id' => null,
'card_id' => null,
'user_id' => null,
'credit_status' => null,
'request_date_time' => null,
'offer_id' => 'int32',
'settlement_currency' => null,
'reward_settlement_currency' => 'double',
'billing_currency' => null,
'reward_billing_currency' => 'double',
'merchant_name' => null,
'transaction_date' => null,
'transaction_billing_amount' => 'double',
'transaction_settlement_amount' => 'double',
'remarks' => null    ];

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
        'request_id' => 'requestId',
'vop_transaction_id' => 'vopTransactionId',
'action_type' => 'actionType',
'distributor_id' => 'distributorId',
'card_id' => 'cardId',
'user_id' => 'userId',
'credit_status' => 'creditStatus',
'request_date_time' => 'requestDateTime',
'offer_id' => 'offerId',
'settlement_currency' => 'settlementCurrency',
'reward_settlement_currency' => 'rewardSettlementCurrency',
'billing_currency' => 'billingCurrency',
'reward_billing_currency' => 'rewardBillingCurrency',
'merchant_name' => 'merchantName',
'transaction_date' => 'transactionDate',
'transaction_billing_amount' => 'transactionBillingAmount',
'transaction_settlement_amount' => 'transactionSettlementAmount',
'remarks' => 'remarks'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'request_id' => 'setRequestId',
'vop_transaction_id' => 'setVopTransactionId',
'action_type' => 'setActionType',
'distributor_id' => 'setDistributorId',
'card_id' => 'setCardId',
'user_id' => 'setUserId',
'credit_status' => 'setCreditStatus',
'request_date_time' => 'setRequestDateTime',
'offer_id' => 'setOfferId',
'settlement_currency' => 'setSettlementCurrency',
'reward_settlement_currency' => 'setRewardSettlementCurrency',
'billing_currency' => 'setBillingCurrency',
'reward_billing_currency' => 'setRewardBillingCurrency',
'merchant_name' => 'setMerchantName',
'transaction_date' => 'setTransactionDate',
'transaction_billing_amount' => 'setTransactionBillingAmount',
'transaction_settlement_amount' => 'setTransactionSettlementAmount',
'remarks' => 'setRemarks'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'request_id' => 'getRequestId',
'vop_transaction_id' => 'getVopTransactionId',
'action_type' => 'getActionType',
'distributor_id' => 'getDistributorId',
'card_id' => 'getCardId',
'user_id' => 'getUserId',
'credit_status' => 'getCreditStatus',
'request_date_time' => 'getRequestDateTime',
'offer_id' => 'getOfferId',
'settlement_currency' => 'getSettlementCurrency',
'reward_settlement_currency' => 'getRewardSettlementCurrency',
'billing_currency' => 'getBillingCurrency',
'reward_billing_currency' => 'getRewardBillingCurrency',
'merchant_name' => 'getMerchantName',
'transaction_date' => 'getTransactionDate',
'transaction_billing_amount' => 'getTransactionBillingAmount',
'transaction_settlement_amount' => 'getTransactionSettlementAmount',
'remarks' => 'getRemarks'    ];

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
        $this->container['request_id'] = isset($data['request_id']) ? $data['request_id'] : null;
        $this->container['vop_transaction_id'] = isset($data['vop_transaction_id']) ? $data['vop_transaction_id'] : null;
        $this->container['action_type'] = isset($data['action_type']) ? $data['action_type'] : null;
        $this->container['distributor_id'] = isset($data['distributor_id']) ? $data['distributor_id'] : null;
        $this->container['card_id'] = isset($data['card_id']) ? $data['card_id'] : null;
        $this->container['user_id'] = isset($data['user_id']) ? $data['user_id'] : null;
        $this->container['credit_status'] = isset($data['credit_status']) ? $data['credit_status'] : null;
        $this->container['request_date_time'] = isset($data['request_date_time']) ? $data['request_date_time'] : null;
        $this->container['offer_id'] = isset($data['offer_id']) ? $data['offer_id'] : null;
        $this->container['settlement_currency'] = isset($data['settlement_currency']) ? $data['settlement_currency'] : null;
        $this->container['reward_settlement_currency'] = isset($data['reward_settlement_currency']) ? $data['reward_settlement_currency'] : null;
        $this->container['billing_currency'] = isset($data['billing_currency']) ? $data['billing_currency'] : null;
        $this->container['reward_billing_currency'] = isset($data['reward_billing_currency']) ? $data['reward_billing_currency'] : null;
        $this->container['merchant_name'] = isset($data['merchant_name']) ? $data['merchant_name'] : null;
        $this->container['transaction_date'] = isset($data['transaction_date']) ? $data['transaction_date'] : null;
        $this->container['transaction_billing_amount'] = isset($data['transaction_billing_amount']) ? $data['transaction_billing_amount'] : null;
        $this->container['transaction_settlement_amount'] = isset($data['transaction_settlement_amount']) ? $data['transaction_settlement_amount'] : null;
        $this->container['remarks'] = isset($data['remarks']) ? $data['remarks'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['request_id'] === null) {
            $invalidProperties[] = "'request_id' can't be null";
        }
        if ($this->container['vop_transaction_id'] === null) {
            $invalidProperties[] = "'vop_transaction_id' can't be null";
        }
        if ($this->container['action_type'] === null) {
            $invalidProperties[] = "'action_type' can't be null";
        }
        if ($this->container['distributor_id'] === null) {
            $invalidProperties[] = "'distributor_id' can't be null";
        }
        if ($this->container['card_id'] === null) {
            $invalidProperties[] = "'card_id' can't be null";
        }
        if ($this->container['user_id'] === null) {
            $invalidProperties[] = "'user_id' can't be null";
        }
        if ($this->container['credit_status'] === null) {
            $invalidProperties[] = "'credit_status' can't be null";
        }
        if ($this->container['request_date_time'] === null) {
            $invalidProperties[] = "'request_date_time' can't be null";
        }
        if ($this->container['offer_id'] === null) {
            $invalidProperties[] = "'offer_id' can't be null";
        }
        if ($this->container['settlement_currency'] === null) {
            $invalidProperties[] = "'settlement_currency' can't be null";
        }
        if ($this->container['reward_settlement_currency'] === null) {
            $invalidProperties[] = "'reward_settlement_currency' can't be null";
        }
        if ($this->container['billing_currency'] === null) {
            $invalidProperties[] = "'billing_currency' can't be null";
        }
        if ($this->container['reward_billing_currency'] === null) {
            $invalidProperties[] = "'reward_billing_currency' can't be null";
        }
        if ($this->container['merchant_name'] === null) {
            $invalidProperties[] = "'merchant_name' can't be null";
        }
        if ($this->container['transaction_date'] === null) {
            $invalidProperties[] = "'transaction_date' can't be null";
        }
        if ($this->container['transaction_billing_amount'] === null) {
            $invalidProperties[] = "'transaction_billing_amount' can't be null";
        }
        if ($this->container['transaction_settlement_amount'] === null) {
            $invalidProperties[] = "'transaction_settlement_amount' can't be null";
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
     * Gets request_id
     *
     * @return string
     */
    public function getRequestId()
    {
        return $this->container['request_id'];
    }

    /**
     * Sets request_id
     *
     * @param string $request_id This field provides the unique request ID generated from the VOX platform. Will be used for tracking and audit purposes
     *
     * @return $this
     */
    public function setRequestId($request_id)
    {
        $this->container['request_id'] = $request_id;

        return $this;
    }

    /**
     * Gets vop_transaction_id
     *
     * @return string
     */
    public function getVopTransactionId()
    {
        return $this->container['vop_transaction_id'];
    }

    /**
     * Sets vop_transaction_id
     *
     * @param string $vop_transaction_id This field specifies the VOP transaction ID of the original transaction, that triggered the reward.
     *
     * @return $this
     */
    public function setVopTransactionId($vop_transaction_id)
    {
        $this->container['vop_transaction_id'] = $vop_transaction_id;

        return $this;
    }

    /**
     * Gets action_type
     *
     * @return string
     */
    public function getActionType()
    {
        return $this->container['action_type'];
    }

    /**
     * Sets action_type
     *
     * @param string $action_type This field specifies the action to be performed for the request.Valid Value is Notify
     *
     * @return $this
     */
    public function setActionType($action_type)
    {
        $this->container['action_type'] = $action_type;

        return $this;
    }

    /**
     * Gets distributor_id
     *
     * @return string
     */
    public function getDistributorId()
    {
        return $this->container['distributor_id'];
    }

    /**
     * Sets distributor_id
     *
     * @param string $distributor_id This field specifies the Distributor ID. Important when an aggregator (who is serving for more than one distributor) is building the API end point.
     *
     * @return $this
     */
    public function setDistributorId($distributor_id)
    {
        $this->container['distributor_id'] = $distributor_id;

        return $this;
    }

    /**
     * Gets card_id
     *
     * @return string
     */
    public function getCardId()
    {
        return $this->container['card_id'];
    }

    /**
     * Sets card_id
     *
     * @param string $card_id This field provides the card id generated during cardholder enrolment at VOX.
     *
     * @return $this
     */
    public function setCardId($card_id)
    {
        $this->container['card_id'] = $card_id;

        return $this;
    }

    /**
     * Gets user_id
     *
     * @return string
     */
    public function getUserId()
    {
        return $this->container['user_id'];
    }

    /**
     * Sets user_id
     *
     * @param string $user_id This field provides the external user id generated during cardholder enrolment at VOX.
     *
     * @return $this
     */
    public function setUserId($user_id)
    {
        $this->container['user_id'] = $user_id;

        return $this;
    }

    /**
     * Gets credit_status
     *
     * @return string
     */
    public function getCreditStatus()
    {
        return $this->container['credit_status'];
    }

    /**
     * Sets credit_status
     *
     * @param string $credit_status This field specifies the reward credit status.Valid Values are Successful, Eligible, Failed
     *
     * @return $this
     */
    public function setCreditStatus($credit_status)
    {
        $this->container['credit_status'] = $credit_status;

        return $this;
    }

    /**
     * Gets request_date_time
     *
     * @return string
     */
    public function getRequestDateTime()
    {
        return $this->container['request_date_time'];
    }

    /**
     * Sets request_date_time
     *
     * @param string $request_date_time This field specifies the date and time which the reward request is initiated in the format YYYY-MM-DD HH:MM:SS
     *
     * @return $this
     */
    public function setRequestDateTime($request_date_time)
    {
        $this->container['request_date_time'] = $request_date_time;

        return $this;
    }

    /**
     * Gets offer_id
     *
     * @return int
     */
    public function getOfferId()
    {
        return $this->container['offer_id'];
    }

    /**
     * Sets offer_id
     *
     * @param int $offer_id This will be the VOX qualified offer ID, which the reward is given, Will be used for tracking and audit purposes.
     *
     * @return $this
     */
    public function setOfferId($offer_id)
    {
        $this->container['offer_id'] = $offer_id;

        return $this;
    }

    /**
     * Gets settlement_currency
     *
     * @return string
     */
    public function getSettlementCurrency()
    {
        return $this->container['settlement_currency'];
    }

    /**
     * Sets settlement_currency
     *
     * @param string $settlement_currency This field specifies the reward currency of the original offer
     *
     * @return $this
     */
    public function setSettlementCurrency($settlement_currency)
    {
        $this->container['settlement_currency'] = $settlement_currency;

        return $this;
    }

    /**
     * Gets reward_settlement_currency
     *
     * @return double
     */
    public function getRewardSettlementCurrency()
    {
        return $this->container['reward_settlement_currency'];
    }

    /**
     * Sets reward_settlement_currency
     *
     * @param double $reward_settlement_currency This field specifies the cashback reward value in Settlement Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00
     *
     * @return $this
     */
    public function setRewardSettlementCurrency($reward_settlement_currency)
    {
        $this->container['reward_settlement_currency'] = $reward_settlement_currency;

        return $this;
    }

    /**
     * Gets billing_currency
     *
     * @return string
     */
    public function getBillingCurrency()
    {
        return $this->container['billing_currency'];
    }

    /**
     * Sets billing_currency
     *
     * @param string $billing_currency This field specifies the customer purchase currency derived from the VOP transaction.
     *
     * @return $this
     */
    public function setBillingCurrency($billing_currency)
    {
        $this->container['billing_currency'] = $billing_currency;

        return $this;
    }

    /**
     * Gets reward_billing_currency
     *
     * @return double
     */
    public function getRewardBillingCurrency()
    {
        return $this->container['reward_billing_currency'];
    }

    /**
     * Sets reward_billing_currency
     *
     * @param double $reward_billing_currency This field specifies the cashback reward value in Settlement Billing Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00
     *
     * @return $this
     */
    public function setRewardBillingCurrency($reward_billing_currency)
    {
        $this->container['reward_billing_currency'] = $reward_billing_currency;

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
     * @param string $merchant_name This field provides the merchant name
     *
     * @return $this
     */
    public function setMerchantName($merchant_name)
    {
        $this->container['merchant_name'] = $merchant_name;

        return $this;
    }

    /**
     * Gets transaction_date
     *
     * @return string
     */
    public function getTransactionDate()
    {
        return $this->container['transaction_date'];
    }

    /**
     * Sets transaction_date
     *
     * @param string $transaction_date This field specifies the transaction date retrieved from the VOP Transaction in the format YYYY-MM-DD HH:MM:SS
     *
     * @return $this
     */
    public function setTransactionDate($transaction_date)
    {
        $this->container['transaction_date'] = $transaction_date;

        return $this;
    }

    /**
     * Gets transaction_billing_amount
     *
     * @return double
     */
    public function getTransactionBillingAmount()
    {
        return $this->container['transaction_billing_amount'];
    }

    /**
     * Sets transaction_billing_amount
     *
     * @param double $transaction_billing_amount This field specifies transaction amount in billing currency as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00
     *
     * @return $this
     */
    public function setTransactionBillingAmount($transaction_billing_amount)
    {
        $this->container['transaction_billing_amount'] = $transaction_billing_amount;

        return $this;
    }

    /**
     * Gets transaction_settlement_amount
     *
     * @return double
     */
    public function getTransactionSettlementAmount()
    {
        return $this->container['transaction_settlement_amount'];
    }

    /**
     * Sets transaction_settlement_amount
     *
     * @param double $transaction_settlement_amount This field specifies transaction amount in settlement currency  as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00
     *
     * @return $this
     */
    public function setTransactionSettlementAmount($transaction_settlement_amount)
    {
        $this->container['transaction_settlement_amount'] = $transaction_settlement_amount;

        return $this;
    }

    /**
     * Gets remarks
     *
     * @return string
     */
    public function getRemarks()
    {
        return $this->container['remarks'];
    }

    /**
     * Sets remarks
     *
     * @param string $remarks This field is used to pass additional information required by the partner for their records. This can pass an empty value as well.
     *
     * @return $this
     */
    public function setRemarks($remarks)
    {
        $this->container['remarks'] = $remarks;

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
