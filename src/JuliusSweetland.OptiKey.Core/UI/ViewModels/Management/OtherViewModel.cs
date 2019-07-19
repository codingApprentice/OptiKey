// Copyright (c) 2019 OPTIKEY LTD (UK company number 11854839) - All Rights Reserved
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using JuliusSweetland.OptiKey.Properties;
using log4net;
using Prism.Mvvm;

namespace JuliusSweetland.OptiKey.UI.ViewModels.Management
{
    public class OtherViewModel : BindableBase
    {
        #region Private Member Vars

        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        
        #region Ctor

        public OtherViewModel()
        {
            Load();
        }
        
        #endregion
        
        #region Properties

        public List<string> ColourNames
        {
            get
            {
                // Based on: https://stackoverflow.com/a/26287682/9091159
                return typeof(Brushes)
                    .GetProperties()
                    .Where(pi => pi.PropertyType == typeof(SolidColorBrush))
                    .Select(pi => pi.Name)
                    .ToList();
            }
        }

        private bool showSplashScreen;
        public bool ShowSplashScreen
        {
            get { return showSplashScreen; }
            set { SetProperty(ref showSplashScreen, value); }
        }

        private bool checkForUpdates;
        public bool CheckForUpdates
        {
            get { return checkForUpdates; }
            set { SetProperty(ref checkForUpdates, value); }
        }

        private bool publishVirtualKeyCodesForCharacters;
        public bool PublishVirtualKeyCodesForCharacters
        {
            get { return publishVirtualKeyCodesForCharacters; }
            set { SetProperty(ref publishVirtualKeyCodesForCharacters, value); }
        }

        private bool suppressModifierKeysForAllMouseActions;
        public bool SuppressModifierKeysForAllMouseActions
        {
            get { return suppressModifierKeysForAllMouseActions; }
            set { SetProperty(ref suppressModifierKeysForAllMouseActions, value); }
        }

        private bool suppressModifierKeysWhenInMouseKeyboard;
        public bool SuppressModifierKeysWhenInMouseKeyboard
        {
            get { return suppressModifierKeysWhenInMouseKeyboard; }
            set { SetProperty(ref suppressModifierKeysWhenInMouseKeyboard, value); }
        }

        private bool magnifySuppressedForScrollingActions;
        public bool MagnifySuppressedForScrollingActions
        {
            get { return magnifySuppressedForScrollingActions; }
            set { SetProperty(ref magnifySuppressedForScrollingActions, value); }
        }

        private bool debug;
        public bool Debug
        {
            get { return debug; }
            set { SetProperty(ref debug, value); }
        }

        private bool lookToScrollEnabled;
        public bool LookToScrollEnabled
        {
            get { return lookToScrollEnabled; }
            set { SetProperty(ref lookToScrollEnabled, value); }
        }

        private bool lookToScrollDirectionInverted;
        public bool LookToScrollDirectionInverted
        {
            get { return lookToScrollDirectionInverted; }
            set { SetProperty(ref lookToScrollDirectionInverted, value); }
        }

        private bool lookToScrollLockDownBoundsKey;
        public bool LookToScrollLockDownBoundsKey
        {
            get { return lookToScrollLockDownBoundsKey; }
            set { SetProperty(ref lookToScrollLockDownBoundsKey, value); }
        }

        private bool lookToScrollCentreMouseWhenActivated;
        public bool LookToScrollCentreMouseWhenActivated
        {
            get { return lookToScrollCentreMouseWhenActivated; }
            set { SetProperty(ref lookToScrollCentreMouseWhenActivated, value); }
        }

        private bool lookToScrollBringWindowToFrontWhenActivated;
        public bool LookToScrollBringWindowToFrontWhenActivated
        {
            get { return lookToScrollBringWindowToFrontWhenActivated; }
            set { SetProperty(ref lookToScrollBringWindowToFrontWhenActivated, value); }
        }

