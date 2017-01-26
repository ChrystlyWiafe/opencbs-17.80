UPDATE  [TechnicalParameters]
SET     [value] = 'v17.1.0.0'
WHERE   [name] = 'VERSION'
GO

if col_length('dbo.Credit','initial_emi') IS NULL
    begin
        alter table dbo.Credit add initial_emi decimal(18,2) null
    end
GO

if col_length('dbo.PaymentMethods','accountNumber') IS NULL
    begin
        alter table dbo.PaymentMethods add accountNumber varchar(32) null
    end
GO