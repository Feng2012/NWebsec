// Copyright (c) Andr� N. Klingsheim. See License.txt in the project root for license information.

using System.Web;
using NWebsec.Core.Fluent;

namespace NWebsec.Mvc.Html
{
    /// <summary>
    /// Interface to generate a Referrer policy meta tag.
    /// </summary>
    public interface IReferrerPolicy: IFluentInterface

    {
        /// <summary>
        /// Specifies the <c>none</c> policy, instructing the browser to not send referrer information.
        /// </summary>
        /// <returns>The meta tag.</returns>
        HtmlString None();

        /// <summary>
        /// Specifies the 'none-when-downgrade' policy, instructing the browser to send full referrer information unless navigation is from HTTPS->HTTP.
        /// </summary>
        /// <returns>The meta tag.</returns>
        HtmlString NoneWhenDownGrade();

        /// <summary>
        /// Specifies the 'origin' policy, instructing the browser to send referrer information about the origin only, without path and query. 
        /// </summary>
        /// <returns>The meta tag.</returns>
        HtmlString Origin();

        /// <summary>
        /// Specifies the 'origin-when-crossorigin' policy, instructing the browser to send full referrer information for same origin but origin only when cross origin. 
        /// </summary>
        /// <returns>The meta tag.</returns>
        HtmlString OriginWhenCrossOrigin();

        /// <summary>
        /// Specifies the 'unsafe-url' policy, instructing the browser to always send full referrer information, even when requests are from HTTPS->HTTP. 
        /// </summary>
        /// <returns>The meta tag.</returns>
        HtmlString UnsafeUrl();
    }
}