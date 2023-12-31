=begin
#Onboarding

#The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class AdditionalDataAdd
    # This field is to indicates the primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description.
    attr_accessor :account_fund_source

    # Number of dependents
    attr_accessor :number_of_dependents

    # Flag to indicates if applicant is a Citi Staff. Valid values: true and false
    attr_accessor :staff_indicator

    # Business nature of the applicant This is a reference data field. Please use /v1/utilities/referenceData/{businessNature} resource to get valid value of this field with description.
    attr_accessor :business_nature

    # Emergency contact given name
    attr_accessor :emergency_contact_name

    # Emergency contact surname
    attr_accessor :emergency_contact_surname

    # Applicant's relationship with the emergency contact.This is a reference data. Please use /v1/utilities/referenceData/{emergencyContactRelationship} resource to get valid value of this field
    attr_accessor :emergency_contact_relationship

    # Emergency contact Number.
    attr_accessor :emergency_contact_phone_number

    # Customer consent on spending more than the limit assigned to him. Valid values: true and false
    attr_accessor :over_limit_consent_flag

    attr_accessor :country_specific_group

    attr_accessor :primary_bank_details

    # Referral First Name.
    attr_accessor :referral_given_name

    # Referral Surname/Last Name.
    attr_accessor :referral_surname

    # Referral Code used for the customer
    attr_accessor :referral_code

    # The media ID will be used to determine which offer / campaign banner was clicked when the customer made his application 
    attr_accessor :media_id

    # Unique identifier associated with the introducer who had referred the applicant.
    attr_accessor :introducer_id

    # Self declaration if applicant has any relation with citi bank employee. Valid values: true and false
    attr_accessor :related_to_citi_employee_flag

    # Name of the citi employee if applicant has any relation with citi bank employee.
    attr_accessor :related_citi_employee_name

    # Department of citi employee if applicant has any relation with citi bank employee.
    attr_accessor :related_citi_employee_department

    # Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description.
    attr_accessor :credit_card_usage_purpose

    # Indicates whether the customer wants a separate cash PIN.
    attr_accessor :cash_pin_flag

    attr_accessor :referral_tracking

    attr_accessor :utility_bill_details

    # Fee code that applied to the requested product
    attr_accessor :fee_code

    # Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description.
    attr_accessor :billing_cycle_day

    # Unique reference ID associated with the application
    attr_accessor :application_reference_id

    # Customer segment decides each applicants interest rate  Different customer target will be subjected to different interest rate..This is a reference data field. Please use /v1/utilities/referenceData/{customerSegment} resource to get valid value of this field with description. 
    attr_accessor :customer_segment

    # This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between
    attr_accessor :printing_serial_number

    # This field refers to the additional comments given by the customer which is to be noted-down during the application process.
    attr_accessor :additional_information

    attr_accessor :trade_reference_details

    # Session ID that is generated from the session / interaction of channel with bureau.
    attr_accessor :bureau_session_id_

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'account_fund_source' => :'accountFundSource',
        :'number_of_dependents' => :'numberOfDependents',
        :'staff_indicator' => :'staffIndicator',
        :'business_nature' => :'businessNature',
        :'emergency_contact_name' => :'emergencyContactName',
        :'emergency_contact_surname' => :'emergencyContactSurname',
        :'emergency_contact_relationship' => :'emergencyContactRelationship',
        :'emergency_contact_phone_number' => :'emergencyContactPhoneNumber',
        :'over_limit_consent_flag' => :'overLimitConsentFlag',
        :'country_specific_group' => :'countrySpecificGroup',
        :'primary_bank_details' => :'primaryBankDetails',
        :'referral_given_name' => :'referralGivenName',
        :'referral_surname' => :'referralSurname',
        :'referral_code' => :'referralCode',
        :'media_id' => :'mediaId',
        :'introducer_id' => :'introducerId',
        :'related_to_citi_employee_flag' => :'relatedToCitiEmployeeFlag',
        :'related_citi_employee_name' => :'relatedCitiEmployeeName',
        :'related_citi_employee_department' => :'relatedCitiEmployeeDepartment',
        :'credit_card_usage_purpose' => :'creditCardUsagePurpose',
        :'cash_pin_flag' => :'cashPinFlag',
        :'referral_tracking' => :'referralTracking',
        :'utility_bill_details' => :'utilityBillDetails',
        :'fee_code' => :'feeCode',
        :'billing_cycle_day' => :'billingCycleDay',
        :'application_reference_id' => :'applicationReferenceId',
        :'customer_segment' => :'customerSegment',
        :'printing_serial_number' => :'printingSerialNumber',
        :'additional_information' => :'additionalInformation',
        :'trade_reference_details' => :'tradeReferenceDetails',
        :'bureau_session_id_' => :'bureauSessionId '
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'account_fund_source' => :'Object',
        :'number_of_dependents' => :'Object',
        :'staff_indicator' => :'Object',
        :'business_nature' => :'Object',
        :'emergency_contact_name' => :'Object',
        :'emergency_contact_surname' => :'Object',
        :'emergency_contact_relationship' => :'Object',
        :'emergency_contact_phone_number' => :'Object',
        :'over_limit_consent_flag' => :'Object',
        :'country_specific_group' => :'Object',
        :'primary_bank_details' => :'Object',
        :'referral_given_name' => :'Object',
        :'referral_surname' => :'Object',
        :'referral_code' => :'Object',
        :'media_id' => :'Object',
        :'introducer_id' => :'Object',
        :'related_to_citi_employee_flag' => :'Object',
        :'related_citi_employee_name' => :'Object',
        :'related_citi_employee_department' => :'Object',
        :'credit_card_usage_purpose' => :'Object',
        :'cash_pin_flag' => :'Object',
        :'referral_tracking' => :'Object',
        :'utility_bill_details' => :'Object',
        :'fee_code' => :'Object',
        :'billing_cycle_day' => :'Object',
        :'application_reference_id' => :'Object',
        :'customer_segment' => :'Object',
        :'printing_serial_number' => :'Object',
        :'additional_information' => :'Object',
        :'trade_reference_details' => :'Object',
        :'bureau_session_id_' => :'Object'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
      ])
    end
  
    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::AdditionalDataAdd` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::AdditionalDataAdd`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'account_fund_source')
        self.account_fund_source = attributes[:'account_fund_source']
      end

      if attributes.key?(:'number_of_dependents')
        self.number_of_dependents = attributes[:'number_of_dependents']
      end

      if attributes.key?(:'staff_indicator')
        self.staff_indicator = attributes[:'staff_indicator']
      end

      if attributes.key?(:'business_nature')
        self.business_nature = attributes[:'business_nature']
      end

      if attributes.key?(:'emergency_contact_name')
        self.emergency_contact_name = attributes[:'emergency_contact_name']
      end

      if attributes.key?(:'emergency_contact_surname')
        self.emergency_contact_surname = attributes[:'emergency_contact_surname']
      end

      if attributes.key?(:'emergency_contact_relationship')
        self.emergency_contact_relationship = attributes[:'emergency_contact_relationship']
      end

      if attributes.key?(:'emergency_contact_phone_number')
        self.emergency_contact_phone_number = attributes[:'emergency_contact_phone_number']
      end

      if attributes.key?(:'over_limit_consent_flag')
        self.over_limit_consent_flag = attributes[:'over_limit_consent_flag']
      end

      if attributes.key?(:'country_specific_group')
        self.country_specific_group = attributes[:'country_specific_group']
      end

      if attributes.key?(:'primary_bank_details')
        self.primary_bank_details = attributes[:'primary_bank_details']
      end

      if attributes.key?(:'referral_given_name')
        self.referral_given_name = attributes[:'referral_given_name']
      end

      if attributes.key?(:'referral_surname')
        self.referral_surname = attributes[:'referral_surname']
      end

      if attributes.key?(:'referral_code')
        self.referral_code = attributes[:'referral_code']
      end

      if attributes.key?(:'media_id')
        self.media_id = attributes[:'media_id']
      end

      if attributes.key?(:'introducer_id')
        self.introducer_id = attributes[:'introducer_id']
      end

      if attributes.key?(:'related_to_citi_employee_flag')
        self.related_to_citi_employee_flag = attributes[:'related_to_citi_employee_flag']
      end

      if attributes.key?(:'related_citi_employee_name')
        self.related_citi_employee_name = attributes[:'related_citi_employee_name']
      end

      if attributes.key?(:'related_citi_employee_department')
        self.related_citi_employee_department = attributes[:'related_citi_employee_department']
      end

      if attributes.key?(:'credit_card_usage_purpose')
        self.credit_card_usage_purpose = attributes[:'credit_card_usage_purpose']
      end

      if attributes.key?(:'cash_pin_flag')
        self.cash_pin_flag = attributes[:'cash_pin_flag']
      end

      if attributes.key?(:'referral_tracking')
        self.referral_tracking = attributes[:'referral_tracking']
      end

      if attributes.key?(:'utility_bill_details')
        self.utility_bill_details = attributes[:'utility_bill_details']
      end

      if attributes.key?(:'fee_code')
        self.fee_code = attributes[:'fee_code']
      end

      if attributes.key?(:'billing_cycle_day')
        self.billing_cycle_day = attributes[:'billing_cycle_day']
      end

      if attributes.key?(:'application_reference_id')
        self.application_reference_id = attributes[:'application_reference_id']
      end

      if attributes.key?(:'customer_segment')
        self.customer_segment = attributes[:'customer_segment']
      end

      if attributes.key?(:'printing_serial_number')
        self.printing_serial_number = attributes[:'printing_serial_number']
      end

      if attributes.key?(:'additional_information')
        self.additional_information = attributes[:'additional_information']
      end

      if attributes.key?(:'trade_reference_details')
        self.trade_reference_details = attributes[:'trade_reference_details']
      end

      if attributes.key?(:'bureau_session_id_')
        self.bureau_session_id_ = attributes[:'bureau_session_id_']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          account_fund_source == o.account_fund_source &&
          number_of_dependents == o.number_of_dependents &&
          staff_indicator == o.staff_indicator &&
          business_nature == o.business_nature &&
          emergency_contact_name == o.emergency_contact_name &&
          emergency_contact_surname == o.emergency_contact_surname &&
          emergency_contact_relationship == o.emergency_contact_relationship &&
          emergency_contact_phone_number == o.emergency_contact_phone_number &&
          over_limit_consent_flag == o.over_limit_consent_flag &&
          country_specific_group == o.country_specific_group &&
          primary_bank_details == o.primary_bank_details &&
          referral_given_name == o.referral_given_name &&
          referral_surname == o.referral_surname &&
          referral_code == o.referral_code &&
          media_id == o.media_id &&
          introducer_id == o.introducer_id &&
          related_to_citi_employee_flag == o.related_to_citi_employee_flag &&
          related_citi_employee_name == o.related_citi_employee_name &&
          related_citi_employee_department == o.related_citi_employee_department &&
          credit_card_usage_purpose == o.credit_card_usage_purpose &&
          cash_pin_flag == o.cash_pin_flag &&
          referral_tracking == o.referral_tracking &&
          utility_bill_details == o.utility_bill_details &&
          fee_code == o.fee_code &&
          billing_cycle_day == o.billing_cycle_day &&
          application_reference_id == o.application_reference_id &&
          customer_segment == o.customer_segment &&
          printing_serial_number == o.printing_serial_number &&
          additional_information == o.additional_information &&
          trade_reference_details == o.trade_reference_details &&
          bureau_session_id_ == o.bureau_session_id_
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [account_fund_source, number_of_dependents, staff_indicator, business_nature, emergency_contact_name, emergency_contact_surname, emergency_contact_relationship, emergency_contact_phone_number, over_limit_consent_flag, country_specific_group, primary_bank_details, referral_given_name, referral_surname, referral_code, media_id, introducer_id, related_to_citi_employee_flag, related_citi_employee_name, related_citi_employee_department, credit_card_usage_purpose, cash_pin_flag, referral_tracking, utility_bill_details, fee_code, billing_cycle_day, application_reference_id, customer_segment, printing_serial_number, additional_information, trade_reference_details, bureau_session_id_].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      self.class.openapi_types.each_pair do |key, type|
        if type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        elsif attributes[self.class.attribute_map[key]].nil? && self.class.openapi_nullable.include?(key)
          self.send("#{key}=", nil)
        end
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :DateTime
        DateTime.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        SwaggerClient.const_get(type).build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          is_nullable = self.class.openapi_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end

        hash[param] = _to_hash(value)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end  end
end
