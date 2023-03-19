
using ShowMeRepair.api.Interfaces;
using ViewModelClass;
using Dapper;
using Microsoft.Data.SqlClient;

namespace ShowMeRepair.api.Repositories;

public class ShowMeRepairRepo : IShowMeRepairRepo
{
    

 

    public async Task<CardComponentVM> GetCardComponentContents(CardComponentVM cc)
    {
        CardComponentVM cardComponentVm = new CardComponentVM();
        var SQLSELECT =
            @"SELECT [CardHeaderOne], [CardBodyOne], [CardHeaderTwo], [CardBodyTwo], [CardHeaderThree], [CardBodyThree]";
        var SQLFROM = @"FROM [ShowMeRepairRepo].[dbo].[CardComponent]";
        var SQL = SQLSELECT + SQLFROM;
        try
        {
            using (var con = new SqlConnection())
            {
                await con.OpenAsync();
                var requestModel = con.QueryAsync<CardComponentVM>(SQL).Result.FirstOrDefault();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        return cardComponentVm;
    }
}