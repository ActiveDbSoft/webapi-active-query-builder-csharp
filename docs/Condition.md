# WebApi.ActiveQueryBuilder.Model.Condition

Defines a constraint for original query resultset values.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Column of original query to which a constraint will applied. | [optional] 
**ConditionOperator** | **string** | Condition operator. | [optional] 
**Values** | **List&lt;string&gt;** | List of values for a constraint. 'IsNull', 'IsNotNull' need no values; 'Between', 'NotBetween' require 2 values; 'In' accepts one or more values; other conditions accept single value only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

