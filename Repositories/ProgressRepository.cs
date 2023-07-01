using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProgressRepository : IProgressRepository
    {
        public void AddRange(int userId, List<Slot> slots) => ProgressDAO.Instance.AddRange(userId, slots);

        public Progress GetProgress(int userId, int slotId) => ProgressDAO.Instance.GetProgress(userId, slotId);

        public void Update(Progress progress) => ProgressDAO.Instance.Update(progress);
    }
}
