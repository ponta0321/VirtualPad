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

        private void Start() {
            InitTryToMoveMethod();
        }

        private void Update() {
            KillTryToMove();
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
    }
}