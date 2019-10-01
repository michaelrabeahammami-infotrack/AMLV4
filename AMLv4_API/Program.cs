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
            //var unarchiveAssessmentRequest = new UnarchiveAssessmentRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AssessmentId = "12345"
            //};
            //UnarchiveAssessmentResponse unarchiveAssessmentResponse = RequestPerformer.RequestPerformer.PerformRequest<UnarchiveAssessmentResponse>(unarchiveAssessmentRequest, "/assessment/unarchive", "additional reference", 0);
            #endregion

            #region List Relationships
            //var listRelationshipsRequest = new ListRelationshipsRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    ClientId = "12345"
            //};
            //ListRelationshipsResponse listRelationshipsResponse = RequestPerformer.RequestPerformer.PerformRequest<ListRelationshipsResponse>(listRelationshipsRequest, "/relationship/list", "additional reference", 0);
            #endregion

            #region View Relationship
            //var viewRelationshipsRequest = new ViewRelationshipsRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    RelationshipId = "12345"
            //};
            //ViewRelationshipsResponse viewRelationshipsResponse = RequestPerformer.RequestPerformer.PerformRequest<ViewRelationshipsResponse>(viewRelationshipsRequest, "/relationship/view", "additional reference", 0);
            #endregion

            #region Archive Relationship
            //var archiveRelationshipRequest = new ArchiveRelationshipRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    RelationshipId = "12345"
            //};
            //ArchiveRelationshipResponse archiveRelationshipResponse = RequestPerformer.RequestPerformer.PerformRequest<ArchiveRelationshipResponse>(archiveRelationshipRequest, "/relationship/archive", "additional reference", 0);
            #endregion

            #region Unarchive Relationship
            //var unarchiveRelationshipRequest = new UnarchiveRelationshipRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    RelationshipId = "12345"
            //};
            //UnarchiveRelationshipResponse unarchiveRelationshipResponse = RequestPerformer.RequestPerformer.PerformRequest<UnarchiveRelationshipResponse>(unarchiveRelationshipRequest, "/relationship/unarchive", "additional reference", 0);
            #endregion

            #region List Risk Profiles
            //var listRiskProfilesRequest = new ListRiskProfilesRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profilestatus = Profilestatus.Enabled,
            //    Profiletype = Profiletype.Personal
            //};
            //ListRiskProfilesResponse listRiskProfilesResponse = RequestPerformer.RequestPerformer.PerformRequest<ListRiskProfilesResponse>(listRiskProfilesRequest, "/riskprofile/list", "additional reference", 0);
            #endregion

            #region Add Risk Profile
            //var addRiskProfileRequest = new AddRiskProfileRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profilename = "myProfile",
            //    Profiletype = Profiletype.Personal
            //};
            //AddRiskProfileResponse addRiskProfileResponse = RequestPerformer.RequestPerformer.PerformRequest<AddRiskProfileResponse>(addRiskProfileRequest, "/riskprofile/add", "additional reference", 0);
            #endregion

            #region Copy Risk Profile
            //var copyRiskProfileRequest = new CopyRiskProfileRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345"
            //};
            //CopyRiskProfileResponse copyRiskProfileResponse = RequestPerformer.RequestPerformer.PerformRequest<CopyRiskProfileResponse>(copyRiskProfileRequest, "/riskprofile/copy", "additional reference", 0);
            #endregion

            #region View Risk Profile
            //var viewRiskProfileRequest = new ViewRiskProfileRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345"
            //};
            //ViewRiskProfileResponse viewRiskProfileResponse = RequestPerformer.RequestPerformer.PerformRequest<ViewRiskProfileResponse>(viewRiskProfileRequest, "/riskprofile/view", "additional reference", 0);
            #endregion

            #region Update Pending Risk Profile
            //var updatePendingRiskProfileRequest = new UpdatePendingRiskProfileRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345",
            //    Profilename = "myProfile"
            //};
            //UpdatePendingRiskProfileResponse updatePendingRiskProfileResponse = RequestPerformer.RequestPerformer.PerformRequest<UpdatePendingRiskProfileResponse>(updatePendingRiskProfileRequest, "/riskprofile/update", "additional reference", 0);
            #endregion

            #region Delete Pending Risk Profile
            //var deletePendingRiskProfileRequest = new DeletePendingRiskProfileRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345"
            //};
            //DeletePendingRiskProfileResponse deletePendingRiskProfileResponse = RequestPerformer.RequestPerformer.PerformRequest<DeletePendingRiskProfileResponse>(deletePendingRiskProfileRequest, "/riskprofile/delete", "additional reference", 0);
            #endregion

            #region Validate Pending Risk Profile
            //var validatePendingRiskProfileRequest = new ValidatePendingRiskProfileRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345"
            //};
            //ValidatePendingRiskProfileResponse validatePendingRiskProfileResponse = RequestPerformer.RequestPerformer.PerformRequest<ValidatePendingRiskProfileResponse>(validatePendingRiskProfileRequest, "/riskprofile/validate", "additional reference", 0);
            #endregion

            #region Enable Pending Risk Profile
            //var enablePendingRiskProfileRequest = new EnablePendingRiskProfileRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345"
            //};
            //EnablePendingRiskProfileResponse enablePendingRiskProfileResponse = RequestPerformer.RequestPerformer.PerformRequest<EnablePendingRiskProfileResponse>(enablePendingRiskProfileRequest, "/riskprofile/enable", "additional reference", 0);
            #endregion

            #region Archive Risk Profile
            //var archiveRiskProfileRequest = new ArchiveRiskProfileRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345"
            //};
            //ArchiveRiskProfileResponse ArchiveRiskProfileResponse = RequestPerformer.RequestPerformer.PerformRequest<ArchiveRiskProfileResponse>(archiveRiskProfileRequest, "/riskprofile/archive", "additional reference", 0);
            #endregion

            #region Unarchive Risk Profile
            //var unarchiveRiskProfileRequest = new UnarchiveRiskProfileRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345"
            //};
            //UnarchiveRiskProfileResponse UnarchiveRiskProfileResponse = RequestPerformer.RequestPerformer.PerformRequest<UnarchiveRiskProfileResponse>(unarchiveRiskProfileRequest, "/riskprofile/unarchive", "additional reference", 0);
            #endregion

            #region List Risk Profile Rules
            //var listRiskProfileRulesRequest = new ListRiskProfileRulesRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345"
            //};
            //ListRiskProfileRulesResponse ListRiskProfileRulesResponse = RequestPerformer.RequestPerformer.PerformRequest<ListRiskProfileRulesResponse>(listRiskProfileRulesRequest, "/riskprofile/rule/list", "additional reference", 0);
            #endregion

            #region Add Profile Rule
            //var addProfileRulesRequest = new AddProfileRulesRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Profileid = "12345",
            //    AllowEnhanced = AllowEnhanced.Yes,
            //    AllowSimplified = AllowEnhanced.Yes,
            //    DoccertEnhancedUnverified = AllowEnhanced.Yes,
            //    DoccertEnhancedVerified = AllowEnhanced.Yes,
            //    DoccertSimplified = AllowEnhanced.Yes,
            //    InterviewMatch = MatchType.Yes,
            //    InterviewValue = InterviewValue.Home,
            //    NationalityMatch = MatchType.Yes,
            //    NationalityValue = "uk",
            //    NumadsElectronicEnhanced = "2",
            //    NumadsEnhancedUnverified = "3",
            //    NumadsEnhancedVerified = "4",
            //    NumadsSimplified = "3",
            //    NumidsElectronicEnhanced = "3",
            //    NumidsEnhancedUnverified = "4",
            //    NumidsEnhancedVerified = "3",
            //    NumidsSimplified = "3",
            //    NumotsElectronicEnhanced = "4",
            //    RelationshipMatch = MatchType.Yes,
            //    RelationshipValue = RelationshipValue.Existing,
            //    ResidencyMatch = MatchType.Yes,
            //    ResidencyValue = "hello"
            //};
            //AddPofileRuleResponse addPofileRuleResponse = RequestPerformer.RequestPerformer.PerformRequest<AddPofileRuleResponse>(addProfileRulesRequest, "/riskprofile/rule/add", "additional reference", 0);
            #endregion

            #region Copy Profile Rule
            //var copyProfileRuleRequest = new CopyProfileRuleRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Ruleid = "12345"
            //};
            //CopyProfileRuleResponse copyProfileRuleResponse = RequestPerformer.RequestPerformer.PerformRequest<CopyProfileRuleResponse>(copyProfileRuleRequest, "/riskprofile/rule/copy", "additional reference", 0);
            #endregion

            #region View Profile Rule
            //var viewProfileRuleRequest = new ViewProfileRuleRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Ruleid = "12345"
            //};
            //ViewProfileRuleResponse ViewProfileRuleResponse = RequestPerformer.RequestPerformer.PerformRequest<ViewProfileRuleResponse>(viewProfileRuleRequest, "/riskprofile/rule/view", "additional reference", 0);
            #endregion

            #region Update Profile Rule
            //var updatePendingProfileRuleRequest = new UpdatePendingProfileRuleRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    AllowEnhanced = AllowEnhanced.Yes,
            //    AllowSimplified = AllowEnhanced.Yes,
            //    DoccertEnhancedUnverified = AllowEnhanced.Yes,
            //    DoccertEnhancedVerified = AllowEnhanced.Yes,
            //    DoccertSimplified = AllowEnhanced.Yes,
            //    InterviewMatch = MatchType.Yes,
            //    InterviewValue = InterviewValue.Home,
            //    NationalityMatch = MatchType.Yes,
            //    NationalityValue = "uk",
            //    NumadsElectronicEnhanced = "2",
            //    NumadsEnhancedUnverified = "3",
            //    NumadsEnhancedVerified = "4",
            //    NumadsSimplified = "3",
            //    NumidsElectronicEnhanced = "3",
            //    NumidsEnhancedUnverified = "4",
            //    NumidsEnhancedVerified = "3",
            //    NumidsSimplified = "3",
            //    NumotsElectronicEnhanced = "4",
            //    RelationshipMatch = MatchType.Yes,
            //    RelationshipValue = RelationshipValue.Existing,
            //    ResidencyMatch = MatchType.Yes,
            //    ResidencyValue = "hello",
            //    Ruleid = "12345"
            //};
            //UpdatePendingProfileRuleResponse UpdatePendingProfileRuleResponse = RequestPerformer.RequestPerformer.PerformRequest<UpdatePendingProfileRuleResponse>(updatePendingProfileRuleRequest, "/riskprofile/rule/update", "additional reference", 0);
            #endregion

            #region Delete Profile Rule
            //var deletePendingProfileRuleRequest = new DeletePendingProfileRuleRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Ruleid = "12345"
            //};
            //DeletePendingProfileRuleResponse deletePendingProfileRuleResponse = RequestPerformer.RequestPerformer.PerformRequest<DeletePendingProfileRuleResponse>(deletePendingProfileRuleRequest, "/riskprofile/rule/delete", "additional reference", 0);
            #endregion

            #region Validate Rule Against Other Rules
            //var validateRuleAgainstOtherRulesRequest = new ValidateRuleAgainstOtherRulesRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Ruleid = "12345"
            //};
            //ValidateRuleAgainstOtherRulesResponse ValidateRuleAgainstOtherRulesResponse = RequestPerformer.RequestPerformer.PerformRequest<ValidateRuleAgainstOtherRulesResponse>(validateRuleAgainstOtherRulesRequest, "/riskprofile/rule/validate", "additional reference", 0);
            #endregion

            #region Client List For Customer
            //var clientListForCustomerRequest = new ClientListForCustomerRequest()
            //{
            //    Uri = authenticationResponse.uri,
            //    Clienttypefilter = Clienttypefilter.Personal
            //};
            //ClientListForCustomerResponse clientListForCustomerResponse = RequestPerformer.RequestPerformer.PerformRequest<ClientListForCustomerResponse>(clientListForCustomerRequest, "/client/list", "additional reference", 0);
            #endregion

            #region Search For Client With Wildcards
            var SearchForClientWithWildcardsRequest = new SearchForClientWithWildcardsRequest()
            {
                Uri = authenticationResponse.uri,
                AmlUserId = "12345",
                ClientName = "myname",
                ClientReference = "myref",
                ClientType = Clienttypefilter.Personal,
                ComplianceStatus = ComplianceStatus.Compliant,
                EndDate = DateTime.Now.ToString("yyyy-MM-dd"),
                IncludeArchived = IncludeArchived.Yes,
                Postcode = "se1 8rt",
                RecordLimit = "32",
                StartDate = DateTime.Now.ToString("yyyy-MM-dd"),
                UserName = "myusername"
            };
            SearchForClientWithWildcardsResponse SearchForClientWithWildcardsResponse = RequestPerformer.RequestPerformer.PerformRequest<SearchForClientWithWildcardsResponse>(SearchForClientWithWildcardsRequest, "/client/search", "additional reference", 0);
            #endregion
        }
    }
}
