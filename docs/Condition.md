# WebApi.ActiveQueryBuilder.Model.Condition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Column of original query to which a constraint will applied. | [optional] 
**ConditionOperator** | **string** | Condition operator. | [optional] 
**Values** | **List&lt;string&gt;** | List of values for a constraint. \&quot;IsNull\&quot;, \&quot;IsNotNull\&quot; need no values; \&quot;Between\&quot;, \&quot;NotBetween\&quot; require 2 values; \&quot;In\&quot; accepts one or more values; other conditions accept single value only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

