namespace Raitan.Infrastructure.Data.EF.Contracts
{
    public interface IEntity
    {
        long Id { get; set; }
        bool IsActive { get; set; }
    }
}