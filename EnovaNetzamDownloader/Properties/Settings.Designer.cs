﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnovaNetzamDownloader.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.0.3.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://download.enova.pl/instalatory/archiwalne/enova365_{version1}.{version2}_i" +
            "nstalator.exe")]
        public string InstalatorEnovaExe {
            get {
                return ((string)(this["InstalatorEnovaExe"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://download.enova.pl/instalatory/archiwalne/enova365_{version1}.{version2}_i" +
            "nstalator.msi")]
        public string InstalatorEnovaMsi {
            get {
                return ((string)(this["InstalatorEnovaMsi"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://download.enova.pl/instalatory/archiwalne/Server_Web_Standard.{version1}.{" +
            "version2}.zip")]
        public string InstalatorEnovaZip {
            get {
                return ((string)(this["InstalatorEnovaZip"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://download.enova.pl/ulotka/official/{version1}/{version2}/index.html")]
        public string UlotkaDoWersji {
            get {
                return ((string)(this["UlotkaDoWersji"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://download.enova.pl/ulotka/official/{version1}/{version2}/enova365_{version" +
            "1}.{version2}_komunikat_dla_klienta.pdf")]
        public string KomunikatDlaKlienta {
            get {
                return ((string)(this["KomunikatDlaKlienta"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://download.enova.pl/ulotka/ApiChangeLog/official/{version1}/{version2}/inde" +
            "x.html")]
        public string WykazZmianProgramistycznych {
            get {
                return ((string)(this["WykazZmianProgramistycznych"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsd=\"http://www.w3." +
            "org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">\r\n  <s" +
            "tring />\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SavedVersions {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SavedVersions"]));
            }
            set {
                this["SavedVersions"] = value;
            }
        }
    }
}
