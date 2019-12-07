using General.Entities.SysUser;
using General.Framework.Infrasyructure;

namespace General.Framework
{
    public class WorkContext : IWorkContext
    {
        public SysUser CurrentUser => throw new System.NotImplementedException();
    }
}
