# Generate new
powershell.exe -ExecutionPolicy Bypass -NoLogo -NonInteractive -NoProfile -File "$(split-path $SCRIPT:MyInvocation.MyCommand.Path -parent)\..\..\..\..\tools\generateTool.ps1" -ResourceProvider "azsadmin/resource-manager/subscriptions" -PowershellInvoker  -AutoRestVersion "latest" -SdkDirectory $PSScriptRoot
