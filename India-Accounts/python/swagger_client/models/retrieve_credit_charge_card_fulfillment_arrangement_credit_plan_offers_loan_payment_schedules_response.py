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

class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse(object):
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
        'list_response': 'ListResponse',
        'org_code': 'str',
        'loan_amortization_schedule': 'list[LoanPaymentSchedule]',
        'loan_summary': 'LoanSummary'
    }

    attribute_map = {
        'list_response': 'listResponse',
        'org_code': 'orgCode',
        'loan_amortization_schedule': 'loanAmortizationSchedule',
        'loan_summary': 'loanSummary'
    }

    def __init__(self, list_response=None, org_code=None, loan_amortization_schedule=None, loan_summary=None):  # noqa: E501
        """RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse - a model defined in Swagger"""  # noqa: E501
        self._list_response = None
        self._org_code = None
        self._loan_amortization_schedule = None
        self._loan_summary = None
        self.discriminator = None
        if list_response is not None:
            self.list_response = list_response
        if org_code is not None:
            self.org_code = org_code
        if loan_amortization_schedule is not None:
            self.loan_amortization_schedule = loan_amortization_schedule
        if loan_summary is not None:
            self.loan_summary = loan_summary

    @property
    def list_response(self):
        """Gets the list_response of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501


        :return: The list_response of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501
        :rtype: ListResponse
        """
        return self._list_response

    @list_response.setter
    def list_response(self, list_response):
        """Sets the list_response of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.


        :param list_response: The list_response of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501
        :type: ListResponse
        """

        self._list_response = list_response

    @property
    def org_code(self):
        """Gets the org_code of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501

        Organization of the card  # noqa: E501

        :return: The org_code of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501
        :rtype: str
        """
        return self._org_code

    @org_code.setter
    def org_code(self, org_code):
        """Sets the org_code of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.

        Organization of the card  # noqa: E501

        :param org_code: The org_code of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501
        :type: str
        """

        self._org_code = org_code

    @property
    def loan_amortization_schedule(self):
        """Gets the loan_amortization_schedule of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501


        :return: The loan_amortization_schedule of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501
        :rtype: list[LoanPaymentSchedule]
        """
        return self._loan_amortization_schedule

    @loan_amortization_schedule.setter
    def loan_amortization_schedule(self, loan_amortization_schedule):
        """Sets the loan_amortization_schedule of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.


        :param loan_amortization_schedule: The loan_amortization_schedule of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501
        :type: list[LoanPaymentSchedule]
        """

        self._loan_amortization_schedule = loan_amortization_schedule

    @property
    def loan_summary(self):
        """Gets the loan_summary of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501


        :return: The loan_summary of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501
        :rtype: LoanSummary
        """
        return self._loan_summary

    @loan_summary.setter
    def loan_summary(self, loan_summary):
        """Sets the loan_summary of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.


        :param loan_summary: The loan_summary of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse.  # noqa: E501
        :type: LoanSummary
        """

        self._loan_summary = loan_summary

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
        if issubclass(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse, dict):
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
        if not isinstance(other, RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other