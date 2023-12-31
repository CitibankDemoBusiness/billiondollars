# coding: utf-8

"""
    Accounts

    The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class CreditCheck(object):
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
        'tenor': 'float',
        'maximum_eligible_loan_amount': 'float',
        'annual_percentage_rate': 'float'
    }

    attribute_map = {
        'tenor': 'tenor',
        'maximum_eligible_loan_amount': 'maximumEligibleLoanAmount',
        'annual_percentage_rate': 'annualPercentageRate'
    }

    def __init__(self, tenor=None, maximum_eligible_loan_amount=None, annual_percentage_rate=None):  # noqa: E501
        """CreditCheck - a model defined in Swagger"""  # noqa: E501
        self._tenor = None
        self._maximum_eligible_loan_amount = None
        self._annual_percentage_rate = None
        self.discriminator = None
        self.tenor = tenor
        self.maximum_eligible_loan_amount = maximum_eligible_loan_amount
        if annual_percentage_rate is not None:
            self.annual_percentage_rate = annual_percentage_rate

    @property
    def tenor(self):
        """Gets the tenor of this CreditCheck.  # noqa: E501

        Tenure of loan in months.  # noqa: E501

        :return: The tenor of this CreditCheck.  # noqa: E501
        :rtype: float
        """
        return self._tenor

    @tenor.setter
    def tenor(self, tenor):
        """Sets the tenor of this CreditCheck.

        Tenure of loan in months.  # noqa: E501

        :param tenor: The tenor of this CreditCheck.  # noqa: E501
        :type: float
        """
        if tenor is None:
            raise ValueError("Invalid value for `tenor`, must not be `None`")  # noqa: E501

        self._tenor = tenor

    @property
    def maximum_eligible_loan_amount(self):
        """Gets the maximum_eligible_loan_amount of this CreditCheck.  # noqa: E501

        Maximum Eligible Loan amount corresponding to each tenure.  # noqa: E501

        :return: The maximum_eligible_loan_amount of this CreditCheck.  # noqa: E501
        :rtype: float
        """
        return self._maximum_eligible_loan_amount

    @maximum_eligible_loan_amount.setter
    def maximum_eligible_loan_amount(self, maximum_eligible_loan_amount):
        """Sets the maximum_eligible_loan_amount of this CreditCheck.

        Maximum Eligible Loan amount corresponding to each tenure.  # noqa: E501

        :param maximum_eligible_loan_amount: The maximum_eligible_loan_amount of this CreditCheck.  # noqa: E501
        :type: float
        """
        if maximum_eligible_loan_amount is None:
            raise ValueError("Invalid value for `maximum_eligible_loan_amount`, must not be `None`")  # noqa: E501

        self._maximum_eligible_loan_amount = maximum_eligible_loan_amount

    @property
    def annual_percentage_rate(self):
        """Gets the annual_percentage_rate of this CreditCheck.  # noqa: E501

        Compounded annual interest rate.  # noqa: E501

        :return: The annual_percentage_rate of this CreditCheck.  # noqa: E501
        :rtype: float
        """
        return self._annual_percentage_rate

    @annual_percentage_rate.setter
    def annual_percentage_rate(self, annual_percentage_rate):
        """Sets the annual_percentage_rate of this CreditCheck.

        Compounded annual interest rate.  # noqa: E501

        :param annual_percentage_rate: The annual_percentage_rate of this CreditCheck.  # noqa: E501
        :type: float
        """

        self._annual_percentage_rate = annual_percentage_rate

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
        if issubclass(CreditCheck, dict):
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
        if not isinstance(other, CreditCheck):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
