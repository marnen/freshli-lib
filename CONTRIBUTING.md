# Contributing to Freshli-Lib

We would love your help with Freshli-Lib!  The two default ways to contribute are:

* [Open issues](https://github.com/corgibytes/freshli/issues/new) for any bugs you find or enhancements you would like to see in future versions.
* Submit PRs for any [issues](https://github.com/corgibytes/freshli/issues) listed.

Feel free to submit issues/PRs that aren't code related.  Confused by the documentation or the lack thereof?  Questions about using Freshli?  Something else?  Let us know.

## Fixing an Issue and Submitting a PR

When fixing an issue, assign yourself to the issue to indicate that you're the person currently working on it.

When submitting a PR, please be sure to use Closing statements in the PR description to link to the issue at hand.

## Development Environment Setup

Freshli-Lib requires [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0) to be installed.  Once installed you should be able to build Freshli-Lib via the command line:

```
➜  freshli git:(main) ✗ dotnet build
Microsoft (R) Build Engine version 16.8.0+126527ff1 for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  Restored /Users/danhein/RiderProjects/freshli/Freshli/Freshli.csproj (in 259 ms).
  Restored /Users/danhein/RiderProjects/freshli/Freshli.Test/Freshli.Test.csproj (in 283 ms).
  Freshli -> /Users/danhein/RiderProjects/freshli/Freshli/bin/Debug/net5.0/Freshli.dll
  Freshli.Test -> /Users/danhein/RiderProjects/freshli/Freshli.Test/bin/Debug/net5.0/Freshli.Test.dll
  Archive:  nokotest.zip
    inflating: nokotest/Gemfile
    inflating: nokotest/Gemfile.lock
    inflating: nokotest/.git/config
   extracting: nokotest/.git/objects/0d/8f4f864a22eac5f72153cf1d77fc9791796e6d
   extracting: nokotest/.git/objects/93/e24fec7e2d55e1f2649989a131b1a044008e60
   extracting: nokotest/.git/objects/bb/e94adc863a728d5c63b1293a7d1d81ac437f30
   extracting: nokotest/.git/objects/6e/dae1c2dc746439f567894cf77effc7a8abf97b
   extracting: nokotest/.git/objects/01/7031627f36deb582d69cddd381718be0044b02
   extracting: nokotest/.git/objects/90/2a3082740f83776eec419c59a56e54424fdec5
   extracting: nokotest/.git/objects/b9/803963c64c5c8794334bb667d98c969add6fd0
   extracting: nokotest/.git/objects/b9/d397bcc26e2a820a2e077298f35521b154febd
   extracting: nokotest/.git/objects/c4/a0ab82b5bf0d03d646348bce24527d84d8bfe4
   extracting: nokotest/.git/objects/e1/be34540508cfb94fea222ecdc61a95652068ee
   extracting: nokotest/.git/objects/76/06873e8c521ba79d093029969c2da124ed03d3
   extracting: nokotest/.git/objects/13/963f09081c175c66d20f7dd15d23fedc789ce4
   extracting: nokotest/.git/HEAD
    inflating: nokotest/.git/info/exclude
    inflating: nokotest/.git/logs/HEAD
    inflating: nokotest/.git/logs/refs/heads/master
    inflating: nokotest/.git/description
    inflating: nokotest/.git/hooks/commit-msg.sample
    inflating: nokotest/.git/hooks/pre-rebase.sample
    inflating: nokotest/.git/hooks/pre-commit.sample
    inflating: nokotest/.git/hooks/applypatch-msg.sample
    inflating: nokotest/.git/hooks/prepare-commit-msg.sample
    inflating: nokotest/.git/hooks/post-update.sample
    inflating: nokotest/.git/hooks/pre-applypatch.sample
    inflating: nokotest/.git/hooks/pre-push.sample
    inflating: nokotest/.git/hooks/update.sample
   extracting: nokotest/.git/refs/heads/master
    inflating: nokotest/.git/index
   extracting: nokotest/.git/COMMIT_EDITMSG

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:04.29
```

### VS Code Containers

If using Visual Studio Code, there is a [Remote Container](https://code.visualstudio.com/docs/remote/containers) [configuration](.devcontainer) that allows for building and running tests inside of a development container that contains all dependencies.  This only works for Visual Studio Code and requires [Docker](https://www.docker.com/).

### IDE

Most of the project's developers use [JetBrains Rider](https://www.jetbrains.com/rider/) but some other popular IDEs include [Visual Studio](https://visualstudio.microsoft.com/) and [Visual Studio Code](https://code.visualstudio.com/).

### Running the test suite

Tests can be run from your IDE or using the command line.

```
➜  freshli git:(main) ✗ dotnet test
Test run for /Users/dev/RiderProjects/freshli/Freshli.Test/bin/Debug/net5.0/Freshli.Test.dll (.NETCoreApp,Version=v5.0)
Microsoft (R) Test Execution Command Line Tool Version 16.8.1
Copyright (c) Microsoft Corporation.  All rights reserved.


Starting test execution, please wait...

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
2021/02/08 12:56:19.720| INFO|Freshli.ManifestFinder:57|Registering IManifestFinder: Freshli.Languages.Ruby.RubyBundlerManifestFinder
2021/02/08 12:56:19.720| INFO|Freshli.ManifestFinder:57|Registering IManifestFinder: Freshli.Languages.Ruby.RubyBundlerManifestFinder
2021/02/08 12:56:19.762| INFO|Freshli.ManifestFinder:57|Registering IManifestFinder: Freshli.Languages.Python.PipRequirementsTxtManifestFinder
2021/02/08 12:56:19.762| INFO|Freshli.ManifestFinder:57|Registering IManifestFinder: Freshli.Languages.Python.PipRequirementsTxtManifestFinder
2021/02/08 12:56:19.765| INFO|Freshli.ManifestFinder:57|Registering IManifestFinder: Freshli.Languages.Php.PhpComposerManifestFinder
2021/02/08 12:56:19.765| INFO|Freshli.ManifestFinder:57|Registering IManifestFinder: Freshli.Languages.Php.PhpComposerManifestFinder
2021/02/08 12:56:19.765| INFO|Freshli.ManifestFinder:57|Registering IManifestFinder: Freshli.Languages.Perl.CpanfileManifestFinder
2021/02/08 12:56:19.766| INFO|Freshli.ManifestFinder:57|Registering IManifestFinder: Freshli.Languages.Perl.CpanfileManifestFinder
. . .


Passed!  - Failed:     0, Passed:   823, Skipped:     0, Total:   823, Duration: 6 m 37 s
```

The tests currently take longer to run than we would like. We're exploring ways to speed that up. You can run a subset of tests by including the `--filter` flag, e.g. `dotnet test --filter ComputeAsOf`.

### Test suite organization

The tests in the test suite are grouped according to the following rulses:

* *Unit*:
    * Unit tests should not have any external dependencies. This includes files stored on the file system and any data that needs to be transmitted over a network.
    * Ideally, each unit test class should focus on testing the class under test, this can usually be determined by looking at the test class name and removing the `Test` suffix. Interactions with other classes should be mocked or faked to the extent that it makes sense to do so.
    * Tests that meet these deffinitions should be stored in the `Corgibytes.Freshli.Lib.Test.Unit` namespace.
    * You can run just the the unit tests from the command line by running: `dotnet test --filter Unit`
* *Integration*:
    * Integration tests are used when the goal is to test that two more classes are appropriately interacting with each other.
    * It is perfectly valid (and encouraged) for integration tests to utilize external services, such as files on the filesystem or services that are accessible via the network.
    * Ideally, each integration test will focus on the interactions between a handfull of classes, and will not require an excessive amount of setup to execute.
    * Tests that meet these deffinitions should be stored in the `Corgibytes.Freshli.Lib.Test.Integration` namespace.
    * You can run just the integration tests from the command line by executing: `dotnet test --filter Integration`
* Acceptance:
    * Acceptance tests focus on testing the full suite of behavior. This might require many different classes interacting with each other.
    * Ideally, no classes will be supplemented with mock or fake versions. (Although it may make sense to do so from time to time to improve performance or limit impact on external services.)
    * Right now there's only one class that meets this deffinition, `Corgibytes.Freshli.Lib.Test.Acceptance`, and its entrypoint for testing is the `Run` method on the `Runner` class.
    * You can run just the acceptance tests from the command line by executing: `dotnet test --filter Acceptance`

The test filters above [can be combined](https://docs.microsoft.com/en-us/dotnet/core/testing/selective-unit-tests). For the unit and integration tests can be run with:

```
dotnet test --filter "Unit|Integration"
```

## Running

There is cross platform [Example Client](https://github.com/corgibytes/freshli-lib/tree/feature-add-example-client/ExampleClient) that you can use to see how Freshli-Lib works.  Run or debug the example client in [Visual Studio](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/run-program?view=vs-2019) or [Rider](https://www.jetbrains.com/help/rider/Run_Debug_Configuration_dotNet_Project.html).

If all goes well the Example Client window should appear.  Enter in a public git repo and click the "Run Freshli" button and the results will be displayed below.  You can find some projects we use for testing [here](https://github.com/corgibytes?q=freshli+fixture&type=&language=&sort=).

## Saving Results

Analysis metrics can be saved to a local file by setting the `SAVE_RESULTS_TO_FILE` variable.

First, create a `.env` file  based on the sample `.env-example` file. Set `SAVE_RESULTS_TO_FILE` to `true` and run the analysis. Results will be output to a text file in a newly created `results` directory.

## Logging

[NLog](https://nlog-project.org/) is being used for logging within the application.

Configuration is in [`Freshli/NLog.config`](Freshli/NLog.config)

The logger is configured to write to the console as well as to:
  * `Freshli/bin/Debug/netcoreapp3.1/freshli.log`
  * `Freshli.Test/bin/Debug/netcoreapp3.1/freshli.log`

## Generating Graphs

### Spreadsheets

The console output is designed to make it easy to copy and paste into a spreadsheet application and take advantage of the charting libraries that are available there. Additional output formats will be added in the future.

### Jupyter Notebook

If you want to generate graphs in a Jupyter Notebook, there is some additional setup that you need to follow.

1. Install Jupyter-Lab or nteract
1. Install dontet/interactive

A [sample notebook](https://github.com/corgibytes/freshli/blob/main/Sample.ipynb) can be found in this repository.

Before working with `freshli` in a Jupyter Notebook you have to package it as a NuGet package by running `dotnet pack`.

Once that's done, you'll need to import and require `freshli` as a NuGet package by running the following.

```
#i nuget:/Users/mscottford/src/corgibytes/freshli/Freshli/bin/Debug
#r nuget:freshli,1.0.0-dev
```

You'll need to change the path above to match the absolute path where the `.nupkg` file can be found.

The following script will allow you to create simple line graphs to plot a project or multiple projects.

```csharp

using XPlot.Plotly;

using Freshli;
using Freshli.Languages.Ruby;
using Freshli.Languages.Php;
using Freshli.Languages.Python;

ManifestFinder.Register<RubyBundlerManifestFinder>();
ManifestFinder.Register<PhpComposerManifestFinder>();
ManifestFinder.Register<PipRequirementsTxtManifestFinder>();

FileHistoryFinder.Register<GitFileHistoryFinder>();

PlotlyChart CreateLineGraphFor(Dictionary<string, IList<MetricsResult>> projects) {
    var lineSeries = projects.Select(p => new Scattergl {
        name = p.Key,
        x = p.Value.Select(r => r.Date),
        y = p.Value.Select(r => r.LibYear.Total)
    });


    var chart = Chart.Plot(lineSeries.ToArray());
    chart.WithTitle("LibYear over time");
    return chart;
}
```

You can then generate a graph by running:

```csharp
var runner = new Runner();
var projects = new Dictionary<string, IList<MetrictsResult>>();
projects["example"] = runner.Run("https://github.com/corgibytes/freshli-fixture-ruby-nokotest");
display(CreateLineGraphFor(projects))
```

## Running `eclint` via docker-compose

The `eclint` container provides a convenient way to run the `eclint` command
that's used by GitHub Actions as part of every pull request. To do so simply
run the following.

```
docker-compose run eclint
```

## Running CodeClimate locally

To run CodeClimate locally, do the following:

1. Make sure Docker is installed on your OS.
2. Follow the directions for [CodeClimate CLI installation](https://github.com/codeclimate/codeclimate#installation)
3. Run the following command `sudo codeclimate analyze`.

## Running Github Action locally

When developing the Github Action, consider running it locally before commit
with the [act](https://github.com/nektos/act) tool.

1. [Install](https://github.com/nektos/act#installation) act.
2. Run with the following command, noting you can add secrets:

```
act -s secret_key=secret_value
```

## Branching and Versioning

This project uses cactus branching which means development is done in feature branches merged to the `main` branch and releases are done in `release-X.Y` branches off of main.  Any fixes found testing a release are merged back to the release branch and then merged back to main.  Another name for this branching strategy is Trunk Based [Development](https://trunkbaseddevelopment.com/).

The next version is automatically calculated using [GitVersion](https://github.com/GitTools/GitVersion).  Commits to the main branch have the alpha suffix in their version number (e.g. v1.0.0-alpha0001).  All commits to the release branches have the rc suffix (e.g. v1.0.0-beta).  When a production release is done a tag without any suffix is used (e.g. v1.0.0).  This tag is then used by GitVersion to calculate future versions.  The configuration for GitVersion can be found [GitVersion.yml].
