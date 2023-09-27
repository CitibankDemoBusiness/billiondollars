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

class Statement(object):
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
        'epp_minimum_eligible_amount': 'float',
        'epp_maximum_eligible_amount': 'float',
        'statement_date': 'date',
        'statement_balance_amount': 'float'
    }

    attribute_map = {
        'epp_minimum_eligible_amount': 'eppMinimumEligibleAmount',
        'epp_maximum_eligible_amount': 'eppMaximumEligibleAmount',
        'statement_date': 'statementDate',
        'statement_balance_amount': 'statementBalanceAmount'
    }

    def __init__(self, epp_minimum_eligible_amount=None, epp_maximum_eligible_amount=None, statement_date=None, statement_balance_amount=None):  # noqa: E501
        """Statement - a model defined in Swagger"""  # noqa: E501
        self._epp_minimum_eligible_amount = None
        self._epp_maximum_eligible_amount = None
        self._statement_date = None
        self._statement_balance_amount = None
        self.discriminator = None
        self.epp_minimum_eligible_amount = epp_minimum_eligible_amount
        self.epp_maximum_eligible_amount = epp_maximum_eligible_amount
        self.statement_date = statement_date
        self.statement_balance_amount = statement_balance_amount

    @property
    def epp_minimum_eligible_amount(self):
        """Gets the epp_minimum_eligible_amount of this Statement.  # noqa: E501

        Minimum eligible amount for which Equal Payment Plan can be booked.  # noqa: E501

        :return: The epp_minimum_eligible_amount of this Statement.  # noqa: E501
        :rtype: float
        """
        return self._epp_minimum_eligible_amount

    @epp_minimum_eligible_amount.setter
    def epp_minimum_eligible_amount(self, epp_minimum_eligible_amount):
        """Sets the epp_minimum_eligible_amount of this Statement.

        Minimum eligible amount for which Equal Payment Plan can be booked.  # noqa: E501

        :param epp_minimum_eligible_amount: The epp_minimum_eligible_amount of this Statement.  # noqa: E501
        :type: float
        """
        if epp_minimum_eligible_amount is None:
            raise ValueError("Invalid value for `epp_minimum_eligible_amount`, must not be `None`")  # noqa: E501

        self._epp_minimum_eligible_amount = epp_minimum_eligible_amount

    @property
    def epp_maximum_eligible_amount(self):
        """Gets the epp_maximum_eligible_amount of this Statement.  # noqa: E501

        Maximum eligible amount for which Equal Payment Plan can be booked.  # noqa: E501

        :return: The epp_maximum_eligible_amount of this Statement.  # noqa: E501
        :rtype: float
        """
        return self._epp_maximum_eligible_amount

    @epp_maximum_eligible_amount.setter
    def epp_maximum_eligible_amount(self, epp_maximum_eligible_amount):
        """Sets the epp_maximum_eligible_amount of this Statement.

        Maximum eligible amount for which Equal Payment Plan can be booked.  # noqa: E501

        :param epp_maximum_eligible_amount: The epp_maximum_eligible_amount of this Statement.  # noqa: E501
        :type: float
        """
        if epp_maximum_eligible_amount is None:
            raise ValueError("Invalid value for `epp_maximum_eligible_amount`, must not be `None`")  # noqa: E501

        self._epp_maximum_eligible_amount = epp_maximum_eligible_amount

    @property
    def statement_date(self):
        """Gets the statement_date of this Statement.  # noqa: E501

        Date on which the account statement has been generated in ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :return: The statement_date of this Statement.  # noqa: E501
        :rtype: date
        """
        return self._statement_date

    @statement_date.setter
    def statement_date(self, statement_date):
        """Sets the statement_date of this Statement.

        Date on which the account statement has been generated in ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :param statement_date: The statement_date of this Statement.  # noqa: E501
        :type: date
        """
        if statement_date is None:
            raise ValueError("Invalid value for `statement_date`, must not be `None`")  # noqa: E501

        self._statement_date = statement_date

    @property
    def statement_balance_amount(self):
        """Gets the statement_balance_amount of this Statement.  # noqa: E501

        Statement balance amount on the statement date  # noqa: E501

        :return: The statement_balance_amount of this Statement.  # noqa: E501
        :rtype: float
        """
        return self._statement_balance_amount

    @statement_balance_amount.setter
    def statement_balance_amount(self, statement_balance_amount):
        """Sets the statement_balance_amount of this Statement.

        Statement balance amount on the statement date  # noqa: E501

        :param statement_balance_amount: The statement_balance_amount of this Statement.  # noqa: E501
        :type: float
        """
        if statement_balance_amount is None:
            raise ValueError("Invalid value for `statement_balance_amount`, must not be `None`")  # noqa: E501

        self._statement_balance_amount = statement_balance_amount

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
        if issubclass(Statement, dict):
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
        if not isinstance(other, Statement):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
