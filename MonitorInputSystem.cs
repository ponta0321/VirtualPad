using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using RPGMaker.Codebase.Runtime.Map;
using RPGMaker.Codebase.Runtime.Common;
using RPGMaker.Codebase.Runtime.Common.Enum;
using RPGMaker.Codebase.CoreSystem.Helper;
using UnityEngine.InputSystem;

namespace RPGMaker.Codebase.Addon.ponApp.VirtualPad
{
    public class MonitorInputSystem : MonoBehaviour
    {
        Action _TryToMoveCharacterDelegate;
        Action _TryToMoveVehicleDelegate;
        InputSystemUIInputModule _EventInputModule;
        InputActionAsset _CustomInputAction;

        private void Start() {
            InitTryToMoveMethod();
            InitCustomInputAction();
        }

        private void Update() {
            KillTryToMove();
            SetCustomInputAction();
        }

        private void InitTryToMoveMethod() {
            try
            {
                Type typeMapManager = typeof(MapManager);
                MethodInfo tryToMoveCharacterMethod = typeMapManager.GetMethod("TryToMoveCharacterClick", BindingFlags.NonPublic | BindingFlags.Static);
                MethodInfo tryToMoveVehicleMethod = typeMapManager.GetMethod("TryToMoveVehicleClick", BindingFlags.NonPublic | BindingFlags.Static);
                _TryToMoveCharacterDelegate = (Action) Delegate.CreateDelegate(typeof(Action), null, tryToMoveCharacterMethod);
                _TryToMoveVehicleDelegate = (Action) Delegate.CreateDelegate(typeof(Action), null, tryToMoveVehicleMethod);
            }
            catch (Exception)
            {
                Debug.LogWarning("Warning : InitTryToMoveMethod initialization failed.");
            }
        }

        private void InitCustomInputAction() {
            try
            {
                _CustomInputAction = UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<InputActionAsset>("Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/InputAction/VirtualPadUI.inputactions");
            }
            catch (Exception)
            {
                Debug.LogWarning("Warning : InitCustomInputAction initialization failed.");
            }
        }

        private void KillTryToMove() {
            try
            {
                InputDistributor.RemoveInputHandler(GameStateHandler.GameState.MAP, HandleType.LeftClick, _TryToMoveCharacterDelegate);
                InputDistributor.RemoveInputHandler(GameStateHandler.GameState.MAP, HandleType.LeftClick, _TryToMoveVehicleDelegate);
            }
            catch (Exception)
            {
                //Debug.LogWarning("Warning : KillTryToMove update failed.");
            }
        }

        private void SetCustomInputAction() {
            try
            {
                if (_EventInputModule != null)
                {
                    return;
                }
                _EventInputModule = GameObject.Find("EventSystem").GetComponent<InputSystemUIInputModule>();
                _EventInputModule.actionsAsset = _CustomInputAction;
            }
            catch (Exception)
            {
                //Debug.LogWarning("Warning : SetCustomInputAction update failed.");
            }
        }
    }
}