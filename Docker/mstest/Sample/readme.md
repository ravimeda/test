This folder contains a sample project to demonstrate running of .NET full-framework tests in a Docker cotnainer.

| File | Description |
|------|-------------|
| `SampleLibrary` | Project that targets .NET 4.7.1 |
| `SampleUnitTests` | A Unit Test project that contains a few unit tests for `GetMessage` method in `SampleLibrary` |
| `Sample.sln` | Solution that contains `SampleLibrary` and `SampleUnitTests` |
| `Dockerfile` | Dockerfile that builds the solution, and runs the unit tests in a container running `microsoft/dotnet-framework-build:4.7.1` |

Here are the commands to try this sample -

```
git clone https://github.com/ravimeda/test.git mstest-sample
cd mstest-sample\Docker\mstest\Sample
docker build -t mstest-sample:latest .
```

If the above commands run successfully, then the console output should show the path to `.trx` file as shown in the example below .

```
Results File: C:\app\SampleUnitTests\TestResults\ContainerAdministrator_F774A80A8993_2017-12-30_13_12_14.trx
```

NOTE: There is scope for optimizations.  For example, `packages` folder can be deleted.  This will reduce the payload to be copied.  However, a `restore` command should be included in the Dockerfile to restore these packages within the container.
