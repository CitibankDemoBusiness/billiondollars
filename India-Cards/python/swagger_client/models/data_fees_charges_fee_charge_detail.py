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

class DataFeesChargesFeeChargeDetail(object):
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
        'item': 'str',
        'chargeable': 'bool',
        'amount': 'float',
        'amount_currency_code': 'str',
        'percentage': 'float',
        'remark': 'str'
    }

    attribute_map = {
        'item': 'item',
        'chargeable': 'chargeable',
        'amount': 'amount',
        'amount_currency_code': 'amount_currency_code',
        'percentage': 'percentage',
        'remark': 'remark'
    }

    def __init__(self, item=None, chargeable=None, amount=None, amount_currency_code='MYR', percentage=None, remark=None):  # noqa: E501
        """DataFeesChargesFeeChargeDetail - a model defined in Swagger"""  # noqa: E501
        self._item = None
        self._chargeable = None
        self._amount = None
        self._amount_currency_code = None
        self._percentage = None
        self._remark = None
        self.discriminator = None
        self.item = item
        if chargeable is not None:
            self.chargeable = chargeable
        if amount is not None:
            self.amount = amount
        if amount_currency_code is not None:
            self.amount_currency_code = amount_currency_code
        if percentage is not None:
            self.percentage = percentage
        if remark is not None:
            self.remark = remark

    @property
    def item(self):
        """Gets the item of this DataFeesChargesFeeChargeDetail.  # noqa: E501


        :return: The item of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :rtype: str
        """
        return self._item

    @item.setter
    def item(self, item):
        """Sets the item of this DataFeesChargesFeeChargeDetail.


        :param item: The item of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :type: str
        """
        if item is None:
            raise ValueError("Invalid value for `item`, must not be `None`")  # noqa: E501
        allowed_values = ["actual_monthly_management", "annual", "atm_withdrawal", "card_replacement", "cash_advance", "cash_withdrawal", "early_settlement", "finance_charge_cash_advance", "finance_charge_retail", "fixed_monthly_management", "late_payment", "minimum_monthly_payment", "others", "oversea_transaction", "oversea_transaction_conversion", "sales_draft_retrieval_copy", "service_tax", "starter_pack", "statement_copy"]  # noqa: E501
        if item not in allowed_values:
            raise ValueError(
                "Invalid value for `item` ({0}), must be one of {1}"  # noqa: E501
                .format(item, allowed_values)
            )

        self._item = item

    @property
    def chargeable(self):
        """Gets the chargeable of this DataFeesChargesFeeChargeDetail.  # noqa: E501

        Indicator of chargeability  # noqa: E501

        :return: The chargeable of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :rtype: bool
        """
        return self._chargeable

    @chargeable.setter
    def chargeable(self, chargeable):
        """Sets the chargeable of this DataFeesChargesFeeChargeDetail.

        Indicator of chargeability  # noqa: E501

        :param chargeable: The chargeable of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :type: bool
        """

        self._chargeable = chargeable

    @property
    def amount(self):
        """Gets the amount of this DataFeesChargesFeeChargeDetail.  # noqa: E501

        Amount for fee and charge up to two digits decimal  # noqa: E501

        :return: The amount of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :rtype: float
        """
        return self._amount

    @amount.setter
    def amount(self, amount):
        """Sets the amount of this DataFeesChargesFeeChargeDetail.

        Amount for fee and charge up to two digits decimal  # noqa: E501

        :param amount: The amount of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :type: float
        """

        self._amount = amount

    @property
    def amount_currency_code(self):
        """Gets the amount_currency_code of this DataFeesChargesFeeChargeDetail.  # noqa: E501

        ISO-4217 3 characters currency code for fee and charge amount  # noqa: E501

        :return: The amount_currency_code of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :rtype: str
        """
        return self._amount_currency_code

    @amount_currency_code.setter
    def amount_currency_code(self, amount_currency_code):
        """Sets the amount_currency_code of this DataFeesChargesFeeChargeDetail.

        ISO-4217 3 characters currency code for fee and charge amount  # noqa: E501

        :param amount_currency_code: The amount_currency_code of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :type: str
        """

        self._amount_currency_code = amount_currency_code

    @property
    def percentage(self):
        """Gets the percentage of this DataFeesChargesFeeChargeDetail.  # noqa: E501

        Percentage of amount for fee and charge up to two digits decimal  # noqa: E501

        :return: The percentage of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :rtype: float
        """
        return self._percentage

    @percentage.setter
    def percentage(self, percentage):
        """Sets the percentage of this DataFeesChargesFeeChargeDetail.

        Percentage of amount for fee and charge up to two digits decimal  # noqa: E501

        :param percentage: The percentage of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :type: float
        """

        self._percentage = percentage

    @property
    def remark(self):
        """Gets the remark of this DataFeesChargesFeeChargeDetail.  # noqa: E501

        Additional notes for the fee and charge  # noqa: E501

        :return: The remark of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :rtype: str
        """
        return self._remark

    @remark.setter
    def remark(self, remark):
        """Sets the remark of this DataFeesChargesFeeChargeDetail.

        Additional notes for the fee and charge  # noqa: E501

        :param remark: The remark of this DataFeesChargesFeeChargeDetail.  # noqa: E501
        :type: str
        """

        self._remark = remark

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
        if issubclass(DataFeesChargesFeeChargeDetail, dict):
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
        if not isinstance(other, DataFeesChargesFeeChargeDetail):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
