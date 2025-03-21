// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Notebooks.V1
{
    /// <summary>Settings for <see cref="NotebookServiceClient"/> instances.</summary>
    public sealed partial class NotebookServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NotebookServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NotebookServiceSettings"/>.</returns>
        public static NotebookServiceSettings GetDefault() => new NotebookServiceSettings();

        /// <summary>Constructs a new <see cref="NotebookServiceSettings"/> object with default settings.</summary>
        public NotebookServiceSettings()
        {
        }

        private NotebookServiceSettings(NotebookServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings.Clone();
            RegisterInstanceSettings = existing.RegisterInstanceSettings;
            RegisterInstanceOperationsSettings = existing.RegisterInstanceOperationsSettings.Clone();
            SetInstanceAcceleratorSettings = existing.SetInstanceAcceleratorSettings;
            SetInstanceAcceleratorOperationsSettings = existing.SetInstanceAcceleratorOperationsSettings.Clone();
            SetInstanceMachineTypeSettings = existing.SetInstanceMachineTypeSettings;
            SetInstanceMachineTypeOperationsSettings = existing.SetInstanceMachineTypeOperationsSettings.Clone();
            UpdateInstanceConfigSettings = existing.UpdateInstanceConfigSettings;
            UpdateInstanceConfigOperationsSettings = existing.UpdateInstanceConfigOperationsSettings.Clone();
            UpdateShieldedInstanceConfigSettings = existing.UpdateShieldedInstanceConfigSettings;
            UpdateShieldedInstanceConfigOperationsSettings = existing.UpdateShieldedInstanceConfigOperationsSettings.Clone();
            SetInstanceLabelsSettings = existing.SetInstanceLabelsSettings;
            SetInstanceLabelsOperationsSettings = existing.SetInstanceLabelsOperationsSettings.Clone();
            UpdateInstanceMetadataItemsSettings = existing.UpdateInstanceMetadataItemsSettings;
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            DeleteInstanceOperationsSettings = existing.DeleteInstanceOperationsSettings.Clone();
            StartInstanceSettings = existing.StartInstanceSettings;
            StartInstanceOperationsSettings = existing.StartInstanceOperationsSettings.Clone();
            StopInstanceSettings = existing.StopInstanceSettings;
            StopInstanceOperationsSettings = existing.StopInstanceOperationsSettings.Clone();
            ResetInstanceSettings = existing.ResetInstanceSettings;
            ResetInstanceOperationsSettings = existing.ResetInstanceOperationsSettings.Clone();
            ReportInstanceInfoSettings = existing.ReportInstanceInfoSettings;
            ReportInstanceInfoOperationsSettings = existing.ReportInstanceInfoOperationsSettings.Clone();
            IsInstanceUpgradeableSettings = existing.IsInstanceUpgradeableSettings;
            GetInstanceHealthSettings = existing.GetInstanceHealthSettings;
            UpgradeInstanceSettings = existing.UpgradeInstanceSettings;
            UpgradeInstanceOperationsSettings = existing.UpgradeInstanceOperationsSettings.Clone();
            RollbackInstanceSettings = existing.RollbackInstanceSettings;
            RollbackInstanceOperationsSettings = existing.RollbackInstanceOperationsSettings.Clone();
            DiagnoseInstanceSettings = existing.DiagnoseInstanceSettings;
            DiagnoseInstanceOperationsSettings = existing.DiagnoseInstanceOperationsSettings.Clone();
            UpgradeInstanceInternalSettings = existing.UpgradeInstanceInternalSettings;
            UpgradeInstanceInternalOperationsSettings = existing.UpgradeInstanceInternalOperationsSettings.Clone();
            ListEnvironmentsSettings = existing.ListEnvironmentsSettings;
            GetEnvironmentSettings = existing.GetEnvironmentSettings;
            CreateEnvironmentSettings = existing.CreateEnvironmentSettings;
            CreateEnvironmentOperationsSettings = existing.CreateEnvironmentOperationsSettings.Clone();
            DeleteEnvironmentSettings = existing.DeleteEnvironmentSettings;
            DeleteEnvironmentOperationsSettings = existing.DeleteEnvironmentOperationsSettings.Clone();
            ListSchedulesSettings = existing.ListSchedulesSettings;
            GetScheduleSettings = existing.GetScheduleSettings;
            DeleteScheduleSettings = existing.DeleteScheduleSettings;
            DeleteScheduleOperationsSettings = existing.DeleteScheduleOperationsSettings.Clone();
            CreateScheduleSettings = existing.CreateScheduleSettings;
            CreateScheduleOperationsSettings = existing.CreateScheduleOperationsSettings.Clone();
            TriggerScheduleSettings = existing.TriggerScheduleSettings;
            TriggerScheduleOperationsSettings = existing.TriggerScheduleOperationsSettings.Clone();
            ListExecutionsSettings = existing.ListExecutionsSettings;
            GetExecutionSettings = existing.GetExecutionSettings;
            DeleteExecutionSettings = existing.DeleteExecutionSettings;
            DeleteExecutionOperationsSettings = existing.DeleteExecutionOperationsSettings.Clone();
            CreateExecutionSettings = existing.CreateExecutionSettings;
            CreateExecutionOperationsSettings = existing.CreateExecutionOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(NotebookServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.ListInstances</c> and <c>NotebookServiceClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.GetInstance</c> and <c>NotebookServiceClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.CreateInstance</c> and <c>NotebookServiceClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.CreateInstance</c> and
        /// <c>NotebookServiceClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.RegisterInstance</c> and <c>NotebookServiceClient.RegisterInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RegisterInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.RegisterInstance</c> and
        /// <c>NotebookServiceClient.RegisterInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RegisterInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.SetInstanceAccelerator</c> and <c>NotebookServiceClient.SetInstanceAcceleratorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetInstanceAcceleratorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.SetInstanceAccelerator</c> and
        /// <c>NotebookServiceClient.SetInstanceAcceleratorAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetInstanceAcceleratorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.SetInstanceMachineType</c> and <c>NotebookServiceClient.SetInstanceMachineTypeAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetInstanceMachineTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.SetInstanceMachineType</c> and
        /// <c>NotebookServiceClient.SetInstanceMachineTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetInstanceMachineTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.UpdateInstanceConfig</c> and <c>NotebookServiceClient.UpdateInstanceConfigAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.UpdateInstanceConfig</c> and
        /// <c>NotebookServiceClient.UpdateInstanceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateInstanceConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.UpdateShieldedInstanceConfig</c> and
        /// <c>NotebookServiceClient.UpdateShieldedInstanceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateShieldedInstanceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.UpdateShieldedInstanceConfig</c> and
        /// <c>NotebookServiceClient.UpdateShieldedInstanceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateShieldedInstanceConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.SetInstanceLabels</c> and <c>NotebookServiceClient.SetInstanceLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetInstanceLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.SetInstanceLabels</c> and
        /// <c>NotebookServiceClient.SetInstanceLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetInstanceLabelsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.UpdateInstanceMetadataItems</c> and
        /// <c>NotebookServiceClient.UpdateInstanceMetadataItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInstanceMetadataItemsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.DeleteInstance</c> and <c>NotebookServiceClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.DeleteInstance</c> and
        /// <c>NotebookServiceClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.StartInstance</c> and <c>NotebookServiceClient.StartInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.StartInstance</c> and
        /// <c>NotebookServiceClient.StartInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings StartInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.StopInstance</c> and <c>NotebookServiceClient.StopInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.StopInstance</c> and
        /// <c>NotebookServiceClient.StopInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings StopInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.ResetInstance</c> and <c>NotebookServiceClient.ResetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.ResetInstance</c> and
        /// <c>NotebookServiceClient.ResetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ResetInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.ReportInstanceInfo</c> and <c>NotebookServiceClient.ReportInstanceInfoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReportInstanceInfoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.ReportInstanceInfo</c> and
        /// <c>NotebookServiceClient.ReportInstanceInfoAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ReportInstanceInfoOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.IsInstanceUpgradeable</c> and <c>NotebookServiceClient.IsInstanceUpgradeableAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings IsInstanceUpgradeableSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.GetInstanceHealth</c> and <c>NotebookServiceClient.GetInstanceHealthAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstanceHealthSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.UpgradeInstance</c> and <c>NotebookServiceClient.UpgradeInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpgradeInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.UpgradeInstance</c> and
        /// <c>NotebookServiceClient.UpgradeInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpgradeInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.RollbackInstance</c> and <c>NotebookServiceClient.RollbackInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.RollbackInstance</c> and
        /// <c>NotebookServiceClient.RollbackInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings RollbackInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.DiagnoseInstance</c> and <c>NotebookServiceClient.DiagnoseInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DiagnoseInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.DiagnoseInstance</c> and
        /// <c>NotebookServiceClient.DiagnoseInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DiagnoseInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.UpgradeInstanceInternal</c> and
        /// <c>NotebookServiceClient.UpgradeInstanceInternalAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpgradeInstanceInternalSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.UpgradeInstanceInternal</c> and
        /// <c>NotebookServiceClient.UpgradeInstanceInternalAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpgradeInstanceInternalOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.ListEnvironments</c> and <c>NotebookServiceClient.ListEnvironmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEnvironmentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.GetEnvironment</c> and <c>NotebookServiceClient.GetEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.CreateEnvironment</c> and <c>NotebookServiceClient.CreateEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.CreateEnvironment</c> and
        /// <c>NotebookServiceClient.CreateEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.DeleteEnvironment</c> and <c>NotebookServiceClient.DeleteEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEnvironmentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.DeleteEnvironment</c> and
        /// <c>NotebookServiceClient.DeleteEnvironmentAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteEnvironmentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.ListSchedules</c> and <c>NotebookServiceClient.ListSchedulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSchedulesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.GetSchedule</c> and <c>NotebookServiceClient.GetScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetScheduleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.DeleteSchedule</c> and <c>NotebookServiceClient.DeleteScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteScheduleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.DeleteSchedule</c> and
        /// <c>NotebookServiceClient.DeleteScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteScheduleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.CreateSchedule</c> and <c>NotebookServiceClient.CreateScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateScheduleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.CreateSchedule</c> and
        /// <c>NotebookServiceClient.CreateScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateScheduleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.TriggerSchedule</c> and <c>NotebookServiceClient.TriggerScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TriggerScheduleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.TriggerSchedule</c> and
        /// <c>NotebookServiceClient.TriggerScheduleAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings TriggerScheduleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.ListExecutions</c> and <c>NotebookServiceClient.ListExecutionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExecutionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.GetExecution</c> and <c>NotebookServiceClient.GetExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.DeleteExecution</c> and <c>NotebookServiceClient.DeleteExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.DeleteExecution</c> and
        /// <c>NotebookServiceClient.DeleteExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteExecutionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotebookServiceClient.CreateExecution</c> and <c>NotebookServiceClient.CreateExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateExecutionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>NotebookServiceClient.CreateExecution</c> and
        /// <c>NotebookServiceClient.CreateExecutionAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateExecutionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NotebookServiceSettings"/> object.</returns>
        public NotebookServiceSettings Clone() => new NotebookServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NotebookServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class NotebookServiceClientBuilder : gaxgrpc::ClientBuilderBase<NotebookServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NotebookServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NotebookServiceClientBuilder() : base(NotebookServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NotebookServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NotebookServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NotebookServiceClient Build()
        {
            NotebookServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NotebookServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NotebookServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NotebookServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NotebookServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NotebookServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NotebookServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NotebookServiceClient.ChannelPool;
    }

    /// <summary>NotebookService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API v1 service for Cloud AI Platform Notebooks.
    /// </remarks>
    public abstract partial class NotebookServiceClient
    {
        /// <summary>
        /// The default endpoint for the NotebookService service, which is a host of "notebooks.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "notebooks.googleapis.com:443";

        /// <summary>The default NotebookService scopes.</summary>
        /// <remarks>
        /// The default NotebookService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NotebookService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NotebookServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NotebookServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NotebookServiceClient"/>.</returns>
        public static stt::Task<NotebookServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NotebookServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NotebookServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NotebookServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NotebookServiceClient"/>.</returns>
        public static NotebookServiceClient Create() => new NotebookServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NotebookServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NotebookServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NotebookServiceClient"/>.</returns>
        internal static NotebookServiceClient Create(grpccore::CallInvoker callInvoker, NotebookServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NotebookService.NotebookServiceClient grpcClient = new NotebookService.NotebookServiceClient(callInvoker);
            return new NotebookServiceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC NotebookService client</summary>
        public virtual NotebookService.NotebookServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInstances(request, callSettings);
        }

        /// <summary>
        /// Lists instances in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInstancesRequest request = new ListInstancesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInstancesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instance GetInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstance(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceAsync(new GetInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instance> GetInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public virtual lro::OperationsClient CreateInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceCreateInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceCreateInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="instance">
        /// Required. The instance to be created.
        /// </param>
        /// <param name="instanceId">
        /// Required. User-defined unique ID of this instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> CreateInstance(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstance(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="instance">
        /// Required. The instance to be created.
        /// </param>
        /// <param name="instanceId">
        /// Required. User-defined unique ID of this instance.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstanceAsync(new CreateInstanceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
            }, callSettings);

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="instance">
        /// Required. The instance to be created.
        /// </param>
        /// <param name="instanceId">
        /// Required. User-defined unique ID of this instance.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(string parent, Instance instance, string instanceId, st::CancellationToken cancellationToken) =>
            CreateInstanceAsync(parent, instance, instanceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers an existing legacy notebook instance to the Notebooks API server.
        /// Legacy instances are instances created with the legacy Compute Engine
        /// calls. They are not manageable by the Notebooks API out of the box. This
        /// call makes these instances manageable by the Notebooks API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RegisterInstance(RegisterInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers an existing legacy notebook instance to the Notebooks API server.
        /// Legacy instances are instances created with the legacy Compute Engine
        /// calls. They are not manageable by the Notebooks API out of the box. This
        /// call makes these instances manageable by the Notebooks API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RegisterInstanceAsync(RegisterInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers an existing legacy notebook instance to the Notebooks API server.
        /// Legacy instances are instances created with the legacy Compute Engine
        /// calls. They are not manageable by the Notebooks API out of the box. This
        /// call makes these instances manageable by the Notebooks API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RegisterInstanceAsync(RegisterInstanceRequest request, st::CancellationToken cancellationToken) =>
            RegisterInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RegisterInstance</c>.</summary>
        public virtual lro::OperationsClient RegisterInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RegisterInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceRegisterInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RegisterInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RegisterInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceRegisterInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RegisterInstanceOperationsClient, callSettings);

        /// <summary>
        /// Updates the guest accelerators of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> SetInstanceAccelerator(SetInstanceAcceleratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the guest accelerators of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> SetInstanceAcceleratorAsync(SetInstanceAcceleratorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the guest accelerators of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> SetInstanceAcceleratorAsync(SetInstanceAcceleratorRequest request, st::CancellationToken cancellationToken) =>
            SetInstanceAcceleratorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetInstanceAccelerator</c>.</summary>
        public virtual lro::OperationsClient SetInstanceAcceleratorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetInstanceAccelerator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceSetInstanceAccelerator(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetInstanceAcceleratorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetInstanceAccelerator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceSetInstanceAcceleratorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetInstanceAcceleratorOperationsClient, callSettings);

        /// <summary>
        /// Updates the machine type of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> SetInstanceMachineType(SetInstanceMachineTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the machine type of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> SetInstanceMachineTypeAsync(SetInstanceMachineTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the machine type of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> SetInstanceMachineTypeAsync(SetInstanceMachineTypeRequest request, st::CancellationToken cancellationToken) =>
            SetInstanceMachineTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetInstanceMachineType</c>.</summary>
        public virtual lro::OperationsClient SetInstanceMachineTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetInstanceMachineType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceSetInstanceMachineType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetInstanceMachineTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetInstanceMachineType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceSetInstanceMachineTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetInstanceMachineTypeOperationsClient, callSettings);

        /// <summary>
        /// Update Notebook Instance configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateInstanceConfig(UpdateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update Notebook Instance configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceConfigAsync(UpdateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update Notebook Instance configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceConfigAsync(UpdateInstanceConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateInstanceConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateInstanceConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstanceConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpdateInstanceConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateInstanceConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpdateInstanceConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates the Shielded instance configuration of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpdateShieldedInstanceConfig(UpdateShieldedInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Shielded instance configuration of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Shielded instance configuration of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateShieldedInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateShieldedInstanceConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateShieldedInstanceConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateShieldedInstanceConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpdateShieldedInstanceConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateShieldedInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateShieldedInstanceConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpdateShieldedInstanceConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateShieldedInstanceConfigOperationsClient, callSettings);

        /// <summary>
        /// Replaces all the labels of an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> SetInstanceLabels(SetInstanceLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces all the labels of an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> SetInstanceLabelsAsync(SetInstanceLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces all the labels of an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> SetInstanceLabelsAsync(SetInstanceLabelsRequest request, st::CancellationToken cancellationToken) =>
            SetInstanceLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetInstanceLabels</c>.</summary>
        public virtual lro::OperationsClient SetInstanceLabelsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetInstanceLabels</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceSetInstanceLabels(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetInstanceLabelsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetInstanceLabels</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceSetInstanceLabelsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetInstanceLabelsOperationsClient, callSettings);

        /// <summary>
        /// Add/update metadata items for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateInstanceMetadataItemsResponse UpdateInstanceMetadataItems(UpdateInstanceMetadataItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add/update metadata items for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateInstanceMetadataItemsResponse> UpdateInstanceMetadataItemsAsync(UpdateInstanceMetadataItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add/update metadata items for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateInstanceMetadataItemsResponse> UpdateInstanceMetadataItemsAsync(UpdateInstanceMetadataItemsRequest request, st::CancellationToken cancellationToken) =>
            UpdateInstanceMetadataItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public virtual lro::OperationsClient DeleteInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteInstanceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstance(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstanceAsync(new DeleteInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstanceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> StartInstance(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> StartInstanceAsync(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> StartInstanceAsync(StartInstanceRequest request, st::CancellationToken cancellationToken) =>
            StartInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartInstance</c>.</summary>
        public virtual lro::OperationsClient StartInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceStartInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceStartInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartInstanceOperationsClient, callSettings);

        /// <summary>
        /// Stops a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> StopInstance(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> StopInstanceAsync(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> StopInstanceAsync(StopInstanceRequest request, st::CancellationToken cancellationToken) =>
            StopInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StopInstance</c>.</summary>
        public virtual lro::OperationsClient StopInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StopInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceStopInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StopInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceStopInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StopInstanceOperationsClient, callSettings);

        /// <summary>
        /// Resets a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ResetInstance(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ResetInstanceAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resets a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ResetInstanceAsync(ResetInstanceRequest request, st::CancellationToken cancellationToken) =>
            ResetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResetInstance</c>.</summary>
        public virtual lro::OperationsClient ResetInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResetInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceResetInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResetInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceResetInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResetInstanceOperationsClient, callSettings);

        /// <summary>
        /// Allows notebook instances to
        /// report their latest instance information to the Notebooks
        /// API server. The server will merge the reported information to
        /// the instance metadata store. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> ReportInstanceInfo(ReportInstanceInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows notebook instances to
        /// report their latest instance information to the Notebooks
        /// API server. The server will merge the reported information to
        /// the instance metadata store. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ReportInstanceInfoAsync(ReportInstanceInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows notebook instances to
        /// report their latest instance information to the Notebooks
        /// API server. The server will merge the reported information to
        /// the instance metadata store. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> ReportInstanceInfoAsync(ReportInstanceInfoRequest request, st::CancellationToken cancellationToken) =>
            ReportInstanceInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReportInstanceInfo</c>.</summary>
        public virtual lro::OperationsClient ReportInstanceInfoOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReportInstanceInfo</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceReportInstanceInfo(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReportInstanceInfoOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReportInstanceInfo</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceReportInstanceInfoAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReportInstanceInfoOperationsClient, callSettings);

        /// <summary>
        /// Check if a notebook instance is upgradable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IsInstanceUpgradeableResponse IsInstanceUpgradeable(IsInstanceUpgradeableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Check if a notebook instance is upgradable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IsInstanceUpgradeableResponse> IsInstanceUpgradeableAsync(IsInstanceUpgradeableRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Check if a notebook instance is upgradable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IsInstanceUpgradeableResponse> IsInstanceUpgradeableAsync(IsInstanceUpgradeableRequest request, st::CancellationToken cancellationToken) =>
            IsInstanceUpgradeableAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetInstanceHealthResponse GetInstanceHealth(GetInstanceHealthRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetInstanceHealthResponse> GetInstanceHealthAsync(GetInstanceHealthRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetInstanceHealthResponse> GetInstanceHealthAsync(GetInstanceHealthRequest request, st::CancellationToken cancellationToken) =>
            GetInstanceHealthAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetInstanceHealthResponse GetInstanceHealth(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceHealth(new GetInstanceHealthRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetInstanceHealthResponse> GetInstanceHealthAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceHealthAsync(new GetInstanceHealthRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetInstanceHealthResponse> GetInstanceHealthAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstanceHealthAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetInstanceHealthResponse GetInstanceHealth(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceHealth(new GetInstanceHealthRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetInstanceHealthResponse> GetInstanceHealthAsync(InstanceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstanceHealthAsync(new GetInstanceHealthRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetInstanceHealthResponse> GetInstanceHealthAsync(InstanceName name, st::CancellationToken cancellationToken) =>
            GetInstanceHealthAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Upgrades a notebook instance to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpgradeInstance(UpgradeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades a notebook instance to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpgradeInstanceAsync(UpgradeInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Upgrades a notebook instance to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpgradeInstanceAsync(UpgradeInstanceRequest request, st::CancellationToken cancellationToken) =>
            UpgradeInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpgradeInstance</c>.</summary>
        public virtual lro::OperationsClient UpgradeInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpgradeInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpgradeInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpgradeInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpgradeInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeInstanceOperationsClient, callSettings);

        /// <summary>
        /// Rollbacks a notebook instance to the previous version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> RollbackInstance(RollbackInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rollbacks a notebook instance to the previous version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RollbackInstanceAsync(RollbackInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rollbacks a notebook instance to the previous version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> RollbackInstanceAsync(RollbackInstanceRequest request, st::CancellationToken cancellationToken) =>
            RollbackInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RollbackInstance</c>.</summary>
        public virtual lro::OperationsClient RollbackInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RollbackInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceRollbackInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RollbackInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RollbackInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceRollbackInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RollbackInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> DiagnoseInstance(DiagnoseInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DiagnoseInstanceAsync(DiagnoseInstanceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DiagnoseInstanceAsync(DiagnoseInstanceRequest request, st::CancellationToken cancellationToken) =>
            DiagnoseInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DiagnoseInstance</c>.</summary>
        public virtual lro::OperationsClient DiagnoseInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DiagnoseInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceDiagnoseInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DiagnoseInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DiagnoseInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceDiagnoseInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DiagnoseInstanceOperationsClient, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> DiagnoseInstance(string name, DiagnosticConfig diagnosticConfig, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseInstance(new DiagnoseInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DiagnosticConfig = gax::GaxPreconditions.CheckNotNull(diagnosticConfig, nameof(diagnosticConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DiagnoseInstanceAsync(string name, DiagnosticConfig diagnosticConfig, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseInstanceAsync(new DiagnoseInstanceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DiagnosticConfig = gax::GaxPreconditions.CheckNotNull(diagnosticConfig, nameof(diagnosticConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DiagnoseInstanceAsync(string name, DiagnosticConfig diagnosticConfig, st::CancellationToken cancellationToken) =>
            DiagnoseInstanceAsync(name, diagnosticConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> DiagnoseInstance(InstanceName name, DiagnosticConfig diagnosticConfig, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseInstance(new DiagnoseInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DiagnosticConfig = gax::GaxPreconditions.CheckNotNull(diagnosticConfig, nameof(diagnosticConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DiagnoseInstanceAsync(InstanceName name, DiagnosticConfig diagnosticConfig, gaxgrpc::CallSettings callSettings = null) =>
            DiagnoseInstanceAsync(new DiagnoseInstanceRequest
            {
                InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DiagnosticConfig = gax::GaxPreconditions.CheckNotNull(diagnosticConfig, nameof(diagnosticConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/instances/{instance_id}`
        /// </param>
        /// <param name="diagnosticConfig">
        /// Required. Defines flags that are used to run the diagnostic tool
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> DiagnoseInstanceAsync(InstanceName name, DiagnosticConfig diagnosticConfig, st::CancellationToken cancellationToken) =>
            DiagnoseInstanceAsync(name, diagnosticConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Allows notebook instances to
        /// call this endpoint to upgrade themselves. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> UpgradeInstanceInternal(UpgradeInstanceInternalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows notebook instances to
        /// call this endpoint to upgrade themselves. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpgradeInstanceInternalAsync(UpgradeInstanceInternalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Allows notebook instances to
        /// call this endpoint to upgrade themselves. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> UpgradeInstanceInternalAsync(UpgradeInstanceInternalRequest request, st::CancellationToken cancellationToken) =>
            UpgradeInstanceInternalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpgradeInstanceInternal</c>.</summary>
        public virtual lro::OperationsClient UpgradeInstanceInternalOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpgradeInstanceInternal</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, OperationMetadata> PollOnceUpgradeInstanceInternal(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeInstanceInternalOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpgradeInstanceInternal</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, OperationMetadata>> PollOnceUpgradeInstanceInternalAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instance, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpgradeInstanceInternalOperationsClient, callSettings);

        /// <summary>
        /// Lists environments in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists environments in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists environments in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEnvironments(request, callSettings);
        }

        /// <summary>
        /// Lists environments in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEnvironmentsRequest request = new ListEnvironmentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEnvironmentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Environment.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/environments/{environment_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Environment GetEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironment(new GetEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Environment.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/environments/{environment_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEnvironmentAsync(new GetEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Environment.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/environments/{environment_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Environment> GetEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            GetEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public virtual lro::OperationsClient CreateEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> PollOnceCreateEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> PollOnceCreateEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Environment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Environment.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="environment">
        /// Required. The environment to be created.
        /// </param>
        /// <param name="environmentId">
        /// Required. User-defined unique ID of this environment. The `environment_id` must
        /// be 1 to 63 characters long and contain only lowercase letters,
        /// numeric characters, and dashes. The first character must be a lowercase
        /// letter and the last character cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Environment, OperationMetadata> CreateEnvironment(string parent, Environment environment, string environmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironment(new CreateEnvironmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EnvironmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Creates a new Environment.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="environment">
        /// Required. The environment to be created.
        /// </param>
        /// <param name="environmentId">
        /// Required. User-defined unique ID of this environment. The `environment_id` must
        /// be 1 to 63 characters long and contain only lowercase letters,
        /// numeric characters, and dashes. The first character must be a lowercase
        /// letter and the last character cannot be a dash.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(string parent, Environment environment, string environmentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEnvironmentAsync(new CreateEnvironmentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EnvironmentId = gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)),
                Environment = gax::GaxPreconditions.CheckNotNull(environment, nameof(environment)),
            }, callSettings);

        /// <summary>
        /// Creates a new Environment.
        /// </summary>
        /// <param name="parent">
        /// Required. Format: `projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="environment">
        /// Required. The environment to be created.
        /// </param>
        /// <param name="environmentId">
        /// Required. User-defined unique ID of this environment. The `environment_id` must
        /// be 1 to 63 characters long and contain only lowercase letters,
        /// numeric characters, and dashes. The first character must be a lowercase
        /// letter and the last character cannot be a dash.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(string parent, Environment environment, string environmentId, st::CancellationToken cancellationToken) =>
            CreateEnvironmentAsync(parent, environment, environmentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEnvironment</c>.</summary>
        public virtual lro::OperationsClient DeleteEnvironmentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEnvironment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEnvironment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEnvironment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEnvironmentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEnvironmentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Environment.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/environments/{environment_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironment(new DeleteEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Environment.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/environments/{environment_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEnvironmentAsync(new DeleteEnvironmentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Environment.
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/environments/{environment_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEnvironmentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists schedules in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchedulesResponse, Schedule> ListSchedules(ListSchedulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists schedules in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchedulesResponse, Schedule> ListSchedulesAsync(ListSchedulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists schedules in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchedulesResponse, Schedule> ListSchedules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchedulesRequest request = new ListSchedulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSchedules(request, callSettings);
        }

        /// <summary>
        /// Lists schedules in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchedulesResponse, Schedule> ListSchedulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchedulesRequest request = new ListSchedulesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSchedulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists schedules in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSchedulesResponse, Schedule> ListSchedules(ScheduleName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchedulesRequest request = new ListSchedulesRequest
            {
                ParentAsScheduleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSchedules(request, callSettings);
        }

        /// <summary>
        /// Lists schedules in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schedule"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSchedulesResponse, Schedule> ListSchedulesAsync(ScheduleName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSchedulesRequest request = new ListSchedulesRequest
            {
                ParentAsScheduleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSchedulesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule GetSchedule(GetScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(GetScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(GetScheduleRequest request, st::CancellationToken cancellationToken) =>
            GetScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule GetSchedule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchedule(new GetScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScheduleAsync(new GetScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(string name, st::CancellationToken cancellationToken) =>
            GetScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Schedule GetSchedule(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSchedule(new GetScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScheduleAsync(new GetScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Schedule> GetScheduleAsync(ScheduleName name, st::CancellationToken cancellationToken) =>
            GetScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSchedule(DeleteScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScheduleAsync(DeleteScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScheduleAsync(DeleteScheduleRequest request, st::CancellationToken cancellationToken) =>
            DeleteScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteSchedule</c>.</summary>
        public virtual lro::OperationsClient DeleteScheduleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteSchedule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteSchedule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScheduleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteSchedule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteScheduleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteScheduleOperationsClient, callSettings);

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSchedule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchedule(new DeleteScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScheduleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScheduleAsync(new DeleteScheduleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScheduleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteSchedule(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSchedule(new DeleteScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScheduleAsync(ScheduleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScheduleAsync(new DeleteScheduleRequest
            {
                ScheduleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/schedules/{schedule_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScheduleAsync(ScheduleName name, st::CancellationToken cancellationToken) =>
            DeleteScheduleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Schedule, OperationMetadata> CreateSchedule(CreateScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> CreateScheduleAsync(CreateScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> CreateScheduleAsync(CreateScheduleRequest request, st::CancellationToken cancellationToken) =>
            CreateScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateSchedule</c>.</summary>
        public virtual lro::OperationsClient CreateScheduleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateSchedule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Schedule, OperationMetadata> PollOnceCreateSchedule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Schedule, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateScheduleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateSchedule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> PollOnceCreateScheduleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Schedule, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateScheduleOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The schedule to be created.
        /// </param>
        /// <param name="scheduleId">
        /// Required. User-defined unique ID of this schedule.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Schedule, OperationMetadata> CreateSchedule(string parent, Schedule schedule, string scheduleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchedule(new CreateScheduleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScheduleId = gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)),
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
            }, callSettings);

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The schedule to be created.
        /// </param>
        /// <param name="scheduleId">
        /// Required. User-defined unique ID of this schedule.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> CreateScheduleAsync(string parent, Schedule schedule, string scheduleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduleAsync(new CreateScheduleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScheduleId = gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)),
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
            }, callSettings);

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The schedule to be created.
        /// </param>
        /// <param name="scheduleId">
        /// Required. User-defined unique ID of this schedule.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> CreateScheduleAsync(string parent, Schedule schedule, string scheduleId, st::CancellationToken cancellationToken) =>
            CreateScheduleAsync(parent, schedule, scheduleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The schedule to be created.
        /// </param>
        /// <param name="scheduleId">
        /// Required. User-defined unique ID of this schedule.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Schedule, OperationMetadata> CreateSchedule(ScheduleName parent, Schedule schedule, string scheduleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSchedule(new CreateScheduleRequest
            {
                ParentAsScheduleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScheduleId = gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)),
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
            }, callSettings);

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The schedule to be created.
        /// </param>
        /// <param name="scheduleId">
        /// Required. User-defined unique ID of this schedule.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> CreateScheduleAsync(ScheduleName parent, Schedule schedule, string scheduleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduleAsync(new CreateScheduleRequest
            {
                ParentAsScheduleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScheduleId = gax::GaxPreconditions.CheckNotNullOrEmpty(scheduleId, nameof(scheduleId)),
                Schedule = gax::GaxPreconditions.CheckNotNull(schedule, nameof(schedule)),
            }, callSettings);

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="schedule">
        /// Required. The schedule to be created.
        /// </param>
        /// <param name="scheduleId">
        /// Required. User-defined unique ID of this schedule.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> CreateScheduleAsync(ScheduleName parent, Schedule schedule, string scheduleId, st::CancellationToken cancellationToken) =>
            CreateScheduleAsync(parent, schedule, scheduleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Triggers execution of an existing schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Schedule, OperationMetadata> TriggerSchedule(TriggerScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers execution of an existing schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> TriggerScheduleAsync(TriggerScheduleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Triggers execution of an existing schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> TriggerScheduleAsync(TriggerScheduleRequest request, st::CancellationToken cancellationToken) =>
            TriggerScheduleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TriggerSchedule</c>.</summary>
        public virtual lro::OperationsClient TriggerScheduleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TriggerSchedule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Schedule, OperationMetadata> PollOnceTriggerSchedule(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Schedule, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TriggerScheduleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TriggerSchedule</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Schedule, OperationMetadata>> PollOnceTriggerScheduleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Schedule, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TriggerScheduleOperationsClient, callSettings);

        /// <summary>
        /// Lists executions in a given project and location
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists executions in a given project and location
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists executions in a given project and location
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExecutions(request, callSettings);
        }

        /// <summary>
        /// Lists executions in a given project and location
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExecutionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists executions in a given project and location
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(ExecutionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsExecutionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExecutions(request, callSettings);
        }

        /// <summary>
        /// Lists executions in a given project and location
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(ExecutionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExecutionsRequest request = new ListExecutionsRequest
            {
                ParentAsExecutionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExecutionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecution(new GetExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecutionAsync(new GetExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(string name, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Execution GetExecution(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecution(new GetExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetExecutionAsync(new GetExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Execution> GetExecutionAsync(ExecutionName name, st::CancellationToken cancellationToken) =>
            GetExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExecution(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(DeleteExecutionRequest request, st::CancellationToken cancellationToken) =>
            DeleteExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteExecution</c>.</summary>
        public virtual lro::OperationsClient DeleteExecutionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteExecution</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteExecution(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExecutionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteExecution</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteExecutionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteExecutionOperationsClient, callSettings);

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExecution(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecution(new DeleteExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecutionAsync(new DeleteExecutionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteExecution(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecution(new DeleteExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(ExecutionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteExecutionAsync(new DeleteExecutionRequest
            {
                ExecutionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="name">
        /// Required. Format:
        /// `projects/{project_id}/locations/{location}/executions/{execution_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(ExecutionName name, st::CancellationToken cancellationToken) =>
            DeleteExecutionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Execution, OperationMetadata> CreateExecution(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> CreateExecutionAsync(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> CreateExecutionAsync(CreateExecutionRequest request, st::CancellationToken cancellationToken) =>
            CreateExecutionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateExecution</c>.</summary>
        public virtual lro::OperationsClient CreateExecutionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateExecution</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Execution, OperationMetadata> PollOnceCreateExecution(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Execution, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateExecutionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateExecution</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> PollOnceCreateExecutionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Execution, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateExecutionOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="execution">
        /// Required. The execution to be created.
        /// </param>
        /// <param name="executionId">
        /// Required. User-defined unique ID of this execution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Execution, OperationMetadata> CreateExecution(string parent, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecution(new CreateExecutionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExecutionId = gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="execution">
        /// Required. The execution to be created.
        /// </param>
        /// <param name="executionId">
        /// Required. User-defined unique ID of this execution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> CreateExecutionAsync(string parent, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecutionAsync(new CreateExecutionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ExecutionId = gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="execution">
        /// Required. The execution to be created.
        /// </param>
        /// <param name="executionId">
        /// Required. User-defined unique ID of this execution.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> CreateExecutionAsync(string parent, Execution execution, string executionId, st::CancellationToken cancellationToken) =>
            CreateExecutionAsync(parent, execution, executionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="execution">
        /// Required. The execution to be created.
        /// </param>
        /// <param name="executionId">
        /// Required. User-defined unique ID of this execution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Execution, OperationMetadata> CreateExecution(ExecutionName parent, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecution(new CreateExecutionRequest
            {
                ParentAsExecutionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExecutionId = gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="execution">
        /// Required. The execution to be created.
        /// </param>
        /// <param name="executionId">
        /// Required. User-defined unique ID of this execution.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> CreateExecutionAsync(ExecutionName parent, Execution execution, string executionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateExecutionAsync(new CreateExecutionRequest
            {
                ParentAsExecutionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ExecutionId = gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)),
                Execution = gax::GaxPreconditions.CheckNotNull(execution, nameof(execution)),
            }, callSettings);

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Format:
        /// `parent=projects/{project_id}/locations/{location}`
        /// </param>
        /// <param name="execution">
        /// Required. The execution to be created.
        /// </param>
        /// <param name="executionId">
        /// Required. User-defined unique ID of this execution.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Execution, OperationMetadata>> CreateExecutionAsync(ExecutionName parent, Execution execution, string executionId, st::CancellationToken cancellationToken) =>
            CreateExecutionAsync(parent, execution, executionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NotebookService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API v1 service for Cloud AI Platform Notebooks.
    /// </remarks>
    public sealed partial class NotebookServiceClientImpl : NotebookServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;

        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;

        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;

        private readonly gaxgrpc::ApiCall<RegisterInstanceRequest, lro::Operation> _callRegisterInstance;

        private readonly gaxgrpc::ApiCall<SetInstanceAcceleratorRequest, lro::Operation> _callSetInstanceAccelerator;

        private readonly gaxgrpc::ApiCall<SetInstanceMachineTypeRequest, lro::Operation> _callSetInstanceMachineType;

        private readonly gaxgrpc::ApiCall<UpdateInstanceConfigRequest, lro::Operation> _callUpdateInstanceConfig;

        private readonly gaxgrpc::ApiCall<UpdateShieldedInstanceConfigRequest, lro::Operation> _callUpdateShieldedInstanceConfig;

        private readonly gaxgrpc::ApiCall<SetInstanceLabelsRequest, lro::Operation> _callSetInstanceLabels;

        private readonly gaxgrpc::ApiCall<UpdateInstanceMetadataItemsRequest, UpdateInstanceMetadataItemsResponse> _callUpdateInstanceMetadataItems;

        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> _callDeleteInstance;

        private readonly gaxgrpc::ApiCall<StartInstanceRequest, lro::Operation> _callStartInstance;

        private readonly gaxgrpc::ApiCall<StopInstanceRequest, lro::Operation> _callStopInstance;

        private readonly gaxgrpc::ApiCall<ResetInstanceRequest, lro::Operation> _callResetInstance;

        private readonly gaxgrpc::ApiCall<ReportInstanceInfoRequest, lro::Operation> _callReportInstanceInfo;

        private readonly gaxgrpc::ApiCall<IsInstanceUpgradeableRequest, IsInstanceUpgradeableResponse> _callIsInstanceUpgradeable;

        private readonly gaxgrpc::ApiCall<GetInstanceHealthRequest, GetInstanceHealthResponse> _callGetInstanceHealth;

        private readonly gaxgrpc::ApiCall<UpgradeInstanceRequest, lro::Operation> _callUpgradeInstance;

        private readonly gaxgrpc::ApiCall<RollbackInstanceRequest, lro::Operation> _callRollbackInstance;

        private readonly gaxgrpc::ApiCall<DiagnoseInstanceRequest, lro::Operation> _callDiagnoseInstance;

        private readonly gaxgrpc::ApiCall<UpgradeInstanceInternalRequest, lro::Operation> _callUpgradeInstanceInternal;

        private readonly gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> _callListEnvironments;

        private readonly gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> _callGetEnvironment;

        private readonly gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> _callCreateEnvironment;

        private readonly gaxgrpc::ApiCall<DeleteEnvironmentRequest, lro::Operation> _callDeleteEnvironment;

        private readonly gaxgrpc::ApiCall<ListSchedulesRequest, ListSchedulesResponse> _callListSchedules;

        private readonly gaxgrpc::ApiCall<GetScheduleRequest, Schedule> _callGetSchedule;

        private readonly gaxgrpc::ApiCall<DeleteScheduleRequest, lro::Operation> _callDeleteSchedule;

        private readonly gaxgrpc::ApiCall<CreateScheduleRequest, lro::Operation> _callCreateSchedule;

        private readonly gaxgrpc::ApiCall<TriggerScheduleRequest, lro::Operation> _callTriggerSchedule;

        private readonly gaxgrpc::ApiCall<ListExecutionsRequest, ListExecutionsResponse> _callListExecutions;

        private readonly gaxgrpc::ApiCall<GetExecutionRequest, Execution> _callGetExecution;

        private readonly gaxgrpc::ApiCall<DeleteExecutionRequest, lro::Operation> _callDeleteExecution;

        private readonly gaxgrpc::ApiCall<CreateExecutionRequest, lro::Operation> _callCreateExecution;

        /// <summary>
        /// Constructs a client wrapper for the NotebookService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NotebookServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NotebookServiceClientImpl(NotebookService.NotebookServiceClient grpcClient, NotebookServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NotebookServiceSettings effectiveSettings = settings ?? NotebookServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings, logger);
            RegisterInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RegisterInstanceOperationsSettings, logger);
            SetInstanceAcceleratorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SetInstanceAcceleratorOperationsSettings, logger);
            SetInstanceMachineTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SetInstanceMachineTypeOperationsSettings, logger);
            UpdateInstanceConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceConfigOperationsSettings, logger);
            UpdateShieldedInstanceConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateShieldedInstanceConfigOperationsSettings, logger);
            SetInstanceLabelsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SetInstanceLabelsOperationsSettings, logger);
            DeleteInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteInstanceOperationsSettings, logger);
            StartInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartInstanceOperationsSettings, logger);
            StopInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StopInstanceOperationsSettings, logger);
            ResetInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResetInstanceOperationsSettings, logger);
            ReportInstanceInfoOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReportInstanceInfoOperationsSettings, logger);
            UpgradeInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpgradeInstanceOperationsSettings, logger);
            RollbackInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RollbackInstanceOperationsSettings, logger);
            DiagnoseInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DiagnoseInstanceOperationsSettings, logger);
            UpgradeInstanceInternalOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpgradeInstanceInternalOperationsSettings, logger);
            CreateEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEnvironmentOperationsSettings, logger);
            DeleteEnvironmentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEnvironmentOperationsSettings, logger);
            DeleteScheduleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteScheduleOperationsSettings, logger);
            CreateScheduleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateScheduleOperationsSettings, logger);
            TriggerScheduleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TriggerScheduleOperationsSettings, logger);
            DeleteExecutionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteExecutionOperationsSettings, logger);
            CreateExecutionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateExecutionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>("ListInstances", grpcClient.ListInstancesAsync, grpcClient.ListInstances, effectiveSettings.ListInstancesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>("GetInstance", grpcClient.GetInstanceAsync, grpcClient.GetInstance, effectiveSettings.GetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>("CreateInstance", grpcClient.CreateInstanceAsync, grpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            _callRegisterInstance = clientHelper.BuildApiCall<RegisterInstanceRequest, lro::Operation>("RegisterInstance", grpcClient.RegisterInstanceAsync, grpcClient.RegisterInstance, effectiveSettings.RegisterInstanceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRegisterInstance);
            Modify_RegisterInstanceApiCall(ref _callRegisterInstance);
            _callSetInstanceAccelerator = clientHelper.BuildApiCall<SetInstanceAcceleratorRequest, lro::Operation>("SetInstanceAccelerator", grpcClient.SetInstanceAcceleratorAsync, grpcClient.SetInstanceAccelerator, effectiveSettings.SetInstanceAcceleratorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSetInstanceAccelerator);
            Modify_SetInstanceAcceleratorApiCall(ref _callSetInstanceAccelerator);
            _callSetInstanceMachineType = clientHelper.BuildApiCall<SetInstanceMachineTypeRequest, lro::Operation>("SetInstanceMachineType", grpcClient.SetInstanceMachineTypeAsync, grpcClient.SetInstanceMachineType, effectiveSettings.SetInstanceMachineTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSetInstanceMachineType);
            Modify_SetInstanceMachineTypeApiCall(ref _callSetInstanceMachineType);
            _callUpdateInstanceConfig = clientHelper.BuildApiCall<UpdateInstanceConfigRequest, lro::Operation>("UpdateInstanceConfig", grpcClient.UpdateInstanceConfigAsync, grpcClient.UpdateInstanceConfig, effectiveSettings.UpdateInstanceConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateInstanceConfig);
            Modify_UpdateInstanceConfigApiCall(ref _callUpdateInstanceConfig);
            _callUpdateShieldedInstanceConfig = clientHelper.BuildApiCall<UpdateShieldedInstanceConfigRequest, lro::Operation>("UpdateShieldedInstanceConfig", grpcClient.UpdateShieldedInstanceConfigAsync, grpcClient.UpdateShieldedInstanceConfig, effectiveSettings.UpdateShieldedInstanceConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateShieldedInstanceConfig);
            Modify_UpdateShieldedInstanceConfigApiCall(ref _callUpdateShieldedInstanceConfig);
            _callSetInstanceLabels = clientHelper.BuildApiCall<SetInstanceLabelsRequest, lro::Operation>("SetInstanceLabels", grpcClient.SetInstanceLabelsAsync, grpcClient.SetInstanceLabels, effectiveSettings.SetInstanceLabelsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSetInstanceLabels);
            Modify_SetInstanceLabelsApiCall(ref _callSetInstanceLabels);
            _callUpdateInstanceMetadataItems = clientHelper.BuildApiCall<UpdateInstanceMetadataItemsRequest, UpdateInstanceMetadataItemsResponse>("UpdateInstanceMetadataItems", grpcClient.UpdateInstanceMetadataItemsAsync, grpcClient.UpdateInstanceMetadataItems, effectiveSettings.UpdateInstanceMetadataItemsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateInstanceMetadataItems);
            Modify_UpdateInstanceMetadataItemsApiCall(ref _callUpdateInstanceMetadataItems);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, lro::Operation>("DeleteInstance", grpcClient.DeleteInstanceAsync, grpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            _callStartInstance = clientHelper.BuildApiCall<StartInstanceRequest, lro::Operation>("StartInstance", grpcClient.StartInstanceAsync, grpcClient.StartInstance, effectiveSettings.StartInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartInstance);
            Modify_StartInstanceApiCall(ref _callStartInstance);
            _callStopInstance = clientHelper.BuildApiCall<StopInstanceRequest, lro::Operation>("StopInstance", grpcClient.StopInstanceAsync, grpcClient.StopInstance, effectiveSettings.StopInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopInstance);
            Modify_StopInstanceApiCall(ref _callStopInstance);
            _callResetInstance = clientHelper.BuildApiCall<ResetInstanceRequest, lro::Operation>("ResetInstance", grpcClient.ResetInstanceAsync, grpcClient.ResetInstance, effectiveSettings.ResetInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetInstance);
            Modify_ResetInstanceApiCall(ref _callResetInstance);
            _callReportInstanceInfo = clientHelper.BuildApiCall<ReportInstanceInfoRequest, lro::Operation>("ReportInstanceInfo", grpcClient.ReportInstanceInfoAsync, grpcClient.ReportInstanceInfo, effectiveSettings.ReportInstanceInfoSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callReportInstanceInfo);
            Modify_ReportInstanceInfoApiCall(ref _callReportInstanceInfo);
            _callIsInstanceUpgradeable = clientHelper.BuildApiCall<IsInstanceUpgradeableRequest, IsInstanceUpgradeableResponse>("IsInstanceUpgradeable", grpcClient.IsInstanceUpgradeableAsync, grpcClient.IsInstanceUpgradeable, effectiveSettings.IsInstanceUpgradeableSettings).WithGoogleRequestParam("notebook_instance", request => request.NotebookInstance);
            Modify_ApiCall(ref _callIsInstanceUpgradeable);
            Modify_IsInstanceUpgradeableApiCall(ref _callIsInstanceUpgradeable);
            _callGetInstanceHealth = clientHelper.BuildApiCall<GetInstanceHealthRequest, GetInstanceHealthResponse>("GetInstanceHealth", grpcClient.GetInstanceHealthAsync, grpcClient.GetInstanceHealth, effectiveSettings.GetInstanceHealthSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstanceHealth);
            Modify_GetInstanceHealthApiCall(ref _callGetInstanceHealth);
            _callUpgradeInstance = clientHelper.BuildApiCall<UpgradeInstanceRequest, lro::Operation>("UpgradeInstance", grpcClient.UpgradeInstanceAsync, grpcClient.UpgradeInstance, effectiveSettings.UpgradeInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpgradeInstance);
            Modify_UpgradeInstanceApiCall(ref _callUpgradeInstance);
            _callRollbackInstance = clientHelper.BuildApiCall<RollbackInstanceRequest, lro::Operation>("RollbackInstance", grpcClient.RollbackInstanceAsync, grpcClient.RollbackInstance, effectiveSettings.RollbackInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRollbackInstance);
            Modify_RollbackInstanceApiCall(ref _callRollbackInstance);
            _callDiagnoseInstance = clientHelper.BuildApiCall<DiagnoseInstanceRequest, lro::Operation>("DiagnoseInstance", grpcClient.DiagnoseInstanceAsync, grpcClient.DiagnoseInstance, effectiveSettings.DiagnoseInstanceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDiagnoseInstance);
            Modify_DiagnoseInstanceApiCall(ref _callDiagnoseInstance);
            _callUpgradeInstanceInternal = clientHelper.BuildApiCall<UpgradeInstanceInternalRequest, lro::Operation>("UpgradeInstanceInternal", grpcClient.UpgradeInstanceInternalAsync, grpcClient.UpgradeInstanceInternal, effectiveSettings.UpgradeInstanceInternalSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpgradeInstanceInternal);
            Modify_UpgradeInstanceInternalApiCall(ref _callUpgradeInstanceInternal);
            _callListEnvironments = clientHelper.BuildApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse>("ListEnvironments", grpcClient.ListEnvironmentsAsync, grpcClient.ListEnvironments, effectiveSettings.ListEnvironmentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEnvironments);
            Modify_ListEnvironmentsApiCall(ref _callListEnvironments);
            _callGetEnvironment = clientHelper.BuildApiCall<GetEnvironmentRequest, Environment>("GetEnvironment", grpcClient.GetEnvironmentAsync, grpcClient.GetEnvironment, effectiveSettings.GetEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEnvironment);
            Modify_GetEnvironmentApiCall(ref _callGetEnvironment);
            _callCreateEnvironment = clientHelper.BuildApiCall<CreateEnvironmentRequest, lro::Operation>("CreateEnvironment", grpcClient.CreateEnvironmentAsync, grpcClient.CreateEnvironment, effectiveSettings.CreateEnvironmentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEnvironment);
            Modify_CreateEnvironmentApiCall(ref _callCreateEnvironment);
            _callDeleteEnvironment = clientHelper.BuildApiCall<DeleteEnvironmentRequest, lro::Operation>("DeleteEnvironment", grpcClient.DeleteEnvironmentAsync, grpcClient.DeleteEnvironment, effectiveSettings.DeleteEnvironmentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEnvironment);
            Modify_DeleteEnvironmentApiCall(ref _callDeleteEnvironment);
            _callListSchedules = clientHelper.BuildApiCall<ListSchedulesRequest, ListSchedulesResponse>("ListSchedules", grpcClient.ListSchedulesAsync, grpcClient.ListSchedules, effectiveSettings.ListSchedulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSchedules);
            Modify_ListSchedulesApiCall(ref _callListSchedules);
            _callGetSchedule = clientHelper.BuildApiCall<GetScheduleRequest, Schedule>("GetSchedule", grpcClient.GetScheduleAsync, grpcClient.GetSchedule, effectiveSettings.GetScheduleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSchedule);
            Modify_GetScheduleApiCall(ref _callGetSchedule);
            _callDeleteSchedule = clientHelper.BuildApiCall<DeleteScheduleRequest, lro::Operation>("DeleteSchedule", grpcClient.DeleteScheduleAsync, grpcClient.DeleteSchedule, effectiveSettings.DeleteScheduleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSchedule);
            Modify_DeleteScheduleApiCall(ref _callDeleteSchedule);
            _callCreateSchedule = clientHelper.BuildApiCall<CreateScheduleRequest, lro::Operation>("CreateSchedule", grpcClient.CreateScheduleAsync, grpcClient.CreateSchedule, effectiveSettings.CreateScheduleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSchedule);
            Modify_CreateScheduleApiCall(ref _callCreateSchedule);
            _callTriggerSchedule = clientHelper.BuildApiCall<TriggerScheduleRequest, lro::Operation>("TriggerSchedule", grpcClient.TriggerScheduleAsync, grpcClient.TriggerSchedule, effectiveSettings.TriggerScheduleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTriggerSchedule);
            Modify_TriggerScheduleApiCall(ref _callTriggerSchedule);
            _callListExecutions = clientHelper.BuildApiCall<ListExecutionsRequest, ListExecutionsResponse>("ListExecutions", grpcClient.ListExecutionsAsync, grpcClient.ListExecutions, effectiveSettings.ListExecutionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExecutions);
            Modify_ListExecutionsApiCall(ref _callListExecutions);
            _callGetExecution = clientHelper.BuildApiCall<GetExecutionRequest, Execution>("GetExecution", grpcClient.GetExecutionAsync, grpcClient.GetExecution, effectiveSettings.GetExecutionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExecution);
            Modify_GetExecutionApiCall(ref _callGetExecution);
            _callDeleteExecution = clientHelper.BuildApiCall<DeleteExecutionRequest, lro::Operation>("DeleteExecution", grpcClient.DeleteExecutionAsync, grpcClient.DeleteExecution, effectiveSettings.DeleteExecutionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteExecution);
            Modify_DeleteExecutionApiCall(ref _callDeleteExecution);
            _callCreateExecution = clientHelper.BuildApiCall<CreateExecutionRequest, lro::Operation>("CreateExecution", grpcClient.CreateExecutionAsync, grpcClient.CreateExecution, effectiveSettings.CreateExecutionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateExecution);
            Modify_CreateExecutionApiCall(ref _callCreateExecution);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);

        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);

        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);

        partial void Modify_RegisterInstanceApiCall(ref gaxgrpc::ApiCall<RegisterInstanceRequest, lro::Operation> call);

        partial void Modify_SetInstanceAcceleratorApiCall(ref gaxgrpc::ApiCall<SetInstanceAcceleratorRequest, lro::Operation> call);

        partial void Modify_SetInstanceMachineTypeApiCall(ref gaxgrpc::ApiCall<SetInstanceMachineTypeRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceConfigApiCall(ref gaxgrpc::ApiCall<UpdateInstanceConfigRequest, lro::Operation> call);

        partial void Modify_UpdateShieldedInstanceConfigApiCall(ref gaxgrpc::ApiCall<UpdateShieldedInstanceConfigRequest, lro::Operation> call);

        partial void Modify_SetInstanceLabelsApiCall(ref gaxgrpc::ApiCall<SetInstanceLabelsRequest, lro::Operation> call);

        partial void Modify_UpdateInstanceMetadataItemsApiCall(ref gaxgrpc::ApiCall<UpdateInstanceMetadataItemsRequest, UpdateInstanceMetadataItemsResponse> call);

        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, lro::Operation> call);

        partial void Modify_StartInstanceApiCall(ref gaxgrpc::ApiCall<StartInstanceRequest, lro::Operation> call);

        partial void Modify_StopInstanceApiCall(ref gaxgrpc::ApiCall<StopInstanceRequest, lro::Operation> call);

        partial void Modify_ResetInstanceApiCall(ref gaxgrpc::ApiCall<ResetInstanceRequest, lro::Operation> call);

        partial void Modify_ReportInstanceInfoApiCall(ref gaxgrpc::ApiCall<ReportInstanceInfoRequest, lro::Operation> call);

        partial void Modify_IsInstanceUpgradeableApiCall(ref gaxgrpc::ApiCall<IsInstanceUpgradeableRequest, IsInstanceUpgradeableResponse> call);

        partial void Modify_GetInstanceHealthApiCall(ref gaxgrpc::ApiCall<GetInstanceHealthRequest, GetInstanceHealthResponse> call);

        partial void Modify_UpgradeInstanceApiCall(ref gaxgrpc::ApiCall<UpgradeInstanceRequest, lro::Operation> call);

        partial void Modify_RollbackInstanceApiCall(ref gaxgrpc::ApiCall<RollbackInstanceRequest, lro::Operation> call);

        partial void Modify_DiagnoseInstanceApiCall(ref gaxgrpc::ApiCall<DiagnoseInstanceRequest, lro::Operation> call);

        partial void Modify_UpgradeInstanceInternalApiCall(ref gaxgrpc::ApiCall<UpgradeInstanceInternalRequest, lro::Operation> call);

        partial void Modify_ListEnvironmentsApiCall(ref gaxgrpc::ApiCall<ListEnvironmentsRequest, ListEnvironmentsResponse> call);

        partial void Modify_GetEnvironmentApiCall(ref gaxgrpc::ApiCall<GetEnvironmentRequest, Environment> call);

        partial void Modify_CreateEnvironmentApiCall(ref gaxgrpc::ApiCall<CreateEnvironmentRequest, lro::Operation> call);

        partial void Modify_DeleteEnvironmentApiCall(ref gaxgrpc::ApiCall<DeleteEnvironmentRequest, lro::Operation> call);

        partial void Modify_ListSchedulesApiCall(ref gaxgrpc::ApiCall<ListSchedulesRequest, ListSchedulesResponse> call);

        partial void Modify_GetScheduleApiCall(ref gaxgrpc::ApiCall<GetScheduleRequest, Schedule> call);

        partial void Modify_DeleteScheduleApiCall(ref gaxgrpc::ApiCall<DeleteScheduleRequest, lro::Operation> call);

        partial void Modify_CreateScheduleApiCall(ref gaxgrpc::ApiCall<CreateScheduleRequest, lro::Operation> call);

        partial void Modify_TriggerScheduleApiCall(ref gaxgrpc::ApiCall<TriggerScheduleRequest, lro::Operation> call);

        partial void Modify_ListExecutionsApiCall(ref gaxgrpc::ApiCall<ListExecutionsRequest, ListExecutionsResponse> call);

        partial void Modify_GetExecutionApiCall(ref gaxgrpc::ApiCall<GetExecutionRequest, Execution> call);

        partial void Modify_DeleteExecutionApiCall(ref gaxgrpc::ApiCall<DeleteExecutionRequest, lro::Operation> call);

        partial void Modify_CreateExecutionApiCall(ref gaxgrpc::ApiCall<CreateExecutionRequest, lro::Operation> call);

        partial void OnConstruction(NotebookService.NotebookServiceClient grpcClient, NotebookServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NotebookService client</summary>
        public override NotebookService.NotebookServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RegisterInstanceRequest(ref RegisterInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetInstanceAcceleratorRequest(ref SetInstanceAcceleratorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetInstanceMachineTypeRequest(ref SetInstanceMachineTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceConfigRequest(ref UpdateInstanceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateShieldedInstanceConfigRequest(ref UpdateShieldedInstanceConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetInstanceLabelsRequest(ref SetInstanceLabelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInstanceMetadataItemsRequest(ref UpdateInstanceMetadataItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartInstanceRequest(ref StartInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopInstanceRequest(ref StopInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetInstanceRequest(ref ResetInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReportInstanceInfoRequest(ref ReportInstanceInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_IsInstanceUpgradeableRequest(ref IsInstanceUpgradeableRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstanceHealthRequest(ref GetInstanceHealthRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpgradeInstanceRequest(ref UpgradeInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackInstanceRequest(ref RollbackInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DiagnoseInstanceRequest(ref DiagnoseInstanceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpgradeInstanceInternalRequest(ref UpgradeInstanceInternalRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEnvironmentsRequest(ref ListEnvironmentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEnvironmentRequest(ref GetEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEnvironmentRequest(ref CreateEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEnvironmentRequest(ref DeleteEnvironmentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSchedulesRequest(ref ListSchedulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetScheduleRequest(ref GetScheduleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteScheduleRequest(ref DeleteScheduleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateScheduleRequest(ref CreateScheduleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TriggerScheduleRequest(ref TriggerScheduleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExecutionsRequest(ref ListExecutionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExecutionRequest(ref GetExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteExecutionRequest(ref DeleteExecutionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateExecutionRequest(ref CreateExecutionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists instances in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instance"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(ListInstancesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instance GetInstance(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instance> GetInstanceAsync(GetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstance</c>.</summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> CreateInstance(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a new Instance in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> CreateInstanceAsync(CreateInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RegisterInstance</c>.</summary>
        public override lro::OperationsClient RegisterInstanceOperationsClient { get; }

        /// <summary>
        /// Registers an existing legacy notebook instance to the Notebooks API server.
        /// Legacy instances are instances created with the legacy Compute Engine
        /// calls. They are not manageable by the Notebooks API out of the box. This
        /// call makes these instances manageable by the Notebooks API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> RegisterInstance(RegisterInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callRegisterInstance.Sync(request, callSettings), RegisterInstanceOperationsClient);
        }

        /// <summary>
        /// Registers an existing legacy notebook instance to the Notebooks API server.
        /// Legacy instances are instances created with the legacy Compute Engine
        /// calls. They are not manageable by the Notebooks API out of the box. This
        /// call makes these instances manageable by the Notebooks API.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> RegisterInstanceAsync(RegisterInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callRegisterInstance.Async(request, callSettings).ConfigureAwait(false), RegisterInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetInstanceAccelerator</c>.</summary>
        public override lro::OperationsClient SetInstanceAcceleratorOperationsClient { get; }

        /// <summary>
        /// Updates the guest accelerators of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> SetInstanceAccelerator(SetInstanceAcceleratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetInstanceAcceleratorRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callSetInstanceAccelerator.Sync(request, callSettings), SetInstanceAcceleratorOperationsClient);
        }

        /// <summary>
        /// Updates the guest accelerators of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> SetInstanceAcceleratorAsync(SetInstanceAcceleratorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetInstanceAcceleratorRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callSetInstanceAccelerator.Async(request, callSettings).ConfigureAwait(false), SetInstanceAcceleratorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetInstanceMachineType</c>.</summary>
        public override lro::OperationsClient SetInstanceMachineTypeOperationsClient { get; }

        /// <summary>
        /// Updates the machine type of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> SetInstanceMachineType(SetInstanceMachineTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetInstanceMachineTypeRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callSetInstanceMachineType.Sync(request, callSettings), SetInstanceMachineTypeOperationsClient);
        }

        /// <summary>
        /// Updates the machine type of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> SetInstanceMachineTypeAsync(SetInstanceMachineTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetInstanceMachineTypeRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callSetInstanceMachineType.Async(request, callSettings).ConfigureAwait(false), SetInstanceMachineTypeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateInstanceConfig</c>.</summary>
        public override lro::OperationsClient UpdateInstanceConfigOperationsClient { get; }

        /// <summary>
        /// Update Notebook Instance configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpdateInstanceConfig(UpdateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceConfigRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpdateInstanceConfig.Sync(request, callSettings), UpdateInstanceConfigOperationsClient);
        }

        /// <summary>
        /// Update Notebook Instance configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateInstanceConfigAsync(UpdateInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceConfigRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpdateInstanceConfig.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateShieldedInstanceConfig</c>.</summary>
        public override lro::OperationsClient UpdateShieldedInstanceConfigOperationsClient { get; }

        /// <summary>
        /// Updates the Shielded instance configuration of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpdateShieldedInstanceConfig(UpdateShieldedInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateShieldedInstanceConfigRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpdateShieldedInstanceConfig.Sync(request, callSettings), UpdateShieldedInstanceConfigOperationsClient);
        }

        /// <summary>
        /// Updates the Shielded instance configuration of a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpdateShieldedInstanceConfigAsync(UpdateShieldedInstanceConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateShieldedInstanceConfigRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpdateShieldedInstanceConfig.Async(request, callSettings).ConfigureAwait(false), UpdateShieldedInstanceConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetInstanceLabels</c>.</summary>
        public override lro::OperationsClient SetInstanceLabelsOperationsClient { get; }

        /// <summary>
        /// Replaces all the labels of an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> SetInstanceLabels(SetInstanceLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetInstanceLabelsRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callSetInstanceLabels.Sync(request, callSettings), SetInstanceLabelsOperationsClient);
        }

        /// <summary>
        /// Replaces all the labels of an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> SetInstanceLabelsAsync(SetInstanceLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetInstanceLabelsRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callSetInstanceLabels.Async(request, callSettings).ConfigureAwait(false), SetInstanceLabelsOperationsClient);
        }

        /// <summary>
        /// Add/update metadata items for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UpdateInstanceMetadataItemsResponse UpdateInstanceMetadataItems(UpdateInstanceMetadataItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceMetadataItemsRequest(ref request, ref callSettings);
            return _callUpdateInstanceMetadataItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Add/update metadata items for an instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UpdateInstanceMetadataItemsResponse> UpdateInstanceMetadataItemsAsync(UpdateInstanceMetadataItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceMetadataItemsRequest(ref request, ref callSettings);
            return _callUpdateInstanceMetadataItems.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteInstance</c>.</summary>
        public override lro::OperationsClient DeleteInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteInstance(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteInstance.Sync(request, callSettings), DeleteInstanceOperationsClient);
        }

        /// <summary>
        /// Deletes a single Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteInstanceAsync(DeleteInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteInstance.Async(request, callSettings).ConfigureAwait(false), DeleteInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartInstance</c>.</summary>
        public override lro::OperationsClient StartInstanceOperationsClient { get; }

        /// <summary>
        /// Starts a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> StartInstance(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callStartInstance.Sync(request, callSettings), StartInstanceOperationsClient);
        }

        /// <summary>
        /// Starts a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> StartInstanceAsync(StartInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callStartInstance.Async(request, callSettings).ConfigureAwait(false), StartInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StopInstance</c>.</summary>
        public override lro::OperationsClient StopInstanceOperationsClient { get; }

        /// <summary>
        /// Stops a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> StopInstance(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callStopInstance.Sync(request, callSettings), StopInstanceOperationsClient);
        }

        /// <summary>
        /// Stops a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> StopInstanceAsync(StopInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callStopInstance.Async(request, callSettings).ConfigureAwait(false), StopInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResetInstance</c>.</summary>
        public override lro::OperationsClient ResetInstanceOperationsClient { get; }

        /// <summary>
        /// Resets a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> ResetInstance(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callResetInstance.Sync(request, callSettings), ResetInstanceOperationsClient);
        }

        /// <summary>
        /// Resets a notebook instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> ResetInstanceAsync(ResetInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callResetInstance.Async(request, callSettings).ConfigureAwait(false), ResetInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReportInstanceInfo</c>.</summary>
        public override lro::OperationsClient ReportInstanceInfoOperationsClient { get; }

        /// <summary>
        /// Allows notebook instances to
        /// report their latest instance information to the Notebooks
        /// API server. The server will merge the reported information to
        /// the instance metadata store. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> ReportInstanceInfo(ReportInstanceInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportInstanceInfoRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callReportInstanceInfo.Sync(request, callSettings), ReportInstanceInfoOperationsClient);
        }

        /// <summary>
        /// Allows notebook instances to
        /// report their latest instance information to the Notebooks
        /// API server. The server will merge the reported information to
        /// the instance metadata store. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> ReportInstanceInfoAsync(ReportInstanceInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReportInstanceInfoRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callReportInstanceInfo.Async(request, callSettings).ConfigureAwait(false), ReportInstanceInfoOperationsClient);
        }

        /// <summary>
        /// Check if a notebook instance is upgradable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IsInstanceUpgradeableResponse IsInstanceUpgradeable(IsInstanceUpgradeableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IsInstanceUpgradeableRequest(ref request, ref callSettings);
            return _callIsInstanceUpgradeable.Sync(request, callSettings);
        }

        /// <summary>
        /// Check if a notebook instance is upgradable.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IsInstanceUpgradeableResponse> IsInstanceUpgradeableAsync(IsInstanceUpgradeableRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IsInstanceUpgradeableRequest(ref request, ref callSettings);
            return _callIsInstanceUpgradeable.Async(request, callSettings);
        }

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GetInstanceHealthResponse GetInstanceHealth(GetInstanceHealthRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceHealthRequest(ref request, ref callSettings);
            return _callGetInstanceHealth.Sync(request, callSettings);
        }

        /// <summary>
        /// Check if a notebook instance is healthy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GetInstanceHealthResponse> GetInstanceHealthAsync(GetInstanceHealthRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstanceHealthRequest(ref request, ref callSettings);
            return _callGetInstanceHealth.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpgradeInstance</c>.</summary>
        public override lro::OperationsClient UpgradeInstanceOperationsClient { get; }

        /// <summary>
        /// Upgrades a notebook instance to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpgradeInstance(UpgradeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpgradeInstance.Sync(request, callSettings), UpgradeInstanceOperationsClient);
        }

        /// <summary>
        /// Upgrades a notebook instance to the latest version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpgradeInstanceAsync(UpgradeInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpgradeInstance.Async(request, callSettings).ConfigureAwait(false), UpgradeInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RollbackInstance</c>.</summary>
        public override lro::OperationsClient RollbackInstanceOperationsClient { get; }

        /// <summary>
        /// Rollbacks a notebook instance to the previous version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> RollbackInstance(RollbackInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callRollbackInstance.Sync(request, callSettings), RollbackInstanceOperationsClient);
        }

        /// <summary>
        /// Rollbacks a notebook instance to the previous version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> RollbackInstanceAsync(RollbackInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callRollbackInstance.Async(request, callSettings).ConfigureAwait(false), RollbackInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DiagnoseInstance</c>.</summary>
        public override lro::OperationsClient DiagnoseInstanceOperationsClient { get; }

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> DiagnoseInstance(DiagnoseInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callDiagnoseInstance.Sync(request, callSettings), DiagnoseInstanceOperationsClient);
        }

        /// <summary>
        /// Creates a Diagnostic File and runs Diagnostic Tool given an Instance.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> DiagnoseInstanceAsync(DiagnoseInstanceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DiagnoseInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callDiagnoseInstance.Async(request, callSettings).ConfigureAwait(false), DiagnoseInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpgradeInstanceInternal</c>.</summary>
        public override lro::OperationsClient UpgradeInstanceInternalOperationsClient { get; }

        /// <summary>
        /// Allows notebook instances to
        /// call this endpoint to upgrade themselves. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instance, OperationMetadata> UpgradeInstanceInternal(UpgradeInstanceInternalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeInstanceInternalRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(_callUpgradeInstanceInternal.Sync(request, callSettings), UpgradeInstanceInternalOperationsClient);
        }

        /// <summary>
        /// Allows notebook instances to
        /// call this endpoint to upgrade themselves. Do not use this method directly.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instance, OperationMetadata>> UpgradeInstanceInternalAsync(UpgradeInstanceInternalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpgradeInstanceInternalRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, OperationMetadata>(await _callUpgradeInstanceInternal.Async(request, callSettings).ConfigureAwait(false), UpgradeInstanceInternalOperationsClient);
        }

        /// <summary>
        /// Lists environments in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedEnumerable<ListEnvironmentsResponse, Environment> ListEnvironments(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// Lists environments in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Environment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEnvironmentsResponse, Environment> ListEnvironmentsAsync(ListEnvironmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEnvironmentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEnvironmentsRequest, ListEnvironmentsResponse, Environment>(_callListEnvironments, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Environment GetEnvironment(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Environment> GetEnvironmentAsync(GetEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEnvironmentRequest(ref request, ref callSettings);
            return _callGetEnvironment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEnvironment</c>.</summary>
        public override lro::OperationsClient CreateEnvironmentOperationsClient { get; }

        /// <summary>
        /// Creates a new Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Environment, OperationMetadata> CreateEnvironment(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(_callCreateEnvironment.Sync(request, callSettings), CreateEnvironmentOperationsClient);
        }

        /// <summary>
        /// Creates a new Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Environment, OperationMetadata>> CreateEnvironmentAsync(CreateEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<Environment, OperationMetadata>(await _callCreateEnvironment.Async(request, callSettings).ConfigureAwait(false), CreateEnvironmentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEnvironment</c>.</summary>
        public override lro::OperationsClient DeleteEnvironmentOperationsClient { get; }

        /// <summary>
        /// Deletes a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEnvironment(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEnvironment.Sync(request, callSettings), DeleteEnvironmentOperationsClient);
        }

        /// <summary>
        /// Deletes a single Environment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEnvironmentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEnvironment.Async(request, callSettings).ConfigureAwait(false), DeleteEnvironmentOperationsClient);
        }

        /// <summary>
        /// Lists schedules in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Schedule"/> resources.</returns>
        public override gax::PagedEnumerable<ListSchedulesResponse, Schedule> ListSchedules(ListSchedulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSchedulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSchedulesRequest, ListSchedulesResponse, Schedule>(_callListSchedules, request, callSettings);
        }

        /// <summary>
        /// Lists schedules in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Schedule"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSchedulesResponse, Schedule> ListSchedulesAsync(ListSchedulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSchedulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSchedulesRequest, ListSchedulesResponse, Schedule>(_callListSchedules, request, callSettings);
        }

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Schedule GetSchedule(GetScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScheduleRequest(ref request, ref callSettings);
            return _callGetSchedule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of schedule
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Schedule> GetScheduleAsync(GetScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScheduleRequest(ref request, ref callSettings);
            return _callGetSchedule.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteSchedule</c>.</summary>
        public override lro::OperationsClient DeleteScheduleOperationsClient { get; }

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteSchedule(DeleteScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScheduleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteSchedule.Sync(request, callSettings), DeleteScheduleOperationsClient);
        }

        /// <summary>
        /// Deletes schedule and all underlying jobs
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteScheduleAsync(DeleteScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScheduleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteSchedule.Async(request, callSettings).ConfigureAwait(false), DeleteScheduleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateSchedule</c>.</summary>
        public override lro::OperationsClient CreateScheduleOperationsClient { get; }

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Schedule, OperationMetadata> CreateSchedule(CreateScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScheduleRequest(ref request, ref callSettings);
            return new lro::Operation<Schedule, OperationMetadata>(_callCreateSchedule.Sync(request, callSettings), CreateScheduleOperationsClient);
        }

        /// <summary>
        /// Creates a new Scheduled Notebook in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Schedule, OperationMetadata>> CreateScheduleAsync(CreateScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScheduleRequest(ref request, ref callSettings);
            return new lro::Operation<Schedule, OperationMetadata>(await _callCreateSchedule.Async(request, callSettings).ConfigureAwait(false), CreateScheduleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>TriggerSchedule</c>.</summary>
        public override lro::OperationsClient TriggerScheduleOperationsClient { get; }

        /// <summary>
        /// Triggers execution of an existing schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Schedule, OperationMetadata> TriggerSchedule(TriggerScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TriggerScheduleRequest(ref request, ref callSettings);
            return new lro::Operation<Schedule, OperationMetadata>(_callTriggerSchedule.Sync(request, callSettings), TriggerScheduleOperationsClient);
        }

        /// <summary>
        /// Triggers execution of an existing schedule.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Schedule, OperationMetadata>> TriggerScheduleAsync(TriggerScheduleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TriggerScheduleRequest(ref request, ref callSettings);
            return new lro::Operation<Schedule, OperationMetadata>(await _callTriggerSchedule.Async(request, callSettings).ConfigureAwait(false), TriggerScheduleOperationsClient);
        }

        /// <summary>
        /// Lists executions in a given project and location
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Execution"/> resources.</returns>
        public override gax::PagedEnumerable<ListExecutionsResponse, Execution> ListExecutions(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExecutionsRequest, ListExecutionsResponse, Execution>(_callListExecutions, request, callSettings);
        }

        /// <summary>
        /// Lists executions in a given project and location
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Execution"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExecutionsResponse, Execution> ListExecutionsAsync(ListExecutionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExecutionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExecutionsRequest, ListExecutionsResponse, Execution>(_callListExecutions, request, callSettings);
        }

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Execution GetExecution(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExecutionRequest(ref request, ref callSettings);
            return _callGetExecution.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of executions
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Execution> GetExecutionAsync(GetExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExecutionRequest(ref request, ref callSettings);
            return _callGetExecution.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteExecution</c>.</summary>
        public override lro::OperationsClient DeleteExecutionOperationsClient { get; }

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteExecution(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExecutionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteExecution.Sync(request, callSettings), DeleteExecutionOperationsClient);
        }

        /// <summary>
        /// Deletes execution
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteExecutionAsync(DeleteExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExecutionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteExecution.Async(request, callSettings).ConfigureAwait(false), DeleteExecutionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateExecution</c>.</summary>
        public override lro::OperationsClient CreateExecutionOperationsClient { get; }

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Execution, OperationMetadata> CreateExecution(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExecutionRequest(ref request, ref callSettings);
            return new lro::Operation<Execution, OperationMetadata>(_callCreateExecution.Sync(request, callSettings), CreateExecutionOperationsClient);
        }

        /// <summary>
        /// Creates a new Execution in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Execution, OperationMetadata>> CreateExecutionAsync(CreateExecutionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExecutionRequest(ref request, ref callSettings);
            return new lro::Operation<Execution, OperationMetadata>(await _callCreateExecution.Async(request, callSettings).ConfigureAwait(false), CreateExecutionOperationsClient);
        }
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEnvironmentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSchedulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExecutionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEnvironmentsResponse : gaxgrpc::IPageResponse<Environment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Environment> GetEnumerator() => Environments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSchedulesResponse : gaxgrpc::IPageResponse<Schedule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Schedule> GetEnumerator() => Schedules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExecutionsResponse : gaxgrpc::IPageResponse<Execution>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Execution> GetEnumerator() => Executions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class NotebookService
    {
        public partial class NotebookServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class NotebookService
    {
        public partial class NotebookServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
