
<h1 align="center">
  <br><a href="https://github.com/kalilistic/starkuserconfig"><img src="img/bannerIcon.png" alt="StarkUserConfig"></a>
  <br>StarkUserConfig<br>
</h1>
<h4 align="center">Basic user config in XML format.</h4>

<p align="center">
  <a href="https://github.com/kalilistic/starkuserconfig/releases/latest"><img src="https://img.shields.io/github/v/release/kalilistic/starkuserconfig"></a>
  <a href="https://ci.appveyor.com/project/kalilistic/starkuserconfig/branch/master"><img src="https://img.shields.io/appveyor/ci/kalilistic/starkuserconfig"></a>
  <a href="https://ci.appveyor.com/project/kalilistic/starkuserconfig/branch/master/tests"><img src="https://img.shields.io/appveyor/tests/kalilistic/starkuserconfig"></a>
  <a href="https://codecov.io/gh/kalilistic/starkuserconfig/branch/master"><img src="https://img.shields.io/codecov/c/gh/kalilistic/starkuserconfig"></a>
  <a href="https://github.com/kalilistic/starkuserconfig/blob/master/LICENSE"><img src="https://img.shields.io/github/license/kalilistic/starkuserconfig?color=lightgrey"></a>
</p>

## Background

Very basic user config in XML format with no dependencies except .NET Framework.

## Key Features

* Save and load user settings in xml format.
* Customize fields easily with user config interface.
* Backup previous version if config can't be loaded.
  
## How To Use

```csharp
// create class with IConfig interface with user setting fields
public class MyUserConfig : IConfig
{
    public string Name;
}

// initialize config manager with directory, config file name, and config instance
ConfigManager.Initialize(ConfigDirPath, ConfigFileName, new MyUserConfig());

// update configuration
UserConfig.Config.Name = "Karen";

// save user settings
ConfigManager.GetInstance().SaveSettings();

// load user settings
ConfigManager.GetInstance().LoadSettings();

// deinitialize
UserConfig.GetInstance().DeInit();
```

## How To Contribute

Feel free to open an issue or submit a PR.