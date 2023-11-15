#if UNITY_EDITOR
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.AddressableAssets;
using UnityEditor.AddressableAssets.Settings;
using UnityEditor.AddressableAssets.Settings.GroupSchemas;

namespace RPGMaker.Codebase.Addon.ponApp.VirtualPad
{
    public class AutoSetAssetData
    {
        private static AddressableAssetSettings _settings;

        [InitializeOnLoadMethod]
        private static void Initialize() {
            SetAssetAddressProcess();
        }

        // アセットをアドレス登録する
        private static bool SetAssetAddressProcess() {
            AssetDatabase.StartAssetEditing();
            bool isFirstCreate = false;
            if (!Directory.Exists("Assets/AddressableAssetsData"))
            {
                _settings = AddressableAssetSettings.Create("Assets/AddressableAssetsData", "AddressableAssetSettings", true, true);
                isFirstCreate = true;
            }
            else
                _settings = AssetDatabase.LoadAssetAtPath<AddressableAssetSettings>("Assets/AddressableAssetsData/AddressableAssetSettings.asset");
            if (_settings == null)
            {
                AssetDatabase.StopAssetEditing();
                return false;
            }
            AddressableAssetSettingsDefaultObject.Settings = _settings;
            string[] pathAdd =
            {
                "Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites"
            };
            string[] extensionAdd =
            {
                "*.png"
            };
            bool result = true;
            for (var i = 0; i < pathAdd.Length; i++)
            {
                if (!System.IO.Directory.Exists(pathAdd[i])) continue;
                try
                {
                    var data_path = Directory.GetFiles(pathAdd[i], extensionAdd[i]);
                    for (var i2 = 0; i2 < data_path.Length; i2++)
                    {
                        string path = data_path[i2].Replace("\\", "/");
                        int start = path.LastIndexOf("/", path.LastIndexOf("/") - 1) + 1;
                        string pathName = path.Substring(start);
                        AddressableAssetGroup targetParent;
                        targetParent = GetOrCreateGroup("ponapptddungeon");
                        if (!SetAddressToAsset(path, pathName, targetParent)) result = false;
                    }
                }
                catch (IOException)
                {
                    result = false;
                }
            }
            if (isFirstCreate)
                GetOrCreateGroup("Asset_end");

            AssetDatabase.StopAssetEditing();
            return result;
        }

        // 指定された名前のグループを取得もしくは作成します
        private static AddressableAssetGroup GetOrCreateGroup(string groupName) {
            var groups = _settings.groups;
            AddressableAssetGroup group = null;
            for (int i = 0; i < groups.Count; i++)
                if (groups[i].name == groupName)
                {
                    group = groups[i];
                    break;
                }

            // 既に指定された名前のグループが存在する場合は
            // そのグループを返します
            if (group != null) return group;

            // Content Packing & Loading
            var bunlAssetGroupSchema = ScriptableObject.CreateInstance<BundledAssetGroupSchema>();
            bunlAssetGroupSchema.BundleMode = BundledAssetGroupSchema.BundlePackingMode.PackSeparately;

            // Content Update Restriction
            var contentUpdateGroupSchema = ScriptableObject.CreateInstance<ContentUpdateGroupSchema>();

            // AddressableAssetGroup の Inspector に表示されている Schema
            var schemas = new List<AddressableAssetGroupSchema>
                {
                    bunlAssetGroupSchema,
                    contentUpdateGroupSchema
                };

            // 指定された名前のグループを作成して返します
            return _settings.CreateGroup(groupName, false, false,
                true, schemas);
        }

        // 指定されたアセットにアドレスを割り当ててグループに追加します
        private static bool SetAddressToAsset(string path, string pathName, AddressableAssetGroup targetParent) {
            var guid = AssetDatabase.AssetPathToGUID(path);
            if (guid == "")
            {
                AssetDatabase.Refresh();
                guid = AssetDatabase.AssetPathToGUID(path);
            }

            var entry = _settings.FindAssetEntry(guid);

            if (entry != null)
                // すでに同じアドレスかグループが設定されている場合処理をスキップします
                if (entry.address == pathName || entry.parentGroup == targetParent)
                    return true;

            // アセットをグループに追加します
            entry = _settings.CreateOrMoveEntry(guid, targetParent);
            if (entry == null)
            {
                Debug.LogError("[AddressableUtils] Failed AddressableAssetSettings.CreateOrMoveEntry.\n" + path);
                return false;
            }

            // アセットにアドレスを割り当てます
            entry.SetAddress(pathName);
            return true;
        }
    }
}
#endif