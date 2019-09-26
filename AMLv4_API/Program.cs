using AMLv4_API.Aml_v4_API;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLv4_API
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Authentication

            string integratorId = "1168CD5D-4DE4-41C9-9CCF-1E9BE9BF0D1E";

            AuthenticationRequest authRequest = new AuthenticationRequest()
            {
                CustomerID = "InfoTrack Test Customer 001",
                IntegratorID = integratorId,
                UserID = "InfoTrack Test Id 001"
            };

            AuthenticationResponse authenticationResponse = RequestPerformer.RequestPerformer.PerformRequest<AuthenticationResponse>(authRequest, "/auth", "additional reference", 0);


            #endregion Authentication

            #region Register Customer

            //RegisterCustomerRequest registerCustomerRequest = new RegisterCustomerRequest()
            //{
            //    CustData = new CustData()
            //    {
            //        ContactEmail = "joao.fernandes@infotrack.co.uk",
            //        ContactForename = "Joao",
            //        ContactSurname = "Fernandes",
            //        ContactPosition = "Developer",
            //        ContactTitle = "Mr",
            //        CustomerAccess = CustomerAccess.Transactional,
            //        CustomerAddress = "91 Waterloo Road SE1 8RT",
            //        CustomerIcoNumber = "1234567789",
            //        CustomerName = "InfoTrack",
            //        MlroContactEmail = "mlro@infotrack.co.uk",
            //        MlroContactName = "Mr Mlro at InfoTRack",
            //        MlroContactPosition = "Mlro Position at InfoTrack",
            //        OrgType = OrgType.Other,
            //        Telephone = "83920380921",
            //        TermsAccepted = TermsAccepted.Yes
            //    },
            //    Uri = authenticationResponse.uri
            //};

            //RegisterCustomerResponse registerCustomerResponse = RequestPerformer.RequestPerformer.PerformRequest<RegisterCustomerResponse>(registerCustomerRequest, "/register/customer", "additional reference", 0);


            #endregion Register Customer

            #region Customer Terms

            //CustomerTermsRequest customerTermsRequest = new CustomerTermsRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    ContactEmail = "joao.fernandes@infotrack.co.uk",
            //    ContactForename = "Joao",
            //    ContactPosition = "Overworked Developer",
            //    ContactSurname = "Fernandes",
            //    ContactTitle = "Mr",
            //    CustomerAddress = "91 Waterloo Road",
            //    CustomerName = "InfoTrack"
            //};

            //CustomerTermsResponse customerTermsResponse = RequestPerformer.RequestPerformer.PerformRequest<CustomerTermsResponse>(customerTermsRequest, "/register/terms", "additional reference", 0);

            //if (customerTermsResponse.Error == "no")
            //{
            //    File.WriteAllBytes(@"C:\CustomerTerms.pdf", Convert.FromBase64String(customerTermsResponse.TermsBinary));
            //}

            #endregion Customer Terms

            #region Adopt Profiles

            //AdoptProfilesRequest adoptProfileRequest = new AdoptProfilesRequest()
            //{
            //    Uri = authenticationResponse.uri
            //};

            //AdoptProfilesResponse adoptProfilesResponse = RequestPerformer.RequestPerformer.PerformRequest<AdoptProfilesResponse>(adoptProfileRequest, "/register/adoptprofiles", "additional reference", 0);

            #endregion Adopt Profiles

            //#region Add User to Registered Customer

            //AddUserToRegisteredCustomerRequest addUserToRegisteredCustomerRequest = new AddUserToRegisteredCustomerRequest()
            //{
            //    AmlCustomerID = authenticationResponse.AmlCustomerID,
            //    uri = authenticationResponse.uri,
            //    ContactEmail = "joao.fernandes@infotrack.co.uk",
            //    ContactForename = "Joao",
            //    ContactSurname = "Fernandes",
            //    ServicesAvailable = ServicesAvailable.MO,
            //    UserLoginID = "jpafernandes" + DateTime.Now.Ticks,
            //    UserType = UserType.admin.ToString()
            //};

            //AddUserToRegisteredCustomerResponse addUserToRegisteredCustomerResponse = RequestPerformer.RequestPerformer.PerformRequest<AddUserToRegisteredCustomerResponse>(addUserToRegisteredCustomerRequest, "/user/add", "additional reference", 0);

            //#endregion Add User to Registered Customer

            //#region Check Customer Terms Version

            //CheckCustomerTermsVersionRequest checkCustomerTermsVersionRequest = new CheckCustomerTermsVersionRequest()
            //{
            //    IncludeBinary = IncludeBinary.yes.ToString(),
            //    uri = authenticationResponse.uri,
            //    ViewingNewVersion = IncludeBinary.yes.ToString()
            //};

            //CheckCustomerTermsVersionResponse checkCustomerTermsVersionResponse = RequestPerformer.RequestPerformer.PerformRequest<CheckCustomerTermsVersionResponse>(addUserToRegisteredCustomerRequest, "/terms/view", "additional reference", 0);


            //#endregion Check Customer Terms Version

            //#region Accept New Customer Terms Version

            //AcceptNewCustomerTermsVersionRequest acceptNewCustomerTermsVersionRequest = new AcceptNewCustomerTermsVersionRequest()
            //{
            //    uri = authenticationResponse.uri
            //};

            //AcceptNewCustomerTermsVersionResponse acceptNewCustomerTermsVersionResponse = RequestPerformer.RequestPerformer.PerformRequest<AcceptNewCustomerTermsVersionResponse>(addUserToRegisteredCustomerRequest, "/terms/accept", "additional reference", 0);

            //#endregion Accept New Customer Terms Version

            //#region Migration List - Request

            //MigrationListRequest migrationListRequest = new MigrationListRequest()
            //{
            //    IntegratorID = integratorId
            //};

            //MigrationListResponse migrationListResponse = RequestPerformer.RequestPerformer.PerformRequest<MigrationListResponse>(migrationListRequest, "/migration/list", "additional reference", 0);

            //#endregion Migration List - Request

            //#region Migration Customer and User details - Request

            //MigrationCustomerAndUserDetailsRequest migrationCustomerAndUserDetailsRequest = new MigrationCustomerAndUserDetailsRequest()
            //{
            //    CustomerID = "360 Business Law",
            //    IntegratorID = integratorId,
            //    UserID = "AML Provider"
            //};

            //MigrationCustomerAndUserDetailsResponse migrationListResponse = RequestPerformer.RequestPerformer.PerformRequest<MigrationCustomerAndUserDetailsResponse>(migrationCustomerAndUserDetailsRequest, "/migration/run", "additional reference", 0);

            //#endregion Migration Customer and User details - Request


            //#region Select Risk Profile / CDD - Request

            //SelectRiskProfileCddRequest selectRiskProfileCddRequest = new SelectRiskProfileCddRequest()
            //{
            //    interview_value = InterviewValue.home.ToString(),
            //    nationality_value = "UK",
            //    ProfileOverride = ProfileOverride.empty.ToString(),
            //    profiletype = Profiletype.personal.ToString(),
            //    relationship_value = RelationshipValue.existing,
            //    residency_value = "UK",
            //    uri = authenticationResponse.uri,
            //};

            //SelectRiskProfileCddResponse selectRiskProfileCddResponse = RequestPerformer.RequestPerformer.PerformRequest<SelectRiskProfileCddResponse>(selectRiskProfileCddRequest, "/riskprofile/lookup", "additional reference", 0);

            //#endregion Select Risk Profile / CDD - Request


            //#region Personal Risk Assessment, Client Data - Request

            //PersonalRiskAssessmentClientDataRequest personalRiskAssessmentClientDataRequest = new PersonalRiskAssessmentClientDataRequest()
            //{
            //    AssessmentType = AssessmentType.simplified.ToString(),
            //    clienttype = Clienttype.personal.ToString(),
            //    compliance = Compliance.yes.ToString(),
            //    CountryCode = "UK",
            //    CurrentAddressFlatFloor = "11",
            //    CurrentAddressHouseNameNumber = "Capital Tower",
            //    CurrentAddressLocality = "London",
            //    CurrentAddressPostcode = "SE1 8RT",
            //    CurrentAddressState = "London",
            //    CurrentAddressStreet = "Waterloo Road",
            //    CurrentAddressTown = "London",
            //    DateMoved = "2019-01-01",
            //    DOB = "1987-06-09",
            //    Email = "joao.fernandes@infotrack.co.uk",
            //    Forename = "Joao",
            //    Gender = Gender.Male.ToString(),
            //    Interview = Interview.person.ToString(),
            //    Nationality = "UK",
            //    OtherNames = "Pedro",
            //    Phone = "3829013802",
            //    PreviousAddress = Previous.no.ToString(),
            //    PreviousAddressFlatFloor = "",
            //    PreviousAddressHouseNameNumber = "",
            //    PreviousAddressLocality = "",
            //    PreviousAddressPostcode = "",
            //    PreviousAddressState = "",
            //    PreviousAddressStreet = "",
            //    PreviousAddressTown = "",
            //    PreviousCountryCode = "",
            //    PreviousForename = "",
            //    PreviousName = Previous.no.ToString(),
            //    PreviousOtherNames = "",
            //    PreviousSuffix = "",
            //    PreviousSurname = "",
            //    PreviousTitle = "",
            //    Relationship = RelationshipValue.existing,
            //    Residency = "UK",
            //    RiskProfile = "4097",
            //    SSN = "N/A",
            //    Suffix = "N/A",
            //    Surname = "Fernandes",
            //    Title = "mr",
            //    uri = authenticationResponse.uri
            //};

            //PersonalRiskAssessmentClientDataResponse personalRiskAssessmentClientDataResponse = RequestPerformer.RequestPerformer.PerformRequest<PersonalRiskAssessmentClientDataResponse>(personalRiskAssessmentClientDataRequest, "/client/personal/add", "additional reference", 0);


            //#endregion Personal Risk Assessment, Client Data - Request



            //#region Personal Risk Assessment, Update Client Data - Request

            //PersonalRiskAssessmentUpdateClientDataRequest personalRiskAssessmentUpdateClientDataRequest = new PersonalRiskAssessmentUpdateClientDataRequest()
            //{
            //    AssessmentType = AssessmentType.simplified.ToString(),
            //    clienttype = Clienttype.personal.ToString(),
            //    compliance = Compliance.yes.ToString(),
            //    CountryCode = "UK",
            //    CurrentAddressFlatFloor = "11",
            //    CurrentAddressHouseNameNumber = "Capital Tower",
            //    CurrentAddressLocality = "London",
            //    CurrentAddressPostcode = "SE1 8RT",
            //    CurrentAddressState = "London",
            //    CurrentAddressStreet = "Waterloo Road",
            //    CurrentAddressTown = "London",
            //    DateMoved = "2019-01-01",
            //    DOB = "1987-06-09",
            //    Email = "joao.fernandes@infotrack.co.uk",
            //    Forename = "Joao",
            //    Gender = Gender.Male.ToString(),
            //    Interview = Interview.person.ToString(),
            //    Nationality = "UK",
            //    OtherNames = "Pedro",
            //    Phone = "3829013802",
            //    PreviousAddress = Previous.no.ToString(),
            //    PreviousAddressFlatFloor = "",
            //    PreviousAddressHouseNameNumber = "",
            //    PreviousAddressLocality = "",
            //    PreviousAddressPostcode = "",
            //    PreviousAddressState = "",
            //    PreviousAddressStreet = "",
            //    PreviousAddressTown = "",
            //    PreviousCountryCode = "",
            //    PreviousForename = "",
            //    PreviousName = Previous.no.ToString(),
            //    PreviousOtherNames = "",
            //    PreviousSuffix = "",
            //    PreviousSurname = "",
            //    PreviousTitle = "",
            //    Relationship = RelationshipValue.existing,
            //    Residency = "UK",
            //    RiskProfile = "4097",
            //    SSN = "N/A",
            //    Suffix = "N/A",
            //    Surname = "Fernandes",
            //    Title = "mr",
            //    uri = authenticationResponse.uri,
            //    ClientID = "12345"
            //};

            //PersonalRiskAssessmentUpdateClientDataResponse personalRiskAssessmentUpdateClientDataResponse = RequestPerformer.RequestPerformer.PerformRequest<PersonalRiskAssessmentUpdateClientDataResponse>(personalRiskAssessmentUpdateClientDataRequest, "/client/personal/update", "additional reference", 0);


            //#endregion Personal Risk Assessment, Update Client Data - Request


        }
    }
}
