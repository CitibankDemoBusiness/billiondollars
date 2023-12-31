# coding: utf-8

"""
    Cards

    The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class RetrieveCreditChargeCardCorporateCardsDetailResponse(object):
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
        'cash_withdrawal_allowed_flag': 'bool',
        'permanent_credit_limit_amount': 'float',
        'current_balance_amount': 'float',
        'card_status': 'str'
    }

    attribute_map = {
        'cash_withdrawal_allowed_flag': 'cashWithdrawalAllowedFlag',
        'permanent_credit_limit_amount': 'permanentCreditLimitAmount',
        'current_balance_amount': 'currentBalanceAmount',
        'card_status': 'cardStatus'
    }

    def __init__(self, cash_withdrawal_allowed_flag=None, permanent_credit_limit_amount=None, current_balance_amount=None, card_status=None):  # noqa: E501
        """RetrieveCreditChargeCardCorporateCardsDetailResponse - a model defined in Swagger"""  # noqa: E501
        self._cash_withdrawal_allowed_flag = None
        self._permanent_credit_limit_amount = None
        self._current_balance_amount = None
        self._card_status = None
        self.discriminator = None
        if cash_withdrawal_allowed_flag is not None:
            self.cash_withdrawal_allowed_flag = cash_withdrawal_allowed_flag
        if permanent_credit_limit_amount is not None:
            self.permanent_credit_limit_amount = permanent_credit_limit_amount
        if current_balance_amount is not None:
            self.current_balance_amount = current_balance_amount
        if card_status is not None:
            self.card_status = card_status

    @property
    def cash_withdrawal_allowed_flag(self):
        """Gets the cash_withdrawal_allowed_flag of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501

        This field is used to indicate, whether the customer is allowed to withdraw cash or not  # noqa: E501

        :return: The cash_withdrawal_allowed_flag of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501
        :rtype: bool
        """
        return self._cash_withdrawal_allowed_flag

    @cash_withdrawal_allowed_flag.setter
    def cash_withdrawal_allowed_flag(self, cash_withdrawal_allowed_flag):
        """Sets the cash_withdrawal_allowed_flag of this RetrieveCreditChargeCardCorporateCardsDetailResponse.

        This field is used to indicate, whether the customer is allowed to withdraw cash or not  # noqa: E501

        :param cash_withdrawal_allowed_flag: The cash_withdrawal_allowed_flag of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501
        :type: bool
        """

        self._cash_withdrawal_allowed_flag = cash_withdrawal_allowed_flag

    @property
    def permanent_credit_limit_amount(self):
        """Gets the permanent_credit_limit_amount of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501

        This field is used to indicate the limit present on the card  # noqa: E501

        :return: The permanent_credit_limit_amount of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501
        :rtype: float
        """
        return self._permanent_credit_limit_amount

    @permanent_credit_limit_amount.setter
    def permanent_credit_limit_amount(self, permanent_credit_limit_amount):
        """Sets the permanent_credit_limit_amount of this RetrieveCreditChargeCardCorporateCardsDetailResponse.

        This field is used to indicate the limit present on the card  # noqa: E501

        :param permanent_credit_limit_amount: The permanent_credit_limit_amount of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501
        :type: float
        """

        self._permanent_credit_limit_amount = permanent_credit_limit_amount

    @property
    def current_balance_amount(self):
        """Gets the current_balance_amount of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501

        This is the balance credit limit left after monthly spend  # noqa: E501

        :return: The current_balance_amount of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501
        :rtype: float
        """
        return self._current_balance_amount

    @current_balance_amount.setter
    def current_balance_amount(self, current_balance_amount):
        """Sets the current_balance_amount of this RetrieveCreditChargeCardCorporateCardsDetailResponse.

        This is the balance credit limit left after monthly spend  # noqa: E501

        :param current_balance_amount: The current_balance_amount of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501
        :type: float
        """

        self._current_balance_amount = current_balance_amount

    @property
    def card_status(self):
        """Gets the card_status of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501

        This field shows the card status. This is a reference data field. Please use /v1/utilities/referenceData/{cardStatus} resource to get possible values of this field with descriptions  # noqa: E501

        :return: The card_status of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501
        :rtype: str
        """
        return self._card_status

    @card_status.setter
    def card_status(self, card_status):
        """Sets the card_status of this RetrieveCreditChargeCardCorporateCardsDetailResponse.

        This field shows the card status. This is a reference data field. Please use /v1/utilities/referenceData/{cardStatus} resource to get possible values of this field with descriptions  # noqa: E501

        :param card_status: The card_status of this RetrieveCreditChargeCardCorporateCardsDetailResponse.  # noqa: E501
        :type: str
        """

        self._card_status = card_status

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
        if issubclass(RetrieveCreditChargeCardCorporateCardsDetailResponse, dict):
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
        if not isinstance(other, RetrieveCreditChargeCardCorporateCardsDetailResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
