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

class AccountStatementListResponse(object):
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
        'statement_list': 'list[StatementList]',
        'next_start_index': 'str'
    }

    attribute_map = {
        'statement_list': 'statementList',
        'next_start_index': 'nextStartIndex'
    }

    def __init__(self, statement_list=None, next_start_index=None):  # noqa: E501
        """AccountStatementListResponse - a model defined in Swagger"""  # noqa: E501
        self._statement_list = None
        self._next_start_index = None
        self.discriminator = None
        if statement_list is not None:
            self.statement_list = statement_list
        if next_start_index is not None:
            self.next_start_index = next_start_index

    @property
    def statement_list(self):
        """Gets the statement_list of this AccountStatementListResponse.  # noqa: E501


        :return: The statement_list of this AccountStatementListResponse.  # noqa: E501
        :rtype: list[StatementList]
        """
        return self._statement_list

    @statement_list.setter
    def statement_list(self, statement_list):
        """Sets the statement_list of this AccountStatementListResponse.


        :param statement_list: The statement_list of this AccountStatementListResponse.  # noqa: E501
        :type: list[StatementList]
        """

        self._statement_list = statement_list

    @property
    def next_start_index(self):
        """Gets the next_start_index of this AccountStatementListResponse.  # noqa: E501

        The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.  # noqa: E501

        :return: The next_start_index of this AccountStatementListResponse.  # noqa: E501
        :rtype: str
        """
        return self._next_start_index

    @next_start_index.setter
    def next_start_index(self, next_start_index):
        """Sets the next_start_index of this AccountStatementListResponse.

        The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.  # noqa: E501

        :param next_start_index: The next_start_index of this AccountStatementListResponse.  # noqa: E501
        :type: str
        """

        self._next_start_index = next_start_index

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
        if issubclass(AccountStatementListResponse, dict):
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
        if not isinstance(other, AccountStatementListResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other