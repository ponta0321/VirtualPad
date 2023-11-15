/*:
 * @addondesc Addition of virtual gamepad function
 * @author ponApp
 * @help A virtual gamepad is displayed on the screen, and by touching the screen you can perform the same operations as using a gamepad.
 * 
 */

/*:ja
 * @addondesc バーチャルゲームパッド機能の追加
 * @author ponApp
 * @help 画面上にバーチャルゲームパッドを表示し、画面タッチでゲームパッドの操作と同程度の操作を実現します。
 * 
 * @param ButtonSize
 * @text ボタンの大きさ
 * @desc ボタンの大きさを設定します。
 * @type integer
 * @default 50
 * 
 * @param ButtonPadding
 * @text ボタンの間隔
 * @desc 各ボタン間の間隔の大きさを設定します。
 * @type integer
 * @default 0
 * 
 * @param CornerPadding
 * @text 画面端までの間隔
 * @desc ボタンから画面端までの間隔の大きさを設定します。
 * @type integer
 * @default 10
 * 
 * @param ButtonUpImage
 * @text 上ボタンの画像
 * @desc パッド左側の上ボタンの画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/sbtn.png
 * 
 * @param ButtonUpText
 * @text 上ボタンのテキスト
 * @desc パッド左側の上ボタンのテキストを設定します。
 * @type string
 * @default ↑
 * 
 * @param ButtonRightImage
 * @text 右ボタンの画像
 * @desc パッド左側の右ボタンの画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/sbtn.png
 * 
 * @param ButtonRightText
 * @text 右ボタンのテキスト
 * @desc パッド左側の右ボタンのテキストを設定します。
 * @type string
 * @default →
 * 
 * @param ButtonDownImage
 * @text 下ボタンの画像
 * @desc パッド左側の下ボタンの画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/sbtn.png
 * 
 * @param ButtonDownText
 * @text 下ボタンのテキスト
 * @desc パッド左側の下ボタンのテキストを設定します。
 * @type string
 * @default ↓
 * 
 * @param ButtonLeftImage
 * @text 左ボタンの画像
 * @desc パッド左側の左ボタンの画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/sbtn.png
 * 
 * @param ButtonLeftText
 * @text 左ボタンのテキスト
 * @desc パッド左側の左ボタンのテキストを設定します。
 * @type string
 * @default ←
 * 
 * @param ButtonNorthImage
 * @text 北ボタンの画像
 * @desc パッド右側の北ボタンの画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/ybtn.png
 * 
 * @param ButtonNorthText
 * @text 北ボタンのテキスト
 * @desc パッド右側の北ボタンのテキストを設定します。
 * @type string
 * @default Y
 * 
 * @param ButtonEastImage
 * @text 東ボタンの画像
 * @desc パッド右側の東ボタンの画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/rbtn.png
 * 
 * @param ButtonEastText
 * @text 東ボタンのテキスト
 * @desc パッド右側の東ボタンのテキストを設定します。
 * @type string
 * @default B
 * 
 * @param ButtonSouthImage
 * @text 南ボタンの画像
 * @desc パッド右側の南ボタンの画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/gbtn.png
 * 
 * @param ButtonSouthText
 * @text 南ボタンのテキスト
 * @desc パッド右側の南ボタンのテキストを設定します。
 * @type string
 * @default A
 * 
 * @param ButtonWestImage
 * @text 西ボタンの画像
 * @desc パッド右側の西ボタンの画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/bbtn.png
 * 
 * @param ButtonWestText
 * @text 西ボタンのテキスト
 * @desc パッド右側の西ボタンのテキストを設定します。
 * @type string
 * @default X
 * 
 */

using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem.OnScreen;
using RPGMaker.Codebase.CoreSystem.Helper;
using RPGMaker.Codebase.Addon.ponApp.VirtualPad;

namespace RPGMaker.Codebase.Addon
{
    public class ponAppVirtualPad : MonoBehaviour
    {
        private enum Direction
        {
            North,
            East,
            South,
            West
        }

        private int _ButtonSize;
        private int _ButtonPadding;
        private int _CornerPadding;
        private string _ButtonUpImage;
        private string _ButtonUpText;
        private string _ButtonRightImage;
        private string _ButtonRightText;
        private string _ButtonDownImage;
        private string _ButtonDownText;
        private string _ButtonLeftImage;
        private string _ButtonLeftText;
        private string _ButtonNorthImage;
        private string _ButtonNorthText;
        private string _ButtonEastImage;
        private string _ButtonEastText;
        private string _ButtonSouthImage;
        private string _ButtonSouthText;
        private string _ButtonWestImage;
        private string _ButtonWestText;

