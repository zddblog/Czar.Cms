using General.Entities.SysUser;
namespace General.Framework.Infrasyructure
{
    public interface IWorkContext
    {
        SysUser CurrentUser { get; }
    }
}
