$functionName="PSDemo"
clear
Write-Host Compressing function code...
# zip -rq drop.zip .
7z a -r drop.zip *
Write-Host "Uploading to Lambda function [$functionName] to region [$region]..."
aws lambda update-function-code --region $region --function-name $functionName --zip-file fileb://drop.zip
Write-Host Cleaning up...
del drop.zip
Write-Host Done.