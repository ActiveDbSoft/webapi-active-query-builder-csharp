# WebApi.ActiveQueryBuilder - the C# library for the QueryBuilderApi

Active Query Builder Web API lets create, analyze and modify SQL queries for different database servers using RESTful HTTP requests to a cloud-based service. It requires SQL execution context (information about database schema and used database server) to be stored under the registered account at https://webapi.activequerybuilder.com/.

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommned using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation
Include the DLL in the C# project, and use the namespaces:
```csharp
using WebApi.ActiveQueryBuilder.Api;
using WebApi.ActiveQueryBuilder.Client;
using WebApi.ActiveQueryBuilder.Model;
```

## Getting Started

```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using WebApi.ActiveQueryBuilder.Api;
using WebApi.ActiveQueryBuilder.Client;
using WebApi.ActiveQueryBuilder.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            string sql = "Select customer_id, first_name From customer";
            string metadataGuid = "b3207f4f-b1f4-4dc2-979b-7724ed2d0221";

            var apiInstance = new ActiveQueryBuilderApi();
            
            var query = new SqlQuery() // SqlQuery | Information about SQL query and it's context.
            {
              Guid = metadataGuid,
              Text = sql
            };
            
            List<QueryColumn> columns = apiInstance.GetQueryColumnsPost(query);
            Debug.WriteLine("API called successfully. Returned columns: " + columns.Count);
            
            var transform = new Transform
            {
                Guid = metadataGuid,
                Sql = sql
            };

            var filter = new ConditionGroup();

            var conditionGroup = new ConditionGroup();

            var condition = new Condition
            {
                Field = "customer_id",
                ConditionOperator = Condition.ConditionOperatorEnum.Greater,
                Values = new List<string> { "10" }
            };
            
            conditionGroup.Conditions = new List<Condition> { condition };

            filter.ConditionGroups = new List<ConditionGroup> { conditionGroup };

            var page = new Pagination { Skip = 2, Take = 3 };
            var order = new Sorting { Field = "customer_id", Order = Sorting.OrderEnum.Desc };            

            transform.Filter = filter;
            transform.Pagination = page;
            transform.Sortings = new List<Sorting> { order };

            TransformResult result = apiInstance.TransformSQLPost(transform);
            Debug.WriteLine("API called successfully. Returned result: " + result.Sql);
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://webapi.activequerybuilder.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ActiveQueryBuilderApi* | [**GetQueryColumnsPost**](docs/ActiveQueryBuilderApi.md#getquerycolumnspost) | **POST** /getQueryColumns | 
*ActiveQueryBuilderApi* | [**TransformSQLPost**](docs/ActiveQueryBuilderApi.md#transformsqlpost) | **POST** /transformSQL | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Condition](docs/Condition.md)
 - [Model.ConditionGroup](docs/ConditionGroup.md)
 - [Model.HiddenColumn](docs/HiddenColumn.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.QueryColumn](docs/QueryColumn.md)
 - [Model.Sorting](docs/Sorting.md)
 - [Model.SqlQuery](docs/SqlQuery.md)
 - [Model.Totals](docs/Totals.md)
 - [Model.Transform](docs/Transform.md)
 - [Model.TransformResult](docs/TransformResult.md)


## Source code
Full source code of all clients for Active Query Builder Web API is available on GitHub. Get the source code of javascript here: [https://github.com/ActiveDbSoft/webapi-active-query-builder-csharp](https://github.com/ActiveDbSoft/webapi-active-query-builder-csharp)
