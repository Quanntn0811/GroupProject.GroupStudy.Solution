using BusinessObjects.EntityModels;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public void Add(Group group) => GroupDAO.Add(group);

        public void Delete(int id) => GroupDAO.Delete(id);

        public void Update(Group group) => GroupDAO.Update(group);

        public IEnumerable<Group> GetGroups() => GroupDAO.GetGroups();

        public IEnumerable<Group> SortByID() => GroupDAO.SortById();

        public IEnumerable<Subject> GetSubjects() => SubjectDAO.GetSubjects();
    }
}
