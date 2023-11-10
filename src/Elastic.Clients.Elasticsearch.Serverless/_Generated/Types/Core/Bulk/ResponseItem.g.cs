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
using Elastic.Transport.Products.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Core.Bulk;

public abstract partial class ResponseItem
{
	/// <summary>
	/// <para>The document ID associated with the operation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_id")]
	public string? Id { get; init; }

	/// <summary>
	/// <para>Name of the index associated with the operation.<br/>If the operation targeted a data stream, this is the backing index into which the document was written.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_index")]
	public string Index { get; init; }

	/// <summary>
	/// <para>The primary term assigned to the document for the operation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_primary_term")]
	public long? PrimaryTerm { get; init; }

	/// <summary>
	/// <para>The sequence number assigned to the document for the operation.<br/>Sequence numbers are used to ensure an older version of a document doesn’t overwrite a newer version.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_seq_no")]
	public long? SeqNo { get; init; }

	/// <summary>
	/// <para>Contains shard information for the operation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_shards")]
	public Elastic.Clients.Elasticsearch.Serverless.ShardStatistics? Shards { get; init; }

	/// <summary>
	/// <para>The document version associated with the operation.<br/>The document version is incremented each time the document is updated.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_version")]
	public long? Version { get; init; }

	/// <summary>
	/// <para>Contains additional information about the failed operation.<br/>The parameter is only returned for failed operations.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("error")]
	public Elastic.Clients.Elasticsearch.Serverless.ErrorCause? Error { get; init; }
	[JsonInclude, JsonPropertyName("forced_refresh")]
	public bool? ForcedRefresh { get; init; }
	[JsonInclude, JsonPropertyName("get")]
	public Elastic.Clients.Elasticsearch.Serverless.InlineGet<LazyJson>? Get { get; init; }

	/// <summary>
	/// <para>Result of the operation.<br/>Successful values are `created`, `deleted`, and `updated`.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("result")]
	public string? Result { get; init; }

	/// <summary>
	/// <para>HTTP status code returned for the operation.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("status")]
	public int Status { get; init; }
}