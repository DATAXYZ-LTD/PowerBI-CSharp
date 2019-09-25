// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// EmbedTokenOperations operations.
    /// </summary>
    public partial interface IEmbedTokenOperations
    {
        /// <summary>
        /// Generates an embed token for multiple reports, datasets and target
        /// workspaces. Reports and datasets do not have to be related. The
        /// binding of a report to a dataset can be done during embedding.
        /// Target workspaces are workspaces where creation of reports is
        /// allowed.&lt;br/&gt;This API is relevant only to ['App owns data'
        /// embed
        /// scenario](https://docs.microsoft.com/power-bi/developer/embed-sample-for-customers).
        /// </summary>
        /// <remarks>
        /// &lt;br/&gt;**Required scope**: &lt;ul&gt;&lt;li&gt;Content.Create -
        /// required only if a target workspace is specified in
        /// [GenerateTokenRequestV2](/rest/api/power-bi/embedtoken/generatetoken#generatetokenrequestv2)&lt;/li&gt;&lt;li&gt;Report.ReadWrite.All
        /// or Report.Read.All - required only if a report is specified in
        /// [GenerateTokenRequestV2](/rest/api/power-bi/embedtoken/generatetoken#generatetokenrequestv2)&lt;/li&gt;&lt;li&gt;Report.ReadWrite.All
        /// - required if allowEdit flag is specified for at least one report
        /// in
        /// [GenerateTokenRequestV2](/rest/api/power-bi/embedtoken/generatetoken#generatetokenrequestv2)&lt;/li&gt;&lt;li&gt;Dataset.ReadWrite.All
        /// or Dataset.Read.All&lt;/li&gt;&lt;/ul&gt; &lt;br/&gt;To set the
        /// permissions scope, see [Register an
        /// app](https://docs.microsoft.com/power-bi/developer/register-app).
        /// &lt;h2&gt;Restrictions&lt;/h2&gt;&lt;li&gt;All the reports and
        /// datasets must reside in workspace V2. All the target workpaces must
        /// be workspace V2.&lt;/li&gt;&lt;li&gt;Maximum number of reports,
        /// datasets and target workspaces is 50
        /// each.&lt;/li&gt;&lt;li&gt;Generating Embed Token with RLS may not
        /// work for AS Azure or AS OnPrem live connection reports for several
        /// minutes after a
        /// [Rebind](/rest/api/power-bi/reports/RebindReport).&lt;/li&gt;&lt;br/&gt;
        /// </remarks>
        /// <param name='requestParameters'>
        /// Generate token parameters
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<EmbedToken>> GenerateTokenWithHttpMessagesAsync(GenerateTokenRequestV2 requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