        private bool lookToScrollBringWindowToFrontAfterChoosingScreenPoint;
        public bool LookToScrollBringWindowToFrontAfterChoosingScreenPoint
        {
            get { return lookToScrollBringWindowToFrontAfterChoosingScreenPoint; }
            set { SetProperty(ref lookToScrollBringWindowToFrontAfterChoosingScreenPoint, value); }
        }

        private bool lookToScrollSuspendBeforeChoosingPointForMouse;
        public bool LookToScrollSuspendBeforeChoosingPointForMouse
        {
            get { return lookToScrollSuspendBeforeChoosingPointForMouse; }
            set { SetProperty(ref lookToScrollSuspendBeforeChoosingPointForMouse, value); }
        }

        private bool lookToScrollResumeAfterChoosingPointForMouse;
        public bool LookToScrollResumeAfterChoosingPointForMouse
        {
            get { return lookToScrollResumeAfterChoosingPointForMouse; }
            set { SetProperty(ref lookToScrollResumeAfterChoosingPointForMouse, value); }
        }

        private bool lookToScrollDeactivateUponSwitchingKeyboards;
        public bool LookToScrollDeactivateUponSwitchingKeyboards
        {
            get { return lookToScrollDeactivateUponSwitchingKeyboards; }
            set { SetProperty(ref lookToScrollDeactivateUponSwitchingKeyboards, value); }
        }

        private bool lookToScrollShowOverlayWindow;
        public bool LookToScrollShowOverlayWindow
        {
            get { return lookToScrollShowOverlayWindow; }
            set { SetProperty(ref lookToScrollShowOverlayWindow, value); }
        }

        private string lookToScrollOverlayBoundsColour;
        public string LookToScrollOverlayBoundsColour
        {
            get { return lookToScrollOverlayBoundsColour; }
            set { SetProperty(ref lookToScrollOverlayBoundsColour, value); }
        }

        private string lookToScrollOverlayDeadzoneColour;
        public string LookToScrollOverlayDeadzoneColour
        {
            get { return lookToScrollOverlayDeadzoneColour; }
            set { SetProperty(ref lookToScrollOverlayDeadzoneColour, value); }
        }

        private int lookToScrollOverlayBoundsThickness;
        public int LookToScrollOverlayBoundsThickness
        {
            get { return lookToScrollOverlayBoundsThickness; }
            set { SetProperty(ref lookToScrollOverlayBoundsThickness, value); }
        }

        private int lookToScrollOverlayDeadzoneThickness;
        public int LookToScrollOverlayDeadzoneThickness
        {
            get { return lookToScrollOverlayDeadzoneThickness; }
            set { SetProperty(ref lookToScrollOverlayDeadzoneThickness, value); }
        }

        private int lookToScrollHorizontalDeadzone;
        public int LookToScrollHorizontalDeadzone
        {
            get { return lookToScrollHorizontalDeadzone; }
            set { SetProperty(ref lookToScrollHorizontalDeadzone, value); }
        }

        private int lookToScrollVerticalDeadzone;
        public int LookToScrollVerticalDeadzone
        {
            get { return lookToScrollVerticalDeadzone; }
            set { SetProperty(ref lookToScrollVerticalDeadzone, value); }
        }

        private string lookToScrollIncrementChoices;
        public string LookToScrollIncrementChoices
        {
            get { return lookToScrollIncrementChoices; }
            set { SetProperty(ref lookToScrollIncrementChoices, value); }
        }

        private decimal lookToScrollBaseSpeedSlow;
        public decimal LookToScrollBaseSpeedSlow
        {
            get { return lookToScrollBaseSpeedSlow; }
            set { SetProperty(ref lookToScrollBaseSpeedSlow, value); }
        }

        private decimal lookToScrollBaseSpeedMedium;
        public decimal LookToScrollBaseSpeedMedium
        {
            get { return lookToScrollBaseSpeedMedium; }
            set { SetProperty(ref lookToScrollBaseSpeedMedium, value); }
        }