        public ponAppVirtualPad(
            int ButtonSize,
            int ButtonPadding,
            int CornerPadding,
            string ButtonUpImage,
            string ButtonUpText,
            string ButtonRightImage,
            string ButtonRightText,
            string ButtonDownImage,
            string ButtonDownText,
            string ButtonLeftImage,
            string ButtonLeftText,
            string ButtonNorthImage,
            string ButtonNorthText,
            string ButtonEastImage,
            string ButtonEastText,
            string ButtonSouthImage,
            string ButtonSouthText,
            string ButtonWestImage,
            string ButtonWestText
        ) {
            _ButtonSize = ButtonSize;
            _ButtonPadding = ButtonPadding;
            _CornerPadding = CornerPadding;
            _ButtonUpImage = ButtonUpImage;
            _ButtonUpText = ButtonUpText;
            _ButtonRightImage = ButtonRightImage;
            _ButtonRightText = ButtonRightText;
            _ButtonDownImage = ButtonDownImage;
            _ButtonDownText = ButtonDownText;
            _ButtonLeftImage = ButtonLeftImage;
            _ButtonLeftText = ButtonLeftText;
            _ButtonNorthImage = ButtonNorthImage;
            _ButtonNorthText = ButtonNorthText;
            _ButtonEastImage = ButtonEastImage;
            _ButtonEastText = ButtonEastText;
            _ButtonSouthImage = ButtonSouthImage;
            _ButtonSouthText = ButtonSouthText;
            _ButtonWestImage = ButtonWestImage;
            _ButtonWestText = ButtonWestText;

#if UNITY_EDITOR
        EditorApplication.playModeStateChanged +=
                    OnPlayModeStateChanged;
#else
            CreateVirtualPad();
#endif
        }
#if UNITY_EDITOR
        private void OnPlayModeStateChanged(PlayModeStateChange state) {
            if (state == PlayModeStateChange.EnteredPlayMode)
            {
                CreateVirtualPad();
            }
        }
#endif
        private void CreateVirtualPad() {
            try
            {
                // 新しいCanvasの作成
                var canvasObject = new GameObject("CanvasVirtualPad");
                var canvas = canvasObject.AddComponent<Canvas>();
                RectTransform canvasRectTransform = canvasObject.GetComponent<RectTransform>();
                //canvasRectTransform.SetParent(root.transform);
                canvas.renderMode = RenderMode.ScreenSpaceOverlay;
                canvas.sortingOrder = 2000;
                canvasObject.AddComponent<GraphicRaycaster>();
                var font = GetFontInfoFromInputNameCanvas();
                 string [] keyNames = {
                    "ButtonUp",
                    "ButtonRight",
                    "ButtonDown", 
                    "ButtonLeft", 
                    "ButtonNorth", 
                    "ButtonEast", 
                    "ButtonSouth", 
                    "ButtonWest"
                };
                foreach (var keName in keyNames)
                {
                    CreateButtonObject(
                        keName,
                        canvasRectTransform,
                        font
                    );
                }
                var canvasScaler = canvasObject.AddComponent<CanvasScaler>();
                canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                canvasScaler.referenceResolution = new Vector2(1920, 1080);
                canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;

                canvasObject.AddComponent<KillTryToMove>();
                DontDestroyOnLoad(canvasObject);
            }
            catch (Exception)
            {
                Debug.LogWarning("Warning : Failed to create Virtual Pad");
            }
        }
        private void CreateButtonObject(
            string name, 
            RectTransform rootTransform,
            Font font
        ) {
            try
            {
                var obj = new GameObject(name);
                obj.transform.SetParent(rootTransform);
                RectTransform rectTransform = obj.AddComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(_ButtonSize, _ButtonSize);
                bool IsLeftSide = false;
                string controlPath = "";
                Sprite sprite = null;
                string text = "";
                switch (name)
                {
                    case "ButtonUp":
                        IsLeftSide = true;
                        rectTransform.anchoredPosition = new Vector2(
                            _ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding,
                            _ButtonSize * 2 + _ButtonPadding * 2 + _CornerPadding
                        );
                        controlPath = "<Keyboard>/UpArrow";
                        sprite = string.IsNullOrEmpty(_ButtonUpImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonUpImage);
                        text = _ButtonUpText;
                        break;
                    case "ButtonRight":
                        IsLeftSide = true;
                        rectTransform.anchoredPosition = new Vector2(
                            _ButtonSize * 2 + _ButtonPadding * 2 + _CornerPadding,
                            _ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding
                        );
                        controlPath = "<Keyboard>/RightArrow";
                        sprite = string.IsNullOrEmpty(_ButtonRightImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonRightImage);
                        text = _ButtonRightText;
                        break;
                    case "ButtonDown":
                        IsLeftSide = true;
                        rectTransform.anchoredPosition = new Vector2(
                            _ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding,
                            _ButtonSize * 0 + _ButtonPadding * 0 + _CornerPadding
                        );
                        controlPath = "<Keyboard>/DownArrow";
                        sprite = string.IsNullOrEmpty(_ButtonDownImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonDownImage);
                        text = _ButtonDownText;
                        break;
                    case "ButtonLeft":
                        IsLeftSide = true;
                        rectTransform.anchoredPosition = new Vector2(
                            _ButtonSize * 0 + _ButtonPadding * 0 + _CornerPadding,
                            _ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding
                        );
                        controlPath = "<Keyboard>/LeftArrow";
                        sprite = string.IsNullOrEmpty(_ButtonLeftImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonLeftImage);
                        text = _ButtonLeftText;
                        break;
                    case "ButtonNorth":
                        rectTransform.anchoredPosition = new Vector2(
                            (_ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding) * -1,
                            _ButtonSize * 2 + _ButtonPadding * 2 + _CornerPadding
                        );
                        controlPath = "<Keyboard>/Escape";
                        sprite = string.IsNullOrEmpty(_ButtonNorthImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonNorthImage);
                        text = _ButtonNorthText;
                        break;
                    case "ButtonEast":
                        rectTransform.anchoredPosition = new Vector2(
                            (_ButtonSize * 0 + _ButtonPadding * 0 + _CornerPadding) * -1,
                            _ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding
                        );
                        controlPath = "<Keyboard>/Escape";
                        sprite = string.IsNullOrEmpty(_ButtonEastImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonEastImage);
                        text = _ButtonEastText;
                        break;
                    case "ButtonSouth":
                        rectTransform.anchoredPosition = new Vector2(
                            (_ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding) * -1,
                            _ButtonSize * 0 + _ButtonPadding * 0 + _CornerPadding
                        );
                        controlPath = "<Keyboard>/Enter";
                        sprite = string.IsNullOrEmpty(_ButtonSouthImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonSouthImage);
                        text = _ButtonSouthText;
                        break;
                    case "ButtonWest":
                        rectTransform.anchoredPosition = new Vector2(
                            (_ButtonSize * 2 + _ButtonPadding * 2 + _CornerPadding) * -1,
                            _ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding
                        );
                        controlPath = "<Keyboard>/Shift";
                        sprite = string.IsNullOrEmpty(_ButtonWestImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonWestImage);
                        text = _ButtonWestText;
                        break;
                    default:
                        rectTransform.anchoredPosition = new Vector2(0, 0);
                        break;
                }
                Vector2 anchorMin;
                Vector2 anchorMax;
                Vector2 pivot;
                if (IsLeftSide == true)
                {
                    anchorMin = new Vector2(0, 0);
                    anchorMax = new Vector2(0, 0);
                    pivot = new Vector2(0, 0);
                }
                else
                {
                    anchorMin = new Vector2(1, 0);
                    anchorMax = new Vector2(1, 0);
                    pivot = new Vector2(1, 0);
                }
                rectTransform.anchorMin = anchorMin;
                rectTransform.anchorMax = anchorMax;
                rectTransform.pivot = pivot;

                var image = obj.AddComponent<Image>();
                image.sprite = sprite;
                image.raycastTarget = true;
                if (!string.IsNullOrEmpty(controlPath))
                {
                    var onScreenButton = obj.AddComponent<OnScreenButton>();
                    onScreenButton.controlPath = controlPath;
                }

                var txtObj = new GameObject("Text");
                RectTransform txtObjRectTransform = txtObj.AddComponent<RectTransform>();
                txtObjRectTransform.sizeDelta = new Vector2(_ButtonSize, _ButtonSize);
                txtObjRectTransform.anchorMin = anchorMin;
                txtObjRectTransform.anchorMax = anchorMax;
                txtObjRectTransform.pivot = pivot;
                txtObj.transform.SetParent(rectTransform);
                txtObjRectTransform.localPosition = new Vector3(0, 0, 0);
                var txtObjText = txtObj.AddComponent<Text>();
                txtObjText.font = font;
                txtObjText.fontSize = 24;
                txtObjText.color = Color.black;
                txtObjText.text = text;
                txtObjText.alignment = TextAnchor.MiddleCenter;
            }
            catch (Exception)
            {
                Debug.LogWarning("Warning : Failed to create Button Object");
            }
        }

        // InputNameCanvasで使用されているFontを取得する
        private Font GetFontInfoFromInputNameCanvas() {
            string path = "Assets/RPGMaker/Codebase/Runtime/Map/Asset/Prefab/InputNameCanvas.prefab";
            var prefab = UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<GameObject>(path);
            if (prefab == null)
            {
                return null;
            }
            try
            {
                Transform font = prefab.transform.Find("DisplayFrame ")
                    .Find("OutputField")
                    .Find("Text 1");
                if (font == null)
                {
                    font = prefab.transform.Find("DisplayFrame")
                        .Find("OutputField")
                        .Find("Text 1");
                }
                return font.GetComponent<Text>().font;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}