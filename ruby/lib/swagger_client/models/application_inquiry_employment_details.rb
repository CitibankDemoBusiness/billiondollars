=begin
#Onboarding

#The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class ApplicationInquiryEmploymentDetails
    # Name of the employer.
    attr_accessor :employer_name

    # Job Title. This is a reference data field. Please use /v1/apac/utilities/referenceData/{jobTitle} resource to get valid value of this field with description. You can use jobTitle field name as the referenceCode parameter to retrieve the values.
    attr_accessor :job_title

    # Occupation code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{occupationCode} resource to get valid value of this field with description. You can use occupationCode field name as the referenceCode parameter to retrieve the values.
    attr_accessor :occupation_code

    # Code of the industry of employment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{industryCode} resource to get valid value of this field with description. You can use industryCode field name as the referenceCode parameter to retrieve the values.
    attr_accessor :industry_code

    # Employment duration in years
    attr_accessor :employment_duration_in_years

    # Employment duration in months
    attr_accessor :employment_duration_in_months

    # Status of the employment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{employmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
    attr_accessor :employment_status

    # Months spent in the previouse employment
    attr_accessor :months_in_previous_employment

    # Years spent in the previouse employment
    attr_accessor :years_in_previous_employment

    # Accountant or contact's name
    attr_accessor :accountant_name

    # Accountant's firm or business name
    attr_accessor :accountant_firm_name

    # Years spent in industry
    attr_accessor :years_in_industry

    # Months spent in industry
    attr_accessor :months_in_industry

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'employer_name' => :'employerName',
        :'job_title' => :'jobTitle',
        :'occupation_code' => :'occupationCode',
        :'industry_code' => :'industryCode',
        :'employment_duration_in_years' => :'employmentDurationInYears',
        :'employment_duration_in_months' => :'employmentDurationInMonths',
        :'employment_status' => :'employmentStatus',
        :'months_in_previous_employment' => :'monthsInPreviousEmployment',
        :'years_in_previous_employment' => :'yearsInPreviousEmployment',
        :'accountant_name' => :'accountantName',
        :'accountant_firm_name' => :'accountantFirmName',
        :'years_in_industry' => :'yearsInIndustry',
        :'months_in_industry' => :'monthsInIndustry'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'employer_name' => :'Object',
        :'job_title' => :'Object',
        :'occupation_code' => :'Object',
        :'industry_code' => :'Object',
        :'employment_duration_in_years' => :'Object',
        :'employment_duration_in_months' => :'Object',
        :'employment_status' => :'Object',
        :'months_in_previous_employment' => :'Object',
        :'years_in_previous_employment' => :'Object',
        :'accountant_name' => :'Object',
        :'accountant_firm_name' => :'Object',
        :'years_in_industry' => :'Object',
        :'months_in_industry' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::ApplicationInquiryEmploymentDetails` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::ApplicationInquiryEmploymentDetails`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'employer_name')
        self.employer_name = attributes[:'employer_name']
      end

      if attributes.key?(:'job_title')
        self.job_title = attributes[:'job_title']
      end

      if attributes.key?(:'occupation_code')
        self.occupation_code = attributes[:'occupation_code']
      end

      if attributes.key?(:'industry_code')
        self.industry_code = attributes[:'industry_code']
      end

      if attributes.key?(:'employment_duration_in_years')
        self.employment_duration_in_years = attributes[:'employment_duration_in_years']
      end

      if attributes.key?(:'employment_duration_in_months')
        self.employment_duration_in_months = attributes[:'employment_duration_in_months']
      end

      if attributes.key?(:'employment_status')
        self.employment_status = attributes[:'employment_status']
      end

      if attributes.key?(:'months_in_previous_employment')
        self.months_in_previous_employment = attributes[:'months_in_previous_employment']
      end

      if attributes.key?(:'years_in_previous_employment')
        self.years_in_previous_employment = attributes[:'years_in_previous_employment']
      end

      if attributes.key?(:'accountant_name')
        self.accountant_name = attributes[:'accountant_name']
      end

      if attributes.key?(:'accountant_firm_name')
        self.accountant_firm_name = attributes[:'accountant_firm_name']
      end

      if attributes.key?(:'years_in_industry')
        self.years_in_industry = attributes[:'years_in_industry']
      end

      if attributes.key?(:'months_in_industry')
        self.months_in_industry = attributes[:'months_in_industry']
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
          employer_name == o.employer_name &&
          job_title == o.job_title &&
          occupation_code == o.occupation_code &&
          industry_code == o.industry_code &&
          employment_duration_in_years == o.employment_duration_in_years &&
          employment_duration_in_months == o.employment_duration_in_months &&
          employment_status == o.employment_status &&
          months_in_previous_employment == o.months_in_previous_employment &&
          years_in_previous_employment == o.years_in_previous_employment &&
          accountant_name == o.accountant_name &&
          accountant_firm_name == o.accountant_firm_name &&
          years_in_industry == o.years_in_industry &&
          months_in_industry == o.months_in_industry
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [employer_name, job_title, occupation_code, industry_code, employment_duration_in_years, employment_duration_in_months, employment_status, months_in_previous_employment, years_in_previous_employment, accountant_name, accountant_firm_name, years_in_industry, months_in_industry].hash
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
