<?php
/**
 * ApplicationInquiryRequiredDocuments
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
 * ApplicationInquiryRequiredDocuments Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationInquiryRequiredDocuments implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationInquiryRequiredDocuments';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'document_id_type' => 'string',
'document_status' => 'string',
'product_code' => 'string',
'proof_type' => 'string',
'linked_document_id' => 'string',
'applicant_type' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'document_id_type' => null,
'document_status' => null,
'product_code' => null,
'proof_type' => null,
'linked_document_id' => null,
'applicant_type' => null    ];

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
        'document_id_type' => 'documentIdType',
'document_status' => 'documentStatus',
'product_code' => 'productCode',
'proof_type' => 'proofType',
'linked_document_id' => 'linkedDocumentId',
'applicant_type' => 'applicantType'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'document_id_type' => 'setDocumentIdType',
'document_status' => 'setDocumentStatus',
'product_code' => 'setProductCode',
'proof_type' => 'setProofType',
'linked_document_id' => 'setLinkedDocumentId',
'applicant_type' => 'setApplicantType'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'document_id_type' => 'getDocumentIdType',
'document_status' => 'getDocumentStatus',
'product_code' => 'getProductCode',
'proof_type' => 'getProofType',
'linked_document_id' => 'getLinkedDocumentId',
'applicant_type' => 'getApplicantType'    ];

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
        $this->container['document_id_type'] = isset($data['document_id_type']) ? $data['document_id_type'] : null;
        $this->container['document_status'] = isset($data['document_status']) ? $data['document_status'] : null;
        $this->container['product_code'] = isset($data['product_code']) ? $data['product_code'] : null;
        $this->container['proof_type'] = isset($data['proof_type']) ? $data['proof_type'] : null;
        $this->container['linked_document_id'] = isset($data['linked_document_id']) ? $data['linked_document_id'] : null;
        $this->container['applicant_type'] = isset($data['applicant_type']) ? $data['applicant_type'] : null;
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
     * Gets document_id_type
     *
     * @return string
     */
    public function getDocumentIdType()
    {
        return $this->container['document_id_type'];
    }

    /**
     * Sets document_id_type
     *
     * @param string $document_id_type Document ID for each proof. This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentIdType} resource to get valid values of this field with descriptions.You can use the documentIdType as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setDocumentIdType($document_id_type)
    {
        $this->container['document_id_type'] = $document_id_type;

        return $this;
    }

    /**
     * Gets document_status
     *
     * @return string
     */
    public function getDocumentStatus()
    {
        return $this->container['document_status'];
    }

    /**
     * Sets document_status
     *
     * @param string $document_status Status of document proof.This is a reference data field. Please use /v1/apac/utilities/referenceData/{documentStatus} resource to get possible values of this field with descriptions.You can use the documentStatus as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setDocumentStatus($document_status)
    {
        $this->container['document_status'] = $document_status;

        return $this;
    }

    /**
     * Gets product_code
     *
     * @return string
     */
    public function getProductCode()
    {
        return $this->container['product_code'];
    }

    /**
     * Sets product_code
     *
     * @param string $product_code A unique code that identifies the product
     *
     * @return $this
     */
    public function setProductCode($product_code)
    {
        $this->container['product_code'] = $product_code;

        return $this;
    }

    /**
     * Gets proof_type
     *
     * @return string
     */
    public function getProofType()
    {
        return $this->container['proof_type'];
    }

    /**
     * Sets proof_type
     *
     * @param string $proof_type Type of document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{proofType} resource to get possible values of this field with descriptions.You can use the proofType as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setProofType($proof_type)
    {
        $this->container['proof_type'] = $proof_type;

        return $this;
    }

    /**
     * Gets linked_document_id
     *
     * @return string
     */
    public function getLinkedDocumentId()
    {
        return $this->container['linked_document_id'];
    }

    /**
     * Sets linked_document_id
     *
     * @param string $linked_document_id Linked document id specifies that the same document can be used for different proof types
     *
     * @return $this
     */
    public function setLinkedDocumentId($linked_document_id)
    {
        $this->container['linked_document_id'] = $linked_document_id;

        return $this;
    }

    /**
     * Gets applicant_type
     *
     * @return string
     */
    public function getApplicantType()
    {
        return $this->container['applicant_type'];
    }

    /**
     * Sets applicant_type
     *
     * @param string $applicant_type Applicant's relationship with the Bank. Currently supported is Primary - P.This is a reference data field. Please use /v1/apac/utilities/referenceData/{applicantType} resource to get valid value of this field with description.You can use the documentType as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setApplicantType($applicant_type)
    {
        $this->container['applicant_type'] = $applicant_type;

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
