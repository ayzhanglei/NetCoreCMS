using NetCoreCMS.Framework.Core.Data;
using NetCoreCMS.Framework.Core.Mvc.Repository;
using NetCoreCMS.Modules.StudentBoardResult.Models;

namespace NetCoreCMS.Modules.StudentBoardResult.Repository
{    
    public class SbrGroupRepository : BaseRepository<SbrGroup, long>
    {
        public SbrGroupRepository(NccDbContext context) : base(context)
        {
        }
    }
}
