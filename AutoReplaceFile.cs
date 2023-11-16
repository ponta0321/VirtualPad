#if UNITY_EDITOR
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using System.Diagnostics;

namespace RPGMaker.Codebase.Addon.ponApp.VirtualPad
{
    public class AutoReplaceFile
    {
        private const string _OriginalFileA = "EventSystem.prefab";
        private const string _OriginalFileB = "InputSystem.prefab";
        private const string _OriginalSourcePath = "/RPGMaker/InputSystem/";
        private const string _ReplaceFilePath = "/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Prefabs/";
        private const string _BackUpDestPath = "/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/.BackUp/";

        /*
        [InitializeOnLoadMethod]
        private static void Initialize() {
            if (!File.Exists(Application.dataPath + _BackUpDestPath + _OriginalFileA))
                ReplaceCustomAddonManager();
        }
        */

        // カスタムファイルに差し替える
        [MenuItem("Virtual Pad/Replace Custom SystemPrefabs")]
        private static void ReplaceCustomAddonManager() {
            UnityEngine.Debug.Log("Replace Custom ImputActionAsset...");
            try
            {
                if (File.Exists(Application.dataPath + _BackUpDestPath + _OriginalFileA))
                {
                    UnityEngine.Debug.Log("Interrupt Replace Custom ImputActionAsset : Exist backup file.");
                    return;
                }
                if (!Directory.Exists(Application.dataPath + _BackUpDestPath))
                {
                    Directory.CreateDirectory(Application.dataPath + _BackUpDestPath);
                }
                // FileA
                File.Copy(Application.dataPath + _OriginalSourcePath + _OriginalFileA, Application.dataPath + _BackUpDestPath + _OriginalFileA);
                File.Copy(Application.dataPath + _ReplaceFilePath + _OriginalFileA, Application.dataPath + _OriginalSourcePath + _OriginalFileA, true);
                // FileB
                File.Copy(Application.dataPath + _OriginalSourcePath + _OriginalFileB, Application.dataPath + _BackUpDestPath + _OriginalFileB);
                File.Copy(Application.dataPath + _ReplaceFilePath + _OriginalFileB, Application.dataPath + _OriginalSourcePath + _OriginalFileB, true);
                UnityEngine.Debug.Log("Completed replacement!");
            }
            catch (Exception e)
            {
                UnityEngine.Debug.Log("Exception error : " + e.Message);
            }
        }

        // オリジナルファイルに戻す
        [MenuItem("Virtual Pad/Revert Original SystemPrefabs")]
        private static void RevertOriginalInput() {
            UnityEngine.Debug.Log("Revert Original ImputActionAsset...");
            try
            {
                if (!File.Exists(Application.dataPath + _BackUpDestPath + _OriginalFileA))
                {
                    UnityEngine.Debug.LogError("Interrupt Revert Original ImputActionAsset : No backup file.");
                    return;
                }
                // FileA
                File.Copy(Application.dataPath + _BackUpDestPath + _OriginalFileA, Application.dataPath + _OriginalSourcePath + _OriginalFileA, true);
                File.Delete(Application.dataPath + _BackUpDestPath + _OriginalFileA);
                // FileB
                File.Copy(Application.dataPath + _BackUpDestPath + _OriginalFileB, Application.dataPath + _OriginalSourcePath + _OriginalFileB, true);
                File.Delete(Application.dataPath + _BackUpDestPath + _OriginalFileB);
                UnityEngine.Debug.Log("Completed reverting!");
            }
            catch (Exception e)
            {
                UnityEngine.Debug.Log("Exception error : " + e.Message);
            }
        }
    }
}
#endif