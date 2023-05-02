namespace ExampleProject.Core.Entities.Abstract;

public abstract class EntityBase
{
    public virtual int Id { get; set; }
    public virtual DateTime? CreatedDate { get; set; } = DateTime.Now;
    public virtual DateTime? ModifiedDate { get; set; } = null;
    public virtual string CreatorName { get; set; } = "admin";
    public virtual string? UpdaterName { get; set; } = null;
    public virtual bool IsActive { get; set; } = true;
    public virtual bool IsDelete { get; set; } = false;



}
