if col_length('dbo.Installments','extra_amount_1') is null
ALTER TABLE dbo.Installments ADD extra_amount_1 MONEY NULL DEFAULT(0)
GO

if col_length('dbo.Installments','extra_amount_2') is null
ALTER TABLE dbo.Installments ADD extra_amount_2 MONEY NULL DEFAULT(0)
GO
--********************

if col_length('dbo.InstallmentHistory','extra_amount_1') is null
ALTER TABLE dbo.InstallmentHistory ADD extra_amount_1 MONEY NULL DEFAULT(0)
GO

if col_length('dbo.InstallmentHistory','extra_amount_2') is null
ALTER TABLE dbo.InstallmentHistory ADD extra_amount_2 MONEY NULL DEFAULT(0)
GO

-----------------------------------

if col_length('dbo.Installments','last_interest_accrual_date') is null
ALTER TABLE dbo.Installments ADD last_interest_accrual_date MONEY NULL DEFAULT(0)
GO

if col_length('dbo.InstallmentHistory','last_interest_accrual_date') is null
ALTER TABLE dbo.InstallmentHistory ADD last_interest_accrual_date MONEY NULL DEFAULT(0)
GO

update dbo.Installments set last_interest_accrual_date = expected_date
GO

update dbo.InstallmentHistory set last_interest_accrual_date = expected_date
GO

UPDATE  [TechnicalParameters]
SET     [value] = 'v15.11.0.0'
WHERE   [name] = 'VERSION'
GO
