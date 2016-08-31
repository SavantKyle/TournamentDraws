/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
:r .\Seed\AddRatings.sql
:r .\Seed\AddTournaments.sql
:r .\Seed\AddFacilities.sql
:r .\Seed\AddDivisionGroups.sql
:r .\Seed\AddDivisions.sql
:r .\Seed\AddTeams.sql
:r .\Seed\AddPlayers.sql
:r .\Seed\AddCourts.sql
:r .\Seed\AddCourtTimes.sql