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

class ApplicantUpdateCreditCardProduct(object):
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
        'emboss_name': 'str',
        'requested_credit_limit': 'float',
        'overseas_card_activation_flag': 'bool'
    }

    attribute_map = {
        'emboss_name': 'embossName',
        'requested_credit_limit': 'requestedCreditLimit',
        'overseas_card_activation_flag': 'overseasCardActivationFlag'
    }

    def __init__(self, emboss_name=None, requested_credit_limit=None, overseas_card_activation_flag=None):  # noqa: E501
        """ApplicantUpdateCreditCardProduct - a model defined in Swagger"""  # noqa: E501
        self._emboss_name = None
        self._requested_credit_limit = None
        self._overseas_card_activation_flag = None
        self.discriminator = None
        if emboss_name is not None:
            self.emboss_name = emboss_name
        if requested_credit_limit is not None:
            self.requested_credit_limit = requested_credit_limit
        if overseas_card_activation_flag is not None:
            self.overseas_card_activation_flag = overseas_card_activation_flag

    @property
    def emboss_name(self):
        """Gets the emboss_name of this ApplicantUpdateCreditCardProduct.  # noqa: E501

        Name to be embossed on card.  # noqa: E501

        :return: The emboss_name of this ApplicantUpdateCreditCardProduct.  # noqa: E501
        :rtype: str
        """
        return self._emboss_name

    @emboss_name.setter
    def emboss_name(self, emboss_name):
        """Sets the emboss_name of this ApplicantUpdateCreditCardProduct.

        Name to be embossed on card.  # noqa: E501

        :param emboss_name: The emboss_name of this ApplicantUpdateCreditCardProduct.  # noqa: E501
        :type: str
        """

        self._emboss_name = emboss_name

    @property
    def requested_credit_limit(self):
        """Gets the requested_credit_limit of this ApplicantUpdateCreditCardProduct.  # noqa: E501

        Credit limit accepted by applicant  # noqa: E501

        :return: The requested_credit_limit of this ApplicantUpdateCreditCardProduct.  # noqa: E501
        :rtype: float
        """
        return self._requested_credit_limit

    @requested_credit_limit.setter
    def requested_credit_limit(self, requested_credit_limit):
        """Sets the requested_credit_limit of this ApplicantUpdateCreditCardProduct.

        Credit limit accepted by applicant  # noqa: E501

        :param requested_credit_limit: The requested_credit_limit of this ApplicantUpdateCreditCardProduct.  # noqa: E501
        :type: float
        """

        self._requested_credit_limit = requested_credit_limit

    @property
    def overseas_card_activation_flag(self):
        """Gets the overseas_card_activation_flag of this ApplicantUpdateCreditCardProduct.  # noqa: E501

        Flag to activate the card for overseas usage.Valid values: true and false  # noqa: E501

        :return: The overseas_card_activation_flag of this ApplicantUpdateCreditCardProduct.  # noqa: E501
        :rtype: bool
        """
        return self._overseas_card_activation_flag

    @overseas_card_activation_flag.setter
    def overseas_card_activation_flag(self, overseas_card_activation_flag):
        """Sets the overseas_card_activation_flag of this ApplicantUpdateCreditCardProduct.

        Flag to activate the card for overseas usage.Valid values: true and false  # noqa: E501

        :param overseas_card_activation_flag: The overseas_card_activation_flag of this ApplicantUpdateCreditCardProduct.  # noqa: E501
        :type: bool
        """

        self._overseas_card_activation_flag = overseas_card_activation_flag

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
        if issubclass(ApplicantUpdateCreditCardProduct, dict):
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
        if not isinstance(other, ApplicantUpdateCreditCardProduct):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
