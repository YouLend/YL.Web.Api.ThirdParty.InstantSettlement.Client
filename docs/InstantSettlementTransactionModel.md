# YL.Web.Api.ThirdParty.InstantSettlement.Client.Model.InstantSettlementTransactionModel
Model for viewing details of an Instant Settlement transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstantSettlementId** | **Guid** | Gets or sets the Instant Settlement Id | [optional] 
**InstantSettlementTransactionNumber** | **int** | Gets or sets the Instant Settlement Number | [optional] 
**Status** | **string** | Gets or sets the status of the loan (i.e. unfunded, funded or repaid) | [optional] 
**DateCreated** | **DateTime** | Gets or sets the date the loan was created | [optional] 
**DateFunded** | **DateTime** | Gets or sets the date the loan was funded | [optional] 
**DateRepaid** | **DateTime** | Gets or sets the date the loan was repaid | [optional] 
**CurrentAmount** | **double** | Gets or sets the current amount outstanding for the loan | [optional] 
**FundedAmount** | **double** | Gets or sets the originally funded amount for the loan | [optional] 
**Amount** | **double** | Gets or sets the amount requested for funding for the loan | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

