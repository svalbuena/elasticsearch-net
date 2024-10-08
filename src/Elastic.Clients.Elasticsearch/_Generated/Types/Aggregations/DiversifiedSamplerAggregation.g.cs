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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Aggregations;

public sealed partial class DiversifiedSamplerAggregation
{
	/// <summary>
	/// <para>The type of value used for de-duplication.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("execution_hint")]
	public Elastic.Clients.Elasticsearch.Aggregations.SamplerAggregationExecutionHint? ExecutionHint { get; set; }

	/// <summary>
	/// <para>The field used to provide values used for de-duplication.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }

	/// <summary>
	/// <para>Limits how many documents are permitted per choice of de-duplicating value.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_docs_per_value")]
	public int? MaxDocsPerValue { get; set; }
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }

	/// <summary>
	/// <para>Limits how many top-scoring documents are collected in the sample processed on each shard.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("shard_size")]
	public int? ShardSize { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Aggregations.Aggregation(DiversifiedSamplerAggregation diversifiedSamplerAggregation) => Elastic.Clients.Elasticsearch.Aggregations.Aggregation.DiversifiedSampler(diversifiedSamplerAggregation);
}

public sealed partial class DiversifiedSamplerAggregationDescriptor<TDocument> : SerializableDescriptor<DiversifiedSamplerAggregationDescriptor<TDocument>>
{
	internal DiversifiedSamplerAggregationDescriptor(Action<DiversifiedSamplerAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public DiversifiedSamplerAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.SamplerAggregationExecutionHint? ExecutionHintValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private int? MaxDocsPerValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private int? ShardSizeValue { get; set; }

	/// <summary>
	/// <para>The type of value used for de-duplication.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor<TDocument> ExecutionHint(Elastic.Clients.Elasticsearch.Aggregations.SamplerAggregationExecutionHint? executionHint)
	{
		ExecutionHintValue = executionHint;
		return Self;
	}

	/// <summary>
	/// <para>The field used to provide values used for de-duplication.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field used to provide values used for de-duplication.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field used to provide values used for de-duplication.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Limits how many documents are permitted per choice of de-duplicating value.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor<TDocument> MaxDocsPerValue(int? maxDocsPerValue)
	{
		MaxDocsPerValueValue = maxDocsPerValue;
		return Self;
	}

	public DiversifiedSamplerAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public DiversifiedSamplerAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public DiversifiedSamplerAggregationDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Limits how many top-scoring documents are collected in the sample processed on each shard.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor<TDocument> ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ExecutionHintValue is not null)
		{
			writer.WritePropertyName("execution_hint");
			JsonSerializer.Serialize(writer, ExecutionHintValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MaxDocsPerValueValue.HasValue)
		{
			writer.WritePropertyName("max_docs_per_value");
			writer.WriteNumberValue(MaxDocsPerValueValue.Value);
		}

		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class DiversifiedSamplerAggregationDescriptor : SerializableDescriptor<DiversifiedSamplerAggregationDescriptor>
{
	internal DiversifiedSamplerAggregationDescriptor(Action<DiversifiedSamplerAggregationDescriptor> configure) => configure.Invoke(this);

	public DiversifiedSamplerAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Aggregations.SamplerAggregationExecutionHint? ExecutionHintValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private int? MaxDocsPerValueValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private int? ShardSizeValue { get; set; }

	/// <summary>
	/// <para>The type of value used for de-duplication.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor ExecutionHint(Elastic.Clients.Elasticsearch.Aggregations.SamplerAggregationExecutionHint? executionHint)
	{
		ExecutionHintValue = executionHint;
		return Self;
	}

	/// <summary>
	/// <para>The field used to provide values used for de-duplication.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field used to provide values used for de-duplication.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>The field used to provide values used for de-duplication.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>Limits how many documents are permitted per choice of de-duplicating value.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor MaxDocsPerValue(int? maxDocsPerValue)
	{
		MaxDocsPerValueValue = maxDocsPerValue;
		return Self;
	}

	public DiversifiedSamplerAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public DiversifiedSamplerAggregationDescriptor Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public DiversifiedSamplerAggregationDescriptor Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>Limits how many top-scoring documents are collected in the sample processed on each shard.</para>
	/// </summary>
	public DiversifiedSamplerAggregationDescriptor ShardSize(int? shardSize)
	{
		ShardSizeValue = shardSize;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (ExecutionHintValue is not null)
		{
			writer.WritePropertyName("execution_hint");
			JsonSerializer.Serialize(writer, ExecutionHintValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MaxDocsPerValueValue.HasValue)
		{
			writer.WritePropertyName("max_docs_per_value");
			writer.WriteNumberValue(MaxDocsPerValueValue.Value);
		}

		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (ShardSizeValue.HasValue)
		{
			writer.WritePropertyName("shard_size");
			writer.WriteNumberValue(ShardSizeValue.Value);
		}

		writer.WriteEndObject();
	}
}