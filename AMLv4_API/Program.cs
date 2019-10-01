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

            #region Add User to Registered Customer

            //AddUserToRegisteredCustomerRequest addUserToRegisteredCustomerRequest = new AddUserToRegisteredCustomerRequest()
            //{
            //    AmlCustomerId = authenticationResponse.AmlCustomerID,
            //    Uri = authenticationResponse.uri,
            //    ContactEmail = "joao.fernandes@infotrack.co.uk",
            //    ContactForename = "Joao",
            //    ContactSurname = "Fernandes",
            //    ServicesAvailable = ServicesAvailable.Mo,
            //    UserLoginId = "jpafernandes" + DateTime.Now.Ticks,
            //    UserType = UserType.Admin
            //};

            //AddUserToRegisteredCustomerResponse addUserToRegisteredCustomerResponse = RequestPerformer.RequestPerformer.PerformRequest<AddUserToRegisteredCustomerResponse>(addUserToRegisteredCustomerRequest, "/user/add", "additional reference", 0);

            #endregion Add User to Registered Customer

            #region Check Customer Terms Version

            //CheckCustomerTermsVersionRequest checkCustomerTermsVersionRequest = new CheckCustomerTermsVersionRequest()
            //{
            //    IncludeBinary = IncludeBinary.Yes,
            //    Uri = authenticationResponse.uri,
            //    ViewingNewVersion = IncludeBinary.Yes
            //};

            //CheckCustomerTermsVersionResponse checkCustomerTermsVersionResponse = RequestPerformer.RequestPerformer.PerformRequest<CheckCustomerTermsVersionResponse>(checkCustomerTermsVersionRequest, "/terms/view", "additional reference", 0);


            #endregion Check Customer Terms Version

            #region Accept New Customer Terms Version

            //AcceptNewCustomerTermsVersionRequest acceptNewCustomerTermsVersionRequest = new AcceptNewCustomerTermsVersionRequest()
            //{
            //    Uri = authenticationResponse.uri
            //};

            //AcceptNewCustomerTermsVersionResponse acceptNewCustomerTermsVersionResponse = RequestPerformer.RequestPerformer.PerformRequest<AcceptNewCustomerTermsVersionResponse>(acceptNewCustomerTermsVersionRequest, "/terms/accept", "additional reference", 0);

            #endregion Accept New Customer Terms Version

            #region Migration List - Request

            //MigrationListRequest migrationListRequest = new MigrationListRequest()
            //{
            //    IntegratorId = integratorId
            //};

            //MigrationListResponse migrationListResponse = RequestPerformer.RequestPerformer.PerformRequest<MigrationListResponse>(migrationListRequest, "/migration/list", "additional reference", 0);

            #endregion Migration List - Request

            #region Migration Customer and User details - Request

            //MigrationCustomerAndUserDetailsRequest migrationCustomerAndUserDetailsRequest = new MigrationCustomerAndUserDetailsRequest()
            //{
            //    CustomerId = "360 Business Law",
            //    IntegratorId = integratorId,
            //    UserId = "AML Provider"
            //};

            //MigrationCustomerAndUserDetailsResponse migrationListResponse = RequestPerformer.RequestPerformer.PerformRequest<MigrationCustomerAndUserDetailsResponse>(migrationCustomerAndUserDetailsRequest, "/migration/run", "additional reference", 0);

            #endregion Migration Customer and User details - Request

            #region Select Risk Profile / CDD - Request

            //SelectRiskProfileCddRequest selectRiskProfileCddRequest = new SelectRiskProfileCddRequest()
            //{
            //    InterviewValue = InterviewValue.Home,
            //    NationalityValue = "UK",
            //    ProfileOverride = ProfileOverride.Empty,
            //    Profiletype = Profiletype.Personal,
            //    RelationshipValue = RelationshipValue.Existing,
            //    ResidencyValue = "UK",
            //    Uri = authenticationResponse.uri,
            //};

            //SelectRiskProfileCddResponse selectRiskProfileCddResponse = RequestPerformer.RequestPerformer.PerformRequest<SelectRiskProfileCddResponse>(selectRiskProfileCddRequest, "/riskprofile/lookup", "additional reference", 0);

            #endregion Select Risk Profile / CDD - Request

            #region Personal Risk Assessment, Client Data - Request

            //PersonalRiskAssessmentClientDataRequest personalRiskAssessmentClientDataRequest = new PersonalRiskAssessmentClientDataRequest()
            //{
            //    AssessmentType = AssessmentType.Simplified,
            //    Clienttype = Clienttype.Personal,
            //    Compliance = Compliance.Yes,
            //    CountryCode = "UK",
            //    CurrentAddressFlatFloor = "11",
            //    CurrentAddressHouseNameNumber = "Capital Tower",
            //    CurrentAddressLocality = "London",
            //    CurrentAddressPostcode = "SE1 8RT",
            //    CurrentAddressState = "London",
            //    CurrentAddressStreet = "Waterloo Road",
            //    CurrentAddressTown = "London",
            //    DateMoved = "2019-01-01",
            //    Dob = "1987-06-09",
            //    Email = "joao.fernandes@infotrack.co.uk",
            //    Forename = "Joao",
            //    Gender = Gender.Male,
            //    Interview = Interview.Person,
            //    Nationality = "UK",
            //    OtherNames = "Pedro",
            //    Phone = "3829013802",
            //    PreviousAddress = Previous.No,
            //    PreviousAddressFlatFloor = "",
            //    PreviousAddressHouseNameNumber = "",
            //    PreviousAddressLocality = "",
            //    PreviousAddressPostcode = "",
            //    PreviousAddressState = "",
            //    PreviousAddressStreet = "",
            //    PreviousAddressTown = "",
            //    PreviousCountryCode = "",
            //    PreviousForename = "",
            //    PreviousName = Previous.No,
            //    PreviousOtherNames = "",
            //    PreviousSuffix = "",
            //    PreviousSurname = "",
            //    PreviousTitle = "",
            //    Relationship = Relationship.Existing,
            //    Residency = "UK",
            //    RiskProfile = "4097",
            //    Ssn = "N/A",
            //    Suffix = "N/A",
            //    Surname = "Fernandes",
            //    Title = "mr",
            //    Uri = authenticationResponse.uri
            //};

            //PersonalRiskAssessmentClientDataResponse personalRiskAssessmentClientDataResponse = RequestPerformer.RequestPerformer.PerformRequest<PersonalRiskAssessmentClientDataResponse>(personalRiskAssessmentClientDataRequest, "/client/personal/add", "additional reference", 0);


            #endregion Personal Risk Assessment, Client Data - Request

            #region Personal Risk Assessment, Update Client Data - Request

            //PersonalRiskAssessmentUpdateClientDataRequest personalRiskAssessmentUpdateClientDataRequest = new PersonalRiskAssessmentUpdateClientDataRequest()
            //{
            //    AssessmentType = AssessmentType.Simplified,
            //    Clienttype = Clienttype.Personal,
            //    Compliance = Compliance.Yes,
            //    CountryCode = "UK",
            //    CurrentAddressFlatFloor = "11",
            //    CurrentAddressHouseNameNumber = "Capital Tower",
            //    CurrentAddressLocality = "London",
            //    CurrentAddressPostcode = "SE1 8RT",
            //    CurrentAddressState = "London",
            //    CurrentAddressStreet = "Waterloo Road",
            //    CurrentAddressTown = "London",
            //    DateMoved = "2019-01-01",
            //    Dob = "1987-06-09",
            //    Email = "joao.fernandes@infotrack.co.uk",
            //    Forename = "Joao",
            //    Gender = Gender.Male,
            //    Interview = Interview.Person,
            //    Nationality = "UK",
            //    OtherNames = "Pedro",
            //    Phone = "3829013802",
            //    PreviousAddress = Previous.No,
            //    PreviousAddressFlatFloor = "",
            //    PreviousAddressHouseNameNumber = "",
            //    PreviousAddressLocality = "",
            //    PreviousAddressPostcode = "",
            //    PreviousAddressState = "",
            //    PreviousAddressStreet = "",
            //    PreviousAddressTown = "",
            //    PreviousCountryCode = "",
            //    PreviousForename = "",
            //    PreviousName = Previous.No,
            //    PreviousOtherNames = "",
            //    PreviousSuffix = "",
            //    PreviousSurname = "",
            //    PreviousTitle = "",
            //    Relationship = Relationship.Existing,
            //    Residency = "UK",
            //    RiskProfile = "4097",
            //    Ssn = "N/A",
            //    Suffix = "N/A",
            //    Surname = "Fernandes",
            //    Title = "mr",
            //    Uri = authenticationResponse.uri,
            //    ClientId = "12345"
            //};

            //PersonalRiskAssessmentUpdateClientDataResponse personalRiskAssessmentUpdateClientDataResponse = RequestPerformer.RequestPerformer.PerformRequest<PersonalRiskAssessmentUpdateClientDataResponse>(personalRiskAssessmentUpdateClientDataRequest, "/client/personal/update", "additional reference", 0);


            #endregion Personal Risk Assessment, Update Client Data - Request

            #region Risk Assessment Document Types (Personal) 

            //var personalRiskAssessmentDocumentTypesRequest = new PersonalRiskAssessmentDocumentTypesRequest()
            //{
            //    ClientId = "12345",
            //    Uri = authenticationResponse.uri
            //};
            //PersonalRiskAssessmentDocumentTypesResponse personalRiskAssessmentUpdateClientDataResponse = RequestPerformer.RequestPerformer.PerformRequest<PersonalRiskAssessmentDocumentTypesResponse>(personalRiskAssessmentDocumentTypesRequest, "/document/types", "additional reference", 0); 
            #endregion

            #region Add Document to CDD Record
            //var addDocumentToCddRecordRequest = new AddDocumentToCddRecordRequest()
            //{
            //    ClientId = "12345",
            //    Uri = authenticationResponse.uri,
            //    Docref = "mydocref",
            //    Doctype = "mydoctype",
            //    Expirydate = DateTime.Now.ToShortDateString()
            //};
            //AddDocumentToCddRecordResponse addDocumentToCddRecordResponse = RequestPerformer.RequestPerformer.PerformRequest<AddDocumentToCddRecordResponse>(addDocumentToCddRecordRequest, "/document/add", "additional reference", 0);
            #endregion

            #region List Documents on CDD record or Assessment
            //var listDocumentsOnCddRecordOrAssessmentRequest = new ListDocumentsOnCddRecordOrAssessmentRequest()
            //{
            //    ClientId = "12345",
            //    Uri = authenticationResponse.uri
            //};
            //ListDocumentsOnCddRecordOrAssessmentResponse listDocumentsOnCddRecordOrAssessmentResponse = RequestPerformer.RequestPerformer.PerformRequest<ListDocumentsOnCddRecordOrAssessmentResponse>(listDocumentsOnCddRecordOrAssessmentRequest, "/document/list", "additional reference", 0);
            #endregion

            #region Use Document in assessment
            //var useDocumentInAssessmentRequest = new UseDocumentInAssessmentRequest()
            //{
            //    AssessmentId = "12345",
            //    Uri = authenticationResponse.uri,
            //    Docid = "12345"
            //};
            //UseDocumentInAssessmentResponse useDocumentInAssessmentResponse = RequestPerformer.RequestPerformer.PerformRequest<UseDocumentInAssessmentResponse>(useDocumentInAssessmentRequest, "/document/include", "additional reference", 0);
            #endregion

            #region View Document Details
            //var viewDocumentDetailsRequest = new ViewDocumentDetailsRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Docid = "12345"
            //};
            //ViewDocumentDetailsResponse viewDocumentDetailsResponse = RequestPerformer.RequestPerformer.PerformRequest<ViewDocumentDetailsResponse>(viewDocumentDetailsRequest, "/document/view", "additional reference", 0);
            #endregion

            #region Update Document Details
            //var updateDocumentDetailsRequest = new UpdateDocumentDetailsRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Docid = "12345",
            //    Docref = "12345",
            //    Doctype = "12345",
            //    Expirydate = DateTime.Now.ToShortDateString()
            //};
            //ViewDocumentDetailsResponse viewDocumentDetailsResponse = RequestPerformer.RequestPerformer.PerformRequest<ViewDocumentDetailsResponse>(updateDocumentDetailsRequest, "/document/update", "additional reference", 0);
            #endregion

            #region Delete Document Details
            //var deleteDocumentDetailsRequest = new DeleteDocumentDetailsRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Docid = "12345"
            //};
            //DeleteDocumentDetailsResponse deleteDocumentDetailsResponse = RequestPerformer.RequestPerformer.PerformRequest<DeleteDocumentDetailsResponse>(deleteDocumentDetailsRequest, "/document/delete", "additional reference", 0);
            #endregion

            #region Add Client Relationships
            //var addClientRelationshipsRequest = new AddClientRelationshipsRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345",
            //    AssociateId = "12345",
            //    ClientId = "12345",
            //    RelatedClientId = "12345",
            //    Relationship = RelationshipType.Controller
            //};
            //AddClientRelationshipsResponse addClientRelationshipsResponse = RequestPerformer.RequestPerformer.PerformRequest<AddClientRelationshipsResponse>(addClientRelationshipsRequest, "/relationship/add", "additional reference", 0);
            #endregion

            #region View Risk Assessment
            //var viewRiskAssessmentRequest = new ViewRiskAssessmentRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345"
            //};
            //ViewRiskAssessmentResponse viewRiskAssessmentResponse = RequestPerformer.RequestPerformer.PerformRequest<ViewRiskAssessmentResponse>(viewRiskAssessmentRequest, "/assessment/view", "additional reference", 0);
            #endregion

            #region Run Risk Assessment
            //var runRiskAssessmentRequest = new RunRiskAssessmentRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345"
            //};
            //RunRiskAssessmentResponse runRiskAssessmentResponse = RequestPerformer.RequestPerformer.PerformRequest<RunRiskAssessmentResponse>(runRiskAssessmentRequest, "/assessment/run", "additional reference", 0);
            #endregion

            #region Run Risk Assessment PickList
            //var riskAssessmentPickListSelectRequest = new RiskAssessmentPickListSelectRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345"
            //};
            //RiskAssessmentPickListSelectResponse riskAssessmentPickListSelectResponse = RequestPerformer.RequestPerformer.PerformRequest<RiskAssessmentPickListSelectResponse>(riskAssessmentPickListSelectRequest, "/assessment/pick", "additional reference", 0);
            #endregion

            #region Risk Assessment Result
            //var riskAssessmentResultRequest = new RiskAssessmentResultRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345"
            //};
            //RiskAssessmentResultResponse riskAssessmentResultResponse = RequestPerformer.RequestPerformer.PerformRequest<RiskAssessmentResultResponse>(riskAssessmentResultRequest, "/assessment/result", "additional reference", 0);
            #endregion

            #region Risk Assessment Result
            //var organisationLookupRequest = new OrganisationLookupRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    CompanyName = "myCompany",
            //    CompanyRegistrationNumber = "12345",
            //    CountryCode = "UK"
            //};
            //OrganisationLookupResponse organisationLookupResponse = RequestPerformer.RequestPerformer.PerformRequest<OrganisationLookupResponse>(organisationLookupRequest, "/assessment/nonpersonal/lookup", "additional reference", 0);
            #endregion

            #region Non-Personal Add Client
            //var nonPersonalAddClientRequest = new NonPersonalAddClientRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    CompanyName = "myCompany",
            //    CompanyRegistrationNumber = "12345",
            //    CountryCode = "UK",
            //    AssessmentType = AssessmentType.Enhanced,
            //    Clienttype =  Clienttype.NonPersonal,
            //    CompanyIntroducer = "myintro",
            //    CompanyNoDisplay = "nodisplay",
            //    CompanyStatus = "status",
            //    CompanyType = "myType",
            //    Compliance = Compliance.Yes,
            //    InceptionDate = DateTime.Now.ToString("yyyy-MM-dd"),
            //    Interview = Interview.Viaexisting,
            //    JurisdictionCode = "12345",
            //    RegisteredAddress = "myAddress",
            //    Relationship = RelationshipValue.Newknown,
            //    RiskProfile = "12345",
            //    SearchRef = "12345"
            //};
            //NonPersonalAddClientResponse nonPersonalAddClientResponse = RequestPerformer.RequestPerformer.PerformRequest<NonPersonalAddClientResponse>(nonPersonalAddClientRequest, "/client/nonpersonal/add", "additional reference", 0);
            #endregion

            #region Associates List
            //var associatesListRequest = new AssociatesListRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345",
            //    ClientId = "12345"
            //};
            //AssociatesListResponse associatesListResponse = RequestPerformer.RequestPerformer.PerformRequest<AssociatesListResponse>(associatesListRequest, "/client/associate/list", "additional reference", 0);
            #endregion

            #region Add Associate
            //var addAssociateRequest = new AddAssociateRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345",
            //    ClientId = "12345",
            //    Address = "MyAddress",
            //    CompanyName = "mycompanyName",
            //    DateOfBirth = DateTime.Now.ToShortDateString(),
            //    Forename = "myForeName",
            //    LinkDescription = "myLinkDescription",
            //    LinkType = LinkType.Accountant,
            //    MiddleNames = "myMiddleNames",
            //    Surname = "mySurname"
            //};
            //AddAssociateResponse addAssociateResponse = RequestPerformer.RequestPerformer.PerformRequest<AddAssociateResponse>(addAssociateRequest, "/client/associate/add", "additional reference", 0);
            #endregion

            #region Non Personal View Risk Assessment
            //var nonPersonalViewRiskAssessmentRequest = new NonPersonalViewRiskAssessmentRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345",
            //};
            //NonPersonalViewRiskAssessmentResponse nonPersonalViewRiskAssessmentResponse = RequestPerformer.RequestPerformer.PerformRequest<NonPersonalViewRiskAssessmentResponse>(nonPersonalViewRiskAssessmentRequest, "/assessment/view", "additional reference", 0);
            #endregion

            #region Management Oversight View
            //var managementOversightViewRequest = new ManagementOversightViewRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345",
            //};
            //ManagementOversightViewResponse managementOversightViewResponse = RequestPerformer.RequestPerformer.PerformRequest<ManagementOversightViewResponse>(managementOversightViewRequest, "/client/oversight/view", "additional reference", 0);
            #endregion

            #region Management Oversight Update
            //var managementOversightUpdateRequest = new ManagementOversightUpdateRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345",
            //};
            //ManagementOversightUpdateResponse managementOversightUpdateResponse = RequestPerformer.RequestPerformer.PerformRequest<ManagementOversightUpdateResponse>(managementOversightUpdateRequest, "/client/oversight/view", "additional reference", 0);
            #endregion

            #region Management Oversight Update
            //var monitorAlertListRequest = new MonitorAlertListRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AmlCustomerId = "12345"
            //};
            //MonitorAlertListResponse monitorAlertListResponse = RequestPerformer.RequestPerformer.PerformRequest<MonitorAlertListResponse>(monitorAlertListRequest, "/alert/list", "additional reference", 0);
            #endregion

            #region Single Monitoring Alert View
            //var singleMonitoringAlertViewRequest = new SingleMonitoringAlertViewRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AlertId = "12345",
            //    Cancelled = Cancelled.no,
            //    CancelReason = "myReason",
            //    UndoNonCompliance = Cancelled.no
            //};
            //SingleMonitoringAlertViewResponse singleMonitoringAlertViewResponse = RequestPerformer.RequestPerformer.PerformRequest<SingleMonitoringAlertViewResponse>(singleMonitoringAlertViewRequest, "/alert/update", "additional reference", 0);
            #endregion

            #region Monitoring Alert Update
            //var monitoringAlertUpdateRequest = new MonitoringAlertUpdateRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AlertId = "12345",
            //    Cancelled = Cancelled.no,
            //    CancelReason = "myReason"
            //};
            //MonitoringAlertUpdateResponse monitoringAlertUpdateResponse = RequestPerformer.RequestPerformer.PerformRequest<MonitoringAlertUpdateResponse>(monitoringAlertUpdateRequest, "/alert/update", "additional reference", 0);
            #endregion

            #region Archive Assessment
            //var archiveAssessmentRequest = new ArchiveAssessmentRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345"
            //};
            //ArchiveAssessmentResponse archiveAssessmentResponse = RequestPerformer.RequestPerformer.PerformRequest<ArchiveAssessmentResponse>(archiveAssessmentRequest, "/assessment/archive", "additional reference", 0);
            #endregion

            #region Unarchive Assessment
            var unarchiveAssessmentRequest = new UnarchiveAssessmentRequest()
            {
                Uri = authenticationResponse.uri,
                AssessmentId = "12345"
            };
            UnarchiveAssessmentResponse unarchiveAssessmentResponse = RequestPerformer.RequestPerformer.PerformRequest<UnarchiveAssessmentResponse>(unarchiveAssessmentRequest, "/assessment/unarchive", "additional reference", 0);
            #endregion
        }
    }
}
