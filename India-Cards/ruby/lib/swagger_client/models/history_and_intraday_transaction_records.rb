=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class HistoryAndIntradayTransactionRecords
    # Transaction date in ISO 8601  format YYYY-MM-DD
    attr_accessor :transaction_date

    # This field indicates the merchant Name
    attr_accessor :merchant_name

    # This filed indicates the Merchant Address
    attr_accessor :merchant_location

    # This field provides the status of the transaction. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions.
    attr_accessor :transaction_status

    # Decline Description- for declined transaction
    attr_accessor :reason_description

    # Amount of funds the cardholder requested in source location of the transaction.
    attr_accessor :transaction_amount

    # transactionCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{transactionCurrencyCode} resource to get possible values of this field with descriptions
    attr_accessor :transaction_currency_code

    # Amount billed to the cardholder in the cardholder account currency
    attr_accessor :billed_amount

    # billedCurrencyCode. This is a reference data field. Please use /v1/utilities/referenceData/{billedCurrencyCode} resource to get possible values of this field with descriptions
    attr_accessor :billed_currency_code

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'transaction_date' => :'transactionDate',
        :'merchant_name' => :'merchantName',
        :'merchant_location' => :'merchantLocation',
        :'transaction_status' => :'transactionStatus',
        :'reason_description' => :'reasonDescription',
        :'transaction_amount' => :'transactionAmount',
        :'transaction_currency_code' => :'transactionCurrencyCode',
        :'billed_amount' => :'billedAmount',
        :'billed_currency_code' => :'billedCurrencyCode'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'transaction_date' => :'Object',
        :'merchant_name' => :'Object',
        :'merchant_location' => :'Object',
        :'transaction_status' => :'Object',
        :'reason_description' => :'Object',
        :'transaction_amount' => :'Object',
        :'transaction_currency_code' => :'Object',
        :'billed_amount' => :'Object',
        :'billed_currency_code' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::HistoryAndIntradayTransactionRecords` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::HistoryAndIntradayTransactionRecords`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'transaction_date')
        self.transaction_date = attributes[:'transaction_date']
      end

      if attributes.key?(:'merchant_name')
        self.merchant_name = attributes[:'merchant_name']
      end

      if attributes.key?(:'merchant_location')
        self.merchant_location = attributes[:'merchant_location']
      end

      if attributes.key?(:'transaction_status')
        self.transaction_status = attributes[:'transaction_status']
      end

      if attributes.key?(:'reason_description')
        self.reason_description = attributes[:'reason_description']
      end

      if attributes.key?(:'transaction_amount')
        self.transaction_amount = attributes[:'transaction_amount']
      end

      if attributes.key?(:'transaction_currency_code')
        self.transaction_currency_code = attributes[:'transaction_currency_code']
      end

      if attributes.key?(:'billed_amount')
        self.billed_amount = attributes[:'billed_amount']
      end

      if attributes.key?(:'billed_currency_code')
        self.billed_currency_code = attributes[:'billed_currency_code']
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
          transaction_date == o.transaction_date &&
          merchant_name == o.merchant_name &&
          merchant_location == o.merchant_location &&
          transaction_status == o.transaction_status &&
          reason_description == o.reason_description &&
          transaction_amount == o.transaction_amount &&
          transaction_currency_code == o.transaction_currency_code &&
          billed_amount == o.billed_amount &&
          billed_currency_code == o.billed_currency_code
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [transaction_date, merchant_name, merchant_location, transaction_status, reason_description, transaction_amount, transaction_currency_code, billed_amount, billed_currency_code].hash
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