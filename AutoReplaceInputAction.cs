#if UNITY_EDITOR
using System;
using System.IO;
using UnityEngine;
using UnityEditor;
using System.Diagnostics;

namespace RPGMaker.Codebase.Addon.ponApp.VirtualPad
{
    public class AutoReplaceInputAction
    {
        private const string _OriginalFileName = "rpgmaker.inputactions";
        private const string _OriginalSourcePath = "/RPGMaker/InputSystem/";
        private const string _ReplaceFilePath = "/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/";
        private const string _BackUpDestPath = "/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/.BackUp/";

        [InitializeOnLoadMethod]
        private static void Initialize() {
            if (!File.Exists(Application.dataPath + _BackUpDestPath + _OriginalFileName))
                ReplaceCustomAddonManager();
        }

        // カスタムファイルに差し替える
        private static void ReplaceCustomAddonManager() {
            UnityEngine.Debug.Log("Replace Custom ImputActionAsset...");
            try
            {
                if (File.Exists(Application.dataPath + _BackUpDestPath + _OriginalFileName))
                {
                    UnityEngine.Debug.Log("Interrupt Replace Custom ImputActionAsset : Exist backup file.");
                    return;
                }
                if (!Directory.Exists(Application.dataPath + _BackUpDestPath))
                {
                    Directory.CreateDirectory(Application.dataPath + _BackUpDestPath);
                }
                File.Copy(Application.dataPath + _OriginalSourcePath + _OriginalFileName, Application.dataPath + _BackUpDestPath + _OriginalFileName);
                File.Copy(Application.dataPath + _ReplaceFilePath + _OriginalFileName, Application.dataPath + _OriginalSourcePath + _OriginalFileName, true);
                UnityEngine.Debug.Log("Completed replacement!");
                RestartProject();
            }
            catch (Exception e)
            {
                UnityEngine.Debug.Log("Exception error : " + e.Message);
            }
        }

        // オリジナルファイルに戻す
        private static void RevertOriginalInput() {
            UnityEngine.Debug.Log("Revert Original ImputActionAsset...");
            try
            {
                if (!File.Exists(Application.dataPath + _BackUpDestPath + _OriginalFileName))
                {
                    UnityEngine.Debug.LogError("Interrupt Revert Original ImputActionAsset : No backup file.");
                    return;
                }
                File.Copy(Application.dataPath + _BackUpDestPath + _OriginalFileName, Application.dataPath + _OriginalSourcePath + _OriginalFileName, true);
                File.Delete(Application.dataPath + _BackUpDestPath + _OriginalFileName);
                UnityEngine.Debug.Log("Completed reverting!");
                RestartProject();
            }
            catch (Exception e)
            {
                UnityEngine.Debug.Log("Exception error : " + e.Message);
            }
        }

        // Unityプロジェクトを再起動する
        public static void RestartProject() {
            var filename = EditorApplication.applicationPath;
            var arguments = "-projectPath " + Application.dataPath.Replace("/Assets", string.Empty);
            var startInfo = new ProcessStartInfo
            {
                FileName = filename,
                Arguments = arguments,
            };
            Process.Start(startInfo);
            EditorApplication.Exit(0);
        }
    }
}
#endif