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

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless.Cluster;

public partial class ClusterNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// Initializes a new instance of the <see cref="ClusterNamespacedClient"/> class for mocking.
	/// </summary>
	protected ClusterNamespacedClient() : base()
	{
	}

	internal ClusterNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>Provides explanations for shard allocations in the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-allocation-explain.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AllocationExplainResponse AllocationExplain(AllocationExplainRequest request)
	{
		request.BeforeRequest();
		return DoRequest<AllocationExplainRequest, AllocationExplainResponse, AllocationExplainRequestParameters>(request);
	}

	/// <summary>
	/// <para>Provides explanations for shard allocations in the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-allocation-explain.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AllocationExplainResponse> AllocationExplainAsync(AllocationExplainRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<AllocationExplainRequest, AllocationExplainResponse, AllocationExplainRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Provides explanations for shard allocations in the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-allocation-explain.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AllocationExplainResponse AllocationExplain()
	{
		var descriptor = new AllocationExplainRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<AllocationExplainRequestDescriptor, AllocationExplainResponse, AllocationExplainRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Provides explanations for shard allocations in the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-allocation-explain.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AllocationExplainResponse AllocationExplain(AllocationExplainRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<AllocationExplainRequestDescriptor, AllocationExplainResponse, AllocationExplainRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Provides explanations for shard allocations in the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-allocation-explain.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual AllocationExplainResponse AllocationExplain(Action<AllocationExplainRequestDescriptor> configureRequest)
	{
		var descriptor = new AllocationExplainRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<AllocationExplainRequestDescriptor, AllocationExplainResponse, AllocationExplainRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Provides explanations for shard allocations in the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-allocation-explain.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AllocationExplainResponse> AllocationExplainAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new AllocationExplainRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<AllocationExplainRequestDescriptor, AllocationExplainResponse, AllocationExplainRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Provides explanations for shard allocations in the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-allocation-explain.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AllocationExplainResponse> AllocationExplainAsync(AllocationExplainRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<AllocationExplainRequestDescriptor, AllocationExplainResponse, AllocationExplainRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Provides explanations for shard allocations in the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-allocation-explain.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<AllocationExplainResponse> AllocationExplainAsync(Action<AllocationExplainRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new AllocationExplainRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<AllocationExplainRequestDescriptor, AllocationExplainResponse, AllocationExplainRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns high-level overview of cluster statistics.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-stats.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual ClusterStatsResponse Stats(ClusterStatsRequest request)
	{
		request.BeforeRequest();
		return DoRequest<ClusterStatsRequest, ClusterStatsResponse, ClusterStatsRequestParameters>(request);
	}

	/// <summary>
	/// <para>Returns high-level overview of cluster statistics.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-stats.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClusterStatsResponse> StatsAsync(ClusterStatsRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<ClusterStatsRequest, ClusterStatsResponse, ClusterStatsRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns high-level overview of cluster statistics.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-stats.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual ClusterStatsResponse Stats()
	{
		var descriptor = new ClusterStatsRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<ClusterStatsRequestDescriptor, ClusterStatsResponse, ClusterStatsRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns high-level overview of cluster statistics.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-stats.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual ClusterStatsResponse Stats(ClusterStatsRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<ClusterStatsRequestDescriptor, ClusterStatsResponse, ClusterStatsRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns high-level overview of cluster statistics.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-stats.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual ClusterStatsResponse Stats(Action<ClusterStatsRequestDescriptor> configureRequest)
	{
		var descriptor = new ClusterStatsRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<ClusterStatsRequestDescriptor, ClusterStatsResponse, ClusterStatsRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns high-level overview of cluster statistics.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-stats.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClusterStatsResponse> StatsAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new ClusterStatsRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<ClusterStatsRequestDescriptor, ClusterStatsResponse, ClusterStatsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns high-level overview of cluster statistics.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-stats.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClusterStatsResponse> StatsAsync(ClusterStatsRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<ClusterStatsRequestDescriptor, ClusterStatsResponse, ClusterStatsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns high-level overview of cluster statistics.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-stats.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<ClusterStatsResponse> StatsAsync(Action<ClusterStatsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new ClusterStatsRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<ClusterStatsRequestDescriptor, ClusterStatsResponse, ClusterStatsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns cluster settings.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-get-settings.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetClusterSettingsResponse GetSettings(GetClusterSettingsRequest request)
	{
		request.BeforeRequest();
		return DoRequest<GetClusterSettingsRequest, GetClusterSettingsResponse, GetClusterSettingsRequestParameters>(request);
	}

	/// <summary>
	/// <para>Returns cluster settings.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-get-settings.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetClusterSettingsResponse> GetSettingsAsync(GetClusterSettingsRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetClusterSettingsRequest, GetClusterSettingsResponse, GetClusterSettingsRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns cluster settings.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-get-settings.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetClusterSettingsResponse GetSettings()
	{
		var descriptor = new GetClusterSettingsRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<GetClusterSettingsRequestDescriptor, GetClusterSettingsResponse, GetClusterSettingsRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns cluster settings.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-get-settings.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetClusterSettingsResponse GetSettings(GetClusterSettingsRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<GetClusterSettingsRequestDescriptor, GetClusterSettingsResponse, GetClusterSettingsRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns cluster settings.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-get-settings.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual GetClusterSettingsResponse GetSettings(Action<GetClusterSettingsRequestDescriptor> configureRequest)
	{
		var descriptor = new GetClusterSettingsRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<GetClusterSettingsRequestDescriptor, GetClusterSettingsResponse, GetClusterSettingsRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns cluster settings.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-get-settings.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetClusterSettingsResponse> GetSettingsAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new GetClusterSettingsRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<GetClusterSettingsRequestDescriptor, GetClusterSettingsResponse, GetClusterSettingsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns cluster settings.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-get-settings.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetClusterSettingsResponse> GetSettingsAsync(GetClusterSettingsRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetClusterSettingsRequestDescriptor, GetClusterSettingsResponse, GetClusterSettingsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns cluster settings.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-get-settings.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetClusterSettingsResponse> GetSettingsAsync(Action<GetClusterSettingsRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetClusterSettingsRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetClusterSettingsRequestDescriptor, GetClusterSettingsResponse, GetClusterSettingsRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual HealthResponse Health(HealthRequest request)
	{
		request.BeforeRequest();
		return DoRequest<HealthRequest, HealthResponse, HealthRequestParameters>(request);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<HealthResponse> HealthAsync(HealthRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<HealthRequest, HealthResponse, HealthRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual HealthResponse Health()
	{
		var descriptor = new HealthRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<HealthRequestDescriptor, HealthResponse, HealthRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual HealthResponse Health(HealthRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<HealthRequestDescriptor, HealthResponse, HealthRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual HealthResponse Health(Action<HealthRequestDescriptor> configureRequest)
	{
		var descriptor = new HealthRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<HealthRequestDescriptor, HealthResponse, HealthRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual HealthResponse Health<TDocument>(HealthRequestDescriptor<TDocument> descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<HealthRequestDescriptor<TDocument>, HealthResponse, HealthRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual HealthResponse Health<TDocument>(Action<HealthRequestDescriptor<TDocument>> configureRequest)
	{
		var descriptor = new HealthRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<HealthRequestDescriptor<TDocument>, HealthResponse, HealthRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<HealthResponse> HealthAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new HealthRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<HealthRequestDescriptor, HealthResponse, HealthRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<HealthResponse> HealthAsync(HealthRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<HealthRequestDescriptor, HealthResponse, HealthRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<HealthResponse> HealthAsync(Action<HealthRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new HealthRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<HealthRequestDescriptor, HealthResponse, HealthRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<HealthResponse> HealthAsync<TDocument>(HealthRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<HealthRequestDescriptor<TDocument>, HealthResponse, HealthRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns basic information about the health of the cluster.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-health.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<HealthResponse> HealthAsync<TDocument>(Action<HealthRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new HealthRequestDescriptor<TDocument>();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<HealthRequestDescriptor<TDocument>, HealthResponse, HealthRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a list of any cluster-level changes (e.g. create index, update mapping,<br/>allocate or fail shard) which have not yet been executed.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-pending.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual PendingTasksResponse PendingTasks(PendingTasksRequest request)
	{
		request.BeforeRequest();
		return DoRequest<PendingTasksRequest, PendingTasksResponse, PendingTasksRequestParameters>(request);
	}

	/// <summary>
	/// <para>Returns a list of any cluster-level changes (e.g. create index, update mapping,<br/>allocate or fail shard) which have not yet been executed.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-pending.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PendingTasksResponse> PendingTasksAsync(PendingTasksRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<PendingTasksRequest, PendingTasksResponse, PendingTasksRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a list of any cluster-level changes (e.g. create index, update mapping,<br/>allocate or fail shard) which have not yet been executed.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-pending.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual PendingTasksResponse PendingTasks()
	{
		var descriptor = new PendingTasksRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<PendingTasksRequestDescriptor, PendingTasksResponse, PendingTasksRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns a list of any cluster-level changes (e.g. create index, update mapping,<br/>allocate or fail shard) which have not yet been executed.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-pending.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual PendingTasksResponse PendingTasks(PendingTasksRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<PendingTasksRequestDescriptor, PendingTasksResponse, PendingTasksRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns a list of any cluster-level changes (e.g. create index, update mapping,<br/>allocate or fail shard) which have not yet been executed.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-pending.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual PendingTasksResponse PendingTasks(Action<PendingTasksRequestDescriptor> configureRequest)
	{
		var descriptor = new PendingTasksRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<PendingTasksRequestDescriptor, PendingTasksResponse, PendingTasksRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>Returns a list of any cluster-level changes (e.g. create index, update mapping,<br/>allocate or fail shard) which have not yet been executed.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-pending.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PendingTasksResponse> PendingTasksAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new PendingTasksRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<PendingTasksRequestDescriptor, PendingTasksResponse, PendingTasksRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a list of any cluster-level changes (e.g. create index, update mapping,<br/>allocate or fail shard) which have not yet been executed.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-pending.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PendingTasksResponse> PendingTasksAsync(PendingTasksRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<PendingTasksRequestDescriptor, PendingTasksResponse, PendingTasksRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>Returns a list of any cluster-level changes (e.g. create index, update mapping,<br/>allocate or fail shard) which have not yet been executed.</para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/8.11/cluster-pending.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<PendingTasksResponse> PendingTasksAsync(Action<PendingTasksRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new PendingTasksRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<PendingTasksRequestDescriptor, PendingTasksResponse, PendingTasksRequestParameters>(descriptor, cancellationToken);
	}
}