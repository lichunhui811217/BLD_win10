﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLD_win10 {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class BldSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static BldSettings defaultInstance = ((BldSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new BldSettings())));
        
        public static BldSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("AC6623.DLL")]
        public string DriverDllName {
            get {
                return ((string)(this["DriverDllName"]));
            }
            set {
                this["DriverDllName"] = value;
            }
        }
    }
}