        private decimal lookToScrollBaseSpeedFast;
        public decimal LookToScrollBaseSpeedFast
        {
            get { return lookToScrollBaseSpeedFast; }
            set { SetProperty(ref lookToScrollBaseSpeedFast, value); }
        }

        private decimal lookToScrollAccelerationSlow;
        public decimal LookToScrollAccelerationSlow
        {
            get { return lookToScrollAccelerationSlow; }
            set { SetProperty(ref lookToScrollAccelerationSlow, value); }
        }

        private decimal lookToScrollAccelerationMedium;
        public decimal LookToScrollAccelerationMedium
        {
            get { return lookToScrollAccelerationMedium; }
            set { SetProperty(ref lookToScrollAccelerationMedium, value); }
        }

        private decimal lookToScrollAccelerationFast;
        public decimal LookToScrollAccelerationFast
        {
            get { return lookToScrollAccelerationFast; }
            set { SetProperty(ref lookToScrollAccelerationFast, value); }
        }

        public bool ChangesRequireRestart
        {
            get
            {
                return (
                    Settings.Default.Debug != Debug || 
                    Settings.Default.LookToScrollEnabled != LookToScrollEnabled ||
                    (LookToScrollEnabled && Settings.Default.LookToScrollShowOverlayWindow != LookToScrollShowOverlayWindow)
                );
            }
        }
        
        #endregion
        
        #region Methods

        private void Load()
        {
            ShowSplashScreen = Settings.Default.ShowSplashScreen;
            CheckForUpdates = Settings.Default.CheckForUpdates;
            PublishVirtualKeyCodesForCharacters = Settings.Default.PublishVirtualKeyCodesForCharacters;
            SuppressModifierKeysForAllMouseActions = Settings.Default.SuppressModifierKeysForAllMouseActions;
            SuppressModifierKeysWhenInMouseKeyboard = Settings.Default.SuppressModifierKeysWhenInMouseKeyboard;
            MagnifySuppressedForScrollingActions = Settings.Default.MagnifySuppressedForScrollingActions;
            Debug = Settings.Default.Debug;
            LookToScrollEnabled = Settings.Default.LookToScrollEnabled;
            LookToScrollDirectionInverted = Settings.Default.LookToScrollDirectionInverted;
            LookToScrollLockDownBoundsKey = Settings.Default.LookToScrollLockDownBoundsKey;
            LookToScrollCentreMouseWhenActivated = Settings.Default.LookToScrollCentreMouseWhenActivated;
            LookToScrollBringWindowToFrontWhenActivated = Settings.Default.LookToScrollBringWindowToFrontWhenActivated;
            LookToScrollBringWindowToFrontAfterChoosingScreenPoint = Settings.Default.LookToScrollBringWindowToFrontAfterChoosingScreenPoint;
            LookToScrollSuspendBeforeChoosingPointForMouse = Settings.Default.LookToScrollSuspendBeforeChoosingPointForMouse;
            LookToScrollResumeAfterChoosingPointForMouse = Settings.Default.LookToScrollResumeAfterChoosingPointForMouse;
            LookToScrollDeactivateUponSwitchingKeyboards = Settings.Default.LookToScrollDeactivateUponSwitchingKeyboards;
            LookToScrollShowOverlayWindow = Settings.Default.LookToScrollShowOverlayWindow;
            LookToScrollOverlayBoundsColour = Settings.Default.LookToScrollOverlayBoundsColour;
            LookToScrollOverlayDeadzoneColour = Settings.Default.LookToScrollOverlayDeadzoneColour;
            LookToScrollOverlayBoundsThickness = Settings.Default.LookToScrollOverlayBoundsThickness;
            LookToScrollOverlayDeadzoneThickness = Settings.Default.LookToScrollOverlayDeadzoneThickness;
            LookToScrollHorizontalDeadzone = Settings.Default.LookToScrollHorizontalDeadzone;
            LookToScrollVerticalDeadzone = Settings.Default.LookToScrollVerticalDeadzone;
            LookToScrollIncrementChoices = Settings.Default.LookToScrollIncrementChoices;
            LookToScrollBaseSpeedSlow = Settings.Default.LookToScrollBaseSpeedSlow;
            LookToScrollBaseSpeedMedium = Settings.Default.LookToScrollBaseSpeedMedium;
            LookToScrollBaseSpeedFast = Settings.Default.LookToScrollBaseSpeedFast;
            LookToScrollAccelerationSlow = Settings.Default.LookToScrollAccelerationSlow;
            LookToScrollAccelerationMedium = Settings.Default.LookToScrollAccelerationMedium;
            LookToScrollAccelerationFast = Settings.Default.LookToScrollAccelerationFast;
        }

