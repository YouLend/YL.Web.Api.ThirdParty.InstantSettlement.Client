# YL.Web.Api.ThirdParty.InstantSettlement.Client.Api.InstantSettlementApi

All URIs are relative to *https://staging.youlendapi.com/instantsettlement*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiInstantSettlementGet**](InstantSettlementApi.md#apiinstantsettlementget) | **GET** /api/InstantSettlement | An endpoint for getting your associated Instant Settlements
[**ApiInstantSettlementInstantSettlementNumberPost**](InstantSettlementApi.md#apiinstantsettlementinstantsettlementnumberpost) | **POST** /api/InstantSettlement/{instantSettlementNumber} | Create instant settlement transactions for a specified instant settlement
[**ApiInstantSettlementInstantSettlementNumberTransactionsGet**](InstantSettlementApi.md#apiinstantsettlementinstantsettlementnumbertransactionsget) | **GET** /api/InstantSettlement/{instantSettlementNumber}/transactions | An endpoint for viewing the transactions for an Instant Settlement


<a name="apiinstantsettlementget"></a>
# **ApiInstantSettlementGet**
> List&lt;InstantSettlementView&gt; ApiInstantSettlementGet (string apiVersion = null)

An endpoint for getting your associated Instant Settlements

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.InstantSettlement.Client.Api;
using YL.Web.Api.ThirdParty.InstantSettlement.Client.Client;
using YL.Web.Api.ThirdParty.InstantSettlement.Client.Model;

namespace Example
{
    public class ApiInstantSettlementGetExample
    {
        public static void Main()
        {
			// Configure OAuth2 access token for authorization: oauth2
			Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

			var config = new Configuration
			{
				BasePath = "https://staging.youlendapi.com/instantsettlement",
				AccessToken =
					"YOUR_ACCESS_TOKEN"
			};
			var apiInstance = new InstantSettlementApi(config);
			var apiVersion = apiVersion_example;  // string |  (optional) 


            try
            {
                // An endpoint for getting your associated Instant Settlements
                List<InstantSettlementView> result = apiInstance.ApiInstantSettlementGet(apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstantSettlementApi.ApiInstantSettlementGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiVersion** | **string**|  | [optional] 

### Return type

[**List&lt;InstantSettlementView&gt;**](InstantSettlementView.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instant settlements for a lending partner are returned |  -  |
| **401** | Unauthorized request |  -  |
| **400** | Something went wrong! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiinstantsettlementinstantsettlementnumberpost"></a>
# **ApiInstantSettlementInstantSettlementNumberPost**
> void ApiInstantSettlementInstantSettlementNumberPost (int instantSettlementNumber, string apiVersion = null, List<CreateInstantSettlementTransactionModel> createInstantSettlementTransactionModel = null)

Create instant settlement transactions for a specified instant settlement

Sample request:                    POST /api/InstantSettlement/30000001      [{          \"transactionReferences\": [          \"ref\"          ],          \"currencyISOCode\": \"GBP\",          \"totalSettlementAmount\": 10000,          \"transactionDate\" : \"2020-02-16T18:25:43-05:00\"      },      {          \"transactionReferences\": [          \"ref\"          ],          \"currencyISOCode\": \"GBP\",          \"totalSettlementAmount\": 500,          \"transactionDate\" : \"2020-02-16T18:25:43-05:00\"      }]

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.InstantSettlement.Client.Api;
using YL.Web.Api.ThirdParty.InstantSettlement.Client.Client;
using YL.Web.Api.ThirdParty.InstantSettlement.Client.Model;

namespace Example
{
    public class ApiInstantSettlementInstantSettlementNumberPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://staging.youlendapi.com/instantsettlement";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstantSettlementApi(Configuration.Default);
            var instantSettlementNumber = 56;  // int | Instant settlement number (an integer)
            var apiVersion = apiVersion_example;  // string |  (optional) 
            var createInstantSettlementTransactionModel = new List<CreateInstantSettlementTransactionModel>(); // List<CreateInstantSettlementTransactionModel> |  (optional) 

            try
            {
                // Create instant settlement transactions for a specified instant settlement
                apiInstance.ApiInstantSettlementInstantSettlementNumberPost(instantSettlementNumber, apiVersion, createInstantSettlementTransactionModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstantSettlementApi.ApiInstantSettlementInstantSettlementNumberPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instantSettlementNumber** | **int**| Instant settlement number (an integer) | 
 **apiVersion** | **string**|  | [optional] 
 **createInstantSettlementTransactionModel** | [**List&lt;CreateInstantSettlementTransactionModel&gt;**](CreateInstantSettlementTransactionModel.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instant settlement transaction successfully created |  -  |
| **401** | Unauthorized request |  -  |
| **403** | Forbidden request |  -  |
| **422** | CreateInstantSettlementTransactionModel from request body failed validation |  -  |
| **400** | Something went wrong! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apiinstantsettlementinstantsettlementnumbertransactionsget"></a>
# **ApiInstantSettlementInstantSettlementNumberTransactionsGet**
> List&lt;InstantSettlementTransactionModel&gt; ApiInstantSettlementInstantSettlementNumberTransactionsGet (int instantSettlementNumber, string apiVersion = null)

An endpoint for viewing the transactions for an Instant Settlement

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using YL.Web.Api.ThirdParty.InstantSettlement.Client.Api;
using YL.Web.Api.ThirdParty.InstantSettlement.Client.Client;
using YL.Web.Api.ThirdParty.InstantSettlement.Client.Model;

namespace Example
{
    public class ApiInstantSettlementInstantSettlementNumberTransactionsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://staging.youlendapi.com/instantsettlement";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstantSettlementApi(Configuration.Default);
            var instantSettlementNumber = 56;  // int | The number of the Instant Settlement product
            var apiVersion = apiVersion_example;  // string |  (optional) 

            try
            {
                // An endpoint for viewing the transactions for an Instant Settlement
                List<InstantSettlementTransactionModel> result = apiInstance.ApiInstantSettlementInstantSettlementNumberTransactionsGet(instantSettlementNumber, apiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstantSettlementApi.ApiInstantSettlementInstantSettlementNumberTransactionsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instantSettlementNumber** | **int**| The number of the Instant Settlement product | 
 **apiVersion** | **string**|  | [optional] 

### Return type

[**List&lt;InstantSettlementTransactionModel&gt;**](InstantSettlementTransactionModel.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Instant settlement transactions are returned |  -  |
| **401** | Unauthorized request |  -  |
| **400** | Something went wrong! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

