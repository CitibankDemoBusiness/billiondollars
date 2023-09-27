# coding: utf-8

"""
    Cards

    The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.cards_api import CARDSApi  # noqa: E501
from swagger_client.rest import ApiException


class TestCARDSApi(unittest.TestCase):
    """CARDSApi unit test stubs"""

    def setUp(self):
        self.api = CARDSApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_notify_credit_charge_card_fulfillment_arrangement_authorised_transaction(self):
        """Test case for notify_credit_charge_card_fulfillment_arrangement_authorised_transaction

        This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
