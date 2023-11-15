using System;
using System.Reflection;
using UnityEngine;
using RPGMaker.Codebase.Runtime.Map;
using RPGMaker.Codebase.Runtime.Common;
using RPGMaker.Codebase.Runtime.Common.Enum;

namespace RPGMaker.Codebase.Addon.ponApp.VirtualPad
{
    public class KillTryToMove : MonoBehaviour
    {
        Action TryToMoveCharacterDelegate;
        Action TryToMoveVehicleDelegate;

        private void Start() {
            try
            {
                Type typeMapManager = typeof(MapManager);
                MethodInfo tryToMoveCharacterMethod = typeMapManager.GetMethod("TryToMoveCharacterClick", BindingFlags.NonPublic | BindingFlags.Static);
                MethodInfo tryToMoveVehicleMethod = typeMapManager.GetMethod("TryToMoveVehicleClick", BindingFlags.NonPublic | BindingFlags.Static);
                TryToMoveCharacterDelegate = (Action) Delegate.CreateDelegate(typeof(Action), null, tryToMoveCharacterMethod);
                TryToMoveVehicleDelegate = (Action) Delegate.CreateDelegate(typeof(Action), null, tryToMoveVehicleMethod);
            }
            catch (Exception)
            {
                Debug.LogWarning("Warning : KillTryToMove initialization failed.");
            }
        }

        private void Update() {
            try
            {
                InputDistributor.RemoveInputHandler(GameStateHandler.GameState.MAP, HandleType.LeftClick, TryToMoveCharacterDelegate);
                InputDistributor.RemoveInputHandler(GameStateHandler.GameState.MAP, HandleType.LeftClick, TryToMoveVehicleDelegate);
            }
            catch (Exception)
            {
                //Debug.LogWarning("Warning : KillTryToMove update failed.");
            }
        }
    }
}