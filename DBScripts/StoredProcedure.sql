USE [cs6232-g4]
GO
/****** Object:  StoredProcedure [dbo].[GetAdminReport]    Script Date: 4/22/2024 12:05:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Leslie Keller
-- Create date: 17 April 2024
-- Description:	Purpose: Gets the statistics that show the most popular furniture
--				during the specified period for furniture with the same furnintureID
--				that was rented out in at least two transactions.
-- Updated:		30 April 2024
-- Modification: Handled the total transactions change to an overall total
-- =============================================

ALTER PROCEDURE [dbo].[GetAdminReport] 
	-- Add the parameters for the stored procedure here
	@StartDate DateTime = null, 
	@EndDate DateTime = null

AS
BEGIN TRY

	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON; 

	SELECT  f.furniture_id as furniture_id, f.name, f.category_name,
		 	sum(li.rental_transaction_id) as total_transactions,
			count(rt.transaction_id) as total_qualifying_trans,
			count(rt.transaction_id)*100/sum(li.rental_transaction_id) as pct_qualifying_transactions,
			(sum(IIF(DATEDIFF(year, mbr.date_of_birth, rt.transaction_date) < 29 and  
			DATEDIFF(year, mbr.date_of_birth, rt.transaction_date) >17, 1, 0)) * 100)/ count(mbr.member_id) as pct_18_to_29,
			(sum(IIF(DATEDIFF(year, mbr.date_of_birth, rt.transaction_date) > 29 or 
			DATEDIFF(year, mbr.date_of_birth, rt.transaction_date) < 18, 1, 0)) * 100)/ count(mbr.member_id) as pct_over_age_range

			FROM dbo.Furniture f
			INNER JOIN dbo.RentalLineItem li
			ON f.furniture_id = li.furniture_id

			INNER JOIN dbo.RentalTransaction rt
            		ON rt.transaction_id = li.rental_transaction_id
			
			INNER JOIN dbo.StoreMember mbr
            		ON rt.member_id = mbr.member_id

			WHERE rt.transaction_date between @StartDate and @EndDate
			group by f.furniture_id, f.name, f.category_name
			having count(rt.transaction_id)  >= 2
			order by total_qualifying_trans desc, furniture_ID desc

END TRY

-- Error Checking

BEGIN CATCH

	SELECT  
        ERROR_NUMBER() AS ErrorNumber  
        ,ERROR_SEVERITY() AS ErrorSeverity  
        ,ERROR_STATE() AS ErrorState  
        ,ERROR_PROCEDURE() AS ErrorProcedure  
        ,ERROR_LINE() AS ErrorLine  
        ,ERROR_MESSAGE() AS ErrorMessage;

END CATCH;
