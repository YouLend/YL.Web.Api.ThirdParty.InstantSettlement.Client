/* 
 * YouLend Third Party Instant Settlement API
 *
 * Through this API you can can create Instant Settlement transactions with YouLend
 *
 * The version of the OpenAPI document: v1.0
 * Contact: mark.ufland@youlend.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;

namespace YL.Web.Api.ThirdParty.InstantSettlement.Client.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IApiResponse response);
}
