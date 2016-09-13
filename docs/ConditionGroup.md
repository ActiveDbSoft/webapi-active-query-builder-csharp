# WebApi.ActiveQueryBuilder.Model.ConditionGroup

Group of conditions joined with the same boolean operator.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JunctionType** | **string** | Type of junction. All = AND; Any = OR. | [optional] 
**Conditions** | [**List&lt;Condition&gt;**](Condition.md) | List of conditions to join. | [optional] 
**ConditionGroups** | [**List&lt;ConditionGroup&gt;**](ConditionGroup.md) | List of nested condition groups to join them with a different boolean operator. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

