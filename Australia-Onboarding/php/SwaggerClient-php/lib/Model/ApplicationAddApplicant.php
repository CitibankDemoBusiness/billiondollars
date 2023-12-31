<?php
/**
 * ApplicationAddApplicant
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
 * ApplicationAddApplicant Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationAddApplicant implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationAddApplicant';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'ocr' => '\Swagger\Client\Model\ApplicationAddOcr',
'mother_maiden_name' => 'string',
'name' => '\Swagger\Client\Model\ApplicationAddName',
'demographics' => '\Swagger\Client\Model\ApplicationAddDemographics',
'address' => '\Swagger\Client\Model\ApplicationAddAddress[]',
'email' => '\Swagger\Client\Model\ApplicationAddEmail[]',
'phone' => '\Swagger\Client\Model\ApplicationAddPhone[]',
'contact_preference' => '\Swagger\Client\Model\ApplicationAddContactPreference',
'contact_consent' => '\Swagger\Client\Model\ApplicationAddContactConsent',
'financial_information' => '\Swagger\Client\Model\ApplicationAddFinancialInformation',
'education' => '\Swagger\Client\Model\ApplicationAddEducation',
'employment_details' => '\Swagger\Client\Model\ApplicationAddEmploymentDetails[]',
'identification_document_details' => '\Swagger\Client\Model\ApplicationAddIdentificationDocumentDetails[]',
'additional_data' => '\Swagger\Client\Model\ApplicationAddAdditionalData',
'partner_customer_details' => '\Swagger\Client\Model\ApplicationAddPartnerCustomerDetails',
'consent_details' => '\Swagger\Client\Model\ApplicationAddConsentDetails[]',
'marketing_consent' => '\Swagger\Client\Model\ApplicationAddMarketingConsent',
'self_declaration' => '\Swagger\Client\Model\ApplicationAddSelfDeclaration',
'kyc_information' => '\Swagger\Client\Model\ApplicationAddKycInformation'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'ocr' => null,
'mother_maiden_name' => null,
'name' => null,
'demographics' => null,
'address' => null,
'email' => null,
'phone' => null,
'contact_preference' => null,
'contact_consent' => null,
'financial_information' => null,
'education' => null,
'employment_details' => null,
'identification_document_details' => null,
'additional_data' => null,
'partner_customer_details' => null,
'consent_details' => null,
'marketing_consent' => null,
'self_declaration' => null,
'kyc_information' => null    ];

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
        'ocr' => 'ocr',
'mother_maiden_name' => 'motherMaidenName',
'name' => 'name',
'demographics' => 'demographics',
'address' => 'address',
'email' => 'email',
'phone' => 'phone',
'contact_preference' => 'contactPreference',
'contact_consent' => 'contactConsent',
'financial_information' => 'financialInformation',
'education' => 'education',
'employment_details' => 'employmentDetails',
'identification_document_details' => 'identificationDocumentDetails',
'additional_data' => 'additionalData',
'partner_customer_details' => 'partnerCustomerDetails',
'consent_details' => 'consentDetails',
'marketing_consent' => 'marketingConsent',
'self_declaration' => 'selfDeclaration',
'kyc_information' => 'kycInformation'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'ocr' => 'setOcr',
'mother_maiden_name' => 'setMotherMaidenName',
'name' => 'setName',
'demographics' => 'setDemographics',
'address' => 'setAddress',
'email' => 'setEmail',
'phone' => 'setPhone',
'contact_preference' => 'setContactPreference',
'contact_consent' => 'setContactConsent',
'financial_information' => 'setFinancialInformation',
'education' => 'setEducation',
'employment_details' => 'setEmploymentDetails',
'identification_document_details' => 'setIdentificationDocumentDetails',
'additional_data' => 'setAdditionalData',
'partner_customer_details' => 'setPartnerCustomerDetails',
'consent_details' => 'setConsentDetails',
'marketing_consent' => 'setMarketingConsent',
'self_declaration' => 'setSelfDeclaration',
'kyc_information' => 'setKycInformation'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'ocr' => 'getOcr',
'mother_maiden_name' => 'getMotherMaidenName',
'name' => 'getName',
'demographics' => 'getDemographics',
'address' => 'getAddress',
'email' => 'getEmail',
'phone' => 'getPhone',
'contact_preference' => 'getContactPreference',
'contact_consent' => 'getContactConsent',
'financial_information' => 'getFinancialInformation',
'education' => 'getEducation',
'employment_details' => 'getEmploymentDetails',
'identification_document_details' => 'getIdentificationDocumentDetails',
'additional_data' => 'getAdditionalData',
'partner_customer_details' => 'getPartnerCustomerDetails',
'consent_details' => 'getConsentDetails',
'marketing_consent' => 'getMarketingConsent',
'self_declaration' => 'getSelfDeclaration',
'kyc_information' => 'getKycInformation'    ];

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
        $this->container['ocr'] = isset($data['ocr']) ? $data['ocr'] : null;
        $this->container['mother_maiden_name'] = isset($data['mother_maiden_name']) ? $data['mother_maiden_name'] : null;
        $this->container['name'] = isset($data['name']) ? $data['name'] : null;
        $this->container['demographics'] = isset($data['demographics']) ? $data['demographics'] : null;
        $this->container['address'] = isset($data['address']) ? $data['address'] : null;
        $this->container['email'] = isset($data['email']) ? $data['email'] : null;
        $this->container['phone'] = isset($data['phone']) ? $data['phone'] : null;
        $this->container['contact_preference'] = isset($data['contact_preference']) ? $data['contact_preference'] : null;
        $this->container['contact_consent'] = isset($data['contact_consent']) ? $data['contact_consent'] : null;
        $this->container['financial_information'] = isset($data['financial_information']) ? $data['financial_information'] : null;
        $this->container['education'] = isset($data['education']) ? $data['education'] : null;
        $this->container['employment_details'] = isset($data['employment_details']) ? $data['employment_details'] : null;
        $this->container['identification_document_details'] = isset($data['identification_document_details']) ? $data['identification_document_details'] : null;
        $this->container['additional_data'] = isset($data['additional_data']) ? $data['additional_data'] : null;
        $this->container['partner_customer_details'] = isset($data['partner_customer_details']) ? $data['partner_customer_details'] : null;
        $this->container['consent_details'] = isset($data['consent_details']) ? $data['consent_details'] : null;
        $this->container['marketing_consent'] = isset($data['marketing_consent']) ? $data['marketing_consent'] : null;
        $this->container['self_declaration'] = isset($data['self_declaration']) ? $data['self_declaration'] : null;
        $this->container['kyc_information'] = isset($data['kyc_information']) ? $data['kyc_information'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['name'] === null) {
            $invalidProperties[] = "'name' can't be null";
        }
        if ($this->container['phone'] === null) {
            $invalidProperties[] = "'phone' can't be null";
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
     * Gets ocr
     *
     * @return \Swagger\Client\Model\ApplicationAddOcr
     */
    public function getOcr()
    {
        return $this->container['ocr'];
    }

    /**
     * Sets ocr
     *
     * @param \Swagger\Client\Model\ApplicationAddOcr $ocr ocr
     *
     * @return $this
     */
    public function setOcr($ocr)
    {
        $this->container['ocr'] = $ocr;

        return $this;
    }

    /**
     * Gets mother_maiden_name
     *
     * @return string
     */
    public function getMotherMaidenName()
    {
        return $this->container['mother_maiden_name'];
    }

    /**
     * Sets mother_maiden_name
     *
     * @param string $mother_maiden_name Mother's maiden name
     *
     * @return $this
     */
    public function setMotherMaidenName($mother_maiden_name)
    {
        $this->container['mother_maiden_name'] = $mother_maiden_name;

        return $this;
    }

    /**
     * Gets name
     *
     * @return \Swagger\Client\Model\ApplicationAddName
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     *
     * @param \Swagger\Client\Model\ApplicationAddName $name name
     *
     * @return $this
     */
    public function setName($name)
    {
        $this->container['name'] = $name;

        return $this;
    }

    /**
     * Gets demographics
     *
     * @return \Swagger\Client\Model\ApplicationAddDemographics
     */
    public function getDemographics()
    {
        return $this->container['demographics'];
    }

    /**
     * Sets demographics
     *
     * @param \Swagger\Client\Model\ApplicationAddDemographics $demographics demographics
     *
     * @return $this
     */
    public function setDemographics($demographics)
    {
        $this->container['demographics'] = $demographics;

        return $this;
    }

    /**
     * Gets address
     *
     * @return \Swagger\Client\Model\ApplicationAddAddress[]
     */
    public function getAddress()
    {
        return $this->container['address'];
    }

    /**
     * Sets address
     *
     * @param \Swagger\Client\Model\ApplicationAddAddress[] $address address
     *
     * @return $this
     */
    public function setAddress($address)
    {
        $this->container['address'] = $address;

        return $this;
    }

    /**
     * Gets email
     *
     * @return \Swagger\Client\Model\ApplicationAddEmail[]
     */
    public function getEmail()
    {
        return $this->container['email'];
    }

    /**
     * Sets email
     *
     * @param \Swagger\Client\Model\ApplicationAddEmail[] $email email
     *
     * @return $this
     */
    public function setEmail($email)
    {
        $this->container['email'] = $email;

        return $this;
    }

    /**
     * Gets phone
     *
     * @return \Swagger\Client\Model\ApplicationAddPhone[]
     */
    public function getPhone()
    {
        return $this->container['phone'];
    }

    /**
     * Sets phone
     *
     * @param \Swagger\Client\Model\ApplicationAddPhone[] $phone phone
     *
     * @return $this
     */
    public function setPhone($phone)
    {
        $this->container['phone'] = $phone;

        return $this;
    }

    /**
     * Gets contact_preference
     *
     * @return \Swagger\Client\Model\ApplicationAddContactPreference
     */
    public function getContactPreference()
    {
        return $this->container['contact_preference'];
    }

    /**
     * Sets contact_preference
     *
     * @param \Swagger\Client\Model\ApplicationAddContactPreference $contact_preference contact_preference
     *
     * @return $this
     */
    public function setContactPreference($contact_preference)
    {
        $this->container['contact_preference'] = $contact_preference;

        return $this;
    }

    /**
     * Gets contact_consent
     *
     * @return \Swagger\Client\Model\ApplicationAddContactConsent
     */
    public function getContactConsent()
    {
        return $this->container['contact_consent'];
    }

    /**
     * Sets contact_consent
     *
     * @param \Swagger\Client\Model\ApplicationAddContactConsent $contact_consent contact_consent
     *
     * @return $this
     */
    public function setContactConsent($contact_consent)
    {
        $this->container['contact_consent'] = $contact_consent;

        return $this;
    }

    /**
     * Gets financial_information
     *
     * @return \Swagger\Client\Model\ApplicationAddFinancialInformation
     */
    public function getFinancialInformation()
    {
        return $this->container['financial_information'];
    }

    /**
     * Sets financial_information
     *
     * @param \Swagger\Client\Model\ApplicationAddFinancialInformation $financial_information financial_information
     *
     * @return $this
     */
    public function setFinancialInformation($financial_information)
    {
        $this->container['financial_information'] = $financial_information;

        return $this;
    }

    /**
     * Gets education
     *
     * @return \Swagger\Client\Model\ApplicationAddEducation
     */
    public function getEducation()
    {
        return $this->container['education'];
    }

    /**
     * Sets education
     *
     * @param \Swagger\Client\Model\ApplicationAddEducation $education education
     *
     * @return $this
     */
    public function setEducation($education)
    {
        $this->container['education'] = $education;

        return $this;
    }

    /**
     * Gets employment_details
     *
     * @return \Swagger\Client\Model\ApplicationAddEmploymentDetails[]
     */
    public function getEmploymentDetails()
    {
        return $this->container['employment_details'];
    }

    /**
     * Sets employment_details
     *
     * @param \Swagger\Client\Model\ApplicationAddEmploymentDetails[] $employment_details employment_details
     *
     * @return $this
     */
    public function setEmploymentDetails($employment_details)
    {
        $this->container['employment_details'] = $employment_details;

        return $this;
    }

    /**
     * Gets identification_document_details
     *
     * @return \Swagger\Client\Model\ApplicationAddIdentificationDocumentDetails[]
     */
    public function getIdentificationDocumentDetails()
    {
        return $this->container['identification_document_details'];
    }

    /**
     * Sets identification_document_details
     *
     * @param \Swagger\Client\Model\ApplicationAddIdentificationDocumentDetails[] $identification_document_details identification_document_details
     *
     * @return $this
     */
    public function setIdentificationDocumentDetails($identification_document_details)
    {
        $this->container['identification_document_details'] = $identification_document_details;

        return $this;
    }

    /**
     * Gets additional_data
     *
     * @return \Swagger\Client\Model\ApplicationAddAdditionalData
     */
    public function getAdditionalData()
    {
        return $this->container['additional_data'];
    }

    /**
     * Sets additional_data
     *
     * @param \Swagger\Client\Model\ApplicationAddAdditionalData $additional_data additional_data
     *
     * @return $this
     */
    public function setAdditionalData($additional_data)
    {
        $this->container['additional_data'] = $additional_data;

        return $this;
    }

    /**
     * Gets partner_customer_details
     *
     * @return \Swagger\Client\Model\ApplicationAddPartnerCustomerDetails
     */
    public function getPartnerCustomerDetails()
    {
        return $this->container['partner_customer_details'];
    }

    /**
     * Sets partner_customer_details
     *
     * @param \Swagger\Client\Model\ApplicationAddPartnerCustomerDetails $partner_customer_details partner_customer_details
     *
     * @return $this
     */
    public function setPartnerCustomerDetails($partner_customer_details)
    {
        $this->container['partner_customer_details'] = $partner_customer_details;

        return $this;
    }

    /**
     * Gets consent_details
     *
     * @return \Swagger\Client\Model\ApplicationAddConsentDetails[]
     */
    public function getConsentDetails()
    {
        return $this->container['consent_details'];
    }

    /**
     * Sets consent_details
     *
     * @param \Swagger\Client\Model\ApplicationAddConsentDetails[] $consent_details consent_details
     *
     * @return $this
     */
    public function setConsentDetails($consent_details)
    {
        $this->container['consent_details'] = $consent_details;

        return $this;
    }

    /**
     * Gets marketing_consent
     *
     * @return \Swagger\Client\Model\ApplicationAddMarketingConsent
     */
    public function getMarketingConsent()
    {
        return $this->container['marketing_consent'];
    }

    /**
     * Sets marketing_consent
     *
     * @param \Swagger\Client\Model\ApplicationAddMarketingConsent $marketing_consent marketing_consent
     *
     * @return $this
     */
    public function setMarketingConsent($marketing_consent)
    {
        $this->container['marketing_consent'] = $marketing_consent;

        return $this;
    }

    /**
     * Gets self_declaration
     *
     * @return \Swagger\Client\Model\ApplicationAddSelfDeclaration
     */
    public function getSelfDeclaration()
    {
        return $this->container['self_declaration'];
    }

    /**
     * Sets self_declaration
     *
     * @param \Swagger\Client\Model\ApplicationAddSelfDeclaration $self_declaration self_declaration
     *
     * @return $this
     */
    public function setSelfDeclaration($self_declaration)
    {
        $this->container['self_declaration'] = $self_declaration;

        return $this;
    }

    /**
     * Gets kyc_information
     *
     * @return \Swagger\Client\Model\ApplicationAddKycInformation
     */
    public function getKycInformation()
    {
        return $this->container['kyc_information'];
    }

    /**
     * Sets kyc_information
     *
     * @param \Swagger\Client\Model\ApplicationAddKycInformation $kyc_information kyc_information
     *
     * @return $this
     */
    public function setKycInformation($kyc_information)
    {
        $this->container['kyc_information'] = $kyc_information;

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
