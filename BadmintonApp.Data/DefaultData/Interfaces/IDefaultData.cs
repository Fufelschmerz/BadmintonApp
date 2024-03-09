using BadmintonApp.Data.Entities;

namespace BadmintonApp.Data.DefaultData.Interfaces;

public interface IDefaultData<TEntity>
    where TEntity : BaseEntity
{
    IEnumerable<TEntity> GetDefaultsData();
}
