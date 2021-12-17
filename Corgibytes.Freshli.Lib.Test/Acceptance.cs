using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NLog;
using VerifyTests;
using VerifyXunit;
using Xunit;

namespace Corgibytes.Freshli.Lib.Test
{
    [UsesVerify]
    public class Acceptance
    {
        private DateTimeOffset _testingBoundary =
            new DateTimeOffset(2020, 02, 01, 0, 0, 0, 0, TimeSpan.Zero);

        private IManifestFinderRegistry _manifestFinderRegistry;
        private IFileHistoryFinderRegistry _fileHistoryFinderRegistry;
        private ILoggerFactory _loggerFactory;

        private IRunner _runner;

        public Acceptance()
        {
            _loggerFactory = new LoggerFactory();
            _loggerFactory.AddProvider(LoggerRecording.Start(Microsoft.Extensions.Logging.LogLevel.Debug));
            _manifestFinderRegistry = new ManifestFinderRegistry(_loggerFactory.CreateLogger<ManifestFinderRegistry>());

            var loader = new ManifestFinderRegistryLoader(_loggerFactory.CreateLogger<ManifestFinderRegistryLoader>());
            loader.RegisterAll(_manifestFinderRegistry);

            _fileHistoryFinderRegistry = new FileHistoryFinderRegistry();
            _fileHistoryFinderRegistry.Register<GitFileHistoryFinder>();
            _fileHistoryFinderRegistry.Register<LocalFileHistoryFinder>();

            _runner = new Runner(_manifestFinderRegistry, _fileHistoryFinderRegistry, _loggerFactory);
        }

        [Fact]
        public Task RubyGemsWithGitHistory()
        {
            var rubyFixturePath = Fixtures.Path("ruby", "nokotest");
            var results = _runner.Run(rubyFixturePath, asOf: _testingBoundary);

            return Verifier.Verify(results.ToList());
        }

        [Fact]
        public Task RubyGemsWithHistoryViaGitHub()
        {
            var repoUrl =
              "https://github.com/corgibytes/freshli-fixture-ruby-nokotest";
            var results = _runner.Run(repoUrl, asOf: _testingBoundary);

            return Verifier.Verify(results.ToList());
        }

        [Fact]
        public Task RubyGemsFeedbinHistoryViaGitHub()
        {
            var repoUrl = "https://github.com/feedbin/feedbin";
            var results = _runner.Run(repoUrl, asOf: _testingBoundary);

            return Verifier.Verify(results.ToList());
        }

        [Fact]
        public Task RubyGemsClearanceHistoryViaGitHub()
        {
            var results = _runner.Run(
              "https://github.com/thoughtbot/clearance",
              asOf: new DateTimeOffset(2020, 06, 01, 00, 00, 00, 00, TimeSpan.Zero)
            );

            return Verifier.Verify(results.ToList());
        }

        [Fact]
        public Task ComposerWithoutGitHistory()
        {
            var phpFixturePath = Fixtures.Path("php", "large");
            var results = _runner.Run(phpFixturePath, asOf: _testingBoundary);

            return Verifier.Verify(results.ToList());
        }

        [Fact]
        public Task DrupalComposerWithoutGitHistory()
        {
            var phpFixturePath = Fixtures.Path("php", "drupal");
            var results = _runner.Run(phpFixturePath, asOf: _testingBoundary);

            return Verifier.Verify(results.ToList());
        }

        [Fact]
        public Task RequirementsTxtPyspider()
        {
            var results = _runner.Run(
              "https://github.com/binux/pyspider",
              asOf: _testingBoundary
            );

            return Verifier.Verify(results.ToList());
        }

        [Fact]
        public Task CpanfileDancer2()
        {
            var results = _runner.Run(
              "https://github.com/PerlDancer/Dancer2",
              asOf: _testingBoundary
            );

            return Verifier.Verify(results.ToList());
        }

        [Fact]
        public Task SpaCyWithHistoryViaGitHub()
        {
            var results = _runner.Run(
                "https://github.com/explosion/spaCy",
                asOf: new DateTimeOffset(2017, 6, 1, 0, 0, 0, TimeSpan.Zero)
            );

            return Verifier.Verify(results.ToList());
        }

        [Fact]
        public Task UnsupportedGitRepository()
        {
            var results = _runner.Run(
              "https://github.com/gohugoio/hugo",
              asOf: _testingBoundary
            );

            return Verifier.Verify(results.ToList());
        }
    }
}
