// Generated from https://github.com/ErisApps/nuke/blob/master/source/Nuke.Common/Tools/AppCenter/AppCenter.json

using JetBrains.Annotations;
using Newtonsoft.Json;
using Nuke.Common;
using Nuke.Common.Execution;
using Nuke.Common.Tooling;
using Nuke.Common.Tools;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace Nuke.Common.Tools.AppCenter
{
    /// <summary>
    ///   <p>Nuke Tool for AppCenter CLI</p>
    ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AppCenterTasks
    {
        /// <summary>
        ///   Path to the AppCenter executable.
        /// </summary>
        public static string AppCenterPath =>
            ToolPathResolver.TryGetEnvironmentExecutable("APPCENTER_EXE") ??
            ToolPathResolver.GetPathExecutable("appcenter");
        public static Action<OutputType, string> AppCenterLogger { get; set; } = ProcessTasks.DefaultLogger;
        /// <summary>
        ///   <p>Nuke Tool for AppCenter CLI</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        public static IReadOnlyCollection<Output> AppCenter(string arguments, string workingDirectory = null, IReadOnlyDictionary<string, string> environmentVariables = null, int? timeout = null, bool? logOutput = null, bool? logInvocation = null, Func<string, string> outputFilter = null)
        {
            using var process = ProcessTasks.StartProcess(AppCenterPath, arguments, workingDirectory, environmentVariables, timeout, logOutput, logInvocation, AppCenterLogger, outputFilter);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Log in</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AppCenterLoginSettings.Debug"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterLoginSettings.DisableTelemetry"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterLoginSettings.Env"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterLoginSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterLoginSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AppCenterLoginSettings.Password"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterLoginSettings.Quiet"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterLoginSettings.Token"/></li>
        ///     <li><c>--user</c> via <see cref="AppCenterLoginSettings.User"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterLoginSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AppCenterLogin(AppCenterLoginSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AppCenterLoginSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Log in</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AppCenterLoginSettings.Debug"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterLoginSettings.DisableTelemetry"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterLoginSettings.Env"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterLoginSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterLoginSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AppCenterLoginSettings.Password"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterLoginSettings.Quiet"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterLoginSettings.Token"/></li>
        ///     <li><c>--user</c> via <see cref="AppCenterLoginSettings.User"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterLoginSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AppCenterLogin(Configure<AppCenterLoginSettings> configurator)
        {
            return AppCenterLogin(configurator(new AppCenterLoginSettings()));
        }
        /// <summary>
        ///   <p>Log in</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AppCenterLoginSettings.Debug"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterLoginSettings.DisableTelemetry"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterLoginSettings.Env"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterLoginSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterLoginSettings.Output"/></li>
        ///     <li><c>--password</c> via <see cref="AppCenterLoginSettings.Password"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterLoginSettings.Quiet"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterLoginSettings.Token"/></li>
        ///     <li><c>--user</c> via <see cref="AppCenterLoginSettings.User"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterLoginSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AppCenterLoginSettings Settings, IReadOnlyCollection<Output> Output)> AppCenterLogin(CombinatorialConfigure<AppCenterLoginSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AppCenterLogin, AppCenterLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Log out</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AppCenterLogoutSettings.Debug"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterLogoutSettings.DisableTelemetry"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterLogoutSettings.Env"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterLogoutSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterLogoutSettings.Output"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterLogoutSettings.Quiet"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterLogoutSettings.Token"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterLogoutSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AppCenterLogout(AppCenterLogoutSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AppCenterLogoutSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Log out</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AppCenterLogoutSettings.Debug"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterLogoutSettings.DisableTelemetry"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterLogoutSettings.Env"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterLogoutSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterLogoutSettings.Output"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterLogoutSettings.Quiet"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterLogoutSettings.Token"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterLogoutSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AppCenterLogout(Configure<AppCenterLogoutSettings> configurator)
        {
            return AppCenterLogout(configurator(new AppCenterLogoutSettings()));
        }
        /// <summary>
        ///   <p>Log out</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AppCenterLogoutSettings.Debug"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterLogoutSettings.DisableTelemetry"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterLogoutSettings.Env"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterLogoutSettings.Help"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterLogoutSettings.Output"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterLogoutSettings.Quiet"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterLogoutSettings.Token"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterLogoutSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AppCenterLogoutSettings Settings, IReadOnlyCollection<Output> Output)> AppCenterLogout(CombinatorialConfigure<AppCenterLogoutSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AppCenterLogout, AppCenterLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Create a new app</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AppCenterAppsCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AppCenterAppsCreateSettings.Description"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterAppsCreateSettings.DisableTelemetry"/></li>
        ///     <li><c>--display-name</c> via <see cref="AppCenterAppsCreateSettings.DisplayName"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterAppsCreateSettings.Env"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterAppsCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AppCenterAppsCreateSettings.Name"/></li>
        ///     <li><c>--os</c> via <see cref="AppCenterAppsCreateSettings.OS"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterAppsCreateSettings.Output"/></li>
        ///     <li><c>--platform</c> via <see cref="AppCenterAppsCreateSettings.Platform"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterAppsCreateSettings.Quiet"/></li>
        ///     <li><c>--release-type</c> via <see cref="AppCenterAppsCreateSettings.ReleaseType"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterAppsCreateSettings.Token"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterAppsCreateSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AppCenterAppsCreate(AppCenterAppsCreateSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AppCenterAppsCreateSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Create a new app</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AppCenterAppsCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AppCenterAppsCreateSettings.Description"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterAppsCreateSettings.DisableTelemetry"/></li>
        ///     <li><c>--display-name</c> via <see cref="AppCenterAppsCreateSettings.DisplayName"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterAppsCreateSettings.Env"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterAppsCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AppCenterAppsCreateSettings.Name"/></li>
        ///     <li><c>--os</c> via <see cref="AppCenterAppsCreateSettings.OS"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterAppsCreateSettings.Output"/></li>
        ///     <li><c>--platform</c> via <see cref="AppCenterAppsCreateSettings.Platform"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterAppsCreateSettings.Quiet"/></li>
        ///     <li><c>--release-type</c> via <see cref="AppCenterAppsCreateSettings.ReleaseType"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterAppsCreateSettings.Token"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterAppsCreateSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AppCenterAppsCreate(Configure<AppCenterAppsCreateSettings> configurator)
        {
            return AppCenterAppsCreate(configurator(new AppCenterAppsCreateSettings()));
        }
        /// <summary>
        ///   <p>Create a new app</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--debug</c> via <see cref="AppCenterAppsCreateSettings.Debug"/></li>
        ///     <li><c>--description</c> via <see cref="AppCenterAppsCreateSettings.Description"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterAppsCreateSettings.DisableTelemetry"/></li>
        ///     <li><c>--display-name</c> via <see cref="AppCenterAppsCreateSettings.DisplayName"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterAppsCreateSettings.Env"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterAppsCreateSettings.Help"/></li>
        ///     <li><c>--name</c> via <see cref="AppCenterAppsCreateSettings.Name"/></li>
        ///     <li><c>--os</c> via <see cref="AppCenterAppsCreateSettings.OS"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterAppsCreateSettings.Output"/></li>
        ///     <li><c>--platform</c> via <see cref="AppCenterAppsCreateSettings.Platform"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterAppsCreateSettings.Quiet"/></li>
        ///     <li><c>--release-type</c> via <see cref="AppCenterAppsCreateSettings.ReleaseType"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterAppsCreateSettings.Token"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterAppsCreateSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AppCenterAppsCreateSettings Settings, IReadOnlyCollection<Output> Output)> AppCenterAppsCreate(CombinatorialConfigure<AppCenterAppsCreateSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AppCenterAppsCreate, AppCenterLogger, degreeOfParallelism, completeOnFailure);
        }
        /// <summary>
        ///   <p>Upload release binary and trigger distribution, at least one of --store or --group must be specified</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--app</c> via <see cref="AppCenterDistributeReleaseSettings.App"/></li>
        ///     <li><c>--build-number</c> via <see cref="AppCenterDistributeReleaseSettings.BuildNumber"/></li>
        ///     <li><c>--build-version</c> via <see cref="AppCenterDistributeReleaseSettings.BuildVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AppCenterDistributeReleaseSettings.Debug"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterDistributeReleaseSettings.DisableTelemetry"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterDistributeReleaseSettings.Env"/></li>
        ///     <li><c>--file</c> via <see cref="AppCenterDistributeReleaseSettings.File"/></li>
        ///     <li><c>--group</c> via <see cref="AppCenterDistributeReleaseSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterDistributeReleaseSettings.Help"/></li>
        ///     <li><c>--mandatory</c> via <see cref="AppCenterDistributeReleaseSettings.Mandatory"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterDistributeReleaseSettings.Output"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterDistributeReleaseSettings.Quiet"/></li>
        ///     <li><c>--release-notes</c> via <see cref="AppCenterDistributeReleaseSettings.ReleaseNotes"/></li>
        ///     <li><c>--release-notes-file</c> via <see cref="AppCenterDistributeReleaseSettings.ReleaseNotesFile"/></li>
        ///     <li><c>--silent</c> via <see cref="AppCenterDistributeReleaseSettings.Silent"/></li>
        ///     <li><c>--store</c> via <see cref="AppCenterDistributeReleaseSettings.Store"/></li>
        ///     <li><c>--timeout</c> via <see cref="AppCenterDistributeReleaseSettings.Timeout"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterDistributeReleaseSettings.Token"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterDistributeReleaseSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AppCenterDistributeRelease(AppCenterDistributeReleaseSettings toolSettings = null)
        {
            toolSettings = toolSettings ?? new AppCenterDistributeReleaseSettings();
            using var process = ProcessTasks.StartProcess(toolSettings);
            process.AssertZeroExitCode();
            return process.Output;
        }
        /// <summary>
        ///   <p>Upload release binary and trigger distribution, at least one of --store or --group must be specified</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--app</c> via <see cref="AppCenterDistributeReleaseSettings.App"/></li>
        ///     <li><c>--build-number</c> via <see cref="AppCenterDistributeReleaseSettings.BuildNumber"/></li>
        ///     <li><c>--build-version</c> via <see cref="AppCenterDistributeReleaseSettings.BuildVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AppCenterDistributeReleaseSettings.Debug"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterDistributeReleaseSettings.DisableTelemetry"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterDistributeReleaseSettings.Env"/></li>
        ///     <li><c>--file</c> via <see cref="AppCenterDistributeReleaseSettings.File"/></li>
        ///     <li><c>--group</c> via <see cref="AppCenterDistributeReleaseSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterDistributeReleaseSettings.Help"/></li>
        ///     <li><c>--mandatory</c> via <see cref="AppCenterDistributeReleaseSettings.Mandatory"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterDistributeReleaseSettings.Output"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterDistributeReleaseSettings.Quiet"/></li>
        ///     <li><c>--release-notes</c> via <see cref="AppCenterDistributeReleaseSettings.ReleaseNotes"/></li>
        ///     <li><c>--release-notes-file</c> via <see cref="AppCenterDistributeReleaseSettings.ReleaseNotesFile"/></li>
        ///     <li><c>--silent</c> via <see cref="AppCenterDistributeReleaseSettings.Silent"/></li>
        ///     <li><c>--store</c> via <see cref="AppCenterDistributeReleaseSettings.Store"/></li>
        ///     <li><c>--timeout</c> via <see cref="AppCenterDistributeReleaseSettings.Timeout"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterDistributeReleaseSettings.Token"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterDistributeReleaseSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IReadOnlyCollection<Output> AppCenterDistributeRelease(Configure<AppCenterDistributeReleaseSettings> configurator)
        {
            return AppCenterDistributeRelease(configurator(new AppCenterDistributeReleaseSettings()));
        }
        /// <summary>
        ///   <p>Upload release binary and trigger distribution, at least one of --store or --group must be specified</p>
        ///   <p>For more details, visit the <a href="https://github.com/Microsoft/appcenter-cli/">official website</a>.</p>
        /// </summary>
        /// <remarks>
        ///   <p>This is a <a href="http://www.nuke.build/docs/authoring-builds/cli-tools.html#fluent-apis">CLI wrapper with fluent API</a> that allows to modify the following arguments:</p>
        ///   <ul>
        ///     <li><c>--app</c> via <see cref="AppCenterDistributeReleaseSettings.App"/></li>
        ///     <li><c>--build-number</c> via <see cref="AppCenterDistributeReleaseSettings.BuildNumber"/></li>
        ///     <li><c>--build-version</c> via <see cref="AppCenterDistributeReleaseSettings.BuildVersion"/></li>
        ///     <li><c>--debug</c> via <see cref="AppCenterDistributeReleaseSettings.Debug"/></li>
        ///     <li><c>--disable-telemetry</c> via <see cref="AppCenterDistributeReleaseSettings.DisableTelemetry"/></li>
        ///     <li><c>--env</c> via <see cref="AppCenterDistributeReleaseSettings.Env"/></li>
        ///     <li><c>--file</c> via <see cref="AppCenterDistributeReleaseSettings.File"/></li>
        ///     <li><c>--group</c> via <see cref="AppCenterDistributeReleaseSettings.Group"/></li>
        ///     <li><c>--help</c> via <see cref="AppCenterDistributeReleaseSettings.Help"/></li>
        ///     <li><c>--mandatory</c> via <see cref="AppCenterDistributeReleaseSettings.Mandatory"/></li>
        ///     <li><c>--output</c> via <see cref="AppCenterDistributeReleaseSettings.Output"/></li>
        ///     <li><c>--quiet</c> via <see cref="AppCenterDistributeReleaseSettings.Quiet"/></li>
        ///     <li><c>--release-notes</c> via <see cref="AppCenterDistributeReleaseSettings.ReleaseNotes"/></li>
        ///     <li><c>--release-notes-file</c> via <see cref="AppCenterDistributeReleaseSettings.ReleaseNotesFile"/></li>
        ///     <li><c>--silent</c> via <see cref="AppCenterDistributeReleaseSettings.Silent"/></li>
        ///     <li><c>--store</c> via <see cref="AppCenterDistributeReleaseSettings.Store"/></li>
        ///     <li><c>--timeout</c> via <see cref="AppCenterDistributeReleaseSettings.Timeout"/></li>
        ///     <li><c>--token</c> via <see cref="AppCenterDistributeReleaseSettings.Token"/></li>
        ///     <li><c>--version</c> via <see cref="AppCenterDistributeReleaseSettings.Version"/></li>
        ///   </ul>
        /// </remarks>
        public static IEnumerable<(AppCenterDistributeReleaseSettings Settings, IReadOnlyCollection<Output> Output)> AppCenterDistributeRelease(CombinatorialConfigure<AppCenterDistributeReleaseSettings> configurator, int degreeOfParallelism = 1, bool completeOnFailure = false)
        {
            return configurator.Invoke(AppCenterDistributeRelease, AppCenterLogger, degreeOfParallelism, completeOnFailure);
        }
    }
    #region AppCenterLoginSettings
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AppCenterLoginSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AppCenter executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? AppCenterTasks.AppCenterPath;
        public override Action<OutputType, string> ProcessCustomLogger => AppCenterTasks.AppCenterLogger;
        /// <summary>
        ///   Username to log in as
        /// </summary>
        public virtual string User { get; internal set; }
        /// <summary>
        ///   Password to log in with
        /// </summary>
        public virtual string Password { get; internal set; }
        /// <summary>
        ///   Disable telemetry for this command
        /// </summary>
        public virtual bool? DisableTelemetry { get; internal set; }
        /// <summary>
        ///   Display AppCenter version
        /// </summary>
        public virtual bool? Version { get; internal set; }
        /// <summary>
        ///   Auto-confirm any prompts without waiting for input
        /// </summary>
        public virtual bool? Quiet { get; internal set; }
        /// <summary>
        ///   Display help for current command
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Environment when using API token
        /// </summary>
        public virtual string Env { get; internal set; }
        /// <summary>
        ///   API token
        /// </summary>
        public virtual string Token { get; internal set; }
        /// <summary>
        ///   Output format: json
        /// </summary>
        public virtual AppCenterDistributeReleaseOutput Output { get; internal set; }
        /// <summary>
        ///   Display extra output for debugging
        /// </summary>
        public virtual bool? Debug { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("login")
              .Add("--user {value}", User)
              .Add("--password {value}", Password, secret: true)
              .Add("--disable-telemetry", DisableTelemetry)
              .Add("--version", Version)
              .Add("--quiet", Quiet)
              .Add("--help", Help)
              .Add("--env {value}", Env)
              .Add("--token {value}", Token, secret: true)
              .Add("--output {value}", Output)
              .Add("--debug", Debug);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region AppCenterLogoutSettings
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AppCenterLogoutSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AppCenter executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? AppCenterTasks.AppCenterPath;
        public override Action<OutputType, string> ProcessCustomLogger => AppCenterTasks.AppCenterLogger;
        /// <summary>
        ///   Disable telemetry for this command
        /// </summary>
        public virtual bool? DisableTelemetry { get; internal set; }
        /// <summary>
        ///   Display AppCenter version
        /// </summary>
        public virtual bool? Version { get; internal set; }
        /// <summary>
        ///   Auto-confirm any prompts without waiting for input
        /// </summary>
        public virtual bool? Quiet { get; internal set; }
        /// <summary>
        ///   Display help for current command
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Environment when using API token
        /// </summary>
        public virtual string Env { get; internal set; }
        /// <summary>
        ///   API token
        /// </summary>
        public virtual string Token { get; internal set; }
        /// <summary>
        ///   Output format: json
        /// </summary>
        public virtual AppCenterDistributeReleaseOutput Output { get; internal set; }
        /// <summary>
        ///   Display extra output for debugging
        /// </summary>
        public virtual bool? Debug { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("logout")
              .Add("--disable-telemetry", DisableTelemetry)
              .Add("--version", Version)
              .Add("--quiet", Quiet)
              .Add("--help", Help)
              .Add("--env {value}", Env)
              .Add("--token {value}", Token, secret: true)
              .Add("--output {value}", Output)
              .Add("--debug", Debug);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region AppCenterAppsCreateSettings
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AppCenterAppsCreateSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AppCenter executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? AppCenterTasks.AppCenterPath;
        public override Action<OutputType, string> ProcessCustomLogger => AppCenterTasks.AppCenterLogger;
        /// <summary>
        ///   The platform of the app. Supported values: Cordova, Java, Objective-C-Swift, React-Native, Unity, UWP, WinForms, WPF, Xamarin, Custom
        /// </summary>
        public virtual AppCenterAppsCreatePlatform Platform { get; internal set; }
        /// <summary>
        ///   The OS the app will be running on. Supported values: Android, Custom, iOS, macOS, tvOS, Windows
        /// </summary>
        public virtual AppCenterAppsCreateOS OS { get; internal set; }
        /// <summary>
        ///   The descriptive name of the app. This can contain any characters
        /// </summary>
        public virtual string DisplayName { get; internal set; }
        /// <summary>
        ///   The app release type. Suggested values are Alpha, Beta, Production, Store, Enterprise. Custom values are allowed and must be must be one word, alphanumeric, first letter capitalized.
        /// </summary>
        public virtual AppCenterAppsCreateReleaseType ReleaseType { get; internal set; }
        /// <summary>
        ///   The name of the app used in URLs. Can optionally be provided specifically, otherwise a generated name will be derived from display-name
        /// </summary>
        public virtual string Name { get; internal set; }
        /// <summary>
        ///   The description of the app
        /// </summary>
        public virtual string Description { get; internal set; }
        /// <summary>
        ///   Disable telemetry for this command
        /// </summary>
        public virtual bool? DisableTelemetry { get; internal set; }
        /// <summary>
        ///   Display AppCenter version
        /// </summary>
        public virtual bool? Version { get; internal set; }
        /// <summary>
        ///   Auto-confirm any prompts without waiting for input
        /// </summary>
        public virtual bool? Quiet { get; internal set; }
        /// <summary>
        ///   Display help for current command
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Environment when using API token
        /// </summary>
        public virtual string Env { get; internal set; }
        /// <summary>
        ///   API token
        /// </summary>
        public virtual string Token { get; internal set; }
        /// <summary>
        ///   Output format: json
        /// </summary>
        public virtual AppCenterDistributeReleaseOutput Output { get; internal set; }
        /// <summary>
        ///   Display extra output for debugging
        /// </summary>
        public virtual bool? Debug { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("apps create")
              .Add("--platform {value}", Platform)
              .Add("--os {value}", OS)
              .Add("--display-name {value}", DisplayName)
              .Add("--release-type {value}", ReleaseType)
              .Add("--name {value}", Name)
              .Add("--description {value}", Description)
              .Add("--disable-telemetry", DisableTelemetry)
              .Add("--version", Version)
              .Add("--quiet", Quiet)
              .Add("--help", Help)
              .Add("--env {value}", Env)
              .Add("--token {value}", Token, secret: true)
              .Add("--output {value}", Output)
              .Add("--debug", Debug);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region AppCenterDistributeReleaseSettings
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    [Serializable]
    public partial class AppCenterDistributeReleaseSettings : ToolSettings
    {
        /// <summary>
        ///   Path to the AppCenter executable.
        /// </summary>
        public override string ProcessToolPath => base.ProcessToolPath ?? AppCenterTasks.AppCenterPath;
        public override Action<OutputType, string> ProcessCustomLogger => AppCenterTasks.AppCenterLogger;
        /// <summary>
        ///   Path to binary file
        /// </summary>
        public virtual string File { get; internal set; }
        /// <summary>
        ///   Timeout for waiting release id (in seconds)
        /// </summary>
        public virtual int? Timeout { get; internal set; }
        /// <summary>
        ///   Make the release mandatory for the testers (default is false)
        /// </summary>
        public virtual bool? Mandatory { get; internal set; }
        /// <summary>
        ///   Do not notify testers of this release
        /// </summary>
        public virtual bool? Silent { get; internal set; }
        /// <summary>
        ///   Path to release notes file (markdown supported, 5000 characters max)
        /// </summary>
        public virtual string ReleaseNotesFile { get; internal set; }
        /// <summary>
        ///   Release notes text (5000 characters max)
        /// </summary>
        public virtual string ReleaseNotes { get; internal set; }
        /// <summary>
        ///   Store name
        /// </summary>
        public virtual string Store { get; internal set; }
        /// <summary>
        ///   Comma-separated distribution group names
        /// </summary>
        public virtual IReadOnlyList<string> Group => GroupInternal.AsReadOnly();
        internal List<string> GroupInternal { get; set; } = new List<string>();
        /// <summary>
        ///   Build number parameter required for macOS .pkg and .dmg files
        /// </summary>
        public virtual string BuildNumber { get; internal set; }
        /// <summary>
        ///   Build version parameter required for .zip, .msi, .pkg and .dmg files
        /// </summary>
        public virtual string BuildVersion { get; internal set; }
        /// <summary>
        ///   Specify app in the &lt;ownerName&gt;/&lt;appName&gt; format
        /// </summary>
        public virtual string App { get; internal set; }
        /// <summary>
        ///   Disable telemetry for this command
        /// </summary>
        public virtual bool? DisableTelemetry { get; internal set; }
        /// <summary>
        ///   Display AppCenter version
        /// </summary>
        public virtual bool? Version { get; internal set; }
        /// <summary>
        ///   Auto-confirm any prompts without waiting for input
        /// </summary>
        public virtual bool? Quiet { get; internal set; }
        /// <summary>
        ///   Display help for current command
        /// </summary>
        public virtual bool? Help { get; internal set; }
        /// <summary>
        ///   Environment when using API token
        /// </summary>
        public virtual string Env { get; internal set; }
        /// <summary>
        ///   API token
        /// </summary>
        public virtual string Token { get; internal set; }
        /// <summary>
        ///   Output format: json
        /// </summary>
        public virtual AppCenterDistributeReleaseOutput Output { get; internal set; }
        /// <summary>
        ///   Display extra output for debugging
        /// </summary>
        public virtual bool? Debug { get; internal set; }
        protected override Arguments ConfigureProcessArguments(Arguments arguments)
        {
            arguments
              .Add("distribute release")
              .Add("--file {value}", File)
              .Add("--timeout {value}", Timeout)
              .Add("--mandatory", Mandatory)
              .Add("--silent", Silent)
              .Add("--release-notes-file {value}", ReleaseNotesFile)
              .Add("--release-notes {value}", ReleaseNotes)
              .Add("--store {value}", Store)
              .Add("--group {value}", Group, separator: ',')
              .Add("--build-number {value}", BuildNumber)
              .Add("--build-version {value}", BuildVersion)
              .Add("--app {value}", App)
              .Add("--disable-telemetry", DisableTelemetry)
              .Add("--version", Version)
              .Add("--quiet", Quiet)
              .Add("--help", Help)
              .Add("--env {value}", Env)
              .Add("--token {value}", Token, secret: true)
              .Add("--output {value}", Output)
              .Add("--debug", Debug);
            return base.ConfigureProcessArguments(arguments);
        }
    }
    #endregion
    #region AppCenterLoginSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AppCenterLoginSettingsExtensions
    {
        #region User
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.User"/></em></p>
        ///   <p>Username to log in as</p>
        /// </summary>
        [Pure]
        public static T SetUser<T>(this T toolSettings, string user) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.User = user;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.User"/></em></p>
        ///   <p>Username to log in as</p>
        /// </summary>
        [Pure]
        public static T ResetUser<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.User = null;
            return toolSettings;
        }
        #endregion
        #region Password
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.Password"/></em></p>
        ///   <p>Password to log in with</p>
        /// </summary>
        [Pure]
        public static T SetPassword<T>(this T toolSettings, [Secret] string password) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = password;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.Password"/></em></p>
        ///   <p>Password to log in with</p>
        /// </summary>
        [Pure]
        public static T ResetPassword<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Password = null;
            return toolSettings;
        }
        #endregion
        #region DisableTelemetry
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T SetDisableTelemetry<T>(this T toolSettings, bool? disableTelemetry) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = disableTelemetry;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T ResetDisableTelemetry<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLoginSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T EnableDisableTelemetry<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLoginSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T DisableDisableTelemetry<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLoginSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T ToggleDisableTelemetry<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = !toolSettings.DisableTelemetry;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T SetVersion<T>(this T toolSettings, bool? version) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T ResetVersion<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLoginSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T EnableVersion<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLoginSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T DisableVersion<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLoginSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T ToggleVersion<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = !toolSettings.Version;
            return toolSettings;
        }
        #endregion
        #region Quiet
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T SetQuiet<T>(this T toolSettings, bool? quiet) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = quiet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T ResetQuiet<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLoginSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T EnableQuiet<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLoginSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T DisableQuiet<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLoginSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T ToggleQuiet<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = !toolSettings.Quiet;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T SetHelp<T>(this T toolSettings, bool? help) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T ResetHelp<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLoginSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T EnableHelp<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLoginSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T DisableHelp<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLoginSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T ToggleHelp<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Env
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.Env"/></em></p>
        ///   <p>Environment when using API token</p>
        /// </summary>
        [Pure]
        public static T SetEnv<T>(this T toolSettings, string env) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Env = env;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.Env"/></em></p>
        ///   <p>Environment when using API token</p>
        /// </summary>
        [Pure]
        public static T ResetEnv<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Env = null;
            return toolSettings;
        }
        #endregion
        #region Token
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.Token"/></em></p>
        ///   <p>API token</p>
        /// </summary>
        [Pure]
        public static T SetToken<T>(this T toolSettings, [Secret] string token) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = token;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.Token"/></em></p>
        ///   <p>API token</p>
        /// </summary>
        [Pure]
        public static T ResetToken<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.Output"/></em></p>
        ///   <p>Output format: json</p>
        /// </summary>
        [Pure]
        public static T SetOutput<T>(this T toolSettings, AppCenterDistributeReleaseOutput output) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.Output"/></em></p>
        ///   <p>Output format: json</p>
        /// </summary>
        [Pure]
        public static T ResetOutput<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLoginSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T SetDebug<T>(this T toolSettings, bool? debug) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLoginSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T ResetDebug<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLoginSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T EnableDebug<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLoginSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T DisableDebug<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLoginSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T ToggleDebug<T>(this T toolSettings) where T : AppCenterLoginSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = !toolSettings.Debug;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AppCenterLogoutSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AppCenterLogoutSettingsExtensions
    {
        #region DisableTelemetry
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLogoutSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T SetDisableTelemetry<T>(this T toolSettings, bool? disableTelemetry) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = disableTelemetry;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLogoutSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T ResetDisableTelemetry<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLogoutSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T EnableDisableTelemetry<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLogoutSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T DisableDisableTelemetry<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLogoutSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T ToggleDisableTelemetry<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = !toolSettings.DisableTelemetry;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLogoutSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T SetVersion<T>(this T toolSettings, bool? version) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLogoutSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T ResetVersion<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLogoutSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T EnableVersion<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLogoutSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T DisableVersion<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLogoutSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T ToggleVersion<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = !toolSettings.Version;
            return toolSettings;
        }
        #endregion
        #region Quiet
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLogoutSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T SetQuiet<T>(this T toolSettings, bool? quiet) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = quiet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLogoutSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T ResetQuiet<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLogoutSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T EnableQuiet<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLogoutSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T DisableQuiet<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLogoutSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T ToggleQuiet<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = !toolSettings.Quiet;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLogoutSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T SetHelp<T>(this T toolSettings, bool? help) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLogoutSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T ResetHelp<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLogoutSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T EnableHelp<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLogoutSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T DisableHelp<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLogoutSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T ToggleHelp<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Env
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLogoutSettings.Env"/></em></p>
        ///   <p>Environment when using API token</p>
        /// </summary>
        [Pure]
        public static T SetEnv<T>(this T toolSettings, string env) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Env = env;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLogoutSettings.Env"/></em></p>
        ///   <p>Environment when using API token</p>
        /// </summary>
        [Pure]
        public static T ResetEnv<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Env = null;
            return toolSettings;
        }
        #endregion
        #region Token
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLogoutSettings.Token"/></em></p>
        ///   <p>API token</p>
        /// </summary>
        [Pure]
        public static T SetToken<T>(this T toolSettings, [Secret] string token) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = token;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLogoutSettings.Token"/></em></p>
        ///   <p>API token</p>
        /// </summary>
        [Pure]
        public static T ResetToken<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLogoutSettings.Output"/></em></p>
        ///   <p>Output format: json</p>
        /// </summary>
        [Pure]
        public static T SetOutput<T>(this T toolSettings, AppCenterDistributeReleaseOutput output) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLogoutSettings.Output"/></em></p>
        ///   <p>Output format: json</p>
        /// </summary>
        [Pure]
        public static T ResetOutput<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterLogoutSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T SetDebug<T>(this T toolSettings, bool? debug) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterLogoutSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T ResetDebug<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterLogoutSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T EnableDebug<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterLogoutSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T DisableDebug<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterLogoutSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T ToggleDebug<T>(this T toolSettings) where T : AppCenterLogoutSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = !toolSettings.Debug;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AppCenterAppsCreateSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AppCenterAppsCreateSettingsExtensions
    {
        #region Platform
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Platform"/></em></p>
        ///   <p>The platform of the app. Supported values: Cordova, Java, Objective-C-Swift, React-Native, Unity, UWP, WinForms, WPF, Xamarin, Custom</p>
        /// </summary>
        [Pure]
        public static T SetPlatform<T>(this T toolSettings, AppCenterAppsCreatePlatform platform) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Platform = platform;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Platform"/></em></p>
        ///   <p>The platform of the app. Supported values: Cordova, Java, Objective-C-Swift, React-Native, Unity, UWP, WinForms, WPF, Xamarin, Custom</p>
        /// </summary>
        [Pure]
        public static T ResetPlatform<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Platform = null;
            return toolSettings;
        }
        #endregion
        #region OS
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.OS"/></em></p>
        ///   <p>The OS the app will be running on. Supported values: Android, Custom, iOS, macOS, tvOS, Windows</p>
        /// </summary>
        [Pure]
        public static T SetOS<T>(this T toolSettings, AppCenterAppsCreateOS os) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OS = os;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.OS"/></em></p>
        ///   <p>The OS the app will be running on. Supported values: Android, Custom, iOS, macOS, tvOS, Windows</p>
        /// </summary>
        [Pure]
        public static T ResetOS<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.OS = null;
            return toolSettings;
        }
        #endregion
        #region DisplayName
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.DisplayName"/></em></p>
        ///   <p>The descriptive name of the app. This can contain any characters</p>
        /// </summary>
        [Pure]
        public static T SetDisplayName<T>(this T toolSettings, string displayName) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = displayName;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.DisplayName"/></em></p>
        ///   <p>The descriptive name of the app. This can contain any characters</p>
        /// </summary>
        [Pure]
        public static T ResetDisplayName<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisplayName = null;
            return toolSettings;
        }
        #endregion
        #region ReleaseType
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.ReleaseType"/></em></p>
        ///   <p>The app release type. Suggested values are Alpha, Beta, Production, Store, Enterprise. Custom values are allowed and must be must be one word, alphanumeric, first letter capitalized.</p>
        /// </summary>
        [Pure]
        public static T SetReleaseType<T>(this T toolSettings, AppCenterAppsCreateReleaseType releaseType) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseType = releaseType;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.ReleaseType"/></em></p>
        ///   <p>The app release type. Suggested values are Alpha, Beta, Production, Store, Enterprise. Custom values are allowed and must be must be one word, alphanumeric, first letter capitalized.</p>
        /// </summary>
        [Pure]
        public static T ResetReleaseType<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseType = null;
            return toolSettings;
        }
        #endregion
        #region Name
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Name"/></em></p>
        ///   <p>The name of the app used in URLs. Can optionally be provided specifically, otherwise a generated name will be derived from display-name</p>
        /// </summary>
        [Pure]
        public static T SetName<T>(this T toolSettings, string name) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = name;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Name"/></em></p>
        ///   <p>The name of the app used in URLs. Can optionally be provided specifically, otherwise a generated name will be derived from display-name</p>
        /// </summary>
        [Pure]
        public static T ResetName<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Name = null;
            return toolSettings;
        }
        #endregion
        #region Description
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Description"/></em></p>
        ///   <p>The description of the app</p>
        /// </summary>
        [Pure]
        public static T SetDescription<T>(this T toolSettings, string description) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = description;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Description"/></em></p>
        ///   <p>The description of the app</p>
        /// </summary>
        [Pure]
        public static T ResetDescription<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Description = null;
            return toolSettings;
        }
        #endregion
        #region DisableTelemetry
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T SetDisableTelemetry<T>(this T toolSettings, bool? disableTelemetry) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = disableTelemetry;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T ResetDisableTelemetry<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterAppsCreateSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T EnableDisableTelemetry<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterAppsCreateSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T DisableDisableTelemetry<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterAppsCreateSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T ToggleDisableTelemetry<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = !toolSettings.DisableTelemetry;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T SetVersion<T>(this T toolSettings, bool? version) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T ResetVersion<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterAppsCreateSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T EnableVersion<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterAppsCreateSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T DisableVersion<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterAppsCreateSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T ToggleVersion<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = !toolSettings.Version;
            return toolSettings;
        }
        #endregion
        #region Quiet
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T SetQuiet<T>(this T toolSettings, bool? quiet) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = quiet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T ResetQuiet<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterAppsCreateSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T EnableQuiet<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterAppsCreateSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T DisableQuiet<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterAppsCreateSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T ToggleQuiet<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = !toolSettings.Quiet;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T SetHelp<T>(this T toolSettings, bool? help) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T ResetHelp<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterAppsCreateSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T EnableHelp<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterAppsCreateSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T DisableHelp<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterAppsCreateSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T ToggleHelp<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Env
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Env"/></em></p>
        ///   <p>Environment when using API token</p>
        /// </summary>
        [Pure]
        public static T SetEnv<T>(this T toolSettings, string env) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Env = env;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Env"/></em></p>
        ///   <p>Environment when using API token</p>
        /// </summary>
        [Pure]
        public static T ResetEnv<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Env = null;
            return toolSettings;
        }
        #endregion
        #region Token
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Token"/></em></p>
        ///   <p>API token</p>
        /// </summary>
        [Pure]
        public static T SetToken<T>(this T toolSettings, [Secret] string token) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = token;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Token"/></em></p>
        ///   <p>API token</p>
        /// </summary>
        [Pure]
        public static T ResetToken<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Output"/></em></p>
        ///   <p>Output format: json</p>
        /// </summary>
        [Pure]
        public static T SetOutput<T>(this T toolSettings, AppCenterDistributeReleaseOutput output) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Output"/></em></p>
        ///   <p>Output format: json</p>
        /// </summary>
        [Pure]
        public static T ResetOutput<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterAppsCreateSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T SetDebug<T>(this T toolSettings, bool? debug) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterAppsCreateSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T ResetDebug<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterAppsCreateSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T EnableDebug<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterAppsCreateSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T DisableDebug<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterAppsCreateSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T ToggleDebug<T>(this T toolSettings) where T : AppCenterAppsCreateSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = !toolSettings.Debug;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AppCenterDistributeReleaseSettingsExtensions
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [ExcludeFromCodeCoverage]
    public static partial class AppCenterDistributeReleaseSettingsExtensions
    {
        #region File
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.File"/></em></p>
        ///   <p>Path to binary file</p>
        /// </summary>
        [Pure]
        public static T SetFile<T>(this T toolSettings, string file) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = file;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.File"/></em></p>
        ///   <p>Path to binary file</p>
        /// </summary>
        [Pure]
        public static T ResetFile<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.File = null;
            return toolSettings;
        }
        #endregion
        #region Timeout
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Timeout"/></em></p>
        ///   <p>Timeout for waiting release id (in seconds)</p>
        /// </summary>
        [Pure]
        public static T SetTimeout<T>(this T toolSettings, int? timeout) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = timeout;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Timeout"/></em></p>
        ///   <p>Timeout for waiting release id (in seconds)</p>
        /// </summary>
        [Pure]
        public static T ResetTimeout<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Timeout = null;
            return toolSettings;
        }
        #endregion
        #region Mandatory
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Mandatory"/></em></p>
        ///   <p>Make the release mandatory for the testers (default is false)</p>
        /// </summary>
        [Pure]
        public static T SetMandatory<T>(this T toolSettings, bool? mandatory) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mandatory = mandatory;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Mandatory"/></em></p>
        ///   <p>Make the release mandatory for the testers (default is false)</p>
        /// </summary>
        [Pure]
        public static T ResetMandatory<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mandatory = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterDistributeReleaseSettings.Mandatory"/></em></p>
        ///   <p>Make the release mandatory for the testers (default is false)</p>
        /// </summary>
        [Pure]
        public static T EnableMandatory<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mandatory = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterDistributeReleaseSettings.Mandatory"/></em></p>
        ///   <p>Make the release mandatory for the testers (default is false)</p>
        /// </summary>
        [Pure]
        public static T DisableMandatory<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mandatory = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterDistributeReleaseSettings.Mandatory"/></em></p>
        ///   <p>Make the release mandatory for the testers (default is false)</p>
        /// </summary>
        [Pure]
        public static T ToggleMandatory<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Mandatory = !toolSettings.Mandatory;
            return toolSettings;
        }
        #endregion
        #region Silent
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Silent"/></em></p>
        ///   <p>Do not notify testers of this release</p>
        /// </summary>
        [Pure]
        public static T SetSilent<T>(this T toolSettings, bool? silent) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Silent = silent;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Silent"/></em></p>
        ///   <p>Do not notify testers of this release</p>
        /// </summary>
        [Pure]
        public static T ResetSilent<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Silent = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterDistributeReleaseSettings.Silent"/></em></p>
        ///   <p>Do not notify testers of this release</p>
        /// </summary>
        [Pure]
        public static T EnableSilent<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Silent = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterDistributeReleaseSettings.Silent"/></em></p>
        ///   <p>Do not notify testers of this release</p>
        /// </summary>
        [Pure]
        public static T DisableSilent<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Silent = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterDistributeReleaseSettings.Silent"/></em></p>
        ///   <p>Do not notify testers of this release</p>
        /// </summary>
        [Pure]
        public static T ToggleSilent<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Silent = !toolSettings.Silent;
            return toolSettings;
        }
        #endregion
        #region ReleaseNotesFile
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.ReleaseNotesFile"/></em></p>
        ///   <p>Path to release notes file (markdown supported, 5000 characters max)</p>
        /// </summary>
        [Pure]
        public static T SetReleaseNotesFile<T>(this T toolSettings, string releaseNotesFile) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNotesFile = releaseNotesFile;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.ReleaseNotesFile"/></em></p>
        ///   <p>Path to release notes file (markdown supported, 5000 characters max)</p>
        /// </summary>
        [Pure]
        public static T ResetReleaseNotesFile<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNotesFile = null;
            return toolSettings;
        }
        #endregion
        #region ReleaseNotes
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.ReleaseNotes"/></em></p>
        ///   <p>Release notes text (5000 characters max)</p>
        /// </summary>
        [Pure]
        public static T SetReleaseNotes<T>(this T toolSettings, string releaseNotes) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNotes = releaseNotes;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.ReleaseNotes"/></em></p>
        ///   <p>Release notes text (5000 characters max)</p>
        /// </summary>
        [Pure]
        public static T ResetReleaseNotes<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.ReleaseNotes = null;
            return toolSettings;
        }
        #endregion
        #region Store
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Store"/></em></p>
        ///   <p>Store name</p>
        /// </summary>
        [Pure]
        public static T SetStore<T>(this T toolSettings, string store) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Store = store;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Store"/></em></p>
        ///   <p>Store name</p>
        /// </summary>
        [Pure]
        public static T ResetStore<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Store = null;
            return toolSettings;
        }
        #endregion
        #region Group
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Group"/> to a new list</em></p>
        ///   <p>Comma-separated distribution group names</p>
        /// </summary>
        [Pure]
        public static T SetGroup<T>(this T toolSettings, params string[] group) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GroupInternal = group.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Group"/> to a new list</em></p>
        ///   <p>Comma-separated distribution group names</p>
        /// </summary>
        [Pure]
        public static T SetGroup<T>(this T toolSettings, IEnumerable<string> group) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GroupInternal = group.ToList();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AppCenterDistributeReleaseSettings.Group"/></em></p>
        ///   <p>Comma-separated distribution group names</p>
        /// </summary>
        [Pure]
        public static T AddGroup<T>(this T toolSettings, params string[] group) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GroupInternal.AddRange(group);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Adds values to <see cref="AppCenterDistributeReleaseSettings.Group"/></em></p>
        ///   <p>Comma-separated distribution group names</p>
        /// </summary>
        [Pure]
        public static T AddGroup<T>(this T toolSettings, IEnumerable<string> group) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GroupInternal.AddRange(group);
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Clears <see cref="AppCenterDistributeReleaseSettings.Group"/></em></p>
        ///   <p>Comma-separated distribution group names</p>
        /// </summary>
        [Pure]
        public static T ClearGroup<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.GroupInternal.Clear();
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AppCenterDistributeReleaseSettings.Group"/></em></p>
        ///   <p>Comma-separated distribution group names</p>
        /// </summary>
        [Pure]
        public static T RemoveGroup<T>(this T toolSettings, params string[] group) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(group);
            toolSettings.GroupInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Removes values from <see cref="AppCenterDistributeReleaseSettings.Group"/></em></p>
        ///   <p>Comma-separated distribution group names</p>
        /// </summary>
        [Pure]
        public static T RemoveGroup<T>(this T toolSettings, IEnumerable<string> group) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            var hashSet = new HashSet<string>(group);
            toolSettings.GroupInternal.RemoveAll(x => hashSet.Contains(x));
            return toolSettings;
        }
        #endregion
        #region BuildNumber
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.BuildNumber"/></em></p>
        ///   <p>Build number parameter required for macOS .pkg and .dmg files</p>
        /// </summary>
        [Pure]
        public static T SetBuildNumber<T>(this T toolSettings, string buildNumber) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildNumber = buildNumber;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.BuildNumber"/></em></p>
        ///   <p>Build number parameter required for macOS .pkg and .dmg files</p>
        /// </summary>
        [Pure]
        public static T ResetBuildNumber<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildNumber = null;
            return toolSettings;
        }
        #endregion
        #region BuildVersion
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.BuildVersion"/></em></p>
        ///   <p>Build version parameter required for .zip, .msi, .pkg and .dmg files</p>
        /// </summary>
        [Pure]
        public static T SetBuildVersion<T>(this T toolSettings, string buildVersion) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildVersion = buildVersion;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.BuildVersion"/></em></p>
        ///   <p>Build version parameter required for .zip, .msi, .pkg and .dmg files</p>
        /// </summary>
        [Pure]
        public static T ResetBuildVersion<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.BuildVersion = null;
            return toolSettings;
        }
        #endregion
        #region App
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.App"/></em></p>
        ///   <p>Specify app in the &lt;ownerName&gt;/&lt;appName&gt; format</p>
        /// </summary>
        [Pure]
        public static T SetApp<T>(this T toolSettings, string app) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.App = app;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.App"/></em></p>
        ///   <p>Specify app in the &lt;ownerName&gt;/&lt;appName&gt; format</p>
        /// </summary>
        [Pure]
        public static T ResetApp<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.App = null;
            return toolSettings;
        }
        #endregion
        #region DisableTelemetry
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T SetDisableTelemetry<T>(this T toolSettings, bool? disableTelemetry) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = disableTelemetry;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T ResetDisableTelemetry<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterDistributeReleaseSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T EnableDisableTelemetry<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterDistributeReleaseSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T DisableDisableTelemetry<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterDistributeReleaseSettings.DisableTelemetry"/></em></p>
        ///   <p>Disable telemetry for this command</p>
        /// </summary>
        [Pure]
        public static T ToggleDisableTelemetry<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.DisableTelemetry = !toolSettings.DisableTelemetry;
            return toolSettings;
        }
        #endregion
        #region Version
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T SetVersion<T>(this T toolSettings, bool? version) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = version;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T ResetVersion<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterDistributeReleaseSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T EnableVersion<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterDistributeReleaseSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T DisableVersion<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterDistributeReleaseSettings.Version"/></em></p>
        ///   <p>Display AppCenter version</p>
        /// </summary>
        [Pure]
        public static T ToggleVersion<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Version = !toolSettings.Version;
            return toolSettings;
        }
        #endregion
        #region Quiet
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T SetQuiet<T>(this T toolSettings, bool? quiet) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = quiet;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T ResetQuiet<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterDistributeReleaseSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T EnableQuiet<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterDistributeReleaseSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T DisableQuiet<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterDistributeReleaseSettings.Quiet"/></em></p>
        ///   <p>Auto-confirm any prompts without waiting for input</p>
        /// </summary>
        [Pure]
        public static T ToggleQuiet<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Quiet = !toolSettings.Quiet;
            return toolSettings;
        }
        #endregion
        #region Help
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T SetHelp<T>(this T toolSettings, bool? help) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = help;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T ResetHelp<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterDistributeReleaseSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T EnableHelp<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterDistributeReleaseSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T DisableHelp<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterDistributeReleaseSettings.Help"/></em></p>
        ///   <p>Display help for current command</p>
        /// </summary>
        [Pure]
        public static T ToggleHelp<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Help = !toolSettings.Help;
            return toolSettings;
        }
        #endregion
        #region Env
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Env"/></em></p>
        ///   <p>Environment when using API token</p>
        /// </summary>
        [Pure]
        public static T SetEnv<T>(this T toolSettings, string env) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Env = env;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Env"/></em></p>
        ///   <p>Environment when using API token</p>
        /// </summary>
        [Pure]
        public static T ResetEnv<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Env = null;
            return toolSettings;
        }
        #endregion
        #region Token
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Token"/></em></p>
        ///   <p>API token</p>
        /// </summary>
        [Pure]
        public static T SetToken<T>(this T toolSettings, [Secret] string token) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = token;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Token"/></em></p>
        ///   <p>API token</p>
        /// </summary>
        [Pure]
        public static T ResetToken<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Token = null;
            return toolSettings;
        }
        #endregion
        #region Output
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Output"/></em></p>
        ///   <p>Output format: json</p>
        /// </summary>
        [Pure]
        public static T SetOutput<T>(this T toolSettings, AppCenterDistributeReleaseOutput output) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = output;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Output"/></em></p>
        ///   <p>Output format: json</p>
        /// </summary>
        [Pure]
        public static T ResetOutput<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Output = null;
            return toolSettings;
        }
        #endregion
        #region Debug
        /// <summary>
        ///   <p><em>Sets <see cref="AppCenterDistributeReleaseSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T SetDebug<T>(this T toolSettings, bool? debug) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = debug;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Resets <see cref="AppCenterDistributeReleaseSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T ResetDebug<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = null;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Enables <see cref="AppCenterDistributeReleaseSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T EnableDebug<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = true;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Disables <see cref="AppCenterDistributeReleaseSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T DisableDebug<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = false;
            return toolSettings;
        }
        /// <summary>
        ///   <p><em>Toggles <see cref="AppCenterDistributeReleaseSettings.Debug"/></em></p>
        ///   <p>Display extra output for debugging</p>
        /// </summary>
        [Pure]
        public static T ToggleDebug<T>(this T toolSettings) where T : AppCenterDistributeReleaseSettings
        {
            toolSettings = toolSettings.NewInstance();
            toolSettings.Debug = !toolSettings.Debug;
            return toolSettings;
        }
        #endregion
    }
    #endregion
    #region AppCenterAppsCreatePlatform
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AppCenterAppsCreatePlatform>))]
    public partial class AppCenterAppsCreatePlatform : Enumeration
    {
        public static AppCenterAppsCreatePlatform Cordova = (AppCenterAppsCreatePlatform) "Cordova";
        public static AppCenterAppsCreatePlatform Java = (AppCenterAppsCreatePlatform) "Java";
        public static AppCenterAppsCreatePlatform Objective_C_Swift = (AppCenterAppsCreatePlatform) "Objective-C-Swift";
        public static AppCenterAppsCreatePlatform React_Native = (AppCenterAppsCreatePlatform) "React-Native";
        public static AppCenterAppsCreatePlatform Unity = (AppCenterAppsCreatePlatform) "Unity";
        public static AppCenterAppsCreatePlatform UWP = (AppCenterAppsCreatePlatform) "UWP";
        public static AppCenterAppsCreatePlatform Xamarin = (AppCenterAppsCreatePlatform) "Xamarin";
        public static AppCenterAppsCreatePlatform Custom = (AppCenterAppsCreatePlatform) "Custom";
        public static implicit operator AppCenterAppsCreatePlatform(string value)
        {
            return new AppCenterAppsCreatePlatform { Value = value };
        }
    }
    #endregion
    #region AppCenterAppsCreateOs
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AppCenterAppsCreateOs>))]
    public partial class AppCenterAppsCreateOs : Enumeration
    {
        public static AppCenterAppsCreateOs Android = (AppCenterAppsCreateOs) "Android";
        public static AppCenterAppsCreateOs Custom = (AppCenterAppsCreateOs) "Custom";
        public static AppCenterAppsCreateOs iOS = (AppCenterAppsCreateOs) "iOS";
        public static AppCenterAppsCreateOs macOS = (AppCenterAppsCreateOs) "macOS";
        public static AppCenterAppsCreateOs tvOS = (AppCenterAppsCreateOs) "tvOS";
        public static AppCenterAppsCreateOs Windows = (AppCenterAppsCreateOs) "Windows";
        public static implicit operator AppCenterAppsCreateOs(string value)
        {
            return new AppCenterAppsCreateOs { Value = value };
        }
    }
    #endregion
    #region AppCenterAppsCreateReleaseType
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AppCenterAppsCreateReleaseType>))]
    public partial class AppCenterAppsCreateReleaseType : Enumeration
    {
        public static AppCenterAppsCreateReleaseType Alpha = (AppCenterAppsCreateReleaseType) "Alpha";
        public static AppCenterAppsCreateReleaseType Beta = (AppCenterAppsCreateReleaseType) "Beta";
        public static AppCenterAppsCreateReleaseType Production = (AppCenterAppsCreateReleaseType) "Production";
        public static AppCenterAppsCreateReleaseType Store = (AppCenterAppsCreateReleaseType) "Store";
        public static AppCenterAppsCreateReleaseType Enterprise = (AppCenterAppsCreateReleaseType) "Enterprise";
        public static implicit operator AppCenterAppsCreateReleaseType(string value)
        {
            return new AppCenterAppsCreateReleaseType { Value = value };
        }
    }
    #endregion
    #region AppCenterDistributeReleaseOutput
    /// <summary>
    ///   Used within <see cref="AppCenterTasks"/>.
    /// </summary>
    [PublicAPI]
    [Serializable]
    [ExcludeFromCodeCoverage]
    [TypeConverter(typeof(TypeConverter<AppCenterDistributeReleaseOutput>))]
    public partial class AppCenterDistributeReleaseOutput : Enumeration
    {
        public static AppCenterDistributeReleaseOutput json = (AppCenterDistributeReleaseOutput) "json";
        public static implicit operator AppCenterDistributeReleaseOutput(string value)
        {
            return new AppCenterDistributeReleaseOutput { Value = value };
        }
    }
    #endregion
}
