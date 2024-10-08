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

namespace Elastic.Clients.Elasticsearch.Serverless.QueryDsl;

public sealed partial class FieldLookup
{
	/// <summary>
	/// <para>`id` of the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("id")]
	public Elastic.Clients.Elasticsearch.Serverless.Id Id { get; set; }

	/// <summary>
	/// <para>Index from which to retrieve the document.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("index")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexName? Index { get; set; }

	/// <summary>
	/// <para>Name of the field.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("path")]
	public Elastic.Clients.Elasticsearch.Serverless.Field? Path { get; set; }

	/// <summary>
	/// <para>Custom routing value.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("routing")]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get; set; }
}

public sealed partial class FieldLookupDescriptor<TDocument> : SerializableDescriptor<FieldLookupDescriptor<TDocument>>
{
	internal FieldLookupDescriptor(Action<FieldLookupDescriptor<TDocument>> configure) => configure.Invoke(this);

	public FieldLookupDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Id IdValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexName? IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? PathValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? RoutingValue { get; set; }

	/// <summary>
	/// <para>`id` of the document.</para>
	/// </summary>
	public FieldLookupDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>Index from which to retrieve the document.</para>
	/// </summary>
	public FieldLookupDescriptor<TDocument> Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>Name of the field.</para>
	/// </summary>
	public FieldLookupDescriptor<TDocument> Path(Elastic.Clients.Elasticsearch.Serverless.Field? path)
	{
		PathValue = path;
		return Self;
	}

	/// <summary>
	/// <para>Name of the field.</para>
	/// </summary>
	public FieldLookupDescriptor<TDocument> Path<TValue>(Expression<Func<TDocument, TValue>> path)
	{
		PathValue = path;
		return Self;
	}

	/// <summary>
	/// <para>Name of the field.</para>
	/// </summary>
	public FieldLookupDescriptor<TDocument> Path(Expression<Func<TDocument, object>> path)
	{
		PathValue = path;
		return Self;
	}

	/// <summary>
	/// <para>Custom routing value.</para>
	/// </summary>
	public FieldLookupDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("id");
		JsonSerializer.Serialize(writer, IdValue, options);
		if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (PathValue is not null)
		{
			writer.WritePropertyName("path");
			JsonSerializer.Serialize(writer, PathValue, options);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class FieldLookupDescriptor : SerializableDescriptor<FieldLookupDescriptor>
{
	internal FieldLookupDescriptor(Action<FieldLookupDescriptor> configure) => configure.Invoke(this);

	public FieldLookupDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Id IdValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexName? IndexValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Field? PathValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Routing? RoutingValue { get; set; }

	/// <summary>
	/// <para>`id` of the document.</para>
	/// </summary>
	public FieldLookupDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>Index from which to retrieve the document.</para>
	/// </summary>
	public FieldLookupDescriptor Index(Elastic.Clients.Elasticsearch.Serverless.IndexName? index)
	{
		IndexValue = index;
		return Self;
	}

	/// <summary>
	/// <para>Name of the field.</para>
	/// </summary>
	public FieldLookupDescriptor Path(Elastic.Clients.Elasticsearch.Serverless.Field? path)
	{
		PathValue = path;
		return Self;
	}

	/// <summary>
	/// <para>Name of the field.</para>
	/// </summary>
	public FieldLookupDescriptor Path<TDocument, TValue>(Expression<Func<TDocument, TValue>> path)
	{
		PathValue = path;
		return Self;
	}

	/// <summary>
	/// <para>Name of the field.</para>
	/// </summary>
	public FieldLookupDescriptor Path<TDocument>(Expression<Func<TDocument, object>> path)
	{
		PathValue = path;
		return Self;
	}

	/// <summary>
	/// <para>Custom routing value.</para>
	/// </summary>
	public FieldLookupDescriptor Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing)
	{
		RoutingValue = routing;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("id");
		JsonSerializer.Serialize(writer, IdValue, options);
		if (IndexValue is not null)
		{
			writer.WritePropertyName("index");
			JsonSerializer.Serialize(writer, IndexValue, options);
		}

		if (PathValue is not null)
		{
			writer.WritePropertyName("path");
			JsonSerializer.Serialize(writer, PathValue, options);
		}

		if (RoutingValue is not null)
		{
			writer.WritePropertyName("routing");
			JsonSerializer.Serialize(writer, RoutingValue, options);
		}

		writer.WriteEndObject();
	}
}