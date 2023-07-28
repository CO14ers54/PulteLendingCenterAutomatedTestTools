--Test Automation Database

SELECT [id]
      ,[loan_id]
      ,[confirmation_id]
      ,[batch_id]
      ,[entered]
      ,[processed_by_automation_for_empower]
      ,[processed_by_automation_date]
FROM [TestAutomation].[dbo].[association_my_loan_to_empower]

  --truncate table association_my_loan_to_empower
  --truncate table loan_generator_batch

USE EMPOWER
GO
UPDATE EMPOWER.DBLOCKS
SET NETWORKLOCKED = 'N'
WHERE LNKEY = '##-######A'


SELECT a.loan_id, a.confirmation_id, a.batch_id, b.loan_type, a.entered, a.processed_by_automation_for_empower, a.processed_by_automation_date, b.created_by
FROM association_my_loan_to_empower a
	INNER JOIN loan_generator_batch b ON a.batch_id = b.id
ORDER BY a.batch_id, a.loan_id ASC

-- empower-db  EMPOWER

SELECT [LNKEY]
      ,[U_WEB_QUESTIONNAIRE_SUBMITTED]
      ,[U_WEB_QUESTIONNAIRE_UPLOADED]
      ,[U_WEB_CONFIRMATION_ID]
      ,[U_WEB_CUST_ID]
      ,[ORIGINAL_EDOC_SELECTION]
FROM [Empower].[EMPOWER].[U_LS_WEB_APP]
ORDER BY U_WEB_QUESTIONNAIRE_SUBMITTED DESC

SELECT *
FROM [Empower].[EMPOWER].[U_LS_WEB_APP]
WHERE U_WEB_CONFIRMATION_ID = 'PMA002-433'

-- eda-db  PM_EDA

SELECT TOP 1000
       e.BusinessObjectID
      ,e.StructuredContext
	  ,d.BusinessEventDefinitionName
      ,e.CreateDate
      ,e.EffectiveTimeStamp
      ,e.RecordingTimeStamp

FROM [PM_EDA].[dbo].BusinessEvent AS e WITH (NOLOCK)
    INNER JOIN [PM_EDA].[dbo].BusinessEventDefinition AS d WITH (NOLOCK)
        On e.BusinessEventDefinitionID = d.BusinessEventDefinitionID
WHERE d.BusinessEventDefinitionName = 'WebLoanQuestionnaireSubmitted'
ORDER BY e.EffectiveTimeStamp DESC