// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

#nullable restore

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class DownsamplingRound
{
	/// <summary>
	/// <para>The duration since rollover when this downsampling round should execute</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("after")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration After { get; set; }

	/// <summary>
	/// <para>The downsample configuration to execute.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("config")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DownsampleConfig Config { get; set; }
}

public sealed partial class DownsamplingRoundDescriptor : SerializableDescriptor<DownsamplingRoundDescriptor>
{
	internal DownsamplingRoundDescriptor(Action<DownsamplingRoundDescriptor> configure) => configure.Invoke(this);

	public DownsamplingRoundDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Duration AfterValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DownsampleConfig ConfigValue { get; set; }
	private DownsampleConfigDescriptor ConfigDescriptor { get; set; }
	private Action<DownsampleConfigDescriptor> ConfigDescriptorAction { get; set; }

	/// <summary>
	/// <para>The duration since rollover when this downsampling round should execute</para>
	/// </summary>
	public DownsamplingRoundDescriptor After(Elastic.Clients.Elasticsearch.Serverless.Duration after)
	{
		AfterValue = after;
		return Self;
	}

	/// <summary>
	/// <para>The downsample configuration to execute.</para>
	/// </summary>
	public DownsamplingRoundDescriptor Config(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DownsampleConfig config)
	{
		ConfigDescriptor = null;
		ConfigDescriptorAction = null;
		ConfigValue = config;
		return Self;
	}

	public DownsamplingRoundDescriptor Config(DownsampleConfigDescriptor descriptor)
	{
		ConfigValue = null;
		ConfigDescriptorAction = null;
		ConfigDescriptor = descriptor;
		return Self;
	}

	public DownsamplingRoundDescriptor Config(Action<DownsampleConfigDescriptor> configure)
	{
		ConfigValue = null;
		ConfigDescriptor = null;
		ConfigDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("after");
		JsonSerializer.Serialize(writer, AfterValue, options);
		if (ConfigDescriptor is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, ConfigDescriptor, options);
		}
		else if (ConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, new DownsampleConfigDescriptor(ConfigDescriptorAction), options);
		}
		else
		{
			writer.WritePropertyName("config");
			JsonSerializer.Serialize(writer, ConfigValue, options);
		}

		writer.WriteEndObject();
	}
}