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

class ExistingCustomerCreditProductApplicationAddRequest(object):
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
        'product': 'ECMProduct',
        'applicant': 'ECMApplicant',
        'sales_agent_details': 'SalesAgentDetails',
        'marketing_campaign_offer_details': 'MarketingCampaignOfferDetails',
        'sub_card_type': 'str',
        'display_card_number': 'str',
        'control_flow_id': 'str'
    }

    attribute_map = {
        'product': 'product',
        'applicant': 'applicant',
        'sales_agent_details': 'salesAgentDetails',
        'marketing_campaign_offer_details': 'marketingCampaignOfferDetails',
        'sub_card_type': 'subCardType',
        'display_card_number': 'displayCardNumber',
        'control_flow_id': 'controlFlowId'
    }

    def __init__(self, product=None, applicant=None, sales_agent_details=None, marketing_campaign_offer_details=None, sub_card_type=None, display_card_number=None, control_flow_id=None):  # noqa: E501
        """ExistingCustomerCreditProductApplicationAddRequest - a model defined in Swagger"""  # noqa: E501
        self._product = None
        self._applicant = None
        self._sales_agent_details = None
        self._marketing_campaign_offer_details = None
        self._sub_card_type = None
        self._display_card_number = None
        self._control_flow_id = None
        self.discriminator = None
        if product is not None:
            self.product = product
        if applicant is not None:
            self.applicant = applicant
        if sales_agent_details is not None:
            self.sales_agent_details = sales_agent_details
        if marketing_campaign_offer_details is not None:
            self.marketing_campaign_offer_details = marketing_campaign_offer_details
        if sub_card_type is not None:
            self.sub_card_type = sub_card_type
        if display_card_number is not None:
            self.display_card_number = display_card_number
        self.control_flow_id = control_flow_id

    @property
    def product(self):
        """Gets the product of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501


        :return: The product of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :rtype: ECMProduct
        """
        return self._product

    @product.setter
    def product(self, product):
        """Sets the product of this ExistingCustomerCreditProductApplicationAddRequest.


        :param product: The product of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :type: ECMProduct
        """

        self._product = product

    @property
    def applicant(self):
        """Gets the applicant of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501


        :return: The applicant of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :rtype: ECMApplicant
        """
        return self._applicant

    @applicant.setter
    def applicant(self, applicant):
        """Sets the applicant of this ExistingCustomerCreditProductApplicationAddRequest.


        :param applicant: The applicant of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :type: ECMApplicant
        """

        self._applicant = applicant

    @property
    def sales_agent_details(self):
        """Gets the sales_agent_details of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501


        :return: The sales_agent_details of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :rtype: SalesAgentDetails
        """
        return self._sales_agent_details

    @sales_agent_details.setter
    def sales_agent_details(self, sales_agent_details):
        """Sets the sales_agent_details of this ExistingCustomerCreditProductApplicationAddRequest.


        :param sales_agent_details: The sales_agent_details of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :type: SalesAgentDetails
        """

        self._sales_agent_details = sales_agent_details

    @property
    def marketing_campaign_offer_details(self):
        """Gets the marketing_campaign_offer_details of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501


        :return: The marketing_campaign_offer_details of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :rtype: MarketingCampaignOfferDetails
        """
        return self._marketing_campaign_offer_details

    @marketing_campaign_offer_details.setter
    def marketing_campaign_offer_details(self, marketing_campaign_offer_details):
        """Sets the marketing_campaign_offer_details of this ExistingCustomerCreditProductApplicationAddRequest.


        :param marketing_campaign_offer_details: The marketing_campaign_offer_details of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :type: MarketingCampaignOfferDetails
        """

        self._marketing_campaign_offer_details = marketing_campaign_offer_details

    @property
    def sub_card_type(self):
        """Gets the sub_card_type of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501

        Type of existing card of customer.  # noqa: E501

        :return: The sub_card_type of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :rtype: str
        """
        return self._sub_card_type

    @sub_card_type.setter
    def sub_card_type(self, sub_card_type):
        """Sets the sub_card_type of this ExistingCustomerCreditProductApplicationAddRequest.

        Type of existing card of customer.  # noqa: E501

        :param sub_card_type: The sub_card_type of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :type: str
        """

        self._sub_card_type = sub_card_type

    @property
    def display_card_number(self):
        """Gets the display_card_number of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501

        Last 4 digits of card number  # noqa: E501

        :return: The display_card_number of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :rtype: str
        """
        return self._display_card_number

    @display_card_number.setter
    def display_card_number(self, display_card_number):
        """Sets the display_card_number of this ExistingCustomerCreditProductApplicationAddRequest.

        Last 4 digits of card number  # noqa: E501

        :param display_card_number: The display_card_number of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :type: str
        """

        self._display_card_number = display_card_number

    @property
    def control_flow_id(self):
        """Gets the control_flow_id of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501

        Control Flow Id  # noqa: E501

        :return: The control_flow_id of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :rtype: str
        """
        return self._control_flow_id

    @control_flow_id.setter
    def control_flow_id(self, control_flow_id):
        """Sets the control_flow_id of this ExistingCustomerCreditProductApplicationAddRequest.

        Control Flow Id  # noqa: E501

        :param control_flow_id: The control_flow_id of this ExistingCustomerCreditProductApplicationAddRequest.  # noqa: E501
        :type: str
        """
        if control_flow_id is None:
            raise ValueError("Invalid value for `control_flow_id`, must not be `None`")  # noqa: E501

        self._control_flow_id = control_flow_id

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
        if issubclass(ExistingCustomerCreditProductApplicationAddRequest, dict):
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
        if not isinstance(other, ExistingCustomerCreditProductApplicationAddRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other