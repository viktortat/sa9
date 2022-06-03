using Core.DataAccess;
using Core.Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Bu s�n�f Repository pattern kullan�r IEntityRepository'den implemente edilir T generic tipinde nesne al�r.
    /// s�n�fa �zel operasyonlar bu s�n�f i�inde tan�mlan�r. �rne�ini IUserRepository interface i i�inde bulabilirsiniz.
    /// </summary>
    public interface IUserRepository : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(int userId);
    }
}