using BusinessObjects.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IProgressRepository
    {
        void AddRange(int userId, List<Slot> slots);
        Progress GetProgress(int userId, int slotId);
        void Update(Progress progress);
    }
}
