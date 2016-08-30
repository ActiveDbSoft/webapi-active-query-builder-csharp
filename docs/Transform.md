# WebApi.ActiveQueryBuilder.Model.Transform
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Guid** | **string** | Unique identifier that defines SQL execution context for the given query, i.e. database server (SQL syntax rules),  database schema. The context itself must be saved in the user account on https://webapi.activequerybuilder.com/. | [optional] 
**Sql** | **string** | Text of original SQL query to be transformed. | [optional] 
**Pagination** | [**Pagination**](Pagination.md) |  | [optional] 
**Totals** | [**List&lt;Totals&gt;**](Totals.md) |  | [optional] 
**Sortings** | [**List&lt;Sorting&gt;**](Sorting.md) |  | [optional] 
**Filter** | [**ConditionGroup**](ConditionGroup.md) |  | [optional] 
**HiddenColumns** | [**List&lt;HiddenColumn&gt;**](HiddenColumn.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

