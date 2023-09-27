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

class HistoryAndIntradayTransactions(object):
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
        'next_start_index': 'str',
        'more_indicator': 'str',
        'number_of_transactions': 'int',
        'history_and_intraday_transaction_records': 'list[HistoryAndIntradayTransactionRecords]'
    }

    attribute_map = {
        'next_start_index': 'nextStartIndex',
        'more_indicator': 'moreIndicator',
        'number_of_transactions': 'numberOfTransactions',
        'history_and_intraday_transaction_records': 'historyAndIntradayTransactionRecords'
    }

    def __init__(self, next_start_index=None, more_indicator=None, number_of_transactions=None, history_and_intraday_transaction_records=None):  # noqa: E501
        """HistoryAndIntradayTransactions - a model defined in Swagger"""  # noqa: E501
        self._next_start_index = None
        self._more_indicator = None
        self._number_of_transactions = None
        self._history_and_intraday_transaction_records = None
        self.discriminator = None
        if next_start_index is not None:
            self.next_start_index = next_start_index
        if more_indicator is not None:
            self.more_indicator = more_indicator
        if number_of_transactions is not None:
            self.number_of_transactions = number_of_transactions
        if history_and_intraday_transaction_records is not None:
            self.history_and_intraday_transaction_records = history_and_intraday_transaction_records

    @property
    def next_start_index(self):
        """Gets the next_start_index of this HistoryAndIntradayTransactions.  # noqa: E501

        For pagination - the starting index for retrieving the next page/batch of records.  # noqa: E501

        :return: The next_start_index of this HistoryAndIntradayTransactions.  # noqa: E501
        :rtype: str
        """
        return self._next_start_index

    @next_start_index.setter
    def next_start_index(self, next_start_index):
        """Sets the next_start_index of this HistoryAndIntradayTransactions.

        For pagination - the starting index for retrieving the next page/batch of records.  # noqa: E501

        :param next_start_index: The next_start_index of this HistoryAndIntradayTransactions.  # noqa: E501
        :type: str
        """

        self._next_start_index = next_start_index

    @property
    def more_indicator(self):
        """Gets the more_indicator of this HistoryAndIntradayTransactions.  # noqa: E501

        This field indicates that more records are available for retrieval.  # noqa: E501

        :return: The more_indicator of this HistoryAndIntradayTransactions.  # noqa: E501
        :rtype: str
        """
        return self._more_indicator

    @more_indicator.setter
    def more_indicator(self, more_indicator):
        """Sets the more_indicator of this HistoryAndIntradayTransactions.

        This field indicates that more records are available for retrieval.  # noqa: E501

        :param more_indicator: The more_indicator of this HistoryAndIntradayTransactions.  # noqa: E501
        :type: str
        """

        self._more_indicator = more_indicator

    @property
    def number_of_transactions(self):
        """Gets the number_of_transactions of this HistoryAndIntradayTransactions.  # noqa: E501

        Number of Transactions  # noqa: E501

        :return: The number_of_transactions of this HistoryAndIntradayTransactions.  # noqa: E501
        :rtype: int
        """
        return self._number_of_transactions

    @number_of_transactions.setter
    def number_of_transactions(self, number_of_transactions):
        """Sets the number_of_transactions of this HistoryAndIntradayTransactions.

        Number of Transactions  # noqa: E501

        :param number_of_transactions: The number_of_transactions of this HistoryAndIntradayTransactions.  # noqa: E501
        :type: int
        """

        self._number_of_transactions = number_of_transactions

    @property
    def history_and_intraday_transaction_records(self):
        """Gets the history_and_intraday_transaction_records of this HistoryAndIntradayTransactions.  # noqa: E501


        :return: The history_and_intraday_transaction_records of this HistoryAndIntradayTransactions.  # noqa: E501
        :rtype: list[HistoryAndIntradayTransactionRecords]
        """
        return self._history_and_intraday_transaction_records

    @history_and_intraday_transaction_records.setter
    def history_and_intraday_transaction_records(self, history_and_intraday_transaction_records):
        """Sets the history_and_intraday_transaction_records of this HistoryAndIntradayTransactions.


        :param history_and_intraday_transaction_records: The history_and_intraday_transaction_records of this HistoryAndIntradayTransactions.  # noqa: E501
        :type: list[HistoryAndIntradayTransactionRecords]
        """

        self._history_and_intraday_transaction_records = history_and_intraday_transaction_records

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
        if issubclass(HistoryAndIntradayTransactions, dict):
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
        if not isinstance(other, HistoryAndIntradayTransactions):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
