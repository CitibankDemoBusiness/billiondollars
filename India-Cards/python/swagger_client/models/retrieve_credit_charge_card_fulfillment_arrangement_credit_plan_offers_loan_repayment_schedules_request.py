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

class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest(object):
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
        'loan_amount': 'float',
        'tenor': 'int',
        'next_start_index': 'str',
        'binary_data': 'BinaryData'
    }

    attribute_map = {
        'loan_amount': 'loanAmount',
        'tenor': 'tenor',
        'next_start_index': 'nextStartIndex',
        'binary_data': 'binaryData'
    }

    def __init__(self, loan_amount=None, tenor=None, next_start_index=None, binary_data=None):  # noqa: E501
        """RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest - a model defined in Swagger"""  # noqa: E501
        self._loan_amount = None
        self._tenor = None
        self._next_start_index = None
        self._binary_data = None
        self.discriminator = None
        self.loan_amount = loan_amount
        self.tenor = tenor
        if next_start_index is not None:
            self.next_start_index = next_start_index
        if binary_data is not None:
            self.binary_data = binary_data

    @property
    def loan_amount(self):
        """Gets the loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501

        Loan amount for easy payment plan booking.  # noqa: E501

        :return: The loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501
        :rtype: float
        """
        return self._loan_amount

    @loan_amount.setter
    def loan_amount(self, loan_amount):
        """Sets the loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.

        Loan amount for easy payment plan booking.  # noqa: E501

        :param loan_amount: The loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501
        :type: float
        """
        if loan_amount is None:
            raise ValueError("Invalid value for `loan_amount`, must not be `None`")  # noqa: E501

        self._loan_amount = loan_amount

    @property
    def tenor(self):
        """Gets the tenor of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501

        Tenure of loan.  # noqa: E501

        :return: The tenor of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501
        :rtype: int
        """
        return self._tenor

    @tenor.setter
    def tenor(self, tenor):
        """Sets the tenor of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.

        Tenure of loan.  # noqa: E501

        :param tenor: The tenor of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501
        :type: int
        """
        if tenor is None:
            raise ValueError("Invalid value for `tenor`, must not be `None`")  # noqa: E501

        self._tenor = tenor

    @property
    def next_start_index(self):
        """Gets the next_start_index of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501

        In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.  # noqa: E501

        :return: The next_start_index of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501
        :rtype: str
        """
        return self._next_start_index

    @next_start_index.setter
    def next_start_index(self, next_start_index):
        """Sets the next_start_index of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.

        In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.  # noqa: E501

        :param next_start_index: The next_start_index of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501
        :type: str
        """

        self._next_start_index = next_start_index

    @property
    def binary_data(self):
        """Gets the binary_data of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501


        :return: The binary_data of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501
        :rtype: BinaryData
        """
        return self._binary_data

    @binary_data.setter
    def binary_data(self, binary_data):
        """Sets the binary_data of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.


        :param binary_data: The binary_data of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest.  # noqa: E501
        :type: BinaryData
        """

        self._binary_data = binary_data

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
        if issubclass(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest, dict):
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
        if not isinstance(other, RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
