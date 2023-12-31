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

class DisbursementOption(object):
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
        'disbursement_option': 'str',
        'address': 'Address',
        'external_bank_details': 'ExternalBankDetails',
        'personal_account_details': 'list[PersonalAccountDetails]',
        'payee_account_details': 'list[PayeeAccountDetails]'
    }

    attribute_map = {
        'disbursement_option': 'disbursementOption',
        'address': 'address',
        'external_bank_details': 'externalBankDetails',
        'personal_account_details': 'personalAccountDetails',
        'payee_account_details': 'payeeAccountDetails'
    }

    def __init__(self, disbursement_option=None, address=None, external_bank_details=None, personal_account_details=None, payee_account_details=None):  # noqa: E501
        """DisbursementOption - a model defined in Swagger"""  # noqa: E501
        self._disbursement_option = None
        self._address = None
        self._external_bank_details = None
        self._personal_account_details = None
        self._payee_account_details = None
        self.discriminator = None
        self.disbursement_option = disbursement_option
        if address is not None:
            self.address = address
        if external_bank_details is not None:
            self.external_bank_details = external_bank_details
        if personal_account_details is not None:
            self.personal_account_details = personal_account_details
        if payee_account_details is not None:
            self.payee_account_details = payee_account_details

    @property
    def disbursement_option(self):
        """Gets the disbursement_option of this DisbursementOption.  # noqa: E501

        Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.  # noqa: E501

        :return: The disbursement_option of this DisbursementOption.  # noqa: E501
        :rtype: str
        """
        return self._disbursement_option

    @disbursement_option.setter
    def disbursement_option(self, disbursement_option):
        """Sets the disbursement_option of this DisbursementOption.

        Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.  # noqa: E501

        :param disbursement_option: The disbursement_option of this DisbursementOption.  # noqa: E501
        :type: str
        """
        if disbursement_option is None:
            raise ValueError("Invalid value for `disbursement_option`, must not be `None`")  # noqa: E501

        self._disbursement_option = disbursement_option

    @property
    def address(self):
        """Gets the address of this DisbursementOption.  # noqa: E501


        :return: The address of this DisbursementOption.  # noqa: E501
        :rtype: Address
        """
        return self._address

    @address.setter
    def address(self, address):
        """Sets the address of this DisbursementOption.


        :param address: The address of this DisbursementOption.  # noqa: E501
        :type: Address
        """

        self._address = address

    @property
    def external_bank_details(self):
        """Gets the external_bank_details of this DisbursementOption.  # noqa: E501


        :return: The external_bank_details of this DisbursementOption.  # noqa: E501
        :rtype: ExternalBankDetails
        """
        return self._external_bank_details

    @external_bank_details.setter
    def external_bank_details(self, external_bank_details):
        """Sets the external_bank_details of this DisbursementOption.


        :param external_bank_details: The external_bank_details of this DisbursementOption.  # noqa: E501
        :type: ExternalBankDetails
        """

        self._external_bank_details = external_bank_details

    @property
    def personal_account_details(self):
        """Gets the personal_account_details of this DisbursementOption.  # noqa: E501


        :return: The personal_account_details of this DisbursementOption.  # noqa: E501
        :rtype: list[PersonalAccountDetails]
        """
        return self._personal_account_details

    @personal_account_details.setter
    def personal_account_details(self, personal_account_details):
        """Sets the personal_account_details of this DisbursementOption.


        :param personal_account_details: The personal_account_details of this DisbursementOption.  # noqa: E501
        :type: list[PersonalAccountDetails]
        """

        self._personal_account_details = personal_account_details

    @property
    def payee_account_details(self):
        """Gets the payee_account_details of this DisbursementOption.  # noqa: E501


        :return: The payee_account_details of this DisbursementOption.  # noqa: E501
        :rtype: list[PayeeAccountDetails]
        """
        return self._payee_account_details

    @payee_account_details.setter
    def payee_account_details(self, payee_account_details):
        """Sets the payee_account_details of this DisbursementOption.


        :param payee_account_details: The payee_account_details of this DisbursementOption.  # noqa: E501
        :type: list[PayeeAccountDetails]
        """

        self._payee_account_details = payee_account_details

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
        if issubclass(DisbursementOption, dict):
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
        if not isinstance(other, DisbursementOption):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
