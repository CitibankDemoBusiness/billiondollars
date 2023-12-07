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

class ApplicationInquiryContactConsent(object):
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
        'ok_to_call': 'bool',
        'ok_to_mail': 'bool',
        'ok_to_sms': 'bool'
    }

    attribute_map = {
        'ok_to_call': 'okToCall',
        'ok_to_mail': 'okToMail',
        'ok_to_sms': 'okToSms'
    }

    def __init__(self, ok_to_call=None, ok_to_mail=None, ok_to_sms=None):  # noqa: E501
        """ApplicationInquiryContactConsent - a model defined in Swagger"""  # noqa: E501
        self._ok_to_call = None
        self._ok_to_mail = None
        self._ok_to_sms = None
        self.discriminator = None
        if ok_to_call is not None:
            self.ok_to_call = ok_to_call
        if ok_to_mail is not None:
            self.ok_to_mail = ok_to_mail
        if ok_to_sms is not None:
            self.ok_to_sms = ok_to_sms

    @property
    def ok_to_call(self):
        """Gets the ok_to_call of this ApplicationInquiryContactConsent.  # noqa: E501

        Applicant's consent for receiving phone calls. Valid values: true and false  # noqa: E501

        :return: The ok_to_call of this ApplicationInquiryContactConsent.  # noqa: E501
        :rtype: bool
        """
        return self._ok_to_call

    @ok_to_call.setter
    def ok_to_call(self, ok_to_call):
        """Sets the ok_to_call of this ApplicationInquiryContactConsent.

        Applicant's consent for receiving phone calls. Valid values: true and false  # noqa: E501

        :param ok_to_call: The ok_to_call of this ApplicationInquiryContactConsent.  # noqa: E501
        :type: bool
        """

        self._ok_to_call = ok_to_call

    @property
    def ok_to_mail(self):
        """Gets the ok_to_mail of this ApplicationInquiryContactConsent.  # noqa: E501

        Applicant's consent for receiving mails. Valid values: true and false  # noqa: E501

        :return: The ok_to_mail of this ApplicationInquiryContactConsent.  # noqa: E501
        :rtype: bool
        """
        return self._ok_to_mail

    @ok_to_mail.setter
    def ok_to_mail(self, ok_to_mail):
        """Sets the ok_to_mail of this ApplicationInquiryContactConsent.

        Applicant's consent for receiving mails. Valid values: true and false  # noqa: E501

        :param ok_to_mail: The ok_to_mail of this ApplicationInquiryContactConsent.  # noqa: E501
        :type: bool
        """

        self._ok_to_mail = ok_to_mail

    @property
    def ok_to_sms(self):
        """Gets the ok_to_sms of this ApplicationInquiryContactConsent.  # noqa: E501

        Applicant's consent for receiving sms. Valid values: true and false  # noqa: E501

        :return: The ok_to_sms of this ApplicationInquiryContactConsent.  # noqa: E501
        :rtype: bool
        """
        return self._ok_to_sms

    @ok_to_sms.setter
    def ok_to_sms(self, ok_to_sms):
        """Sets the ok_to_sms of this ApplicationInquiryContactConsent.

        Applicant's consent for receiving sms. Valid values: true and false  # noqa: E501

        :param ok_to_sms: The ok_to_sms of this ApplicationInquiryContactConsent.  # noqa: E501
        :type: bool
        """

        self._ok_to_sms = ok_to_sms

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
        if issubclass(ApplicationInquiryContactConsent, dict):
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
        if not isinstance(other, ApplicationInquiryContactConsent):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
