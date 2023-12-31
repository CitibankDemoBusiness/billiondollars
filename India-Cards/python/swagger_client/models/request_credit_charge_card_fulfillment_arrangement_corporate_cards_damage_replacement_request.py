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

class RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest(object):
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
        'tokenized_card_number': 'str',
        'corporate_officer_details': 'CorporateOfficerDetails',
        'embossed_name': 'str',
        'replacement_reason_code': 'str'
    }

    attribute_map = {
        'tokenized_card_number': 'tokenizedCardNumber',
        'corporate_officer_details': 'corporateOfficerDetails',
        'embossed_name': 'embossedName',
        'replacement_reason_code': 'replacementReasonCode'
    }

    def __init__(self, tokenized_card_number=None, corporate_officer_details=None, embossed_name=None, replacement_reason_code=None):  # noqa: E501
        """RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest - a model defined in Swagger"""  # noqa: E501
        self._tokenized_card_number = None
        self._corporate_officer_details = None
        self._embossed_name = None
        self._replacement_reason_code = None
        self.discriminator = None
        self.tokenized_card_number = tokenized_card_number
        if corporate_officer_details is not None:
            self.corporate_officer_details = corporate_officer_details
        if embossed_name is not None:
            self.embossed_name = embossed_name
        if replacement_reason_code is not None:
            self.replacement_reason_code = replacement_reason_code

    @property
    def tokenized_card_number(self):
        """Gets the tokenized_card_number of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501

        Tokenized card number  # noqa: E501

        :return: The tokenized_card_number of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501
        :rtype: str
        """
        return self._tokenized_card_number

    @tokenized_card_number.setter
    def tokenized_card_number(self, tokenized_card_number):
        """Sets the tokenized_card_number of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.

        Tokenized card number  # noqa: E501

        :param tokenized_card_number: The tokenized_card_number of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501
        :type: str
        """
        if tokenized_card_number is None:
            raise ValueError("Invalid value for `tokenized_card_number`, must not be `None`")  # noqa: E501

        self._tokenized_card_number = tokenized_card_number

    @property
    def corporate_officer_details(self):
        """Gets the corporate_officer_details of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501


        :return: The corporate_officer_details of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501
        :rtype: CorporateOfficerDetails
        """
        return self._corporate_officer_details

    @corporate_officer_details.setter
    def corporate_officer_details(self, corporate_officer_details):
        """Sets the corporate_officer_details of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.


        :param corporate_officer_details: The corporate_officer_details of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501
        :type: CorporateOfficerDetails
        """

        self._corporate_officer_details = corporate_officer_details

    @property
    def embossed_name(self):
        """Gets the embossed_name of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501

        Customer Name embossed on the card  # noqa: E501

        :return: The embossed_name of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501
        :rtype: str
        """
        return self._embossed_name

    @embossed_name.setter
    def embossed_name(self, embossed_name):
        """Sets the embossed_name of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.

        Customer Name embossed on the card  # noqa: E501

        :param embossed_name: The embossed_name of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501
        :type: str
        """

        self._embossed_name = embossed_name

    @property
    def replacement_reason_code(self):
        """Gets the replacement_reason_code of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501

        Reason code for replacement. This is a reference data field. Please use /v1/utilities/referenceData/{replacementReasonCode} resource to get possible values of this field with descriptions  # noqa: E501

        :return: The replacement_reason_code of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501
        :rtype: str
        """
        return self._replacement_reason_code

    @replacement_reason_code.setter
    def replacement_reason_code(self, replacement_reason_code):
        """Sets the replacement_reason_code of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.

        Reason code for replacement. This is a reference data field. Please use /v1/utilities/referenceData/{replacementReasonCode} resource to get possible values of this field with descriptions  # noqa: E501

        :param replacement_reason_code: The replacement_reason_code of this RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.  # noqa: E501
        :type: str
        """

        self._replacement_reason_code = replacement_reason_code

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
        if issubclass(RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest, dict):
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
        if not isinstance(other, RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
