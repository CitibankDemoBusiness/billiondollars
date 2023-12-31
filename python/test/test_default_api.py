# coding: utf-8

"""
    Onboarding

    The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.default_api import DefaultApi  # noqa: E501
from swagger_client.rest import ApiException


class TestDefaultApi(unittest.TestCase):
    """DefaultApi unit test stubs"""

    def setUp(self):
        self.api = DefaultApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_v1_apac_onboarding_applications_application_id_documents_post(self):
        """Test case for v1_apac_onboarding_applications_application_id_documents_post

        Upload Application Documents  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_delete_put

        Supp Applicant Delete  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_applicants_applicant_id_put

        Supp Applicant Update  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_applicants_get

        Supp Applicant Inquiry  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_applicants_post

        Supp Applicant Add  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_background_screening_post

        Screen Unsecured Credit Application  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_get(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_get

        Application Inquiry  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_in_principle_approvals_post

        Request Credit Application Decision  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_offer_acceptance_post

        Accept Cross Sell Products  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_put(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_put

        Update Unsecured Credit Application  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_status_get(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_status_get

        Check Application Status  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_application_id_submission_post(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_application_id_submission_post

        Submit Application  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_products_unsecured_applications_post(self):
        """Test case for v1_apac_onboarding_products_unsecured_applications_post

        Create Unsecured Credit Application  # noqa: E501
        """
        pass

    def test_v1_apac_onboarding_prospects_post(self):
        """Test case for v1_apac_onboarding_prospects_post

        Submit Prospect  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
