# coding: utf-8

"""
    Onboarding

    The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class IncomeDetails(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'income_type': 'str',
        'fixed_amount': 'float',
        'variable_amount': 'float',
        'currency_code': 'str',
        'frequency': 'str',
        'other_income_description': 'str'
    }

    attribute_map = {
        'income_type': 'incomeType',
        'fixed_amount': 'fixedAmount',
        'variable_amount': 'variableAmount',
        'currency_code': 'currencyCode',
        'frequency': 'frequency',
        'other_income_description': 'otherIncomeDescription'
    }

    def __init__(self, income_type=None, fixed_amount=None, variable_amount=None, currency_code=None, frequency=None, other_income_description=None):  # noqa: E501
        """IncomeDetails - a model defined in Swagger"""  # noqa: E501
        self._income_type = None
        self._fixed_amount = None
        self._variable_amount = None
        self._currency_code = None
        self._frequency = None
        self._other_income_description = None
        self.discriminator = None
        if income_type is not None:
            self.income_type = income_type
        if fixed_amount is not None:
            self.fixed_amount = fixed_amount
        if variable_amount is not None:
            self.variable_amount = variable_amount
        if currency_code is not None:
            self.currency_code = currency_code
        if frequency is not None:
            self.frequency = frequency
        if other_income_description is not None:
            self.other_income_description = other_income_description

    @property
    def income_type(self):
        """Gets the income_type of this IncomeDetails.  # noqa: E501

        Income type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get possible values of this field with descriptions. You can use incomeType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The income_type of this IncomeDetails.  # noqa: E501
        :rtype: str
        """
        return self._income_type

    @income_type.setter
    def income_type(self, income_type):
        """Sets the income_type of this IncomeDetails.

        Income type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{incomeType} resource to get possible values of this field with descriptions. You can use incomeType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param income_type: The income_type of this IncomeDetails.  # noqa: E501
        :type: str
        """

        self._income_type = income_type

    @property
    def fixed_amount(self):
        """Gets the fixed_amount of this IncomeDetails.  # noqa: E501

        Fixed income amount  # noqa: E501

        :return: The fixed_amount of this IncomeDetails.  # noqa: E501
        :rtype: float
        """
        return self._fixed_amount

    @fixed_amount.setter
    def fixed_amount(self, fixed_amount):
        """Sets the fixed_amount of this IncomeDetails.

        Fixed income amount  # noqa: E501

        :param fixed_amount: The fixed_amount of this IncomeDetails.  # noqa: E501
        :type: float
        """

        self._fixed_amount = fixed_amount

    @property
    def variable_amount(self):
        """Gets the variable_amount of this IncomeDetails.  # noqa: E501

        Variable income amount  # noqa: E501

        :return: The variable_amount of this IncomeDetails.  # noqa: E501
        :rtype: float
        """
        return self._variable_amount

    @variable_amount.setter
    def variable_amount(self, variable_amount):
        """Sets the variable_amount of this IncomeDetails.

        Variable income amount  # noqa: E501

        :param variable_amount: The variable_amount of this IncomeDetails.  # noqa: E501
        :type: float
        """

        self._variable_amount = variable_amount

    @property
    def currency_code(self):
        """Gets the currency_code of this IncomeDetails.  # noqa: E501

        Currency Code in ISO 4217 format.  # noqa: E501

        :return: The currency_code of this IncomeDetails.  # noqa: E501
        :rtype: str
        """
        return self._currency_code

    @currency_code.setter
    def currency_code(self, currency_code):
        """Sets the currency_code of this IncomeDetails.

        Currency Code in ISO 4217 format.  # noqa: E501

        :param currency_code: The currency_code of this IncomeDetails.  # noqa: E501
        :type: str
        """

        self._currency_code = currency_code

    @property
    def frequency(self):
        """Gets the frequency of this IncomeDetails.  # noqa: E501

        Frequency. This is a reference data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get possible values of this field with descriptions. You can use frequency field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The frequency of this IncomeDetails.  # noqa: E501
        :rtype: str
        """
        return self._frequency

    @frequency.setter
    def frequency(self, frequency):
        """Sets the frequency of this IncomeDetails.

        Frequency. This is a reference data field. Please use /v1/apac/utilities/referenceData/{frequency} resource to get possible values of this field with descriptions. You can use frequency field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param frequency: The frequency of this IncomeDetails.  # noqa: E501
        :type: str
        """

        self._frequency = frequency

    @property
    def other_income_description(self):
        """Gets the other_income_description of this IncomeDetails.  # noqa: E501

        Description of income from other sources  # noqa: E501

        :return: The other_income_description of this IncomeDetails.  # noqa: E501
        :rtype: str
        """
        return self._other_income_description

    @other_income_description.setter
    def other_income_description(self, other_income_description):
        """Sets the other_income_description of this IncomeDetails.

        Description of income from other sources  # noqa: E501

        :param other_income_description: The other_income_description of this IncomeDetails.  # noqa: E501
        :type: str
        """

        self._other_income_description = other_income_description

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(IncomeDetails, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, IncomeDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
