using ObjCRuntime;

[assembly: LinkWith ("libSDKClasses.a", LinkTarget.ArmV7 |  LinkTarget.Simulator, SmartLink = true, ForceLoad = false, IsCxx=true, Frameworks = "MediaPlayer", LinkerFlags = "-lc++ -ObjC")]
