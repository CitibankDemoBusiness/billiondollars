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

class CardDetails(object):
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
        'card_id': 'str',
        'display_card_number': 'str',
        'local_card_activation_indicator': 'str',
        'overseas_card_activation_indicator': 'str',
        'perpetual_activation_flag': 'bool',
        'overseas_card_activation_start_date': 'date',
        'overseas_card_activation_end_date': 'date',
        'current_credit_limit_amount': 'float',
        'maximum_permanent_credit_limit_amount': 'float',
        'maximum_temporary_credit_limit_amount': 'float',
        'sub_card_type': 'str',
        'card_holder_type': 'str',
        'card_issue_reason': 'str',
        'card_functions_allowed': 'list[CardFunctionsAllowed]'
    }

    attribute_map = {
        'card_id': 'cardId',
        'display_card_number': 'displayCardNumber',
        'local_card_activation_indicator': 'localCardActivationIndicator',
        'overseas_card_activation_indicator': 'overseasCardActivationIndicator',
        'perpetual_activation_flag': 'perpetualActivationFlag',
        'overseas_card_activation_start_date': 'overseasCardActivationStartDate',
        'overseas_card_activation_end_date': 'overseasCardActivationEndDate',
        'current_credit_limit_amount': 'currentCreditLimitAmount',
        'maximum_permanent_credit_limit_amount': 'maximumPermanentCreditLimitAmount',
        'maximum_temporary_credit_limit_amount': 'maximumTemporaryCreditLimitAmount',
        'sub_card_type': 'subCardType',
        'card_holder_type': 'cardHolderType',
        'card_issue_reason': 'cardIssueReason',
        'card_functions_allowed': 'cardFunctionsAllowed'
    }

    def __init__(self, card_id=None, display_card_number=None, local_card_activation_indicator=None, overseas_card_activation_indicator=None, perpetual_activation_flag=None, overseas_card_activation_start_date=None, overseas_card_activation_end_date=None, current_credit_limit_amount=None, maximum_permanent_credit_limit_amount=None, maximum_temporary_credit_limit_amount=None, sub_card_type=None, card_holder_type=None, card_issue_reason=None, card_functions_allowed=None):  # noqa: E501
        """CardDetails - a model defined in Swagger"""  # noqa: E501
        self._card_id = None
        self._display_card_number = None
        self._local_card_activation_indicator = None
        self._overseas_card_activation_indicator = None
        self._perpetual_activation_flag = None
        self._overseas_card_activation_start_date = None
        self._overseas_card_activation_end_date = None
        self._current_credit_limit_amount = None
        self._maximum_permanent_credit_limit_amount = None
        self._maximum_temporary_credit_limit_amount = None
        self._sub_card_type = None
        self._card_holder_type = None
        self._card_issue_reason = None
        self._card_functions_allowed = None
        self.discriminator = None
        self.card_id = card_id
        if display_card_number is not None:
            self.display_card_number = display_card_number
        self.local_card_activation_indicator = local_card_activation_indicator
        if overseas_card_activation_indicator is not None:
            self.overseas_card_activation_indicator = overseas_card_activation_indicator
        if perpetual_activation_flag is not None:
            self.perpetual_activation_flag = perpetual_activation_flag
        if overseas_card_activation_start_date is not None:
            self.overseas_card_activation_start_date = overseas_card_activation_start_date
        if overseas_card_activation_end_date is not None:
            self.overseas_card_activation_end_date = overseas_card_activation_end_date
        self.current_credit_limit_amount = current_credit_limit_amount
        if maximum_permanent_credit_limit_amount is not None:
            self.maximum_permanent_credit_limit_amount = maximum_permanent_credit_limit_amount
        if maximum_temporary_credit_limit_amount is not None:
            self.maximum_temporary_credit_limit_amount = maximum_temporary_credit_limit_amount
        self.sub_card_type = sub_card_type
        if card_holder_type is not None:
            self.card_holder_type = card_holder_type
        if card_issue_reason is not None:
            self.card_issue_reason = card_issue_reason
        if card_functions_allowed is not None:
            self.card_functions_allowed = card_functions_allowed

    @property
    def card_id(self):
        """Gets the card_id of this CardDetails.  # noqa: E501

        The card id  in encrypted format  # noqa: E501

        :return: The card_id of this CardDetails.  # noqa: E501
        :rtype: str
        """
        return self._card_id

    @card_id.setter
    def card_id(self, card_id):
        """Sets the card_id of this CardDetails.

        The card id  in encrypted format  # noqa: E501

        :param card_id: The card_id of this CardDetails.  # noqa: E501
        :type: str
        """
        if card_id is None:
            raise ValueError("Invalid value for `card_id`, must not be `None`")  # noqa: E501

        self._card_id = card_id

    @property
    def display_card_number(self):
        """Gets the display_card_number of this CardDetails.  # noqa: E501

        A masked card number that can be displayed to the customer.  # noqa: E501

        :return: The display_card_number of this CardDetails.  # noqa: E501
        :rtype: str
        """
        return self._display_card_number

    @display_card_number.setter
    def display_card_number(self, display_card_number):
        """Sets the display_card_number of this CardDetails.

        A masked card number that can be displayed to the customer.  # noqa: E501

        :param display_card_number: The display_card_number of this CardDetails.  # noqa: E501
        :type: str
        """

        self._display_card_number = display_card_number

    @property
    def local_card_activation_indicator(self):
        """Gets the local_card_activation_indicator of this CardDetails.  # noqa: E501

        The card activation indicator for local usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{localCardActivationIndicator} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The local_card_activation_indicator of this CardDetails.  # noqa: E501
        :rtype: str
        """
        return self._local_card_activation_indicator

    @local_card_activation_indicator.setter
    def local_card_activation_indicator(self, local_card_activation_indicator):
        """Sets the local_card_activation_indicator of this CardDetails.

        The card activation indicator for local usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{localCardActivationIndicator} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param local_card_activation_indicator: The local_card_activation_indicator of this CardDetails.  # noqa: E501
        :type: str
        """
        if local_card_activation_indicator is None:
            raise ValueError("Invalid value for `local_card_activation_indicator`, must not be `None`")  # noqa: E501

        self._local_card_activation_indicator = local_card_activation_indicator

    @property
    def overseas_card_activation_indicator(self):
        """Gets the overseas_card_activation_indicator of this CardDetails.  # noqa: E501

        The card activation indicator for overseas usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardActivationIndicator} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The overseas_card_activation_indicator of this CardDetails.  # noqa: E501
        :rtype: str
        """
        return self._overseas_card_activation_indicator

    @overseas_card_activation_indicator.setter
    def overseas_card_activation_indicator(self, overseas_card_activation_indicator):
        """Sets the overseas_card_activation_indicator of this CardDetails.

        The card activation indicator for overseas usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardActivationIndicator} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param overseas_card_activation_indicator: The overseas_card_activation_indicator of this CardDetails.  # noqa: E501
        :type: str
        """

        self._overseas_card_activation_indicator = overseas_card_activation_indicator

    @property
    def perpetual_activation_flag(self):
        """Gets the perpetual_activation_flag of this CardDetails.  # noqa: E501

        Flag to specify whether the card is activated perpetually, till card expiration  # noqa: E501

        :return: The perpetual_activation_flag of this CardDetails.  # noqa: E501
        :rtype: bool
        """
        return self._perpetual_activation_flag

    @perpetual_activation_flag.setter
    def perpetual_activation_flag(self, perpetual_activation_flag):
        """Sets the perpetual_activation_flag of this CardDetails.

        Flag to specify whether the card is activated perpetually, till card expiration  # noqa: E501

        :param perpetual_activation_flag: The perpetual_activation_flag of this CardDetails.  # noqa: E501
        :type: bool
        """

        self._perpetual_activation_flag = perpetual_activation_flag

    @property
    def overseas_card_activation_start_date(self):
        """Gets the overseas_card_activation_start_date of this CardDetails.  # noqa: E501

        Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage.  # noqa: E501

        :return: The overseas_card_activation_start_date of this CardDetails.  # noqa: E501
        :rtype: date
        """
        return self._overseas_card_activation_start_date

    @overseas_card_activation_start_date.setter
    def overseas_card_activation_start_date(self, overseas_card_activation_start_date):
        """Sets the overseas_card_activation_start_date of this CardDetails.

        Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage.  # noqa: E501

        :param overseas_card_activation_start_date: The overseas_card_activation_start_date of this CardDetails.  # noqa: E501
        :type: date
        """

        self._overseas_card_activation_start_date = overseas_card_activation_start_date

    @property
    def overseas_card_activation_end_date(self):
        """Gets the overseas_card_activation_end_date of this CardDetails.  # noqa: E501

        Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, value is card expiry date  # noqa: E501

        :return: The overseas_card_activation_end_date of this CardDetails.  # noqa: E501
        :rtype: date
        """
        return self._overseas_card_activation_end_date

    @overseas_card_activation_end_date.setter
    def overseas_card_activation_end_date(self, overseas_card_activation_end_date):
        """Sets the overseas_card_activation_end_date of this CardDetails.

        Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, value is card expiry date  # noqa: E501

        :param overseas_card_activation_end_date: The overseas_card_activation_end_date of this CardDetails.  # noqa: E501
        :type: date
        """

        self._overseas_card_activation_end_date = overseas_card_activation_end_date

    @property
    def current_credit_limit_amount(self):
        """Gets the current_credit_limit_amount of this CardDetails.  # noqa: E501

        Current credit limit amount on the credit card  # noqa: E501

        :return: The current_credit_limit_amount of this CardDetails.  # noqa: E501
        :rtype: float
        """
        return self._current_credit_limit_amount

    @current_credit_limit_amount.setter
    def current_credit_limit_amount(self, current_credit_limit_amount):
        """Sets the current_credit_limit_amount of this CardDetails.

        Current credit limit amount on the credit card  # noqa: E501

        :param current_credit_limit_amount: The current_credit_limit_amount of this CardDetails.  # noqa: E501
        :type: float
        """
        if current_credit_limit_amount is None:
            raise ValueError("Invalid value for `current_credit_limit_amount`, must not be `None`")  # noqa: E501

        self._current_credit_limit_amount = current_credit_limit_amount

    @property
    def maximum_permanent_credit_limit_amount(self):
        """Gets the maximum_permanent_credit_limit_amount of this CardDetails.  # noqa: E501

        Maximum permanent credit limit amount allowed on the credit card  # noqa: E501

        :return: The maximum_permanent_credit_limit_amount of this CardDetails.  # noqa: E501
        :rtype: float
        """
        return self._maximum_permanent_credit_limit_amount

    @maximum_permanent_credit_limit_amount.setter
    def maximum_permanent_credit_limit_amount(self, maximum_permanent_credit_limit_amount):
        """Sets the maximum_permanent_credit_limit_amount of this CardDetails.

        Maximum permanent credit limit amount allowed on the credit card  # noqa: E501

        :param maximum_permanent_credit_limit_amount: The maximum_permanent_credit_limit_amount of this CardDetails.  # noqa: E501
        :type: float
        """

        self._maximum_permanent_credit_limit_amount = maximum_permanent_credit_limit_amount

    @property
    def maximum_temporary_credit_limit_amount(self):
        """Gets the maximum_temporary_credit_limit_amount of this CardDetails.  # noqa: E501

        Maximum temporary credit limit amount allowed on the credit card  # noqa: E501

        :return: The maximum_temporary_credit_limit_amount of this CardDetails.  # noqa: E501
        :rtype: float
        """
        return self._maximum_temporary_credit_limit_amount

    @maximum_temporary_credit_limit_amount.setter
    def maximum_temporary_credit_limit_amount(self, maximum_temporary_credit_limit_amount):
        """Sets the maximum_temporary_credit_limit_amount of this CardDetails.

        Maximum temporary credit limit amount allowed on the credit card  # noqa: E501

        :param maximum_temporary_credit_limit_amount: The maximum_temporary_credit_limit_amount of this CardDetails.  # noqa: E501
        :type: float
        """

        self._maximum_temporary_credit_limit_amount = maximum_temporary_credit_limit_amount

    @property
    def sub_card_type(self):
        """Gets the sub_card_type of this CardDetails.  # noqa: E501

        Type of the card. Debit or Credit.This is a reference data field. Please use /v1/apac/utilities/referenceData/{subCardType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The sub_card_type of this CardDetails.  # noqa: E501
        :rtype: str
        """
        return self._sub_card_type

    @sub_card_type.setter
    def sub_card_type(self, sub_card_type):
        """Sets the sub_card_type of this CardDetails.

        Type of the card. Debit or Credit.This is a reference data field. Please use /v1/apac/utilities/referenceData/{subCardType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param sub_card_type: The sub_card_type of this CardDetails.  # noqa: E501
        :type: str
        """
        if sub_card_type is None:
            raise ValueError("Invalid value for `sub_card_type`, must not be `None`")  # noqa: E501

        self._sub_card_type = sub_card_type

    @property
    def card_holder_type(self):
        """Gets the card_holder_type of this CardDetails.  # noqa: E501

        Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description.  # noqa: E501

        :return: The card_holder_type of this CardDetails.  # noqa: E501
        :rtype: str
        """
        return self._card_holder_type

    @card_holder_type.setter
    def card_holder_type(self, card_holder_type):
        """Sets the card_holder_type of this CardDetails.

        Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description.  # noqa: E501

        :param card_holder_type: The card_holder_type of this CardDetails.  # noqa: E501
        :type: str
        """

        self._card_holder_type = card_holder_type

    @property
    def card_issue_reason(self):
        """Gets the card_issue_reason of this CardDetails.  # noqa: E501

        Specifies the reason for the card issuance. Applicable only for recently issued cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssueReason} resource to get valid value of this field with description.  # noqa: E501

        :return: The card_issue_reason of this CardDetails.  # noqa: E501
        :rtype: str
        """
        return self._card_issue_reason

    @card_issue_reason.setter
    def card_issue_reason(self, card_issue_reason):
        """Sets the card_issue_reason of this CardDetails.

        Specifies the reason for the card issuance. Applicable only for recently issued cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssueReason} resource to get valid value of this field with description.  # noqa: E501

        :param card_issue_reason: The card_issue_reason of this CardDetails.  # noqa: E501
        :type: str
        """

        self._card_issue_reason = card_issue_reason

    @property
    def card_functions_allowed(self):
        """Gets the card_functions_allowed of this CardDetails.  # noqa: E501


        :return: The card_functions_allowed of this CardDetails.  # noqa: E501
        :rtype: list[CardFunctionsAllowed]
        """
        return self._card_functions_allowed

    @card_functions_allowed.setter
    def card_functions_allowed(self, card_functions_allowed):
        """Sets the card_functions_allowed of this CardDetails.


        :param card_functions_allowed: The card_functions_allowed of this CardDetails.  # noqa: E501
        :type: list[CardFunctionsAllowed]
        """

        self._card_functions_allowed = card_functions_allowed

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
        if issubclass(CardDetails, dict):
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
        if not isinstance(other, CardDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
