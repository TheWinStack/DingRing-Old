﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MelakifyMind.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.5.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IsWatched {
            get {
                return ((bool)(this["IsWatched"]));
            }
            set {
                this["IsWatched"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime WatchTime {
            get {
                return ((global::System.DateTime)(this["WatchTime"]));
            }
            set {
                this["WatchTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool FirstReminder {
            get {
                return ((bool)(this["FirstReminder"]));
            }
            set {
                this["FirstReminder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OnStartup {
            get {
                return ((bool)(this["OnStartup"]));
            }
            set {
                this["OnStartup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoBackup {
            get {
                return ((bool)(this["AutoBackup"]));
            }
            set {
                this["AutoBackup"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("None")]
        public string BackupPath {
            get {
                return ((string)(this["BackupPath"]));
            }
            set {
                this["BackupPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsTranslucent {
            get {
                return ((bool)(this["IsTranslucent"]));
            }
            set {
                this["IsTranslucent"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("میکا")]
        public string TranslucentMode {
            get {
                return ((string)(this["TranslucentMode"]));
            }
            set {
                this["TranslucentMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Orange")]
        public System.Windows.Media.SolidColorBrush ColorPalette {
            get {
                return ((System.Windows.Media.SolidColorBrush)(this["ColorPalette"]));
            }
            set {
                this["ColorPalette"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Orange")]
        public System.Windows.Media.SolidColorBrush ColorBackground
        {
            get
            {
                return ((System.Windows.Media.SolidColorBrush)(this["ColorBackground"]));
            }
            set
            {
                this["ColorBackground"] = value;
            }
        }

        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Orange")]
        public string ColorName
        {
            get
            {
                return ((string)(this["ColorName"]));
            }
            set
            {
                this["ColorName"] = value;
            }
        }
    }
}
