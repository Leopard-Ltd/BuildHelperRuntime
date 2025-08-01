using UnityEditor;

public static class BuildMenu
{
    [MenuItem("BuildHelper/SetBlueprintPath")]
    static void SetBlueprintDataPath() { BuildCmd.SetBlueprintDataPath(); }

    [MenuItem("BuildHelper/Build Android from Editor")]
    static void BuildAndroidOnEditor() { BuildCmd.BuildAndroidOnEditor(); }

    [MenuItem("BuildHelper/TryRynSyncData")]
    static void TryRunSyncData() { BuildCmd.TryRunSyncData(); }

    [MenuItem("BuildHelper/Build Android")]
    static void BuildAndroid() { BuildCmd.BuildAndroid(); }

    [MenuItem("BuildHelper/Build Ios")]
    static void BuildIos() { BuildCmd.BuildIos(); }

    [MenuItem("BuildHelper/Build WebGl")]
    static void BuildWebGL() { BuildCmd.BuildWebGL(); }

    [MenuItem("BuildHelper/UploadTestFlight")]
    static void UploadTestFlight() { BuildCmd.UploadTestFlight(); }

    [MenuItem("BuildHelper/UploadAAbToGooglePlay")]
    static void UploadAAbToGooglePlay() { BuildCmd.UploadAAbToGooglePlay(); }

    [MenuItem("BuildHelper/ProcessBlueprintAndroid")]
    static void BlueprintWorkFlowAndroid() { BuildCmd.BlueprintWorkFlowAndroid(); }

    [MenuItem("BuildHelper/ProcessBlueprintIos")]
    static void BlueprintWorkFlowIos() { BuildCmd.BlueprintWorkFlowIos(); }

    [MenuItem("BuildHelper/ProcessBlueprintWegbl")]
    static void BlueprintWorkFlowWebGL() { BuildCmd.BlueprintWorkFlowWebgl(); }

    [MenuItem("BuildHelper/UploadGoogleAndroid")]
    static void UploadFile() { UploadBuild.UploadGoogleDriveAndroidPlatform(); }

    [MenuItem("BuildHelper/UploadGoogleIos")]
    static void UploadFileIos() { UploadBuild.UploadGoogleDriveIosPlatform(); }

    [MenuItem("BuildHelper/UploadGoogleWebGL")]
    static void UploadFileWebGL() { UploadBuild.UploadGoogleDriveWebGlPlatForm(); }

    [MenuItem("BuildHelper/UploadTelegramWebgl")]
    static void UploadTelegramWebGL() { UploadBuildTelegram.UploadWebGl(); }

    [MenuItem("BuildHelper/Upload CCD")]
    static void UploadCCD() { UnityCCD.ProcessCcd(); }
}