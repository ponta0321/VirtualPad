/*:
 * @addondesc Addition of virtual gamepad function
 * @author ponApp
 * @help A virtual gamepad is displayed on the screen, and by touching the screen you can perform the same operations as using a gamepad.
 * 
 * @param ButtonSize
 * @text Button Size
 * @desc Sets the size of the button.
 * @type integer
 * @default 96
 * 
 * @param ButtonTextSize
 * @text Button Text Size
 * @desc Sets the text to be displayed in the center of the button.
 * @type integer
 * @default 36
 * 
 * @param ButtonPadding
 * @text Button Spacing
 * @desc Sets the distance between buttons.
 * @type integer
 * @default 0
 * 
 * @param CornerPadding
 * @text Distance to the edge of the screen
 * @desc Sets the distance between the edge of the screen and the button.
 * @type integer
 * @default 48
 * 
 * @param NumbeOfButtons
 * @text Number of buttons
 * @desc Set from 2 and 4 buttons.
 * @type select
 * @option 2
 * @option 4
 * @default 2
 * 
 * @param StickMovementRange
 * @text Range of stick button movement
 * @desc Set the range of stick button movement.
 * @type integer
 * @default 50
 * 
 * @param StickButtonImage
 * @text Stick button image
 * @desc Set the full path of the stick button image (png).
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/sbtn.png
 * 
 * @param StickButtonText
 * @text Stick Button Text
 * @desc Set the text to be displayed in the center of the stick button.
 * @type string
 * @default 
 * 
 * @param StickUnderImage
 * @text Stick button bottom image
 * @desc Set the stick button bottom image (png) with full path.
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/sbtn.png
 * 
 * @param ButtonNorthImage
 * @text North button image
 * @desc Set the full path of the north button image (png).
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/ybtn.png
 * 
 * @param ButtonNorthText
 * @text Text of North button
 * @desc Set the text to be displayed in the center of the North button.
 * @type string
 * @default Y
 * 
 * @param ButtonEastImage
 * @text East button image
 * @desc Set the east button image (png) with the full path.
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/rbtn.png
 * 
 * @param ButtonEastText
 * @text Text of East button
 * @desc Set the text to be displayed in the center of the East button.
 * @type string
 * @default B
 * 
 * @param ButtonSouthImage
 * @text South button image
 * @desc Set the south button image (png) with the full path.
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/gbtn.png
 * 
 * @param ButtonSouthText
 * @text Text of South button
 * @desc Set the text to be displayed in the center of the South button.
 * @type string
 * @default A
 * 
 * @param ButtonWestImage
 * @text West button image
 * @desc Set the west button image (png) with the full path.
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/bbtn.png
 * 
 * @param ButtonWestText
 * @text Text of West button
 * @desc Set the text to be displayed in the center of the West button.
 * @type string
 * @default X
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
 * @default 96
 * 
 * @param ButtonTextSize
 * @text ボタンのテキストの大きさ
 * @desc ボタンのテキストの大きさを設定します。
 * @type integer
 * @default 36
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
 * @default 24
 * 
 * @param NumbeOfButtons
 * @text ボタンの数
 * @desc 右側のボタンの数を設定します。
 * @type select
 * @option 2
 * @option 4
 * @default 2
 * 
 * @param StickMovementRange
 * @text スティックボタンの動かせる範囲
 * @desc スティックボタンの動かせる範囲を設定します。
 * @type integer
 * @default 50
 * 
 * @param StickButtonImage
 * @text スティックボタンの画像
 * @desc パッド左側のスティックボタンの画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/sbtn.png
 * 
 * @param StickButtonText
 * @text スティックボタンのテキスト
 * @desc パッド左側のスティックボタンのテキストを設定します。
 * @type string
 * @default 
 * 
 * @param StickUnderImage
 * @text スティックボタンの下側の画像
 * @desc パッド左側のスティックボタンの下側の画像を設定します。
 * @type string
 * @default Assets/RPGMaker/Codebase/Add-ons/ponAppVirtualPad/Sprites/sbtn.png
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
        private int _ButtonSize;
        private int _ButtonTextSize;
        private int _ButtonPadding;
        private int _CornerPadding;
        private int _NumbeOfButtons;
        private int _StickMovementRange;
        private string _StickButtonImage;
        private string _StickButtonText;
        private string _StickUnderImage;
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
            int ButtonTextSize,
            int ButtonPadding,
            int CornerPadding,
            int NumbeOfButtons,
            int StickMovementRange,
            string StickButtonImage,
            string StickButtonText,
            string StickUnderImage,
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
            _ButtonTextSize = ButtonTextSize;
            _ButtonPadding = ButtonPadding;
            _CornerPadding = CornerPadding;
            _NumbeOfButtons = NumbeOfButtons;
            _StickButtonImage = StickButtonImage;
            _StickMovementRange = StickMovementRange;
            if (_StickMovementRange < 5)
            {
                _StickMovementRange = 5;
            }
            else if (_StickMovementRange > 200)
            {
                _StickMovementRange = 200;
            }
            _StickButtonText = StickButtonText;
            _StickUnderImage = StickUnderImage;
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
                var canvasObject = new GameObject("CanvasVirtualPad");
                var canvas = canvasObject.AddComponent<Canvas>();
                RectTransform canvasRectTransform = canvasObject.GetComponent<RectTransform>();
                canvas.renderMode = RenderMode.ScreenSpaceOverlay;
                canvas.sortingOrder = 2000;
                canvasObject.AddComponent<GraphicRaycaster>();
                var font = GetFontInfoFromInputNameCanvas();
                CreateStickButtonObject(canvasRectTransform, font);
                if (_NumbeOfButtons == 0)
                {
                    foreach (var keName in new []{ "ButtonEast", "ButtonSouth" })
                    {
                        CreateButtonObject(keName, canvasRectTransform, font);
                    }
                }
                else
                {
                    foreach (var keName in new[] { "ButtonNorth", "ButtonEast", "ButtonSouth", "ButtonWest" })
                    {
                        CreateButtonObject(keName, canvasRectTransform, font);
                    }
                }
                var canvasScaler = canvasObject.AddComponent<CanvasScaler>();
                canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
                canvasScaler.referenceResolution = new Vector2(1080, 1080);
                canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.Expand;
                canvasObject.AddComponent<MonitorInputSystem>();
                DontDestroyOnLoad(canvasObject);
            }
            catch (Exception)
            {
                Debug.LogWarning("Warning : Failed to create Virtual Pad");
            }
        }
        private void CreateStickButtonObject(
            RectTransform rootTransform,
            Font font
        ) {
            try
            {

                var underObj = new GameObject("StickButton");
                underObj.transform.SetParent(rootTransform);
                RectTransform underObjRectTransform = underObj.AddComponent<RectTransform>();
                float StickSize = _ButtonSize * (100 + _StickMovementRange * 2) / 100;
                underObjRectTransform.sizeDelta = new Vector2(StickSize, StickSize);

                if (_NumbeOfButtons == 0)
                {
                    underObjRectTransform.anchoredPosition = new Vector2(
                        (_ButtonSize * 2 + _ButtonPadding - StickSize) / 2 + _CornerPadding,
                        (_ButtonSize * 2 + _ButtonPadding - StickSize) / 2 + _CornerPadding
                    );
                }
                else
                {
                    underObjRectTransform.anchoredPosition = new Vector2(
                        (_ButtonSize * 3 + _ButtonPadding * 2 - StickSize) / 2 + _CornerPadding,
                        (_ButtonSize * 3 + _ButtonPadding * 2 - StickSize) / 2 + _CornerPadding
                    );
                }
                underObjRectTransform.anchorMin = new Vector2(0, 0);
                underObjRectTransform.anchorMax = new Vector2(0, 0);
                underObjRectTransform.pivot = new Vector2(0, 0);
                var underObjImage = underObj.AddComponent<Image>();
                if (!string.IsNullOrEmpty(_StickUnderImage))
                {
                    underObjImage.sprite = UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_StickUnderImage);
                }
                underObjImage.color = new Color(0, 0, 0, 0.5f);

                var obj = new GameObject("StickButton");
                obj.transform.SetParent(underObjRectTransform);
                RectTransform rectTransform = obj.AddComponent<RectTransform>();
                rectTransform.sizeDelta = new Vector2(_ButtonSize, _ButtonSize);
                rectTransform.anchoredPosition = new Vector2(0, 0);
                var onScreenStick = obj.AddComponent<OnScreenStick>();
                onScreenStick.controlPath = "<Gamepad>/leftStick";
                onScreenStick.movementRange = _StickMovementRange;
                Vector2 anchorMin;
                Vector2 anchorMax;
                Vector2 pivot;
                anchorMin = new Vector2(0.5f, 0.5f);
                anchorMax = new Vector2(0.5f, 0.5f);
                pivot = new Vector2(0.5f, 0.5f);
                rectTransform.anchorMin = anchorMin;
                rectTransform.anchorMax = anchorMax;
                rectTransform.pivot = pivot;
                var button = obj.AddComponent<Button>();
                Navigation navigation = button.navigation;
                navigation.mode = Navigation.Mode.None;
                button.navigation = navigation;
                var image = obj.AddComponent<Image>();
                if (!string.IsNullOrEmpty(_StickButtonImage))
                {
                    image.sprite = UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_StickButtonImage);
                }
                image.raycastTarget = true;
                button.targetGraphic = image;
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
                txtObjText.fontSize = _ButtonTextSize;
                txtObjText.color = Color.black;
                txtObjText.text = _StickButtonText;
                txtObjText.alignment = TextAnchor.MiddleCenter;
            }
            catch (Exception)
            {
                Debug.LogWarning("Warning : Failed to create Button Object");
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
                    case "ButtonNorth":
                        rectTransform.anchoredPosition = new Vector2(
                            (_ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding) * -1,
                            _ButtonSize * 2 + _ButtonPadding * 2 + _CornerPadding
                        );
                        controlPath = "<Gamepad>/buttonNorth";
                        sprite = string.IsNullOrEmpty(_ButtonNorthImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonNorthImage);
                        text = _ButtonNorthText;
                        break;
                    case "ButtonEast":
                        rectTransform.anchoredPosition = new Vector2(
                            (_ButtonSize * 0 + _ButtonPadding * 0 + _CornerPadding) * -1,
                            _ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding
                        );
                        controlPath = "<Gamepad>/buttonEast";
                        sprite = string.IsNullOrEmpty(_ButtonEastImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonEastImage);
                        text = _ButtonEastText;
                        break;
                    case "ButtonSouth":
                        rectTransform.anchoredPosition = new Vector2(
                            (_ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding) * -1,
                            _ButtonSize * 0 + _ButtonPadding * 0 + _CornerPadding
                        );
                        controlPath = "<Gamepad>/buttonSouth";
                        sprite = string.IsNullOrEmpty(_ButtonSouthImage) ? null : UnityEditorWrapper.AssetDatabaseWrapper.LoadAssetAtPath<Sprite>(_ButtonSouthImage);
                        text = _ButtonSouthText;
                        break;
                    case "ButtonWest":
                        rectTransform.anchoredPosition = new Vector2(
                            (_ButtonSize * 2 + _ButtonPadding * 2 + _CornerPadding) * -1,
                            _ButtonSize * 1 + _ButtonPadding * 1 + _CornerPadding
                        );
                        controlPath = "<Gamepad>/buttonWest";
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

                var button = obj.AddComponent<Button>();
                Navigation navigation = button.navigation;
                navigation.mode = Navigation.Mode.None;
                button.navigation = navigation;

                var image = obj.AddComponent<Image>();
                image.sprite = sprite;
                image.raycastTarget = true;
                if (!string.IsNullOrEmpty(controlPath))
                {
                    var onScreenButton = obj.AddComponent<OnScreenButton>();
                    onScreenButton.controlPath = controlPath;
                }
                button.targetGraphic = image;

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
                txtObjText.fontSize = _ButtonTextSize;
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
            catch (Exception)
            {
                return null;
            }
        }
    }
}