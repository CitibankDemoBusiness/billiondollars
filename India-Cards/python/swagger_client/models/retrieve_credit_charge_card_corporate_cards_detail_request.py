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

class RetrieveCreditChargeCardCorporateCardsDetailRequest(object):
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
        'corporate_officer_details': 'CorporateOfficerDetails'
    }

    attribute_map = {
        'tokenized_card_number': 'tokenizedCardNumber',
        'corporate_officer_details': 'corporateOfficerDetails'
    }

    def __init__(self, tokenized_card_number=None, corporate_officer_details=None):  # noqa: E501
        """RetrieveCreditChargeCardCorporateCardsDetailRequest - a model defined in Swagger"""  # noqa: E501
        self._tokenized_card_number = None
        self._corporate_officer_details = None
        self.discriminator = None
        self.tokenized_card_number = tokenized_card_number
        if corporate_officer_details is not None:
            self.corporate_officer_details = corporate_officer_details

    @property
    def tokenized_card_number(self):
        """Gets the tokenized_card_number of this RetrieveCreditChargeCardCorporateCardsDetailRequest.  # noqa: E501

        Tokenized card number  # noqa: E501

        :return: The tokenized_card_number of this RetrieveCreditChargeCardCorporateCardsDetailRequest.  # noqa: E501
        :rtype: str
        """
        return self._tokenized_card_number

    @tokenized_card_number.setter
    def tokenized_card_number(self, tokenized_card_number):
        """Sets the tokenized_card_number of this RetrieveCreditChargeCardCorporateCardsDetailRequest.

        Tokenized card number  # noqa: E501

        :param tokenized_card_number: The tokenized_card_number of this RetrieveCreditChargeCardCorporateCardsDetailRequest.  # noqa: E501
        :type: str
        """
        if tokenized_card_number is None:
            raise ValueError("Invalid value for `tokenized_card_number`, must not be `None`")  # noqa: E501

        self._tokenized_card_number = tokenized_card_number

    @property
    def corporate_officer_details(self):
        """Gets the corporate_officer_details of this RetrieveCreditChargeCardCorporateCardsDetailRequest.  # noqa: E501


        :return: The corporate_officer_details of this RetrieveCreditChargeCardCorporateCardsDetailRequest.  # noqa: E501
        :rtype: CorporateOfficerDetails
        """
        return self._corporate_officer_details

    @corporate_officer_details.setter
    def corporate_officer_details(self, corporate_officer_details):
        """Sets the corporate_officer_details of this RetrieveCreditChargeCardCorporateCardsDetailRequest.


        :param corporate_officer_details: The corporate_officer_details of this RetrieveCreditChargeCardCorporateCardsDetailRequest.  # noqa: E501
        :type: CorporateOfficerDetails
        """

        self._corporate_officer_details = corporate_officer_details

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
        if issubclass(RetrieveCreditChargeCardCorporateCardsDetailRequest, dict):
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
        if not isinstance(other, RetrieveCreditChargeCardCorporateCardsDetailRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
