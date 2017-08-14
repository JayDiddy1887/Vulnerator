﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vulnerator.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Vulnerator.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM Vulnerabilities_VulnerabilitySources WHERE Vulnerability_Source_ID = (SELECT Vulnerability_Source_ID FROM VulnerabilitySources WHERE Source_Version = &apos;Version Unknown&apos;);.
        /// </summary>
        internal static string DeleteAcasVulnerabilitiesMappedToUnknownVersion {
            get {
                return ResourceManager.GetString("DeleteAcasVulnerabilitiesMappedToUnknownVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Data_Entry_Dates VALUES (NULL, @Entry_Date);.
        /// </summary>
        internal static string InsertDataEntryDate {
            get {
                return ResourceManager.GetString("InsertDataEntryDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Groups VALUES (NULL, @Group_Name, &apos;False&apos;, NULL, NULL);.
        /// </summary>
        internal static string InsertGroup {
            get {
                return ResourceManager.GetString("InsertGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Hardware VALUES (NULL,@Displayed_Host_Name, @Host_Name,@FQDN,@NetBIOS,@Scan_IP, @Found_21745, @Found_26917,@Is_Virtual_Server,@NIAP_Level,@Manufacturer,@ModelNumber,@Is_IA_Enabled,@SerialNumber,@Role,(SELECT LifecycleStatus_ID FROM LifecycleStatuses WHERE LifecycleStatus = &apos;Uncategorized&apos;));.
        /// </summary>
        internal static string InsertHardware {
            get {
                return ResourceManager.GetString("InsertHardware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO IP_Addresses VALUES (NULL, @IP_Address);.
        /// </summary>
        internal static string InsertIpAddress {
            get {
                return ResourceManager.GetString("InsertIpAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO MAC_Addresses VALUES (NULL, @MAC_Address);.
        /// </summary>
        internal static string InsertMacAddress {
            get {
                return ResourceManager.GetString("InsertMacAddress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO PPS VALUES (NULL, @Port, @Protocol);.
        /// </summary>
        internal static string InsertPPS {
            get {
                return ResourceManager.GetString("InsertPPS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO ScapScores VALUES (NULL, @Score, (SELECT Hardware_ID FROM Hardware WHERE Scan_IP = @Scan_IP), (SELECT Finding_Source_File_ID FROM UniqueFindingsSourceFiles WHERE Finding_Source_File_Name = @Finding_Source_File_Name), (SELECT Vulnerability_Source_ID FROM VulnerabilitySources WHERE Source_Name = @Source_Name), @Scan_Date);.
        /// </summary>
        internal static string InsertScapScore {
            get {
                return ResourceManager.GetString("InsertScapScore", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Software VALUES (
        ///	NULL, 
        ///	@Discovered_Software_Name, 
        ///	@Displayed_Software_Name, 
        ///	@Software_Acronym, 
        ///	@Software_Version, 
        ///	@Function, 
        ///	@DADMS_ID, 
        ///	@DADMS_Disposition, 
        ///	@DADMS_LDA, 
        ///	@Has_Custom_Code, 
        ///	@IaOrIa_Enabled, 
        ///	@Is_OS_Or_Firmware, 
        ///	@FAM_Accepted, 
        ///	@Externally_Authorized, 
        ///	@ReportInAccreditation_Global, 
        ///	@ApprovedForBaseline_Global, 
        ///	@BaselineApprover_Global, 
        ///	@Instance
        ///);.
        /// </summary>
        internal static string InsertSoftware {
            get {
                return ResourceManager.GetString("InsertSoftware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO UniqueFindings VALUES (
        ///	NULL, 
        ///	@Instance_Identifier,
        ///	@Tool_Generated_Output, 
        ///	@Comments, 
        ///	@Finding_Details, 
        ///	@Technical_Mitigation, 
        ///	@Proposed_Mitigation, 
        ///	@Predisposing_Conditions, 
        ///	@Impact, 
        ///	@Likelihood, 
        ///	@Severity, 
        ///	@Risk, 
        ///	@Residual_Risk, 
        ///	@First_Discovered, 
        ///	@Last_Observed, 
        ///	@Approval_Status, 
        ///	@Approval_Date, 
        ///	@Approval_Expiration_Date, 
        ///	@Delta_Analysis_Required, 
        ///	(SELECT Finding_Type_ID FROM FindingTypes WHERE Finding_Type = @Finding_Type), 
        ///	(SELEC [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InsertUniqueFinding {
            get {
                return ResourceManager.GetString("InsertUniqueFinding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO UniqueFindingsSourceFiles VALUES (NULL, @Finding_Source_File_Name);.
        /// </summary>
        internal static string InsertUniqueFindingSource {
            get {
                return ResourceManager.GetString("InsertUniqueFindingSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Vulnerabilities VALUES (NULL, @Unique_Vulnerability_Identifier, @Vulnerability_Group_ID, @Vulnerability_Group_Title, @Secondary_Vulnerability_Identifier, @VulnerabilityFamilyOrClass, @Vulnerability_Version, @Vulnerability_Release, @Vulnerability_Title, @Vulnerability_Description, @Risk_Statement, @Fix_Text, @Published_Date, @Modified_Date, @Fix_Published_Date, @Raw_Risk, @CVSS_Base_Score, @CVSS_Base_Vector, @CVSS_Temporal_Score, @CVSS_Temporal_Vector, @Check_Content, @False_Positives, @False_Neg [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InsertVulnerability {
            get {
                return ResourceManager.GetString("InsertVulnerability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO VulnerabilityReferences VALUES (NULL, @Reference, @Reference_Type);.
        /// </summary>
        internal static string InsertVulnerabilityReference {
            get {
                return ResourceManager.GetString("InsertVulnerabilityReference", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT OR IGNORE INTO VulnerabilitySources VALUES (NULL, @Source_Name, @Source_Secondary_Identifier, @Vulnerability_Source_File_Name, @Source_Description, @Source_Version, @Source_Release);.
        /// </summary>
        internal static string InsertVulnerabilitySource {
            get {
                return ResourceManager.GetString("InsertVulnerabilitySource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO HardwareGroups VALUES ((SELECT Hardware_ID FROM Hardware WHERE Scan_IP = @Scan_IP AND Host_Name = @Host_Name AND FQDN = @FQDN AND NetBIOS = @NetBIOS), (SELECT Group_ID FROM Groups WHERE Group_Name = @Group_Name));.
        /// </summary>
        internal static string MapHardwareToGroup {
            get {
                return ResourceManager.GetString("MapHardwareToGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO SoftwareHardware VALUES ((SELECT Software_ID FROM Software WHERE Discovered_Software_Name = @Discovered_Software_Name), (SELECT Hardware_ID FROM Hardware WHERE Scan_IP = @Scan_IP),@Install_Date  ,@ReportInAccreditation, @ApprovedForBaseline, @BaselineApprover);.
        /// </summary>
        internal static string MapHardwareToSoftware {
            get {
                return ResourceManager.GetString("MapHardwareToSoftware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO HardwareIpAddresses VALUES ((SELECT Hardware_ID FROM Hardware WHERE Scan_IP = @Scan_IP AND Host_Name = @Host_Name), (SELECT IP_Address_ID FROM IP_Addresses WHERE IP_Address = @IP_Address));.
        /// </summary>
        internal static string MapIpToHardware {
            get {
                return ResourceManager.GetString("MapIpToHardware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO HardwareMacAddresses VALUES ((SELECT Hardware_ID FROM Hardware WHERE Scan_IP = @Scan_IP AND Host_Name = @Host_Name), (SELECT MAC_Address_ID FROM MAC_Addresses WHERE MAC_Address = @MAC_Address));.
        /// </summary>
        internal static string MapMacToHardware {
            get {
                return ResourceManager.GetString("MapMacToHardware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Hardware_PPS (Hardware_ID, PPS_ID, Discovered_Service, Display_Service) VALUES ((SELECT Hardware_ID FROM Hardware WHERE Scan_IP = @Scan_IP), (SELECT PPS_ID FROM PPS WHERE Port = @Port AND Protocol = @Protocol), @Discovered_Service, @Display_Service);.
        /// </summary>
        internal static string MapPortToHardware {
            get {
                return ResourceManager.GetString("MapPortToHardware", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Vulnerabilities_VulnerabilityReferences VALUES ((SELECT Vulnerability_ID FROM Vulnerabilities WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifier), (SELECT Reference_ID FROM VulnerabilityReferences WHERE Reference = @Reference AND Reference_Type = @Reference_Type));.
        /// </summary>
        internal static string MapReferenceToVulnerability {
            get {
                return ResourceManager.GetString("MapReferenceToVulnerability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT OR REPLACE INTO VulnerabilitiesCCIs VALUES ((SELECT Vulnerability_ID FROM Vulnerabilities WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifier), (SELECT CCI_ID FROM CCIs WHERE CCI = @CCI));.
        /// </summary>
        internal static string MapVulnerabilityToCci {
            get {
                return ResourceManager.GetString("MapVulnerabilityToCci", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT OR REPLACE INTO Vulnerabilities_IA_Controls VALUES (@Vulnerablity_ID, (SELECT IA_Control_ID FROM IA_Controls WHERE IA_Control_Number = @IA_Control));.
        /// </summary>
        internal static string MapVulnerabilityToIAControl {
            get {
                return ResourceManager.GetString("MapVulnerabilityToIAControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO Vulnerabilities_VulnerabilitySources VALUES ((SELECT Vulnerability_ID FROM Vulnerabilities WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifier), (SELECT Vulnerability_Source_ID FROM VulnerabilitySources WHERE Source_Name = @Source_Name AND Source_Version = @Source_Version AND Source_Release = @Source_Release));.
        /// </summary>
        internal static string MapVulnerabilityToSource {
            get {
                return ResourceManager.GetString("MapVulnerabilityToSource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;=(?:\w{2})\s{2})(?:\w+(?:-?\.?\+*)*)+.
        /// </summary>
        internal static string RegexAcasDebianSoftwareName {
            get {
                return ResourceManager.GetString("RegexAcasDebianSoftwareName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:\s{10,})(?:\d+(?:\w*(?:-?\.?\+*\:?\~?)*)*)+.
        /// </summary>
        internal static string RegexAcasDebianSoftwareVersion {
            get {
                return ResourceManager.GetString("RegexAcasDebianSoftwareVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(\w)+(-?\.?[A-Za-z]+)*.
        /// </summary>
        internal static string RegexAcasLinuxSoftwareName {
            get {
                return ResourceManager.GetString("RegexAcasLinuxSoftwareName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:(?:\d+\.?-?)+(?:(?:\w+)?\.?-?)+)+(?=\|).
        /// </summary>
        internal static string RegexAcasLinuxSoftwareVersion {
            get {
                return ResourceManager.GetString("RegexAcasLinuxSoftwareVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;=\[installed on\s)(?:\d{2,4}\/\d{1,2}\/\d{1,2})(?=\]).
        /// </summary>
        internal static string RegexAcasSoftwareInstallDate {
            get {
                return ResourceManager.GetString("RegexAcasSoftwareInstallDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(?:\w)+(?:-?(?:\w?)+)+.
        /// </summary>
        internal static string RegexAcasSolarisSoftwareName {
            get {
                return ResourceManager.GetString("RegexAcasSolarisSoftwareName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:\d+\.?)+,?(?:REV=(?:\d+\.?)+)?.
        /// </summary>
        internal static string RegexAcasSolarisSoftwareVersion {
            get {
                return ResourceManager.GetString("RegexAcasSolarisSoftwareVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^.+?((?=\[)|(?=\r?\n)).
        /// </summary>
        internal static string RegexAcasWindowsSoftwareName {
            get {
                return ResourceManager.GetString("RegexAcasWindowsSoftwareName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;=\[version\s)(?:\d+(?:(?:(?:\.|-?)\d*)*)|(?:\w+))(?=\]).
        /// </summary>
        internal static string RegexAcasWindowsSoftwareVersion {
            get {
                return ResourceManager.GetString("RegexAcasWindowsSoftwareVersion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CAT\s(?:I{1,3}(?:V)?)(?:,\s)*.
        /// </summary>
        internal static string RegexCatText {
            get {
                return ResourceManager.GetString("RegexCatText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string RegexCciSelector {
            get {
                return ResourceManager.GetString("RegexCciSelector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$.
        /// </summary>
        internal static string RegexIPv4 {
            get {
                return ResourceManager.GetString("RegexIPv4", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]| [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string RegexIPv6 {
            get {
                return ResourceManager.GetString("RegexIPv6", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2}).
        /// </summary>
        internal static string RegexMAC {
            get {
                return ResourceManager.GetString("RegexMAC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?&lt;=Release: )\d+(?=\s).
        /// </summary>
        internal static string RegexRawStigRelease {
            get {
                return ResourceManager.GetString("RegexRawStigRelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to (?:(?:\w)+(?:-|\.|_)?)+.
        /// </summary>
        internal static string RegexStigId {
            get {
                return ResourceManager.GetString("RegexStigId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///    Unique_Vulnerability_Identifier,
        ///    Vulnerability_Version,
        ///    Vulnerability_Title,
        ///    Vulnerability_Description,
        ///    Source_Name,
        ///    Source_Version,
        ///    Source_Release, 
        ///    Comments, 
        ///    Finding_Details,
        ///    Raw_Risk, 
        ///    Status,
        ///    GROUP_CONCAT(DISTINCT Scan_IP) AS IPs,
        ///    GROUP_CONCAT(DISTINCT (Control_Family || &apos;-&apos; || Control_Number || &apos;.&apos; || Enhancement)) AS NIST_Controls
        ///FROM Vulnerabilities
        ///LEFT JOIN UniqueFindings ON Vulnerabilities.Vulnerability_ID = UniqueFindings [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SelectGroupedPoamVulnerabilities {
            get {
                return ResourceManager.GetString("SelectGroupedPoamVulnerabilities", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT name FROM sqlite_master WHERE type == &apos;index&apos;;.
        /// </summary>
        internal static string SelectIndexes {
            get {
                return ResourceManager.GetString("SelectIndexes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Source_Version, Source_Release FROM VulnerabilitySources WHERE Source_Name = @Source_Name;.
        /// </summary>
        internal static string SelectVulnerabilitySourceVersionAndRelease {
            get {
                return ResourceManager.GetString("SelectVulnerabilitySourceVersionAndRelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Vulnerability_Version, Vulnerability_Release FROM Vulnerabilities WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifier;.
        /// </summary>
        internal static string SelectVulnerabilityVersionAndRelease {
            get {
                return ResourceManager.GetString("SelectVulnerabilityVersionAndRelease", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE Hardware SET Found_21745 = @Found_21745, Found_26917 = @Found_26917 WHERE Scan_IP = @Scan_IP AND Host_Name=@Host_Name;.
        /// </summary>
        internal static string SetCredentialedScanStatus {
            get {
                return ResourceManager.GetString("SetCredentialedScanStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE UniqueFindings SET Delta_Analysis_Required = &apos;True&apos; WHERE Vulnerability_ID = (SELECT Vulnerability_ID FROM Vulnerabilities WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifier);.
        /// </summary>
        internal static string UpdateDeltaAnalysisFlag {
            get {
                return ResourceManager.GetString("UpdateDeltaAnalysisFlag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE UniqueFindings SET Last_Observed = @Last_Observed, Status = @Status, Tool_Generated_Output = @Tool_Generated_Output WHERE Hardware_ID = (SELECT Hardware_ID FROM Hardware WHERE Scan_IP = @Scan_IP) AND Software_ID = (SELECT Software_ID FROM Software WHERE Discovered_Software_Name = @Discovered_Software_Name) AND Vulnerability_ID = (SELECT Vulnerability_ID FROM Vulnerabilities WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifier) AND Last_Observed &lt; @Last_Observed;.
        /// </summary>
        internal static string UpdateUniqueFindingFromAcas {
            get {
                return ResourceManager.GetString("UpdateUniqueFindingFromAcas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE UniqueFindings SET 
        ///	Finding_Details = @Finding_Details, 
        ///	Comments = @Comments, 
        ///	Severity_Override = @Severity_Override, 
        ///	Severity_Override_Justification = @Severity_Override_Justification, 
        ///	Last_Observed = @Last_Observed, 
        ///	Technology_Area = @Technology_Area, 
        ///	Web_DB_Site = @Web_DB_Site, 
        ///	Web_DB_Instance = @Web_DB_Instance, 
        ///	Finding_Source_File_ID = (SELECT Finding_Source_File_ID FROM UniqueFindingsSourceFiles WHERE Finding_Source_File_Name = @Finding_Source_File_Name), 
        ///	Status = @ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateUniqueFindingFromCkl {
            get {
                return ResourceManager.GetString("UpdateUniqueFindingFromCkl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE Vulnerabilities SET Vulnerability_Title=@Vulnerability_Title, Vulnerability_Description = @Vulnerability_Description, Risk_Statement = @Risk_Statement, Fix_Text = @Fix_Text, Modified_Date = @Modified_Date, Fix_Published_Date = @Fix_Published_Date, Raw_Risk = @Raw_Risk, Vulnerability_Version = @Vulnerability_Version, Vulnerability_Release = @Vulnerability_Release WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifier;.
        /// </summary>
        internal static string UpdateVulnerability {
            get {
                return ResourceManager.GetString("UpdateVulnerability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE UniqueFindings SET 
        ///	Last_Observed = @Last_Observed, 
        ///	Status = @Status, 
        ///	Finding_Source_File_ID = (SELECT Finding_Source_File_ID FROM UniqueFindingsSourceFiles WHERE Finding_Source_File_Name = @Finding_Source_File_Name),
        ///	Tool_Generated_Output = @Tool_Generated_Output 
        ///WHERE 
        ///	Hardware_ID = (SELECT Hardware_ID FROM Hardware WHERE Scan_IP = @Scan_IP) 
        ///AND 
        ///	Vulnerability_ID = (SELECT Vulnerability_ID FROM Vulnerabilities WHERE Unique_Vulnerability_Identifier = @Unique_Vulnerability_Identifie [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateVulnerabilityFromAcas {
            get {
                return ResourceManager.GetString("UpdateVulnerabilityFromAcas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE 
        ///	VulnerabilitySources 
        ///SET 
        ///	Source_Name = @Source_Name, 
        ///	Source_Secondary_Identifier = @Source_Secondary_Identifier, 
        ///	Vulnerability_Source_File_Name = @Vulnerability_Source_File_Name, 
        ///	Source_Description = @Source_Description, 
        ///	Source_Version = @Source_Version, 
        ///	Source_Release = @Source_Release 
        ///WHERE 
        ///	Vulnerability_Source_ID = (SELECT Vulnerability_Source_ID FROM VulnerabilitySources WHERE Source_Name = @Source_Name);.
        /// </summary>
        internal static string UpdateVulnerabilitySource {
            get {
                return ResourceManager.GetString("UpdateVulnerabilitySource", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE 
        ///    Vulnerabilities_VulnerabilitySources 
        ///SET 
        ///    Vulnerability_Source_ID = (SELECT Vulnerability_Source_ID FROM VulnerabilitySources WHERE Source_Name = @Source_Name AND Source_Version = @Source_Version AND Source_Release = @Source_Release)
        ///WHERE
        ///    Vulnerability_Source_ID = (SELECT Vulnerability_Source_ID FROM VulnerabilitySources WHERE Source_Name = @Source_Name AND Source_Version = &apos;Version Unknown&apos;).
        /// </summary>
        internal static string UpdateVulnerabilitySourceFromAcas {
            get {
                return ResourceManager.GetString("UpdateVulnerabilitySourceFromAcas", resourceCulture);
            }
        }
    }
}
