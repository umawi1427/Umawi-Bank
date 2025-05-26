#define MyAppName "Umawi Bank"
#define MyAppVersion "1.0"
#define MyAppPublisher "Umawi Inc."
#define MyAppURL "https://github.com/umawi1427/Umawi-Bank"
#define MyAppExeName "Umawi Bank.exe"
#define MyAppAssocName MyAppName + ""
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
AppId={{6D051BF1-0449-46E3-A51A-68877EB0461C}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
UninstallDisplayIcon={app}\{#MyAppExeName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
OutputDir=C:\Users\umawi\Desktop
OutputBaseFilename=Umawi Bank
SetupIconFile=C:\Users\umawi\Desktop\icon.ico
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\BouncyCastle.Cryptography.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\BouncyCastle.Cryptography.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.BonusSkins.v24.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Data.Desktop.v24.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Data.Desktop.v24.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Data.v24.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Data.v24.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Drawing.v24.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Drawing.v24.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Pdf.v24.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Pdf.v24.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Pdf.v24.1.Drawing.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Pdf.v24.1.Drawing.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Printing.v24.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Printing.v24.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Sparkline.v24.1.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Sparkline.v24.1.Core.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Utils.v24.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.Utils.v24.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.XtraBars.v24.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.XtraBars.v24.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.XtraEditors.v24.1.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\DevExpress.XtraEditors.v24.1.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\itextsharp.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\itextsharp.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\Umawi Bank.application"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\Umawi Bank.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\Umawi Bank.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\Umawi Bank.exe.manifest"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\umawi\Desktop\Umawi Bank\Umawi Bank\bin\Debug\Umawi Bank.pdb"; DestDir: "{app}"; Flags: ignoreversion

; Add the icon file to the installer and install it in the app folder
Source: "C:\Users\umawi\Desktop\icon.ico"; DestDir: "{app}"; Flags: ignoreversion

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""

[Icons]
Name: "{userprograms}\Umawi Bank\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\icon.ico"
Name: "{userprograms}\Umawi Bank\Uninstall {#MyAppName}"; Filename: "{uninstallexe}"; IconFilename: "{app}\icon.ico"
Name: "{userprograms}\Umawi Bank\{#MyAppName} Website"; Filename: "{#MyAppURL}"; IconFilename: "{app}\icon.ico"
Name: "{userdesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon; IconFilename: "{app}\icon.ico"

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
