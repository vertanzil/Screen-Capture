﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Screen_Capture {
	
	
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("ICSharpCode.SettingsEditor.SettingsCodeGeneratorTool", "5.1.0.5216")]
	internal sealed partial class ScreenCapture : global::System.Configuration.ApplicationSettingsBase {
		
		private static ScreenCapture defaultInstance = ((ScreenCapture)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ScreenCapture())));
		
		public static ScreenCapture Default {
			get {
				return defaultInstance;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("1")]
		public int setting_copymode {
			get {
				return ((int)(this["setting_copymode"]));
			}
			set {
				this["setting_copymode"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		public bool setting_copytoclipboard {
			get {
				return ((bool)(this["setting_copytoclipboard"]));
			}
			set {
				this["setting_copytoclipboard"] = value;
			}
		}
		
		[global::System.Configuration.UserScopedSettingAttribute()]
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		[global::System.Configuration.DefaultSettingValueAttribute("False")]
		public bool setting_openinbrowser {
			get {
				return ((bool)(this["setting_openinbrowser"]));
			}
			set {
				this["setting_openinbrowser"] = value;
			}
		}
	}
}
