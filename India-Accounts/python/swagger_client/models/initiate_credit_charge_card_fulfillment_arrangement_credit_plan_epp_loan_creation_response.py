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

class InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse(object):
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
        'next_installment_amount': 'float',
        'interest_rate': 'float',
        'initial_fee': 'float'
    }

    attribute_map = {
        'next_installment_amount': 'nextInstallmentAmount',
        'interest_rate': 'interestRate',
        'initial_fee': 'initialFee'
    }

    def __init__(self, next_installment_amount=None, interest_rate=None, initial_fee=None):  # noqa: E501
        """InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse - a model defined in Swagger"""  # noqa: E501
        self._next_installment_amount = None
        self._interest_rate = None
        self._initial_fee = None
        self.discriminator = None
        if next_installment_amount is not None:
            self.next_installment_amount = next_installment_amount
        if interest_rate is not None:
            self.interest_rate = interest_rate
        if initial_fee is not None:
            self.initial_fee = initial_fee

    @property
    def next_installment_amount(self):
        """Gets the next_installment_amount of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.  # noqa: E501

        Next installment Amount for the loan  # noqa: E501

        :return: The next_installment_amount of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.  # noqa: E501
        :rtype: float
        """
        return self._next_installment_amount

    @next_installment_amount.setter
    def next_installment_amount(self, next_installment_amount):
        """Sets the next_installment_amount of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.

        Next installment Amount for the loan  # noqa: E501

        :param next_installment_amount: The next_installment_amount of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.  # noqa: E501
        :type: float
        """

        self._next_installment_amount = next_installment_amount

    @property
    def interest_rate(self):
        """Gets the interest_rate of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.  # noqa: E501

        Interest Rate for the loan  # noqa: E501

        :return: The interest_rate of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.  # noqa: E501
        :rtype: float
        """
        return self._interest_rate

    @interest_rate.setter
    def interest_rate(self, interest_rate):
        """Sets the interest_rate of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.

        Interest Rate for the loan  # noqa: E501

        :param interest_rate: The interest_rate of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.  # noqa: E501
        :type: float
        """

        self._interest_rate = interest_rate

    @property
    def initial_fee(self):
        """Gets the initial_fee of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.  # noqa: E501

        Initial Fees for the loan  # noqa: E501

        :return: The initial_fee of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.  # noqa: E501
        :rtype: float
        """
        return self._initial_fee

    @initial_fee.setter
    def initial_fee(self, initial_fee):
        """Sets the initial_fee of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.

        Initial Fees for the loan  # noqa: E501

        :param initial_fee: The initial_fee of this InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse.  # noqa: E501
        :type: float
        """

        self._initial_fee = initial_fee

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
        if issubclass(InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse, dict):
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
        if not isinstance(other, InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