        public void ApplyChanges()
        {
            Settings.Default.ShowSplashScreen = ShowSplashScreen;
            Settings.Default.CheckForUpdates = CheckForUpdates;
            Settings.Default.PublishVirtualKeyCodesForCharacters = PublishVirtualKeyCodesForCharacters;
            Settings.Default.SuppressModifierKeysForAllMouseActions = SuppressModifierKeysForAllMouseActions;
            Settings.Default.SuppressModifierKeysWhenInMouseKeyboard = SuppressModifierKeysWhenInMouseKeyboard;
            Settings.Default.MagnifySuppressedForScrollingActions = MagnifySuppressedForScrollingActions;
            Settings.Default.Debug = Debug;
            Settings.Default.LookToScrollEnabled = LookToScrollEnabled;
            Settings.Default.LookToScrollDirectionInverted = LookToScrollDirectionInverted;
            Settings.Default.LookToScrollLockDownBoundsKey = LookToScrollLockDownBoundsKey;
            Settings.Default.LookToScrollCentreMouseWhenActivated = LookToScrollCentreMouseWhenActivated;
            Settings.Default.LookToScrollBringWindowToFrontWhenActivated = LookToScrollBringWindowToFrontWhenActivated;
            Settings.Default.LookToScrollBringWindowToFrontAfterChoosingScreenPoint = LookToScrollBringWindowToFrontAfterChoosingScreenPoint;
            Settings.Default.LookToScrollSuspendBeforeChoosingPointForMouse = LookToScrollSuspendBeforeChoosingPointForMouse;
            Settings.Default.LookToScrollResumeAfterChoosingPointForMouse = LookToScrollResumeAfterChoosingPointForMouse;
            Settings.Default.LookToScrollDeactivateUponSwitchingKeyboards = LookToScrollDeactivateUponSwitchingKeyboards;
            Settings.Default.LookToScrollShowOverlayWindow = LookToScrollShowOverlayWindow;
            Settings.Default.LookToScrollOverlayBoundsColour = LookToScrollOverlayBoundsColour;
            Settings.Default.LookToScrollOverlayDeadzoneColour = LookToScrollOverlayDeadzoneColour;
            Settings.Default.LookToScrollOverlayBoundsThickness = LookToScrollOverlayBoundsThickness;
            Settings.Default.LookToScrollOverlayDeadzoneThickness = LookToScrollOverlayDeadzoneThickness;
            Settings.Default.LookToScrollHorizontalDeadzone = LookToScrollHorizontalDeadzone;
            Settings.Default.LookToScrollVerticalDeadzone = LookToScrollVerticalDeadzone;
            Settings.Default.LookToScrollIncrementChoices = LookToScrollIncrementChoices;
            Settings.Default.LookToScrollBaseSpeedSlow = LookToScrollBaseSpeedSlow;
            Settings.Default.LookToScrollBaseSpeedMedium = LookToScrollBaseSpeedMedium;
            Settings.Default.LookToScrollBaseSpeedFast = LookToScrollBaseSpeedFast;
            Settings.Default.LookToScrollAccelerationSlow = LookToScrollAccelerationSlow;
            Settings.Default.LookToScrollAccelerationMedium = LookToScrollAccelerationMedium;
            Settings.Default.LookToScrollAccelerationFast = LookToScrollAccelerationFast;
        }

        #endregion
    }
}
