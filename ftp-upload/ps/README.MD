# Setup PS
https://github.com/aws/aws-lambda-dotnet/tree/master/PowerShell
https://www.powershellgallery.com/packages/AWS.Tools.Common/4.1.16.0
https://github.com/aws/aws-lambda-dotnet/tree/master/PowerShell

Install-Module AWS.Tools.Installer -AllowClobber -Force -Scope CurrentUser -Repository PSGallery


Get-AWSPowerShellLambdaTemplate	Returns a list of getting started templates.
New-AWSPowerShellLambda	Used to create an initial PowerShell script that is based on a template.
Publish-AWSPowerShellLambda	Publishes a given PowerShell script to Lambda.
New-AWSPowerShellLambdaPackage	Creates the Lambda deployment package that can be used in a CI/CD system for deployment