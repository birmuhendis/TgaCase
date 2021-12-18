using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using TgaCase.ProductManagement.Domain.Schemas.MAIN.ProductDetailAggregates;
using TgaCase.SharedKernel.SeedWork.Repository;

namespace TgaCase.ProductManagement.Infrastructure.Repositories.MAIN.Implementations
{
    public class ProductDetailRepository:  RepositoryBase<ProductDetail,int>, IProductDetailRepository
    {
        public ProductDetailRepository(IDbConnection dbConnection, IDbTransaction dbTransaction, string schemaName, int commandTimeout = 30) : base(dbConnection, dbTransaction, schemaName, commandTimeout)
        {
        }

        public async Task<ProductLastVersionDetail> GetLastVersionByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id, DbType.Int32);
            var sql = $@"select distinct on(p.""Id"") 
                p.""Id"", p.""Name"" as ""ProductName"", p.""UserId"", u.""Username"", pd.""Quantity"", pd.""SalesPrice"",pd.""PurchasePrice"",pd.""UpdatedDate"",c.""Name"" as ""CategoryName""   
                from
               ""MAIN"".""Product"" p 
                inner join ""MAIN"".""ProductDetail"" pd on pd.""ProductId"" = p.""Id""
                inner join ""MAIN"".""User"" u on p.""UserId"" = u.""Id""
                inner join ""MAIN"".""Category"" c on c.""Id"" = p.""CategoryId""
                where p.""Id"" = @id
                order by p.""Id"",pd.""Id"" DESC;
            ";
            var response = await DbConnection.QueryFirstOrDefaultAsync<ProductLastVersionDetail>(sql, parameters, transaction: DbTransaction, commandTimeout: CommandTimeout);
            return  response;
        }

        public async Task<IList<ProductDetailGetBtCategoryId>> GetByCategoryId(int categoryId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@categoryid", categoryId, DbType.Int32);
            var sql = $@"select distinct on(p.""Id"") 
                p.""Id"", p.""Name"" as ""ProductName"", p.""UserId"", u.""Username"", pd.""SalesPrice"",c.""Name"" as ""CategoryName"", pi.""Path"" as   ""ImagePath""
                from
               ""MAIN"".""Product"" p 
                inner join ""MAIN"".""ProductDetail"" pd on pd.""ProductId"" = p.""Id""
                inner join ""MAIN"".""User"" u on p.""UserId"" = u.""Id""
                inner join ""MAIN"".""Category"" c on c.""Id"" = p.""CategoryId""
                left join ""MAIN"".""ProductImages"" pi on pi.""ProductId"" = p.""Id""
                where p.""CategoryId"" = @categoryid
                order by p.""Id"",pd.""Id""  DESC;
            ";
            var response = await DbConnection.QueryAsync<ProductDetailGetBtCategoryId>(sql, parameters, transaction: DbTransaction, commandTimeout: CommandTimeout);
            return  response.ToList();
        }

        public async Task<ProductDetail> GetByProductId(int productId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@productid", productId, DbType.Int32);
            var sql = $@"select * from ""MAIN"".""ProductDetail"" where ""ProductId"" = @productid";
            var response = await DbConnection.QueryFirstOrDefaultAsync<ProductDetail>(sql, parameters, transaction: DbTransaction, commandTimeout: CommandTimeout);
            return  response;
        }
    }
}