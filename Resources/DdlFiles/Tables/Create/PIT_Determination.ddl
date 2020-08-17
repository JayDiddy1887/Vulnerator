CREATE TABLE IF NOT EXISTS PIT_Determination (
    PIT_Determination_ID INTEGER PRIMARY KEY,
    ReceivesInfo NVARCHAR (5) NOT NULL,
    TransmitsInfo NVARCHAR (5) NOT NULL,
    ProcessesInfo NVARCHAR (5) NOT NULL,
    StoresInfo NVARCHAR (5) NOT NULL,
    DisplaysInfo NVARCHAR (5) NOT NULL,
    EmbeddedInSpecialPurpose NVARCHAR (5) NOT NULL,
    IsDedicatedSpecialPurposeSystem NVARCHAR (5) NOT NULL,
    IsEssentialSpecialPurposeSystem NVARCHAR (5) NOT NULL,
    PerformsGeneralServices NVARCHAR (5) NOT NULL,
    IsFireControlOrTargetingSystem NVARCHAR (5),
    IsMissileSystem NVARCHAR (5),
    IsGunSystem NVARCHAR (5),
    IsTorpedo NVARCHAR (5),
    IsActiveElectronicsWarfareSystem NVARCHAR (5),
    IsLauncher NVARCHAR (5),
    IsDecoySystem NVARCHAR (5),
    IsVehicle NVARCHAR (5),
    IsTank NVARCHAR (5),
    IsArtillery NVARCHAR (5),
    IsManDeployableWeapon NVARCHAR (5),
    IsFlightSimulator NVARCHAR (5),
    IsBridgeSimulator NVARCHAR (5),
    IsClassroomNetworkOther NVARCHAR (5),
    IsEmbeddedTacticalTrainerAndSimulator NVARCHAR (5),
    IsBuiltInTestOrMaintenanceEquipment NVARCHAR (5),
    IsPortableTestOrMaintenanceEquipment NVARCHAR (5),
    IsBuiltInCalibrationEquipment NVARCHAR (5),
    IsPortableCalibrationEquipment NVARCHAR (5),
    IsRDTE_Network NVARCHAR (5),
    IsRDTE_SystemConnectedToRDTE_Network NVARCHAR (5),
    IsMedicalImaging NVARCHAR (5),
    IsMedicalMonitoring NVARCHAR (5),
    IsShipOrAircraftControlSystem NVARCHAR (5),
    IsIntegratedBridgeSystem NVARCHAR (5),
    IsElectronicChart NVARCHAR (5),
    IsGPS NVARCHAR (5),
    IsWSN NVARCHAR (5),
    IsInterialNavigation NVARCHAR (5),
    IsDeadReckoningDevice NVARCHAR (5),
    IsRealTimeAccessControlSystem NVARCHAR (5),
    IsHVAC_System NVARCHAR (5),
    IsRealTimeSecurityMonitoringSystem NVARCHAR (5),
    IsSCADA_System NVARCHAR (5),
    IsUtilitiesEngineeringManagement NVARCHAR (5),
    IsMeteringAndControl NVARCHAR (5),
    IsMechanicalMonitoring NVARCHAR (5),
    IsDamageControlMonitoring NVARCHAR (5),
    IsVoiceCommunicationSystem NVARCHAR (5),
    IsSatelliteCommunitcationSystem NVARCHAR (5),
    IsTacticalCommunication NVARCHAR (5),
    IsISDN_VTC_System NVARCHAR (5),
    IsInterrigatorOrTransponder NVARCHAR (5),
    IsCommandAndControlOfForces NVARCHAR (5),
    IsCombatIdentificationAndClassification NVARCHAR (5),
    IsRealTimeTrackManagement NVARCHAR (5),
    IsForceOrders NVARCHAR (5),
    IsTroopMovement NVARCHAR (5),
    IsEngagementCoordination NVARCHAR (5),
    IsWarFightingDisplay NVARCHAR (5),
    IsInputOutputConsole NVARCHAR (5),
    IsRADAR_System NVARCHAR (5),
    IsActiveOrPassiveAcousticSensor NVARCHAR (5),
    IsVisualOrImagingSensor NVARCHAR (5),
    IsRemoteVehicle NVARCHAR (5),
    IsPassiveElectronicWarfareSensor NVARCHAR (5),
    IsISR_Sensor NVARCHAR (5),
    IsNationalSensor NVARCHAR (5),
    IsNavigationAndControlSensor NVARCHAR (5),
    IsElectronicWarfare NVARCHAR (5),
    IsIntelligence NVARCHAR (5),
    IsEnvironmental NVARCHAR (5),
    IsAcoustic NVARCHAR (5),
    IsGeographic NVARCHAR (5),
    IsTacticalDecisionAid NVARCHAR (5),
    OtherSystemTypeDescription NVARCHAR (500)
);