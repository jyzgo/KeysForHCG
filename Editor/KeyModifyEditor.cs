#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;
using Facebook.Unity.Settings;

class KeyModifyEditor : IPreprocessBuildWithReport
{
    public int callbackOrder { get { return 0; } }
    public void OnPreprocessBuild(BuildReport report)
    {
        //FacebookSettings fbsetting = Resources.Load<FacebookSettings>("FacebookSettings");
        //Debug.Log("fb s " + fbsetting.)
        //Debug.Log("MyCustomBuildProcessor.OnPreprocessBuild for target " + report.summary.platform + " at path " + report.summary.outputPath);
        var appID = FacebookSettings.AppId;
        Debug.Log("Apppp id " + FacebookSettings.AppId);
        if(KeyBase.FACEBOOK_APP_ID != FacebookSettings.AppId)
        {
            Debug.LogError("Facebook app id is different ");
        }

        if(KeyBase.BUNDLE_ID != Application.identifier)
        {
            Debug.LogError("Bundle id is different");
        }
    }
}
#endif
