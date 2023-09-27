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

class UtilityBillDetails(object):
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
        'utility_code': 'str',
        'telephone_indicator': 'str',
        'telecom_operator_name': 'str',
        'phone_billing_cycle_day': 'str'
    }

    attribute_map = {
        'utility_code': 'utilityCode',
        'telephone_indicator': 'telephoneIndicator',
        'telecom_operator_name': 'telecomOperatorName',
        'phone_billing_cycle_day': 'phoneBillingCycleDay'
    }

    def __init__(self, utility_code=None, telephone_indicator=None, telecom_operator_name=None, phone_billing_cycle_day=None):  # noqa: E501
        """UtilityBillDetails - a model defined in Swagger"""  # noqa: E501
        self._utility_code = None
        self._telephone_indicator = None
        self._telecom_operator_name = None
        self._phone_billing_cycle_day = None
        self.discriminator = None
        if utility_code is not None:
            self.utility_code = utility_code
        if telephone_indicator is not None:
            self.telephone_indicator = telephone_indicator
        if telecom_operator_name is not None:
            self.telecom_operator_name = telecom_operator_name
        if phone_billing_cycle_day is not None:
            self.phone_billing_cycle_day = phone_billing_cycle_day

    @property
    def utility_code(self):
        """Gets the utility_code of this UtilityBillDetails.  # noqa: E501

        Utility service provider codes. Please use /v1/utilities/referenceData/{utilityCode} resource to get valid value of this field with description. You can use utilityCode as the referenceCode parameter to retrieve the values  # noqa: E501

        :return: The utility_code of this UtilityBillDetails.  # noqa: E501
        :rtype: str
        """
        return self._utility_code

    @utility_code.setter
    def utility_code(self, utility_code):
        """Sets the utility_code of this UtilityBillDetails.

        Utility service provider codes. Please use /v1/utilities/referenceData/{utilityCode} resource to get valid value of this field with description. You can use utilityCode as the referenceCode parameter to retrieve the values  # noqa: E501

        :param utility_code: The utility_code of this UtilityBillDetails.  # noqa: E501
        :type: str
        """

        self._utility_code = utility_code

    @property
    def telephone_indicator(self):
        """Gets the telephone_indicator of this UtilityBillDetails.  # noqa: E501

        Type of the telephone to be enrolled for bill payment.Please use /v1/utilities/referenceData/{telephoneIndicator} resource to get valid value of this field with description.  # noqa: E501

        :return: The telephone_indicator of this UtilityBillDetails.  # noqa: E501
        :rtype: str
        """
        return self._telephone_indicator

    @telephone_indicator.setter
    def telephone_indicator(self, telephone_indicator):
        """Sets the telephone_indicator of this UtilityBillDetails.

        Type of the telephone to be enrolled for bill payment.Please use /v1/utilities/referenceData/{telephoneIndicator} resource to get valid value of this field with description.  # noqa: E501

        :param telephone_indicator: The telephone_indicator of this UtilityBillDetails.  # noqa: E501
        :type: str
        """

        self._telephone_indicator = telephone_indicator

    @property
    def telecom_operator_name(self):
        """Gets the telecom_operator_name of this UtilityBillDetails.  # noqa: E501

        Telecom operator name.  # noqa: E501

        :return: The telecom_operator_name of this UtilityBillDetails.  # noqa: E501
        :rtype: str
        """
        return self._telecom_operator_name

    @telecom_operator_name.setter
    def telecom_operator_name(self, telecom_operator_name):
        """Sets the telecom_operator_name of this UtilityBillDetails.

        Telecom operator name.  # noqa: E501

        :param telecom_operator_name: The telecom_operator_name of this UtilityBillDetails.  # noqa: E501
        :type: str
        """

        self._telecom_operator_name = telecom_operator_name

    @property
    def phone_billing_cycle_day(self):
        """Gets the phone_billing_cycle_day of this UtilityBillDetails.  # noqa: E501

        Day of each month for the phone bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{phoneBillingCycleDay} resource to get valid value of this field with description.  # noqa: E501

        :return: The phone_billing_cycle_day of this UtilityBillDetails.  # noqa: E501
        :rtype: str
        """
        return self._phone_billing_cycle_day

    @phone_billing_cycle_day.setter
    def phone_billing_cycle_day(self, phone_billing_cycle_day):
        """Sets the phone_billing_cycle_day of this UtilityBillDetails.

        Day of each month for the phone bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{phoneBillingCycleDay} resource to get valid value of this field with description.  # noqa: E501

        :param phone_billing_cycle_day: The phone_billing_cycle_day of this UtilityBillDetails.  # noqa: E501
        :type: str
        """

        self._phone_billing_cycle_day = phone_billing_cycle_day

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
        if issubclass(UtilityBillDetails, dict):
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
        if not isinstance(other, UtilityBillDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
