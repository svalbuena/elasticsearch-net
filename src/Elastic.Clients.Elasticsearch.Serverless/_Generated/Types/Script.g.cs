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

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class Script
{
	/// <summary>
	/// <para>The `id` for a stored script.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("id")]
	public Elastic.Clients.Elasticsearch.Serverless.Id? Id { get; set; }

	/// <summary>
	/// <para>Specifies the language the script is written in.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("lang")]
	public Elastic.Clients.Elasticsearch.Serverless.ScriptLanguage? Lang { get; set; }
	[JsonInclude, JsonPropertyName("options")]
	public IDictionary<string, string>? Options { get; set; }

	/// <summary>
	/// <para>Specifies any named parameters that are passed into the script as variables.<br/>Use parameters instead of hard-coded values to decrease compile time.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("params")]
	public IDictionary<string, object>? Params { get; set; }

	/// <summary>
	/// <para>The script source.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("source")]
	public string? Source { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Serverless.QueryDsl.IntervalsFilter(Script script) => Elastic.Clients.Elasticsearch.Serverless.QueryDsl.IntervalsFilter.Script(script);
}

public sealed partial class ScriptDescriptor : SerializableDescriptor<ScriptDescriptor>
{
	internal ScriptDescriptor(Action<ScriptDescriptor> configure) => configure.Invoke(this);

	public ScriptDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Id? IdValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.ScriptLanguage? LangValue { get; set; }
	private IDictionary<string, string>? OptionsValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private string? SourceValue { get; set; }

	/// <summary>
	/// <para>The `id` for a stored script.</para>
	/// </summary>
	public ScriptDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id? id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the language the script is written in.</para>
	/// </summary>
	public ScriptDescriptor Lang(Elastic.Clients.Elasticsearch.Serverless.ScriptLanguage? lang)
	{
		LangValue = lang;
		return Self;
	}

	public ScriptDescriptor Options(Func<FluentDictionary<string, string>, FluentDictionary<string, string>> selector)
	{
		OptionsValue = selector?.Invoke(new FluentDictionary<string, string>());
		return Self;
	}

	/// <summary>
	/// <para>Specifies any named parameters that are passed into the script as variables.<br/>Use parameters instead of hard-coded values to decrease compile time.</para>
	/// </summary>
	public ScriptDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>The script source.</para>
	/// </summary>
	public ScriptDescriptor Source(string? source)
	{
		SourceValue = source;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IdValue is not null)
		{
			writer.WritePropertyName("id");
			JsonSerializer.Serialize(writer, IdValue, options);
		}

		if (LangValue is not null)
		{
			writer.WritePropertyName("lang");
			JsonSerializer.Serialize(writer, LangValue, options);
		}

		if (OptionsValue is not null)
		{
			writer.WritePropertyName("options");
			JsonSerializer.Serialize(writer, OptionsValue, options);
		}

		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (!string.IsNullOrEmpty(SourceValue))
		{
			writer.WritePropertyName("source");
			writer.WriteStringValue(SourceValue);
		}

		writer.WriteEndObject();
	}
}