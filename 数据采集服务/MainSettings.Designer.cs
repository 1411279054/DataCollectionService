﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 数据采集服务 {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class MainSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static MainSettings defaultInstance = ((MainSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new MainSettings())));
        
        public static MainSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string 数据存储路径 {
            get {
                return ((string)(this["数据存储路径"]));
            }
            set {
                this["数据存储路径"] = value;
            }
        }
    }
}
