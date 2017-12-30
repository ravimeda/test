FROM microsoft/dotnet-framework-build:4.7.1
WORKDIR app
COPY . .

RUN ["msbuild.exe", "Sample.sln", "/t:build", "/verbosity:quiet"]
RUN ["dotnet", "test", "--logger \"trx\"", "--verbosity q"]

# RUN Get-ChildItem *.trx -Recurse | Get-Content -Raw
# RUN gci ./ -Recurse | Measure-Object -Property Length -Sum
