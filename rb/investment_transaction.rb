=begin
#Accounts

#The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class InvestmentTransaction
    # Order date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting
    attr_accessor :order_date

    # Reference Id to uniquely identify the investment transaction
    attr_accessor :order_reference_id

    # This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderType} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
    attr_accessor :order_type

    # Order code to uniquely identify the transaction,
    attr_accessor :code

    # Unique name  for fund/stock
    attr_accessor :name

    # The currency code of the transaction in ISO 4217 format,
    attr_accessor :currency_code

    # Transaction amount in local currency.
    attr_accessor :transaction_amount

    # Order price of  trade
    attr_accessor :price

    # This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderStatus} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values.
    attr_accessor :order_status

    # The total amount of the transaction
    attr_accessor :gross_amount

    # Total number of units ordered
    attr_accessor :order_quantity

    # The medium used by customer to place order.This is a reference data field. Please use /v1/apac/utilities/referenceData/{orderMedium} resource to get possible values of This field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values.
    attr_accessor :order_medium

    # Number of units received
    attr_accessor :filled_quantity

    # Number of units not received
    attr_accessor :balance_quantity

    # Trading market code for securities
    attr_accessor :stock_market_code

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'order_date' => :'orderDate',
        :'order_reference_id' => :'orderReferenceId',
        :'order_type' => :'orderType',
        :'code' => :'code',
        :'name' => :'name',
        :'currency_code' => :'currencyCode',
        :'transaction_amount' => :'transactionAmount',
        :'price' => :'price',
        :'order_status' => :'orderStatus',
        :'gross_amount' => :'grossAmount',
        :'order_quantity' => :'orderQuantity',
        :'order_medium' => :'orderMedium',
        :'filled_quantity' => :'filledQuantity',
        :'balance_quantity' => :'balanceQuantity',
        :'stock_market_code' => :'stockMarketCode'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'order_date' => :'Object',
        :'order_reference_id' => :'Object',
        :'order_type' => :'Object',
        :'code' => :'Object',
        :'name' => :'Object',
        :'currency_code' => :'Object',
        :'transaction_amount' => :'Object',
        :'price' => :'Object',
        :'order_status' => :'Object',
        :'gross_amount' => :'Object',
        :'order_quantity' => :'Object',
        :'order_medium' => :'Object',
        :'filled_quantity' => :'Object',
        :'balance_quantity' => :'Object',
        :'stock_market_code' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::InvestmentTransaction` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::InvestmentTransaction`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'order_date')
        self.order_date = attributes[:'order_date']
      end

      if attributes.key?(:'order_reference_id')
        self.order_reference_id = attributes[:'order_reference_id']
      end

      if attributes.key?(:'order_type')
        self.order_type = attributes[:'order_type']
      end

      if attributes.key?(:'code')
        self.code = attributes[:'code']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'currency_code')
        self.currency_code = attributes[:'currency_code']
      end

      if attributes.key?(:'transaction_amount')
        self.transaction_amount = attributes[:'transaction_amount']
      end

      if attributes.key?(:'price')
        self.price = attributes[:'price']
      end

      if attributes.key?(:'order_status')
        self.order_status = attributes[:'order_status']
      end

      if attributes.key?(:'gross_amount')
        self.gross_amount = attributes[:'gross_amount']
      end

      if attributes.key?(:'order_quantity')
        self.order_quantity = attributes[:'order_quantity']
      end

      if attributes.key?(:'order_medium')
        self.order_medium = attributes[:'order_medium']
      end

      if attributes.key?(:'filled_quantity')
        self.filled_quantity = attributes[:'filled_quantity']
      end

      if attributes.key?(:'balance_quantity')
        self.balance_quantity = attributes[:'balance_quantity']
      end

      if attributes.key?(:'stock_market_code')
        self.stock_market_code = attributes[:'stock_market_code']
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
          order_date == o.order_date &&
          order_reference_id == o.order_reference_id &&
          order_type == o.order_type &&
          code == o.code &&
          name == o.name &&
          currency_code == o.currency_code &&
          transaction_amount == o.transaction_amount &&
          price == o.price &&
          order_status == o.order_status &&
          gross_amount == o.gross_amount &&
          order_quantity == o.order_quantity &&
          order_medium == o.order_medium &&
          filled_quantity == o.filled_quantity &&
          balance_quantity == o.balance_quantity &&
          stock_market_code == o.stock_market_code
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [order_date, order_reference_id, order_type, code, name, currency_code, transaction_amount, price, order_status, gross_amount, order_quantity, order_medium, filled_quantity, balance_quantity, stock_market_code].hash
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
