# WebApi.ActiveQueryBuilder.Api.ActiveQueryBuilderApi

All URIs are relative to *https://webapi.activequerybuilder.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetQueryColumnsPost**](ActiveQueryBuilderApi.md#getquerycolumnspost) | **POST** /getQueryColumns | 
[**TransformSQLPost**](ActiveQueryBuilderApi.md#transformsqlpost) | **POST** /transformSQL | 


<a name="getquerycolumnspost"></a>
# **GetQueryColumnsPost**
> List<QueryColumn> GetQueryColumnsPost (SqlQuery query)



Returns list of columns for the given SQL query.

### Example
```csharp
using System;
using System.Diagnostics;
using WebApi.ActiveQueryBuilder.Api;
using WebApi.ActiveQueryBuilder.Client;
using WebApi.ActiveQueryBuilder.Model;

namespace Example
{
    public class GetQueryColumnsPostExample
    {
        public void main()
        {
            
            var apiInstance = new ActiveQueryBuilderApi();
            var query = new SqlQuery(); // SqlQuery | Information about SQL query and it's context.

            try
            {
                List&lt;QueryColumn&gt; result = apiInstance.GetQueryColumnsPost(query);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveQueryBuilderApi.GetQueryColumnsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | [**SqlQuery**](SqlQuery.md)| Information about SQL query and it&#39;s context. | 

### Return type

[**List<QueryColumn>**](QueryColumn.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transformsqlpost"></a>
# **TransformSQLPost**
> TransformResult TransformSQLPost (Transform transform)



Transforms the given SQL query according to the commands provided in this request. You can add constraints, hide some of the resultset columns, chang sorting or limit rows of resultset. All transformations can only lead to reorganization or limitation of the resultset data. This means that it's impossible to get transformed SQL that reveals any other data than the data retutned by original query.

### Example
```csharp
using System;
using System.Diagnostics;
using WebApi.ActiveQueryBuilder.Api;
using WebApi.ActiveQueryBuilder.Client;
using WebApi.ActiveQueryBuilder.Model;

namespace Example
{
    public class TransformSQLPostExample
    {
        public void main()
        {
            
            var apiInstance = new ActiveQueryBuilderApi();
            var transform = new Transform(); // Transform | SQL transformation parameters and commands.

            try
            {
                TransformResult result = apiInstance.TransformSQLPost(transform);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiveQueryBuilderApi.TransformSQLPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transform** | [**Transform**](Transform.md)| SQL transformation parameters and commands. | 

### Return type

[**TransformResult**](TransformResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/xml
 - **Accept**: application/json, text/html

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

